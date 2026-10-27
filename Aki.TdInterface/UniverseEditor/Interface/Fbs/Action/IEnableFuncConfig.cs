using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006660 RID: 26208
	public struct IEnableFuncConfig : IFlatbufferObject
	{
		// Token: 0x1700C2B4 RID: 49844
		// (get) Token: 0x0602D86B RID: 186475 RVA: 0x0063BF17 File Offset: 0x0063A117
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D86C RID: 186476 RVA: 0x0063BF24 File Offset: 0x0063A124
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D86D RID: 186477 RVA: 0x0063BF2C File Offset: 0x0063A12C
		public static IEnableFuncConfig GetRootAsIEnableFuncConfig(ByteBuffer _bb)
		{
			return IEnableFuncConfig.GetRootAsIEnableFuncConfig(_bb, default(IEnableFuncConfig));
		}

		// Token: 0x0602D86E RID: 186478 RVA: 0x0063BF48 File Offset: 0x0063A148
		public static IEnableFuncConfig GetRootAsIEnableFuncConfig(ByteBuffer _bb, IEnableFuncConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D86F RID: 186479 RVA: 0x0063BF65 File Offset: 0x0063A165
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D870 RID: 186480 RVA: 0x0063BF74 File Offset: 0x0063A174
		public IEnableFuncConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2B5 RID: 49845
		// (get) Token: 0x0602D871 RID: 186481 RVA: 0x0063BF84 File Offset: 0x0063A184
		public float DelayDuration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C2B6 RID: 49846
		// (get) Token: 0x0602D872 RID: 186482 RVA: 0x0063BFC4 File Offset: 0x0063A1C4
		public bool IsEnableEsc
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2B7 RID: 49847
		// (get) Token: 0x0602D873 RID: 186483 RVA: 0x0063C004 File Offset: 0x0063A204
		public bool IsEnablePhoto
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2B8 RID: 49848
		// (get) Token: 0x0602D874 RID: 186484 RVA: 0x0063C044 File Offset: 0x0063A244
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D875 RID: 186485 RVA: 0x0063C081 File Offset: 0x0063A281
		public static Offset<IEnableFuncConfig> CreateIEnableFuncConfig(FlatBufferBuilder builder, float DelayDuration = 0f, bool IsEnableEsc = false, bool IsEnablePhoto = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEnableFuncConfig.AddDelayDuration(builder, DelayDuration);
			IEnableFuncConfig.AddNullMask(builder, NullMask);
			IEnableFuncConfig.AddIsEnablePhoto(builder, IsEnablePhoto);
			IEnableFuncConfig.AddIsEnableEsc(builder, IsEnableEsc);
			return IEnableFuncConfig.EndIEnableFuncConfig(builder);
		}

		// Token: 0x0602D876 RID: 186486 RVA: 0x0063C0AD File Offset: 0x0063A2AD
		public static void StartIEnableFuncConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602D877 RID: 186487 RVA: 0x0063C0B6 File Offset: 0x0063A2B6
		public static void AddDelayDuration(FlatBufferBuilder builder, float delayDuration)
		{
			builder.AddFloat(0, delayDuration, 0.0);
		}

		// Token: 0x0602D878 RID: 186488 RVA: 0x0063C0C9 File Offset: 0x0063A2C9
		public static void AddIsEnableEsc(FlatBufferBuilder builder, bool isEnableEsc)
		{
			builder.AddBool(1, isEnableEsc, false);
		}

		// Token: 0x0602D879 RID: 186489 RVA: 0x0063C0D4 File Offset: 0x0063A2D4
		public static void AddIsEnablePhoto(FlatBufferBuilder builder, bool isEnablePhoto)
		{
			builder.AddBool(2, isEnablePhoto, false);
		}

		// Token: 0x0602D87A RID: 186490 RVA: 0x0063C0DF File Offset: 0x0063A2DF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602D87B RID: 186491 RVA: 0x0063C0EA File Offset: 0x0063A2EA
		public static Offset<IEnableFuncConfig> EndIEnableFuncConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEnableFuncConfig>(builder.EndTable());
		}

		// Token: 0x0602D87C RID: 186492 RVA: 0x0063C0F8 File Offset: 0x0063A2F8
		public IEnableFuncConfigT UnPack()
		{
			IEnableFuncConfigT enableFuncConfigT = new IEnableFuncConfigT();
			this.UnPackTo(enableFuncConfigT);
			return enableFuncConfigT;
		}

		// Token: 0x0602D87D RID: 186493 RVA: 0x0063C113 File Offset: 0x0063A313
		public void UnPackTo(IEnableFuncConfigT _o)
		{
			_o.DelayDuration = this.DelayDuration;
			_o.IsEnableEsc = this.IsEnableEsc;
			_o.IsEnablePhoto = this.IsEnablePhoto;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D87E RID: 186494 RVA: 0x0063C148 File Offset: 0x0063A348
		public static Offset<IEnableFuncConfig> Pack(FlatBufferBuilder builder, IEnableFuncConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableFuncConfig>);
			}
			return IEnableFuncConfig.CreateIEnableFuncConfig(builder, _o.DelayDuration, _o.IsEnableEsc, _o.IsEnablePhoto, _o.NullMask);
		}

		// Token: 0x04010D01 RID: 68865
		private Table __p;
	}
}

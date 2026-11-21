using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD1 RID: 27857
	public struct IEnableFuncConfig : IFlatbufferObject
	{
		// Token: 0x1700CC52 RID: 52306
		// (get) Token: 0x0603003C RID: 196668 RVA: 0x00688A7F File Offset: 0x00686C7F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603003D RID: 196669 RVA: 0x00688A8C File Offset: 0x00686C8C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603003E RID: 196670 RVA: 0x00688A94 File Offset: 0x00686C94
		public static IEnableFuncConfig GetRootAsIEnableFuncConfig(ByteBuffer _bb)
		{
			return IEnableFuncConfig.GetRootAsIEnableFuncConfig(_bb, default(IEnableFuncConfig));
		}

		// Token: 0x0603003F RID: 196671 RVA: 0x00688AB0 File Offset: 0x00686CB0
		public static IEnableFuncConfig GetRootAsIEnableFuncConfig(ByteBuffer _bb, IEnableFuncConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030040 RID: 196672 RVA: 0x00688ACD File Offset: 0x00686CCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030041 RID: 196673 RVA: 0x00688ADC File Offset: 0x00686CDC
		public IEnableFuncConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC53 RID: 52307
		// (get) Token: 0x06030042 RID: 196674 RVA: 0x00688AEC File Offset: 0x00686CEC
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

		// Token: 0x1700CC54 RID: 52308
		// (get) Token: 0x06030043 RID: 196675 RVA: 0x00688B2C File Offset: 0x00686D2C
		public bool IsEnableEsc
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC55 RID: 52309
		// (get) Token: 0x06030044 RID: 196676 RVA: 0x00688B6C File Offset: 0x00686D6C
		public bool IsEnablePhoto
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC56 RID: 52310
		// (get) Token: 0x06030045 RID: 196677 RVA: 0x00688BAC File Offset: 0x00686DAC
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

		// Token: 0x06030046 RID: 196678 RVA: 0x00688BE9 File Offset: 0x00686DE9
		public static Offset<IEnableFuncConfig> CreateIEnableFuncConfig(FlatBufferBuilder builder, float DelayDuration = 0f, bool IsEnableEsc = false, bool IsEnablePhoto = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEnableFuncConfig.AddDelayDuration(builder, DelayDuration);
			IEnableFuncConfig.AddNullMask(builder, NullMask);
			IEnableFuncConfig.AddIsEnablePhoto(builder, IsEnablePhoto);
			IEnableFuncConfig.AddIsEnableEsc(builder, IsEnableEsc);
			return IEnableFuncConfig.EndIEnableFuncConfig(builder);
		}

		// Token: 0x06030047 RID: 196679 RVA: 0x00688C15 File Offset: 0x00686E15
		public static void StartIEnableFuncConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030048 RID: 196680 RVA: 0x00688C1E File Offset: 0x00686E1E
		public static void AddDelayDuration(FlatBufferBuilder builder, float delayDuration)
		{
			builder.AddFloat(0, delayDuration, 0.0);
		}

		// Token: 0x06030049 RID: 196681 RVA: 0x00688C31 File Offset: 0x00686E31
		public static void AddIsEnableEsc(FlatBufferBuilder builder, bool isEnableEsc)
		{
			builder.AddBool(1, isEnableEsc, false);
		}

		// Token: 0x0603004A RID: 196682 RVA: 0x00688C3C File Offset: 0x00686E3C
		public static void AddIsEnablePhoto(FlatBufferBuilder builder, bool isEnablePhoto)
		{
			builder.AddBool(2, isEnablePhoto, false);
		}

		// Token: 0x0603004B RID: 196683 RVA: 0x00688C47 File Offset: 0x00686E47
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603004C RID: 196684 RVA: 0x00688C52 File Offset: 0x00686E52
		public static Offset<IEnableFuncConfig> EndIEnableFuncConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEnableFuncConfig>(builder.EndTable());
		}

		// Token: 0x0603004D RID: 196685 RVA: 0x00688C60 File Offset: 0x00686E60
		public IEnableFuncConfigT UnPack()
		{
			IEnableFuncConfigT enableFuncConfigT = new IEnableFuncConfigT();
			this.UnPackTo(enableFuncConfigT);
			return enableFuncConfigT;
		}

		// Token: 0x0603004E RID: 196686 RVA: 0x00688C7B File Offset: 0x00686E7B
		public void UnPackTo(IEnableFuncConfigT _o)
		{
			_o.DelayDuration = this.DelayDuration;
			_o.IsEnableEsc = this.IsEnableEsc;
			_o.IsEnablePhoto = this.IsEnablePhoto;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603004F RID: 196687 RVA: 0x00688CB0 File Offset: 0x00686EB0
		public static Offset<IEnableFuncConfig> Pack(FlatBufferBuilder builder, IEnableFuncConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableFuncConfig>);
			}
			return IEnableFuncConfig.CreateIEnableFuncConfig(builder, _o.DelayDuration, _o.IsEnableEsc, _o.IsEnablePhoto, _o.NullMask);
		}

		// Token: 0x04011B1C RID: 72476
		private Table __p;
	}
}

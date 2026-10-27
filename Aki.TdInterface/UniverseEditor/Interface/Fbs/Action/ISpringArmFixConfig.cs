using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A2 RID: 29090
	public struct ISpringArmFixConfig : IFlatbufferObject
	{
		// Token: 0x1700D806 RID: 55302
		// (get) Token: 0x0603392E RID: 211246 RVA: 0x006F2102 File Offset: 0x006F0302
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603392F RID: 211247 RVA: 0x006F210F File Offset: 0x006F030F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033930 RID: 211248 RVA: 0x006F2118 File Offset: 0x006F0318
		public static ISpringArmFixConfig GetRootAsISpringArmFixConfig(ByteBuffer _bb)
		{
			return ISpringArmFixConfig.GetRootAsISpringArmFixConfig(_bb, default(ISpringArmFixConfig));
		}

		// Token: 0x06033931 RID: 211249 RVA: 0x006F2134 File Offset: 0x006F0334
		public static ISpringArmFixConfig GetRootAsISpringArmFixConfig(ByteBuffer _bb, ISpringArmFixConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033932 RID: 211250 RVA: 0x006F2151 File Offset: 0x006F0351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033933 RID: 211251 RVA: 0x006F2160 File Offset: 0x006F0360
		public ISpringArmFixConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D807 RID: 55303
		// (get) Token: 0x06033934 RID: 211252 RVA: 0x006F2170 File Offset: 0x006F0370
		public bool LeftRightFix
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D808 RID: 55304
		// (get) Token: 0x06033935 RID: 211253 RVA: 0x006F21B0 File Offset: 0x006F03B0
		public bool ForwardBackFix
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D809 RID: 55305
		// (get) Token: 0x06033936 RID: 211254 RVA: 0x006F21F0 File Offset: 0x006F03F0
		public bool UpDownFix
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D80A RID: 55306
		// (get) Token: 0x06033937 RID: 211255 RVA: 0x006F2230 File Offset: 0x006F0430
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

		// Token: 0x06033938 RID: 211256 RVA: 0x006F226D File Offset: 0x006F046D
		public static Offset<ISpringArmFixConfig> CreateISpringArmFixConfig(FlatBufferBuilder builder, bool LeftRightFix = false, bool ForwardBackFix = false, bool UpDownFix = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISpringArmFixConfig.AddNullMask(builder, NullMask);
			ISpringArmFixConfig.AddUpDownFix(builder, UpDownFix);
			ISpringArmFixConfig.AddForwardBackFix(builder, ForwardBackFix);
			ISpringArmFixConfig.AddLeftRightFix(builder, LeftRightFix);
			return ISpringArmFixConfig.EndISpringArmFixConfig(builder);
		}

		// Token: 0x06033939 RID: 211257 RVA: 0x006F2299 File Offset: 0x006F0499
		public static void StartISpringArmFixConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603393A RID: 211258 RVA: 0x006F22A2 File Offset: 0x006F04A2
		public static void AddLeftRightFix(FlatBufferBuilder builder, bool leftRightFix)
		{
			builder.AddBool(0, leftRightFix, false);
		}

		// Token: 0x0603393B RID: 211259 RVA: 0x006F22AD File Offset: 0x006F04AD
		public static void AddForwardBackFix(FlatBufferBuilder builder, bool forwardBackFix)
		{
			builder.AddBool(1, forwardBackFix, false);
		}

		// Token: 0x0603393C RID: 211260 RVA: 0x006F22B8 File Offset: 0x006F04B8
		public static void AddUpDownFix(FlatBufferBuilder builder, bool upDownFix)
		{
			builder.AddBool(2, upDownFix, false);
		}

		// Token: 0x0603393D RID: 211261 RVA: 0x006F22C3 File Offset: 0x006F04C3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603393E RID: 211262 RVA: 0x006F22CE File Offset: 0x006F04CE
		public static Offset<ISpringArmFixConfig> EndISpringArmFixConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpringArmFixConfig>(builder.EndTable());
		}

		// Token: 0x0603393F RID: 211263 RVA: 0x006F22DC File Offset: 0x006F04DC
		public ISpringArmFixConfigT UnPack()
		{
			ISpringArmFixConfigT springArmFixConfigT = new ISpringArmFixConfigT();
			this.UnPackTo(springArmFixConfigT);
			return springArmFixConfigT;
		}

		// Token: 0x06033940 RID: 211264 RVA: 0x006F22F7 File Offset: 0x006F04F7
		public void UnPackTo(ISpringArmFixConfigT _o)
		{
			_o.LeftRightFix = this.LeftRightFix;
			_o.ForwardBackFix = this.ForwardBackFix;
			_o.UpDownFix = this.UpDownFix;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033941 RID: 211265 RVA: 0x006F232C File Offset: 0x006F052C
		public static Offset<ISpringArmFixConfig> Pack(FlatBufferBuilder builder, ISpringArmFixConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpringArmFixConfig>);
			}
			return ISpringArmFixConfig.CreateISpringArmFixConfig(builder, _o.LeftRightFix, _o.ForwardBackFix, _o.UpDownFix, _o.NullMask);
		}

		// Token: 0x04011C68 RID: 72808
		private Table __p;
	}
}

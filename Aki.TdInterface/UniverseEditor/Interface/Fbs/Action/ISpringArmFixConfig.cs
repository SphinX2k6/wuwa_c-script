using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007977 RID: 31095
	public struct ISpringArmFixConfig : IFlatbufferObject
	{
		// Token: 0x1700E3FD RID: 58365
		// (get) Token: 0x06036C2C RID: 224300 RVA: 0x007533D0 File Offset: 0x007515D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036C2D RID: 224301 RVA: 0x007533DD File Offset: 0x007515DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036C2E RID: 224302 RVA: 0x007533E4 File Offset: 0x007515E4
		public static ISpringArmFixConfig GetRootAsISpringArmFixConfig(ByteBuffer _bb)
		{
			return ISpringArmFixConfig.GetRootAsISpringArmFixConfig(_bb, default(ISpringArmFixConfig));
		}

		// Token: 0x06036C2F RID: 224303 RVA: 0x00753400 File Offset: 0x00751600
		public static ISpringArmFixConfig GetRootAsISpringArmFixConfig(ByteBuffer _bb, ISpringArmFixConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036C30 RID: 224304 RVA: 0x0075341D File Offset: 0x0075161D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036C31 RID: 224305 RVA: 0x0075342C File Offset: 0x0075162C
		public ISpringArmFixConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3FE RID: 58366
		// (get) Token: 0x06036C32 RID: 224306 RVA: 0x0075343C File Offset: 0x0075163C
		public bool LeftRightFix
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E3FF RID: 58367
		// (get) Token: 0x06036C33 RID: 224307 RVA: 0x0075347C File Offset: 0x0075167C
		public bool ForwardBackFix
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E400 RID: 58368
		// (get) Token: 0x06036C34 RID: 224308 RVA: 0x007534BC File Offset: 0x007516BC
		public bool UpDownFix
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E401 RID: 58369
		// (get) Token: 0x06036C35 RID: 224309 RVA: 0x007534FC File Offset: 0x007516FC
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

		// Token: 0x06036C36 RID: 224310 RVA: 0x00753539 File Offset: 0x00751739
		public static Offset<ISpringArmFixConfig> CreateISpringArmFixConfig(FlatBufferBuilder builder, bool LeftRightFix = false, bool ForwardBackFix = false, bool UpDownFix = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISpringArmFixConfig.AddNullMask(builder, NullMask);
			ISpringArmFixConfig.AddUpDownFix(builder, UpDownFix);
			ISpringArmFixConfig.AddForwardBackFix(builder, ForwardBackFix);
			ISpringArmFixConfig.AddLeftRightFix(builder, LeftRightFix);
			return ISpringArmFixConfig.EndISpringArmFixConfig(builder);
		}

		// Token: 0x06036C37 RID: 224311 RVA: 0x00753565 File Offset: 0x00751765
		public static void StartISpringArmFixConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036C38 RID: 224312 RVA: 0x0075356E File Offset: 0x0075176E
		public static void AddLeftRightFix(FlatBufferBuilder builder, bool leftRightFix)
		{
			builder.AddBool(0, leftRightFix, false);
		}

		// Token: 0x06036C39 RID: 224313 RVA: 0x00753579 File Offset: 0x00751779
		public static void AddForwardBackFix(FlatBufferBuilder builder, bool forwardBackFix)
		{
			builder.AddBool(1, forwardBackFix, false);
		}

		// Token: 0x06036C3A RID: 224314 RVA: 0x00753584 File Offset: 0x00751784
		public static void AddUpDownFix(FlatBufferBuilder builder, bool upDownFix)
		{
			builder.AddBool(2, upDownFix, false);
		}

		// Token: 0x06036C3B RID: 224315 RVA: 0x0075358F File Offset: 0x0075178F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036C3C RID: 224316 RVA: 0x0075359A File Offset: 0x0075179A
		public static Offset<ISpringArmFixConfig> EndISpringArmFixConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpringArmFixConfig>(builder.EndTable());
		}

		// Token: 0x06036C3D RID: 224317 RVA: 0x007535A8 File Offset: 0x007517A8
		public ISpringArmFixConfigT UnPack()
		{
			ISpringArmFixConfigT springArmFixConfigT = new ISpringArmFixConfigT();
			this.UnPackTo(springArmFixConfigT);
			return springArmFixConfigT;
		}

		// Token: 0x06036C3E RID: 224318 RVA: 0x007535C3 File Offset: 0x007517C3
		public void UnPackTo(ISpringArmFixConfigT _o)
		{
			_o.LeftRightFix = this.LeftRightFix;
			_o.ForwardBackFix = this.ForwardBackFix;
			_o.UpDownFix = this.UpDownFix;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036C3F RID: 224319 RVA: 0x007535F8 File Offset: 0x007517F8
		public static Offset<ISpringArmFixConfig> Pack(FlatBufferBuilder builder, ISpringArmFixConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpringArmFixConfig>);
			}
			return ISpringArmFixConfig.CreateISpringArmFixConfig(builder, _o.LeftRightFix, _o.ForwardBackFix, _o.UpDownFix, _o.NullMask);
		}

		// Token: 0x04012C69 RID: 76905
		private Table __p;
	}
}

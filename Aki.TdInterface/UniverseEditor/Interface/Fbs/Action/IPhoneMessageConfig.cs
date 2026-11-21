using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200741B RID: 29723
	public struct IPhoneMessageConfig : IFlatbufferObject
	{
		// Token: 0x1700DA55 RID: 55893
		// (get) Token: 0x0603400A RID: 213002 RVA: 0x007024A6 File Offset: 0x007006A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603400B RID: 213003 RVA: 0x007024B3 File Offset: 0x007006B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603400C RID: 213004 RVA: 0x007024BC File Offset: 0x007006BC
		public static IPhoneMessageConfig GetRootAsIPhoneMessageConfig(ByteBuffer _bb)
		{
			return IPhoneMessageConfig.GetRootAsIPhoneMessageConfig(_bb, default(IPhoneMessageConfig));
		}

		// Token: 0x0603400D RID: 213005 RVA: 0x007024D8 File Offset: 0x007006D8
		public static IPhoneMessageConfig GetRootAsIPhoneMessageConfig(ByteBuffer _bb, IPhoneMessageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603400E RID: 213006 RVA: 0x007024F5 File Offset: 0x007006F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603400F RID: 213007 RVA: 0x00702504 File Offset: 0x00700704
		public IPhoneMessageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA56 RID: 55894
		// (get) Token: 0x06034010 RID: 213008 RVA: 0x00702514 File Offset: 0x00700714
		public bool IsJumpToFirstOption
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DA57 RID: 55895
		// (get) Token: 0x06034011 RID: 213009 RVA: 0x00702554 File Offset: 0x00700754
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034012 RID: 213010 RVA: 0x00702590 File Offset: 0x00700790
		public static Offset<IPhoneMessageConfig> CreateIPhoneMessageConfig(FlatBufferBuilder builder, bool IsJumpToFirstOption = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IPhoneMessageConfig.AddNullMask(builder, NullMask);
			IPhoneMessageConfig.AddIsJumpToFirstOption(builder, IsJumpToFirstOption);
			return IPhoneMessageConfig.EndIPhoneMessageConfig(builder);
		}

		// Token: 0x06034013 RID: 213011 RVA: 0x007025AD File Offset: 0x007007AD
		public static void StartIPhoneMessageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034014 RID: 213012 RVA: 0x007025B6 File Offset: 0x007007B6
		public static void AddIsJumpToFirstOption(FlatBufferBuilder builder, bool isJumpToFirstOption)
		{
			builder.AddBool(0, isJumpToFirstOption, false);
		}

		// Token: 0x06034015 RID: 213013 RVA: 0x007025C1 File Offset: 0x007007C1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06034016 RID: 213014 RVA: 0x007025CC File Offset: 0x007007CC
		public static Offset<IPhoneMessageConfig> EndIPhoneMessageConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneMessageConfig>(builder.EndTable());
		}

		// Token: 0x06034017 RID: 213015 RVA: 0x007025DC File Offset: 0x007007DC
		public IPhoneMessageConfigT UnPack()
		{
			IPhoneMessageConfigT phoneMessageConfigT = new IPhoneMessageConfigT();
			this.UnPackTo(phoneMessageConfigT);
			return phoneMessageConfigT;
		}

		// Token: 0x06034018 RID: 213016 RVA: 0x007025F7 File Offset: 0x007007F7
		public void UnPackTo(IPhoneMessageConfigT _o)
		{
			_o.IsJumpToFirstOption = this.IsJumpToFirstOption;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034019 RID: 213017 RVA: 0x00702614 File Offset: 0x00700814
		public static Offset<IPhoneMessageConfig> Pack(FlatBufferBuilder builder, IPhoneMessageConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhoneMessageConfig>);
			}
			return IPhoneMessageConfig.CreateIPhoneMessageConfig(builder, _o.IsJumpToFirstOption, _o.NullMask);
		}

		// Token: 0x0401256E RID: 75118
		private Table __p;
	}
}

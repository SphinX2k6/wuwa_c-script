using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074AB RID: 29867
	public struct IUiStyleBaseOfLevelD : IFlatbufferObject
	{
		// Token: 0x1700E2B8 RID: 58040
		// (get) Token: 0x060364CE RID: 222414 RVA: 0x0076166A File Offset: 0x0075F86A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060364CF RID: 222415 RVA: 0x00761677 File Offset: 0x0075F877
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060364D0 RID: 222416 RVA: 0x00761680 File Offset: 0x0075F880
		public static IUiStyleBaseOfLevelD GetRootAsIUiStyleBaseOfLevelD(ByteBuffer _bb)
		{
			return IUiStyleBaseOfLevelD.GetRootAsIUiStyleBaseOfLevelD(_bb, default(IUiStyleBaseOfLevelD));
		}

		// Token: 0x060364D1 RID: 222417 RVA: 0x0076169C File Offset: 0x0075F89C
		public static IUiStyleBaseOfLevelD GetRootAsIUiStyleBaseOfLevelD(ByteBuffer _bb, IUiStyleBaseOfLevelD obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060364D2 RID: 222418 RVA: 0x007616B9 File Offset: 0x0075F8B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060364D3 RID: 222419 RVA: 0x007616C8 File Offset: 0x0075F8C8
		public IUiStyleBaseOfLevelD __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2B9 RID: 58041
		// (get) Token: 0x060364D4 RID: 222420 RVA: 0x007616D8 File Offset: 0x0075F8D8
		public EUiStyleTypeOfLevelD Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUiStyleTypeOfLevelD.GiantSubtitle;
				}
				return (EUiStyleTypeOfLevelD)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060364D5 RID: 222421 RVA: 0x00761714 File Offset: 0x0075F914
		public static Offset<IUiStyleBaseOfLevelD> CreateIUiStyleBaseOfLevelD(FlatBufferBuilder builder, EUiStyleTypeOfLevelD Type = EUiStyleTypeOfLevelD.GiantSubtitle)
		{
			builder.StartTable(1);
			IUiStyleBaseOfLevelD.AddType(builder, Type);
			return IUiStyleBaseOfLevelD.EndIUiStyleBaseOfLevelD(builder);
		}

		// Token: 0x060364D6 RID: 222422 RVA: 0x0076172A File Offset: 0x0075F92A
		public static void StartIUiStyleBaseOfLevelD(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060364D7 RID: 222423 RVA: 0x00761733 File Offset: 0x0075F933
		public static void AddType(FlatBufferBuilder builder, EUiStyleTypeOfLevelD type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060364D8 RID: 222424 RVA: 0x0076173E File Offset: 0x0075F93E
		public static Offset<IUiStyleBaseOfLevelD> EndIUiStyleBaseOfLevelD(FlatBufferBuilder builder)
		{
			return new Offset<IUiStyleBaseOfLevelD>(builder.EndTable());
		}

		// Token: 0x060364D9 RID: 222425 RVA: 0x0076174C File Offset: 0x0075F94C
		public IUiStyleBaseOfLevelDT UnPack()
		{
			IUiStyleBaseOfLevelDT uiStyleBaseOfLevelDT = new IUiStyleBaseOfLevelDT();
			this.UnPackTo(uiStyleBaseOfLevelDT);
			return uiStyleBaseOfLevelDT;
		}

		// Token: 0x060364DA RID: 222426 RVA: 0x00761767 File Offset: 0x0075F967
		public void UnPackTo(IUiStyleBaseOfLevelDT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060364DB RID: 222427 RVA: 0x00761778 File Offset: 0x0075F978
		public static Offset<IUiStyleBaseOfLevelD> Pack(FlatBufferBuilder builder, IUiStyleBaseOfLevelDT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUiStyleBaseOfLevelD>);
			}
			return IUiStyleBaseOfLevelD.CreateIUiStyleBaseOfLevelD(builder, _o.Type);
		}

		// Token: 0x0401236E RID: 74606
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007830 RID: 30768
	public struct ISetRegionMpc : IFlatbufferObject
	{
		// Token: 0x1700E1BD RID: 57789
		// (get) Token: 0x060361B5 RID: 221621 RVA: 0x0073FC82 File Offset: 0x0073DE82
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060361B6 RID: 221622 RVA: 0x0073FC8F File Offset: 0x0073DE8F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060361B7 RID: 221623 RVA: 0x0073FC98 File Offset: 0x0073DE98
		public static ISetRegionMpc GetRootAsISetRegionMpc(ByteBuffer _bb)
		{
			return ISetRegionMpc.GetRootAsISetRegionMpc(_bb, default(ISetRegionMpc));
		}

		// Token: 0x060361B8 RID: 221624 RVA: 0x0073FCB4 File Offset: 0x0073DEB4
		public static ISetRegionMpc GetRootAsISetRegionMpc(ByteBuffer _bb, ISetRegionMpc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060361B9 RID: 221625 RVA: 0x0073FCD1 File Offset: 0x0073DED1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060361BA RID: 221626 RVA: 0x0073FCE0 File Offset: 0x0073DEE0
		public ISetRegionMpc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1BE RID: 57790
		// (get) Token: 0x060361BB RID: 221627 RVA: 0x0073FCF0 File Offset: 0x0073DEF0
		public ERegionConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERegionConfigType.Mpc;
				}
				return (ERegionConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E1BF RID: 57791
		// (get) Token: 0x060361BC RID: 221628 RVA: 0x0073FD2C File Offset: 0x0073DF2C
		public int RegionMpcId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060361BD RID: 221629 RVA: 0x0073FD68 File Offset: 0x0073DF68
		public static Offset<ISetRegionMpc> CreateISetRegionMpc(FlatBufferBuilder builder, ERegionConfigType Type = ERegionConfigType.Mpc, int RegionMpcId = 0)
		{
			builder.StartTable(2);
			ISetRegionMpc.AddRegionMpcId(builder, RegionMpcId);
			ISetRegionMpc.AddType(builder, Type);
			return ISetRegionMpc.EndISetRegionMpc(builder);
		}

		// Token: 0x060361BE RID: 221630 RVA: 0x0073FD85 File Offset: 0x0073DF85
		public static void StartISetRegionMpc(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060361BF RID: 221631 RVA: 0x0073FD8E File Offset: 0x0073DF8E
		public static void AddType(FlatBufferBuilder builder, ERegionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060361C0 RID: 221632 RVA: 0x0073FD99 File Offset: 0x0073DF99
		public static void AddRegionMpcId(FlatBufferBuilder builder, int regionMpcId)
		{
			builder.AddInt(1, regionMpcId, 0);
		}

		// Token: 0x060361C1 RID: 221633 RVA: 0x0073FDA4 File Offset: 0x0073DFA4
		public static Offset<ISetRegionMpc> EndISetRegionMpc(FlatBufferBuilder builder)
		{
			return new Offset<ISetRegionMpc>(builder.EndTable());
		}

		// Token: 0x060361C2 RID: 221634 RVA: 0x0073FDB4 File Offset: 0x0073DFB4
		public ISetRegionMpcT UnPack()
		{
			ISetRegionMpcT setRegionMpcT = new ISetRegionMpcT();
			this.UnPackTo(setRegionMpcT);
			return setRegionMpcT;
		}

		// Token: 0x060361C3 RID: 221635 RVA: 0x0073FDCF File Offset: 0x0073DFCF
		public void UnPackTo(ISetRegionMpcT _o)
		{
			_o.Type = this.Type;
			_o.RegionMpcId = this.RegionMpcId;
		}

		// Token: 0x060361C4 RID: 221636 RVA: 0x0073FDEC File Offset: 0x0073DFEC
		public static Offset<ISetRegionMpc> Pack(FlatBufferBuilder builder, ISetRegionMpcT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetRegionMpc>);
			}
			return ISetRegionMpc.CreateISetRegionMpc(builder, _o.Type, _o.RegionMpcId);
		}

		// Token: 0x04012AB5 RID: 76469
		private Table __p;
	}
}

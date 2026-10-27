using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043AA RID: 17322
	public struct INpcOccupationData : IFlatbufferObject
	{
		// Token: 0x17007A72 RID: 31346
		// (get) Token: 0x06019CA8 RID: 105640 RVA: 0x003B1328 File Offset: 0x003AF528
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019CA9 RID: 105641 RVA: 0x003B1335 File Offset: 0x003AF535
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019CAA RID: 105642 RVA: 0x003B133C File Offset: 0x003AF53C
		public static INpcOccupationData GetRootAsINpcOccupationData(ByteBuffer _bb)
		{
			return INpcOccupationData.GetRootAsINpcOccupationData(_bb, default(INpcOccupationData));
		}

		// Token: 0x06019CAB RID: 105643 RVA: 0x003B1358 File Offset: 0x003AF558
		public static INpcOccupationData GetRootAsINpcOccupationData(ByteBuffer _bb, INpcOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019CAC RID: 105644 RVA: 0x003B1375 File Offset: 0x003AF575
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019CAD RID: 105645 RVA: 0x003B1384 File Offset: 0x003AF584
		public INpcOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A73 RID: 31347
		// (get) Token: 0x06019CAE RID: 105646 RVA: 0x003B1394 File Offset: 0x003AF594
		public EOccupationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOccupationType.Npc;
				}
				return (EOccupationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019CAF RID: 105647 RVA: 0x003B13D0 File Offset: 0x003AF5D0
		public static Offset<INpcOccupationData> CreateINpcOccupationData(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc)
		{
			builder.StartTable(1);
			INpcOccupationData.AddType(builder, Type);
			return INpcOccupationData.EndINpcOccupationData(builder);
		}

		// Token: 0x06019CB0 RID: 105648 RVA: 0x003B13E6 File Offset: 0x003AF5E6
		public static void StartINpcOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019CB1 RID: 105649 RVA: 0x003B13EF File Offset: 0x003AF5EF
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019CB2 RID: 105650 RVA: 0x003B13FA File Offset: 0x003AF5FA
		public static Offset<INpcOccupationData> EndINpcOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<INpcOccupationData>(builder.EndTable());
		}

		// Token: 0x06019CB3 RID: 105651 RVA: 0x003B1408 File Offset: 0x003AF608
		public INpcOccupationDataT UnPack()
		{
			INpcOccupationDataT npcOccupationDataT = new INpcOccupationDataT();
			this.UnPackTo(npcOccupationDataT);
			return npcOccupationDataT;
		}

		// Token: 0x06019CB4 RID: 105652 RVA: 0x003B1423 File Offset: 0x003AF623
		public void UnPackTo(INpcOccupationDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019CB5 RID: 105653 RVA: 0x003B1434 File Offset: 0x003AF634
		public static Offset<INpcOccupationData> Pack(FlatBufferBuilder builder, INpcOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcOccupationData>);
			}
			return INpcOccupationData.CreateINpcOccupationData(builder, _o.Type);
		}

		// Token: 0x0400C1E0 RID: 49632
		private Table __p;
	}
}

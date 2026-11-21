using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200480C RID: 18444
	public struct INpcOccupationData : IFlatbufferObject
	{
		// Token: 0x170080A7 RID: 32935
		// (get) Token: 0x0601B436 RID: 111670 RVA: 0x003DCD50 File Offset: 0x003DAF50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B437 RID: 111671 RVA: 0x003DCD5D File Offset: 0x003DAF5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B438 RID: 111672 RVA: 0x003DCD64 File Offset: 0x003DAF64
		public static INpcOccupationData GetRootAsINpcOccupationData(ByteBuffer _bb)
		{
			return INpcOccupationData.GetRootAsINpcOccupationData(_bb, default(INpcOccupationData));
		}

		// Token: 0x0601B439 RID: 111673 RVA: 0x003DCD80 File Offset: 0x003DAF80
		public static INpcOccupationData GetRootAsINpcOccupationData(ByteBuffer _bb, INpcOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B43A RID: 111674 RVA: 0x003DCD9D File Offset: 0x003DAF9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B43B RID: 111675 RVA: 0x003DCDAC File Offset: 0x003DAFAC
		public INpcOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080A8 RID: 32936
		// (get) Token: 0x0601B43C RID: 111676 RVA: 0x003DCDBC File Offset: 0x003DAFBC
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

		// Token: 0x0601B43D RID: 111677 RVA: 0x003DCDF8 File Offset: 0x003DAFF8
		public static Offset<INpcOccupationData> CreateINpcOccupationData(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc)
		{
			builder.StartTable(1);
			INpcOccupationData.AddType(builder, Type);
			return INpcOccupationData.EndINpcOccupationData(builder);
		}

		// Token: 0x0601B43E RID: 111678 RVA: 0x003DCE0E File Offset: 0x003DB00E
		public static void StartINpcOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B43F RID: 111679 RVA: 0x003DCE17 File Offset: 0x003DB017
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B440 RID: 111680 RVA: 0x003DCE22 File Offset: 0x003DB022
		public static Offset<INpcOccupationData> EndINpcOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<INpcOccupationData>(builder.EndTable());
		}

		// Token: 0x0601B441 RID: 111681 RVA: 0x003DCE30 File Offset: 0x003DB030
		public INpcOccupationDataT UnPack()
		{
			INpcOccupationDataT npcOccupationDataT = new INpcOccupationDataT();
			this.UnPackTo(npcOccupationDataT);
			return npcOccupationDataT;
		}

		// Token: 0x0601B442 RID: 111682 RVA: 0x003DCE4B File Offset: 0x003DB04B
		public void UnPackTo(INpcOccupationDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B443 RID: 111683 RVA: 0x003DCE5C File Offset: 0x003DB05C
		public static Offset<INpcOccupationData> Pack(FlatBufferBuilder builder, INpcOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcOccupationData>);
			}
			return INpcOccupationData.CreateINpcOccupationData(builder, _o.Type);
		}

		// Token: 0x0400CBFF RID: 52223
		private Table __p;
	}
}

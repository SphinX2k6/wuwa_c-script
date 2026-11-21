using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047F7 RID: 18423
	public struct IClosedSegmentOccupationData : IFlatbufferObject
	{
		// Token: 0x17008080 RID: 32896
		// (get) Token: 0x0601B36F RID: 111471 RVA: 0x003DB3B6 File Offset: 0x003D95B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B370 RID: 111472 RVA: 0x003DB3C3 File Offset: 0x003D95C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B371 RID: 111473 RVA: 0x003DB3CC File Offset: 0x003D95CC
		public static IClosedSegmentOccupationData GetRootAsIClosedSegmentOccupationData(ByteBuffer _bb)
		{
			return IClosedSegmentOccupationData.GetRootAsIClosedSegmentOccupationData(_bb, default(IClosedSegmentOccupationData));
		}

		// Token: 0x0601B372 RID: 111474 RVA: 0x003DB3E8 File Offset: 0x003D95E8
		public static IClosedSegmentOccupationData GetRootAsIClosedSegmentOccupationData(ByteBuffer _bb, IClosedSegmentOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B373 RID: 111475 RVA: 0x003DB405 File Offset: 0x003D9605
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B374 RID: 111476 RVA: 0x003DB414 File Offset: 0x003D9614
		public IClosedSegmentOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008081 RID: 32897
		// (get) Token: 0x0601B375 RID: 111477 RVA: 0x003DB424 File Offset: 0x003D9624
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

		// Token: 0x0601B376 RID: 111478 RVA: 0x003DB460 File Offset: 0x003D9660
		public static Offset<IClosedSegmentOccupationData> CreateIClosedSegmentOccupationData(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc)
		{
			builder.StartTable(1);
			IClosedSegmentOccupationData.AddType(builder, Type);
			return IClosedSegmentOccupationData.EndIClosedSegmentOccupationData(builder);
		}

		// Token: 0x0601B377 RID: 111479 RVA: 0x003DB476 File Offset: 0x003D9676
		public static void StartIClosedSegmentOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B378 RID: 111480 RVA: 0x003DB47F File Offset: 0x003D967F
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B379 RID: 111481 RVA: 0x003DB48A File Offset: 0x003D968A
		public static Offset<IClosedSegmentOccupationData> EndIClosedSegmentOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<IClosedSegmentOccupationData>(builder.EndTable());
		}

		// Token: 0x0601B37A RID: 111482 RVA: 0x003DB498 File Offset: 0x003D9698
		public IClosedSegmentOccupationDataT UnPack()
		{
			IClosedSegmentOccupationDataT closedSegmentOccupationDataT = new IClosedSegmentOccupationDataT();
			this.UnPackTo(closedSegmentOccupationDataT);
			return closedSegmentOccupationDataT;
		}

		// Token: 0x0601B37B RID: 111483 RVA: 0x003DB4B3 File Offset: 0x003D96B3
		public void UnPackTo(IClosedSegmentOccupationDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B37C RID: 111484 RVA: 0x003DB4C4 File Offset: 0x003D96C4
		public static Offset<IClosedSegmentOccupationData> Pack(FlatBufferBuilder builder, IClosedSegmentOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClosedSegmentOccupationData>);
			}
			return IClosedSegmentOccupationData.CreateIClosedSegmentOccupationData(builder, _o.Type);
		}

		// Token: 0x0400CBE8 RID: 52200
		private Table __p;
	}
}

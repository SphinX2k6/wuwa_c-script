using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200482A RID: 18474
	public struct ISeasonRotationOccupationData : IFlatbufferObject
	{
		// Token: 0x170080E7 RID: 32999
		// (get) Token: 0x0601B58D RID: 112013 RVA: 0x003DFB65 File Offset: 0x003DDD65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B58E RID: 112014 RVA: 0x003DFB72 File Offset: 0x003DDD72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B58F RID: 112015 RVA: 0x003DFB7C File Offset: 0x003DDD7C
		public static ISeasonRotationOccupationData GetRootAsISeasonRotationOccupationData(ByteBuffer _bb)
		{
			return ISeasonRotationOccupationData.GetRootAsISeasonRotationOccupationData(_bb, default(ISeasonRotationOccupationData));
		}

		// Token: 0x0601B590 RID: 112016 RVA: 0x003DFB98 File Offset: 0x003DDD98
		public static ISeasonRotationOccupationData GetRootAsISeasonRotationOccupationData(ByteBuffer _bb, ISeasonRotationOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B591 RID: 112017 RVA: 0x003DFBB5 File Offset: 0x003DDDB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B592 RID: 112018 RVA: 0x003DFBC4 File Offset: 0x003DDDC4
		public ISeasonRotationOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080E8 RID: 33000
		// (get) Token: 0x0601B593 RID: 112019 RVA: 0x003DFBD4 File Offset: 0x003DDDD4
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

		// Token: 0x0601B594 RID: 112020 RVA: 0x003DFC10 File Offset: 0x003DDE10
		public static Offset<ISeasonRotationOccupationData> CreateISeasonRotationOccupationData(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc)
		{
			builder.StartTable(1);
			ISeasonRotationOccupationData.AddType(builder, Type);
			return ISeasonRotationOccupationData.EndISeasonRotationOccupationData(builder);
		}

		// Token: 0x0601B595 RID: 112021 RVA: 0x003DFC26 File Offset: 0x003DDE26
		public static void StartISeasonRotationOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B596 RID: 112022 RVA: 0x003DFC2F File Offset: 0x003DDE2F
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B597 RID: 112023 RVA: 0x003DFC3A File Offset: 0x003DDE3A
		public static Offset<ISeasonRotationOccupationData> EndISeasonRotationOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<ISeasonRotationOccupationData>(builder.EndTable());
		}

		// Token: 0x0601B598 RID: 112024 RVA: 0x003DFC48 File Offset: 0x003DDE48
		public ISeasonRotationOccupationDataT UnPack()
		{
			ISeasonRotationOccupationDataT seasonRotationOccupationDataT = new ISeasonRotationOccupationDataT();
			this.UnPackTo(seasonRotationOccupationDataT);
			return seasonRotationOccupationDataT;
		}

		// Token: 0x0601B599 RID: 112025 RVA: 0x003DFC63 File Offset: 0x003DDE63
		public void UnPackTo(ISeasonRotationOccupationDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B59A RID: 112026 RVA: 0x003DFC74 File Offset: 0x003DDE74
		public static Offset<ISeasonRotationOccupationData> Pack(FlatBufferBuilder builder, ISeasonRotationOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISeasonRotationOccupationData>);
			}
			return ISeasonRotationOccupationData.CreateISeasonRotationOccupationData(builder, _o.Type);
		}

		// Token: 0x0400CC35 RID: 52277
		private Table __p;
	}
}

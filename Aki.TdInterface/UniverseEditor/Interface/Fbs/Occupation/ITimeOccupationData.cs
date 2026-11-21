using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004833 RID: 18483
	public struct ITimeOccupationData : IFlatbufferObject
	{
		// Token: 0x170080FA RID: 33018
		// (get) Token: 0x0601B5ED RID: 112109 RVA: 0x003E05F7 File Offset: 0x003DE7F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B5EE RID: 112110 RVA: 0x003E0604 File Offset: 0x003DE804
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B5EF RID: 112111 RVA: 0x003E060C File Offset: 0x003DE80C
		public static ITimeOccupationData GetRootAsITimeOccupationData(ByteBuffer _bb)
		{
			return ITimeOccupationData.GetRootAsITimeOccupationData(_bb, default(ITimeOccupationData));
		}

		// Token: 0x0601B5F0 RID: 112112 RVA: 0x003E0628 File Offset: 0x003DE828
		public static ITimeOccupationData GetRootAsITimeOccupationData(ByteBuffer _bb, ITimeOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B5F1 RID: 112113 RVA: 0x003E0645 File Offset: 0x003DE845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B5F2 RID: 112114 RVA: 0x003E0654 File Offset: 0x003DE854
		public ITimeOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080FB RID: 33019
		// (get) Token: 0x0601B5F3 RID: 112115 RVA: 0x003E0664 File Offset: 0x003DE864
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

		// Token: 0x0601B5F4 RID: 112116 RVA: 0x003E06A0 File Offset: 0x003DE8A0
		public static Offset<ITimeOccupationData> CreateITimeOccupationData(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc)
		{
			builder.StartTable(1);
			ITimeOccupationData.AddType(builder, Type);
			return ITimeOccupationData.EndITimeOccupationData(builder);
		}

		// Token: 0x0601B5F5 RID: 112117 RVA: 0x003E06B6 File Offset: 0x003DE8B6
		public static void StartITimeOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B5F6 RID: 112118 RVA: 0x003E06BF File Offset: 0x003DE8BF
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B5F7 RID: 112119 RVA: 0x003E06CA File Offset: 0x003DE8CA
		public static Offset<ITimeOccupationData> EndITimeOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<ITimeOccupationData>(builder.EndTable());
		}

		// Token: 0x0601B5F8 RID: 112120 RVA: 0x003E06D8 File Offset: 0x003DE8D8
		public ITimeOccupationDataT UnPack()
		{
			ITimeOccupationDataT timeOccupationDataT = new ITimeOccupationDataT();
			this.UnPackTo(timeOccupationDataT);
			return timeOccupationDataT;
		}

		// Token: 0x0601B5F9 RID: 112121 RVA: 0x003E06F3 File Offset: 0x003DE8F3
		public void UnPackTo(ITimeOccupationDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B5FA RID: 112122 RVA: 0x003E0704 File Offset: 0x003DE904
		public static Offset<ITimeOccupationData> Pack(FlatBufferBuilder builder, ITimeOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeOccupationData>);
			}
			return ITimeOccupationData.CreateITimeOccupationData(builder, _o.Type);
		}

		// Token: 0x0400CC40 RID: 52288
		private Table __p;
	}
}

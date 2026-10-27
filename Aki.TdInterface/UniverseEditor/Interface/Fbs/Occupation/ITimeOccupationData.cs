using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043CE RID: 17358
	public struct ITimeOccupationData : IFlatbufferObject
	{
		// Token: 0x17007AC0 RID: 31424
		// (get) Token: 0x06019E40 RID: 106048 RVA: 0x003B47E7 File Offset: 0x003B29E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019E41 RID: 106049 RVA: 0x003B47F4 File Offset: 0x003B29F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019E42 RID: 106050 RVA: 0x003B47FC File Offset: 0x003B29FC
		public static ITimeOccupationData GetRootAsITimeOccupationData(ByteBuffer _bb)
		{
			return ITimeOccupationData.GetRootAsITimeOccupationData(_bb, default(ITimeOccupationData));
		}

		// Token: 0x06019E43 RID: 106051 RVA: 0x003B4818 File Offset: 0x003B2A18
		public static ITimeOccupationData GetRootAsITimeOccupationData(ByteBuffer _bb, ITimeOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019E44 RID: 106052 RVA: 0x003B4835 File Offset: 0x003B2A35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019E45 RID: 106053 RVA: 0x003B4844 File Offset: 0x003B2A44
		public ITimeOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AC1 RID: 31425
		// (get) Token: 0x06019E46 RID: 106054 RVA: 0x003B4854 File Offset: 0x003B2A54
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

		// Token: 0x06019E47 RID: 106055 RVA: 0x003B4890 File Offset: 0x003B2A90
		public static Offset<ITimeOccupationData> CreateITimeOccupationData(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc)
		{
			builder.StartTable(1);
			ITimeOccupationData.AddType(builder, Type);
			return ITimeOccupationData.EndITimeOccupationData(builder);
		}

		// Token: 0x06019E48 RID: 106056 RVA: 0x003B48A6 File Offset: 0x003B2AA6
		public static void StartITimeOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019E49 RID: 106057 RVA: 0x003B48AF File Offset: 0x003B2AAF
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019E4A RID: 106058 RVA: 0x003B48BA File Offset: 0x003B2ABA
		public static Offset<ITimeOccupationData> EndITimeOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<ITimeOccupationData>(builder.EndTable());
		}

		// Token: 0x06019E4B RID: 106059 RVA: 0x003B48C8 File Offset: 0x003B2AC8
		public ITimeOccupationDataT UnPack()
		{
			ITimeOccupationDataT timeOccupationDataT = new ITimeOccupationDataT();
			this.UnPackTo(timeOccupationDataT);
			return timeOccupationDataT;
		}

		// Token: 0x06019E4C RID: 106060 RVA: 0x003B48E3 File Offset: 0x003B2AE3
		public void UnPackTo(ITimeOccupationDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019E4D RID: 106061 RVA: 0x003B48F4 File Offset: 0x003B2AF4
		public static Offset<ITimeOccupationData> Pack(FlatBufferBuilder builder, ITimeOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeOccupationData>);
			}
			return ITimeOccupationData.CreateITimeOccupationData(builder, _o.Type);
		}

		// Token: 0x0400C21D RID: 49693
		private Table __p;
	}
}

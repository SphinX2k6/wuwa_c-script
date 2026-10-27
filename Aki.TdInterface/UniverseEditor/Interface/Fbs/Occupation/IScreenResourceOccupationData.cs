using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043C5 RID: 17349
	public struct IScreenResourceOccupationData : IFlatbufferObject
	{
		// Token: 0x17007AAD RID: 31405
		// (get) Token: 0x06019DE0 RID: 105952 RVA: 0x003B3D56 File Offset: 0x003B1F56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019DE1 RID: 105953 RVA: 0x003B3D63 File Offset: 0x003B1F63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019DE2 RID: 105954 RVA: 0x003B3D6C File Offset: 0x003B1F6C
		public static IScreenResourceOccupationData GetRootAsIScreenResourceOccupationData(ByteBuffer _bb)
		{
			return IScreenResourceOccupationData.GetRootAsIScreenResourceOccupationData(_bb, default(IScreenResourceOccupationData));
		}

		// Token: 0x06019DE3 RID: 105955 RVA: 0x003B3D88 File Offset: 0x003B1F88
		public static IScreenResourceOccupationData GetRootAsIScreenResourceOccupationData(ByteBuffer _bb, IScreenResourceOccupationData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019DE4 RID: 105956 RVA: 0x003B3DA5 File Offset: 0x003B1FA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019DE5 RID: 105957 RVA: 0x003B3DB4 File Offset: 0x003B1FB4
		public IScreenResourceOccupationData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AAE RID: 31406
		// (get) Token: 0x06019DE6 RID: 105958 RVA: 0x003B3DC4 File Offset: 0x003B1FC4
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

		// Token: 0x06019DE7 RID: 105959 RVA: 0x003B3E00 File Offset: 0x003B2000
		public static Offset<IScreenResourceOccupationData> CreateIScreenResourceOccupationData(FlatBufferBuilder builder, EOccupationType Type = EOccupationType.Npc)
		{
			builder.StartTable(1);
			IScreenResourceOccupationData.AddType(builder, Type);
			return IScreenResourceOccupationData.EndIScreenResourceOccupationData(builder);
		}

		// Token: 0x06019DE8 RID: 105960 RVA: 0x003B3E16 File Offset: 0x003B2016
		public static void StartIScreenResourceOccupationData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019DE9 RID: 105961 RVA: 0x003B3E1F File Offset: 0x003B201F
		public static void AddType(FlatBufferBuilder builder, EOccupationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019DEA RID: 105962 RVA: 0x003B3E2A File Offset: 0x003B202A
		public static Offset<IScreenResourceOccupationData> EndIScreenResourceOccupationData(FlatBufferBuilder builder)
		{
			return new Offset<IScreenResourceOccupationData>(builder.EndTable());
		}

		// Token: 0x06019DEB RID: 105963 RVA: 0x003B3E38 File Offset: 0x003B2038
		public IScreenResourceOccupationDataT UnPack()
		{
			IScreenResourceOccupationDataT screenResourceOccupationDataT = new IScreenResourceOccupationDataT();
			this.UnPackTo(screenResourceOccupationDataT);
			return screenResourceOccupationDataT;
		}

		// Token: 0x06019DEC RID: 105964 RVA: 0x003B3E53 File Offset: 0x003B2053
		public void UnPackTo(IScreenResourceOccupationDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019DED RID: 105965 RVA: 0x003B3E64 File Offset: 0x003B2064
		public static Offset<IScreenResourceOccupationData> Pack(FlatBufferBuilder builder, IScreenResourceOccupationDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScreenResourceOccupationData>);
			}
			return IScreenResourceOccupationData.CreateIScreenResourceOccupationData(builder, _o.Type);
		}

		// Token: 0x0400C212 RID: 49682
		private Table __p;
	}
}

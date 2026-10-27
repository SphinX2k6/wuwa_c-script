using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004464 RID: 17508
	public struct IDartboardZoneType : IFlatbufferObject
	{
		// Token: 0x17007B90 RID: 31632
		// (get) Token: 0x0601A172 RID: 106866 RVA: 0x003BA5FD File Offset: 0x003B87FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A173 RID: 106867 RVA: 0x003BA60A File Offset: 0x003B880A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A174 RID: 106868 RVA: 0x003BA614 File Offset: 0x003B8814
		public static IDartboardZoneType GetRootAsIDartboardZoneType(ByteBuffer _bb)
		{
			return IDartboardZoneType.GetRootAsIDartboardZoneType(_bb, default(IDartboardZoneType));
		}

		// Token: 0x0601A175 RID: 106869 RVA: 0x003BA630 File Offset: 0x003B8830
		public static IDartboardZoneType GetRootAsIDartboardZoneType(ByteBuffer _bb, IDartboardZoneType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A176 RID: 106870 RVA: 0x003BA64D File Offset: 0x003B884D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A177 RID: 106871 RVA: 0x003BA65C File Offset: 0x003B885C
		public IDartboardZoneType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B91 RID: 31633
		// (get) Token: 0x0601A178 RID: 106872 RVA: 0x003BA66C File Offset: 0x003B886C
		public EDartboardZoneType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartboardZoneType.CenterBull;
				}
				return (EDartboardZoneType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A179 RID: 106873 RVA: 0x003BA6A8 File Offset: 0x003B88A8
		public static Offset<IDartboardZoneType> CreateIDartboardZoneType(FlatBufferBuilder builder, EDartboardZoneType Type = EDartboardZoneType.CenterBull)
		{
			builder.StartTable(1);
			IDartboardZoneType.AddType(builder, Type);
			return IDartboardZoneType.EndIDartboardZoneType(builder);
		}

		// Token: 0x0601A17A RID: 106874 RVA: 0x003BA6BE File Offset: 0x003B88BE
		public static void StartIDartboardZoneType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A17B RID: 106875 RVA: 0x003BA6C7 File Offset: 0x003B88C7
		public static void AddType(FlatBufferBuilder builder, EDartboardZoneType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A17C RID: 106876 RVA: 0x003BA6D2 File Offset: 0x003B88D2
		public static Offset<IDartboardZoneType> EndIDartboardZoneType(FlatBufferBuilder builder)
		{
			return new Offset<IDartboardZoneType>(builder.EndTable());
		}

		// Token: 0x0601A17D RID: 106877 RVA: 0x003BA6E0 File Offset: 0x003B88E0
		public IDartboardZoneTypeT UnPack()
		{
			IDartboardZoneTypeT dartboardZoneTypeT = new IDartboardZoneTypeT();
			this.UnPackTo(dartboardZoneTypeT);
			return dartboardZoneTypeT;
		}

		// Token: 0x0601A17E RID: 106878 RVA: 0x003BA6FB File Offset: 0x003B88FB
		public void UnPackTo(IDartboardZoneTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A17F RID: 106879 RVA: 0x003BA70C File Offset: 0x003B890C
		public static Offset<IDartboardZoneType> Pack(FlatBufferBuilder builder, IDartboardZoneTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartboardZoneType>);
			}
			return IDartboardZoneType.CreateIDartboardZoneType(builder, _o.Type);
		}

		// Token: 0x0400C44F RID: 50255
		private Table __p;
	}
}

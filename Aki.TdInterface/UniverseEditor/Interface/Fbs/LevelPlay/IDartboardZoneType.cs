using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048CC RID: 18636
	public struct IDartboardZoneType : IFlatbufferObject
	{
		// Token: 0x170081CF RID: 33231
		// (get) Token: 0x0601B943 RID: 112963 RVA: 0x003E6809 File Offset: 0x003E4A09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B944 RID: 112964 RVA: 0x003E6816 File Offset: 0x003E4A16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B945 RID: 112965 RVA: 0x003E6820 File Offset: 0x003E4A20
		public static IDartboardZoneType GetRootAsIDartboardZoneType(ByteBuffer _bb)
		{
			return IDartboardZoneType.GetRootAsIDartboardZoneType(_bb, default(IDartboardZoneType));
		}

		// Token: 0x0601B946 RID: 112966 RVA: 0x003E683C File Offset: 0x003E4A3C
		public static IDartboardZoneType GetRootAsIDartboardZoneType(ByteBuffer _bb, IDartboardZoneType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B947 RID: 112967 RVA: 0x003E6859 File Offset: 0x003E4A59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B948 RID: 112968 RVA: 0x003E6868 File Offset: 0x003E4A68
		public IDartboardZoneType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081D0 RID: 33232
		// (get) Token: 0x0601B949 RID: 112969 RVA: 0x003E6878 File Offset: 0x003E4A78
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

		// Token: 0x0601B94A RID: 112970 RVA: 0x003E68B4 File Offset: 0x003E4AB4
		public static Offset<IDartboardZoneType> CreateIDartboardZoneType(FlatBufferBuilder builder, EDartboardZoneType Type = EDartboardZoneType.CenterBull)
		{
			builder.StartTable(1);
			IDartboardZoneType.AddType(builder, Type);
			return IDartboardZoneType.EndIDartboardZoneType(builder);
		}

		// Token: 0x0601B94B RID: 112971 RVA: 0x003E68CA File Offset: 0x003E4ACA
		public static void StartIDartboardZoneType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B94C RID: 112972 RVA: 0x003E68D3 File Offset: 0x003E4AD3
		public static void AddType(FlatBufferBuilder builder, EDartboardZoneType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B94D RID: 112973 RVA: 0x003E68DE File Offset: 0x003E4ADE
		public static Offset<IDartboardZoneType> EndIDartboardZoneType(FlatBufferBuilder builder)
		{
			return new Offset<IDartboardZoneType>(builder.EndTable());
		}

		// Token: 0x0601B94E RID: 112974 RVA: 0x003E68EC File Offset: 0x003E4AEC
		public IDartboardZoneTypeT UnPack()
		{
			IDartboardZoneTypeT dartboardZoneTypeT = new IDartboardZoneTypeT();
			this.UnPackTo(dartboardZoneTypeT);
			return dartboardZoneTypeT;
		}

		// Token: 0x0601B94F RID: 112975 RVA: 0x003E6907 File Offset: 0x003E4B07
		public void UnPackTo(IDartboardZoneTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B950 RID: 112976 RVA: 0x003E6918 File Offset: 0x003E4B18
		public static Offset<IDartboardZoneType> Pack(FlatBufferBuilder builder, IDartboardZoneTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartboardZoneType>);
			}
			return IDartboardZoneType.CreateIDartboardZoneType(builder, _o.Type);
		}

		// Token: 0x0400CE7D RID: 52861
		private Table __p;
	}
}

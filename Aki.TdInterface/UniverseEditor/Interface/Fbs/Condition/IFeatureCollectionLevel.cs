using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005115 RID: 20757
	public struct IFeatureCollectionLevel : IFlatbufferObject
	{
		// Token: 0x170094BC RID: 38076
		// (get) Token: 0x06020A09 RID: 133641 RVA: 0x00485EA2 File Offset: 0x004840A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020A0A RID: 133642 RVA: 0x00485EAF File Offset: 0x004840AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020A0B RID: 133643 RVA: 0x00485EB8 File Offset: 0x004840B8
		public static IFeatureCollectionLevel GetRootAsIFeatureCollectionLevel(ByteBuffer _bb)
		{
			return IFeatureCollectionLevel.GetRootAsIFeatureCollectionLevel(_bb, default(IFeatureCollectionLevel));
		}

		// Token: 0x06020A0C RID: 133644 RVA: 0x00485ED4 File Offset: 0x004840D4
		public static IFeatureCollectionLevel GetRootAsIFeatureCollectionLevel(ByteBuffer _bb, IFeatureCollectionLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020A0D RID: 133645 RVA: 0x00485EF1 File Offset: 0x004840F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020A0E RID: 133646 RVA: 0x00485F00 File Offset: 0x00484100
		public IFeatureCollectionLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094BD RID: 38077
		// (get) Token: 0x06020A0F RID: 133647 RVA: 0x00485F10 File Offset: 0x00484110
		public EFormationRoleInfoType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFormationRoleInfoType.RoleLevel;
				}
				return (EFormationRoleInfoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170094BE RID: 38078
		// (get) Token: 0x06020A10 RID: 133648 RVA: 0x00485F4C File Offset: 0x0048414C
		public int Id
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

		// Token: 0x170094BF RID: 38079
		// (get) Token: 0x06020A11 RID: 133649 RVA: 0x00485F88 File Offset: 0x00484188
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170094C0 RID: 38080
		// (get) Token: 0x06020A12 RID: 133650 RVA: 0x00485FC4 File Offset: 0x004841C4
		public int Level
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020A13 RID: 133651 RVA: 0x00486001 File Offset: 0x00484201
		public static Offset<IFeatureCollectionLevel> CreateIFeatureCollectionLevel(FlatBufferBuilder builder, EFormationRoleInfoType Type = EFormationRoleInfoType.RoleLevel, int Id = 0, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(4);
			IFeatureCollectionLevel.AddLevel(builder, Level);
			IFeatureCollectionLevel.AddId(builder, Id);
			IFeatureCollectionLevel.AddCompare(builder, Compare);
			IFeatureCollectionLevel.AddType(builder, Type);
			return IFeatureCollectionLevel.EndIFeatureCollectionLevel(builder);
		}

		// Token: 0x06020A14 RID: 133652 RVA: 0x0048602D File Offset: 0x0048422D
		public static void StartIFeatureCollectionLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020A15 RID: 133653 RVA: 0x00486036 File Offset: 0x00484236
		public static void AddType(FlatBufferBuilder builder, EFormationRoleInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020A16 RID: 133654 RVA: 0x00486041 File Offset: 0x00484241
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06020A17 RID: 133655 RVA: 0x0048604C File Offset: 0x0048424C
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x06020A18 RID: 133656 RVA: 0x00486057 File Offset: 0x00484257
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(3, level, 0);
		}

		// Token: 0x06020A19 RID: 133657 RVA: 0x00486062 File Offset: 0x00484262
		public static Offset<IFeatureCollectionLevel> EndIFeatureCollectionLevel(FlatBufferBuilder builder)
		{
			return new Offset<IFeatureCollectionLevel>(builder.EndTable());
		}

		// Token: 0x06020A1A RID: 133658 RVA: 0x00486070 File Offset: 0x00484270
		public IFeatureCollectionLevelT UnPack()
		{
			IFeatureCollectionLevelT featureCollectionLevelT = new IFeatureCollectionLevelT();
			this.UnPackTo(featureCollectionLevelT);
			return featureCollectionLevelT;
		}

		// Token: 0x06020A1B RID: 133659 RVA: 0x0048608B File Offset: 0x0048428B
		public void UnPackTo(IFeatureCollectionLevelT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x06020A1C RID: 133660 RVA: 0x004860C0 File Offset: 0x004842C0
		public static Offset<IFeatureCollectionLevel> Pack(FlatBufferBuilder builder, IFeatureCollectionLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFeatureCollectionLevel>);
			}
			return IFeatureCollectionLevel.CreateIFeatureCollectionLevel(builder, _o.Type, _o.Id, _o.Compare, _o.Level);
		}

		// Token: 0x0400E0D9 RID: 57561
		private Table __p;
	}
}

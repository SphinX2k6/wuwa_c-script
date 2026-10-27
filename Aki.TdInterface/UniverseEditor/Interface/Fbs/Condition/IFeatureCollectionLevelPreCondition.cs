using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C25 RID: 19493
	public struct IFeatureCollectionLevelPreCondition : IFlatbufferObject
	{
		// Token: 0x17008D9C RID: 36252
		// (get) Token: 0x0601EE23 RID: 126499 RVA: 0x004528E0 File Offset: 0x00450AE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EE24 RID: 126500 RVA: 0x004528ED File Offset: 0x00450AED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EE25 RID: 126501 RVA: 0x004528F4 File Offset: 0x00450AF4
		public static IFeatureCollectionLevelPreCondition GetRootAsIFeatureCollectionLevelPreCondition(ByteBuffer _bb)
		{
			return IFeatureCollectionLevelPreCondition.GetRootAsIFeatureCollectionLevelPreCondition(_bb, default(IFeatureCollectionLevelPreCondition));
		}

		// Token: 0x0601EE26 RID: 126502 RVA: 0x00452910 File Offset: 0x00450B10
		public static IFeatureCollectionLevelPreCondition GetRootAsIFeatureCollectionLevelPreCondition(ByteBuffer _bb, IFeatureCollectionLevelPreCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EE27 RID: 126503 RVA: 0x0045292D File Offset: 0x00450B2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EE28 RID: 126504 RVA: 0x0045293C File Offset: 0x00450B3C
		public IFeatureCollectionLevelPreCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D9D RID: 36253
		// (get) Token: 0x0601EE29 RID: 126505 RVA: 0x0045294C File Offset: 0x00450B4C
		public EAccessQuestCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAccessQuestCondition.ExploreLevel;
				}
				return (EAccessQuestCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D9E RID: 36254
		// (get) Token: 0x0601EE2A RID: 126506 RVA: 0x00452988 File Offset: 0x00450B88
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

		// Token: 0x17008D9F RID: 36255
		// (get) Token: 0x0601EE2B RID: 126507 RVA: 0x004529C4 File Offset: 0x00450BC4
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

		// Token: 0x17008DA0 RID: 36256
		// (get) Token: 0x0601EE2C RID: 126508 RVA: 0x00452A00 File Offset: 0x00450C00
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

		// Token: 0x0601EE2D RID: 126509 RVA: 0x00452A3D File Offset: 0x00450C3D
		public static Offset<IFeatureCollectionLevelPreCondition> CreateIFeatureCollectionLevelPreCondition(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int Id = 0, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(4);
			IFeatureCollectionLevelPreCondition.AddLevel(builder, Level);
			IFeatureCollectionLevelPreCondition.AddId(builder, Id);
			IFeatureCollectionLevelPreCondition.AddCompare(builder, Compare);
			IFeatureCollectionLevelPreCondition.AddType(builder, Type);
			return IFeatureCollectionLevelPreCondition.EndIFeatureCollectionLevelPreCondition(builder);
		}

		// Token: 0x0601EE2E RID: 126510 RVA: 0x00452A69 File Offset: 0x00450C69
		public static void StartIFeatureCollectionLevelPreCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601EE2F RID: 126511 RVA: 0x00452A72 File Offset: 0x00450C72
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EE30 RID: 126512 RVA: 0x00452A7D File Offset: 0x00450C7D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601EE31 RID: 126513 RVA: 0x00452A88 File Offset: 0x00450C88
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601EE32 RID: 126514 RVA: 0x00452A93 File Offset: 0x00450C93
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(3, level, 0);
		}

		// Token: 0x0601EE33 RID: 126515 RVA: 0x00452A9E File Offset: 0x00450C9E
		public static Offset<IFeatureCollectionLevelPreCondition> EndIFeatureCollectionLevelPreCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFeatureCollectionLevelPreCondition>(builder.EndTable());
		}

		// Token: 0x0601EE34 RID: 126516 RVA: 0x00452AAC File Offset: 0x00450CAC
		public IFeatureCollectionLevelPreConditionT UnPack()
		{
			IFeatureCollectionLevelPreConditionT featureCollectionLevelPreConditionT = new IFeatureCollectionLevelPreConditionT();
			this.UnPackTo(featureCollectionLevelPreConditionT);
			return featureCollectionLevelPreConditionT;
		}

		// Token: 0x0601EE35 RID: 126517 RVA: 0x00452AC7 File Offset: 0x00450CC7
		public void UnPackTo(IFeatureCollectionLevelPreConditionT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0601EE36 RID: 126518 RVA: 0x00452AFC File Offset: 0x00450CFC
		public static Offset<IFeatureCollectionLevelPreCondition> Pack(FlatBufferBuilder builder, IFeatureCollectionLevelPreConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFeatureCollectionLevelPreCondition>);
			}
			return IFeatureCollectionLevelPreCondition.CreateIFeatureCollectionLevelPreCondition(builder, _o.Type, _o.Id, _o.Compare, _o.Level);
		}

		// Token: 0x0400D5BF RID: 54719
		private Table __p;
	}
}

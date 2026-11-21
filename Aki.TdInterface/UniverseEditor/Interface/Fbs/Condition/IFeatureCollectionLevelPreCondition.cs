using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005118 RID: 20760
	public struct IFeatureCollectionLevelPreCondition : IFlatbufferObject
	{
		// Token: 0x170094C5 RID: 38085
		// (get) Token: 0x06020A27 RID: 133671 RVA: 0x004861BC File Offset: 0x004843BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020A28 RID: 133672 RVA: 0x004861C9 File Offset: 0x004843C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020A29 RID: 133673 RVA: 0x004861D0 File Offset: 0x004843D0
		public static IFeatureCollectionLevelPreCondition GetRootAsIFeatureCollectionLevelPreCondition(ByteBuffer _bb)
		{
			return IFeatureCollectionLevelPreCondition.GetRootAsIFeatureCollectionLevelPreCondition(_bb, default(IFeatureCollectionLevelPreCondition));
		}

		// Token: 0x06020A2A RID: 133674 RVA: 0x004861EC File Offset: 0x004843EC
		public static IFeatureCollectionLevelPreCondition GetRootAsIFeatureCollectionLevelPreCondition(ByteBuffer _bb, IFeatureCollectionLevelPreCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020A2B RID: 133675 RVA: 0x00486209 File Offset: 0x00484409
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020A2C RID: 133676 RVA: 0x00486218 File Offset: 0x00484418
		public IFeatureCollectionLevelPreCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094C6 RID: 38086
		// (get) Token: 0x06020A2D RID: 133677 RVA: 0x00486228 File Offset: 0x00484428
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

		// Token: 0x170094C7 RID: 38087
		// (get) Token: 0x06020A2E RID: 133678 RVA: 0x00486264 File Offset: 0x00484464
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

		// Token: 0x170094C8 RID: 38088
		// (get) Token: 0x06020A2F RID: 133679 RVA: 0x004862A0 File Offset: 0x004844A0
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

		// Token: 0x170094C9 RID: 38089
		// (get) Token: 0x06020A30 RID: 133680 RVA: 0x004862DC File Offset: 0x004844DC
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

		// Token: 0x06020A31 RID: 133681 RVA: 0x00486319 File Offset: 0x00484519
		public static Offset<IFeatureCollectionLevelPreCondition> CreateIFeatureCollectionLevelPreCondition(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int Id = 0, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(4);
			IFeatureCollectionLevelPreCondition.AddLevel(builder, Level);
			IFeatureCollectionLevelPreCondition.AddId(builder, Id);
			IFeatureCollectionLevelPreCondition.AddCompare(builder, Compare);
			IFeatureCollectionLevelPreCondition.AddType(builder, Type);
			return IFeatureCollectionLevelPreCondition.EndIFeatureCollectionLevelPreCondition(builder);
		}

		// Token: 0x06020A32 RID: 133682 RVA: 0x00486345 File Offset: 0x00484545
		public static void StartIFeatureCollectionLevelPreCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020A33 RID: 133683 RVA: 0x0048634E File Offset: 0x0048454E
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020A34 RID: 133684 RVA: 0x00486359 File Offset: 0x00484559
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06020A35 RID: 133685 RVA: 0x00486364 File Offset: 0x00484564
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x06020A36 RID: 133686 RVA: 0x0048636F File Offset: 0x0048456F
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(3, level, 0);
		}

		// Token: 0x06020A37 RID: 133687 RVA: 0x0048637A File Offset: 0x0048457A
		public static Offset<IFeatureCollectionLevelPreCondition> EndIFeatureCollectionLevelPreCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFeatureCollectionLevelPreCondition>(builder.EndTable());
		}

		// Token: 0x06020A38 RID: 133688 RVA: 0x00486388 File Offset: 0x00484588
		public IFeatureCollectionLevelPreConditionT UnPack()
		{
			IFeatureCollectionLevelPreConditionT featureCollectionLevelPreConditionT = new IFeatureCollectionLevelPreConditionT();
			this.UnPackTo(featureCollectionLevelPreConditionT);
			return featureCollectionLevelPreConditionT;
		}

		// Token: 0x06020A39 RID: 133689 RVA: 0x004863A3 File Offset: 0x004845A3
		public void UnPackTo(IFeatureCollectionLevelPreConditionT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x06020A3A RID: 133690 RVA: 0x004863D8 File Offset: 0x004845D8
		public static Offset<IFeatureCollectionLevelPreCondition> Pack(FlatBufferBuilder builder, IFeatureCollectionLevelPreConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFeatureCollectionLevelPreCondition>);
			}
			return IFeatureCollectionLevelPreCondition.CreateIFeatureCollectionLevelPreCondition(builder, _o.Type, _o.Id, _o.Compare, _o.Level);
		}

		// Token: 0x0400E0DE RID: 57566
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C20 RID: 27680
	public struct IDetectBattleTag : IFlatbufferObject
	{
		// Token: 0x1700CADD RID: 51933
		// (get) Token: 0x0602FA27 RID: 195111 RVA: 0x0067D736 File Offset: 0x0067B936
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FA28 RID: 195112 RVA: 0x0067D743 File Offset: 0x0067B943
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FA29 RID: 195113 RVA: 0x0067D74C File Offset: 0x0067B94C
		public static IDetectBattleTag GetRootAsIDetectBattleTag(ByteBuffer _bb)
		{
			return IDetectBattleTag.GetRootAsIDetectBattleTag(_bb, default(IDetectBattleTag));
		}

		// Token: 0x0602FA2A RID: 195114 RVA: 0x0067D768 File Offset: 0x0067B968
		public static IDetectBattleTag GetRootAsIDetectBattleTag(ByteBuffer _bb, IDetectBattleTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FA2B RID: 195115 RVA: 0x0067D785 File Offset: 0x0067B985
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FA2C RID: 195116 RVA: 0x0067D794 File Offset: 0x0067B994
		public IDetectBattleTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CADE RID: 51934
		// (get) Token: 0x0602FA2D RID: 195117 RVA: 0x0067D7A4 File Offset: 0x0067B9A4
		public EDetectBattleConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDetectBattleConditionType.DetectBattleTag;
				}
				return (EDetectBattleConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CADF RID: 51935
		// (get) Token: 0x0602FA2E RID: 195118 RVA: 0x0067D7E0 File Offset: 0x0067B9E0
		public int EntityId
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

		// Token: 0x1700CAE0 RID: 51936
		// (get) Token: 0x0602FA2F RID: 195119 RVA: 0x0067D81C File Offset: 0x0067BA1C
		public IDetectBattleMonsterOnGround? TagOption
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IDetectBattleMonsterOnGround?(default(IDetectBattleMonsterOnGround).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CAE1 RID: 51937
		// (get) Token: 0x0602FA30 RID: 195120 RVA: 0x0067D87C File Offset: 0x0067BA7C
		public float MaxWaitTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FA31 RID: 195121 RVA: 0x0067D8BD File Offset: 0x0067BABD
		public static Offset<IDetectBattleTag> CreateIDetectBattleTag(FlatBufferBuilder builder, EDetectBattleConditionType Type = EDetectBattleConditionType.DetectBattleTag, int EntityId = 0, Offset<IDetectBattleMonsterOnGround> TagOptionOffset = default(Offset<IDetectBattleMonsterOnGround>), float MaxWaitTime = 0f)
		{
			builder.StartTable(4);
			IDetectBattleTag.AddMaxWaitTime(builder, MaxWaitTime);
			IDetectBattleTag.AddTagOption(builder, TagOptionOffset);
			IDetectBattleTag.AddEntityId(builder, EntityId);
			IDetectBattleTag.AddType(builder, Type);
			return IDetectBattleTag.EndIDetectBattleTag(builder);
		}

		// Token: 0x0602FA32 RID: 195122 RVA: 0x0067D8E9 File Offset: 0x0067BAE9
		public static void StartIDetectBattleTag(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602FA33 RID: 195123 RVA: 0x0067D8F2 File Offset: 0x0067BAF2
		public static void AddType(FlatBufferBuilder builder, EDetectBattleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FA34 RID: 195124 RVA: 0x0067D8FD File Offset: 0x0067BAFD
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602FA35 RID: 195125 RVA: 0x0067D908 File Offset: 0x0067BB08
		public static void AddTagOption(FlatBufferBuilder builder, Offset<IDetectBattleMonsterOnGround> tagOptionOffset)
		{
			builder.AddOffset(2, tagOptionOffset.Value, 0);
		}

		// Token: 0x0602FA36 RID: 195126 RVA: 0x0067D918 File Offset: 0x0067BB18
		public static void AddMaxWaitTime(FlatBufferBuilder builder, float maxWaitTime)
		{
			builder.AddFloat(3, maxWaitTime, 0.0);
		}

		// Token: 0x0602FA37 RID: 195127 RVA: 0x0067D92B File Offset: 0x0067BB2B
		public static Offset<IDetectBattleTag> EndIDetectBattleTag(FlatBufferBuilder builder)
		{
			return new Offset<IDetectBattleTag>(builder.EndTable());
		}

		// Token: 0x0602FA38 RID: 195128 RVA: 0x0067D938 File Offset: 0x0067BB38
		public IDetectBattleTagT UnPack()
		{
			IDetectBattleTagT detectBattleTagT = new IDetectBattleTagT();
			this.UnPackTo(detectBattleTagT);
			return detectBattleTagT;
		}

		// Token: 0x0602FA39 RID: 195129 RVA: 0x0067D954 File Offset: 0x0067BB54
		public void UnPackTo(IDetectBattleTagT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.TagOption = ((this.TagOption != null) ? this.TagOption.Value.UnPack() : null);
			_o.MaxWaitTime = this.MaxWaitTime;
		}

		// Token: 0x0602FA3A RID: 195130 RVA: 0x0067D9B4 File Offset: 0x0067BBB4
		public static Offset<IDetectBattleTag> Pack(FlatBufferBuilder builder, IDetectBattleTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDetectBattleTag>);
			}
			Offset<IDetectBattleMonsterOnGround> tagOptionOffset = (_o.TagOption == null) ? default(Offset<IDetectBattleMonsterOnGround>) : IDetectBattleMonsterOnGround.Pack(builder, _o.TagOption);
			return IDetectBattleTag.CreateIDetectBattleTag(builder, _o.Type, _o.EntityId, tagOptionOffset, _o.MaxWaitTime);
		}

		// Token: 0x04011A26 RID: 72230
		private Table __p;
	}
}

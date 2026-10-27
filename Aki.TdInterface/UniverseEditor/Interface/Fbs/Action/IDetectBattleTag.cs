using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065B8 RID: 26040
	public struct IDetectBattleTag : IFlatbufferObject
	{
		// Token: 0x1700C14E RID: 49486
		// (get) Token: 0x0602D2A3 RID: 184995 RVA: 0x00631572 File Offset: 0x0062F772
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D2A4 RID: 184996 RVA: 0x0063157F File Offset: 0x0062F77F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D2A5 RID: 184997 RVA: 0x00631588 File Offset: 0x0062F788
		public static IDetectBattleTag GetRootAsIDetectBattleTag(ByteBuffer _bb)
		{
			return IDetectBattleTag.GetRootAsIDetectBattleTag(_bb, default(IDetectBattleTag));
		}

		// Token: 0x0602D2A6 RID: 184998 RVA: 0x006315A4 File Offset: 0x0062F7A4
		public static IDetectBattleTag GetRootAsIDetectBattleTag(ByteBuffer _bb, IDetectBattleTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D2A7 RID: 184999 RVA: 0x006315C1 File Offset: 0x0062F7C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D2A8 RID: 185000 RVA: 0x006315D0 File Offset: 0x0062F7D0
		public IDetectBattleTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C14F RID: 49487
		// (get) Token: 0x0602D2A9 RID: 185001 RVA: 0x006315E0 File Offset: 0x0062F7E0
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

		// Token: 0x1700C150 RID: 49488
		// (get) Token: 0x0602D2AA RID: 185002 RVA: 0x0063161C File Offset: 0x0062F81C
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

		// Token: 0x1700C151 RID: 49489
		// (get) Token: 0x0602D2AB RID: 185003 RVA: 0x00631658 File Offset: 0x0062F858
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

		// Token: 0x1700C152 RID: 49490
		// (get) Token: 0x0602D2AC RID: 185004 RVA: 0x006316B8 File Offset: 0x0062F8B8
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

		// Token: 0x0602D2AD RID: 185005 RVA: 0x006316F9 File Offset: 0x0062F8F9
		public static Offset<IDetectBattleTag> CreateIDetectBattleTag(FlatBufferBuilder builder, EDetectBattleConditionType Type = EDetectBattleConditionType.DetectBattleTag, int EntityId = 0, Offset<IDetectBattleMonsterOnGround> TagOptionOffset = default(Offset<IDetectBattleMonsterOnGround>), float MaxWaitTime = 0f)
		{
			builder.StartTable(4);
			IDetectBattleTag.AddMaxWaitTime(builder, MaxWaitTime);
			IDetectBattleTag.AddTagOption(builder, TagOptionOffset);
			IDetectBattleTag.AddEntityId(builder, EntityId);
			IDetectBattleTag.AddType(builder, Type);
			return IDetectBattleTag.EndIDetectBattleTag(builder);
		}

		// Token: 0x0602D2AE RID: 185006 RVA: 0x00631725 File Offset: 0x0062F925
		public static void StartIDetectBattleTag(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602D2AF RID: 185007 RVA: 0x0063172E File Offset: 0x0062F92E
		public static void AddType(FlatBufferBuilder builder, EDetectBattleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D2B0 RID: 185008 RVA: 0x00631739 File Offset: 0x0062F939
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602D2B1 RID: 185009 RVA: 0x00631744 File Offset: 0x0062F944
		public static void AddTagOption(FlatBufferBuilder builder, Offset<IDetectBattleMonsterOnGround> tagOptionOffset)
		{
			builder.AddOffset(2, tagOptionOffset.Value, 0);
		}

		// Token: 0x0602D2B2 RID: 185010 RVA: 0x00631754 File Offset: 0x0062F954
		public static void AddMaxWaitTime(FlatBufferBuilder builder, float maxWaitTime)
		{
			builder.AddFloat(3, maxWaitTime, 0.0);
		}

		// Token: 0x0602D2B3 RID: 185011 RVA: 0x00631767 File Offset: 0x0062F967
		public static Offset<IDetectBattleTag> EndIDetectBattleTag(FlatBufferBuilder builder)
		{
			return new Offset<IDetectBattleTag>(builder.EndTable());
		}

		// Token: 0x0602D2B4 RID: 185012 RVA: 0x00631774 File Offset: 0x0062F974
		public IDetectBattleTagT UnPack()
		{
			IDetectBattleTagT detectBattleTagT = new IDetectBattleTagT();
			this.UnPackTo(detectBattleTagT);
			return detectBattleTagT;
		}

		// Token: 0x0602D2B5 RID: 185013 RVA: 0x00631790 File Offset: 0x0062F990
		public void UnPackTo(IDetectBattleTagT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.TagOption = ((this.TagOption != null) ? this.TagOption.Value.UnPack() : null);
			_o.MaxWaitTime = this.MaxWaitTime;
		}

		// Token: 0x0602D2B6 RID: 185014 RVA: 0x006317F0 File Offset: 0x0062F9F0
		public static Offset<IDetectBattleTag> Pack(FlatBufferBuilder builder, IDetectBattleTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDetectBattleTag>);
			}
			Offset<IDetectBattleMonsterOnGround> tagOptionOffset = (_o.TagOption == null) ? default(Offset<IDetectBattleMonsterOnGround>) : IDetectBattleMonsterOnGround.Pack(builder, _o.TagOption);
			return IDetectBattleTag.CreateIDetectBattleTag(builder, _o.Type, _o.EntityId, tagOptionOffset, _o.MaxWaitTime);
		}

		// Token: 0x04010C14 RID: 68628
		private Table __p;
	}
}

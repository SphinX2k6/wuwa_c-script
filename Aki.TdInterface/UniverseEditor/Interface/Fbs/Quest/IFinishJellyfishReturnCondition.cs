using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E39 RID: 15929
	public struct IFinishJellyfishReturnCondition : IFlatbufferObject
	{
		// Token: 0x17006E28 RID: 28200
		// (get) Token: 0x06016553 RID: 91475 RVA: 0x003395E2 File Offset: 0x003377E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016554 RID: 91476 RVA: 0x003395EF File Offset: 0x003377EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016555 RID: 91477 RVA: 0x003395F8 File Offset: 0x003377F8
		public static IFinishJellyfishReturnCondition GetRootAsIFinishJellyfishReturnCondition(ByteBuffer _bb)
		{
			return IFinishJellyfishReturnCondition.GetRootAsIFinishJellyfishReturnCondition(_bb, default(IFinishJellyfishReturnCondition));
		}

		// Token: 0x06016556 RID: 91478 RVA: 0x00339614 File Offset: 0x00337814
		public static IFinishJellyfishReturnCondition GetRootAsIFinishJellyfishReturnCondition(ByteBuffer _bb, IFinishJellyfishReturnCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016557 RID: 91479 RVA: 0x00339631 File Offset: 0x00337831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016558 RID: 91480 RVA: 0x00339640 File Offset: 0x00337840
		public IFinishJellyfishReturnCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E29 RID: 28201
		// (get) Token: 0x06016559 RID: 91481 RVA: 0x00339650 File Offset: 0x00337850
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006E2A RID: 28202
		// (get) Token: 0x0601655A RID: 91482 RVA: 0x0033968C File Offset: 0x0033788C
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006E2B RID: 28203
		// (get) Token: 0x0601655B RID: 91483 RVA: 0x003396EC File Offset: 0x003378EC
		public int StartPosEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006E2C RID: 28204
		// (get) Token: 0x0601655C RID: 91484 RVA: 0x00339728 File Offset: 0x00337928
		public float StartRadius
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

		// Token: 0x17006E2D RID: 28205
		// (get) Token: 0x0601655D RID: 91485 RVA: 0x0033976C File Offset: 0x0033796C
		public int EndPosEntityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006E2E RID: 28206
		// (get) Token: 0x0601655E RID: 91486 RVA: 0x003397AC File Offset: 0x003379AC
		public float EndRadius
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006E2F RID: 28207
		// (get) Token: 0x0601655F RID: 91487 RVA: 0x003397F0 File Offset: 0x003379F0
		public string LevelConfigDa
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016560 RID: 91488 RVA: 0x00339828 File Offset: 0x00337A28
		public Span<byte> GetLevelConfigDaBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06016561 RID: 91489 RVA: 0x00339838 File Offset: 0x00337A38
		public byte[] GetLevelConfigDaArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17006E30 RID: 28208
		// (get) Token: 0x06016562 RID: 91490 RVA: 0x00339848 File Offset: 0x00337A48
		public string EffectDa
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016563 RID: 91491 RVA: 0x00339880 File Offset: 0x00337A80
		public Span<byte> GetEffectDaBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06016564 RID: 91492 RVA: 0x00339890 File Offset: 0x00337A90
		public byte[] GetEffectDaArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x06016565 RID: 91493 RVA: 0x003398A0 File Offset: 0x00337AA0
		public static Offset<IFinishJellyfishReturnCondition> CreateIFinishJellyfishReturnCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int StartPosEntityId = 0, float StartRadius = 0f, int EndPosEntityId = 0, float EndRadius = 0f, StringOffset LevelConfigDaOffset = default(StringOffset), StringOffset EffectDaOffset = default(StringOffset))
		{
			builder.StartTable(8);
			IFinishJellyfishReturnCondition.AddEffectDa(builder, EffectDaOffset);
			IFinishJellyfishReturnCondition.AddLevelConfigDa(builder, LevelConfigDaOffset);
			IFinishJellyfishReturnCondition.AddEndRadius(builder, EndRadius);
			IFinishJellyfishReturnCondition.AddEndPosEntityId(builder, EndPosEntityId);
			IFinishJellyfishReturnCondition.AddStartRadius(builder, StartRadius);
			IFinishJellyfishReturnCondition.AddStartPosEntityId(builder, StartPosEntityId);
			IFinishJellyfishReturnCondition.AddPreConditions(builder, PreConditionsOffset);
			IFinishJellyfishReturnCondition.AddType(builder, Type);
			return IFinishJellyfishReturnCondition.EndIFinishJellyfishReturnCondition(builder);
		}

		// Token: 0x06016566 RID: 91494 RVA: 0x003398F7 File Offset: 0x00337AF7
		public static void StartIFinishJellyfishReturnCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06016567 RID: 91495 RVA: 0x00339900 File Offset: 0x00337B00
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016568 RID: 91496 RVA: 0x0033990B File Offset: 0x00337B0B
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016569 RID: 91497 RVA: 0x0033991B File Offset: 0x00337B1B
		public static void AddStartPosEntityId(FlatBufferBuilder builder, int startPosEntityId)
		{
			builder.AddInt(2, startPosEntityId, 0);
		}

		// Token: 0x0601656A RID: 91498 RVA: 0x00339926 File Offset: 0x00337B26
		public static void AddStartRadius(FlatBufferBuilder builder, float startRadius)
		{
			builder.AddFloat(3, startRadius, 0.0);
		}

		// Token: 0x0601656B RID: 91499 RVA: 0x00339939 File Offset: 0x00337B39
		public static void AddEndPosEntityId(FlatBufferBuilder builder, int endPosEntityId)
		{
			builder.AddInt(4, endPosEntityId, 0);
		}

		// Token: 0x0601656C RID: 91500 RVA: 0x00339944 File Offset: 0x00337B44
		public static void AddEndRadius(FlatBufferBuilder builder, float endRadius)
		{
			builder.AddFloat(5, endRadius, 0.0);
		}

		// Token: 0x0601656D RID: 91501 RVA: 0x00339957 File Offset: 0x00337B57
		public static void AddLevelConfigDa(FlatBufferBuilder builder, StringOffset levelConfigDaOffset)
		{
			builder.AddOffset(6, levelConfigDaOffset.Value, 0);
		}

		// Token: 0x0601656E RID: 91502 RVA: 0x00339967 File Offset: 0x00337B67
		public static void AddEffectDa(FlatBufferBuilder builder, StringOffset effectDaOffset)
		{
			builder.AddOffset(7, effectDaOffset.Value, 0);
		}

		// Token: 0x0601656F RID: 91503 RVA: 0x00339977 File Offset: 0x00337B77
		public static Offset<IFinishJellyfishReturnCondition> EndIFinishJellyfishReturnCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishJellyfishReturnCondition>(builder.EndTable());
		}

		// Token: 0x06016570 RID: 91504 RVA: 0x00339984 File Offset: 0x00337B84
		public IFinishJellyfishReturnConditionT UnPack()
		{
			IFinishJellyfishReturnConditionT finishJellyfishReturnConditionT = new IFinishJellyfishReturnConditionT();
			this.UnPackTo(finishJellyfishReturnConditionT);
			return finishJellyfishReturnConditionT;
		}

		// Token: 0x06016571 RID: 91505 RVA: 0x003399A0 File Offset: 0x00337BA0
		public void UnPackTo(IFinishJellyfishReturnConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.StartPosEntityId = this.StartPosEntityId;
			_o.StartRadius = this.StartRadius;
			_o.EndPosEntityId = this.EndPosEntityId;
			_o.EndRadius = this.EndRadius;
			_o.LevelConfigDa = this.LevelConfigDa;
			_o.EffectDa = this.EffectDa;
		}

		// Token: 0x06016572 RID: 91506 RVA: 0x00339A30 File Offset: 0x00337C30
		public static Offset<IFinishJellyfishReturnCondition> Pack(FlatBufferBuilder builder, IFinishJellyfishReturnConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishJellyfishReturnCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			StringOffset levelConfigDaOffset = (_o.LevelConfigDa == null) ? default(StringOffset) : builder.CreateString(_o.LevelConfigDa);
			StringOffset effectDaOffset = (_o.EffectDa == null) ? default(StringOffset) : builder.CreateString(_o.EffectDa);
			return IFinishJellyfishReturnCondition.CreateIFinishJellyfishReturnCondition(builder, _o.Type, preConditionsOffset, _o.StartPosEntityId, _o.StartRadius, _o.EndPosEntityId, _o.EndRadius, levelConfigDaOffset, effectDaOffset);
		}

		// Token: 0x0400B7C1 RID: 47041
		private Table __p;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004274 RID: 17012
	public struct IFinishJellyfishReturnCondition : IFlatbufferObject
	{
		// Token: 0x1700740E RID: 29710
		// (get) Token: 0x06017B80 RID: 97152 RVA: 0x003621DA File Offset: 0x003603DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017B81 RID: 97153 RVA: 0x003621E7 File Offset: 0x003603E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017B82 RID: 97154 RVA: 0x003621F0 File Offset: 0x003603F0
		public static IFinishJellyfishReturnCondition GetRootAsIFinishJellyfishReturnCondition(ByteBuffer _bb)
		{
			return IFinishJellyfishReturnCondition.GetRootAsIFinishJellyfishReturnCondition(_bb, default(IFinishJellyfishReturnCondition));
		}

		// Token: 0x06017B83 RID: 97155 RVA: 0x0036220C File Offset: 0x0036040C
		public static IFinishJellyfishReturnCondition GetRootAsIFinishJellyfishReturnCondition(ByteBuffer _bb, IFinishJellyfishReturnCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017B84 RID: 97156 RVA: 0x00362229 File Offset: 0x00360429
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017B85 RID: 97157 RVA: 0x00362238 File Offset: 0x00360438
		public IFinishJellyfishReturnCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700740F RID: 29711
		// (get) Token: 0x06017B86 RID: 97158 RVA: 0x00362248 File Offset: 0x00360448
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

		// Token: 0x17007410 RID: 29712
		// (get) Token: 0x06017B87 RID: 97159 RVA: 0x00362284 File Offset: 0x00360484
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

		// Token: 0x17007411 RID: 29713
		// (get) Token: 0x06017B88 RID: 97160 RVA: 0x003622E4 File Offset: 0x003604E4
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

		// Token: 0x17007412 RID: 29714
		// (get) Token: 0x06017B89 RID: 97161 RVA: 0x00362320 File Offset: 0x00360520
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

		// Token: 0x17007413 RID: 29715
		// (get) Token: 0x06017B8A RID: 97162 RVA: 0x00362364 File Offset: 0x00360564
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

		// Token: 0x17007414 RID: 29716
		// (get) Token: 0x06017B8B RID: 97163 RVA: 0x003623A4 File Offset: 0x003605A4
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

		// Token: 0x17007415 RID: 29717
		// (get) Token: 0x06017B8C RID: 97164 RVA: 0x003623E8 File Offset: 0x003605E8
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

		// Token: 0x06017B8D RID: 97165 RVA: 0x00362420 File Offset: 0x00360620
		public Span<byte> GetLevelConfigDaBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06017B8E RID: 97166 RVA: 0x00362430 File Offset: 0x00360630
		public byte[] GetLevelConfigDaArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x06017B8F RID: 97167 RVA: 0x00362440 File Offset: 0x00360640
		public static Offset<IFinishJellyfishReturnCondition> CreateIFinishJellyfishReturnCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int StartPosEntityId = 0, float StartRadius = 0f, int EndPosEntityId = 0, float EndRadius = 0f, StringOffset LevelConfigDaOffset = default(StringOffset))
		{
			builder.StartTable(7);
			IFinishJellyfishReturnCondition.AddLevelConfigDa(builder, LevelConfigDaOffset);
			IFinishJellyfishReturnCondition.AddEndRadius(builder, EndRadius);
			IFinishJellyfishReturnCondition.AddEndPosEntityId(builder, EndPosEntityId);
			IFinishJellyfishReturnCondition.AddStartRadius(builder, StartRadius);
			IFinishJellyfishReturnCondition.AddStartPosEntityId(builder, StartPosEntityId);
			IFinishJellyfishReturnCondition.AddPreConditions(builder, PreConditionsOffset);
			IFinishJellyfishReturnCondition.AddType(builder, Type);
			return IFinishJellyfishReturnCondition.EndIFinishJellyfishReturnCondition(builder);
		}

		// Token: 0x06017B90 RID: 97168 RVA: 0x0036248F File Offset: 0x0036068F
		public static void StartIFinishJellyfishReturnCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06017B91 RID: 97169 RVA: 0x00362498 File Offset: 0x00360698
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017B92 RID: 97170 RVA: 0x003624A3 File Offset: 0x003606A3
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017B93 RID: 97171 RVA: 0x003624B3 File Offset: 0x003606B3
		public static void AddStartPosEntityId(FlatBufferBuilder builder, int startPosEntityId)
		{
			builder.AddInt(2, startPosEntityId, 0);
		}

		// Token: 0x06017B94 RID: 97172 RVA: 0x003624BE File Offset: 0x003606BE
		public static void AddStartRadius(FlatBufferBuilder builder, float startRadius)
		{
			builder.AddFloat(3, startRadius, 0.0);
		}

		// Token: 0x06017B95 RID: 97173 RVA: 0x003624D1 File Offset: 0x003606D1
		public static void AddEndPosEntityId(FlatBufferBuilder builder, int endPosEntityId)
		{
			builder.AddInt(4, endPosEntityId, 0);
		}

		// Token: 0x06017B96 RID: 97174 RVA: 0x003624DC File Offset: 0x003606DC
		public static void AddEndRadius(FlatBufferBuilder builder, float endRadius)
		{
			builder.AddFloat(5, endRadius, 0.0);
		}

		// Token: 0x06017B97 RID: 97175 RVA: 0x003624EF File Offset: 0x003606EF
		public static void AddLevelConfigDa(FlatBufferBuilder builder, StringOffset levelConfigDaOffset)
		{
			builder.AddOffset(6, levelConfigDaOffset.Value, 0);
		}

		// Token: 0x06017B98 RID: 97176 RVA: 0x003624FF File Offset: 0x003606FF
		public static Offset<IFinishJellyfishReturnCondition> EndIFinishJellyfishReturnCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishJellyfishReturnCondition>(builder.EndTable());
		}

		// Token: 0x06017B99 RID: 97177 RVA: 0x0036250C File Offset: 0x0036070C
		public IFinishJellyfishReturnConditionT UnPack()
		{
			IFinishJellyfishReturnConditionT finishJellyfishReturnConditionT = new IFinishJellyfishReturnConditionT();
			this.UnPackTo(finishJellyfishReturnConditionT);
			return finishJellyfishReturnConditionT;
		}

		// Token: 0x06017B9A RID: 97178 RVA: 0x00362528 File Offset: 0x00360728
		public void UnPackTo(IFinishJellyfishReturnConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.StartPosEntityId = this.StartPosEntityId;
			_o.StartRadius = this.StartRadius;
			_o.EndPosEntityId = this.EndPosEntityId;
			_o.EndRadius = this.EndRadius;
			_o.LevelConfigDa = this.LevelConfigDa;
		}

		// Token: 0x06017B9B RID: 97179 RVA: 0x003625AC File Offset: 0x003607AC
		public static Offset<IFinishJellyfishReturnCondition> Pack(FlatBufferBuilder builder, IFinishJellyfishReturnConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishJellyfishReturnCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			StringOffset levelConfigDaOffset = (_o.LevelConfigDa == null) ? default(StringOffset) : builder.CreateString(_o.LevelConfigDa);
			return IFinishJellyfishReturnCondition.CreateIFinishJellyfishReturnCondition(builder, _o.Type, preConditionsOffset, _o.StartPosEntityId, _o.StartRadius, _o.EndPosEntityId, _o.EndRadius, levelConfigDaOffset);
		}

		// Token: 0x0400C199 RID: 49561
		private Table __p;
	}
}

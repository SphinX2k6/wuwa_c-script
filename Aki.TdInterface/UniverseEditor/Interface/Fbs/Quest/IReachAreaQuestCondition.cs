using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200406A RID: 16490
	public struct IReachAreaQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007445 RID: 29765
		// (get) Token: 0x06017F2F RID: 98095 RVA: 0x00374C4D File Offset: 0x00372E4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017F30 RID: 98096 RVA: 0x00374C5A File Offset: 0x00372E5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017F31 RID: 98097 RVA: 0x00374C64 File Offset: 0x00372E64
		public static IReachAreaQuestCondition GetRootAsIReachAreaQuestCondition(ByteBuffer _bb)
		{
			return IReachAreaQuestCondition.GetRootAsIReachAreaQuestCondition(_bb, default(IReachAreaQuestCondition));
		}

		// Token: 0x06017F32 RID: 98098 RVA: 0x00374C80 File Offset: 0x00372E80
		public static IReachAreaQuestCondition GetRootAsIReachAreaQuestCondition(ByteBuffer _bb, IReachAreaQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017F33 RID: 98099 RVA: 0x00374C9D File Offset: 0x00372E9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017F34 RID: 98100 RVA: 0x00374CAC File Offset: 0x00372EAC
		public IReachAreaQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007446 RID: 29766
		// (get) Token: 0x06017F35 RID: 98101 RVA: 0x00374CBC File Offset: 0x00372EBC
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

		// Token: 0x17007447 RID: 29767
		// (get) Token: 0x06017F36 RID: 98102 RVA: 0x00374CF8 File Offset: 0x00372EF8
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

		// Token: 0x17007448 RID: 29768
		// (get) Token: 0x06017F37 RID: 98103 RVA: 0x00374D58 File Offset: 0x00372F58
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007449 RID: 29769
		// (get) Token: 0x06017F38 RID: 98104 RVA: 0x00374DB8 File Offset: 0x00372FB8
		public int Range
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

		// Token: 0x1700744A RID: 29770
		// (get) Token: 0x06017F39 RID: 98105 RVA: 0x00374DF8 File Offset: 0x00372FF8
		public int EntityId
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

		// Token: 0x1700744B RID: 29771
		// (get) Token: 0x06017F3A RID: 98106 RVA: 0x00374E38 File Offset: 0x00373038
		public int RangeEntityId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017F3B RID: 98107 RVA: 0x00374E78 File Offset: 0x00373078
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700744C RID: 29772
		// (get) Token: 0x06017F3C RID: 98108 RVA: 0x00374EB8 File Offset: 0x003730B8
		public int RangeEntitiesLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017F3D RID: 98109 RVA: 0x00374EE4 File Offset: 0x003730E4
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06017F3E RID: 98110 RVA: 0x00374EF4 File Offset: 0x003730F4
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(16);
		}

		// Token: 0x06017F3F RID: 98111 RVA: 0x00374F04 File Offset: 0x00373104
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700744D RID: 29773
		// (get) Token: 0x06017F40 RID: 98112 RVA: 0x00374F44 File Offset: 0x00373144
		public int MatchRoleOptionTypeLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017F41 RID: 98113 RVA: 0x00374F70 File Offset: 0x00373170
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(18, 1);
		}

		// Token: 0x06017F42 RID: 98114 RVA: 0x00374F80 File Offset: 0x00373180
		public TMatchRoleOption[] GetMatchRoleOptionTypeArray()
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TMatchRoleOption[] array = new TMatchRoleOption[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TMatchRoleOption)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06017F43 RID: 98115 RVA: 0x00374FEC File Offset: 0x003731EC
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700744E RID: 29774
		// (get) Token: 0x06017F44 RID: 98116 RVA: 0x00375034 File Offset: 0x00373234
		public int MatchRoleOptionLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700744F RID: 29775
		// (get) Token: 0x06017F45 RID: 98117 RVA: 0x00375060 File Offset: 0x00373260
		public string EffectPath
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017F46 RID: 98118 RVA: 0x00375098 File Offset: 0x00373298
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06017F47 RID: 98119 RVA: 0x003750A8 File Offset: 0x003732A8
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17007450 RID: 29776
		// (get) Token: 0x06017F48 RID: 98120 RVA: 0x003750B8 File Offset: 0x003732B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017F49 RID: 98121 RVA: 0x003750F8 File Offset: 0x003732F8
		public static Offset<IReachAreaQuestCondition> CreateIReachAreaQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), int Range = 0, int EntityId = 0, int RangeEntityId = 0, VectorOffset RangeEntitiesOffset = default(VectorOffset), VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), StringOffset EffectPathOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(11);
			IReachAreaQuestCondition.AddEffectPath(builder, EffectPathOffset);
			IReachAreaQuestCondition.AddMatchRoleOption(builder, MatchRoleOptionOffset);
			IReachAreaQuestCondition.AddMatchRoleOptionType(builder, MatchRoleOption_typeOffset);
			IReachAreaQuestCondition.AddRangeEntities(builder, RangeEntitiesOffset);
			IReachAreaQuestCondition.AddRangeEntityId(builder, RangeEntityId);
			IReachAreaQuestCondition.AddEntityId(builder, EntityId);
			IReachAreaQuestCondition.AddRange(builder, Range);
			IReachAreaQuestCondition.AddPos(builder, PosOffset);
			IReachAreaQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IReachAreaQuestCondition.AddNullMask(builder, NullMask);
			IReachAreaQuestCondition.AddType(builder, Type);
			return IReachAreaQuestCondition.EndIReachAreaQuestCondition(builder);
		}

		// Token: 0x06017F4A RID: 98122 RVA: 0x00375168 File Offset: 0x00373368
		public static void StartIReachAreaQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06017F4B RID: 98123 RVA: 0x00375172 File Offset: 0x00373372
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017F4C RID: 98124 RVA: 0x0037517D File Offset: 0x0037337D
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017F4D RID: 98125 RVA: 0x0037518D File Offset: 0x0037338D
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x06017F4E RID: 98126 RVA: 0x0037519D File Offset: 0x0037339D
		public static void AddRange(FlatBufferBuilder builder, int range)
		{
			builder.AddInt(3, range, 0);
		}

		// Token: 0x06017F4F RID: 98127 RVA: 0x003751A8 File Offset: 0x003733A8
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(4, entityId, 0);
		}

		// Token: 0x06017F50 RID: 98128 RVA: 0x003751B3 File Offset: 0x003733B3
		public static void AddRangeEntityId(FlatBufferBuilder builder, int rangeEntityId)
		{
			builder.AddInt(5, rangeEntityId, 0);
		}

		// Token: 0x06017F51 RID: 98129 RVA: 0x003751BE File Offset: 0x003733BE
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(6, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x06017F52 RID: 98130 RVA: 0x003751D0 File Offset: 0x003733D0
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017F53 RID: 98131 RVA: 0x00375207 File Offset: 0x00373407
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F54 RID: 98132 RVA: 0x00375221 File Offset: 0x00373421
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F55 RID: 98133 RVA: 0x0037523F File Offset: 0x0037343F
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017F56 RID: 98134 RVA: 0x00375258 File Offset: 0x00373458
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017F57 RID: 98135 RVA: 0x00375263 File Offset: 0x00373463
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(7, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x06017F58 RID: 98136 RVA: 0x00375274 File Offset: 0x00373474
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017F59 RID: 98137 RVA: 0x003752AB File Offset: 0x003734AB
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F5A RID: 98138 RVA: 0x003752C5 File Offset: 0x003734C5
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F5B RID: 98139 RVA: 0x003752E3 File Offset: 0x003734E3
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017F5C RID: 98140 RVA: 0x003752FC File Offset: 0x003734FC
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06017F5D RID: 98141 RVA: 0x00375307 File Offset: 0x00373507
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(8, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x06017F5E RID: 98142 RVA: 0x00375318 File Offset: 0x00373518
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017F5F RID: 98143 RVA: 0x0037534F File Offset: 0x0037354F
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F60 RID: 98144 RVA: 0x00375369 File Offset: 0x00373569
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F61 RID: 98145 RVA: 0x00375387 File Offset: 0x00373587
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017F62 RID: 98146 RVA: 0x003753A0 File Offset: 0x003735A0
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017F63 RID: 98147 RVA: 0x003753AB File Offset: 0x003735AB
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(9, effectPathOffset.Value, 0);
		}

		// Token: 0x06017F64 RID: 98148 RVA: 0x003753BC File Offset: 0x003735BC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06017F65 RID: 98149 RVA: 0x003753C8 File Offset: 0x003735C8
		public static Offset<IReachAreaQuestCondition> EndIReachAreaQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IReachAreaQuestCondition>(builder.EndTable());
		}

		// Token: 0x06017F66 RID: 98150 RVA: 0x003753D8 File Offset: 0x003735D8
		public IReachAreaQuestConditionT UnPack()
		{
			IReachAreaQuestConditionT reachAreaQuestConditionT = new IReachAreaQuestConditionT();
			this.UnPackTo(reachAreaQuestConditionT);
			return reachAreaQuestConditionT;
		}

		// Token: 0x06017F67 RID: 98151 RVA: 0x003753F4 File Offset: 0x003735F4
		public void UnPackTo(IReachAreaQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Range = this.Range;
			_o.EntityId = this.EntityId;
			_o.RangeEntityId = this.RangeEntityId;
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
			_o.MatchRoleOption = new List<TMatchRoleOptionUnion>();
			for (int j = 0; j < this.MatchRoleOptionLength; j++)
			{
				TMatchRoleOptionUnion tmatchRoleOptionUnion = new TMatchRoleOptionUnion();
				tmatchRoleOptionUnion.Type = this.MatchRoleOptionType(j);
				TMatchRoleOption tmatchRoleOption = this.MatchRoleOptionType(j);
				if (tmatchRoleOption != TMatchRoleOption.IMatchPhantomRole)
				{
					if (tmatchRoleOption == TMatchRoleOption.IMatchPlayerRole)
					{
						tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(j) != null) ? this.MatchRoleOption<IMatchPlayerRole>(j).Value.UnPack() : null);
					}
				}
				else
				{
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(j) != null) ? this.MatchRoleOption<IMatchPhantomRole>(j).Value.UnPack() : null);
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.EffectPath = this.EffectPath;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017F68 RID: 98152 RVA: 0x003755AC File Offset: 0x003737AC
		public static Offset<IReachAreaQuestCondition> Pack(FlatBufferBuilder builder, IReachAreaQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReachAreaQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = IReachAreaQuestCondition.CreateRangeEntitiesVector(builder, data);
			}
			VectorOffset matchRoleOption_typeOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				TMatchRoleOption[] array = new TMatchRoleOption[_o.MatchRoleOption.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.MatchRoleOption[i].Type;
				}
				matchRoleOption_typeOffset = IReachAreaQuestCondition.CreateMatchRoleOptionTypeVector(builder, array);
			}
			VectorOffset matchRoleOptionOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				int[] array2 = new int[_o.MatchRoleOption.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TMatchRoleOptionUnion.Pack(builder, _o.MatchRoleOption[j]);
				}
				matchRoleOptionOffset = IReachAreaQuestCondition.CreateMatchRoleOptionVector(builder, array2);
			}
			StringOffset effectPathOffset = (_o.EffectPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectPath);
			return IReachAreaQuestCondition.CreateIReachAreaQuestCondition(builder, _o.Type, preConditionsOffset, posOffset, _o.Range, _o.EntityId, _o.RangeEntityId, rangeEntitiesOffset, matchRoleOption_typeOffset, matchRoleOptionOffset, effectPathOffset, _o.NullMask);
		}

		// Token: 0x0400BBDA RID: 48090
		private Table __p;
	}
}

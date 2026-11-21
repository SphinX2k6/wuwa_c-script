using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044AB RID: 17579
	public struct IReachAreaQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007A47 RID: 31303
		// (get) Token: 0x060195C8 RID: 103880 RVA: 0x0039EA41 File Offset: 0x0039CC41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060195C9 RID: 103881 RVA: 0x0039EA4E File Offset: 0x0039CC4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060195CA RID: 103882 RVA: 0x0039EA58 File Offset: 0x0039CC58
		public static IReachAreaQuestCondition GetRootAsIReachAreaQuestCondition(ByteBuffer _bb)
		{
			return IReachAreaQuestCondition.GetRootAsIReachAreaQuestCondition(_bb, default(IReachAreaQuestCondition));
		}

		// Token: 0x060195CB RID: 103883 RVA: 0x0039EA74 File Offset: 0x0039CC74
		public static IReachAreaQuestCondition GetRootAsIReachAreaQuestCondition(ByteBuffer _bb, IReachAreaQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060195CC RID: 103884 RVA: 0x0039EA91 File Offset: 0x0039CC91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060195CD RID: 103885 RVA: 0x0039EAA0 File Offset: 0x0039CCA0
		public IReachAreaQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A48 RID: 31304
		// (get) Token: 0x060195CE RID: 103886 RVA: 0x0039EAB0 File Offset: 0x0039CCB0
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

		// Token: 0x17007A49 RID: 31305
		// (get) Token: 0x060195CF RID: 103887 RVA: 0x0039EAEC File Offset: 0x0039CCEC
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

		// Token: 0x17007A4A RID: 31306
		// (get) Token: 0x060195D0 RID: 103888 RVA: 0x0039EB4C File Offset: 0x0039CD4C
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

		// Token: 0x17007A4B RID: 31307
		// (get) Token: 0x060195D1 RID: 103889 RVA: 0x0039EBAC File Offset: 0x0039CDAC
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

		// Token: 0x17007A4C RID: 31308
		// (get) Token: 0x060195D2 RID: 103890 RVA: 0x0039EBEC File Offset: 0x0039CDEC
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

		// Token: 0x17007A4D RID: 31309
		// (get) Token: 0x060195D3 RID: 103891 RVA: 0x0039EC2C File Offset: 0x0039CE2C
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

		// Token: 0x060195D4 RID: 103892 RVA: 0x0039EC6C File Offset: 0x0039CE6C
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007A4E RID: 31310
		// (get) Token: 0x060195D5 RID: 103893 RVA: 0x0039ECAC File Offset: 0x0039CEAC
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

		// Token: 0x060195D6 RID: 103894 RVA: 0x0039ECD8 File Offset: 0x0039CED8
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x060195D7 RID: 103895 RVA: 0x0039ECE8 File Offset: 0x0039CEE8
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(16);
		}

		// Token: 0x060195D8 RID: 103896 RVA: 0x0039ECF8 File Offset: 0x0039CEF8
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007A4F RID: 31311
		// (get) Token: 0x060195D9 RID: 103897 RVA: 0x0039ED38 File Offset: 0x0039CF38
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

		// Token: 0x060195DA RID: 103898 RVA: 0x0039ED64 File Offset: 0x0039CF64
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(18, 1);
		}

		// Token: 0x060195DB RID: 103899 RVA: 0x0039ED74 File Offset: 0x0039CF74
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

		// Token: 0x060195DC RID: 103900 RVA: 0x0039EDE0 File Offset: 0x0039CFE0
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007A50 RID: 31312
		// (get) Token: 0x060195DD RID: 103901 RVA: 0x0039EE28 File Offset: 0x0039D028
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

		// Token: 0x17007A51 RID: 31313
		// (get) Token: 0x060195DE RID: 103902 RVA: 0x0039EE54 File Offset: 0x0039D054
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

		// Token: 0x060195DF RID: 103903 RVA: 0x0039EE8C File Offset: 0x0039D08C
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060195E0 RID: 103904 RVA: 0x0039EE9C File Offset: 0x0039D09C
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17007A52 RID: 31314
		// (get) Token: 0x060195E1 RID: 103905 RVA: 0x0039EEAC File Offset: 0x0039D0AC
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

		// Token: 0x060195E2 RID: 103906 RVA: 0x0039EEEC File Offset: 0x0039D0EC
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

		// Token: 0x060195E3 RID: 103907 RVA: 0x0039EF5C File Offset: 0x0039D15C
		public static void StartIReachAreaQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x060195E4 RID: 103908 RVA: 0x0039EF66 File Offset: 0x0039D166
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060195E5 RID: 103909 RVA: 0x0039EF71 File Offset: 0x0039D171
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060195E6 RID: 103910 RVA: 0x0039EF81 File Offset: 0x0039D181
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x060195E7 RID: 103911 RVA: 0x0039EF91 File Offset: 0x0039D191
		public static void AddRange(FlatBufferBuilder builder, int range)
		{
			builder.AddInt(3, range, 0);
		}

		// Token: 0x060195E8 RID: 103912 RVA: 0x0039EF9C File Offset: 0x0039D19C
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(4, entityId, 0);
		}

		// Token: 0x060195E9 RID: 103913 RVA: 0x0039EFA7 File Offset: 0x0039D1A7
		public static void AddRangeEntityId(FlatBufferBuilder builder, int rangeEntityId)
		{
			builder.AddInt(5, rangeEntityId, 0);
		}

		// Token: 0x060195EA RID: 103914 RVA: 0x0039EFB2 File Offset: 0x0039D1B2
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(6, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x060195EB RID: 103915 RVA: 0x0039EFC4 File Offset: 0x0039D1C4
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060195EC RID: 103916 RVA: 0x0039EFFB File Offset: 0x0039D1FB
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060195ED RID: 103917 RVA: 0x0039F015 File Offset: 0x0039D215
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060195EE RID: 103918 RVA: 0x0039F033 File Offset: 0x0039D233
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060195EF RID: 103919 RVA: 0x0039F04C File Offset: 0x0039D24C
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060195F0 RID: 103920 RVA: 0x0039F057 File Offset: 0x0039D257
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(7, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x060195F1 RID: 103921 RVA: 0x0039F068 File Offset: 0x0039D268
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060195F2 RID: 103922 RVA: 0x0039F09F File Offset: 0x0039D29F
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x060195F3 RID: 103923 RVA: 0x0039F0B9 File Offset: 0x0039D2B9
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x060195F4 RID: 103924 RVA: 0x0039F0D7 File Offset: 0x0039D2D7
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060195F5 RID: 103925 RVA: 0x0039F0F0 File Offset: 0x0039D2F0
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060195F6 RID: 103926 RVA: 0x0039F0FB File Offset: 0x0039D2FB
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(8, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x060195F7 RID: 103927 RVA: 0x0039F10C File Offset: 0x0039D30C
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060195F8 RID: 103928 RVA: 0x0039F143 File Offset: 0x0039D343
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060195F9 RID: 103929 RVA: 0x0039F15D File Offset: 0x0039D35D
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060195FA RID: 103930 RVA: 0x0039F17B File Offset: 0x0039D37B
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060195FB RID: 103931 RVA: 0x0039F194 File Offset: 0x0039D394
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060195FC RID: 103932 RVA: 0x0039F19F File Offset: 0x0039D39F
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(9, effectPathOffset.Value, 0);
		}

		// Token: 0x060195FD RID: 103933 RVA: 0x0039F1B0 File Offset: 0x0039D3B0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x060195FE RID: 103934 RVA: 0x0039F1BC File Offset: 0x0039D3BC
		public static Offset<IReachAreaQuestCondition> EndIReachAreaQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IReachAreaQuestCondition>(builder.EndTable());
		}

		// Token: 0x060195FF RID: 103935 RVA: 0x0039F1CC File Offset: 0x0039D3CC
		public IReachAreaQuestConditionT UnPack()
		{
			IReachAreaQuestConditionT reachAreaQuestConditionT = new IReachAreaQuestConditionT();
			this.UnPackTo(reachAreaQuestConditionT);
			return reachAreaQuestConditionT;
		}

		// Token: 0x06019600 RID: 103936 RVA: 0x0039F1E8 File Offset: 0x0039D3E8
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
				switch (this.MatchRoleOptionType(j))
				{
				case TMatchRoleOption.IMatchAssistCharacterRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchAssistCharacterRole>(j) != null) ? this.MatchRoleOption<IMatchAssistCharacterRole>(j).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPhantomRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(j) != null) ? this.MatchRoleOption<IMatchPhantomRole>(j).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPlayerRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(j) != null) ? this.MatchRoleOption<IMatchPlayerRole>(j).Value.UnPack() : null);
					break;
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.EffectPath = this.EffectPath;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019601 RID: 103937 RVA: 0x0039F3E4 File Offset: 0x0039D5E4
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

		// Token: 0x0400C5C1 RID: 50625
		private Table __p;
	}
}

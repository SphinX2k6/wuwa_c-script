using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043B5 RID: 17333
	public struct IParkourQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007758 RID: 30552
		// (get) Token: 0x0601895B RID: 100699 RVA: 0x00381DC0 File Offset: 0x0037FFC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601895C RID: 100700 RVA: 0x00381DCD File Offset: 0x0037FFCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601895D RID: 100701 RVA: 0x00381DD4 File Offset: 0x0037FFD4
		public static IParkourQuestCondition GetRootAsIParkourQuestCondition(ByteBuffer _bb)
		{
			return IParkourQuestCondition.GetRootAsIParkourQuestCondition(_bb, default(IParkourQuestCondition));
		}

		// Token: 0x0601895E RID: 100702 RVA: 0x00381DF0 File Offset: 0x0037FFF0
		public static IParkourQuestCondition GetRootAsIParkourQuestCondition(ByteBuffer _bb, IParkourQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601895F RID: 100703 RVA: 0x00381E0D File Offset: 0x0038000D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018960 RID: 100704 RVA: 0x00381E1C File Offset: 0x0038001C
		public IParkourQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007759 RID: 30553
		// (get) Token: 0x06018961 RID: 100705 RVA: 0x00381E2C File Offset: 0x0038002C
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

		// Token: 0x1700775A RID: 30554
		// (get) Token: 0x06018962 RID: 100706 RVA: 0x00381E68 File Offset: 0x00380068
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

		// Token: 0x1700775B RID: 30555
		// (get) Token: 0x06018963 RID: 100707 RVA: 0x00381EC8 File Offset: 0x003800C8
		public string Config
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018964 RID: 100708 RVA: 0x00381EFF File Offset: 0x003800FF
		public Span<byte> GetConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06018965 RID: 100709 RVA: 0x00381F0E File Offset: 0x0038010E
		public byte[] GetConfigArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700775C RID: 30556
		// (get) Token: 0x06018966 RID: 100710 RVA: 0x00381F1C File Offset: 0x0038011C
		public int SplineEntityId
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

		// Token: 0x06018967 RID: 100711 RVA: 0x00381F5C File Offset: 0x0038015C
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700775D RID: 30557
		// (get) Token: 0x06018968 RID: 100712 RVA: 0x00381F9C File Offset: 0x0038019C
		public int MatchRoleOptionTypeLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06018969 RID: 100713 RVA: 0x00381FC8 File Offset: 0x003801C8
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(12, 1);
		}

		// Token: 0x0601896A RID: 100714 RVA: 0x00381FD8 File Offset: 0x003801D8
		public TMatchRoleOption[] GetMatchRoleOptionTypeArray()
		{
			int num = this.__p.__offset(12);
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

		// Token: 0x0601896B RID: 100715 RVA: 0x00382044 File Offset: 0x00380244
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700775E RID: 30558
		// (get) Token: 0x0601896C RID: 100716 RVA: 0x0038208C File Offset: 0x0038028C
		public int MatchRoleOptionLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700775F RID: 30559
		// (get) Token: 0x0601896D RID: 100717 RVA: 0x003820B8 File Offset: 0x003802B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601896E RID: 100718 RVA: 0x003820F8 File Offset: 0x003802F8
		public static Offset<IParkourQuestCondition> CreateIParkourQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), StringOffset ConfigOffset = default(StringOffset), int SplineEntityId = 0, VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IParkourQuestCondition.AddMatchRoleOption(builder, MatchRoleOptionOffset);
			IParkourQuestCondition.AddMatchRoleOptionType(builder, MatchRoleOption_typeOffset);
			IParkourQuestCondition.AddSplineEntityId(builder, SplineEntityId);
			IParkourQuestCondition.AddConfig(builder, ConfigOffset);
			IParkourQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IParkourQuestCondition.AddNullMask(builder, NullMask);
			IParkourQuestCondition.AddType(builder, Type);
			return IParkourQuestCondition.EndIParkourQuestCondition(builder);
		}

		// Token: 0x0601896F RID: 100719 RVA: 0x00382147 File Offset: 0x00380347
		public static void StartIParkourQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06018970 RID: 100720 RVA: 0x00382150 File Offset: 0x00380350
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018971 RID: 100721 RVA: 0x0038215B File Offset: 0x0038035B
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018972 RID: 100722 RVA: 0x0038216B File Offset: 0x0038036B
		public static void AddConfig(FlatBufferBuilder builder, StringOffset configOffset)
		{
			builder.AddOffset(2, configOffset.Value, 0);
		}

		// Token: 0x06018973 RID: 100723 RVA: 0x0038217B File Offset: 0x0038037B
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x06018974 RID: 100724 RVA: 0x00382186 File Offset: 0x00380386
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(4, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x06018975 RID: 100725 RVA: 0x00382198 File Offset: 0x00380398
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018976 RID: 100726 RVA: 0x003821CF File Offset: 0x003803CF
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06018977 RID: 100727 RVA: 0x003821E9 File Offset: 0x003803E9
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06018978 RID: 100728 RVA: 0x00382207 File Offset: 0x00380407
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018979 RID: 100729 RVA: 0x00382220 File Offset: 0x00380420
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601897A RID: 100730 RVA: 0x0038222B File Offset: 0x0038042B
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(5, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x0601897B RID: 100731 RVA: 0x0038223C File Offset: 0x0038043C
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601897C RID: 100732 RVA: 0x00382273 File Offset: 0x00380473
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601897D RID: 100733 RVA: 0x0038228D File Offset: 0x0038048D
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601897E RID: 100734 RVA: 0x003822AB File Offset: 0x003804AB
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601897F RID: 100735 RVA: 0x003822C4 File Offset: 0x003804C4
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018980 RID: 100736 RVA: 0x003822CF File Offset: 0x003804CF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06018981 RID: 100737 RVA: 0x003822DA File Offset: 0x003804DA
		public static Offset<IParkourQuestCondition> EndIParkourQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IParkourQuestCondition>(builder.EndTable());
		}

		// Token: 0x06018982 RID: 100738 RVA: 0x003822E8 File Offset: 0x003804E8
		public IParkourQuestConditionT UnPack()
		{
			IParkourQuestConditionT parkourQuestConditionT = new IParkourQuestConditionT();
			this.UnPackTo(parkourQuestConditionT);
			return parkourQuestConditionT;
		}

		// Token: 0x06018983 RID: 100739 RVA: 0x00382304 File Offset: 0x00380504
		public void UnPackTo(IParkourQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Config = this.Config;
			_o.SplineEntityId = this.SplineEntityId;
			_o.MatchRoleOption = new List<TMatchRoleOptionUnion>();
			for (int i = 0; i < this.MatchRoleOptionLength; i++)
			{
				TMatchRoleOptionUnion tmatchRoleOptionUnion = new TMatchRoleOptionUnion();
				tmatchRoleOptionUnion.Type = this.MatchRoleOptionType(i);
				switch (this.MatchRoleOptionType(i))
				{
				case TMatchRoleOption.IMatchAssistCharacterRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchAssistCharacterRole>(i) != null) ? this.MatchRoleOption<IMatchAssistCharacterRole>(i).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPhantomRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(i) != null) ? this.MatchRoleOption<IMatchPhantomRole>(i).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPlayerRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(i) != null) ? this.MatchRoleOption<IMatchPlayerRole>(i).Value.UnPack() : null);
					break;
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018984 RID: 100740 RVA: 0x00382474 File Offset: 0x00380674
		public static Offset<IParkourQuestCondition> Pack(FlatBufferBuilder builder, IParkourQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParkourQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			StringOffset configOffset = (_o.Config == null) ? default(StringOffset) : builder.CreateString(_o.Config);
			VectorOffset matchRoleOption_typeOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				TMatchRoleOption[] array = new TMatchRoleOption[_o.MatchRoleOption.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.MatchRoleOption[i].Type;
				}
				matchRoleOption_typeOffset = IParkourQuestCondition.CreateMatchRoleOptionTypeVector(builder, array);
			}
			VectorOffset matchRoleOptionOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				int[] array2 = new int[_o.MatchRoleOption.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TMatchRoleOptionUnion.Pack(builder, _o.MatchRoleOption[j]);
				}
				matchRoleOptionOffset = IParkourQuestCondition.CreateMatchRoleOptionVector(builder, array2);
			}
			return IParkourQuestCondition.CreateIParkourQuestCondition(builder, _o.Type, preConditionsOffset, configOffset, _o.SplineEntityId, matchRoleOption_typeOffset, matchRoleOptionOffset, _o.NullMask);
		}

		// Token: 0x0400C3A7 RID: 50087
		private Table __p;
	}
}

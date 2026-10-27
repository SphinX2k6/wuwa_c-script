using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F74 RID: 16244
	public struct IParkourQuestCondition : IFlatbufferObject
	{
		// Token: 0x1700715A RID: 29018
		// (get) Token: 0x060172CC RID: 94924 RVA: 0x003581EC File Offset: 0x003563EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060172CD RID: 94925 RVA: 0x003581F9 File Offset: 0x003563F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060172CE RID: 94926 RVA: 0x00358200 File Offset: 0x00356400
		public static IParkourQuestCondition GetRootAsIParkourQuestCondition(ByteBuffer _bb)
		{
			return IParkourQuestCondition.GetRootAsIParkourQuestCondition(_bb, default(IParkourQuestCondition));
		}

		// Token: 0x060172CF RID: 94927 RVA: 0x0035821C File Offset: 0x0035641C
		public static IParkourQuestCondition GetRootAsIParkourQuestCondition(ByteBuffer _bb, IParkourQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060172D0 RID: 94928 RVA: 0x00358239 File Offset: 0x00356439
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060172D1 RID: 94929 RVA: 0x00358248 File Offset: 0x00356448
		public IParkourQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700715B RID: 29019
		// (get) Token: 0x060172D2 RID: 94930 RVA: 0x00358258 File Offset: 0x00356458
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

		// Token: 0x1700715C RID: 29020
		// (get) Token: 0x060172D3 RID: 94931 RVA: 0x00358294 File Offset: 0x00356494
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

		// Token: 0x1700715D RID: 29021
		// (get) Token: 0x060172D4 RID: 94932 RVA: 0x003582F4 File Offset: 0x003564F4
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

		// Token: 0x060172D5 RID: 94933 RVA: 0x0035832B File Offset: 0x0035652B
		public Span<byte> GetConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060172D6 RID: 94934 RVA: 0x0035833A File Offset: 0x0035653A
		public byte[] GetConfigArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700715E RID: 29022
		// (get) Token: 0x060172D7 RID: 94935 RVA: 0x00358348 File Offset: 0x00356548
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

		// Token: 0x060172D8 RID: 94936 RVA: 0x00358388 File Offset: 0x00356588
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700715F RID: 29023
		// (get) Token: 0x060172D9 RID: 94937 RVA: 0x003583C8 File Offset: 0x003565C8
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

		// Token: 0x060172DA RID: 94938 RVA: 0x003583F4 File Offset: 0x003565F4
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(12, 1);
		}

		// Token: 0x060172DB RID: 94939 RVA: 0x00358404 File Offset: 0x00356604
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

		// Token: 0x060172DC RID: 94940 RVA: 0x00358470 File Offset: 0x00356670
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007160 RID: 29024
		// (get) Token: 0x060172DD RID: 94941 RVA: 0x003584B8 File Offset: 0x003566B8
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

		// Token: 0x17007161 RID: 29025
		// (get) Token: 0x060172DE RID: 94942 RVA: 0x003584E4 File Offset: 0x003566E4
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

		// Token: 0x060172DF RID: 94943 RVA: 0x00358524 File Offset: 0x00356724
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

		// Token: 0x060172E0 RID: 94944 RVA: 0x00358573 File Offset: 0x00356773
		public static void StartIParkourQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060172E1 RID: 94945 RVA: 0x0035857C File Offset: 0x0035677C
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060172E2 RID: 94946 RVA: 0x00358587 File Offset: 0x00356787
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060172E3 RID: 94947 RVA: 0x00358597 File Offset: 0x00356797
		public static void AddConfig(FlatBufferBuilder builder, StringOffset configOffset)
		{
			builder.AddOffset(2, configOffset.Value, 0);
		}

		// Token: 0x060172E4 RID: 94948 RVA: 0x003585A7 File Offset: 0x003567A7
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x060172E5 RID: 94949 RVA: 0x003585B2 File Offset: 0x003567B2
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(4, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x060172E6 RID: 94950 RVA: 0x003585C4 File Offset: 0x003567C4
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060172E7 RID: 94951 RVA: 0x003585FB File Offset: 0x003567FB
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x060172E8 RID: 94952 RVA: 0x00358615 File Offset: 0x00356815
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x060172E9 RID: 94953 RVA: 0x00358633 File Offset: 0x00356833
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060172EA RID: 94954 RVA: 0x0035864C File Offset: 0x0035684C
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060172EB RID: 94955 RVA: 0x00358657 File Offset: 0x00356857
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(5, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x060172EC RID: 94956 RVA: 0x00358668 File Offset: 0x00356868
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060172ED RID: 94957 RVA: 0x0035869F File Offset: 0x0035689F
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060172EE RID: 94958 RVA: 0x003586B9 File Offset: 0x003568B9
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060172EF RID: 94959 RVA: 0x003586D7 File Offset: 0x003568D7
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060172F0 RID: 94960 RVA: 0x003586F0 File Offset: 0x003568F0
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060172F1 RID: 94961 RVA: 0x003586FB File Offset: 0x003568FB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060172F2 RID: 94962 RVA: 0x00358706 File Offset: 0x00356906
		public static Offset<IParkourQuestCondition> EndIParkourQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IParkourQuestCondition>(builder.EndTable());
		}

		// Token: 0x060172F3 RID: 94963 RVA: 0x00358714 File Offset: 0x00356914
		public IParkourQuestConditionT UnPack()
		{
			IParkourQuestConditionT parkourQuestConditionT = new IParkourQuestConditionT();
			this.UnPackTo(parkourQuestConditionT);
			return parkourQuestConditionT;
		}

		// Token: 0x060172F4 RID: 94964 RVA: 0x00358730 File Offset: 0x00356930
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
				TMatchRoleOption tmatchRoleOption = this.MatchRoleOptionType(i);
				if (tmatchRoleOption != TMatchRoleOption.IMatchPhantomRole)
				{
					if (tmatchRoleOption == TMatchRoleOption.IMatchPlayerRole)
					{
						tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(i) != null) ? this.MatchRoleOption<IMatchPlayerRole>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(i) != null) ? this.MatchRoleOption<IMatchPhantomRole>(i).Value.UnPack() : null);
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060172F5 RID: 94965 RVA: 0x0035885C File Offset: 0x00356A5C
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

		// Token: 0x0400B9C2 RID: 47554
		private Table __p;
	}
}

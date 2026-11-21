using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059AE RID: 22958
	public struct IInitStateStandby : IFlatbufferObject
	{
		// Token: 0x1700A6AC RID: 42668
		// (get) Token: 0x060256D5 RID: 153301 RVA: 0x00522471 File Offset: 0x00520671
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060256D6 RID: 153302 RVA: 0x0052247E File Offset: 0x0052067E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060256D7 RID: 153303 RVA: 0x00522488 File Offset: 0x00520688
		public static IInitStateStandby GetRootAsIInitStateStandby(ByteBuffer _bb)
		{
			return IInitStateStandby.GetRootAsIInitStateStandby(_bb, default(IInitStateStandby));
		}

		// Token: 0x060256D8 RID: 153304 RVA: 0x005224A4 File Offset: 0x005206A4
		public static IInitStateStandby GetRootAsIInitStateStandby(ByteBuffer _bb, IInitStateStandby obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060256D9 RID: 153305 RVA: 0x005224C1 File Offset: 0x005206C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060256DA RID: 153306 RVA: 0x005224D0 File Offset: 0x005206D0
		public IInitStateStandby __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6AD RID: 42669
		// (get) Token: 0x060256DB RID: 153307 RVA: 0x005224E0 File Offset: 0x005206E0
		public EInitStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInitStateType.Birth;
				}
				return (EInitStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060256DC RID: 153308 RVA: 0x0052251C File Offset: 0x0052071C
		public string StandbyTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A6AE RID: 42670
		// (get) Token: 0x060256DD RID: 153309 RVA: 0x00522558 File Offset: 0x00520758
		public int StandbyTagsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060256DE RID: 153310 RVA: 0x00522584 File Offset: 0x00520784
		public int EmotionBubbleIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A6AF RID: 42671
		// (get) Token: 0x060256DF RID: 153311 RVA: 0x005225C4 File Offset: 0x005207C4
		public int EmotionBubbleIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060256E0 RID: 153312 RVA: 0x005225EF File Offset: 0x005207EF
		public Span<int> GetEmotionBubbleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060256E1 RID: 153313 RVA: 0x005225FE File Offset: 0x005207FE
		public int[] GetEmotionBubbleIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x060256E2 RID: 153314 RVA: 0x0052260C File Offset: 0x0052080C
		public IConditionGroup? Conditions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A6B0 RID: 42672
		// (get) Token: 0x060256E3 RID: 153315 RVA: 0x00522670 File Offset: 0x00520870
		public int ConditionsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A6B1 RID: 42673
		// (get) Token: 0x060256E4 RID: 153316 RVA: 0x0052269C File Offset: 0x0052089C
		public EAiWanderType Wander
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EAiWanderType.None;
				}
				return (EAiWanderType)this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A6B2 RID: 42674
		// (get) Token: 0x060256E5 RID: 153317 RVA: 0x005226DC File Offset: 0x005208DC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060256E6 RID: 153318 RVA: 0x00522719 File Offset: 0x00520919
		public static Offset<IInitStateStandby> CreateIInitStateStandby(FlatBufferBuilder builder, EInitStateType Type = EInitStateType.Birth, VectorOffset StandbyTagsOffset = default(VectorOffset), VectorOffset EmotionBubbleIdsOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset), EAiWanderType Wander = EAiWanderType.None, byte NullMask = 0)
		{
			builder.StartTable(6);
			IInitStateStandby.AddConditions(builder, ConditionsOffset);
			IInitStateStandby.AddEmotionBubbleIds(builder, EmotionBubbleIdsOffset);
			IInitStateStandby.AddStandbyTags(builder, StandbyTagsOffset);
			IInitStateStandby.AddWander(builder, Wander);
			IInitStateStandby.AddNullMask(builder, NullMask);
			IInitStateStandby.AddType(builder, Type);
			return IInitStateStandby.EndIInitStateStandby(builder);
		}

		// Token: 0x060256E7 RID: 153319 RVA: 0x00522755 File Offset: 0x00520955
		public static void StartIInitStateStandby(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060256E8 RID: 153320 RVA: 0x0052275E File Offset: 0x0052095E
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060256E9 RID: 153321 RVA: 0x00522769 File Offset: 0x00520969
		public static void AddStandbyTags(FlatBufferBuilder builder, VectorOffset standbyTagsOffset)
		{
			builder.AddOffset(1, standbyTagsOffset.Value, 0);
		}

		// Token: 0x060256EA RID: 153322 RVA: 0x0052277C File Offset: 0x0052097C
		public static VectorOffset CreateStandbyTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060256EB RID: 153323 RVA: 0x005227BC File Offset: 0x005209BC
		public static VectorOffset CreateStandbyTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060256EC RID: 153324 RVA: 0x005227D6 File Offset: 0x005209D6
		public static VectorOffset CreateStandbyTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060256ED RID: 153325 RVA: 0x005227F4 File Offset: 0x005209F4
		public static VectorOffset CreateStandbyTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060256EE RID: 153326 RVA: 0x0052280D File Offset: 0x00520A0D
		public static void StartStandbyTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060256EF RID: 153327 RVA: 0x00522818 File Offset: 0x00520A18
		public static void AddEmotionBubbleIds(FlatBufferBuilder builder, VectorOffset emotionBubbleIdsOffset)
		{
			builder.AddOffset(2, emotionBubbleIdsOffset.Value, 0);
		}

		// Token: 0x060256F0 RID: 153328 RVA: 0x00522828 File Offset: 0x00520A28
		public static VectorOffset CreateEmotionBubbleIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060256F1 RID: 153329 RVA: 0x0052285F File Offset: 0x00520A5F
		public static VectorOffset CreateEmotionBubbleIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060256F2 RID: 153330 RVA: 0x00522879 File Offset: 0x00520A79
		public static VectorOffset CreateEmotionBubbleIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060256F3 RID: 153331 RVA: 0x00522897 File Offset: 0x00520A97
		public static VectorOffset CreateEmotionBubbleIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060256F4 RID: 153332 RVA: 0x005228B0 File Offset: 0x00520AB0
		public static void StartEmotionBubbleIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060256F5 RID: 153333 RVA: 0x005228BB File Offset: 0x00520ABB
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(3, conditionsOffset.Value, 0);
		}

		// Token: 0x060256F6 RID: 153334 RVA: 0x005228CC File Offset: 0x00520ACC
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<IConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060256F7 RID: 153335 RVA: 0x0052290C File Offset: 0x00520B0C
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x060256F8 RID: 153336 RVA: 0x00522926 File Offset: 0x00520B26
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x060256F9 RID: 153337 RVA: 0x00522944 File Offset: 0x00520B44
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060256FA RID: 153338 RVA: 0x0052295D File Offset: 0x00520B5D
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060256FB RID: 153339 RVA: 0x00522968 File Offset: 0x00520B68
		public static void AddWander(FlatBufferBuilder builder, EAiWanderType wander)
		{
			builder.AddUshort(4, (ushort)wander, 0);
		}

		// Token: 0x060256FC RID: 153340 RVA: 0x00522973 File Offset: 0x00520B73
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060256FD RID: 153341 RVA: 0x0052297E File Offset: 0x00520B7E
		public static Offset<IInitStateStandby> EndIInitStateStandby(FlatBufferBuilder builder)
		{
			return new Offset<IInitStateStandby>(builder.EndTable());
		}

		// Token: 0x060256FE RID: 153342 RVA: 0x0052298C File Offset: 0x00520B8C
		public IInitStateStandbyT UnPack()
		{
			IInitStateStandbyT initStateStandbyT = new IInitStateStandbyT();
			this.UnPackTo(initStateStandbyT);
			return initStateStandbyT;
		}

		// Token: 0x060256FF RID: 153343 RVA: 0x005229A8 File Offset: 0x00520BA8
		public void UnPackTo(IInitStateStandbyT _o)
		{
			_o.Type = this.Type;
			_o.StandbyTags = new List<string>();
			for (int i = 0; i < this.StandbyTagsLength; i++)
			{
				_o.StandbyTags.Add(this.StandbyTags(i));
			}
			_o.EmotionBubbleIds = new List<int>();
			for (int j = 0; j < this.EmotionBubbleIdsLength; j++)
			{
				_o.EmotionBubbleIds.Add(this.EmotionBubbleIds(j));
			}
			_o.Conditions = new List<IConditionGroupT>();
			for (int k = 0; k < this.ConditionsLength; k++)
			{
				_o.Conditions.Add((this.Conditions(k) != null) ? this.Conditions(k).Value.UnPack() : null);
			}
			_o.Wander = this.Wander;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025700 RID: 153344 RVA: 0x00522A88 File Offset: 0x00520C88
		public static Offset<IInitStateStandby> Pack(FlatBufferBuilder builder, IInitStateStandbyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitStateStandby>);
			}
			VectorOffset standbyTagsOffset = default(VectorOffset);
			if (_o.StandbyTags != null)
			{
				StringOffset[] array = new StringOffset[_o.StandbyTags.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.StandbyTags[i]);
				}
				standbyTagsOffset = IInitStateStandby.CreateStandbyTagsVector(builder, array);
			}
			VectorOffset emotionBubbleIdsOffset = default(VectorOffset);
			if (_o.EmotionBubbleIds != null)
			{
				int[] data = _o.EmotionBubbleIds.ToArray();
				emotionBubbleIdsOffset = IInitStateStandby.CreateEmotionBubbleIdsVector(builder, data);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<IConditionGroup>[] array2 = new Offset<IConditionGroup>[_o.Conditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IConditionGroup.Pack(builder, _o.Conditions[j]);
				}
				conditionsOffset = IInitStateStandby.CreateConditionsVector(builder, array2);
			}
			return IInitStateStandby.CreateIInitStateStandby(builder, _o.Type, standbyTagsOffset, emotionBubbleIdsOffset, conditionsOffset, _o.Wander, _o.NullMask);
		}

		// Token: 0x0400F2A1 RID: 62113
		private Table __p;
	}
}

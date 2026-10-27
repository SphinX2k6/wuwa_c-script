using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005428 RID: 21544
	public struct IInitStateStandby : IFlatbufferObject
	{
		// Token: 0x17009E72 RID: 40562
		// (get) Token: 0x0602361D RID: 144925 RVA: 0x004E5445 File Offset: 0x004E3645
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602361E RID: 144926 RVA: 0x004E5452 File Offset: 0x004E3652
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602361F RID: 144927 RVA: 0x004E545C File Offset: 0x004E365C
		public static IInitStateStandby GetRootAsIInitStateStandby(ByteBuffer _bb)
		{
			return IInitStateStandby.GetRootAsIInitStateStandby(_bb, default(IInitStateStandby));
		}

		// Token: 0x06023620 RID: 144928 RVA: 0x004E5478 File Offset: 0x004E3678
		public static IInitStateStandby GetRootAsIInitStateStandby(ByteBuffer _bb, IInitStateStandby obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023621 RID: 144929 RVA: 0x004E5495 File Offset: 0x004E3695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023622 RID: 144930 RVA: 0x004E54A4 File Offset: 0x004E36A4
		public IInitStateStandby __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E73 RID: 40563
		// (get) Token: 0x06023623 RID: 144931 RVA: 0x004E54B4 File Offset: 0x004E36B4
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

		// Token: 0x06023624 RID: 144932 RVA: 0x004E54F0 File Offset: 0x004E36F0
		public string StandbyTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009E74 RID: 40564
		// (get) Token: 0x06023625 RID: 144933 RVA: 0x004E552C File Offset: 0x004E372C
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

		// Token: 0x06023626 RID: 144934 RVA: 0x004E5558 File Offset: 0x004E3758
		public int EmotionBubbleIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009E75 RID: 40565
		// (get) Token: 0x06023627 RID: 144935 RVA: 0x004E5598 File Offset: 0x004E3798
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

		// Token: 0x06023628 RID: 144936 RVA: 0x004E55C3 File Offset: 0x004E37C3
		public Span<int> GetEmotionBubbleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06023629 RID: 144937 RVA: 0x004E55D2 File Offset: 0x004E37D2
		public int[] GetEmotionBubbleIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0602362A RID: 144938 RVA: 0x004E55E0 File Offset: 0x004E37E0
		public IConditionGroup? Conditions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009E76 RID: 40566
		// (get) Token: 0x0602362B RID: 144939 RVA: 0x004E5644 File Offset: 0x004E3844
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

		// Token: 0x17009E77 RID: 40567
		// (get) Token: 0x0602362C RID: 144940 RVA: 0x004E5670 File Offset: 0x004E3870
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

		// Token: 0x17009E78 RID: 40568
		// (get) Token: 0x0602362D RID: 144941 RVA: 0x004E56B0 File Offset: 0x004E38B0
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

		// Token: 0x0602362E RID: 144942 RVA: 0x004E56ED File Offset: 0x004E38ED
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

		// Token: 0x0602362F RID: 144943 RVA: 0x004E5729 File Offset: 0x004E3929
		public static void StartIInitStateStandby(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06023630 RID: 144944 RVA: 0x004E5732 File Offset: 0x004E3932
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023631 RID: 144945 RVA: 0x004E573D File Offset: 0x004E393D
		public static void AddStandbyTags(FlatBufferBuilder builder, VectorOffset standbyTagsOffset)
		{
			builder.AddOffset(1, standbyTagsOffset.Value, 0);
		}

		// Token: 0x06023632 RID: 144946 RVA: 0x004E5750 File Offset: 0x004E3950
		public static VectorOffset CreateStandbyTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023633 RID: 144947 RVA: 0x004E5790 File Offset: 0x004E3990
		public static VectorOffset CreateStandbyTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06023634 RID: 144948 RVA: 0x004E57AA File Offset: 0x004E39AA
		public static VectorOffset CreateStandbyTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06023635 RID: 144949 RVA: 0x004E57C8 File Offset: 0x004E39C8
		public static VectorOffset CreateStandbyTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023636 RID: 144950 RVA: 0x004E57E1 File Offset: 0x004E39E1
		public static void StartStandbyTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023637 RID: 144951 RVA: 0x004E57EC File Offset: 0x004E39EC
		public static void AddEmotionBubbleIds(FlatBufferBuilder builder, VectorOffset emotionBubbleIdsOffset)
		{
			builder.AddOffset(2, emotionBubbleIdsOffset.Value, 0);
		}

		// Token: 0x06023638 RID: 144952 RVA: 0x004E57FC File Offset: 0x004E39FC
		public static VectorOffset CreateEmotionBubbleIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023639 RID: 144953 RVA: 0x004E5833 File Offset: 0x004E3A33
		public static VectorOffset CreateEmotionBubbleIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602363A RID: 144954 RVA: 0x004E584D File Offset: 0x004E3A4D
		public static VectorOffset CreateEmotionBubbleIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602363B RID: 144955 RVA: 0x004E586B File Offset: 0x004E3A6B
		public static VectorOffset CreateEmotionBubbleIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602363C RID: 144956 RVA: 0x004E5884 File Offset: 0x004E3A84
		public static void StartEmotionBubbleIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602363D RID: 144957 RVA: 0x004E588F File Offset: 0x004E3A8F
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(3, conditionsOffset.Value, 0);
		}

		// Token: 0x0602363E RID: 144958 RVA: 0x004E58A0 File Offset: 0x004E3AA0
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<IConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602363F RID: 144959 RVA: 0x004E58E0 File Offset: 0x004E3AE0
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023640 RID: 144960 RVA: 0x004E58FA File Offset: 0x004E3AFA
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023641 RID: 144961 RVA: 0x004E5918 File Offset: 0x004E3B18
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023642 RID: 144962 RVA: 0x004E5931 File Offset: 0x004E3B31
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023643 RID: 144963 RVA: 0x004E593C File Offset: 0x004E3B3C
		public static void AddWander(FlatBufferBuilder builder, EAiWanderType wander)
		{
			builder.AddUshort(4, (ushort)wander, 0);
		}

		// Token: 0x06023644 RID: 144964 RVA: 0x004E5947 File Offset: 0x004E3B47
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06023645 RID: 144965 RVA: 0x004E5952 File Offset: 0x004E3B52
		public static Offset<IInitStateStandby> EndIInitStateStandby(FlatBufferBuilder builder)
		{
			return new Offset<IInitStateStandby>(builder.EndTable());
		}

		// Token: 0x06023646 RID: 144966 RVA: 0x004E5960 File Offset: 0x004E3B60
		public IInitStateStandbyT UnPack()
		{
			IInitStateStandbyT initStateStandbyT = new IInitStateStandbyT();
			this.UnPackTo(initStateStandbyT);
			return initStateStandbyT;
		}

		// Token: 0x06023647 RID: 144967 RVA: 0x004E597C File Offset: 0x004E3B7C
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

		// Token: 0x06023648 RID: 144968 RVA: 0x004E5A5C File Offset: 0x004E3C5C
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

		// Token: 0x0400E670 RID: 58992
		private Table __p;
	}
}

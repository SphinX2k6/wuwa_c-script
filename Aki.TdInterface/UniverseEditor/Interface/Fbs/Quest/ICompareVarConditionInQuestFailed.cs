using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DA3 RID: 15779
	public struct ICompareVarConditionInQuestFailed : IFlatbufferObject
	{
		// Token: 0x17006C8F RID: 27791
		// (get) Token: 0x06015EE8 RID: 89832 RVA: 0x0032ABE6 File Offset: 0x00328DE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015EE9 RID: 89833 RVA: 0x0032ABF3 File Offset: 0x00328DF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015EEA RID: 89834 RVA: 0x0032ABFC File Offset: 0x00328DFC
		public static ICompareVarConditionInQuestFailed GetRootAsICompareVarConditionInQuestFailed(ByteBuffer _bb)
		{
			return ICompareVarConditionInQuestFailed.GetRootAsICompareVarConditionInQuestFailed(_bb, default(ICompareVarConditionInQuestFailed));
		}

		// Token: 0x06015EEB RID: 89835 RVA: 0x0032AC18 File Offset: 0x00328E18
		public static ICompareVarConditionInQuestFailed GetRootAsICompareVarConditionInQuestFailed(ByteBuffer _bb, ICompareVarConditionInQuestFailed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015EEC RID: 89836 RVA: 0x0032AC35 File Offset: 0x00328E35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015EED RID: 89837 RVA: 0x0032AC44 File Offset: 0x00328E44
		public ICompareVarConditionInQuestFailed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C90 RID: 27792
		// (get) Token: 0x06015EEE RID: 89838 RVA: 0x0032AC54 File Offset: 0x00328E54
		public EConditionCount Count
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConditionCount.All;
				}
				return (EConditionCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015EEF RID: 89839 RVA: 0x0032AC90 File Offset: 0x00328E90
		public ICompareVarInChildQuest? Conditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICompareVarInChildQuest?(default(ICompareVarInChildQuest).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006C91 RID: 27793
		// (get) Token: 0x06015EF0 RID: 89840 RVA: 0x0032ACF0 File Offset: 0x00328EF0
		public int ConditionsLength
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

		// Token: 0x06015EF1 RID: 89841 RVA: 0x0032AD1B File Offset: 0x00328F1B
		public static Offset<ICompareVarConditionInQuestFailed> CreateICompareVarConditionInQuestFailed(FlatBufferBuilder builder, EConditionCount Count = EConditionCount.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICompareVarConditionInQuestFailed.AddConditions(builder, ConditionsOffset);
			ICompareVarConditionInQuestFailed.AddCount(builder, Count);
			return ICompareVarConditionInQuestFailed.EndICompareVarConditionInQuestFailed(builder);
		}

		// Token: 0x06015EF2 RID: 89842 RVA: 0x0032AD38 File Offset: 0x00328F38
		public static void StartICompareVarConditionInQuestFailed(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015EF3 RID: 89843 RVA: 0x0032AD41 File Offset: 0x00328F41
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(0, (byte)count, 0);
		}

		// Token: 0x06015EF4 RID: 89844 RVA: 0x0032AD4C File Offset: 0x00328F4C
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x06015EF5 RID: 89845 RVA: 0x0032AD5C File Offset: 0x00328F5C
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICompareVarInChildQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015EF6 RID: 89846 RVA: 0x0032AD9C File Offset: 0x00328F9C
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICompareVarInChildQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICompareVarInChildQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015EF7 RID: 89847 RVA: 0x0032ADB6 File Offset: 0x00328FB6
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICompareVarInChildQuest>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICompareVarInChildQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015EF8 RID: 89848 RVA: 0x0032ADD4 File Offset: 0x00328FD4
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICompareVarInChildQuest>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015EF9 RID: 89849 RVA: 0x0032ADED File Offset: 0x00328FED
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015EFA RID: 89850 RVA: 0x0032ADF8 File Offset: 0x00328FF8
		public static Offset<ICompareVarConditionInQuestFailed> EndICompareVarConditionInQuestFailed(FlatBufferBuilder builder)
		{
			return new Offset<ICompareVarConditionInQuestFailed>(builder.EndTable());
		}

		// Token: 0x06015EFB RID: 89851 RVA: 0x0032AE08 File Offset: 0x00329008
		public ICompareVarConditionInQuestFailedT UnPack()
		{
			ICompareVarConditionInQuestFailedT compareVarConditionInQuestFailedT = new ICompareVarConditionInQuestFailedT();
			this.UnPackTo(compareVarConditionInQuestFailedT);
			return compareVarConditionInQuestFailedT;
		}

		// Token: 0x06015EFC RID: 89852 RVA: 0x0032AE24 File Offset: 0x00329024
		public void UnPackTo(ICompareVarConditionInQuestFailedT _o)
		{
			_o.Count = this.Count;
			_o.Conditions = new List<ICompareVarInChildQuestT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06015EFD RID: 89853 RVA: 0x0032AE90 File Offset: 0x00329090
		public static Offset<ICompareVarConditionInQuestFailed> Pack(FlatBufferBuilder builder, ICompareVarConditionInQuestFailedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareVarConditionInQuestFailed>);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<ICompareVarInChildQuest>[] array = new Offset<ICompareVarInChildQuest>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICompareVarInChildQuest.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = ICompareVarConditionInQuestFailed.CreateConditionsVector(builder, array);
			}
			return ICompareVarConditionInQuestFailed.CreateICompareVarConditionInQuestFailed(builder, _o.Count, conditionsOffset);
		}

		// Token: 0x0400B6B4 RID: 46772
		private Table __p;
	}
}

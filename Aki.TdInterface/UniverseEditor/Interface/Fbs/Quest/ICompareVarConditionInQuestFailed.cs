using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041BA RID: 16826
	public struct ICompareVarConditionInQuestFailed : IFlatbufferObject
	{
		// Token: 0x17007249 RID: 29257
		// (get) Token: 0x06017420 RID: 95264 RVA: 0x00351F12 File Offset: 0x00350112
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017421 RID: 95265 RVA: 0x00351F1F File Offset: 0x0035011F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017422 RID: 95266 RVA: 0x00351F28 File Offset: 0x00350128
		public static ICompareVarConditionInQuestFailed GetRootAsICompareVarConditionInQuestFailed(ByteBuffer _bb)
		{
			return ICompareVarConditionInQuestFailed.GetRootAsICompareVarConditionInQuestFailed(_bb, default(ICompareVarConditionInQuestFailed));
		}

		// Token: 0x06017423 RID: 95267 RVA: 0x00351F44 File Offset: 0x00350144
		public static ICompareVarConditionInQuestFailed GetRootAsICompareVarConditionInQuestFailed(ByteBuffer _bb, ICompareVarConditionInQuestFailed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017424 RID: 95268 RVA: 0x00351F61 File Offset: 0x00350161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017425 RID: 95269 RVA: 0x00351F70 File Offset: 0x00350170
		public ICompareVarConditionInQuestFailed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700724A RID: 29258
		// (get) Token: 0x06017426 RID: 95270 RVA: 0x00351F80 File Offset: 0x00350180
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

		// Token: 0x06017427 RID: 95271 RVA: 0x00351FBC File Offset: 0x003501BC
		public ICompareVarInChildQuest? Conditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICompareVarInChildQuest?(default(ICompareVarInChildQuest).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700724B RID: 29259
		// (get) Token: 0x06017428 RID: 95272 RVA: 0x0035201C File Offset: 0x0035021C
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

		// Token: 0x06017429 RID: 95273 RVA: 0x00352047 File Offset: 0x00350247
		public static Offset<ICompareVarConditionInQuestFailed> CreateICompareVarConditionInQuestFailed(FlatBufferBuilder builder, EConditionCount Count = EConditionCount.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICompareVarConditionInQuestFailed.AddConditions(builder, ConditionsOffset);
			ICompareVarConditionInQuestFailed.AddCount(builder, Count);
			return ICompareVarConditionInQuestFailed.EndICompareVarConditionInQuestFailed(builder);
		}

		// Token: 0x0601742A RID: 95274 RVA: 0x00352064 File Offset: 0x00350264
		public static void StartICompareVarConditionInQuestFailed(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601742B RID: 95275 RVA: 0x0035206D File Offset: 0x0035026D
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(0, (byte)count, 0);
		}

		// Token: 0x0601742C RID: 95276 RVA: 0x00352078 File Offset: 0x00350278
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x0601742D RID: 95277 RVA: 0x00352088 File Offset: 0x00350288
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICompareVarInChildQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601742E RID: 95278 RVA: 0x003520C8 File Offset: 0x003502C8
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICompareVarInChildQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICompareVarInChildQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601742F RID: 95279 RVA: 0x003520E2 File Offset: 0x003502E2
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICompareVarInChildQuest>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICompareVarInChildQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017430 RID: 95280 RVA: 0x00352100 File Offset: 0x00350300
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICompareVarInChildQuest>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017431 RID: 95281 RVA: 0x00352119 File Offset: 0x00350319
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017432 RID: 95282 RVA: 0x00352124 File Offset: 0x00350324
		public static Offset<ICompareVarConditionInQuestFailed> EndICompareVarConditionInQuestFailed(FlatBufferBuilder builder)
		{
			return new Offset<ICompareVarConditionInQuestFailed>(builder.EndTable());
		}

		// Token: 0x06017433 RID: 95283 RVA: 0x00352134 File Offset: 0x00350334
		public ICompareVarConditionInQuestFailedT UnPack()
		{
			ICompareVarConditionInQuestFailedT compareVarConditionInQuestFailedT = new ICompareVarConditionInQuestFailedT();
			this.UnPackTo(compareVarConditionInQuestFailedT);
			return compareVarConditionInQuestFailedT;
		}

		// Token: 0x06017434 RID: 95284 RVA: 0x00352150 File Offset: 0x00350350
		public void UnPackTo(ICompareVarConditionInQuestFailedT _o)
		{
			_o.Count = this.Count;
			_o.Conditions = new List<ICompareVarInChildQuestT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06017435 RID: 95285 RVA: 0x003521BC File Offset: 0x003503BC
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

		// Token: 0x0400C061 RID: 49249
		private Table __p;
	}
}

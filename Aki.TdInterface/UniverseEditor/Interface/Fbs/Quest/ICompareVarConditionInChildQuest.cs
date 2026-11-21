using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B7 RID: 16823
	public struct ICompareVarConditionInChildQuest : IFlatbufferObject
	{
		// Token: 0x17007240 RID: 29248
		// (get) Token: 0x060173FC RID: 95228 RVA: 0x003519C7 File Offset: 0x0034FBC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060173FD RID: 95229 RVA: 0x003519D4 File Offset: 0x0034FBD4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060173FE RID: 95230 RVA: 0x003519DC File Offset: 0x0034FBDC
		public static ICompareVarConditionInChildQuest GetRootAsICompareVarConditionInChildQuest(ByteBuffer _bb)
		{
			return ICompareVarConditionInChildQuest.GetRootAsICompareVarConditionInChildQuest(_bb, default(ICompareVarConditionInChildQuest));
		}

		// Token: 0x060173FF RID: 95231 RVA: 0x003519F8 File Offset: 0x0034FBF8
		public static ICompareVarConditionInChildQuest GetRootAsICompareVarConditionInChildQuest(ByteBuffer _bb, ICompareVarConditionInChildQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017400 RID: 95232 RVA: 0x00351A15 File Offset: 0x0034FC15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017401 RID: 95233 RVA: 0x00351A24 File Offset: 0x0034FC24
		public ICompareVarConditionInChildQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007241 RID: 29249
		// (get) Token: 0x06017402 RID: 95234 RVA: 0x00351A34 File Offset: 0x0034FC34
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

		// Token: 0x17007242 RID: 29250
		// (get) Token: 0x06017403 RID: 95235 RVA: 0x00351A70 File Offset: 0x0034FC70
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

		// Token: 0x17007243 RID: 29251
		// (get) Token: 0x06017404 RID: 95236 RVA: 0x00351AD0 File Offset: 0x0034FCD0
		public EConditionCount Count
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EConditionCount.All;
				}
				return (EConditionCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017405 RID: 95237 RVA: 0x00351B0C File Offset: 0x0034FD0C
		public ICompareVarInChildQuest? Conditions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ICompareVarInChildQuest?(default(ICompareVarInChildQuest).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007244 RID: 29252
		// (get) Token: 0x06017406 RID: 95238 RVA: 0x00351B70 File Offset: 0x0034FD70
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

		// Token: 0x06017407 RID: 95239 RVA: 0x00351B9C File Offset: 0x0034FD9C
		public static Offset<ICompareVarConditionInChildQuest> CreateICompareVarConditionInChildQuest(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), EConditionCount Count = EConditionCount.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ICompareVarConditionInChildQuest.AddConditions(builder, ConditionsOffset);
			ICompareVarConditionInChildQuest.AddPreConditions(builder, PreConditionsOffset);
			ICompareVarConditionInChildQuest.AddCount(builder, Count);
			ICompareVarConditionInChildQuest.AddType(builder, Type);
			return ICompareVarConditionInChildQuest.EndICompareVarConditionInChildQuest(builder);
		}

		// Token: 0x06017408 RID: 95240 RVA: 0x00351BC8 File Offset: 0x0034FDC8
		public static void StartICompareVarConditionInChildQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017409 RID: 95241 RVA: 0x00351BD1 File Offset: 0x0034FDD1
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601740A RID: 95242 RVA: 0x00351BDC File Offset: 0x0034FDDC
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601740B RID: 95243 RVA: 0x00351BEC File Offset: 0x0034FDEC
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(2, (byte)count, 0);
		}

		// Token: 0x0601740C RID: 95244 RVA: 0x00351BF7 File Offset: 0x0034FDF7
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(3, conditionsOffset.Value, 0);
		}

		// Token: 0x0601740D RID: 95245 RVA: 0x00351C08 File Offset: 0x0034FE08
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICompareVarInChildQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601740E RID: 95246 RVA: 0x00351C48 File Offset: 0x0034FE48
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICompareVarInChildQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICompareVarInChildQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601740F RID: 95247 RVA: 0x00351C62 File Offset: 0x0034FE62
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICompareVarInChildQuest>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICompareVarInChildQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017410 RID: 95248 RVA: 0x00351C80 File Offset: 0x0034FE80
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICompareVarInChildQuest>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017411 RID: 95249 RVA: 0x00351C99 File Offset: 0x0034FE99
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017412 RID: 95250 RVA: 0x00351CA4 File Offset: 0x0034FEA4
		public static Offset<ICompareVarConditionInChildQuest> EndICompareVarConditionInChildQuest(FlatBufferBuilder builder)
		{
			return new Offset<ICompareVarConditionInChildQuest>(builder.EndTable());
		}

		// Token: 0x06017413 RID: 95251 RVA: 0x00351CB4 File Offset: 0x0034FEB4
		public ICompareVarConditionInChildQuestT UnPack()
		{
			ICompareVarConditionInChildQuestT compareVarConditionInChildQuestT = new ICompareVarConditionInChildQuestT();
			this.UnPackTo(compareVarConditionInChildQuestT);
			return compareVarConditionInChildQuestT;
		}

		// Token: 0x06017414 RID: 95252 RVA: 0x00351CD0 File Offset: 0x0034FED0
		public void UnPackTo(ICompareVarConditionInChildQuestT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Count = this.Count;
			_o.Conditions = new List<ICompareVarInChildQuestT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06017415 RID: 95253 RVA: 0x00351D78 File Offset: 0x0034FF78
		public static Offset<ICompareVarConditionInChildQuest> Pack(FlatBufferBuilder builder, ICompareVarConditionInChildQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareVarConditionInChildQuest>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<ICompareVarInChildQuest>[] array = new Offset<ICompareVarInChildQuest>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICompareVarInChildQuest.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = ICompareVarConditionInChildQuest.CreateConditionsVector(builder, array);
			}
			return ICompareVarConditionInChildQuest.CreateICompareVarConditionInChildQuest(builder, _o.Type, preConditionsOffset, _o.Count, conditionsOffset);
		}

		// Token: 0x0400C05C RID: 49244
		private Table __p;
	}
}

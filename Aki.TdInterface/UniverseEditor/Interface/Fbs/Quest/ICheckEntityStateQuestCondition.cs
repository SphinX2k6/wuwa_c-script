using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004163 RID: 16739
	public struct ICheckEntityStateQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007167 RID: 29031
		// (get) Token: 0x06017053 RID: 94291 RVA: 0x003486EA File Offset: 0x003468EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017054 RID: 94292 RVA: 0x003486F7 File Offset: 0x003468F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017055 RID: 94293 RVA: 0x00348700 File Offset: 0x00346900
		public static ICheckEntityStateQuestCondition GetRootAsICheckEntityStateQuestCondition(ByteBuffer _bb)
		{
			return ICheckEntityStateQuestCondition.GetRootAsICheckEntityStateQuestCondition(_bb, default(ICheckEntityStateQuestCondition));
		}

		// Token: 0x06017056 RID: 94294 RVA: 0x0034871C File Offset: 0x0034691C
		public static ICheckEntityStateQuestCondition GetRootAsICheckEntityStateQuestCondition(ByteBuffer _bb, ICheckEntityStateQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017057 RID: 94295 RVA: 0x00348739 File Offset: 0x00346939
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017058 RID: 94296 RVA: 0x00348748 File Offset: 0x00346948
		public ICheckEntityStateQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007168 RID: 29032
		// (get) Token: 0x06017059 RID: 94297 RVA: 0x00348758 File Offset: 0x00346958
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

		// Token: 0x17007169 RID: 29033
		// (get) Token: 0x0601705A RID: 94298 RVA: 0x00348794 File Offset: 0x00346994
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

		// Token: 0x0601705B RID: 94299 RVA: 0x003487F4 File Offset: 0x003469F4
		public IEntityStateCondition? Conditions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateCondition?(default(IEntityStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700716A RID: 29034
		// (get) Token: 0x0601705C RID: 94300 RVA: 0x00348854 File Offset: 0x00346A54
		public int ConditionsLength
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

		// Token: 0x0601705D RID: 94301 RVA: 0x0034887F File Offset: 0x00346A7F
		public static Offset<ICheckEntityStateQuestCondition> CreateICheckEntityStateQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckEntityStateQuestCondition.AddConditions(builder, ConditionsOffset);
			ICheckEntityStateQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckEntityStateQuestCondition.AddType(builder, Type);
			return ICheckEntityStateQuestCondition.EndICheckEntityStateQuestCondition(builder);
		}

		// Token: 0x0601705E RID: 94302 RVA: 0x003488A3 File Offset: 0x00346AA3
		public static void StartICheckEntityStateQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601705F RID: 94303 RVA: 0x003488AC File Offset: 0x00346AAC
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017060 RID: 94304 RVA: 0x003488B7 File Offset: 0x00346AB7
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017061 RID: 94305 RVA: 0x003488C7 File Offset: 0x00346AC7
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x06017062 RID: 94306 RVA: 0x003488D8 File Offset: 0x00346AD8
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017063 RID: 94307 RVA: 0x00348918 File Offset: 0x00346B18
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017064 RID: 94308 RVA: 0x00348932 File Offset: 0x00346B32
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017065 RID: 94309 RVA: 0x00348950 File Offset: 0x00346B50
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017066 RID: 94310 RVA: 0x00348969 File Offset: 0x00346B69
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017067 RID: 94311 RVA: 0x00348974 File Offset: 0x00346B74
		public static Offset<ICheckEntityStateQuestCondition> EndICheckEntityStateQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityStateQuestCondition>(builder.EndTable());
		}

		// Token: 0x06017068 RID: 94312 RVA: 0x00348984 File Offset: 0x00346B84
		public ICheckEntityStateQuestConditionT UnPack()
		{
			ICheckEntityStateQuestConditionT checkEntityStateQuestConditionT = new ICheckEntityStateQuestConditionT();
			this.UnPackTo(checkEntityStateQuestConditionT);
			return checkEntityStateQuestConditionT;
		}

		// Token: 0x06017069 RID: 94313 RVA: 0x003489A0 File Offset: 0x00346BA0
		public void UnPackTo(ICheckEntityStateQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Conditions = new List<IEntityStateConditionT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601706A RID: 94314 RVA: 0x00348A3C File Offset: 0x00346C3C
		public static Offset<ICheckEntityStateQuestCondition> Pack(FlatBufferBuilder builder, ICheckEntityStateQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityStateQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<IEntityStateCondition>[] array = new Offset<IEntityStateCondition>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityStateCondition.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = ICheckEntityStateQuestCondition.CreateConditionsVector(builder, array);
			}
			return ICheckEntityStateQuestCondition.CreateICheckEntityStateQuestCondition(builder, _o.Type, preConditionsOffset, conditionsOffset);
		}

		// Token: 0x0400BFD3 RID: 49107
		private Table __p;
	}
}

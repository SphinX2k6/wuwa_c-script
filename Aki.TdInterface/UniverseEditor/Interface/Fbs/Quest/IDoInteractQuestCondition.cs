using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DDF RID: 15839
	public struct IDoInteractQuestCondition : IFlatbufferObject
	{
		// Token: 0x17006D61 RID: 28001
		// (get) Token: 0x060161F7 RID: 90615 RVA: 0x0033278B File Offset: 0x0033098B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060161F8 RID: 90616 RVA: 0x00332798 File Offset: 0x00330998
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060161F9 RID: 90617 RVA: 0x003327A0 File Offset: 0x003309A0
		public static IDoInteractQuestCondition GetRootAsIDoInteractQuestCondition(ByteBuffer _bb)
		{
			return IDoInteractQuestCondition.GetRootAsIDoInteractQuestCondition(_bb, default(IDoInteractQuestCondition));
		}

		// Token: 0x060161FA RID: 90618 RVA: 0x003327BC File Offset: 0x003309BC
		public static IDoInteractQuestCondition GetRootAsIDoInteractQuestCondition(ByteBuffer _bb, IDoInteractQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060161FB RID: 90619 RVA: 0x003327D9 File Offset: 0x003309D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060161FC RID: 90620 RVA: 0x003327E8 File Offset: 0x003309E8
		public IDoInteractQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D62 RID: 28002
		// (get) Token: 0x060161FD RID: 90621 RVA: 0x003327F8 File Offset: 0x003309F8
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

		// Token: 0x17006D63 RID: 28003
		// (get) Token: 0x060161FE RID: 90622 RVA: 0x00332834 File Offset: 0x00330A34
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

		// Token: 0x060161FF RID: 90623 RVA: 0x00332894 File Offset: 0x00330A94
		public IAddInteractOption? AddOptions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IAddInteractOption?(default(IAddInteractOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006D64 RID: 28004
		// (get) Token: 0x06016200 RID: 90624 RVA: 0x003328F4 File Offset: 0x00330AF4
		public int AddOptionsLength
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

		// Token: 0x06016201 RID: 90625 RVA: 0x0033291F File Offset: 0x00330B1F
		public static Offset<IDoInteractQuestCondition> CreateIDoInteractQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset AddOptionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IDoInteractQuestCondition.AddAddOptions(builder, AddOptionsOffset);
			IDoInteractQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IDoInteractQuestCondition.AddType(builder, Type);
			return IDoInteractQuestCondition.EndIDoInteractQuestCondition(builder);
		}

		// Token: 0x06016202 RID: 90626 RVA: 0x00332943 File Offset: 0x00330B43
		public static void StartIDoInteractQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016203 RID: 90627 RVA: 0x0033294C File Offset: 0x00330B4C
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016204 RID: 90628 RVA: 0x00332957 File Offset: 0x00330B57
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016205 RID: 90629 RVA: 0x00332967 File Offset: 0x00330B67
		public static void AddAddOptions(FlatBufferBuilder builder, VectorOffset addOptionsOffset)
		{
			builder.AddOffset(2, addOptionsOffset.Value, 0);
		}

		// Token: 0x06016206 RID: 90630 RVA: 0x00332978 File Offset: 0x00330B78
		public static VectorOffset CreateAddOptionsVector(FlatBufferBuilder builder, Offset<IAddInteractOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016207 RID: 90631 RVA: 0x003329B8 File Offset: 0x00330BB8
		public static VectorOffset CreateAddOptionsVectorBlock(FlatBufferBuilder builder, Offset<IAddInteractOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAddInteractOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016208 RID: 90632 RVA: 0x003329D2 File Offset: 0x00330BD2
		public static VectorOffset CreateAddOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAddInteractOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAddInteractOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016209 RID: 90633 RVA: 0x003329F0 File Offset: 0x00330BF0
		public static VectorOffset CreateAddOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAddInteractOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601620A RID: 90634 RVA: 0x00332A09 File Offset: 0x00330C09
		public static void StartAddOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601620B RID: 90635 RVA: 0x00332A14 File Offset: 0x00330C14
		public static Offset<IDoInteractQuestCondition> EndIDoInteractQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDoInteractQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601620C RID: 90636 RVA: 0x00332A24 File Offset: 0x00330C24
		public IDoInteractQuestConditionT UnPack()
		{
			IDoInteractQuestConditionT doInteractQuestConditionT = new IDoInteractQuestConditionT();
			this.UnPackTo(doInteractQuestConditionT);
			return doInteractQuestConditionT;
		}

		// Token: 0x0601620D RID: 90637 RVA: 0x00332A40 File Offset: 0x00330C40
		public void UnPackTo(IDoInteractQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.AddOptions = new List<IAddInteractOptionT>();
			for (int i = 0; i < this.AddOptionsLength; i++)
			{
				_o.AddOptions.Add((this.AddOptions(i) != null) ? this.AddOptions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601620E RID: 90638 RVA: 0x00332ADC File Offset: 0x00330CDC
		public static Offset<IDoInteractQuestCondition> Pack(FlatBufferBuilder builder, IDoInteractQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDoInteractQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset addOptionsOffset = default(VectorOffset);
			if (_o.AddOptions != null)
			{
				Offset<IAddInteractOption>[] array = new Offset<IAddInteractOption>[_o.AddOptions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IAddInteractOption.Pack(builder, _o.AddOptions[i]);
				}
				addOptionsOffset = IDoInteractQuestCondition.CreateAddOptionsVector(builder, array);
			}
			return IDoInteractQuestCondition.CreateIDoInteractQuestCondition(builder, _o.Type, preConditionsOffset, addOptionsOffset);
		}

		// Token: 0x0400B727 RID: 46887
		private Table __p;
	}
}

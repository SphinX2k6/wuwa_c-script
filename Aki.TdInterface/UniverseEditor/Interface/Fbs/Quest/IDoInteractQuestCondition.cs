using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200421A RID: 16922
	public struct IDoInteractQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007341 RID: 29505
		// (get) Token: 0x06017816 RID: 96278 RVA: 0x0035B18F File Offset: 0x0035938F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017817 RID: 96279 RVA: 0x0035B19C File Offset: 0x0035939C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017818 RID: 96280 RVA: 0x0035B1A4 File Offset: 0x003593A4
		public static IDoInteractQuestCondition GetRootAsIDoInteractQuestCondition(ByteBuffer _bb)
		{
			return IDoInteractQuestCondition.GetRootAsIDoInteractQuestCondition(_bb, default(IDoInteractQuestCondition));
		}

		// Token: 0x06017819 RID: 96281 RVA: 0x0035B1C0 File Offset: 0x003593C0
		public static IDoInteractQuestCondition GetRootAsIDoInteractQuestCondition(ByteBuffer _bb, IDoInteractQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601781A RID: 96282 RVA: 0x0035B1DD File Offset: 0x003593DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601781B RID: 96283 RVA: 0x0035B1EC File Offset: 0x003593EC
		public IDoInteractQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007342 RID: 29506
		// (get) Token: 0x0601781C RID: 96284 RVA: 0x0035B1FC File Offset: 0x003593FC
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

		// Token: 0x17007343 RID: 29507
		// (get) Token: 0x0601781D RID: 96285 RVA: 0x0035B238 File Offset: 0x00359438
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

		// Token: 0x0601781E RID: 96286 RVA: 0x0035B298 File Offset: 0x00359498
		public IAddInteractOption? AddOptions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IAddInteractOption?(default(IAddInteractOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007344 RID: 29508
		// (get) Token: 0x0601781F RID: 96287 RVA: 0x0035B2F8 File Offset: 0x003594F8
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

		// Token: 0x06017820 RID: 96288 RVA: 0x0035B323 File Offset: 0x00359523
		public static Offset<IDoInteractQuestCondition> CreateIDoInteractQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset AddOptionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IDoInteractQuestCondition.AddAddOptions(builder, AddOptionsOffset);
			IDoInteractQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IDoInteractQuestCondition.AddType(builder, Type);
			return IDoInteractQuestCondition.EndIDoInteractQuestCondition(builder);
		}

		// Token: 0x06017821 RID: 96289 RVA: 0x0035B347 File Offset: 0x00359547
		public static void StartIDoInteractQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017822 RID: 96290 RVA: 0x0035B350 File Offset: 0x00359550
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017823 RID: 96291 RVA: 0x0035B35B File Offset: 0x0035955B
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017824 RID: 96292 RVA: 0x0035B36B File Offset: 0x0035956B
		public static void AddAddOptions(FlatBufferBuilder builder, VectorOffset addOptionsOffset)
		{
			builder.AddOffset(2, addOptionsOffset.Value, 0);
		}

		// Token: 0x06017825 RID: 96293 RVA: 0x0035B37C File Offset: 0x0035957C
		public static VectorOffset CreateAddOptionsVector(FlatBufferBuilder builder, Offset<IAddInteractOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017826 RID: 96294 RVA: 0x0035B3BC File Offset: 0x003595BC
		public static VectorOffset CreateAddOptionsVectorBlock(FlatBufferBuilder builder, Offset<IAddInteractOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAddInteractOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017827 RID: 96295 RVA: 0x0035B3D6 File Offset: 0x003595D6
		public static VectorOffset CreateAddOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAddInteractOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAddInteractOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017828 RID: 96296 RVA: 0x0035B3F4 File Offset: 0x003595F4
		public static VectorOffset CreateAddOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAddInteractOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017829 RID: 96297 RVA: 0x0035B40D File Offset: 0x0035960D
		public static void StartAddOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601782A RID: 96298 RVA: 0x0035B418 File Offset: 0x00359618
		public static Offset<IDoInteractQuestCondition> EndIDoInteractQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDoInteractQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601782B RID: 96299 RVA: 0x0035B428 File Offset: 0x00359628
		public IDoInteractQuestConditionT UnPack()
		{
			IDoInteractQuestConditionT doInteractQuestConditionT = new IDoInteractQuestConditionT();
			this.UnPackTo(doInteractQuestConditionT);
			return doInteractQuestConditionT;
		}

		// Token: 0x0601782C RID: 96300 RVA: 0x0035B444 File Offset: 0x00359644
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

		// Token: 0x0601782D RID: 96301 RVA: 0x0035B4E0 File Offset: 0x003596E0
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

		// Token: 0x0400C0FB RID: 49403
		private Table __p;
	}
}

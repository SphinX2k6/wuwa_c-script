using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059EC RID: 23020
	public struct ISuccessConditionSpecificTargetState : IFlatbufferObject
	{
		// Token: 0x1700ACEC RID: 44268
		// (get) Token: 0x060270DA RID: 159962 RVA: 0x0055F601 File Offset: 0x0055D801
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060270DB RID: 159963 RVA: 0x0055F60E File Offset: 0x0055D80E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060270DC RID: 159964 RVA: 0x0055F618 File Offset: 0x0055D818
		public static ISuccessConditionSpecificTargetState GetRootAsISuccessConditionSpecificTargetState(ByteBuffer _bb)
		{
			return ISuccessConditionSpecificTargetState.GetRootAsISuccessConditionSpecificTargetState(_bb, default(ISuccessConditionSpecificTargetState));
		}

		// Token: 0x060270DD RID: 159965 RVA: 0x0055F634 File Offset: 0x0055D834
		public static ISuccessConditionSpecificTargetState GetRootAsISuccessConditionSpecificTargetState(ByteBuffer _bb, ISuccessConditionSpecificTargetState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060270DE RID: 159966 RVA: 0x0055F651 File Offset: 0x0055D851
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060270DF RID: 159967 RVA: 0x0055F660 File Offset: 0x0055D860
		public ISuccessConditionSpecificTargetState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACED RID: 44269
		// (get) Token: 0x060270E0 RID: 159968 RVA: 0x0055F670 File Offset: 0x0055D870
		public ETargetGearGroupSuccessCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetGearGroupSuccessCondition.SameSpecificState;
				}
				return (ETargetGearGroupSuccessCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060270E1 RID: 159969 RVA: 0x0055F6AC File Offset: 0x0055D8AC
		public IEntityStateCondition? Conditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateCondition?(default(IEntityStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700ACEE RID: 44270
		// (get) Token: 0x060270E2 RID: 159970 RVA: 0x0055F70C File Offset: 0x0055D90C
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

		// Token: 0x060270E3 RID: 159971 RVA: 0x0055F737 File Offset: 0x0055D937
		public static Offset<ISuccessConditionSpecificTargetState> CreateISuccessConditionSpecificTargetState(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition Type = ETargetGearGroupSuccessCondition.SameSpecificState, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISuccessConditionSpecificTargetState.AddConditions(builder, ConditionsOffset);
			ISuccessConditionSpecificTargetState.AddType(builder, Type);
			return ISuccessConditionSpecificTargetState.EndISuccessConditionSpecificTargetState(builder);
		}

		// Token: 0x060270E4 RID: 159972 RVA: 0x0055F754 File Offset: 0x0055D954
		public static void StartISuccessConditionSpecificTargetState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060270E5 RID: 159973 RVA: 0x0055F75D File Offset: 0x0055D95D
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060270E6 RID: 159974 RVA: 0x0055F768 File Offset: 0x0055D968
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x060270E7 RID: 159975 RVA: 0x0055F778 File Offset: 0x0055D978
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060270E8 RID: 159976 RVA: 0x0055F7B8 File Offset: 0x0055D9B8
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x060270E9 RID: 159977 RVA: 0x0055F7D2 File Offset: 0x0055D9D2
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x060270EA RID: 159978 RVA: 0x0055F7F0 File Offset: 0x0055D9F0
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060270EB RID: 159979 RVA: 0x0055F809 File Offset: 0x0055DA09
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060270EC RID: 159980 RVA: 0x0055F814 File Offset: 0x0055DA14
		public static Offset<ISuccessConditionSpecificTargetState> EndISuccessConditionSpecificTargetState(FlatBufferBuilder builder)
		{
			return new Offset<ISuccessConditionSpecificTargetState>(builder.EndTable());
		}

		// Token: 0x060270ED RID: 159981 RVA: 0x0055F824 File Offset: 0x0055DA24
		public ISuccessConditionSpecificTargetStateT UnPack()
		{
			ISuccessConditionSpecificTargetStateT successConditionSpecificTargetStateT = new ISuccessConditionSpecificTargetStateT();
			this.UnPackTo(successConditionSpecificTargetStateT);
			return successConditionSpecificTargetStateT;
		}

		// Token: 0x060270EE RID: 159982 RVA: 0x0055F840 File Offset: 0x0055DA40
		public void UnPackTo(ISuccessConditionSpecificTargetStateT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = new List<IEntityStateConditionT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060270EF RID: 159983 RVA: 0x0055F8AC File Offset: 0x0055DAAC
		public static Offset<ISuccessConditionSpecificTargetState> Pack(FlatBufferBuilder builder, ISuccessConditionSpecificTargetStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISuccessConditionSpecificTargetState>);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<IEntityStateCondition>[] array = new Offset<IEntityStateCondition>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityStateCondition.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = ISuccessConditionSpecificTargetState.CreateConditionsVector(builder, array);
			}
			return ISuccessConditionSpecificTargetState.CreateISuccessConditionSpecificTargetState(builder, _o.Type, conditionsOffset);
		}

		// Token: 0x0400F023 RID: 61475
		private Table __p;
	}
}

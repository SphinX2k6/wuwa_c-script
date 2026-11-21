using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FF9 RID: 24569
	public struct ISuccessConditionSpecificTargetState : IFlatbufferObject
	{
		// Token: 0x1700B624 RID: 46628
		// (get) Token: 0x06029652 RID: 169554 RVA: 0x005A65C5 File Offset: 0x005A47C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029653 RID: 169555 RVA: 0x005A65D2 File Offset: 0x005A47D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029654 RID: 169556 RVA: 0x005A65DC File Offset: 0x005A47DC
		public static ISuccessConditionSpecificTargetState GetRootAsISuccessConditionSpecificTargetState(ByteBuffer _bb)
		{
			return ISuccessConditionSpecificTargetState.GetRootAsISuccessConditionSpecificTargetState(_bb, default(ISuccessConditionSpecificTargetState));
		}

		// Token: 0x06029655 RID: 169557 RVA: 0x005A65F8 File Offset: 0x005A47F8
		public static ISuccessConditionSpecificTargetState GetRootAsISuccessConditionSpecificTargetState(ByteBuffer _bb, ISuccessConditionSpecificTargetState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029656 RID: 169558 RVA: 0x005A6615 File Offset: 0x005A4815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029657 RID: 169559 RVA: 0x005A6624 File Offset: 0x005A4824
		public ISuccessConditionSpecificTargetState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B625 RID: 46629
		// (get) Token: 0x06029658 RID: 169560 RVA: 0x005A6634 File Offset: 0x005A4834
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

		// Token: 0x06029659 RID: 169561 RVA: 0x005A6670 File Offset: 0x005A4870
		public IEntityStateCondition? Conditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateCondition?(default(IEntityStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B626 RID: 46630
		// (get) Token: 0x0602965A RID: 169562 RVA: 0x005A66D0 File Offset: 0x005A48D0
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

		// Token: 0x0602965B RID: 169563 RVA: 0x005A66FB File Offset: 0x005A48FB
		public static Offset<ISuccessConditionSpecificTargetState> CreateISuccessConditionSpecificTargetState(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition Type = ETargetGearGroupSuccessCondition.SameSpecificState, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISuccessConditionSpecificTargetState.AddConditions(builder, ConditionsOffset);
			ISuccessConditionSpecificTargetState.AddType(builder, Type);
			return ISuccessConditionSpecificTargetState.EndISuccessConditionSpecificTargetState(builder);
		}

		// Token: 0x0602965C RID: 169564 RVA: 0x005A6718 File Offset: 0x005A4918
		public static void StartISuccessConditionSpecificTargetState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602965D RID: 169565 RVA: 0x005A6721 File Offset: 0x005A4921
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupSuccessCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602965E RID: 169566 RVA: 0x005A672C File Offset: 0x005A492C
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x0602965F RID: 169567 RVA: 0x005A673C File Offset: 0x005A493C
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029660 RID: 169568 RVA: 0x005A677C File Offset: 0x005A497C
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029661 RID: 169569 RVA: 0x005A6796 File Offset: 0x005A4996
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029662 RID: 169570 RVA: 0x005A67B4 File Offset: 0x005A49B4
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029663 RID: 169571 RVA: 0x005A67CD File Offset: 0x005A49CD
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029664 RID: 169572 RVA: 0x005A67D8 File Offset: 0x005A49D8
		public static Offset<ISuccessConditionSpecificTargetState> EndISuccessConditionSpecificTargetState(FlatBufferBuilder builder)
		{
			return new Offset<ISuccessConditionSpecificTargetState>(builder.EndTable());
		}

		// Token: 0x06029665 RID: 169573 RVA: 0x005A67E8 File Offset: 0x005A49E8
		public ISuccessConditionSpecificTargetStateT UnPack()
		{
			ISuccessConditionSpecificTargetStateT successConditionSpecificTargetStateT = new ISuccessConditionSpecificTargetStateT();
			this.UnPackTo(successConditionSpecificTargetStateT);
			return successConditionSpecificTargetStateT;
		}

		// Token: 0x06029666 RID: 169574 RVA: 0x005A6804 File Offset: 0x005A4A04
		public void UnPackTo(ISuccessConditionSpecificTargetStateT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = new List<IEntityStateConditionT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029667 RID: 169575 RVA: 0x005A6870 File Offset: 0x005A4A70
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

		// Token: 0x0400FD1A RID: 64794
		private Table __p;
	}
}

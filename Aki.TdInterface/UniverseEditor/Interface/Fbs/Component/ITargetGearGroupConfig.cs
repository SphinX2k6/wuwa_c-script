using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A2B RID: 23083
	public struct ITargetGearGroupConfig : IFlatbufferObject
	{
		// Token: 0x1700AD9B RID: 44443
		// (get) Token: 0x060273A0 RID: 160672 RVA: 0x00565A93 File Offset: 0x00563C93
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060273A1 RID: 160673 RVA: 0x00565AA0 File Offset: 0x00563CA0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060273A2 RID: 160674 RVA: 0x00565AA8 File Offset: 0x00563CA8
		public static ITargetGearGroupConfig GetRootAsITargetGearGroupConfig(ByteBuffer _bb)
		{
			return ITargetGearGroupConfig.GetRootAsITargetGearGroupConfig(_bb, default(ITargetGearGroupConfig));
		}

		// Token: 0x060273A3 RID: 160675 RVA: 0x00565AC4 File Offset: 0x00563CC4
		public static ITargetGearGroupConfig GetRootAsITargetGearGroupConfig(ByteBuffer _bb, ITargetGearGroupConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060273A4 RID: 160676 RVA: 0x00565AE1 File Offset: 0x00563CE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060273A5 RID: 160677 RVA: 0x00565AF0 File Offset: 0x00563CF0
		public ITargetGearGroupConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060273A6 RID: 160678 RVA: 0x00565B00 File Offset: 0x00563D00
		public int Entitys(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AD9C RID: 44444
		// (get) Token: 0x060273A7 RID: 160679 RVA: 0x00565B40 File Offset: 0x00563D40
		public int EntitysLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060273A8 RID: 160680 RVA: 0x00565B6B File Offset: 0x00563D6B
		public Span<int> GetEntitysBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x060273A9 RID: 160681 RVA: 0x00565B7A File Offset: 0x00563D7A
		public int[] GetEntitysArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700AD9D RID: 44445
		// (get) Token: 0x060273AA RID: 160682 RVA: 0x00565B88 File Offset: 0x00563D88
		public TTargetGearGroupSuccessCondition SuccessConditionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetGearGroupSuccessCondition.NONE;
				}
				return (TTargetGearGroupSuccessCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060273AB RID: 160683 RVA: 0x00565BC4 File Offset: 0x00563DC4
		public TTable? SuccessCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060273AC RID: 160684 RVA: 0x00565C08 File Offset: 0x00563E08
		public ISuccessConditionCountDownState SuccessConditionAsISuccessConditionCountDownState()
		{
			return this.SuccessCondition<ISuccessConditionCountDownState>().Value;
		}

		// Token: 0x060273AD RID: 160685 RVA: 0x00565C24 File Offset: 0x00563E24
		public ISuccessConditionSameArbitraryState SuccessConditionAsISuccessConditionSameArbitraryState()
		{
			return this.SuccessCondition<ISuccessConditionSameArbitraryState>().Value;
		}

		// Token: 0x060273AE RID: 160686 RVA: 0x00565C40 File Offset: 0x00563E40
		public ISuccessConditionSameSpecificState SuccessConditionAsISuccessConditionSameSpecificState()
		{
			return this.SuccessCondition<ISuccessConditionSameSpecificState>().Value;
		}

		// Token: 0x060273AF RID: 160687 RVA: 0x00565C5C File Offset: 0x00563E5C
		public ISuccessConditionSpecificTargetState SuccessConditionAsISuccessConditionSpecificTargetState()
		{
			return this.SuccessCondition<ISuccessConditionSpecificTargetState>().Value;
		}

		// Token: 0x060273B0 RID: 160688 RVA: 0x00565C78 File Offset: 0x00563E78
		public TTargetGearGroupFailureCondition FailureConditionsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TTargetGearGroupFailureCondition.NONE;
			}
			return (TTargetGearGroupFailureCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700AD9E RID: 44446
		// (get) Token: 0x060273B1 RID: 160689 RVA: 0x00565CB8 File Offset: 0x00563EB8
		public int FailureConditionsTypeLength
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

		// Token: 0x060273B2 RID: 160690 RVA: 0x00565CE4 File Offset: 0x00563EE4
		public Span<TTargetGearGroupFailureCondition> GetFailureConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TTargetGearGroupFailureCondition>(10, 1);
		}

		// Token: 0x060273B3 RID: 160691 RVA: 0x00565CF4 File Offset: 0x00563EF4
		public TTargetGearGroupFailureCondition[] GetFailureConditionsTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TTargetGearGroupFailureCondition[] array = new TTargetGearGroupFailureCondition[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TTargetGearGroupFailureCondition)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060273B4 RID: 160692 RVA: 0x00565D60 File Offset: 0x00563F60
		public TTable? FailureConditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700AD9F RID: 44447
		// (get) Token: 0x060273B5 RID: 160693 RVA: 0x00565DA8 File Offset: 0x00563FA8
		public int FailureConditionsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060273B6 RID: 160694 RVA: 0x00565DD4 File Offset: 0x00563FD4
		public ICheckGearHit? CheckGears(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new ICheckGearHit?(default(ICheckGearHit).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700ADA0 RID: 44448
		// (get) Token: 0x060273B7 RID: 160695 RVA: 0x00565E38 File Offset: 0x00564038
		public int CheckGearsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700ADA1 RID: 44449
		// (get) Token: 0x060273B8 RID: 160696 RVA: 0x00565E64 File Offset: 0x00564064
		public TGroupFinishConfig FinishConfigType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return TGroupFinishConfig.NONE;
				}
				return (TGroupFinishConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060273B9 RID: 160697 RVA: 0x00565EA4 File Offset: 0x005640A4
		public TTable? FinishConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060273BA RID: 160698 RVA: 0x00565EEC File Offset: 0x005640EC
		public IGroupFinishDestroy FinishConfigAsIGroupFinishDestroy()
		{
			return this.FinishConfig<IGroupFinishDestroy>().Value;
		}

		// Token: 0x060273BB RID: 160699 RVA: 0x00565F08 File Offset: 0x00564108
		public IGroupFinishSilence FinishConfigAsIGroupFinishSilence()
		{
			return this.FinishConfig<IGroupFinishSilence>().Value;
		}

		// Token: 0x1700ADA2 RID: 44450
		// (get) Token: 0x060273BC RID: 160700 RVA: 0x00565F24 File Offset: 0x00564124
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060273BD RID: 160701 RVA: 0x00565F64 File Offset: 0x00564164
		public static Offset<ITargetGearGroupConfig> CreateITargetGearGroupConfig(FlatBufferBuilder builder, VectorOffset EntitysOffset = default(VectorOffset), TTargetGearGroupSuccessCondition SuccessCondition_type = TTargetGearGroupSuccessCondition.NONE, int SuccessConditionOffset = 0, VectorOffset FailureConditions_typeOffset = default(VectorOffset), VectorOffset FailureConditionsOffset = default(VectorOffset), VectorOffset CheckGearsOffset = default(VectorOffset), TGroupFinishConfig FinishConfig_type = TGroupFinishConfig.NONE, int FinishConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			ITargetGearGroupConfig.AddFinishConfig(builder, FinishConfigOffset);
			ITargetGearGroupConfig.AddCheckGears(builder, CheckGearsOffset);
			ITargetGearGroupConfig.AddFailureConditions(builder, FailureConditionsOffset);
			ITargetGearGroupConfig.AddFailureConditionsType(builder, FailureConditions_typeOffset);
			ITargetGearGroupConfig.AddSuccessCondition(builder, SuccessConditionOffset);
			ITargetGearGroupConfig.AddEntitys(builder, EntitysOffset);
			ITargetGearGroupConfig.AddNullMask(builder, NullMask);
			ITargetGearGroupConfig.AddFinishConfigType(builder, FinishConfig_type);
			ITargetGearGroupConfig.AddSuccessConditionType(builder, SuccessCondition_type);
			return ITargetGearGroupConfig.EndITargetGearGroupConfig(builder);
		}

		// Token: 0x060273BE RID: 160702 RVA: 0x00565FC4 File Offset: 0x005641C4
		public static void StartITargetGearGroupConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x060273BF RID: 160703 RVA: 0x00565FCE File Offset: 0x005641CE
		public static void AddEntitys(FlatBufferBuilder builder, VectorOffset entitysOffset)
		{
			builder.AddOffset(0, entitysOffset.Value, 0);
		}

		// Token: 0x060273C0 RID: 160704 RVA: 0x00565FE0 File Offset: 0x005641E0
		public static VectorOffset CreateEntitysVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060273C1 RID: 160705 RVA: 0x00566017 File Offset: 0x00564217
		public static VectorOffset CreateEntitysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060273C2 RID: 160706 RVA: 0x00566031 File Offset: 0x00564231
		public static VectorOffset CreateEntitysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060273C3 RID: 160707 RVA: 0x0056604F File Offset: 0x0056424F
		public static VectorOffset CreateEntitysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060273C4 RID: 160708 RVA: 0x00566068 File Offset: 0x00564268
		public static void StartEntitysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060273C5 RID: 160709 RVA: 0x00566073 File Offset: 0x00564273
		public static void AddSuccessConditionType(FlatBufferBuilder builder, TTargetGearGroupSuccessCondition successConditionType)
		{
			builder.AddByte(1, (byte)successConditionType, 0);
		}

		// Token: 0x060273C6 RID: 160710 RVA: 0x0056607E File Offset: 0x0056427E
		public static void AddSuccessCondition(FlatBufferBuilder builder, int successConditionOffset)
		{
			builder.AddOffset(2, successConditionOffset, 0);
		}

		// Token: 0x060273C7 RID: 160711 RVA: 0x00566089 File Offset: 0x00564289
		public static void AddFailureConditionsType(FlatBufferBuilder builder, VectorOffset failureConditionsTypeOffset)
		{
			builder.AddOffset(3, failureConditionsTypeOffset.Value, 0);
		}

		// Token: 0x060273C8 RID: 160712 RVA: 0x0056609C File Offset: 0x0056429C
		public static VectorOffset CreateFailureConditionsTypeVector(FlatBufferBuilder builder, TTargetGearGroupFailureCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060273C9 RID: 160713 RVA: 0x005660D3 File Offset: 0x005642D3
		public static VectorOffset CreateFailureConditionsTypeVectorBlock(FlatBufferBuilder builder, TTargetGearGroupFailureCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTargetGearGroupFailureCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x060273CA RID: 160714 RVA: 0x005660ED File Offset: 0x005642ED
		public static VectorOffset CreateFailureConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTargetGearGroupFailureCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTargetGearGroupFailureCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x060273CB RID: 160715 RVA: 0x0056610B File Offset: 0x0056430B
		public static VectorOffset CreateFailureConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTargetGearGroupFailureCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060273CC RID: 160716 RVA: 0x00566124 File Offset: 0x00564324
		public static void StartFailureConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060273CD RID: 160717 RVA: 0x0056612F File Offset: 0x0056432F
		public static void AddFailureConditions(FlatBufferBuilder builder, VectorOffset failureConditionsOffset)
		{
			builder.AddOffset(4, failureConditionsOffset.Value, 0);
		}

		// Token: 0x060273CE RID: 160718 RVA: 0x00566140 File Offset: 0x00564340
		public static VectorOffset CreateFailureConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060273CF RID: 160719 RVA: 0x00566177 File Offset: 0x00564377
		public static VectorOffset CreateFailureConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060273D0 RID: 160720 RVA: 0x00566191 File Offset: 0x00564391
		public static VectorOffset CreateFailureConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060273D1 RID: 160721 RVA: 0x005661AF File Offset: 0x005643AF
		public static VectorOffset CreateFailureConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060273D2 RID: 160722 RVA: 0x005661C8 File Offset: 0x005643C8
		public static void StartFailureConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060273D3 RID: 160723 RVA: 0x005661D3 File Offset: 0x005643D3
		public static void AddCheckGears(FlatBufferBuilder builder, VectorOffset checkGearsOffset)
		{
			builder.AddOffset(5, checkGearsOffset.Value, 0);
		}

		// Token: 0x060273D4 RID: 160724 RVA: 0x005661E4 File Offset: 0x005643E4
		public static VectorOffset CreateCheckGearsVector(FlatBufferBuilder builder, Offset<ICheckGearHit>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060273D5 RID: 160725 RVA: 0x00566224 File Offset: 0x00564424
		public static VectorOffset CreateCheckGearsVectorBlock(FlatBufferBuilder builder, Offset<ICheckGearHit>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICheckGearHit>>(data);
			return builder.EndVector();
		}

		// Token: 0x060273D6 RID: 160726 RVA: 0x0056623E File Offset: 0x0056443E
		public static VectorOffset CreateCheckGearsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICheckGearHit>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICheckGearHit>>(data);
			return builder.EndVector();
		}

		// Token: 0x060273D7 RID: 160727 RVA: 0x0056625C File Offset: 0x0056445C
		public static VectorOffset CreateCheckGearsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICheckGearHit>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060273D8 RID: 160728 RVA: 0x00566275 File Offset: 0x00564475
		public static void StartCheckGearsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060273D9 RID: 160729 RVA: 0x00566280 File Offset: 0x00564480
		public static void AddFinishConfigType(FlatBufferBuilder builder, TGroupFinishConfig finishConfigType)
		{
			builder.AddByte(6, (byte)finishConfigType, 0);
		}

		// Token: 0x060273DA RID: 160730 RVA: 0x0056628B File Offset: 0x0056448B
		public static void AddFinishConfig(FlatBufferBuilder builder, int finishConfigOffset)
		{
			builder.AddOffset(7, finishConfigOffset, 0);
		}

		// Token: 0x060273DB RID: 160731 RVA: 0x00566296 File Offset: 0x00564496
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060273DC RID: 160732 RVA: 0x005662A1 File Offset: 0x005644A1
		public static Offset<ITargetGearGroupConfig> EndITargetGearGroupConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITargetGearGroupConfig>(builder.EndTable());
		}

		// Token: 0x060273DD RID: 160733 RVA: 0x005662B0 File Offset: 0x005644B0
		public ITargetGearGroupConfigT UnPack()
		{
			ITargetGearGroupConfigT targetGearGroupConfigT = new ITargetGearGroupConfigT();
			this.UnPackTo(targetGearGroupConfigT);
			return targetGearGroupConfigT;
		}

		// Token: 0x060273DE RID: 160734 RVA: 0x005662CC File Offset: 0x005644CC
		public void UnPackTo(ITargetGearGroupConfigT _o)
		{
			_o.Entitys = new List<int>();
			for (int i = 0; i < this.EntitysLength; i++)
			{
				_o.Entitys.Add(this.Entitys(i));
			}
			_o.SuccessCondition = new TTargetGearGroupSuccessConditionUnion();
			_o.SuccessCondition.Type = this.SuccessConditionType;
			switch (this.SuccessConditionType)
			{
			case TTargetGearGroupSuccessCondition.ISuccessConditionCountDownState:
				_o.SuccessCondition.Value = ((this.SuccessCondition<ISuccessConditionCountDownState>() != null) ? this.SuccessCondition<ISuccessConditionCountDownState>().Value.UnPack() : null);
				break;
			case TTargetGearGroupSuccessCondition.ISuccessConditionSameArbitraryState:
				_o.SuccessCondition.Value = ((this.SuccessCondition<ISuccessConditionSameArbitraryState>() != null) ? this.SuccessCondition<ISuccessConditionSameArbitraryState>().Value.UnPack() : null);
				break;
			case TTargetGearGroupSuccessCondition.ISuccessConditionSameSpecificState:
				_o.SuccessCondition.Value = ((this.SuccessCondition<ISuccessConditionSameSpecificState>() != null) ? this.SuccessCondition<ISuccessConditionSameSpecificState>().Value.UnPack() : null);
				break;
			case TTargetGearGroupSuccessCondition.ISuccessConditionSpecificTargetState:
				_o.SuccessCondition.Value = ((this.SuccessCondition<ISuccessConditionSpecificTargetState>() != null) ? this.SuccessCondition<ISuccessConditionSpecificTargetState>().Value.UnPack() : null);
				break;
			}
			_o.FailureConditions = new List<TTargetGearGroupFailureConditionUnion>();
			for (int j = 0; j < this.FailureConditionsLength; j++)
			{
				TTargetGearGroupFailureConditionUnion ttargetGearGroupFailureConditionUnion = new TTargetGearGroupFailureConditionUnion();
				ttargetGearGroupFailureConditionUnion.Type = this.FailureConditionsType(j);
				switch (this.FailureConditionsType(j))
				{
				case TTargetGearGroupFailureCondition.IFailureConditionArbitraryState:
					ttargetGearGroupFailureConditionUnion.Value = ((this.FailureConditions<IFailureConditionArbitraryState>(j) != null) ? this.FailureConditions<IFailureConditionArbitraryState>(j).Value.UnPack() : null);
					break;
				case TTargetGearGroupFailureCondition.IFailureConditionHitTargetEntity:
					ttargetGearGroupFailureConditionUnion.Value = ((this.FailureConditions<IFailureConditionHitTargetEntity>(j) != null) ? this.FailureConditions<IFailureConditionHitTargetEntity>(j).Value.UnPack() : null);
					break;
				case TTargetGearGroupFailureCondition.IFailureConditionSequentialState:
					ttargetGearGroupFailureConditionUnion.Value = ((this.FailureConditions<IFailureConditionSequentialState>(j) != null) ? this.FailureConditions<IFailureConditionSequentialState>(j).Value.UnPack() : null);
					break;
				}
				_o.FailureConditions.Add(ttargetGearGroupFailureConditionUnion);
			}
			_o.CheckGears = new List<ICheckGearHitT>();
			for (int k = 0; k < this.CheckGearsLength; k++)
			{
				_o.CheckGears.Add((this.CheckGears(k) != null) ? this.CheckGears(k).Value.UnPack() : null);
			}
			_o.FinishConfig = new TGroupFinishConfigUnion();
			_o.FinishConfig.Type = this.FinishConfigType;
			TGroupFinishConfig finishConfigType = this.FinishConfigType;
			if (finishConfigType != TGroupFinishConfig.IGroupFinishDestroy)
			{
				if (finishConfigType == TGroupFinishConfig.IGroupFinishSilence)
				{
					_o.FinishConfig.Value = ((this.FinishConfig<IGroupFinishSilence>() != null) ? this.FinishConfig<IGroupFinishSilence>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.FinishConfig.Value = ((this.FinishConfig<IGroupFinishDestroy>() != null) ? this.FinishConfig<IGroupFinishDestroy>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060273DF RID: 160735 RVA: 0x00566648 File Offset: 0x00564848
		public static Offset<ITargetGearGroupConfig> Pack(FlatBufferBuilder builder, ITargetGearGroupConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetGearGroupConfig>);
			}
			VectorOffset entitysOffset = default(VectorOffset);
			if (_o.Entitys != null)
			{
				int[] data = _o.Entitys.ToArray();
				entitysOffset = ITargetGearGroupConfig.CreateEntitysVector(builder, data);
			}
			TTargetGearGroupSuccessCondition successCondition_type = (_o.SuccessCondition == null) ? TTargetGearGroupSuccessCondition.NONE : _o.SuccessCondition.Type;
			int successConditionOffset = (_o.SuccessCondition == null) ? 0 : TTargetGearGroupSuccessConditionUnion.Pack(builder, _o.SuccessCondition);
			VectorOffset failureConditions_typeOffset = default(VectorOffset);
			if (_o.FailureConditions != null)
			{
				TTargetGearGroupFailureCondition[] array = new TTargetGearGroupFailureCondition[_o.FailureConditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.FailureConditions[i].Type;
				}
				failureConditions_typeOffset = ITargetGearGroupConfig.CreateFailureConditionsTypeVector(builder, array);
			}
			VectorOffset failureConditionsOffset = default(VectorOffset);
			if (_o.FailureConditions != null)
			{
				int[] array2 = new int[_o.FailureConditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TTargetGearGroupFailureConditionUnion.Pack(builder, _o.FailureConditions[j]);
				}
				failureConditionsOffset = ITargetGearGroupConfig.CreateFailureConditionsVector(builder, array2);
			}
			VectorOffset checkGearsOffset = default(VectorOffset);
			if (_o.CheckGears != null)
			{
				Offset<ICheckGearHit>[] array3 = new Offset<ICheckGearHit>[_o.CheckGears.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = ICheckGearHit.Pack(builder, _o.CheckGears[k]);
				}
				checkGearsOffset = ITargetGearGroupConfig.CreateCheckGearsVector(builder, array3);
			}
			TGroupFinishConfig finishConfig_type = (_o.FinishConfig == null) ? TGroupFinishConfig.NONE : _o.FinishConfig.Type;
			int finishConfigOffset = (_o.FinishConfig == null) ? 0 : TGroupFinishConfigUnion.Pack(builder, _o.FinishConfig);
			return ITargetGearGroupConfig.CreateITargetGearGroupConfig(builder, entitysOffset, successCondition_type, successConditionOffset, failureConditions_typeOffset, failureConditionsOffset, checkGearsOffset, finishConfig_type, finishConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F08F RID: 61583
		private Table __p;
	}
}

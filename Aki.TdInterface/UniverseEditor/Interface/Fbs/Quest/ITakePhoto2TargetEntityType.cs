using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004196 RID: 16790
	public struct ITakePhoto2TargetEntityType : IFlatbufferObject
	{
		// Token: 0x1700770C RID: 30476
		// (get) Token: 0x06018B35 RID: 101173 RVA: 0x0038E8E5 File Offset: 0x0038CAE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018B36 RID: 101174 RVA: 0x0038E8F2 File Offset: 0x0038CAF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018B37 RID: 101175 RVA: 0x0038E8FC File Offset: 0x0038CAFC
		public static ITakePhoto2TargetEntityType GetRootAsITakePhoto2TargetEntityType(ByteBuffer _bb)
		{
			return ITakePhoto2TargetEntityType.GetRootAsITakePhoto2TargetEntityType(_bb, default(ITakePhoto2TargetEntityType));
		}

		// Token: 0x06018B38 RID: 101176 RVA: 0x0038E918 File Offset: 0x0038CB18
		public static ITakePhoto2TargetEntityType GetRootAsITakePhoto2TargetEntityType(ByteBuffer _bb, ITakePhoto2TargetEntityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018B39 RID: 101177 RVA: 0x0038E935 File Offset: 0x0038CB35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018B3A RID: 101178 RVA: 0x0038E944 File Offset: 0x0038CB44
		public ITakePhoto2TargetEntityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700770D RID: 30477
		// (get) Token: 0x06018B3B RID: 101179 RVA: 0x0038E954 File Offset: 0x0038CB54
		public ETakePhoto2TargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETakePhoto2TargetType.Entity;
				}
				return (ETakePhoto2TargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700770E RID: 30478
		// (get) Token: 0x06018B3C RID: 101180 RVA: 0x0038E990 File Offset: 0x0038CB90
		public bool IsOptionalTarget
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700770F RID: 30479
		// (get) Token: 0x06018B3D RID: 101181 RVA: 0x0038E9D0 File Offset: 0x0038CBD0
		public ITakePhoto2TargetCameraDistanceCondition? TargetCameraDistanceCondition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TargetCameraDistanceCondition?(default(ITakePhoto2TargetCameraDistanceCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007710 RID: 30480
		// (get) Token: 0x06018B3E RID: 101182 RVA: 0x0038EA30 File Offset: 0x0038CC30
		public IEntityCategory? EntityCategory
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IEntityCategory?(default(IEntityCategory).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007711 RID: 30481
		// (get) Token: 0x06018B3F RID: 101183 RVA: 0x0038EA90 File Offset: 0x0038CC90
		public ITakePhoto2TargetPosByRangeCondition? TargetPosCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TargetPosByRangeCondition?(default(ITakePhoto2TargetPosByRangeCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007712 RID: 30482
		// (get) Token: 0x06018B40 RID: 101184 RVA: 0x0038EAF0 File Offset: 0x0038CCF0
		public ITakePhoto2TargetPlayMontageCondition? TargetPlayMontageCondition
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TargetPlayMontageCondition?(default(ITakePhoto2TargetPlayMontageCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007713 RID: 30483
		// (get) Token: 0x06018B41 RID: 101185 RVA: 0x0038EB50 File Offset: 0x0038CD50
		public ITakePhoto2TargetAnsTagCondition? TargetAnsTagCondition
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TargetAnsTagCondition?(default(ITakePhoto2TargetAnsTagCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007714 RID: 30484
		// (get) Token: 0x06018B42 RID: 101186 RVA: 0x0038EBB0 File Offset: 0x0038CDB0
		public int TargetSatisfiedCount
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007715 RID: 30485
		// (get) Token: 0x06018B43 RID: 101187 RVA: 0x0038EBF0 File Offset: 0x0038CDF0
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

		// Token: 0x06018B44 RID: 101188 RVA: 0x0038EC30 File Offset: 0x0038CE30
		public static Offset<ITakePhoto2TargetEntityType> CreateITakePhoto2TargetEntityType(FlatBufferBuilder builder, ETakePhoto2TargetType Type = ETakePhoto2TargetType.Entity, bool IsOptionalTarget = false, Offset<ITakePhoto2TargetCameraDistanceCondition> TargetCameraDistanceConditionOffset = default(Offset<ITakePhoto2TargetCameraDistanceCondition>), Offset<IEntityCategory> EntityCategoryOffset = default(Offset<IEntityCategory>), Offset<ITakePhoto2TargetPosByRangeCondition> TargetPosConditionOffset = default(Offset<ITakePhoto2TargetPosByRangeCondition>), Offset<ITakePhoto2TargetPlayMontageCondition> TargetPlayMontageConditionOffset = default(Offset<ITakePhoto2TargetPlayMontageCondition>), Offset<ITakePhoto2TargetAnsTagCondition> TargetAnsTagConditionOffset = default(Offset<ITakePhoto2TargetAnsTagCondition>), int TargetSatisfiedCount = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			ITakePhoto2TargetEntityType.AddTargetSatisfiedCount(builder, TargetSatisfiedCount);
			ITakePhoto2TargetEntityType.AddTargetAnsTagCondition(builder, TargetAnsTagConditionOffset);
			ITakePhoto2TargetEntityType.AddTargetPlayMontageCondition(builder, TargetPlayMontageConditionOffset);
			ITakePhoto2TargetEntityType.AddTargetPosCondition(builder, TargetPosConditionOffset);
			ITakePhoto2TargetEntityType.AddEntityCategory(builder, EntityCategoryOffset);
			ITakePhoto2TargetEntityType.AddTargetCameraDistanceCondition(builder, TargetCameraDistanceConditionOffset);
			ITakePhoto2TargetEntityType.AddNullMask(builder, NullMask);
			ITakePhoto2TargetEntityType.AddIsOptionalTarget(builder, IsOptionalTarget);
			ITakePhoto2TargetEntityType.AddType(builder, Type);
			return ITakePhoto2TargetEntityType.EndITakePhoto2TargetEntityType(builder);
		}

		// Token: 0x06018B45 RID: 101189 RVA: 0x0038EC90 File Offset: 0x0038CE90
		public static void StartITakePhoto2TargetEntityType(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06018B46 RID: 101190 RVA: 0x0038EC9A File Offset: 0x0038CE9A
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2TargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018B47 RID: 101191 RVA: 0x0038ECA5 File Offset: 0x0038CEA5
		public static void AddIsOptionalTarget(FlatBufferBuilder builder, bool isOptionalTarget)
		{
			builder.AddBool(1, isOptionalTarget, false);
		}

		// Token: 0x06018B48 RID: 101192 RVA: 0x0038ECB0 File Offset: 0x0038CEB0
		public static void AddTargetCameraDistanceCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset)
		{
			builder.AddOffset(2, targetCameraDistanceConditionOffset.Value, 0);
		}

		// Token: 0x06018B49 RID: 101193 RVA: 0x0038ECC0 File Offset: 0x0038CEC0
		public static void AddEntityCategory(FlatBufferBuilder builder, Offset<IEntityCategory> entityCategoryOffset)
		{
			builder.AddOffset(3, entityCategoryOffset.Value, 0);
		}

		// Token: 0x06018B4A RID: 101194 RVA: 0x0038ECD0 File Offset: 0x0038CED0
		public static void AddTargetPosCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset)
		{
			builder.AddOffset(4, targetPosConditionOffset.Value, 0);
		}

		// Token: 0x06018B4B RID: 101195 RVA: 0x0038ECE0 File Offset: 0x0038CEE0
		public static void AddTargetPlayMontageCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPlayMontageCondition> targetPlayMontageConditionOffset)
		{
			builder.AddOffset(5, targetPlayMontageConditionOffset.Value, 0);
		}

		// Token: 0x06018B4C RID: 101196 RVA: 0x0038ECF0 File Offset: 0x0038CEF0
		public static void AddTargetAnsTagCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetAnsTagCondition> targetAnsTagConditionOffset)
		{
			builder.AddOffset(6, targetAnsTagConditionOffset.Value, 0);
		}

		// Token: 0x06018B4D RID: 101197 RVA: 0x0038ED00 File Offset: 0x0038CF00
		public static void AddTargetSatisfiedCount(FlatBufferBuilder builder, int targetSatisfiedCount)
		{
			builder.AddInt(7, targetSatisfiedCount, 0);
		}

		// Token: 0x06018B4E RID: 101198 RVA: 0x0038ED0B File Offset: 0x0038CF0B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06018B4F RID: 101199 RVA: 0x0038ED16 File Offset: 0x0038CF16
		public static Offset<ITakePhoto2TargetEntityType> EndITakePhoto2TargetEntityType(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TargetEntityType>(builder.EndTable());
		}

		// Token: 0x06018B50 RID: 101200 RVA: 0x0038ED24 File Offset: 0x0038CF24
		public ITakePhoto2TargetEntityTypeT UnPack()
		{
			ITakePhoto2TargetEntityTypeT takePhoto2TargetEntityTypeT = new ITakePhoto2TargetEntityTypeT();
			this.UnPackTo(takePhoto2TargetEntityTypeT);
			return takePhoto2TargetEntityTypeT;
		}

		// Token: 0x06018B51 RID: 101201 RVA: 0x0038ED40 File Offset: 0x0038CF40
		public void UnPackTo(ITakePhoto2TargetEntityTypeT _o)
		{
			_o.Type = this.Type;
			_o.IsOptionalTarget = this.IsOptionalTarget;
			_o.TargetCameraDistanceCondition = ((this.TargetCameraDistanceCondition != null) ? this.TargetCameraDistanceCondition.Value.UnPack() : null);
			_o.EntityCategory = ((this.EntityCategory != null) ? this.EntityCategory.Value.UnPack() : null);
			_o.TargetPosCondition = ((this.TargetPosCondition != null) ? this.TargetPosCondition.Value.UnPack() : null);
			_o.TargetPlayMontageCondition = ((this.TargetPlayMontageCondition != null) ? this.TargetPlayMontageCondition.Value.UnPack() : null);
			_o.TargetAnsTagCondition = ((this.TargetAnsTagCondition != null) ? this.TargetAnsTagCondition.Value.UnPack() : null);
			_o.TargetSatisfiedCount = this.TargetSatisfiedCount;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018B52 RID: 101202 RVA: 0x0038EE74 File Offset: 0x0038D074
		public static Offset<ITakePhoto2TargetEntityType> Pack(FlatBufferBuilder builder, ITakePhoto2TargetEntityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2TargetEntityType>);
			}
			Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset = (_o.TargetCameraDistanceCondition == null) ? default(Offset<ITakePhoto2TargetCameraDistanceCondition>) : ITakePhoto2TargetCameraDistanceCondition.Pack(builder, _o.TargetCameraDistanceCondition);
			Offset<IEntityCategory> entityCategoryOffset = (_o.EntityCategory == null) ? default(Offset<IEntityCategory>) : IEntityCategory.Pack(builder, _o.EntityCategory);
			Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset = (_o.TargetPosCondition == null) ? default(Offset<ITakePhoto2TargetPosByRangeCondition>) : ITakePhoto2TargetPosByRangeCondition.Pack(builder, _o.TargetPosCondition);
			Offset<ITakePhoto2TargetPlayMontageCondition> targetPlayMontageConditionOffset = (_o.TargetPlayMontageCondition == null) ? default(Offset<ITakePhoto2TargetPlayMontageCondition>) : ITakePhoto2TargetPlayMontageCondition.Pack(builder, _o.TargetPlayMontageCondition);
			Offset<ITakePhoto2TargetAnsTagCondition> targetAnsTagConditionOffset = (_o.TargetAnsTagCondition == null) ? default(Offset<ITakePhoto2TargetAnsTagCondition>) : ITakePhoto2TargetAnsTagCondition.Pack(builder, _o.TargetAnsTagCondition);
			return ITakePhoto2TargetEntityType.CreateITakePhoto2TargetEntityType(builder, _o.Type, _o.IsOptionalTarget, targetCameraDistanceConditionOffset, entityCategoryOffset, targetPosConditionOffset, targetPlayMontageConditionOffset, targetAnsTagConditionOffset, _o.TargetSatisfiedCount, _o.NullMask);
		}

		// Token: 0x0400BDC9 RID: 48585
		private Table __p;
	}
}

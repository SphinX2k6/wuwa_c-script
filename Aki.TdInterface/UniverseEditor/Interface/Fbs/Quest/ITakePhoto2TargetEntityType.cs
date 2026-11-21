using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045EF RID: 17903
	public struct ITakePhoto2TargetEntityType : IFlatbufferObject
	{
		// Token: 0x17007D38 RID: 32056
		// (get) Token: 0x0601A28B RID: 107147 RVA: 0x003B9D39 File Offset: 0x003B7F39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A28C RID: 107148 RVA: 0x003B9D46 File Offset: 0x003B7F46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A28D RID: 107149 RVA: 0x003B9D50 File Offset: 0x003B7F50
		public static ITakePhoto2TargetEntityType GetRootAsITakePhoto2TargetEntityType(ByteBuffer _bb)
		{
			return ITakePhoto2TargetEntityType.GetRootAsITakePhoto2TargetEntityType(_bb, default(ITakePhoto2TargetEntityType));
		}

		// Token: 0x0601A28E RID: 107150 RVA: 0x003B9D6C File Offset: 0x003B7F6C
		public static ITakePhoto2TargetEntityType GetRootAsITakePhoto2TargetEntityType(ByteBuffer _bb, ITakePhoto2TargetEntityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A28F RID: 107151 RVA: 0x003B9D89 File Offset: 0x003B7F89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A290 RID: 107152 RVA: 0x003B9D98 File Offset: 0x003B7F98
		public ITakePhoto2TargetEntityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D39 RID: 32057
		// (get) Token: 0x0601A291 RID: 107153 RVA: 0x003B9DA8 File Offset: 0x003B7FA8
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

		// Token: 0x17007D3A RID: 32058
		// (get) Token: 0x0601A292 RID: 107154 RVA: 0x003B9DE4 File Offset: 0x003B7FE4
		public bool IsOptionalTarget
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007D3B RID: 32059
		// (get) Token: 0x0601A293 RID: 107155 RVA: 0x003B9E24 File Offset: 0x003B8024
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

		// Token: 0x17007D3C RID: 32060
		// (get) Token: 0x0601A294 RID: 107156 RVA: 0x003B9E84 File Offset: 0x003B8084
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

		// Token: 0x17007D3D RID: 32061
		// (get) Token: 0x0601A295 RID: 107157 RVA: 0x003B9EE4 File Offset: 0x003B80E4
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

		// Token: 0x17007D3E RID: 32062
		// (get) Token: 0x0601A296 RID: 107158 RVA: 0x003B9F44 File Offset: 0x003B8144
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

		// Token: 0x17007D3F RID: 32063
		// (get) Token: 0x0601A297 RID: 107159 RVA: 0x003B9FA4 File Offset: 0x003B81A4
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

		// Token: 0x17007D40 RID: 32064
		// (get) Token: 0x0601A298 RID: 107160 RVA: 0x003BA004 File Offset: 0x003B8204
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

		// Token: 0x17007D41 RID: 32065
		// (get) Token: 0x0601A299 RID: 107161 RVA: 0x003BA044 File Offset: 0x003B8244
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

		// Token: 0x0601A29A RID: 107162 RVA: 0x003BA084 File Offset: 0x003B8284
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

		// Token: 0x0601A29B RID: 107163 RVA: 0x003BA0E4 File Offset: 0x003B82E4
		public static void StartITakePhoto2TargetEntityType(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601A29C RID: 107164 RVA: 0x003BA0EE File Offset: 0x003B82EE
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2TargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A29D RID: 107165 RVA: 0x003BA0F9 File Offset: 0x003B82F9
		public static void AddIsOptionalTarget(FlatBufferBuilder builder, bool isOptionalTarget)
		{
			builder.AddBool(1, isOptionalTarget, false);
		}

		// Token: 0x0601A29E RID: 107166 RVA: 0x003BA104 File Offset: 0x003B8304
		public static void AddTargetCameraDistanceCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset)
		{
			builder.AddOffset(2, targetCameraDistanceConditionOffset.Value, 0);
		}

		// Token: 0x0601A29F RID: 107167 RVA: 0x003BA114 File Offset: 0x003B8314
		public static void AddEntityCategory(FlatBufferBuilder builder, Offset<IEntityCategory> entityCategoryOffset)
		{
			builder.AddOffset(3, entityCategoryOffset.Value, 0);
		}

		// Token: 0x0601A2A0 RID: 107168 RVA: 0x003BA124 File Offset: 0x003B8324
		public static void AddTargetPosCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset)
		{
			builder.AddOffset(4, targetPosConditionOffset.Value, 0);
		}

		// Token: 0x0601A2A1 RID: 107169 RVA: 0x003BA134 File Offset: 0x003B8334
		public static void AddTargetPlayMontageCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPlayMontageCondition> targetPlayMontageConditionOffset)
		{
			builder.AddOffset(5, targetPlayMontageConditionOffset.Value, 0);
		}

		// Token: 0x0601A2A2 RID: 107170 RVA: 0x003BA144 File Offset: 0x003B8344
		public static void AddTargetAnsTagCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetAnsTagCondition> targetAnsTagConditionOffset)
		{
			builder.AddOffset(6, targetAnsTagConditionOffset.Value, 0);
		}

		// Token: 0x0601A2A3 RID: 107171 RVA: 0x003BA154 File Offset: 0x003B8354
		public static void AddTargetSatisfiedCount(FlatBufferBuilder builder, int targetSatisfiedCount)
		{
			builder.AddInt(7, targetSatisfiedCount, 0);
		}

		// Token: 0x0601A2A4 RID: 107172 RVA: 0x003BA15F File Offset: 0x003B835F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601A2A5 RID: 107173 RVA: 0x003BA16A File Offset: 0x003B836A
		public static Offset<ITakePhoto2TargetEntityType> EndITakePhoto2TargetEntityType(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TargetEntityType>(builder.EndTable());
		}

		// Token: 0x0601A2A6 RID: 107174 RVA: 0x003BA178 File Offset: 0x003B8378
		public ITakePhoto2TargetEntityTypeT UnPack()
		{
			ITakePhoto2TargetEntityTypeT takePhoto2TargetEntityTypeT = new ITakePhoto2TargetEntityTypeT();
			this.UnPackTo(takePhoto2TargetEntityTypeT);
			return takePhoto2TargetEntityTypeT;
		}

		// Token: 0x0601A2A7 RID: 107175 RVA: 0x003BA194 File Offset: 0x003B8394
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

		// Token: 0x0601A2A8 RID: 107176 RVA: 0x003BA2C8 File Offset: 0x003B84C8
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

		// Token: 0x0400C7D3 RID: 51155
		private Table __p;
	}
}

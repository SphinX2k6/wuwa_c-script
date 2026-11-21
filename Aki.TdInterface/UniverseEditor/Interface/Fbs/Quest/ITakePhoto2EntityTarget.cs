using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045C8 RID: 17864
	public struct ITakePhoto2EntityTarget : IFlatbufferObject
	{
		// Token: 0x17007CE7 RID: 31975
		// (get) Token: 0x0601A14D RID: 106829 RVA: 0x003B78C0 File Offset: 0x003B5AC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A14E RID: 106830 RVA: 0x003B78CD File Offset: 0x003B5ACD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A14F RID: 106831 RVA: 0x003B78D4 File Offset: 0x003B5AD4
		public static ITakePhoto2EntityTarget GetRootAsITakePhoto2EntityTarget(ByteBuffer _bb)
		{
			return ITakePhoto2EntityTarget.GetRootAsITakePhoto2EntityTarget(_bb, default(ITakePhoto2EntityTarget));
		}

		// Token: 0x0601A150 RID: 106832 RVA: 0x003B78F0 File Offset: 0x003B5AF0
		public static ITakePhoto2EntityTarget GetRootAsITakePhoto2EntityTarget(ByteBuffer _bb, ITakePhoto2EntityTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A151 RID: 106833 RVA: 0x003B790D File Offset: 0x003B5B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A152 RID: 106834 RVA: 0x003B791C File Offset: 0x003B5B1C
		public ITakePhoto2EntityTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CE8 RID: 31976
		// (get) Token: 0x0601A153 RID: 106835 RVA: 0x003B792C File Offset: 0x003B5B2C
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

		// Token: 0x17007CE9 RID: 31977
		// (get) Token: 0x0601A154 RID: 106836 RVA: 0x003B7968 File Offset: 0x003B5B68
		public bool IsOptionalTarget
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007CEA RID: 31978
		// (get) Token: 0x0601A155 RID: 106837 RVA: 0x003B79A8 File Offset: 0x003B5BA8
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

		// Token: 0x17007CEB RID: 31979
		// (get) Token: 0x0601A156 RID: 106838 RVA: 0x003B7A08 File Offset: 0x003B5C08
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007CEC RID: 31980
		// (get) Token: 0x0601A157 RID: 106839 RVA: 0x003B7A48 File Offset: 0x003B5C48
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

		// Token: 0x17007CED RID: 31981
		// (get) Token: 0x0601A158 RID: 106840 RVA: 0x003B7AA8 File Offset: 0x003B5CA8
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

		// Token: 0x17007CEE RID: 31982
		// (get) Token: 0x0601A159 RID: 106841 RVA: 0x003B7B08 File Offset: 0x003B5D08
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

		// Token: 0x17007CEF RID: 31983
		// (get) Token: 0x0601A15A RID: 106842 RVA: 0x003B7B68 File Offset: 0x003B5D68
		public ITakePhoto2TargetPartCondition? TargetPartCondition
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TargetPartCondition?(default(ITakePhoto2TargetPartCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007CF0 RID: 31984
		// (get) Token: 0x0601A15B RID: 106843 RVA: 0x003B7BC8 File Offset: 0x003B5DC8
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

		// Token: 0x0601A15C RID: 106844 RVA: 0x003B7C08 File Offset: 0x003B5E08
		public static Offset<ITakePhoto2EntityTarget> CreateITakePhoto2EntityTarget(FlatBufferBuilder builder, ETakePhoto2TargetType Type = ETakePhoto2TargetType.Entity, bool IsOptionalTarget = false, Offset<ITakePhoto2TargetCameraDistanceCondition> TargetCameraDistanceConditionOffset = default(Offset<ITakePhoto2TargetCameraDistanceCondition>), int EntityId = 0, Offset<ITakePhoto2TargetPosByRangeCondition> TargetPosConditionOffset = default(Offset<ITakePhoto2TargetPosByRangeCondition>), Offset<ITakePhoto2TargetPlayMontageCondition> TargetPlayMontageConditionOffset = default(Offset<ITakePhoto2TargetPlayMontageCondition>), Offset<ITakePhoto2TargetAnsTagCondition> TargetAnsTagConditionOffset = default(Offset<ITakePhoto2TargetAnsTagCondition>), Offset<ITakePhoto2TargetPartCondition> TargetPartConditionOffset = default(Offset<ITakePhoto2TargetPartCondition>), byte NullMask = 0)
		{
			builder.StartTable(9);
			ITakePhoto2EntityTarget.AddTargetPartCondition(builder, TargetPartConditionOffset);
			ITakePhoto2EntityTarget.AddTargetAnsTagCondition(builder, TargetAnsTagConditionOffset);
			ITakePhoto2EntityTarget.AddTargetPlayMontageCondition(builder, TargetPlayMontageConditionOffset);
			ITakePhoto2EntityTarget.AddTargetPosCondition(builder, TargetPosConditionOffset);
			ITakePhoto2EntityTarget.AddEntityId(builder, EntityId);
			ITakePhoto2EntityTarget.AddTargetCameraDistanceCondition(builder, TargetCameraDistanceConditionOffset);
			ITakePhoto2EntityTarget.AddNullMask(builder, NullMask);
			ITakePhoto2EntityTarget.AddIsOptionalTarget(builder, IsOptionalTarget);
			ITakePhoto2EntityTarget.AddType(builder, Type);
			return ITakePhoto2EntityTarget.EndITakePhoto2EntityTarget(builder);
		}

		// Token: 0x0601A15D RID: 106845 RVA: 0x003B7C68 File Offset: 0x003B5E68
		public static void StartITakePhoto2EntityTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601A15E RID: 106846 RVA: 0x003B7C72 File Offset: 0x003B5E72
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2TargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A15F RID: 106847 RVA: 0x003B7C7D File Offset: 0x003B5E7D
		public static void AddIsOptionalTarget(FlatBufferBuilder builder, bool isOptionalTarget)
		{
			builder.AddBool(1, isOptionalTarget, false);
		}

		// Token: 0x0601A160 RID: 106848 RVA: 0x003B7C88 File Offset: 0x003B5E88
		public static void AddTargetCameraDistanceCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset)
		{
			builder.AddOffset(2, targetCameraDistanceConditionOffset.Value, 0);
		}

		// Token: 0x0601A161 RID: 106849 RVA: 0x003B7C98 File Offset: 0x003B5E98
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(3, entityId, 0);
		}

		// Token: 0x0601A162 RID: 106850 RVA: 0x003B7CA3 File Offset: 0x003B5EA3
		public static void AddTargetPosCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset)
		{
			builder.AddOffset(4, targetPosConditionOffset.Value, 0);
		}

		// Token: 0x0601A163 RID: 106851 RVA: 0x003B7CB3 File Offset: 0x003B5EB3
		public static void AddTargetPlayMontageCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPlayMontageCondition> targetPlayMontageConditionOffset)
		{
			builder.AddOffset(5, targetPlayMontageConditionOffset.Value, 0);
		}

		// Token: 0x0601A164 RID: 106852 RVA: 0x003B7CC3 File Offset: 0x003B5EC3
		public static void AddTargetAnsTagCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetAnsTagCondition> targetAnsTagConditionOffset)
		{
			builder.AddOffset(6, targetAnsTagConditionOffset.Value, 0);
		}

		// Token: 0x0601A165 RID: 106853 RVA: 0x003B7CD3 File Offset: 0x003B5ED3
		public static void AddTargetPartCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPartCondition> targetPartConditionOffset)
		{
			builder.AddOffset(7, targetPartConditionOffset.Value, 0);
		}

		// Token: 0x0601A166 RID: 106854 RVA: 0x003B7CE3 File Offset: 0x003B5EE3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601A167 RID: 106855 RVA: 0x003B7CEE File Offset: 0x003B5EEE
		public static Offset<ITakePhoto2EntityTarget> EndITakePhoto2EntityTarget(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2EntityTarget>(builder.EndTable());
		}

		// Token: 0x0601A168 RID: 106856 RVA: 0x003B7CFC File Offset: 0x003B5EFC
		public ITakePhoto2EntityTargetT UnPack()
		{
			ITakePhoto2EntityTargetT takePhoto2EntityTargetT = new ITakePhoto2EntityTargetT();
			this.UnPackTo(takePhoto2EntityTargetT);
			return takePhoto2EntityTargetT;
		}

		// Token: 0x0601A169 RID: 106857 RVA: 0x003B7D18 File Offset: 0x003B5F18
		public void UnPackTo(ITakePhoto2EntityTargetT _o)
		{
			_o.Type = this.Type;
			_o.IsOptionalTarget = this.IsOptionalTarget;
			_o.TargetCameraDistanceCondition = ((this.TargetCameraDistanceCondition != null) ? this.TargetCameraDistanceCondition.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.TargetPosCondition = ((this.TargetPosCondition != null) ? this.TargetPosCondition.Value.UnPack() : null);
			_o.TargetPlayMontageCondition = ((this.TargetPlayMontageCondition != null) ? this.TargetPlayMontageCondition.Value.UnPack() : null);
			_o.TargetAnsTagCondition = ((this.TargetAnsTagCondition != null) ? this.TargetAnsTagCondition.Value.UnPack() : null);
			_o.TargetPartCondition = ((this.TargetPartCondition != null) ? this.TargetPartCondition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A16A RID: 106858 RVA: 0x003B7E4C File Offset: 0x003B604C
		public static Offset<ITakePhoto2EntityTarget> Pack(FlatBufferBuilder builder, ITakePhoto2EntityTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2EntityTarget>);
			}
			Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset = (_o.TargetCameraDistanceCondition == null) ? default(Offset<ITakePhoto2TargetCameraDistanceCondition>) : ITakePhoto2TargetCameraDistanceCondition.Pack(builder, _o.TargetCameraDistanceCondition);
			Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset = (_o.TargetPosCondition == null) ? default(Offset<ITakePhoto2TargetPosByRangeCondition>) : ITakePhoto2TargetPosByRangeCondition.Pack(builder, _o.TargetPosCondition);
			Offset<ITakePhoto2TargetPlayMontageCondition> targetPlayMontageConditionOffset = (_o.TargetPlayMontageCondition == null) ? default(Offset<ITakePhoto2TargetPlayMontageCondition>) : ITakePhoto2TargetPlayMontageCondition.Pack(builder, _o.TargetPlayMontageCondition);
			Offset<ITakePhoto2TargetAnsTagCondition> targetAnsTagConditionOffset = (_o.TargetAnsTagCondition == null) ? default(Offset<ITakePhoto2TargetAnsTagCondition>) : ITakePhoto2TargetAnsTagCondition.Pack(builder, _o.TargetAnsTagCondition);
			Offset<ITakePhoto2TargetPartCondition> targetPartConditionOffset = (_o.TargetPartCondition == null) ? default(Offset<ITakePhoto2TargetPartCondition>) : ITakePhoto2TargetPartCondition.Pack(builder, _o.TargetPartCondition);
			return ITakePhoto2EntityTarget.CreateITakePhoto2EntityTarget(builder, _o.Type, _o.IsOptionalTarget, targetCameraDistanceConditionOffset, _o.EntityId, targetPosConditionOffset, targetPlayMontageConditionOffset, targetAnsTagConditionOffset, targetPartConditionOffset, _o.NullMask);
		}

		// Token: 0x0400C79A RID: 51098
		private Table __p;
	}
}

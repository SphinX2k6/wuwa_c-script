using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045D4 RID: 17876
	public struct ITakePhoto2PhotoTargetEntityTarget : IFlatbufferObject
	{
		// Token: 0x17007D02 RID: 32002
		// (get) Token: 0x0601A1AF RID: 106927 RVA: 0x003B853E File Offset: 0x003B673E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A1B0 RID: 106928 RVA: 0x003B854B File Offset: 0x003B674B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A1B1 RID: 106929 RVA: 0x003B8554 File Offset: 0x003B6754
		public static ITakePhoto2PhotoTargetEntityTarget GetRootAsITakePhoto2PhotoTargetEntityTarget(ByteBuffer _bb)
		{
			return ITakePhoto2PhotoTargetEntityTarget.GetRootAsITakePhoto2PhotoTargetEntityTarget(_bb, default(ITakePhoto2PhotoTargetEntityTarget));
		}

		// Token: 0x0601A1B2 RID: 106930 RVA: 0x003B8570 File Offset: 0x003B6770
		public static ITakePhoto2PhotoTargetEntityTarget GetRootAsITakePhoto2PhotoTargetEntityTarget(ByteBuffer _bb, ITakePhoto2PhotoTargetEntityTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A1B3 RID: 106931 RVA: 0x003B858D File Offset: 0x003B678D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A1B4 RID: 106932 RVA: 0x003B859C File Offset: 0x003B679C
		public ITakePhoto2PhotoTargetEntityTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D03 RID: 32003
		// (get) Token: 0x0601A1B5 RID: 106933 RVA: 0x003B85AC File Offset: 0x003B67AC
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

		// Token: 0x17007D04 RID: 32004
		// (get) Token: 0x0601A1B6 RID: 106934 RVA: 0x003B85E8 File Offset: 0x003B67E8
		public bool IsOptionalTarget
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007D05 RID: 32005
		// (get) Token: 0x0601A1B7 RID: 106935 RVA: 0x003B8628 File Offset: 0x003B6828
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

		// Token: 0x17007D06 RID: 32006
		// (get) Token: 0x0601A1B8 RID: 106936 RVA: 0x003B8688 File Offset: 0x003B6888
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

		// Token: 0x17007D07 RID: 32007
		// (get) Token: 0x0601A1B9 RID: 106937 RVA: 0x003B86C8 File Offset: 0x003B68C8
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

		// Token: 0x17007D08 RID: 32008
		// (get) Token: 0x0601A1BA RID: 106938 RVA: 0x003B8728 File Offset: 0x003B6928
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A1BB RID: 106939 RVA: 0x003B8765 File Offset: 0x003B6965
		public static Offset<ITakePhoto2PhotoTargetEntityTarget> CreateITakePhoto2PhotoTargetEntityTarget(FlatBufferBuilder builder, ETakePhoto2TargetType Type = ETakePhoto2TargetType.Entity, bool IsOptionalTarget = false, Offset<ITakePhoto2TargetCameraDistanceCondition> TargetCameraDistanceConditionOffset = default(Offset<ITakePhoto2TargetCameraDistanceCondition>), int EntityId = 0, Offset<ITakePhoto2TargetPosByRangeCondition> TargetPosConditionOffset = default(Offset<ITakePhoto2TargetPosByRangeCondition>), byte NullMask = 0)
		{
			builder.StartTable(6);
			ITakePhoto2PhotoTargetEntityTarget.AddTargetPosCondition(builder, TargetPosConditionOffset);
			ITakePhoto2PhotoTargetEntityTarget.AddEntityId(builder, EntityId);
			ITakePhoto2PhotoTargetEntityTarget.AddTargetCameraDistanceCondition(builder, TargetCameraDistanceConditionOffset);
			ITakePhoto2PhotoTargetEntityTarget.AddNullMask(builder, NullMask);
			ITakePhoto2PhotoTargetEntityTarget.AddIsOptionalTarget(builder, IsOptionalTarget);
			ITakePhoto2PhotoTargetEntityTarget.AddType(builder, Type);
			return ITakePhoto2PhotoTargetEntityTarget.EndITakePhoto2PhotoTargetEntityTarget(builder);
		}

		// Token: 0x0601A1BC RID: 106940 RVA: 0x003B87A1 File Offset: 0x003B69A1
		public static void StartITakePhoto2PhotoTargetEntityTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601A1BD RID: 106941 RVA: 0x003B87AA File Offset: 0x003B69AA
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2TargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A1BE RID: 106942 RVA: 0x003B87B5 File Offset: 0x003B69B5
		public static void AddIsOptionalTarget(FlatBufferBuilder builder, bool isOptionalTarget)
		{
			builder.AddBool(1, isOptionalTarget, false);
		}

		// Token: 0x0601A1BF RID: 106943 RVA: 0x003B87C0 File Offset: 0x003B69C0
		public static void AddTargetCameraDistanceCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset)
		{
			builder.AddOffset(2, targetCameraDistanceConditionOffset.Value, 0);
		}

		// Token: 0x0601A1C0 RID: 106944 RVA: 0x003B87D0 File Offset: 0x003B69D0
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(3, entityId, 0);
		}

		// Token: 0x0601A1C1 RID: 106945 RVA: 0x003B87DB File Offset: 0x003B69DB
		public static void AddTargetPosCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset)
		{
			builder.AddOffset(4, targetPosConditionOffset.Value, 0);
		}

		// Token: 0x0601A1C2 RID: 106946 RVA: 0x003B87EB File Offset: 0x003B69EB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601A1C3 RID: 106947 RVA: 0x003B87F6 File Offset: 0x003B69F6
		public static Offset<ITakePhoto2PhotoTargetEntityTarget> EndITakePhoto2PhotoTargetEntityTarget(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2PhotoTargetEntityTarget>(builder.EndTable());
		}

		// Token: 0x0601A1C4 RID: 106948 RVA: 0x003B8804 File Offset: 0x003B6A04
		public ITakePhoto2PhotoTargetEntityTargetT UnPack()
		{
			ITakePhoto2PhotoTargetEntityTargetT takePhoto2PhotoTargetEntityTargetT = new ITakePhoto2PhotoTargetEntityTargetT();
			this.UnPackTo(takePhoto2PhotoTargetEntityTargetT);
			return takePhoto2PhotoTargetEntityTargetT;
		}

		// Token: 0x0601A1C5 RID: 106949 RVA: 0x003B8820 File Offset: 0x003B6A20
		public void UnPackTo(ITakePhoto2PhotoTargetEntityTargetT _o)
		{
			_o.Type = this.Type;
			_o.IsOptionalTarget = this.IsOptionalTarget;
			_o.TargetCameraDistanceCondition = ((this.TargetCameraDistanceCondition != null) ? this.TargetCameraDistanceCondition.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.TargetPosCondition = ((this.TargetPosCondition != null) ? this.TargetPosCondition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A1C6 RID: 106950 RVA: 0x003B88BC File Offset: 0x003B6ABC
		public static Offset<ITakePhoto2PhotoTargetEntityTarget> Pack(FlatBufferBuilder builder, ITakePhoto2PhotoTargetEntityTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2PhotoTargetEntityTarget>);
			}
			Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset = (_o.TargetCameraDistanceCondition == null) ? default(Offset<ITakePhoto2TargetCameraDistanceCondition>) : ITakePhoto2TargetCameraDistanceCondition.Pack(builder, _o.TargetCameraDistanceCondition);
			Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset = (_o.TargetPosCondition == null) ? default(Offset<ITakePhoto2TargetPosByRangeCondition>) : ITakePhoto2TargetPosByRangeCondition.Pack(builder, _o.TargetPosCondition);
			return ITakePhoto2PhotoTargetEntityTarget.CreateITakePhoto2PhotoTargetEntityTarget(builder, _o.Type, _o.IsOptionalTarget, targetCameraDistanceConditionOffset, _o.EntityId, targetPosConditionOffset, _o.NullMask);
		}

		// Token: 0x0400C7AE RID: 51118
		private Table __p;
	}
}

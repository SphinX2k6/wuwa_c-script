using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004181 RID: 16769
	public struct ITakePhoto2PhotoTargetEntityTarget : IFlatbufferObject
	{
		// Token: 0x170076DB RID: 30427
		// (get) Token: 0x06018A79 RID: 100985 RVA: 0x0038D3A9 File Offset: 0x0038B5A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018A7A RID: 100986 RVA: 0x0038D3B6 File Offset: 0x0038B5B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018A7B RID: 100987 RVA: 0x0038D3C0 File Offset: 0x0038B5C0
		public static ITakePhoto2PhotoTargetEntityTarget GetRootAsITakePhoto2PhotoTargetEntityTarget(ByteBuffer _bb)
		{
			return ITakePhoto2PhotoTargetEntityTarget.GetRootAsITakePhoto2PhotoTargetEntityTarget(_bb, default(ITakePhoto2PhotoTargetEntityTarget));
		}

		// Token: 0x06018A7C RID: 100988 RVA: 0x0038D3DC File Offset: 0x0038B5DC
		public static ITakePhoto2PhotoTargetEntityTarget GetRootAsITakePhoto2PhotoTargetEntityTarget(ByteBuffer _bb, ITakePhoto2PhotoTargetEntityTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018A7D RID: 100989 RVA: 0x0038D3F9 File Offset: 0x0038B5F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018A7E RID: 100990 RVA: 0x0038D408 File Offset: 0x0038B608
		public ITakePhoto2PhotoTargetEntityTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076DC RID: 30428
		// (get) Token: 0x06018A7F RID: 100991 RVA: 0x0038D418 File Offset: 0x0038B618
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

		// Token: 0x170076DD RID: 30429
		// (get) Token: 0x06018A80 RID: 100992 RVA: 0x0038D454 File Offset: 0x0038B654
		public bool IsOptionalTarget
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170076DE RID: 30430
		// (get) Token: 0x06018A81 RID: 100993 RVA: 0x0038D494 File Offset: 0x0038B694
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

		// Token: 0x170076DF RID: 30431
		// (get) Token: 0x06018A82 RID: 100994 RVA: 0x0038D4F4 File Offset: 0x0038B6F4
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

		// Token: 0x170076E0 RID: 30432
		// (get) Token: 0x06018A83 RID: 100995 RVA: 0x0038D534 File Offset: 0x0038B734
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

		// Token: 0x170076E1 RID: 30433
		// (get) Token: 0x06018A84 RID: 100996 RVA: 0x0038D594 File Offset: 0x0038B794
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

		// Token: 0x06018A85 RID: 100997 RVA: 0x0038D5D1 File Offset: 0x0038B7D1
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

		// Token: 0x06018A86 RID: 100998 RVA: 0x0038D60D File Offset: 0x0038B80D
		public static void StartITakePhoto2PhotoTargetEntityTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06018A87 RID: 100999 RVA: 0x0038D616 File Offset: 0x0038B816
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2TargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018A88 RID: 101000 RVA: 0x0038D621 File Offset: 0x0038B821
		public static void AddIsOptionalTarget(FlatBufferBuilder builder, bool isOptionalTarget)
		{
			builder.AddBool(1, isOptionalTarget, false);
		}

		// Token: 0x06018A89 RID: 101001 RVA: 0x0038D62C File Offset: 0x0038B82C
		public static void AddTargetCameraDistanceCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset)
		{
			builder.AddOffset(2, targetCameraDistanceConditionOffset.Value, 0);
		}

		// Token: 0x06018A8A RID: 101002 RVA: 0x0038D63C File Offset: 0x0038B83C
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(3, entityId, 0);
		}

		// Token: 0x06018A8B RID: 101003 RVA: 0x0038D647 File Offset: 0x0038B847
		public static void AddTargetPosCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset)
		{
			builder.AddOffset(4, targetPosConditionOffset.Value, 0);
		}

		// Token: 0x06018A8C RID: 101004 RVA: 0x0038D657 File Offset: 0x0038B857
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06018A8D RID: 101005 RVA: 0x0038D662 File Offset: 0x0038B862
		public static Offset<ITakePhoto2PhotoTargetEntityTarget> EndITakePhoto2PhotoTargetEntityTarget(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2PhotoTargetEntityTarget>(builder.EndTable());
		}

		// Token: 0x06018A8E RID: 101006 RVA: 0x0038D670 File Offset: 0x0038B870
		public ITakePhoto2PhotoTargetEntityTargetT UnPack()
		{
			ITakePhoto2PhotoTargetEntityTargetT takePhoto2PhotoTargetEntityTargetT = new ITakePhoto2PhotoTargetEntityTargetT();
			this.UnPackTo(takePhoto2PhotoTargetEntityTargetT);
			return takePhoto2PhotoTargetEntityTargetT;
		}

		// Token: 0x06018A8F RID: 101007 RVA: 0x0038D68C File Offset: 0x0038B88C
		public void UnPackTo(ITakePhoto2PhotoTargetEntityTargetT _o)
		{
			_o.Type = this.Type;
			_o.IsOptionalTarget = this.IsOptionalTarget;
			_o.TargetCameraDistanceCondition = ((this.TargetCameraDistanceCondition != null) ? this.TargetCameraDistanceCondition.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.TargetPosCondition = ((this.TargetPosCondition != null) ? this.TargetPosCondition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018A90 RID: 101008 RVA: 0x0038D728 File Offset: 0x0038B928
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

		// Token: 0x0400BDAD RID: 48557
		private Table __p;
	}
}

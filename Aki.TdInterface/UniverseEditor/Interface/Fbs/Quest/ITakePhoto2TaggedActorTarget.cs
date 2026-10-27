using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200418A RID: 16778
	public struct ITakePhoto2TaggedActorTarget : IFlatbufferObject
	{
		// Token: 0x170076EE RID: 30446
		// (get) Token: 0x06018AC5 RID: 101061 RVA: 0x0038DC0C File Offset: 0x0038BE0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018AC6 RID: 101062 RVA: 0x0038DC19 File Offset: 0x0038BE19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018AC7 RID: 101063 RVA: 0x0038DC20 File Offset: 0x0038BE20
		public static ITakePhoto2TaggedActorTarget GetRootAsITakePhoto2TaggedActorTarget(ByteBuffer _bb)
		{
			return ITakePhoto2TaggedActorTarget.GetRootAsITakePhoto2TaggedActorTarget(_bb, default(ITakePhoto2TaggedActorTarget));
		}

		// Token: 0x06018AC8 RID: 101064 RVA: 0x0038DC3C File Offset: 0x0038BE3C
		public static ITakePhoto2TaggedActorTarget GetRootAsITakePhoto2TaggedActorTarget(ByteBuffer _bb, ITakePhoto2TaggedActorTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018AC9 RID: 101065 RVA: 0x0038DC59 File Offset: 0x0038BE59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018ACA RID: 101066 RVA: 0x0038DC68 File Offset: 0x0038BE68
		public ITakePhoto2TaggedActorTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076EF RID: 30447
		// (get) Token: 0x06018ACB RID: 101067 RVA: 0x0038DC78 File Offset: 0x0038BE78
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

		// Token: 0x170076F0 RID: 30448
		// (get) Token: 0x06018ACC RID: 101068 RVA: 0x0038DCB4 File Offset: 0x0038BEB4
		public bool IsOptionalTarget
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170076F1 RID: 30449
		// (get) Token: 0x06018ACD RID: 101069 RVA: 0x0038DCF4 File Offset: 0x0038BEF4
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

		// Token: 0x170076F2 RID: 30450
		// (get) Token: 0x06018ACE RID: 101070 RVA: 0x0038DD54 File Offset: 0x0038BF54
		public string Tag
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018ACF RID: 101071 RVA: 0x0038DD8C File Offset: 0x0038BF8C
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06018AD0 RID: 101072 RVA: 0x0038DD9C File Offset: 0x0038BF9C
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x170076F3 RID: 30451
		// (get) Token: 0x06018AD1 RID: 101073 RVA: 0x0038DDAC File Offset: 0x0038BFAC
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

		// Token: 0x170076F4 RID: 30452
		// (get) Token: 0x06018AD2 RID: 101074 RVA: 0x0038DE0C File Offset: 0x0038C00C
		public int TargetSatisfiedCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170076F5 RID: 30453
		// (get) Token: 0x06018AD3 RID: 101075 RVA: 0x0038DE4C File Offset: 0x0038C04C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018AD4 RID: 101076 RVA: 0x0038DE8C File Offset: 0x0038C08C
		public static Offset<ITakePhoto2TaggedActorTarget> CreateITakePhoto2TaggedActorTarget(FlatBufferBuilder builder, ETakePhoto2TargetType Type = ETakePhoto2TargetType.Entity, bool IsOptionalTarget = false, Offset<ITakePhoto2TargetCameraDistanceCondition> TargetCameraDistanceConditionOffset = default(Offset<ITakePhoto2TargetCameraDistanceCondition>), StringOffset TagOffset = default(StringOffset), Offset<ITakePhoto2TargetPosByRangeCondition> TargetPosConditionOffset = default(Offset<ITakePhoto2TargetPosByRangeCondition>), int TargetSatisfiedCount = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			ITakePhoto2TaggedActorTarget.AddTargetSatisfiedCount(builder, TargetSatisfiedCount);
			ITakePhoto2TaggedActorTarget.AddTargetPosCondition(builder, TargetPosConditionOffset);
			ITakePhoto2TaggedActorTarget.AddTag(builder, TagOffset);
			ITakePhoto2TaggedActorTarget.AddTargetCameraDistanceCondition(builder, TargetCameraDistanceConditionOffset);
			ITakePhoto2TaggedActorTarget.AddNullMask(builder, NullMask);
			ITakePhoto2TaggedActorTarget.AddIsOptionalTarget(builder, IsOptionalTarget);
			ITakePhoto2TaggedActorTarget.AddType(builder, Type);
			return ITakePhoto2TaggedActorTarget.EndITakePhoto2TaggedActorTarget(builder);
		}

		// Token: 0x06018AD5 RID: 101077 RVA: 0x0038DEDB File Offset: 0x0038C0DB
		public static void StartITakePhoto2TaggedActorTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06018AD6 RID: 101078 RVA: 0x0038DEE4 File Offset: 0x0038C0E4
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2TargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018AD7 RID: 101079 RVA: 0x0038DEEF File Offset: 0x0038C0EF
		public static void AddIsOptionalTarget(FlatBufferBuilder builder, bool isOptionalTarget)
		{
			builder.AddBool(1, isOptionalTarget, false);
		}

		// Token: 0x06018AD8 RID: 101080 RVA: 0x0038DEFA File Offset: 0x0038C0FA
		public static void AddTargetCameraDistanceCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset)
		{
			builder.AddOffset(2, targetCameraDistanceConditionOffset.Value, 0);
		}

		// Token: 0x06018AD9 RID: 101081 RVA: 0x0038DF0A File Offset: 0x0038C10A
		public static void AddTag(FlatBufferBuilder builder, StringOffset tagOffset)
		{
			builder.AddOffset(3, tagOffset.Value, 0);
		}

		// Token: 0x06018ADA RID: 101082 RVA: 0x0038DF1A File Offset: 0x0038C11A
		public static void AddTargetPosCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset)
		{
			builder.AddOffset(4, targetPosConditionOffset.Value, 0);
		}

		// Token: 0x06018ADB RID: 101083 RVA: 0x0038DF2A File Offset: 0x0038C12A
		public static void AddTargetSatisfiedCount(FlatBufferBuilder builder, int targetSatisfiedCount)
		{
			builder.AddInt(5, targetSatisfiedCount, 0);
		}

		// Token: 0x06018ADC RID: 101084 RVA: 0x0038DF35 File Offset: 0x0038C135
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06018ADD RID: 101085 RVA: 0x0038DF40 File Offset: 0x0038C140
		public static Offset<ITakePhoto2TaggedActorTarget> EndITakePhoto2TaggedActorTarget(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TaggedActorTarget>(builder.EndTable());
		}

		// Token: 0x06018ADE RID: 101086 RVA: 0x0038DF50 File Offset: 0x0038C150
		public ITakePhoto2TaggedActorTargetT UnPack()
		{
			ITakePhoto2TaggedActorTargetT takePhoto2TaggedActorTargetT = new ITakePhoto2TaggedActorTargetT();
			this.UnPackTo(takePhoto2TaggedActorTargetT);
			return takePhoto2TaggedActorTargetT;
		}

		// Token: 0x06018ADF RID: 101087 RVA: 0x0038DF6C File Offset: 0x0038C16C
		public void UnPackTo(ITakePhoto2TaggedActorTargetT _o)
		{
			_o.Type = this.Type;
			_o.IsOptionalTarget = this.IsOptionalTarget;
			_o.TargetCameraDistanceCondition = ((this.TargetCameraDistanceCondition != null) ? this.TargetCameraDistanceCondition.Value.UnPack() : null);
			_o.Tag = this.Tag;
			_o.TargetPosCondition = ((this.TargetPosCondition != null) ? this.TargetPosCondition.Value.UnPack() : null);
			_o.TargetSatisfiedCount = this.TargetSatisfiedCount;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018AE0 RID: 101088 RVA: 0x0038E014 File Offset: 0x0038C214
		public static Offset<ITakePhoto2TaggedActorTarget> Pack(FlatBufferBuilder builder, ITakePhoto2TaggedActorTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2TaggedActorTarget>);
			}
			Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset = (_o.TargetCameraDistanceCondition == null) ? default(Offset<ITakePhoto2TargetCameraDistanceCondition>) : ITakePhoto2TargetCameraDistanceCondition.Pack(builder, _o.TargetCameraDistanceCondition);
			StringOffset tagOffset = (_o.Tag == null) ? default(StringOffset) : builder.CreateString(_o.Tag);
			Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset = (_o.TargetPosCondition == null) ? default(Offset<ITakePhoto2TargetPosByRangeCondition>) : ITakePhoto2TargetPosByRangeCondition.Pack(builder, _o.TargetPosCondition);
			return ITakePhoto2TaggedActorTarget.CreateITakePhoto2TaggedActorTarget(builder, _o.Type, _o.IsOptionalTarget, targetCameraDistanceConditionOffset, tagOffset, targetPosConditionOffset, _o.TargetSatisfiedCount, _o.NullMask);
		}

		// Token: 0x0400BDB8 RID: 48568
		private Table __p;
	}
}

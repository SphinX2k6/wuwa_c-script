using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200418D RID: 16781
	public struct ITakePhoto2Target : IFlatbufferObject
	{
		// Token: 0x170076FD RID: 30461
		// (get) Token: 0x06018AF1 RID: 101105 RVA: 0x0038E223 File Offset: 0x0038C423
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018AF2 RID: 101106 RVA: 0x0038E230 File Offset: 0x0038C430
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018AF3 RID: 101107 RVA: 0x0038E238 File Offset: 0x0038C438
		public static ITakePhoto2Target GetRootAsITakePhoto2Target(ByteBuffer _bb)
		{
			return ITakePhoto2Target.GetRootAsITakePhoto2Target(_bb, default(ITakePhoto2Target));
		}

		// Token: 0x06018AF4 RID: 101108 RVA: 0x0038E254 File Offset: 0x0038C454
		public static ITakePhoto2Target GetRootAsITakePhoto2Target(ByteBuffer _bb, ITakePhoto2Target obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018AF5 RID: 101109 RVA: 0x0038E271 File Offset: 0x0038C471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018AF6 RID: 101110 RVA: 0x0038E280 File Offset: 0x0038C480
		public ITakePhoto2Target __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076FE RID: 30462
		// (get) Token: 0x06018AF7 RID: 101111 RVA: 0x0038E290 File Offset: 0x0038C490
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

		// Token: 0x170076FF RID: 30463
		// (get) Token: 0x06018AF8 RID: 101112 RVA: 0x0038E2CC File Offset: 0x0038C4CC
		public bool IsOptionalTarget
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007700 RID: 30464
		// (get) Token: 0x06018AF9 RID: 101113 RVA: 0x0038E30C File Offset: 0x0038C50C
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

		// Token: 0x17007701 RID: 30465
		// (get) Token: 0x06018AFA RID: 101114 RVA: 0x0038E36C File Offset: 0x0038C56C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018AFB RID: 101115 RVA: 0x0038E3A9 File Offset: 0x0038C5A9
		public static Offset<ITakePhoto2Target> CreateITakePhoto2Target(FlatBufferBuilder builder, ETakePhoto2TargetType Type = ETakePhoto2TargetType.Entity, bool IsOptionalTarget = false, Offset<ITakePhoto2TargetCameraDistanceCondition> TargetCameraDistanceConditionOffset = default(Offset<ITakePhoto2TargetCameraDistanceCondition>), byte NullMask = 0)
		{
			builder.StartTable(4);
			ITakePhoto2Target.AddTargetCameraDistanceCondition(builder, TargetCameraDistanceConditionOffset);
			ITakePhoto2Target.AddNullMask(builder, NullMask);
			ITakePhoto2Target.AddIsOptionalTarget(builder, IsOptionalTarget);
			ITakePhoto2Target.AddType(builder, Type);
			return ITakePhoto2Target.EndITakePhoto2Target(builder);
		}

		// Token: 0x06018AFC RID: 101116 RVA: 0x0038E3D5 File Offset: 0x0038C5D5
		public static void StartITakePhoto2Target(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06018AFD RID: 101117 RVA: 0x0038E3DE File Offset: 0x0038C5DE
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2TargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018AFE RID: 101118 RVA: 0x0038E3E9 File Offset: 0x0038C5E9
		public static void AddIsOptionalTarget(FlatBufferBuilder builder, bool isOptionalTarget)
		{
			builder.AddBool(1, isOptionalTarget, false);
		}

		// Token: 0x06018AFF RID: 101119 RVA: 0x0038E3F4 File Offset: 0x0038C5F4
		public static void AddTargetCameraDistanceCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset)
		{
			builder.AddOffset(2, targetCameraDistanceConditionOffset.Value, 0);
		}

		// Token: 0x06018B00 RID: 101120 RVA: 0x0038E404 File Offset: 0x0038C604
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06018B01 RID: 101121 RVA: 0x0038E40F File Offset: 0x0038C60F
		public static Offset<ITakePhoto2Target> EndITakePhoto2Target(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2Target>(builder.EndTable());
		}

		// Token: 0x06018B02 RID: 101122 RVA: 0x0038E41C File Offset: 0x0038C61C
		public ITakePhoto2TargetT UnPack()
		{
			ITakePhoto2TargetT takePhoto2TargetT = new ITakePhoto2TargetT();
			this.UnPackTo(takePhoto2TargetT);
			return takePhoto2TargetT;
		}

		// Token: 0x06018B03 RID: 101123 RVA: 0x0038E438 File Offset: 0x0038C638
		public void UnPackTo(ITakePhoto2TargetT _o)
		{
			_o.Type = this.Type;
			_o.IsOptionalTarget = this.IsOptionalTarget;
			_o.TargetCameraDistanceCondition = ((this.TargetCameraDistanceCondition != null) ? this.TargetCameraDistanceCondition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018B04 RID: 101124 RVA: 0x0038E498 File Offset: 0x0038C698
		public static Offset<ITakePhoto2Target> Pack(FlatBufferBuilder builder, ITakePhoto2TargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2Target>);
			}
			Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset = (_o.TargetCameraDistanceCondition == null) ? default(Offset<ITakePhoto2TargetCameraDistanceCondition>) : ITakePhoto2TargetCameraDistanceCondition.Pack(builder, _o.TargetCameraDistanceCondition);
			return ITakePhoto2Target.CreateITakePhoto2Target(builder, _o.Type, _o.IsOptionalTarget, targetCameraDistanceConditionOffset, _o.NullMask);
		}

		// Token: 0x0400BDC0 RID: 48576
		private Table __p;
	}
}

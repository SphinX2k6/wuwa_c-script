using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E01 RID: 28161
	public struct IRacingTrackMove : IFlatbufferObject
	{
		// Token: 0x1700D1E3 RID: 53731
		// (get) Token: 0x06031BF1 RID: 203761 RVA: 0x006BC30A File Offset: 0x006BA50A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031BF2 RID: 203762 RVA: 0x006BC317 File Offset: 0x006BA517
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031BF3 RID: 203763 RVA: 0x006BC320 File Offset: 0x006BA520
		public static IRacingTrackMove GetRootAsIRacingTrackMove(ByteBuffer _bb)
		{
			return IRacingTrackMove.GetRootAsIRacingTrackMove(_bb, default(IRacingTrackMove));
		}

		// Token: 0x06031BF4 RID: 203764 RVA: 0x006BC33C File Offset: 0x006BA53C
		public static IRacingTrackMove GetRootAsIRacingTrackMove(ByteBuffer _bb, IRacingTrackMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031BF5 RID: 203765 RVA: 0x006BC359 File Offset: 0x006BA559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031BF6 RID: 203766 RVA: 0x006BC368 File Offset: 0x006BA568
		public IRacingTrackMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1E4 RID: 53732
		// (get) Token: 0x06031BF7 RID: 203767 RVA: 0x006BC378 File Offset: 0x006BA578
		public ESplineMovePattern Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMovePattern.PathLine;
				}
				return (ESplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D1E5 RID: 53733
		// (get) Token: 0x06031BF8 RID: 203768 RVA: 0x006BC3B4 File Offset: 0x006BA5B4
		public float MaxOffsetDistance
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D1E6 RID: 53734
		// (get) Token: 0x06031BF9 RID: 203769 RVA: 0x006BC3F4 File Offset: 0x006BA5F4
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D1E7 RID: 53735
		// (get) Token: 0x06031BFA RID: 203770 RVA: 0x006BC434 File Offset: 0x006BA634
		public float LayerVerticalLimit
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D1E8 RID: 53736
		// (get) Token: 0x06031BFB RID: 203771 RVA: 0x006BC478 File Offset: 0x006BA678
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D1E9 RID: 53737
		// (get) Token: 0x06031BFC RID: 203772 RVA: 0x006BC4B8 File Offset: 0x006BA6B8
		public float GravitySwitchAngularVelocity
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D1EA RID: 53738
		// (get) Token: 0x06031BFD RID: 203773 RVA: 0x006BC4FC File Offset: 0x006BA6FC
		public int AutoExitDistance
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D1EB RID: 53739
		// (get) Token: 0x06031BFE RID: 203774 RVA: 0x006BC53C File Offset: 0x006BA73C
		public float DirectionAngleLimit
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D1EC RID: 53740
		// (get) Token: 0x06031BFF RID: 203775 RVA: 0x006BC580 File Offset: 0x006BA780
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

		// Token: 0x06031C00 RID: 203776 RVA: 0x006BC5C0 File Offset: 0x006BA7C0
		public static Offset<IRacingTrackMove> CreateIRacingTrackMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float MaxOffsetDistance = 0f, bool IsOneWay = false, float LayerVerticalLimit = 0f, bool DynamicGravity = false, float GravitySwitchAngularVelocity = 0f, int AutoExitDistance = 0, float DirectionAngleLimit = 0f, byte NullMask = 0)
		{
			builder.StartTable(9);
			IRacingTrackMove.AddDirectionAngleLimit(builder, DirectionAngleLimit);
			IRacingTrackMove.AddAutoExitDistance(builder, AutoExitDistance);
			IRacingTrackMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			IRacingTrackMove.AddLayerVerticalLimit(builder, LayerVerticalLimit);
			IRacingTrackMove.AddMaxOffsetDistance(builder, MaxOffsetDistance);
			IRacingTrackMove.AddNullMask(builder, NullMask);
			IRacingTrackMove.AddDynamicGravity(builder, DynamicGravity);
			IRacingTrackMove.AddIsOneWay(builder, IsOneWay);
			IRacingTrackMove.AddType(builder, Type);
			return IRacingTrackMove.EndIRacingTrackMove(builder);
		}

		// Token: 0x06031C01 RID: 203777 RVA: 0x006BC620 File Offset: 0x006BA820
		public static void StartIRacingTrackMove(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06031C02 RID: 203778 RVA: 0x006BC62A File Offset: 0x006BA82A
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031C03 RID: 203779 RVA: 0x006BC635 File Offset: 0x006BA835
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x06031C04 RID: 203780 RVA: 0x006BC648 File Offset: 0x006BA848
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x06031C05 RID: 203781 RVA: 0x006BC653 File Offset: 0x006BA853
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x06031C06 RID: 203782 RVA: 0x006BC666 File Offset: 0x006BA866
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x06031C07 RID: 203783 RVA: 0x006BC671 File Offset: 0x006BA871
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x06031C08 RID: 203784 RVA: 0x006BC684 File Offset: 0x006BA884
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x06031C09 RID: 203785 RVA: 0x006BC68F File Offset: 0x006BA88F
		public static void AddDirectionAngleLimit(FlatBufferBuilder builder, float directionAngleLimit)
		{
			builder.AddFloat(7, directionAngleLimit, 0.0);
		}

		// Token: 0x06031C0A RID: 203786 RVA: 0x006BC6A2 File Offset: 0x006BA8A2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06031C0B RID: 203787 RVA: 0x006BC6AD File Offset: 0x006BA8AD
		public static Offset<IRacingTrackMove> EndIRacingTrackMove(FlatBufferBuilder builder)
		{
			return new Offset<IRacingTrackMove>(builder.EndTable());
		}

		// Token: 0x06031C0C RID: 203788 RVA: 0x006BC6BC File Offset: 0x006BA8BC
		public IRacingTrackMoveT UnPack()
		{
			IRacingTrackMoveT racingTrackMoveT = new IRacingTrackMoveT();
			this.UnPackTo(racingTrackMoveT);
			return racingTrackMoveT;
		}

		// Token: 0x06031C0D RID: 203789 RVA: 0x006BC6D8 File Offset: 0x006BA8D8
		public void UnPackTo(IRacingTrackMoveT _o)
		{
			_o.Type = this.Type;
			_o.MaxOffsetDistance = this.MaxOffsetDistance;
			_o.IsOneWay = this.IsOneWay;
			_o.LayerVerticalLimit = this.LayerVerticalLimit;
			_o.DynamicGravity = this.DynamicGravity;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.AutoExitDistance = this.AutoExitDistance;
			_o.DirectionAngleLimit = this.DirectionAngleLimit;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031C0E RID: 203790 RVA: 0x006BC754 File Offset: 0x006BA954
		public static Offset<IRacingTrackMove> Pack(FlatBufferBuilder builder, IRacingTrackMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRacingTrackMove>);
			}
			return IRacingTrackMove.CreateIRacingTrackMove(builder, _o.Type, _o.MaxOffsetDistance, _o.IsOneWay, _o.LayerVerticalLimit, _o.DynamicGravity, _o.GravitySwitchAngularVelocity, _o.AutoExitDistance, _o.DirectionAngleLimit, _o.NullMask);
		}

		// Token: 0x040117E0 RID: 71648
		private Table __p;
	}
}

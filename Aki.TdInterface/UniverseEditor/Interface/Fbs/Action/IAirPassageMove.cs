using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200617C RID: 24956
	public struct IAirPassageMove : IFlatbufferObject
	{
		// Token: 0x1700BA0C RID: 47628
		// (get) Token: 0x0602AFB6 RID: 176054 RVA: 0x005EE25E File Offset: 0x005EC45E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AFB7 RID: 176055 RVA: 0x005EE26B File Offset: 0x005EC46B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AFB8 RID: 176056 RVA: 0x005EE274 File Offset: 0x005EC474
		public static IAirPassageMove GetRootAsIAirPassageMove(ByteBuffer _bb)
		{
			return IAirPassageMove.GetRootAsIAirPassageMove(_bb, default(IAirPassageMove));
		}

		// Token: 0x0602AFB9 RID: 176057 RVA: 0x005EE290 File Offset: 0x005EC490
		public static IAirPassageMove GetRootAsIAirPassageMove(ByteBuffer _bb, IAirPassageMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AFBA RID: 176058 RVA: 0x005EE2AD File Offset: 0x005EC4AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AFBB RID: 176059 RVA: 0x005EE2BC File Offset: 0x005EC4BC
		public IAirPassageMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA0D RID: 47629
		// (get) Token: 0x0602AFBC RID: 176060 RVA: 0x005EE2CC File Offset: 0x005EC4CC
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

		// Token: 0x1700BA0E RID: 47630
		// (get) Token: 0x0602AFBD RID: 176061 RVA: 0x005EE308 File Offset: 0x005EC508
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

		// Token: 0x1700BA0F RID: 47631
		// (get) Token: 0x0602AFBE RID: 176062 RVA: 0x005EE348 File Offset: 0x005EC548
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BA10 RID: 47632
		// (get) Token: 0x0602AFBF RID: 176063 RVA: 0x005EE388 File Offset: 0x005EC588
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

		// Token: 0x1700BA11 RID: 47633
		// (get) Token: 0x0602AFC0 RID: 176064 RVA: 0x005EE3CC File Offset: 0x005EC5CC
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BA12 RID: 47634
		// (get) Token: 0x0602AFC1 RID: 176065 RVA: 0x005EE40C File Offset: 0x005EC60C
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

		// Token: 0x1700BA13 RID: 47635
		// (get) Token: 0x0602AFC2 RID: 176066 RVA: 0x005EE450 File Offset: 0x005EC650
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

		// Token: 0x1700BA14 RID: 47636
		// (get) Token: 0x0602AFC3 RID: 176067 RVA: 0x005EE490 File Offset: 0x005EC690
		public IAirPassageMoveLimit? Limit
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IAirPassageMoveLimit?(default(IAirPassageMoveLimit).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BA15 RID: 47637
		// (get) Token: 0x0602AFC4 RID: 176068 RVA: 0x005EE4F0 File Offset: 0x005EC6F0
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

		// Token: 0x0602AFC5 RID: 176069 RVA: 0x005EE530 File Offset: 0x005EC730
		public static Offset<IAirPassageMove> CreateIAirPassageMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float MaxOffsetDistance = 0f, bool IsOneWay = false, float LayerVerticalLimit = 0f, bool DynamicGravity = false, float GravitySwitchAngularVelocity = 0f, int AutoExitDistance = 0, Offset<IAirPassageMoveLimit> LimitOffset = default(Offset<IAirPassageMoveLimit>), byte NullMask = 0)
		{
			builder.StartTable(9);
			IAirPassageMove.AddLimit(builder, LimitOffset);
			IAirPassageMove.AddAutoExitDistance(builder, AutoExitDistance);
			IAirPassageMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			IAirPassageMove.AddLayerVerticalLimit(builder, LayerVerticalLimit);
			IAirPassageMove.AddMaxOffsetDistance(builder, MaxOffsetDistance);
			IAirPassageMove.AddNullMask(builder, NullMask);
			IAirPassageMove.AddDynamicGravity(builder, DynamicGravity);
			IAirPassageMove.AddIsOneWay(builder, IsOneWay);
			IAirPassageMove.AddType(builder, Type);
			return IAirPassageMove.EndIAirPassageMove(builder);
		}

		// Token: 0x0602AFC6 RID: 176070 RVA: 0x005EE590 File Offset: 0x005EC790
		public static void StartIAirPassageMove(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602AFC7 RID: 176071 RVA: 0x005EE59A File Offset: 0x005EC79A
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AFC8 RID: 176072 RVA: 0x005EE5A5 File Offset: 0x005EC7A5
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x0602AFC9 RID: 176073 RVA: 0x005EE5B8 File Offset: 0x005EC7B8
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x0602AFCA RID: 176074 RVA: 0x005EE5C3 File Offset: 0x005EC7C3
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x0602AFCB RID: 176075 RVA: 0x005EE5D6 File Offset: 0x005EC7D6
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x0602AFCC RID: 176076 RVA: 0x005EE5E1 File Offset: 0x005EC7E1
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602AFCD RID: 176077 RVA: 0x005EE5F4 File Offset: 0x005EC7F4
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x0602AFCE RID: 176078 RVA: 0x005EE5FF File Offset: 0x005EC7FF
		public static void AddLimit(FlatBufferBuilder builder, Offset<IAirPassageMoveLimit> limitOffset)
		{
			builder.AddOffset(7, limitOffset.Value, 0);
		}

		// Token: 0x0602AFCF RID: 176079 RVA: 0x005EE60F File Offset: 0x005EC80F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602AFD0 RID: 176080 RVA: 0x005EE61A File Offset: 0x005EC81A
		public static Offset<IAirPassageMove> EndIAirPassageMove(FlatBufferBuilder builder)
		{
			return new Offset<IAirPassageMove>(builder.EndTable());
		}

		// Token: 0x0602AFD1 RID: 176081 RVA: 0x005EE628 File Offset: 0x005EC828
		public IAirPassageMoveT UnPack()
		{
			IAirPassageMoveT airPassageMoveT = new IAirPassageMoveT();
			this.UnPackTo(airPassageMoveT);
			return airPassageMoveT;
		}

		// Token: 0x0602AFD2 RID: 176082 RVA: 0x005EE644 File Offset: 0x005EC844
		public void UnPackTo(IAirPassageMoveT _o)
		{
			_o.Type = this.Type;
			_o.MaxOffsetDistance = this.MaxOffsetDistance;
			_o.IsOneWay = this.IsOneWay;
			_o.LayerVerticalLimit = this.LayerVerticalLimit;
			_o.DynamicGravity = this.DynamicGravity;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.AutoExitDistance = this.AutoExitDistance;
			_o.Limit = ((this.Limit != null) ? this.Limit.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602AFD3 RID: 176083 RVA: 0x005EE6E0 File Offset: 0x005EC8E0
		public static Offset<IAirPassageMove> Pack(FlatBufferBuilder builder, IAirPassageMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirPassageMove>);
			}
			Offset<IAirPassageMoveLimit> limitOffset = (_o.Limit == null) ? default(Offset<IAirPassageMoveLimit>) : IAirPassageMoveLimit.Pack(builder, _o.Limit);
			return IAirPassageMove.CreateIAirPassageMove(builder, _o.Type, _o.MaxOffsetDistance, _o.IsOneWay, _o.LayerVerticalLimit, _o.DynamicGravity, _o.GravitySwitchAngularVelocity, _o.AutoExitDistance, limitOffset, _o.NullMask);
		}

		// Token: 0x04010679 RID: 67193
		private Table __p;
	}
}

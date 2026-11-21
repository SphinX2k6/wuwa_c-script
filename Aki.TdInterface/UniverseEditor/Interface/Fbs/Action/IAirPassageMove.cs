using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E7 RID: 26599
	public struct IAirPassageMove : IFlatbufferObject
	{
		// Token: 0x1700C38A RID: 50058
		// (get) Token: 0x0602D6E7 RID: 186087 RVA: 0x00638AD2 File Offset: 0x00636CD2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D6E8 RID: 186088 RVA: 0x00638ADF File Offset: 0x00636CDF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D6E9 RID: 186089 RVA: 0x00638AE8 File Offset: 0x00636CE8
		public static IAirPassageMove GetRootAsIAirPassageMove(ByteBuffer _bb)
		{
			return IAirPassageMove.GetRootAsIAirPassageMove(_bb, default(IAirPassageMove));
		}

		// Token: 0x0602D6EA RID: 186090 RVA: 0x00638B04 File Offset: 0x00636D04
		public static IAirPassageMove GetRootAsIAirPassageMove(ByteBuffer _bb, IAirPassageMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D6EB RID: 186091 RVA: 0x00638B21 File Offset: 0x00636D21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D6EC RID: 186092 RVA: 0x00638B30 File Offset: 0x00636D30
		public IAirPassageMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C38B RID: 50059
		// (get) Token: 0x0602D6ED RID: 186093 RVA: 0x00638B40 File Offset: 0x00636D40
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

		// Token: 0x1700C38C RID: 50060
		// (get) Token: 0x0602D6EE RID: 186094 RVA: 0x00638B7C File Offset: 0x00636D7C
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

		// Token: 0x1700C38D RID: 50061
		// (get) Token: 0x0602D6EF RID: 186095 RVA: 0x00638BBC File Offset: 0x00636DBC
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C38E RID: 50062
		// (get) Token: 0x0602D6F0 RID: 186096 RVA: 0x00638BFC File Offset: 0x00636DFC
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

		// Token: 0x1700C38F RID: 50063
		// (get) Token: 0x0602D6F1 RID: 186097 RVA: 0x00638C40 File Offset: 0x00636E40
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C390 RID: 50064
		// (get) Token: 0x0602D6F2 RID: 186098 RVA: 0x00638C80 File Offset: 0x00636E80
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

		// Token: 0x1700C391 RID: 50065
		// (get) Token: 0x0602D6F3 RID: 186099 RVA: 0x00638CC4 File Offset: 0x00636EC4
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

		// Token: 0x1700C392 RID: 50066
		// (get) Token: 0x0602D6F4 RID: 186100 RVA: 0x00638D04 File Offset: 0x00636F04
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

		// Token: 0x1700C393 RID: 50067
		// (get) Token: 0x0602D6F5 RID: 186101 RVA: 0x00638D64 File Offset: 0x00636F64
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

		// Token: 0x0602D6F6 RID: 186102 RVA: 0x00638DA4 File Offset: 0x00636FA4
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

		// Token: 0x0602D6F7 RID: 186103 RVA: 0x00638E04 File Offset: 0x00637004
		public static void StartIAirPassageMove(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602D6F8 RID: 186104 RVA: 0x00638E0E File Offset: 0x0063700E
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D6F9 RID: 186105 RVA: 0x00638E19 File Offset: 0x00637019
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x0602D6FA RID: 186106 RVA: 0x00638E2C File Offset: 0x0063702C
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x0602D6FB RID: 186107 RVA: 0x00638E37 File Offset: 0x00637037
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x0602D6FC RID: 186108 RVA: 0x00638E4A File Offset: 0x0063704A
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x0602D6FD RID: 186109 RVA: 0x00638E55 File Offset: 0x00637055
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602D6FE RID: 186110 RVA: 0x00638E68 File Offset: 0x00637068
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x0602D6FF RID: 186111 RVA: 0x00638E73 File Offset: 0x00637073
		public static void AddLimit(FlatBufferBuilder builder, Offset<IAirPassageMoveLimit> limitOffset)
		{
			builder.AddOffset(7, limitOffset.Value, 0);
		}

		// Token: 0x0602D700 RID: 186112 RVA: 0x00638E83 File Offset: 0x00637083
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602D701 RID: 186113 RVA: 0x00638E8E File Offset: 0x0063708E
		public static Offset<IAirPassageMove> EndIAirPassageMove(FlatBufferBuilder builder)
		{
			return new Offset<IAirPassageMove>(builder.EndTable());
		}

		// Token: 0x0602D702 RID: 186114 RVA: 0x00638E9C File Offset: 0x0063709C
		public IAirPassageMoveT UnPack()
		{
			IAirPassageMoveT airPassageMoveT = new IAirPassageMoveT();
			this.UnPackTo(airPassageMoveT);
			return airPassageMoveT;
		}

		// Token: 0x0602D703 RID: 186115 RVA: 0x00638EB8 File Offset: 0x006370B8
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

		// Token: 0x0602D704 RID: 186116 RVA: 0x00638F54 File Offset: 0x00637154
		public static Offset<IAirPassageMove> Pack(FlatBufferBuilder builder, IAirPassageMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirPassageMove>);
			}
			Offset<IAirPassageMoveLimit> limitOffset = (_o.Limit == null) ? default(Offset<IAirPassageMoveLimit>) : IAirPassageMoveLimit.Pack(builder, _o.Limit);
			return IAirPassageMove.CreateIAirPassageMove(builder, _o.Type, _o.MaxOffsetDistance, _o.IsOneWay, _o.LayerVerticalLimit, _o.DynamicGravity, _o.GravitySwitchAngularVelocity, _o.AutoExitDistance, limitOffset, _o.NullMask);
		}

		// Token: 0x04011488 RID: 70792
		private Table __p;
	}
}

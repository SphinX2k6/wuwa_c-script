using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200757C RID: 30076
	public struct IRacingTrackMove : IFlatbufferObject
	{
		// Token: 0x1700DD2B RID: 56619
		// (get) Token: 0x06034BED RID: 216045 RVA: 0x007179F2 File Offset: 0x00715BF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034BEE RID: 216046 RVA: 0x007179FF File Offset: 0x00715BFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034BEF RID: 216047 RVA: 0x00717A08 File Offset: 0x00715C08
		public static IRacingTrackMove GetRootAsIRacingTrackMove(ByteBuffer _bb)
		{
			return IRacingTrackMove.GetRootAsIRacingTrackMove(_bb, default(IRacingTrackMove));
		}

		// Token: 0x06034BF0 RID: 216048 RVA: 0x00717A24 File Offset: 0x00715C24
		public static IRacingTrackMove GetRootAsIRacingTrackMove(ByteBuffer _bb, IRacingTrackMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034BF1 RID: 216049 RVA: 0x00717A41 File Offset: 0x00715C41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034BF2 RID: 216050 RVA: 0x00717A50 File Offset: 0x00715C50
		public IRacingTrackMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD2C RID: 56620
		// (get) Token: 0x06034BF3 RID: 216051 RVA: 0x00717A60 File Offset: 0x00715C60
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

		// Token: 0x1700DD2D RID: 56621
		// (get) Token: 0x06034BF4 RID: 216052 RVA: 0x00717A9C File Offset: 0x00715C9C
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

		// Token: 0x1700DD2E RID: 56622
		// (get) Token: 0x06034BF5 RID: 216053 RVA: 0x00717ADC File Offset: 0x00715CDC
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DD2F RID: 56623
		// (get) Token: 0x06034BF6 RID: 216054 RVA: 0x00717B1C File Offset: 0x00715D1C
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

		// Token: 0x1700DD30 RID: 56624
		// (get) Token: 0x06034BF7 RID: 216055 RVA: 0x00717B60 File Offset: 0x00715D60
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DD31 RID: 56625
		// (get) Token: 0x06034BF8 RID: 216056 RVA: 0x00717BA0 File Offset: 0x00715DA0
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

		// Token: 0x1700DD32 RID: 56626
		// (get) Token: 0x06034BF9 RID: 216057 RVA: 0x00717BE4 File Offset: 0x00715DE4
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

		// Token: 0x1700DD33 RID: 56627
		// (get) Token: 0x06034BFA RID: 216058 RVA: 0x00717C24 File Offset: 0x00715E24
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

		// Token: 0x1700DD34 RID: 56628
		// (get) Token: 0x06034BFB RID: 216059 RVA: 0x00717C68 File Offset: 0x00715E68
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

		// Token: 0x06034BFC RID: 216060 RVA: 0x00717CA8 File Offset: 0x00715EA8
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

		// Token: 0x06034BFD RID: 216061 RVA: 0x00717D08 File Offset: 0x00715F08
		public static void StartIRacingTrackMove(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06034BFE RID: 216062 RVA: 0x00717D12 File Offset: 0x00715F12
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034BFF RID: 216063 RVA: 0x00717D1D File Offset: 0x00715F1D
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x06034C00 RID: 216064 RVA: 0x00717D30 File Offset: 0x00715F30
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x06034C01 RID: 216065 RVA: 0x00717D3B File Offset: 0x00715F3B
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x06034C02 RID: 216066 RVA: 0x00717D4E File Offset: 0x00715F4E
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x06034C03 RID: 216067 RVA: 0x00717D59 File Offset: 0x00715F59
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x06034C04 RID: 216068 RVA: 0x00717D6C File Offset: 0x00715F6C
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x06034C05 RID: 216069 RVA: 0x00717D77 File Offset: 0x00715F77
		public static void AddDirectionAngleLimit(FlatBufferBuilder builder, float directionAngleLimit)
		{
			builder.AddFloat(7, directionAngleLimit, 0.0);
		}

		// Token: 0x06034C06 RID: 216070 RVA: 0x00717D8A File Offset: 0x00715F8A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06034C07 RID: 216071 RVA: 0x00717D95 File Offset: 0x00715F95
		public static Offset<IRacingTrackMove> EndIRacingTrackMove(FlatBufferBuilder builder)
		{
			return new Offset<IRacingTrackMove>(builder.EndTable());
		}

		// Token: 0x06034C08 RID: 216072 RVA: 0x00717DA4 File Offset: 0x00715FA4
		public IRacingTrackMoveT UnPack()
		{
			IRacingTrackMoveT racingTrackMoveT = new IRacingTrackMoveT();
			this.UnPackTo(racingTrackMoveT);
			return racingTrackMoveT;
		}

		// Token: 0x06034C09 RID: 216073 RVA: 0x00717DC0 File Offset: 0x00715FC0
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

		// Token: 0x06034C0A RID: 216074 RVA: 0x00717E3C File Offset: 0x0071603C
		public static Offset<IRacingTrackMove> Pack(FlatBufferBuilder builder, IRacingTrackMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRacingTrackMove>);
			}
			return IRacingTrackMove.CreateIRacingTrackMove(builder, _o.Type, _o.MaxOffsetDistance, _o.IsOneWay, _o.LayerVerticalLimit, _o.DynamicGravity, _o.GravitySwitchAngularVelocity, _o.AutoExitDistance, _o.DirectionAngleLimit, _o.NullMask);
		}

		// Token: 0x0401275C RID: 75612
		private Table __p;
	}
}

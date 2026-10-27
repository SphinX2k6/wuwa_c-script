using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200617F RID: 24959
	public struct IAirPassageMoveLimit : IFlatbufferObject
	{
		// Token: 0x1700BA1F RID: 47647
		// (get) Token: 0x0602AFE8 RID: 176104 RVA: 0x005EE918 File Offset: 0x005ECB18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AFE9 RID: 176105 RVA: 0x005EE925 File Offset: 0x005ECB25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AFEA RID: 176106 RVA: 0x005EE92C File Offset: 0x005ECB2C
		public static IAirPassageMoveLimit GetRootAsIAirPassageMoveLimit(ByteBuffer _bb)
		{
			return IAirPassageMoveLimit.GetRootAsIAirPassageMoveLimit(_bb, default(IAirPassageMoveLimit));
		}

		// Token: 0x0602AFEB RID: 176107 RVA: 0x005EE948 File Offset: 0x005ECB48
		public static IAirPassageMoveLimit GetRootAsIAirPassageMoveLimit(ByteBuffer _bb, IAirPassageMoveLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AFEC RID: 176108 RVA: 0x005EE965 File Offset: 0x005ECB65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AFED RID: 176109 RVA: 0x005EE974 File Offset: 0x005ECB74
		public IAirPassageMoveLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA20 RID: 47648
		// (get) Token: 0x0602AFEE RID: 176110 RVA: 0x005EE984 File Offset: 0x005ECB84
		public float DirectionAngleLimit
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA21 RID: 47649
		// (get) Token: 0x0602AFEF RID: 176111 RVA: 0x005EE9C4 File Offset: 0x005ECBC4
		public float EdgeLimitCurveFactor
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

		// Token: 0x0602AFF0 RID: 176112 RVA: 0x005EEA04 File Offset: 0x005ECC04
		public static Offset<IAirPassageMoveLimit> CreateIAirPassageMoveLimit(FlatBufferBuilder builder, float DirectionAngleLimit = 0f, float EdgeLimitCurveFactor = 0f)
		{
			builder.StartTable(2);
			IAirPassageMoveLimit.AddEdgeLimitCurveFactor(builder, EdgeLimitCurveFactor);
			IAirPassageMoveLimit.AddDirectionAngleLimit(builder, DirectionAngleLimit);
			return IAirPassageMoveLimit.EndIAirPassageMoveLimit(builder);
		}

		// Token: 0x0602AFF1 RID: 176113 RVA: 0x005EEA21 File Offset: 0x005ECC21
		public static void StartIAirPassageMoveLimit(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602AFF2 RID: 176114 RVA: 0x005EEA2A File Offset: 0x005ECC2A
		public static void AddDirectionAngleLimit(FlatBufferBuilder builder, float directionAngleLimit)
		{
			builder.AddFloat(0, directionAngleLimit, 0.0);
		}

		// Token: 0x0602AFF3 RID: 176115 RVA: 0x005EEA3D File Offset: 0x005ECC3D
		public static void AddEdgeLimitCurveFactor(FlatBufferBuilder builder, float edgeLimitCurveFactor)
		{
			builder.AddFloat(1, edgeLimitCurveFactor, 0.0);
		}

		// Token: 0x0602AFF4 RID: 176116 RVA: 0x005EEA50 File Offset: 0x005ECC50
		public static Offset<IAirPassageMoveLimit> EndIAirPassageMoveLimit(FlatBufferBuilder builder)
		{
			return new Offset<IAirPassageMoveLimit>(builder.EndTable());
		}

		// Token: 0x0602AFF5 RID: 176117 RVA: 0x005EEA60 File Offset: 0x005ECC60
		public IAirPassageMoveLimitT UnPack()
		{
			IAirPassageMoveLimitT airPassageMoveLimitT = new IAirPassageMoveLimitT();
			this.UnPackTo(airPassageMoveLimitT);
			return airPassageMoveLimitT;
		}

		// Token: 0x0602AFF6 RID: 176118 RVA: 0x005EEA7B File Offset: 0x005ECC7B
		public void UnPackTo(IAirPassageMoveLimitT _o)
		{
			_o.DirectionAngleLimit = this.DirectionAngleLimit;
			_o.EdgeLimitCurveFactor = this.EdgeLimitCurveFactor;
		}

		// Token: 0x0602AFF7 RID: 176119 RVA: 0x005EEA98 File Offset: 0x005ECC98
		public static Offset<IAirPassageMoveLimit> Pack(FlatBufferBuilder builder, IAirPassageMoveLimitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirPassageMoveLimit>);
			}
			return IAirPassageMoveLimit.CreateIAirPassageMoveLimit(builder, _o.DirectionAngleLimit, _o.EdgeLimitCurveFactor);
		}

		// Token: 0x04010683 RID: 67203
		private Table __p;
	}
}

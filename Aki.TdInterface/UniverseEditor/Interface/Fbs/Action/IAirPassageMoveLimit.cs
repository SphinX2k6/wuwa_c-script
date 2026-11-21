using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067EA RID: 26602
	public struct IAirPassageMoveLimit : IFlatbufferObject
	{
		// Token: 0x1700C39D RID: 50077
		// (get) Token: 0x0602D719 RID: 186137 RVA: 0x0063918C File Offset: 0x0063738C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D71A RID: 186138 RVA: 0x00639199 File Offset: 0x00637399
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D71B RID: 186139 RVA: 0x006391A0 File Offset: 0x006373A0
		public static IAirPassageMoveLimit GetRootAsIAirPassageMoveLimit(ByteBuffer _bb)
		{
			return IAirPassageMoveLimit.GetRootAsIAirPassageMoveLimit(_bb, default(IAirPassageMoveLimit));
		}

		// Token: 0x0602D71C RID: 186140 RVA: 0x006391BC File Offset: 0x006373BC
		public static IAirPassageMoveLimit GetRootAsIAirPassageMoveLimit(ByteBuffer _bb, IAirPassageMoveLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D71D RID: 186141 RVA: 0x006391D9 File Offset: 0x006373D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D71E RID: 186142 RVA: 0x006391E8 File Offset: 0x006373E8
		public IAirPassageMoveLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C39E RID: 50078
		// (get) Token: 0x0602D71F RID: 186143 RVA: 0x006391F8 File Offset: 0x006373F8
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

		// Token: 0x1700C39F RID: 50079
		// (get) Token: 0x0602D720 RID: 186144 RVA: 0x00639238 File Offset: 0x00637438
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

		// Token: 0x0602D721 RID: 186145 RVA: 0x00639278 File Offset: 0x00637478
		public static Offset<IAirPassageMoveLimit> CreateIAirPassageMoveLimit(FlatBufferBuilder builder, float DirectionAngleLimit = 0f, float EdgeLimitCurveFactor = 0f)
		{
			builder.StartTable(2);
			IAirPassageMoveLimit.AddEdgeLimitCurveFactor(builder, EdgeLimitCurveFactor);
			IAirPassageMoveLimit.AddDirectionAngleLimit(builder, DirectionAngleLimit);
			return IAirPassageMoveLimit.EndIAirPassageMoveLimit(builder);
		}

		// Token: 0x0602D722 RID: 186146 RVA: 0x00639295 File Offset: 0x00637495
		public static void StartIAirPassageMoveLimit(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D723 RID: 186147 RVA: 0x0063929E File Offset: 0x0063749E
		public static void AddDirectionAngleLimit(FlatBufferBuilder builder, float directionAngleLimit)
		{
			builder.AddFloat(0, directionAngleLimit, 0.0);
		}

		// Token: 0x0602D724 RID: 186148 RVA: 0x006392B1 File Offset: 0x006374B1
		public static void AddEdgeLimitCurveFactor(FlatBufferBuilder builder, float edgeLimitCurveFactor)
		{
			builder.AddFloat(1, edgeLimitCurveFactor, 0.0);
		}

		// Token: 0x0602D725 RID: 186149 RVA: 0x006392C4 File Offset: 0x006374C4
		public static Offset<IAirPassageMoveLimit> EndIAirPassageMoveLimit(FlatBufferBuilder builder)
		{
			return new Offset<IAirPassageMoveLimit>(builder.EndTable());
		}

		// Token: 0x0602D726 RID: 186150 RVA: 0x006392D4 File Offset: 0x006374D4
		public IAirPassageMoveLimitT UnPack()
		{
			IAirPassageMoveLimitT airPassageMoveLimitT = new IAirPassageMoveLimitT();
			this.UnPackTo(airPassageMoveLimitT);
			return airPassageMoveLimitT;
		}

		// Token: 0x0602D727 RID: 186151 RVA: 0x006392EF File Offset: 0x006374EF
		public void UnPackTo(IAirPassageMoveLimitT _o)
		{
			_o.DirectionAngleLimit = this.DirectionAngleLimit;
			_o.EdgeLimitCurveFactor = this.EdgeLimitCurveFactor;
		}

		// Token: 0x0602D728 RID: 186152 RVA: 0x0063930C File Offset: 0x0063750C
		public static Offset<IAirPassageMoveLimit> Pack(FlatBufferBuilder builder, IAirPassageMoveLimitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirPassageMoveLimit>);
			}
			return IAirPassageMoveLimit.CreateIAirPassageMoveLimit(builder, _o.DirectionAngleLimit, _o.EdgeLimitCurveFactor);
		}

		// Token: 0x04011492 RID: 70802
		private Table __p;
	}
}

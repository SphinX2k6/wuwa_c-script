using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E77 RID: 15991
	public struct IEnergyFishSplineState : IFlatbufferObject
	{
		// Token: 0x17006C02 RID: 27650
		// (get) Token: 0x060158FE RID: 88318 RVA: 0x0031BC20 File Offset: 0x00319E20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060158FF RID: 88319 RVA: 0x0031BC2D File Offset: 0x00319E2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015900 RID: 88320 RVA: 0x0031BC34 File Offset: 0x00319E34
		public static IEnergyFishSplineState GetRootAsIEnergyFishSplineState(ByteBuffer _bb)
		{
			return IEnergyFishSplineState.GetRootAsIEnergyFishSplineState(_bb, default(IEnergyFishSplineState));
		}

		// Token: 0x06015901 RID: 88321 RVA: 0x0031BC50 File Offset: 0x00319E50
		public static IEnergyFishSplineState GetRootAsIEnergyFishSplineState(ByteBuffer _bb, IEnergyFishSplineState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015902 RID: 88322 RVA: 0x0031BC6D File Offset: 0x00319E6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015903 RID: 88323 RVA: 0x0031BC7C File Offset: 0x00319E7C
		public IEnergyFishSplineState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C03 RID: 27651
		// (get) Token: 0x06015904 RID: 88324 RVA: 0x0031BC8C File Offset: 0x00319E8C
		public EEnergyFishState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnergyFishState.Spline;
				}
				return (EEnergyFishState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C04 RID: 27652
		// (get) Token: 0x06015905 RID: 88325 RVA: 0x0031BCC8 File Offset: 0x00319EC8
		public int SplineId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C05 RID: 27653
		// (get) Token: 0x06015906 RID: 88326 RVA: 0x0031BD04 File Offset: 0x00319F04
		public float NiagaraOrbitSpeed
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C06 RID: 27654
		// (get) Token: 0x06015907 RID: 88327 RVA: 0x0031BD44 File Offset: 0x00319F44
		public bool NiagaraOrbitDirection
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C07 RID: 27655
		// (get) Token: 0x06015908 RID: 88328 RVA: 0x0031BD84 File Offset: 0x00319F84
		public float NiagaraOrbitTrackWidth
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C08 RID: 27656
		// (get) Token: 0x06015909 RID: 88329 RVA: 0x0031BDC8 File Offset: 0x00319FC8
		public float NiagaraOrbitTrackHeight
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

		// Token: 0x17006C09 RID: 27657
		// (get) Token: 0x0601590A RID: 88330 RVA: 0x0031BE0C File Offset: 0x0031A00C
		public float NiagaraOrbitCaptureStrength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C0A RID: 27658
		// (get) Token: 0x0601590B RID: 88331 RVA: 0x0031BE50 File Offset: 0x0031A050
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601590C RID: 88332 RVA: 0x0031BE90 File Offset: 0x0031A090
		public static Offset<IEnergyFishSplineState> CreateIEnergyFishSplineState(FlatBufferBuilder builder, EEnergyFishState Type = EEnergyFishState.Spline, int SplineId = 0, float NiagaraOrbitSpeed = 0f, bool NiagaraOrbitDirection = false, float NiagaraOrbitTrackWidth = 0f, float NiagaraOrbitTrackHeight = 0f, float NiagaraOrbitCaptureStrength = 0f, byte NullMask = 0)
		{
			builder.StartTable(8);
			IEnergyFishSplineState.AddNiagaraOrbitCaptureStrength(builder, NiagaraOrbitCaptureStrength);
			IEnergyFishSplineState.AddNiagaraOrbitTrackHeight(builder, NiagaraOrbitTrackHeight);
			IEnergyFishSplineState.AddNiagaraOrbitTrackWidth(builder, NiagaraOrbitTrackWidth);
			IEnergyFishSplineState.AddNiagaraOrbitSpeed(builder, NiagaraOrbitSpeed);
			IEnergyFishSplineState.AddSplineId(builder, SplineId);
			IEnergyFishSplineState.AddNullMask(builder, NullMask);
			IEnergyFishSplineState.AddNiagaraOrbitDirection(builder, NiagaraOrbitDirection);
			IEnergyFishSplineState.AddType(builder, Type);
			return IEnergyFishSplineState.EndIEnergyFishSplineState(builder);
		}

		// Token: 0x0601590D RID: 88333 RVA: 0x0031BEE7 File Offset: 0x0031A0E7
		public static void StartIEnergyFishSplineState(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601590E RID: 88334 RVA: 0x0031BEF0 File Offset: 0x0031A0F0
		public static void AddType(FlatBufferBuilder builder, EEnergyFishState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601590F RID: 88335 RVA: 0x0031BEFB File Offset: 0x0031A0FB
		public static void AddSplineId(FlatBufferBuilder builder, int splineId)
		{
			builder.AddInt(1, splineId, 0);
		}

		// Token: 0x06015910 RID: 88336 RVA: 0x0031BF06 File Offset: 0x0031A106
		public static void AddNiagaraOrbitSpeed(FlatBufferBuilder builder, float niagaraOrbitSpeed)
		{
			builder.AddFloat(2, niagaraOrbitSpeed, 0.0);
		}

		// Token: 0x06015911 RID: 88337 RVA: 0x0031BF19 File Offset: 0x0031A119
		public static void AddNiagaraOrbitDirection(FlatBufferBuilder builder, bool niagaraOrbitDirection)
		{
			builder.AddBool(3, niagaraOrbitDirection, false);
		}

		// Token: 0x06015912 RID: 88338 RVA: 0x0031BF24 File Offset: 0x0031A124
		public static void AddNiagaraOrbitTrackWidth(FlatBufferBuilder builder, float niagaraOrbitTrackWidth)
		{
			builder.AddFloat(4, niagaraOrbitTrackWidth, 0.0);
		}

		// Token: 0x06015913 RID: 88339 RVA: 0x0031BF37 File Offset: 0x0031A137
		public static void AddNiagaraOrbitTrackHeight(FlatBufferBuilder builder, float niagaraOrbitTrackHeight)
		{
			builder.AddFloat(5, niagaraOrbitTrackHeight, 0.0);
		}

		// Token: 0x06015914 RID: 88340 RVA: 0x0031BF4A File Offset: 0x0031A14A
		public static void AddNiagaraOrbitCaptureStrength(FlatBufferBuilder builder, float niagaraOrbitCaptureStrength)
		{
			builder.AddFloat(6, niagaraOrbitCaptureStrength, 0.0);
		}

		// Token: 0x06015915 RID: 88341 RVA: 0x0031BF5D File Offset: 0x0031A15D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06015916 RID: 88342 RVA: 0x0031BF68 File Offset: 0x0031A168
		public static Offset<IEnergyFishSplineState> EndIEnergyFishSplineState(FlatBufferBuilder builder)
		{
			return new Offset<IEnergyFishSplineState>(builder.EndTable());
		}

		// Token: 0x06015917 RID: 88343 RVA: 0x0031BF78 File Offset: 0x0031A178
		public IEnergyFishSplineStateT UnPack()
		{
			IEnergyFishSplineStateT energyFishSplineStateT = new IEnergyFishSplineStateT();
			this.UnPackTo(energyFishSplineStateT);
			return energyFishSplineStateT;
		}

		// Token: 0x06015918 RID: 88344 RVA: 0x0031BF94 File Offset: 0x0031A194
		public void UnPackTo(IEnergyFishSplineStateT _o)
		{
			_o.Type = this.Type;
			_o.SplineId = this.SplineId;
			_o.NiagaraOrbitSpeed = this.NiagaraOrbitSpeed;
			_o.NiagaraOrbitDirection = this.NiagaraOrbitDirection;
			_o.NiagaraOrbitTrackWidth = this.NiagaraOrbitTrackWidth;
			_o.NiagaraOrbitTrackHeight = this.NiagaraOrbitTrackHeight;
			_o.NiagaraOrbitCaptureStrength = this.NiagaraOrbitCaptureStrength;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015919 RID: 88345 RVA: 0x0031C004 File Offset: 0x0031A204
		public static Offset<IEnergyFishSplineState> Pack(FlatBufferBuilder builder, IEnergyFishSplineStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnergyFishSplineState>);
			}
			return IEnergyFishSplineState.CreateIEnergyFishSplineState(builder, _o.Type, _o.SplineId, _o.NiagaraOrbitSpeed, _o.NiagaraOrbitDirection, _o.NiagaraOrbitTrackWidth, _o.NiagaraOrbitTrackHeight, _o.NiagaraOrbitCaptureStrength, _o.NullMask);
		}

		// Token: 0x0400B842 RID: 47170
		private Table __p;
	}
}

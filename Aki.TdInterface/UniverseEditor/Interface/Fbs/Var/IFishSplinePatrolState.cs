using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E92 RID: 16018
	public struct IFishSplinePatrolState : IFlatbufferObject
	{
		// Token: 0x17006C4A RID: 27722
		// (get) Token: 0x06015A08 RID: 88584 RVA: 0x0031DC9C File Offset: 0x0031BE9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015A09 RID: 88585 RVA: 0x0031DCA9 File Offset: 0x0031BEA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015A0A RID: 88586 RVA: 0x0031DCB0 File Offset: 0x0031BEB0
		public static IFishSplinePatrolState GetRootAsIFishSplinePatrolState(ByteBuffer _bb)
		{
			return IFishSplinePatrolState.GetRootAsIFishSplinePatrolState(_bb, default(IFishSplinePatrolState));
		}

		// Token: 0x06015A0B RID: 88587 RVA: 0x0031DCCC File Offset: 0x0031BECC
		public static IFishSplinePatrolState GetRootAsIFishSplinePatrolState(ByteBuffer _bb, IFishSplinePatrolState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015A0C RID: 88588 RVA: 0x0031DCE9 File Offset: 0x0031BEE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015A0D RID: 88589 RVA: 0x0031DCF8 File Offset: 0x0031BEF8
		public IFishSplinePatrolState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C4B RID: 27723
		// (get) Token: 0x06015A0E RID: 88590 RVA: 0x0031DD08 File Offset: 0x0031BF08
		public EFishState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFishState.Idle;
				}
				return (EFishState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C4C RID: 27724
		// (get) Token: 0x06015A0F RID: 88591 RVA: 0x0031DD44 File Offset: 0x0031BF44
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

		// Token: 0x17006C4D RID: 27725
		// (get) Token: 0x06015A10 RID: 88592 RVA: 0x0031DD80 File Offset: 0x0031BF80
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

		// Token: 0x17006C4E RID: 27726
		// (get) Token: 0x06015A11 RID: 88593 RVA: 0x0031DDC0 File Offset: 0x0031BFC0
		public bool NiagaraOrbitDirection
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C4F RID: 27727
		// (get) Token: 0x06015A12 RID: 88594 RVA: 0x0031DE00 File Offset: 0x0031C000
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

		// Token: 0x17006C50 RID: 27728
		// (get) Token: 0x06015A13 RID: 88595 RVA: 0x0031DE44 File Offset: 0x0031C044
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

		// Token: 0x17006C51 RID: 27729
		// (get) Token: 0x06015A14 RID: 88596 RVA: 0x0031DE88 File Offset: 0x0031C088
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

		// Token: 0x17006C52 RID: 27730
		// (get) Token: 0x06015A15 RID: 88597 RVA: 0x0031DECC File Offset: 0x0031C0CC
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

		// Token: 0x06015A16 RID: 88598 RVA: 0x0031DF0C File Offset: 0x0031C10C
		public static Offset<IFishSplinePatrolState> CreateIFishSplinePatrolState(FlatBufferBuilder builder, EFishState Type = EFishState.Idle, int SplineId = 0, float NiagaraOrbitSpeed = 0f, bool NiagaraOrbitDirection = false, float NiagaraOrbitTrackWidth = 0f, float NiagaraOrbitTrackHeight = 0f, float NiagaraOrbitCaptureStrength = 0f, byte NullMask = 0)
		{
			builder.StartTable(8);
			IFishSplinePatrolState.AddNiagaraOrbitCaptureStrength(builder, NiagaraOrbitCaptureStrength);
			IFishSplinePatrolState.AddNiagaraOrbitTrackHeight(builder, NiagaraOrbitTrackHeight);
			IFishSplinePatrolState.AddNiagaraOrbitTrackWidth(builder, NiagaraOrbitTrackWidth);
			IFishSplinePatrolState.AddNiagaraOrbitSpeed(builder, NiagaraOrbitSpeed);
			IFishSplinePatrolState.AddSplineId(builder, SplineId);
			IFishSplinePatrolState.AddNullMask(builder, NullMask);
			IFishSplinePatrolState.AddNiagaraOrbitDirection(builder, NiagaraOrbitDirection);
			IFishSplinePatrolState.AddType(builder, Type);
			return IFishSplinePatrolState.EndIFishSplinePatrolState(builder);
		}

		// Token: 0x06015A17 RID: 88599 RVA: 0x0031DF63 File Offset: 0x0031C163
		public static void StartIFishSplinePatrolState(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06015A18 RID: 88600 RVA: 0x0031DF6C File Offset: 0x0031C16C
		public static void AddType(FlatBufferBuilder builder, EFishState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015A19 RID: 88601 RVA: 0x0031DF77 File Offset: 0x0031C177
		public static void AddSplineId(FlatBufferBuilder builder, int splineId)
		{
			builder.AddInt(1, splineId, 0);
		}

		// Token: 0x06015A1A RID: 88602 RVA: 0x0031DF82 File Offset: 0x0031C182
		public static void AddNiagaraOrbitSpeed(FlatBufferBuilder builder, float niagaraOrbitSpeed)
		{
			builder.AddFloat(2, niagaraOrbitSpeed, 0.0);
		}

		// Token: 0x06015A1B RID: 88603 RVA: 0x0031DF95 File Offset: 0x0031C195
		public static void AddNiagaraOrbitDirection(FlatBufferBuilder builder, bool niagaraOrbitDirection)
		{
			builder.AddBool(3, niagaraOrbitDirection, false);
		}

		// Token: 0x06015A1C RID: 88604 RVA: 0x0031DFA0 File Offset: 0x0031C1A0
		public static void AddNiagaraOrbitTrackWidth(FlatBufferBuilder builder, float niagaraOrbitTrackWidth)
		{
			builder.AddFloat(4, niagaraOrbitTrackWidth, 0.0);
		}

		// Token: 0x06015A1D RID: 88605 RVA: 0x0031DFB3 File Offset: 0x0031C1B3
		public static void AddNiagaraOrbitTrackHeight(FlatBufferBuilder builder, float niagaraOrbitTrackHeight)
		{
			builder.AddFloat(5, niagaraOrbitTrackHeight, 0.0);
		}

		// Token: 0x06015A1E RID: 88606 RVA: 0x0031DFC6 File Offset: 0x0031C1C6
		public static void AddNiagaraOrbitCaptureStrength(FlatBufferBuilder builder, float niagaraOrbitCaptureStrength)
		{
			builder.AddFloat(6, niagaraOrbitCaptureStrength, 0.0);
		}

		// Token: 0x06015A1F RID: 88607 RVA: 0x0031DFD9 File Offset: 0x0031C1D9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06015A20 RID: 88608 RVA: 0x0031DFE4 File Offset: 0x0031C1E4
		public static Offset<IFishSplinePatrolState> EndIFishSplinePatrolState(FlatBufferBuilder builder)
		{
			return new Offset<IFishSplinePatrolState>(builder.EndTable());
		}

		// Token: 0x06015A21 RID: 88609 RVA: 0x0031DFF4 File Offset: 0x0031C1F4
		public IFishSplinePatrolStateT UnPack()
		{
			IFishSplinePatrolStateT fishSplinePatrolStateT = new IFishSplinePatrolStateT();
			this.UnPackTo(fishSplinePatrolStateT);
			return fishSplinePatrolStateT;
		}

		// Token: 0x06015A22 RID: 88610 RVA: 0x0031E010 File Offset: 0x0031C210
		public void UnPackTo(IFishSplinePatrolStateT _o)
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

		// Token: 0x06015A23 RID: 88611 RVA: 0x0031E080 File Offset: 0x0031C280
		public static Offset<IFishSplinePatrolState> Pack(FlatBufferBuilder builder, IFishSplinePatrolStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFishSplinePatrolState>);
			}
			return IFishSplinePatrolState.CreateIFishSplinePatrolState(builder, _o.Type, _o.SplineId, _o.NiagaraOrbitSpeed, _o.NiagaraOrbitDirection, _o.NiagaraOrbitTrackWidth, _o.NiagaraOrbitTrackHeight, _o.NiagaraOrbitCaptureStrength, _o.NullMask);
		}

		// Token: 0x0400B870 RID: 47216
		private Table __p;
	}
}

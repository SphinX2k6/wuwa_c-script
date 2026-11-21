using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E71 RID: 15985
	public struct IEnergyFishFollowState : IFlatbufferObject
	{
		// Token: 0x17006BF0 RID: 27632
		// (get) Token: 0x060158BA RID: 88250 RVA: 0x0031B364 File Offset: 0x00319564
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060158BB RID: 88251 RVA: 0x0031B371 File Offset: 0x00319571
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060158BC RID: 88252 RVA: 0x0031B378 File Offset: 0x00319578
		public static IEnergyFishFollowState GetRootAsIEnergyFishFollowState(ByteBuffer _bb)
		{
			return IEnergyFishFollowState.GetRootAsIEnergyFishFollowState(_bb, default(IEnergyFishFollowState));
		}

		// Token: 0x060158BD RID: 88253 RVA: 0x0031B394 File Offset: 0x00319594
		public static IEnergyFishFollowState GetRootAsIEnergyFishFollowState(ByteBuffer _bb, IEnergyFishFollowState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060158BE RID: 88254 RVA: 0x0031B3B1 File Offset: 0x003195B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060158BF RID: 88255 RVA: 0x0031B3C0 File Offset: 0x003195C0
		public IEnergyFishFollowState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BF1 RID: 27633
		// (get) Token: 0x060158C0 RID: 88256 RVA: 0x0031B3D0 File Offset: 0x003195D0
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

		// Token: 0x17006BF2 RID: 27634
		// (get) Token: 0x060158C1 RID: 88257 RVA: 0x0031B40C File Offset: 0x0031960C
		public string ActorKey
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060158C2 RID: 88258 RVA: 0x0031B443 File Offset: 0x00319643
		public Span<byte> GetActorKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060158C3 RID: 88259 RVA: 0x0031B452 File Offset: 0x00319652
		public byte[] GetActorKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006BF3 RID: 27635
		// (get) Token: 0x060158C4 RID: 88260 RVA: 0x0031B460 File Offset: 0x00319660
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006BF4 RID: 27636
		// (get) Token: 0x060158C5 RID: 88261 RVA: 0x0031B4C0 File Offset: 0x003196C0
		public float MaxSpeed
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

		// Token: 0x17006BF5 RID: 27637
		// (get) Token: 0x060158C6 RID: 88262 RVA: 0x0031B504 File Offset: 0x00319704
		public float NiagaraFollowStrength
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

		// Token: 0x17006BF6 RID: 27638
		// (get) Token: 0x060158C7 RID: 88263 RVA: 0x0031B548 File Offset: 0x00319748
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060158C8 RID: 88264 RVA: 0x0031B585 File Offset: 0x00319785
		public static Offset<IEnergyFishFollowState> CreateIEnergyFishFollowState(FlatBufferBuilder builder, EEnergyFishState Type = EEnergyFishState.Spline, StringOffset ActorKeyOffset = default(StringOffset), Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), float MaxSpeed = 0f, float NiagaraFollowStrength = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IEnergyFishFollowState.AddNiagaraFollowStrength(builder, NiagaraFollowStrength);
			IEnergyFishFollowState.AddMaxSpeed(builder, MaxSpeed);
			IEnergyFishFollowState.AddOffset(builder, OffsetOffset);
			IEnergyFishFollowState.AddActorKey(builder, ActorKeyOffset);
			IEnergyFishFollowState.AddNullMask(builder, NullMask);
			IEnergyFishFollowState.AddType(builder, Type);
			return IEnergyFishFollowState.EndIEnergyFishFollowState(builder);
		}

		// Token: 0x060158C9 RID: 88265 RVA: 0x0031B5C1 File Offset: 0x003197C1
		public static void StartIEnergyFishFollowState(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060158CA RID: 88266 RVA: 0x0031B5CA File Offset: 0x003197CA
		public static void AddType(FlatBufferBuilder builder, EEnergyFishState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060158CB RID: 88267 RVA: 0x0031B5D5 File Offset: 0x003197D5
		public static void AddActorKey(FlatBufferBuilder builder, StringOffset actorKeyOffset)
		{
			builder.AddOffset(1, actorKeyOffset.Value, 0);
		}

		// Token: 0x060158CC RID: 88268 RVA: 0x0031B5E5 File Offset: 0x003197E5
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x060158CD RID: 88269 RVA: 0x0031B5F5 File Offset: 0x003197F5
		public static void AddMaxSpeed(FlatBufferBuilder builder, float maxSpeed)
		{
			builder.AddFloat(3, maxSpeed, 0.0);
		}

		// Token: 0x060158CE RID: 88270 RVA: 0x0031B608 File Offset: 0x00319808
		public static void AddNiagaraFollowStrength(FlatBufferBuilder builder, float niagaraFollowStrength)
		{
			builder.AddFloat(4, niagaraFollowStrength, 0.0);
		}

		// Token: 0x060158CF RID: 88271 RVA: 0x0031B61B File Offset: 0x0031981B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060158D0 RID: 88272 RVA: 0x0031B626 File Offset: 0x00319826
		public static Offset<IEnergyFishFollowState> EndIEnergyFishFollowState(FlatBufferBuilder builder)
		{
			return new Offset<IEnergyFishFollowState>(builder.EndTable());
		}

		// Token: 0x060158D1 RID: 88273 RVA: 0x0031B634 File Offset: 0x00319834
		public IEnergyFishFollowStateT UnPack()
		{
			IEnergyFishFollowStateT energyFishFollowStateT = new IEnergyFishFollowStateT();
			this.UnPackTo(energyFishFollowStateT);
			return energyFishFollowStateT;
		}

		// Token: 0x060158D2 RID: 88274 RVA: 0x0031B650 File Offset: 0x00319850
		public void UnPackTo(IEnergyFishFollowStateT _o)
		{
			_o.Type = this.Type;
			_o.ActorKey = this.ActorKey;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.MaxSpeed = this.MaxSpeed;
			_o.NiagaraFollowStrength = this.NiagaraFollowStrength;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060158D3 RID: 88275 RVA: 0x0031B6C8 File Offset: 0x003198C8
		public static Offset<IEnergyFishFollowState> Pack(FlatBufferBuilder builder, IEnergyFishFollowStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnergyFishFollowState>);
			}
			StringOffset actorKeyOffset = (_o.ActorKey == null) ? default(StringOffset) : builder.CreateString(_o.ActorKey);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IEnergyFishFollowState.CreateIEnergyFishFollowState(builder, _o.Type, actorKeyOffset, offsetOffset, _o.MaxSpeed, _o.NiagaraFollowStrength, _o.NullMask);
		}

		// Token: 0x0400B838 RID: 47160
		private Table __p;
	}
}

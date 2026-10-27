using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A70 RID: 23152
	public struct IThrowMotionTrackTarget : IFlatbufferObject
	{
		// Token: 0x1700AE42 RID: 44610
		// (get) Token: 0x0602767B RID: 161403 RVA: 0x0056C25A File Offset: 0x0056A45A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602767C RID: 161404 RVA: 0x0056C267 File Offset: 0x0056A467
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602767D RID: 161405 RVA: 0x0056C270 File Offset: 0x0056A470
		public static IThrowMotionTrackTarget GetRootAsIThrowMotionTrackTarget(ByteBuffer _bb)
		{
			return IThrowMotionTrackTarget.GetRootAsIThrowMotionTrackTarget(_bb, default(IThrowMotionTrackTarget));
		}

		// Token: 0x0602767E RID: 161406 RVA: 0x0056C28C File Offset: 0x0056A48C
		public static IThrowMotionTrackTarget GetRootAsIThrowMotionTrackTarget(ByteBuffer _bb, IThrowMotionTrackTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602767F RID: 161407 RVA: 0x0056C2A9 File Offset: 0x0056A4A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027680 RID: 161408 RVA: 0x0056C2B8 File Offset: 0x0056A4B8
		public IThrowMotionTrackTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE43 RID: 44611
		// (get) Token: 0x06027681 RID: 161409 RVA: 0x0056C2C8 File Offset: 0x0056A4C8
		public EThrowMotion Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EThrowMotion.Projectile;
				}
				return (EThrowMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE44 RID: 44612
		// (get) Token: 0x06027682 RID: 161410 RVA: 0x0056C304 File Offset: 0x0056A504
		public float Velocity
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

		// Token: 0x1700AE45 RID: 44613
		// (get) Token: 0x06027683 RID: 161411 RVA: 0x0056C344 File Offset: 0x0056A544
		public string VelocityCurve
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027684 RID: 161412 RVA: 0x0056C37B File Offset: 0x0056A57B
		public Span<byte> GetVelocityCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06027685 RID: 161413 RVA: 0x0056C38A File Offset: 0x0056A58A
		public byte[] GetVelocityCurveArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700AE46 RID: 44614
		// (get) Token: 0x06027686 RID: 161414 RVA: 0x0056C398 File Offset: 0x0056A598
		public IVectorInfo? VelocityOffset
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AE47 RID: 44615
		// (get) Token: 0x06027687 RID: 161415 RVA: 0x0056C3F8 File Offset: 0x0056A5F8
		public float AngularVelocity
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

		// Token: 0x1700AE48 RID: 44616
		// (get) Token: 0x06027688 RID: 161416 RVA: 0x0056C43C File Offset: 0x0056A63C
		public string AngularVelocityCurve
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027689 RID: 161417 RVA: 0x0056C474 File Offset: 0x0056A674
		public Span<byte> GetAngularVelocityCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602768A RID: 161418 RVA: 0x0056C484 File Offset: 0x0056A684
		public byte[] GetAngularVelocityCurveArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x0602768B RID: 161419 RVA: 0x0056C493 File Offset: 0x0056A693
		public static Offset<IThrowMotionTrackTarget> CreateIThrowMotionTrackTarget(FlatBufferBuilder builder, EThrowMotion Type = EThrowMotion.Projectile, float Velocity = 0f, StringOffset VelocityCurveOffset = default(StringOffset), Offset<IVectorInfo> VelocityOffsetOffset = default(Offset<IVectorInfo>), float AngularVelocity = 0f, StringOffset AngularVelocityCurveOffset = default(StringOffset))
		{
			builder.StartTable(6);
			IThrowMotionTrackTarget.AddAngularVelocityCurve(builder, AngularVelocityCurveOffset);
			IThrowMotionTrackTarget.AddAngularVelocity(builder, AngularVelocity);
			IThrowMotionTrackTarget.AddVelocityOffset(builder, VelocityOffsetOffset);
			IThrowMotionTrackTarget.AddVelocityCurve(builder, VelocityCurveOffset);
			IThrowMotionTrackTarget.AddVelocity(builder, Velocity);
			IThrowMotionTrackTarget.AddType(builder, Type);
			return IThrowMotionTrackTarget.EndIThrowMotionTrackTarget(builder);
		}

		// Token: 0x0602768C RID: 161420 RVA: 0x0056C4CF File Offset: 0x0056A6CF
		public static void StartIThrowMotionTrackTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602768D RID: 161421 RVA: 0x0056C4D8 File Offset: 0x0056A6D8
		public static void AddType(FlatBufferBuilder builder, EThrowMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602768E RID: 161422 RVA: 0x0056C4E3 File Offset: 0x0056A6E3
		public static void AddVelocity(FlatBufferBuilder builder, float velocity)
		{
			builder.AddFloat(1, velocity, 0.0);
		}

		// Token: 0x0602768F RID: 161423 RVA: 0x0056C4F6 File Offset: 0x0056A6F6
		public static void AddVelocityCurve(FlatBufferBuilder builder, StringOffset velocityCurveOffset)
		{
			builder.AddOffset(2, velocityCurveOffset.Value, 0);
		}

		// Token: 0x06027690 RID: 161424 RVA: 0x0056C506 File Offset: 0x0056A706
		public static void AddVelocityOffset(FlatBufferBuilder builder, Offset<IVectorInfo> velocityOffsetOffset)
		{
			builder.AddOffset(3, velocityOffsetOffset.Value, 0);
		}

		// Token: 0x06027691 RID: 161425 RVA: 0x0056C516 File Offset: 0x0056A716
		public static void AddAngularVelocity(FlatBufferBuilder builder, float angularVelocity)
		{
			builder.AddFloat(4, angularVelocity, 0.0);
		}

		// Token: 0x06027692 RID: 161426 RVA: 0x0056C529 File Offset: 0x0056A729
		public static void AddAngularVelocityCurve(FlatBufferBuilder builder, StringOffset angularVelocityCurveOffset)
		{
			builder.AddOffset(5, angularVelocityCurveOffset.Value, 0);
		}

		// Token: 0x06027693 RID: 161427 RVA: 0x0056C539 File Offset: 0x0056A739
		public static Offset<IThrowMotionTrackTarget> EndIThrowMotionTrackTarget(FlatBufferBuilder builder)
		{
			return new Offset<IThrowMotionTrackTarget>(builder.EndTable());
		}

		// Token: 0x06027694 RID: 161428 RVA: 0x0056C548 File Offset: 0x0056A748
		public IThrowMotionTrackTargetT UnPack()
		{
			IThrowMotionTrackTargetT throwMotionTrackTargetT = new IThrowMotionTrackTargetT();
			this.UnPackTo(throwMotionTrackTargetT);
			return throwMotionTrackTargetT;
		}

		// Token: 0x06027695 RID: 161429 RVA: 0x0056C564 File Offset: 0x0056A764
		public void UnPackTo(IThrowMotionTrackTargetT _o)
		{
			_o.Type = this.Type;
			_o.Velocity = this.Velocity;
			_o.VelocityCurve = this.VelocityCurve;
			_o.VelocityOffset = ((this.VelocityOffset != null) ? this.VelocityOffset.Value.UnPack() : null);
			_o.AngularVelocity = this.AngularVelocity;
			_o.AngularVelocityCurve = this.AngularVelocityCurve;
		}

		// Token: 0x06027696 RID: 161430 RVA: 0x0056C5DC File Offset: 0x0056A7DC
		public static Offset<IThrowMotionTrackTarget> Pack(FlatBufferBuilder builder, IThrowMotionTrackTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IThrowMotionTrackTarget>);
			}
			StringOffset velocityCurveOffset = (_o.VelocityCurve == null) ? default(StringOffset) : builder.CreateString(_o.VelocityCurve);
			Offset<IVectorInfo> velocityOffsetOffset = (_o.VelocityOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.VelocityOffset);
			StringOffset angularVelocityCurveOffset = (_o.AngularVelocityCurve == null) ? default(StringOffset) : builder.CreateString(_o.AngularVelocityCurve);
			return IThrowMotionTrackTarget.CreateIThrowMotionTrackTarget(builder, _o.Type, _o.Velocity, velocityCurveOffset, velocityOffsetOffset, _o.AngularVelocity, angularVelocityCurveOffset);
		}

		// Token: 0x0400F107 RID: 61703
		private Table __p;
	}
}

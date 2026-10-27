using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053AA RID: 21418
	public struct IHoldCfg : IFlatbufferObject
	{
		// Token: 0x17009D5B RID: 40283
		// (get) Token: 0x06023152 RID: 143698 RVA: 0x004DB48C File Offset: 0x004D968C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023153 RID: 143699 RVA: 0x004DB499 File Offset: 0x004D9699
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023154 RID: 143700 RVA: 0x004DB4A0 File Offset: 0x004D96A0
		public static IHoldCfg GetRootAsIHoldCfg(ByteBuffer _bb)
		{
			return IHoldCfg.GetRootAsIHoldCfg(_bb, default(IHoldCfg));
		}

		// Token: 0x06023155 RID: 143701 RVA: 0x004DB4BC File Offset: 0x004D96BC
		public static IHoldCfg GetRootAsIHoldCfg(ByteBuffer _bb, IHoldCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023156 RID: 143702 RVA: 0x004DB4D9 File Offset: 0x004D96D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023157 RID: 143703 RVA: 0x004DB4E8 File Offset: 0x004D96E8
		public IHoldCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D5C RID: 40284
		// (get) Token: 0x06023158 RID: 143704 RVA: 0x004DB4F8 File Offset: 0x004D96F8
		public IHoldingTrackTarget? TrackTarget
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IHoldingTrackTarget?(default(IHoldingTrackTarget).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023159 RID: 143705 RVA: 0x004DB555 File Offset: 0x004D9755
		public static Offset<IHoldCfg> CreateIHoldCfg(FlatBufferBuilder builder, Offset<IHoldingTrackTarget> TrackTargetOffset = default(Offset<IHoldingTrackTarget>))
		{
			builder.StartTable(1);
			IHoldCfg.AddTrackTarget(builder, TrackTargetOffset);
			return IHoldCfg.EndIHoldCfg(builder);
		}

		// Token: 0x0602315A RID: 143706 RVA: 0x004DB56B File Offset: 0x004D976B
		public static void StartIHoldCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602315B RID: 143707 RVA: 0x004DB574 File Offset: 0x004D9774
		public static void AddTrackTarget(FlatBufferBuilder builder, Offset<IHoldingTrackTarget> trackTargetOffset)
		{
			builder.AddOffset(0, trackTargetOffset.Value, 0);
		}

		// Token: 0x0602315C RID: 143708 RVA: 0x004DB584 File Offset: 0x004D9784
		public static Offset<IHoldCfg> EndIHoldCfg(FlatBufferBuilder builder)
		{
			return new Offset<IHoldCfg>(builder.EndTable());
		}

		// Token: 0x0602315D RID: 143709 RVA: 0x004DB594 File Offset: 0x004D9794
		public IHoldCfgT UnPack()
		{
			IHoldCfgT holdCfgT = new IHoldCfgT();
			this.UnPackTo(holdCfgT);
			return holdCfgT;
		}

		// Token: 0x0602315E RID: 143710 RVA: 0x004DB5B0 File Offset: 0x004D97B0
		public void UnPackTo(IHoldCfgT _o)
		{
			_o.TrackTarget = ((this.TrackTarget != null) ? this.TrackTarget.Value.UnPack() : null);
		}

		// Token: 0x0602315F RID: 143711 RVA: 0x004DB5EC File Offset: 0x004D97EC
		public static Offset<IHoldCfg> Pack(FlatBufferBuilder builder, IHoldCfgT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHoldCfg>);
			}
			Offset<IHoldingTrackTarget> trackTargetOffset = (_o.TrackTarget == null) ? default(Offset<IHoldingTrackTarget>) : IHoldingTrackTarget.Pack(builder, _o.TrackTarget);
			return IHoldCfg.CreateIHoldCfg(builder, trackTargetOffset);
		}

		// Token: 0x0400E59E RID: 58782
		private Table __p;
	}
}

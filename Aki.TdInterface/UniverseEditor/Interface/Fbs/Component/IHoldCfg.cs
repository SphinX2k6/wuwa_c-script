using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005930 RID: 22832
	public struct IHoldCfg : IFlatbufferObject
	{
		// Token: 0x1700A593 RID: 42387
		// (get) Token: 0x06025206 RID: 152070 RVA: 0x00518360 File Offset: 0x00516560
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025207 RID: 152071 RVA: 0x0051836D File Offset: 0x0051656D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025208 RID: 152072 RVA: 0x00518374 File Offset: 0x00516574
		public static IHoldCfg GetRootAsIHoldCfg(ByteBuffer _bb)
		{
			return IHoldCfg.GetRootAsIHoldCfg(_bb, default(IHoldCfg));
		}

		// Token: 0x06025209 RID: 152073 RVA: 0x00518390 File Offset: 0x00516590
		public static IHoldCfg GetRootAsIHoldCfg(ByteBuffer _bb, IHoldCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602520A RID: 152074 RVA: 0x005183AD File Offset: 0x005165AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602520B RID: 152075 RVA: 0x005183BC File Offset: 0x005165BC
		public IHoldCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A594 RID: 42388
		// (get) Token: 0x0602520C RID: 152076 RVA: 0x005183CC File Offset: 0x005165CC
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

		// Token: 0x0602520D RID: 152077 RVA: 0x00518429 File Offset: 0x00516629
		public static Offset<IHoldCfg> CreateIHoldCfg(FlatBufferBuilder builder, Offset<IHoldingTrackTarget> TrackTargetOffset = default(Offset<IHoldingTrackTarget>))
		{
			builder.StartTable(1);
			IHoldCfg.AddTrackTarget(builder, TrackTargetOffset);
			return IHoldCfg.EndIHoldCfg(builder);
		}

		// Token: 0x0602520E RID: 152078 RVA: 0x0051843F File Offset: 0x0051663F
		public static void StartIHoldCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602520F RID: 152079 RVA: 0x00518448 File Offset: 0x00516648
		public static void AddTrackTarget(FlatBufferBuilder builder, Offset<IHoldingTrackTarget> trackTargetOffset)
		{
			builder.AddOffset(0, trackTargetOffset.Value, 0);
		}

		// Token: 0x06025210 RID: 152080 RVA: 0x00518458 File Offset: 0x00516658
		public static Offset<IHoldCfg> EndIHoldCfg(FlatBufferBuilder builder)
		{
			return new Offset<IHoldCfg>(builder.EndTable());
		}

		// Token: 0x06025211 RID: 152081 RVA: 0x00518468 File Offset: 0x00516668
		public IHoldCfgT UnPack()
		{
			IHoldCfgT holdCfgT = new IHoldCfgT();
			this.UnPackTo(holdCfgT);
			return holdCfgT;
		}

		// Token: 0x06025212 RID: 152082 RVA: 0x00518484 File Offset: 0x00516684
		public void UnPackTo(IHoldCfgT _o)
		{
			_o.TrackTarget = ((this.TrackTarget != null) ? this.TrackTarget.Value.UnPack() : null);
		}

		// Token: 0x06025213 RID: 152083 RVA: 0x005184C0 File Offset: 0x005166C0
		public static Offset<IHoldCfg> Pack(FlatBufferBuilder builder, IHoldCfgT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHoldCfg>);
			}
			Offset<IHoldingTrackTarget> trackTargetOffset = (_o.TrackTarget == null) ? default(Offset<IHoldingTrackTarget>) : IHoldingTrackTarget.Pack(builder, _o.TrackTarget);
			return IHoldCfg.CreateIHoldCfg(builder, trackTargetOffset);
		}

		// Token: 0x0400F1CE RID: 61902
		private Table __p;
	}
}

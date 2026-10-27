using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CFA RID: 19706
	public struct ITrafficMatchTarget : IFlatbufferObject
	{
		// Token: 0x17008EFC RID: 36604
		// (get) Token: 0x0601F46E RID: 128110 RVA: 0x0045D174 File Offset: 0x0045B374
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F46F RID: 128111 RVA: 0x0045D181 File Offset: 0x0045B381
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F470 RID: 128112 RVA: 0x0045D188 File Offset: 0x0045B388
		public static ITrafficMatchTarget GetRootAsITrafficMatchTarget(ByteBuffer _bb)
		{
			return ITrafficMatchTarget.GetRootAsITrafficMatchTarget(_bb, default(ITrafficMatchTarget));
		}

		// Token: 0x0601F471 RID: 128113 RVA: 0x0045D1A4 File Offset: 0x0045B3A4
		public static ITrafficMatchTarget GetRootAsITrafficMatchTarget(ByteBuffer _bb, ITrafficMatchTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F472 RID: 128114 RVA: 0x0045D1C1 File Offset: 0x0045B3C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F473 RID: 128115 RVA: 0x0045D1D0 File Offset: 0x0045B3D0
		public ITrafficMatchTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EFD RID: 36605
		// (get) Token: 0x0601F474 RID: 128116 RVA: 0x0045D1E0 File Offset: 0x0045B3E0
		public bool MatchPlayer
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008EFE RID: 36606
		// (get) Token: 0x0601F475 RID: 128117 RVA: 0x0045D220 File Offset: 0x0045B420
		public ITrafficMatchTargetByEntityLogic? MatchTargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITrafficMatchTargetByEntityLogic?(default(ITrafficMatchTargetByEntityLogic).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601F476 RID: 128118 RVA: 0x0045D27D File Offset: 0x0045B47D
		public static Offset<ITrafficMatchTarget> CreateITrafficMatchTarget(FlatBufferBuilder builder, bool MatchPlayer = false, Offset<ITrafficMatchTargetByEntityLogic> MatchTargetTypeOffset = default(Offset<ITrafficMatchTargetByEntityLogic>))
		{
			builder.StartTable(2);
			ITrafficMatchTarget.AddMatchTargetType(builder, MatchTargetTypeOffset);
			ITrafficMatchTarget.AddMatchPlayer(builder, MatchPlayer);
			return ITrafficMatchTarget.EndITrafficMatchTarget(builder);
		}

		// Token: 0x0601F477 RID: 128119 RVA: 0x0045D29A File Offset: 0x0045B49A
		public static void StartITrafficMatchTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F478 RID: 128120 RVA: 0x0045D2A3 File Offset: 0x0045B4A3
		public static void AddMatchPlayer(FlatBufferBuilder builder, bool matchPlayer)
		{
			builder.AddBool(0, matchPlayer, false);
		}

		// Token: 0x0601F479 RID: 128121 RVA: 0x0045D2AE File Offset: 0x0045B4AE
		public static void AddMatchTargetType(FlatBufferBuilder builder, Offset<ITrafficMatchTargetByEntityLogic> matchTargetTypeOffset)
		{
			builder.AddOffset(1, matchTargetTypeOffset.Value, 0);
		}

		// Token: 0x0601F47A RID: 128122 RVA: 0x0045D2BE File Offset: 0x0045B4BE
		public static Offset<ITrafficMatchTarget> EndITrafficMatchTarget(FlatBufferBuilder builder)
		{
			return new Offset<ITrafficMatchTarget>(builder.EndTable());
		}

		// Token: 0x0601F47B RID: 128123 RVA: 0x0045D2CC File Offset: 0x0045B4CC
		public ITrafficMatchTargetT UnPack()
		{
			ITrafficMatchTargetT trafficMatchTargetT = new ITrafficMatchTargetT();
			this.UnPackTo(trafficMatchTargetT);
			return trafficMatchTargetT;
		}

		// Token: 0x0601F47C RID: 128124 RVA: 0x0045D2E8 File Offset: 0x0045B4E8
		public void UnPackTo(ITrafficMatchTargetT _o)
		{
			_o.MatchPlayer = this.MatchPlayer;
			_o.MatchTargetType = ((this.MatchTargetType != null) ? this.MatchTargetType.Value.UnPack() : null);
		}

		// Token: 0x0601F47D RID: 128125 RVA: 0x0045D330 File Offset: 0x0045B530
		public static Offset<ITrafficMatchTarget> Pack(FlatBufferBuilder builder, ITrafficMatchTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrafficMatchTarget>);
			}
			Offset<ITrafficMatchTargetByEntityLogic> matchTargetTypeOffset = (_o.MatchTargetType == null) ? default(Offset<ITrafficMatchTargetByEntityLogic>) : ITrafficMatchTargetByEntityLogic.Pack(builder, _o.MatchTargetType);
			return ITrafficMatchTarget.CreateITrafficMatchTarget(builder, _o.MatchPlayer, matchTargetTypeOffset);
		}

		// Token: 0x0400D6D6 RID: 54998
		private Table __p;
	}
}

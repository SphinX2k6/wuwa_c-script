using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200570D RID: 22285
	public struct IPatrolRange : IFlatbufferObject
	{
		// Token: 0x1700A5E9 RID: 42473
		// (get) Token: 0x06025423 RID: 152611 RVA: 0x00524169 File Offset: 0x00522369
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025424 RID: 152612 RVA: 0x00524176 File Offset: 0x00522376
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025425 RID: 152613 RVA: 0x00524180 File Offset: 0x00522380
		public static IPatrolRange GetRootAsIPatrolRange(ByteBuffer _bb)
		{
			return IPatrolRange.GetRootAsIPatrolRange(_bb, default(IPatrolRange));
		}

		// Token: 0x06025426 RID: 152614 RVA: 0x0052419C File Offset: 0x0052239C
		public static IPatrolRange GetRootAsIPatrolRange(ByteBuffer _bb, IPatrolRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025427 RID: 152615 RVA: 0x005241B9 File Offset: 0x005223B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025428 RID: 152616 RVA: 0x005241C8 File Offset: 0x005223C8
		public IPatrolRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5EA RID: 42474
		// (get) Token: 0x06025429 RID: 152617 RVA: 0x005241D8 File Offset: 0x005223D8
		public IVectorInfo? Center
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A5EB RID: 42475
		// (get) Token: 0x0602542A RID: 152618 RVA: 0x00524238 File Offset: 0x00522438
		public int Radius
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

		// Token: 0x0602542B RID: 152619 RVA: 0x00524274 File Offset: 0x00522474
		public static Offset<IPatrolRange> CreateIPatrolRange(FlatBufferBuilder builder, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0)
		{
			builder.StartTable(2);
			IPatrolRange.AddRadius(builder, Radius);
			IPatrolRange.AddCenter(builder, CenterOffset);
			return IPatrolRange.EndIPatrolRange(builder);
		}

		// Token: 0x0602542C RID: 152620 RVA: 0x00524291 File Offset: 0x00522491
		public static void StartIPatrolRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602542D RID: 152621 RVA: 0x0052429A File Offset: 0x0052249A
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(0, centerOffset.Value, 0);
		}

		// Token: 0x0602542E RID: 152622 RVA: 0x005242AA File Offset: 0x005224AA
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x0602542F RID: 152623 RVA: 0x005242B5 File Offset: 0x005224B5
		public static Offset<IPatrolRange> EndIPatrolRange(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolRange>(builder.EndTable());
		}

		// Token: 0x06025430 RID: 152624 RVA: 0x005242C4 File Offset: 0x005224C4
		public IPatrolRangeT UnPack()
		{
			IPatrolRangeT patrolRangeT = new IPatrolRangeT();
			this.UnPackTo(patrolRangeT);
			return patrolRangeT;
		}

		// Token: 0x06025431 RID: 152625 RVA: 0x005242E0 File Offset: 0x005224E0
		public void UnPackTo(IPatrolRangeT _o)
		{
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
		}

		// Token: 0x06025432 RID: 152626 RVA: 0x00524328 File Offset: 0x00522528
		public static Offset<IPatrolRange> Pack(FlatBufferBuilder builder, IPatrolRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolRange>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return IPatrolRange.CreateIPatrolRange(builder, centerOffset, _o.Radius);
		}

		// Token: 0x0400EB6C RID: 60268
		private Table __p;
	}
}

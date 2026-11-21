using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D37 RID: 27959
	public struct IEnterNpcVehicle : IFlatbufferObject
	{
		// Token: 0x1700CD18 RID: 52504
		// (get) Token: 0x06030395 RID: 197525 RVA: 0x0068E610 File Offset: 0x0068C810
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030396 RID: 197526 RVA: 0x0068E61D File Offset: 0x0068C81D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030397 RID: 197527 RVA: 0x0068E624 File Offset: 0x0068C824
		public static IEnterNpcVehicle GetRootAsIEnterNpcVehicle(ByteBuffer _bb)
		{
			return IEnterNpcVehicle.GetRootAsIEnterNpcVehicle(_bb, default(IEnterNpcVehicle));
		}

		// Token: 0x06030398 RID: 197528 RVA: 0x0068E640 File Offset: 0x0068C840
		public static IEnterNpcVehicle GetRootAsIEnterNpcVehicle(ByteBuffer _bb, IEnterNpcVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030399 RID: 197529 RVA: 0x0068E65D File Offset: 0x0068C85D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603039A RID: 197530 RVA: 0x0068E66C File Offset: 0x0068C86C
		public IEnterNpcVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD19 RID: 52505
		// (get) Token: 0x0603039B RID: 197531 RVA: 0x0068E67C File Offset: 0x0068C87C
		public int Target
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD1A RID: 52506
		// (get) Token: 0x0603039C RID: 197532 RVA: 0x0068E6B8 File Offset: 0x0068C8B8
		public int Seat
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

		// Token: 0x0603039D RID: 197533 RVA: 0x0068E6F4 File Offset: 0x0068C8F4
		public static Offset<IEnterNpcVehicle> CreateIEnterNpcVehicle(FlatBufferBuilder builder, int Target = 0, int Seat = 0)
		{
			builder.StartTable(2);
			IEnterNpcVehicle.AddSeat(builder, Seat);
			IEnterNpcVehicle.AddTarget(builder, Target);
			return IEnterNpcVehicle.EndIEnterNpcVehicle(builder);
		}

		// Token: 0x0603039E RID: 197534 RVA: 0x0068E711 File Offset: 0x0068C911
		public static void StartIEnterNpcVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603039F RID: 197535 RVA: 0x0068E71A File Offset: 0x0068C91A
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(0, target, 0);
		}

		// Token: 0x060303A0 RID: 197536 RVA: 0x0068E725 File Offset: 0x0068C925
		public static void AddSeat(FlatBufferBuilder builder, int seat)
		{
			builder.AddInt(1, seat, 0);
		}

		// Token: 0x060303A1 RID: 197537 RVA: 0x0068E730 File Offset: 0x0068C930
		public static Offset<IEnterNpcVehicle> EndIEnterNpcVehicle(FlatBufferBuilder builder)
		{
			return new Offset<IEnterNpcVehicle>(builder.EndTable());
		}

		// Token: 0x060303A2 RID: 197538 RVA: 0x0068E740 File Offset: 0x0068C940
		public IEnterNpcVehicleT UnPack()
		{
			IEnterNpcVehicleT enterNpcVehicleT = new IEnterNpcVehicleT();
			this.UnPackTo(enterNpcVehicleT);
			return enterNpcVehicleT;
		}

		// Token: 0x060303A3 RID: 197539 RVA: 0x0068E75B File Offset: 0x0068C95B
		public void UnPackTo(IEnterNpcVehicleT _o)
		{
			_o.Target = this.Target;
			_o.Seat = this.Seat;
		}

		// Token: 0x060303A4 RID: 197540 RVA: 0x0068E778 File Offset: 0x0068C978
		public static Offset<IEnterNpcVehicle> Pack(FlatBufferBuilder builder, IEnterNpcVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterNpcVehicle>);
			}
			return IEnterNpcVehicle.CreateIEnterNpcVehicle(builder, _o.Target, _o.Seat);
		}

		// Token: 0x04011BA7 RID: 72615
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066BD RID: 26301
	public struct IEnterNpcVehicle : IFlatbufferObject
	{
		// Token: 0x1700C367 RID: 50023
		// (get) Token: 0x0602DB78 RID: 187256 RVA: 0x0064135C File Offset: 0x0063F55C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DB79 RID: 187257 RVA: 0x00641369 File Offset: 0x0063F569
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DB7A RID: 187258 RVA: 0x00641370 File Offset: 0x0063F570
		public static IEnterNpcVehicle GetRootAsIEnterNpcVehicle(ByteBuffer _bb)
		{
			return IEnterNpcVehicle.GetRootAsIEnterNpcVehicle(_bb, default(IEnterNpcVehicle));
		}

		// Token: 0x0602DB7B RID: 187259 RVA: 0x0064138C File Offset: 0x0063F58C
		public static IEnterNpcVehicle GetRootAsIEnterNpcVehicle(ByteBuffer _bb, IEnterNpcVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DB7C RID: 187260 RVA: 0x006413A9 File Offset: 0x0063F5A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DB7D RID: 187261 RVA: 0x006413B8 File Offset: 0x0063F5B8
		public IEnterNpcVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C368 RID: 50024
		// (get) Token: 0x0602DB7E RID: 187262 RVA: 0x006413C8 File Offset: 0x0063F5C8
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

		// Token: 0x1700C369 RID: 50025
		// (get) Token: 0x0602DB7F RID: 187263 RVA: 0x00641404 File Offset: 0x0063F604
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

		// Token: 0x0602DB80 RID: 187264 RVA: 0x00641440 File Offset: 0x0063F640
		public static Offset<IEnterNpcVehicle> CreateIEnterNpcVehicle(FlatBufferBuilder builder, int Target = 0, int Seat = 0)
		{
			builder.StartTable(2);
			IEnterNpcVehicle.AddSeat(builder, Seat);
			IEnterNpcVehicle.AddTarget(builder, Target);
			return IEnterNpcVehicle.EndIEnterNpcVehicle(builder);
		}

		// Token: 0x0602DB81 RID: 187265 RVA: 0x0064145D File Offset: 0x0063F65D
		public static void StartIEnterNpcVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DB82 RID: 187266 RVA: 0x00641466 File Offset: 0x0063F666
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(0, target, 0);
		}

		// Token: 0x0602DB83 RID: 187267 RVA: 0x00641471 File Offset: 0x0063F671
		public static void AddSeat(FlatBufferBuilder builder, int seat)
		{
			builder.AddInt(1, seat, 0);
		}

		// Token: 0x0602DB84 RID: 187268 RVA: 0x0064147C File Offset: 0x0063F67C
		public static Offset<IEnterNpcVehicle> EndIEnterNpcVehicle(FlatBufferBuilder builder)
		{
			return new Offset<IEnterNpcVehicle>(builder.EndTable());
		}

		// Token: 0x0602DB85 RID: 187269 RVA: 0x0064148C File Offset: 0x0063F68C
		public IEnterNpcVehicleT UnPack()
		{
			IEnterNpcVehicleT enterNpcVehicleT = new IEnterNpcVehicleT();
			this.UnPackTo(enterNpcVehicleT);
			return enterNpcVehicleT;
		}

		// Token: 0x0602DB86 RID: 187270 RVA: 0x006414A7 File Offset: 0x0063F6A7
		public void UnPackTo(IEnterNpcVehicleT _o)
		{
			_o.Target = this.Target;
			_o.Seat = this.Seat;
		}

		// Token: 0x0602DB87 RID: 187271 RVA: 0x006414C4 File Offset: 0x0063F6C4
		public static Offset<IEnterNpcVehicle> Pack(FlatBufferBuilder builder, IEnterNpcVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterNpcVehicle>);
			}
			return IEnterNpcVehicle.CreateIEnterNpcVehicle(builder, _o.Target, _o.Seat);
		}

		// Token: 0x04010D81 RID: 68993
		private Table __p;
	}
}

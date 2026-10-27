using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FB0 RID: 16304
	public struct IPosRollbackConfig : IFlatbufferObject
	{
		// Token: 0x170071D9 RID: 29145
		// (get) Token: 0x060174E2 RID: 95458 RVA: 0x0035C28A File Offset: 0x0035A48A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060174E3 RID: 95459 RVA: 0x0035C297 File Offset: 0x0035A497
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060174E4 RID: 95460 RVA: 0x0035C2A0 File Offset: 0x0035A4A0
		public static IPosRollbackConfig GetRootAsIPosRollbackConfig(ByteBuffer _bb)
		{
			return IPosRollbackConfig.GetRootAsIPosRollbackConfig(_bb, default(IPosRollbackConfig));
		}

		// Token: 0x060174E5 RID: 95461 RVA: 0x0035C2BC File Offset: 0x0035A4BC
		public static IPosRollbackConfig GetRootAsIPosRollbackConfig(ByteBuffer _bb, IPosRollbackConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060174E6 RID: 95462 RVA: 0x0035C2D9 File Offset: 0x0035A4D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060174E7 RID: 95463 RVA: 0x0035C2E8 File Offset: 0x0035A4E8
		public IPosRollbackConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071DA RID: 29146
		// (get) Token: 0x060174E8 RID: 95464 RVA: 0x0035C2F8 File Offset: 0x0035A4F8
		public int RangeEntityId
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

		// Token: 0x170071DB RID: 29147
		// (get) Token: 0x060174E9 RID: 95465 RVA: 0x0035C334 File Offset: 0x0035A534
		public int PositionEntityId
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

		// Token: 0x170071DC RID: 29148
		// (get) Token: 0x060174EA RID: 95466 RVA: 0x0035C370 File Offset: 0x0035A570
		public bool GravityFlip
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170071DD RID: 29149
		// (get) Token: 0x060174EB RID: 95467 RVA: 0x0035C3B0 File Offset: 0x0035A5B0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060174EC RID: 95468 RVA: 0x0035C3ED File Offset: 0x0035A5ED
		public static Offset<IPosRollbackConfig> CreateIPosRollbackConfig(FlatBufferBuilder builder, int RangeEntityId = 0, int PositionEntityId = 0, bool GravityFlip = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPosRollbackConfig.AddPositionEntityId(builder, PositionEntityId);
			IPosRollbackConfig.AddRangeEntityId(builder, RangeEntityId);
			IPosRollbackConfig.AddNullMask(builder, NullMask);
			IPosRollbackConfig.AddGravityFlip(builder, GravityFlip);
			return IPosRollbackConfig.EndIPosRollbackConfig(builder);
		}

		// Token: 0x060174ED RID: 95469 RVA: 0x0035C419 File Offset: 0x0035A619
		public static void StartIPosRollbackConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060174EE RID: 95470 RVA: 0x0035C422 File Offset: 0x0035A622
		public static void AddRangeEntityId(FlatBufferBuilder builder, int rangeEntityId)
		{
			builder.AddInt(0, rangeEntityId, 0);
		}

		// Token: 0x060174EF RID: 95471 RVA: 0x0035C42D File Offset: 0x0035A62D
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(1, positionEntityId, 0);
		}

		// Token: 0x060174F0 RID: 95472 RVA: 0x0035C438 File Offset: 0x0035A638
		public static void AddGravityFlip(FlatBufferBuilder builder, bool gravityFlip)
		{
			builder.AddBool(2, gravityFlip, false);
		}

		// Token: 0x060174F1 RID: 95473 RVA: 0x0035C443 File Offset: 0x0035A643
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060174F2 RID: 95474 RVA: 0x0035C44E File Offset: 0x0035A64E
		public static Offset<IPosRollbackConfig> EndIPosRollbackConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPosRollbackConfig>(builder.EndTable());
		}

		// Token: 0x060174F3 RID: 95475 RVA: 0x0035C45C File Offset: 0x0035A65C
		public IPosRollbackConfigT UnPack()
		{
			IPosRollbackConfigT posRollbackConfigT = new IPosRollbackConfigT();
			this.UnPackTo(posRollbackConfigT);
			return posRollbackConfigT;
		}

		// Token: 0x060174F4 RID: 95476 RVA: 0x0035C477 File Offset: 0x0035A677
		public void UnPackTo(IPosRollbackConfigT _o)
		{
			_o.RangeEntityId = this.RangeEntityId;
			_o.PositionEntityId = this.PositionEntityId;
			_o.GravityFlip = this.GravityFlip;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060174F5 RID: 95477 RVA: 0x0035C4AC File Offset: 0x0035A6AC
		public static Offset<IPosRollbackConfig> Pack(FlatBufferBuilder builder, IPosRollbackConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPosRollbackConfig>);
			}
			return IPosRollbackConfig.CreateIPosRollbackConfig(builder, _o.RangeEntityId, _o.PositionEntityId, _o.GravityFlip, _o.NullMask);
		}

		// Token: 0x0400BA1A RID: 47642
		private Table __p;
	}
}

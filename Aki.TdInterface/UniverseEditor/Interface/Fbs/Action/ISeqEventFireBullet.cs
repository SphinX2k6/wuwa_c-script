using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F7E RID: 28542
	public struct ISeqEventFireBullet : IFlatbufferObject
	{
		// Token: 0x1700D3FE RID: 54270
		// (get) Token: 0x060326D2 RID: 206546 RVA: 0x006CE80A File Offset: 0x006CCA0A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060326D3 RID: 206547 RVA: 0x006CE817 File Offset: 0x006CCA17
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060326D4 RID: 206548 RVA: 0x006CE820 File Offset: 0x006CCA20
		public static ISeqEventFireBullet GetRootAsISeqEventFireBullet(ByteBuffer _bb)
		{
			return ISeqEventFireBullet.GetRootAsISeqEventFireBullet(_bb, default(ISeqEventFireBullet));
		}

		// Token: 0x060326D5 RID: 206549 RVA: 0x006CE83C File Offset: 0x006CCA3C
		public static ISeqEventFireBullet GetRootAsISeqEventFireBullet(ByteBuffer _bb, ISeqEventFireBullet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060326D6 RID: 206550 RVA: 0x006CE859 File Offset: 0x006CCA59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060326D7 RID: 206551 RVA: 0x006CE868 File Offset: 0x006CCA68
		public ISeqEventFireBullet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3FF RID: 54271
		// (get) Token: 0x060326D8 RID: 206552 RVA: 0x006CE878 File Offset: 0x006CCA78
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060326D9 RID: 206553 RVA: 0x006CE8B5 File Offset: 0x006CCAB5
		public static Offset<ISeqEventFireBullet> CreateISeqEventFireBullet(FlatBufferBuilder builder, long BulletId = 0L)
		{
			builder.StartTable(1);
			ISeqEventFireBullet.AddBulletId(builder, BulletId);
			return ISeqEventFireBullet.EndISeqEventFireBullet(builder);
		}

		// Token: 0x060326DA RID: 206554 RVA: 0x006CE8CB File Offset: 0x006CCACB
		public static void StartISeqEventFireBullet(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060326DB RID: 206555 RVA: 0x006CE8D4 File Offset: 0x006CCAD4
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(0, bulletId, 0L);
		}

		// Token: 0x060326DC RID: 206556 RVA: 0x006CE8E0 File Offset: 0x006CCAE0
		public static Offset<ISeqEventFireBullet> EndISeqEventFireBullet(FlatBufferBuilder builder)
		{
			return new Offset<ISeqEventFireBullet>(builder.EndTable());
		}

		// Token: 0x060326DD RID: 206557 RVA: 0x006CE8F0 File Offset: 0x006CCAF0
		public ISeqEventFireBulletT UnPack()
		{
			ISeqEventFireBulletT seqEventFireBulletT = new ISeqEventFireBulletT();
			this.UnPackTo(seqEventFireBulletT);
			return seqEventFireBulletT;
		}

		// Token: 0x060326DE RID: 206558 RVA: 0x006CE90B File Offset: 0x006CCB0B
		public void UnPackTo(ISeqEventFireBulletT _o)
		{
			_o.BulletId = this.BulletId;
		}

		// Token: 0x060326DF RID: 206559 RVA: 0x006CE91C File Offset: 0x006CCB1C
		public static Offset<ISeqEventFireBullet> Pack(FlatBufferBuilder builder, ISeqEventFireBulletT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISeqEventFireBullet>);
			}
			return ISeqEventFireBullet.CreateISeqEventFireBullet(builder, _o.BulletId);
		}

		// Token: 0x04011979 RID: 72057
		private Table __p;
	}
}

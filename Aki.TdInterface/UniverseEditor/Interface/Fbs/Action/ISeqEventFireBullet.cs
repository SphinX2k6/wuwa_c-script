using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007744 RID: 30532
	public struct ISeqEventFireBullet : IFlatbufferObject
	{
		// Token: 0x1700DFCD RID: 57293
		// (get) Token: 0x06035922 RID: 219426 RVA: 0x0072E1C2 File Offset: 0x0072C3C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035923 RID: 219427 RVA: 0x0072E1CF File Offset: 0x0072C3CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035924 RID: 219428 RVA: 0x0072E1D8 File Offset: 0x0072C3D8
		public static ISeqEventFireBullet GetRootAsISeqEventFireBullet(ByteBuffer _bb)
		{
			return ISeqEventFireBullet.GetRootAsISeqEventFireBullet(_bb, default(ISeqEventFireBullet));
		}

		// Token: 0x06035925 RID: 219429 RVA: 0x0072E1F4 File Offset: 0x0072C3F4
		public static ISeqEventFireBullet GetRootAsISeqEventFireBullet(ByteBuffer _bb, ISeqEventFireBullet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035926 RID: 219430 RVA: 0x0072E211 File Offset: 0x0072C411
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035927 RID: 219431 RVA: 0x0072E220 File Offset: 0x0072C420
		public ISeqEventFireBullet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFCE RID: 57294
		// (get) Token: 0x06035928 RID: 219432 RVA: 0x0072E230 File Offset: 0x0072C430
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

		// Token: 0x06035929 RID: 219433 RVA: 0x0072E26D File Offset: 0x0072C46D
		public static Offset<ISeqEventFireBullet> CreateISeqEventFireBullet(FlatBufferBuilder builder, long BulletId = 0L)
		{
			builder.StartTable(1);
			ISeqEventFireBullet.AddBulletId(builder, BulletId);
			return ISeqEventFireBullet.EndISeqEventFireBullet(builder);
		}

		// Token: 0x0603592A RID: 219434 RVA: 0x0072E283 File Offset: 0x0072C483
		public static void StartISeqEventFireBullet(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603592B RID: 219435 RVA: 0x0072E28C File Offset: 0x0072C48C
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(0, bulletId, 0L);
		}

		// Token: 0x0603592C RID: 219436 RVA: 0x0072E298 File Offset: 0x0072C498
		public static Offset<ISeqEventFireBullet> EndISeqEventFireBullet(FlatBufferBuilder builder)
		{
			return new Offset<ISeqEventFireBullet>(builder.EndTable());
		}

		// Token: 0x0603592D RID: 219437 RVA: 0x0072E2A8 File Offset: 0x0072C4A8
		public ISeqEventFireBulletT UnPack()
		{
			ISeqEventFireBulletT seqEventFireBulletT = new ISeqEventFireBulletT();
			this.UnPackTo(seqEventFireBulletT);
			return seqEventFireBulletT;
		}

		// Token: 0x0603592E RID: 219438 RVA: 0x0072E2C3 File Offset: 0x0072C4C3
		public void UnPackTo(ISeqEventFireBulletT _o)
		{
			_o.BulletId = this.BulletId;
		}

		// Token: 0x0603592F RID: 219439 RVA: 0x0072E2D4 File Offset: 0x0072C4D4
		public static Offset<ISeqEventFireBullet> Pack(FlatBufferBuilder builder, ISeqEventFireBulletT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISeqEventFireBullet>);
			}
			return ISeqEventFireBullet.CreateISeqEventFireBullet(builder, _o.BulletId);
		}

		// Token: 0x0401295B RID: 76123
		private Table __p;
	}
}

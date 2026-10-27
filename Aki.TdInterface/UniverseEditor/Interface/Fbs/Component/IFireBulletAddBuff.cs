using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200525B RID: 21083
	public struct IFireBulletAddBuff : IFlatbufferObject
	{
		// Token: 0x17009A6B RID: 39531
		// (get) Token: 0x060224B7 RID: 140471 RVA: 0x004C14F1 File Offset: 0x004BF6F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060224B8 RID: 140472 RVA: 0x004C14FE File Offset: 0x004BF6FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060224B9 RID: 140473 RVA: 0x004C1508 File Offset: 0x004BF708
		public static IFireBulletAddBuff GetRootAsIFireBulletAddBuff(ByteBuffer _bb)
		{
			return IFireBulletAddBuff.GetRootAsIFireBulletAddBuff(_bb, default(IFireBulletAddBuff));
		}

		// Token: 0x060224BA RID: 140474 RVA: 0x004C1524 File Offset: 0x004BF724
		public static IFireBulletAddBuff GetRootAsIFireBulletAddBuff(ByteBuffer _bb, IFireBulletAddBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060224BB RID: 140475 RVA: 0x004C1541 File Offset: 0x004BF741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060224BC RID: 140476 RVA: 0x004C1550 File Offset: 0x004BF750
		public IFireBulletAddBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A6C RID: 39532
		// (get) Token: 0x060224BD RID: 140477 RVA: 0x004C1560 File Offset: 0x004BF760
		public EBuffProducerMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBuffProducerMode.Immediate;
				}
				return (EBuffProducerMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009A6D RID: 39533
		// (get) Token: 0x060224BE RID: 140478 RVA: 0x004C159C File Offset: 0x004BF79C
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009A6E RID: 39534
		// (get) Token: 0x060224BF RID: 140479 RVA: 0x004C15DC File Offset: 0x004BF7DC
		public IVectorInfo? BulletOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060224C0 RID: 140480 RVA: 0x004C1639 File Offset: 0x004BF839
		public static Offset<IFireBulletAddBuff> CreateIFireBulletAddBuff(FlatBufferBuilder builder, EBuffProducerMode Type = EBuffProducerMode.Immediate, long BulletId = 0L, Offset<IVectorInfo> BulletOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IFireBulletAddBuff.AddBulletId(builder, BulletId);
			IFireBulletAddBuff.AddBulletOffset(builder, BulletOffsetOffset);
			IFireBulletAddBuff.AddType(builder, Type);
			return IFireBulletAddBuff.EndIFireBulletAddBuff(builder);
		}

		// Token: 0x060224C1 RID: 140481 RVA: 0x004C165D File Offset: 0x004BF85D
		public static void StartIFireBulletAddBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060224C2 RID: 140482 RVA: 0x004C1666 File Offset: 0x004BF866
		public static void AddType(FlatBufferBuilder builder, EBuffProducerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060224C3 RID: 140483 RVA: 0x004C1671 File Offset: 0x004BF871
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x060224C4 RID: 140484 RVA: 0x004C167D File Offset: 0x004BF87D
		public static void AddBulletOffset(FlatBufferBuilder builder, Offset<IVectorInfo> bulletOffsetOffset)
		{
			builder.AddOffset(2, bulletOffsetOffset.Value, 0);
		}

		// Token: 0x060224C5 RID: 140485 RVA: 0x004C168D File Offset: 0x004BF88D
		public static Offset<IFireBulletAddBuff> EndIFireBulletAddBuff(FlatBufferBuilder builder)
		{
			return new Offset<IFireBulletAddBuff>(builder.EndTable());
		}

		// Token: 0x060224C6 RID: 140486 RVA: 0x004C169C File Offset: 0x004BF89C
		public IFireBulletAddBuffT UnPack()
		{
			IFireBulletAddBuffT fireBulletAddBuffT = new IFireBulletAddBuffT();
			this.UnPackTo(fireBulletAddBuffT);
			return fireBulletAddBuffT;
		}

		// Token: 0x060224C7 RID: 140487 RVA: 0x004C16B8 File Offset: 0x004BF8B8
		public void UnPackTo(IFireBulletAddBuffT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
			_o.BulletOffset = ((this.BulletOffset != null) ? this.BulletOffset.Value.UnPack() : null);
		}

		// Token: 0x060224C8 RID: 140488 RVA: 0x004C170C File Offset: 0x004BF90C
		public static Offset<IFireBulletAddBuff> Pack(FlatBufferBuilder builder, IFireBulletAddBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBulletAddBuff>);
			}
			Offset<IVectorInfo> bulletOffsetOffset = (_o.BulletOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.BulletOffset);
			return IFireBulletAddBuff.CreateIFireBulletAddBuff(builder, _o.Type, _o.BulletId, bulletOffsetOffset);
		}

		// Token: 0x0400E3AC RID: 58284
		private Table __p;
	}
}

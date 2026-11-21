using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C3 RID: 22467
	public struct IFireBulletAddBuff : IFlatbufferObject
	{
		// Token: 0x1700A267 RID: 41575
		// (get) Token: 0x0602444D RID: 148557 RVA: 0x004FBFB5 File Offset: 0x004FA1B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602444E RID: 148558 RVA: 0x004FBFC2 File Offset: 0x004FA1C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602444F RID: 148559 RVA: 0x004FBFCC File Offset: 0x004FA1CC
		public static IFireBulletAddBuff GetRootAsIFireBulletAddBuff(ByteBuffer _bb)
		{
			return IFireBulletAddBuff.GetRootAsIFireBulletAddBuff(_bb, default(IFireBulletAddBuff));
		}

		// Token: 0x06024450 RID: 148560 RVA: 0x004FBFE8 File Offset: 0x004FA1E8
		public static IFireBulletAddBuff GetRootAsIFireBulletAddBuff(ByteBuffer _bb, IFireBulletAddBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024451 RID: 148561 RVA: 0x004FC005 File Offset: 0x004FA205
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024452 RID: 148562 RVA: 0x004FC014 File Offset: 0x004FA214
		public IFireBulletAddBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A268 RID: 41576
		// (get) Token: 0x06024453 RID: 148563 RVA: 0x004FC024 File Offset: 0x004FA224
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

		// Token: 0x1700A269 RID: 41577
		// (get) Token: 0x06024454 RID: 148564 RVA: 0x004FC060 File Offset: 0x004FA260
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

		// Token: 0x1700A26A RID: 41578
		// (get) Token: 0x06024455 RID: 148565 RVA: 0x004FC0A0 File Offset: 0x004FA2A0
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

		// Token: 0x06024456 RID: 148566 RVA: 0x004FC0FD File Offset: 0x004FA2FD
		public static Offset<IFireBulletAddBuff> CreateIFireBulletAddBuff(FlatBufferBuilder builder, EBuffProducerMode Type = EBuffProducerMode.Immediate, long BulletId = 0L, Offset<IVectorInfo> BulletOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IFireBulletAddBuff.AddBulletId(builder, BulletId);
			IFireBulletAddBuff.AddBulletOffset(builder, BulletOffsetOffset);
			IFireBulletAddBuff.AddType(builder, Type);
			return IFireBulletAddBuff.EndIFireBulletAddBuff(builder);
		}

		// Token: 0x06024457 RID: 148567 RVA: 0x004FC121 File Offset: 0x004FA321
		public static void StartIFireBulletAddBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024458 RID: 148568 RVA: 0x004FC12A File Offset: 0x004FA32A
		public static void AddType(FlatBufferBuilder builder, EBuffProducerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024459 RID: 148569 RVA: 0x004FC135 File Offset: 0x004FA335
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x0602445A RID: 148570 RVA: 0x004FC141 File Offset: 0x004FA341
		public static void AddBulletOffset(FlatBufferBuilder builder, Offset<IVectorInfo> bulletOffsetOffset)
		{
			builder.AddOffset(2, bulletOffsetOffset.Value, 0);
		}

		// Token: 0x0602445B RID: 148571 RVA: 0x004FC151 File Offset: 0x004FA351
		public static Offset<IFireBulletAddBuff> EndIFireBulletAddBuff(FlatBufferBuilder builder)
		{
			return new Offset<IFireBulletAddBuff>(builder.EndTable());
		}

		// Token: 0x0602445C RID: 148572 RVA: 0x004FC160 File Offset: 0x004FA360
		public IFireBulletAddBuffT UnPack()
		{
			IFireBulletAddBuffT fireBulletAddBuffT = new IFireBulletAddBuffT();
			this.UnPackTo(fireBulletAddBuffT);
			return fireBulletAddBuffT;
		}

		// Token: 0x0602445D RID: 148573 RVA: 0x004FC17C File Offset: 0x004FA37C
		public void UnPackTo(IFireBulletAddBuffT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
			_o.BulletOffset = ((this.BulletOffset != null) ? this.BulletOffset.Value.UnPack() : null);
		}

		// Token: 0x0602445E RID: 148574 RVA: 0x004FC1D0 File Offset: 0x004FA3D0
		public static Offset<IFireBulletAddBuff> Pack(FlatBufferBuilder builder, IFireBulletAddBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBulletAddBuff>);
			}
			Offset<IVectorInfo> bulletOffsetOffset = (_o.BulletOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.BulletOffset);
			return IFireBulletAddBuff.CreateIFireBulletAddBuff(builder, _o.Type, _o.BulletId, bulletOffsetOffset);
		}

		// Token: 0x0400EFB2 RID: 61362
		private Table __p;
	}
}

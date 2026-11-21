using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005460 RID: 21600
	public struct IBuffConsumerComponent : IFlatbufferObject
	{
		// Token: 0x17009996 RID: 39318
		// (get) Token: 0x06021EB0 RID: 138928 RVA: 0x004ACD4D File Offset: 0x004AAF4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021EB1 RID: 138929 RVA: 0x004ACD5A File Offset: 0x004AAF5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021EB2 RID: 138930 RVA: 0x004ACD64 File Offset: 0x004AAF64
		public static IBuffConsumerComponent GetRootAsIBuffConsumerComponent(ByteBuffer _bb)
		{
			return IBuffConsumerComponent.GetRootAsIBuffConsumerComponent(_bb, default(IBuffConsumerComponent));
		}

		// Token: 0x06021EB3 RID: 138931 RVA: 0x004ACD80 File Offset: 0x004AAF80
		public static IBuffConsumerComponent GetRootAsIBuffConsumerComponent(ByteBuffer _bb, IBuffConsumerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021EB4 RID: 138932 RVA: 0x004ACD9D File Offset: 0x004AAF9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021EB5 RID: 138933 RVA: 0x004ACDAC File Offset: 0x004AAFAC
		public IBuffConsumerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009997 RID: 39319
		// (get) Token: 0x06021EB6 RID: 138934 RVA: 0x004ACDBC File Offset: 0x004AAFBC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009998 RID: 39320
		// (get) Token: 0x06021EB7 RID: 138935 RVA: 0x004ACDFC File Offset: 0x004AAFFC
		public long BuffId
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

		// Token: 0x17009999 RID: 39321
		// (get) Token: 0x06021EB8 RID: 138936 RVA: 0x004ACE3C File Offset: 0x004AB03C
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700999A RID: 39322
		// (get) Token: 0x06021EB9 RID: 138937 RVA: 0x004ACE7C File Offset: 0x004AB07C
		public int ProducerEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700999B RID: 39323
		// (get) Token: 0x06021EBA RID: 138938 RVA: 0x004ACEBC File Offset: 0x004AB0BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021EBB RID: 138939 RVA: 0x004ACEF9 File Offset: 0x004AB0F9
		public static Offset<IBuffConsumerComponent> CreateIBuffConsumerComponent(FlatBufferBuilder builder, bool Disabled = false, long BuffId = 0L, long BulletId = 0L, int ProducerEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IBuffConsumerComponent.AddBulletId(builder, BulletId);
			IBuffConsumerComponent.AddBuffId(builder, BuffId);
			IBuffConsumerComponent.AddProducerEntityId(builder, ProducerEntityId);
			IBuffConsumerComponent.AddNullMask(builder, NullMask);
			IBuffConsumerComponent.AddDisabled(builder, Disabled);
			return IBuffConsumerComponent.EndIBuffConsumerComponent(builder);
		}

		// Token: 0x06021EBC RID: 138940 RVA: 0x004ACF2D File Offset: 0x004AB12D
		public static void StartIBuffConsumerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021EBD RID: 138941 RVA: 0x004ACF36 File Offset: 0x004AB136
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021EBE RID: 138942 RVA: 0x004ACF41 File Offset: 0x004AB141
		public static void AddBuffId(FlatBufferBuilder builder, long buffId)
		{
			builder.AddLong(1, buffId, 0L);
		}

		// Token: 0x06021EBF RID: 138943 RVA: 0x004ACF4D File Offset: 0x004AB14D
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(2, bulletId, 0L);
		}

		// Token: 0x06021EC0 RID: 138944 RVA: 0x004ACF59 File Offset: 0x004AB159
		public static void AddProducerEntityId(FlatBufferBuilder builder, int producerEntityId)
		{
			builder.AddInt(3, producerEntityId, 0);
		}

		// Token: 0x06021EC1 RID: 138945 RVA: 0x004ACF64 File Offset: 0x004AB164
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06021EC2 RID: 138946 RVA: 0x004ACF6F File Offset: 0x004AB16F
		public static Offset<IBuffConsumerComponent> EndIBuffConsumerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBuffConsumerComponent>(builder.EndTable());
		}

		// Token: 0x06021EC3 RID: 138947 RVA: 0x004ACF7C File Offset: 0x004AB17C
		public IBuffConsumerComponentT UnPack()
		{
			IBuffConsumerComponentT buffConsumerComponentT = new IBuffConsumerComponentT();
			this.UnPackTo(buffConsumerComponentT);
			return buffConsumerComponentT;
		}

		// Token: 0x06021EC4 RID: 138948 RVA: 0x004ACF97 File Offset: 0x004AB197
		public void UnPackTo(IBuffConsumerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.BuffId = this.BuffId;
			_o.BulletId = this.BulletId;
			_o.ProducerEntityId = this.ProducerEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021EC5 RID: 138949 RVA: 0x004ACFD8 File Offset: 0x004AB1D8
		public static Offset<IBuffConsumerComponent> Pack(FlatBufferBuilder builder, IBuffConsumerComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffConsumerComponent>);
			}
			return IBuffConsumerComponent.CreateIBuffConsumerComponent(builder, _o.Disabled, _o.BuffId, _o.BulletId, _o.ProducerEntityId, _o.NullMask);
		}

		// Token: 0x0400E940 RID: 59712
		private Table __p;
	}
}

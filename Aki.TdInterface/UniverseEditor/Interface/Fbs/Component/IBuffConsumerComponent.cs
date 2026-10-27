using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F2E RID: 20270
	public struct IBuffConsumerComponent : IFlatbufferObject
	{
		// Token: 0x17009214 RID: 37396
		// (get) Token: 0x06020140 RID: 131392 RVA: 0x004769B9 File Offset: 0x00474BB9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020141 RID: 131393 RVA: 0x004769C6 File Offset: 0x00474BC6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020142 RID: 131394 RVA: 0x004769D0 File Offset: 0x00474BD0
		public static IBuffConsumerComponent GetRootAsIBuffConsumerComponent(ByteBuffer _bb)
		{
			return IBuffConsumerComponent.GetRootAsIBuffConsumerComponent(_bb, default(IBuffConsumerComponent));
		}

		// Token: 0x06020143 RID: 131395 RVA: 0x004769EC File Offset: 0x00474BEC
		public static IBuffConsumerComponent GetRootAsIBuffConsumerComponent(ByteBuffer _bb, IBuffConsumerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020144 RID: 131396 RVA: 0x00476A09 File Offset: 0x00474C09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020145 RID: 131397 RVA: 0x00476A18 File Offset: 0x00474C18
		public IBuffConsumerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009215 RID: 37397
		// (get) Token: 0x06020146 RID: 131398 RVA: 0x00476A28 File Offset: 0x00474C28
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009216 RID: 37398
		// (get) Token: 0x06020147 RID: 131399 RVA: 0x00476A68 File Offset: 0x00474C68
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

		// Token: 0x17009217 RID: 37399
		// (get) Token: 0x06020148 RID: 131400 RVA: 0x00476AA8 File Offset: 0x00474CA8
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

		// Token: 0x17009218 RID: 37400
		// (get) Token: 0x06020149 RID: 131401 RVA: 0x00476AE8 File Offset: 0x00474CE8
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

		// Token: 0x17009219 RID: 37401
		// (get) Token: 0x0602014A RID: 131402 RVA: 0x00476B28 File Offset: 0x00474D28
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

		// Token: 0x0602014B RID: 131403 RVA: 0x00476B65 File Offset: 0x00474D65
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

		// Token: 0x0602014C RID: 131404 RVA: 0x00476B99 File Offset: 0x00474D99
		public static void StartIBuffConsumerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602014D RID: 131405 RVA: 0x00476BA2 File Offset: 0x00474DA2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602014E RID: 131406 RVA: 0x00476BAD File Offset: 0x00474DAD
		public static void AddBuffId(FlatBufferBuilder builder, long buffId)
		{
			builder.AddLong(1, buffId, 0L);
		}

		// Token: 0x0602014F RID: 131407 RVA: 0x00476BB9 File Offset: 0x00474DB9
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(2, bulletId, 0L);
		}

		// Token: 0x06020150 RID: 131408 RVA: 0x00476BC5 File Offset: 0x00474DC5
		public static void AddProducerEntityId(FlatBufferBuilder builder, int producerEntityId)
		{
			builder.AddInt(3, producerEntityId, 0);
		}

		// Token: 0x06020151 RID: 131409 RVA: 0x00476BD0 File Offset: 0x00474DD0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06020152 RID: 131410 RVA: 0x00476BDB File Offset: 0x00474DDB
		public static Offset<IBuffConsumerComponent> EndIBuffConsumerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBuffConsumerComponent>(builder.EndTable());
		}

		// Token: 0x06020153 RID: 131411 RVA: 0x00476BE8 File Offset: 0x00474DE8
		public IBuffConsumerComponentT UnPack()
		{
			IBuffConsumerComponentT buffConsumerComponentT = new IBuffConsumerComponentT();
			this.UnPackTo(buffConsumerComponentT);
			return buffConsumerComponentT;
		}

		// Token: 0x06020154 RID: 131412 RVA: 0x00476C03 File Offset: 0x00474E03
		public void UnPackTo(IBuffConsumerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.BuffId = this.BuffId;
			_o.BulletId = this.BulletId;
			_o.ProducerEntityId = this.ProducerEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020155 RID: 131413 RVA: 0x00476C44 File Offset: 0x00474E44
		public static Offset<IBuffConsumerComponent> Pack(FlatBufferBuilder builder, IBuffConsumerComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffConsumerComponent>);
			}
			return IBuffConsumerComponent.CreateIBuffConsumerComponent(builder, _o.Disabled, _o.BuffId, _o.BulletId, _o.ProducerEntityId, _o.NullMask);
		}

		// Token: 0x0400DD91 RID: 56721
		private Table __p;
	}
}

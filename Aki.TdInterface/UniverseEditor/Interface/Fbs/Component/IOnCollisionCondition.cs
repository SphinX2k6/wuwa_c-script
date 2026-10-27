using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005695 RID: 22165
	public struct IOnCollisionCondition : IFlatbufferObject
	{
		// Token: 0x1700A4D0 RID: 42192
		// (get) Token: 0x06024FC4 RID: 151492 RVA: 0x0051BC0F File Offset: 0x00519E0F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024FC5 RID: 151493 RVA: 0x0051BC1C File Offset: 0x00519E1C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024FC6 RID: 151494 RVA: 0x0051BC24 File Offset: 0x00519E24
		public static IOnCollisionCondition GetRootAsIOnCollisionCondition(ByteBuffer _bb)
		{
			return IOnCollisionCondition.GetRootAsIOnCollisionCondition(_bb, default(IOnCollisionCondition));
		}

		// Token: 0x06024FC7 RID: 151495 RVA: 0x0051BC40 File Offset: 0x00519E40
		public static IOnCollisionCondition GetRootAsIOnCollisionCondition(ByteBuffer _bb, IOnCollisionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024FC8 RID: 151496 RVA: 0x0051BC5D File Offset: 0x00519E5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024FC9 RID: 151497 RVA: 0x0051BC6C File Offset: 0x00519E6C
		public IOnCollisionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4D1 RID: 42193
		// (get) Token: 0x06024FCA RID: 151498 RVA: 0x0051BC7C File Offset: 0x00519E7C
		public EBulletCreateCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBulletCreateCondition.OnHit;
				}
				return (EBulletCreateCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A4D2 RID: 42194
		// (get) Token: 0x06024FCB RID: 151499 RVA: 0x0051BCB8 File Offset: 0x00519EB8
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

		// Token: 0x1700A4D3 RID: 42195
		// (get) Token: 0x06024FCC RID: 151500 RVA: 0x0051BCF8 File Offset: 0x00519EF8
		public ITriggerCountConfig? TriggerCount
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITriggerCountConfig?(default(ITriggerCountConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024FCD RID: 151501 RVA: 0x0051BD55 File Offset: 0x00519F55
		public static Offset<IOnCollisionCondition> CreateIOnCollisionCondition(FlatBufferBuilder builder, EBulletCreateCondition Type = EBulletCreateCondition.OnHit, long BulletId = 0L, Offset<ITriggerCountConfig> TriggerCountOffset = default(Offset<ITriggerCountConfig>))
		{
			builder.StartTable(3);
			IOnCollisionCondition.AddBulletId(builder, BulletId);
			IOnCollisionCondition.AddTriggerCount(builder, TriggerCountOffset);
			IOnCollisionCondition.AddType(builder, Type);
			return IOnCollisionCondition.EndIOnCollisionCondition(builder);
		}

		// Token: 0x06024FCE RID: 151502 RVA: 0x0051BD79 File Offset: 0x00519F79
		public static void StartIOnCollisionCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024FCF RID: 151503 RVA: 0x0051BD82 File Offset: 0x00519F82
		public static void AddType(FlatBufferBuilder builder, EBulletCreateCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024FD0 RID: 151504 RVA: 0x0051BD8D File Offset: 0x00519F8D
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x06024FD1 RID: 151505 RVA: 0x0051BD99 File Offset: 0x00519F99
		public static void AddTriggerCount(FlatBufferBuilder builder, Offset<ITriggerCountConfig> triggerCountOffset)
		{
			builder.AddOffset(2, triggerCountOffset.Value, 0);
		}

		// Token: 0x06024FD2 RID: 151506 RVA: 0x0051BDA9 File Offset: 0x00519FA9
		public static Offset<IOnCollisionCondition> EndIOnCollisionCondition(FlatBufferBuilder builder)
		{
			return new Offset<IOnCollisionCondition>(builder.EndTable());
		}

		// Token: 0x06024FD3 RID: 151507 RVA: 0x0051BDB8 File Offset: 0x00519FB8
		public IOnCollisionConditionT UnPack()
		{
			IOnCollisionConditionT onCollisionConditionT = new IOnCollisionConditionT();
			this.UnPackTo(onCollisionConditionT);
			return onCollisionConditionT;
		}

		// Token: 0x06024FD4 RID: 151508 RVA: 0x0051BDD4 File Offset: 0x00519FD4
		public void UnPackTo(IOnCollisionConditionT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
			_o.TriggerCount = ((this.TriggerCount != null) ? this.TriggerCount.Value.UnPack() : null);
		}

		// Token: 0x06024FD5 RID: 151509 RVA: 0x0051BE28 File Offset: 0x0051A028
		public static Offset<IOnCollisionCondition> Pack(FlatBufferBuilder builder, IOnCollisionConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnCollisionCondition>);
			}
			Offset<ITriggerCountConfig> triggerCountOffset = (_o.TriggerCount == null) ? default(Offset<ITriggerCountConfig>) : ITriggerCountConfig.Pack(builder, _o.TriggerCount);
			return IOnCollisionCondition.CreateIOnCollisionCondition(builder, _o.Type, _o.BulletId, triggerCountOffset);
		}

		// Token: 0x0400EAB5 RID: 60085
		private Table __p;
	}
}

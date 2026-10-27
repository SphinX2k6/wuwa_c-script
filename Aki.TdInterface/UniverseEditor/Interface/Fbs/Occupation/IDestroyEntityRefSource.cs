using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004398 RID: 17304
	public struct IDestroyEntityRefSource : IFlatbufferObject
	{
		// Token: 0x17007A4E RID: 31310
		// (get) Token: 0x06019BF3 RID: 105459 RVA: 0x003AFB05 File Offset: 0x003ADD05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019BF4 RID: 105460 RVA: 0x003AFB12 File Offset: 0x003ADD12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019BF5 RID: 105461 RVA: 0x003AFB1C File Offset: 0x003ADD1C
		public static IDestroyEntityRefSource GetRootAsIDestroyEntityRefSource(ByteBuffer _bb)
		{
			return IDestroyEntityRefSource.GetRootAsIDestroyEntityRefSource(_bb, default(IDestroyEntityRefSource));
		}

		// Token: 0x06019BF6 RID: 105462 RVA: 0x003AFB38 File Offset: 0x003ADD38
		public static IDestroyEntityRefSource GetRootAsIDestroyEntityRefSource(ByteBuffer _bb, IDestroyEntityRefSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019BF7 RID: 105463 RVA: 0x003AFB55 File Offset: 0x003ADD55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019BF8 RID: 105464 RVA: 0x003AFB64 File Offset: 0x003ADD64
		public IDestroyEntityRefSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A4F RID: 31311
		// (get) Token: 0x06019BF9 RID: 105465 RVA: 0x003AFB74 File Offset: 0x003ADD74
		public ERefSourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERefSourceType.AwakeEntity;
				}
				return (ERefSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007A50 RID: 31312
		// (get) Token: 0x06019BFA RID: 105466 RVA: 0x003AFBB0 File Offset: 0x003ADDB0
		public int EntityId
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

		// Token: 0x06019BFB RID: 105467 RVA: 0x003AFBEC File Offset: 0x003ADDEC
		public static Offset<IDestroyEntityRefSource> CreateIDestroyEntityRefSource(FlatBufferBuilder builder, ERefSourceType Type = ERefSourceType.AwakeEntity, int EntityId = 0)
		{
			builder.StartTable(2);
			IDestroyEntityRefSource.AddEntityId(builder, EntityId);
			IDestroyEntityRefSource.AddType(builder, Type);
			return IDestroyEntityRefSource.EndIDestroyEntityRefSource(builder);
		}

		// Token: 0x06019BFC RID: 105468 RVA: 0x003AFC09 File Offset: 0x003ADE09
		public static void StartIDestroyEntityRefSource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019BFD RID: 105469 RVA: 0x003AFC12 File Offset: 0x003ADE12
		public static void AddType(FlatBufferBuilder builder, ERefSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019BFE RID: 105470 RVA: 0x003AFC1D File Offset: 0x003ADE1D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06019BFF RID: 105471 RVA: 0x003AFC28 File Offset: 0x003ADE28
		public static Offset<IDestroyEntityRefSource> EndIDestroyEntityRefSource(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyEntityRefSource>(builder.EndTable());
		}

		// Token: 0x06019C00 RID: 105472 RVA: 0x003AFC38 File Offset: 0x003ADE38
		public IDestroyEntityRefSourceT UnPack()
		{
			IDestroyEntityRefSourceT destroyEntityRefSourceT = new IDestroyEntityRefSourceT();
			this.UnPackTo(destroyEntityRefSourceT);
			return destroyEntityRefSourceT;
		}

		// Token: 0x06019C01 RID: 105473 RVA: 0x003AFC53 File Offset: 0x003ADE53
		public void UnPackTo(IDestroyEntityRefSourceT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06019C02 RID: 105474 RVA: 0x003AFC70 File Offset: 0x003ADE70
		public static Offset<IDestroyEntityRefSource> Pack(FlatBufferBuilder builder, IDestroyEntityRefSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyEntityRefSource>);
			}
			return IDestroyEntityRefSource.CreateIDestroyEntityRefSource(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400C1CB RID: 49611
		private Table __p;
	}
}

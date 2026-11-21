using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047FA RID: 18426
	public struct IDestroyEntityRefSource : IFlatbufferObject
	{
		// Token: 0x17008083 RID: 32899
		// (get) Token: 0x0601B381 RID: 111489 RVA: 0x003DB52D File Offset: 0x003D972D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B382 RID: 111490 RVA: 0x003DB53A File Offset: 0x003D973A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B383 RID: 111491 RVA: 0x003DB544 File Offset: 0x003D9744
		public static IDestroyEntityRefSource GetRootAsIDestroyEntityRefSource(ByteBuffer _bb)
		{
			return IDestroyEntityRefSource.GetRootAsIDestroyEntityRefSource(_bb, default(IDestroyEntityRefSource));
		}

		// Token: 0x0601B384 RID: 111492 RVA: 0x003DB560 File Offset: 0x003D9760
		public static IDestroyEntityRefSource GetRootAsIDestroyEntityRefSource(ByteBuffer _bb, IDestroyEntityRefSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B385 RID: 111493 RVA: 0x003DB57D File Offset: 0x003D977D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B386 RID: 111494 RVA: 0x003DB58C File Offset: 0x003D978C
		public IDestroyEntityRefSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008084 RID: 32900
		// (get) Token: 0x0601B387 RID: 111495 RVA: 0x003DB59C File Offset: 0x003D979C
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

		// Token: 0x17008085 RID: 32901
		// (get) Token: 0x0601B388 RID: 111496 RVA: 0x003DB5D8 File Offset: 0x003D97D8
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

		// Token: 0x0601B389 RID: 111497 RVA: 0x003DB614 File Offset: 0x003D9814
		public static Offset<IDestroyEntityRefSource> CreateIDestroyEntityRefSource(FlatBufferBuilder builder, ERefSourceType Type = ERefSourceType.AwakeEntity, int EntityId = 0)
		{
			builder.StartTable(2);
			IDestroyEntityRefSource.AddEntityId(builder, EntityId);
			IDestroyEntityRefSource.AddType(builder, Type);
			return IDestroyEntityRefSource.EndIDestroyEntityRefSource(builder);
		}

		// Token: 0x0601B38A RID: 111498 RVA: 0x003DB631 File Offset: 0x003D9831
		public static void StartIDestroyEntityRefSource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B38B RID: 111499 RVA: 0x003DB63A File Offset: 0x003D983A
		public static void AddType(FlatBufferBuilder builder, ERefSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B38C RID: 111500 RVA: 0x003DB645 File Offset: 0x003D9845
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601B38D RID: 111501 RVA: 0x003DB650 File Offset: 0x003D9850
		public static Offset<IDestroyEntityRefSource> EndIDestroyEntityRefSource(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyEntityRefSource>(builder.EndTable());
		}

		// Token: 0x0601B38E RID: 111502 RVA: 0x003DB660 File Offset: 0x003D9860
		public IDestroyEntityRefSourceT UnPack()
		{
			IDestroyEntityRefSourceT destroyEntityRefSourceT = new IDestroyEntityRefSourceT();
			this.UnPackTo(destroyEntityRefSourceT);
			return destroyEntityRefSourceT;
		}

		// Token: 0x0601B38F RID: 111503 RVA: 0x003DB67B File Offset: 0x003D987B
		public void UnPackTo(IDestroyEntityRefSourceT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0601B390 RID: 111504 RVA: 0x003DB698 File Offset: 0x003D9898
		public static Offset<IDestroyEntityRefSource> Pack(FlatBufferBuilder builder, IDestroyEntityRefSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyEntityRefSource>);
			}
			return IDestroyEntityRefSource.CreateIDestroyEntityRefSource(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400CBEA RID: 52202
		private Table __p;
	}
}

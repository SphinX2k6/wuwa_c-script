using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047F4 RID: 18420
	public struct IAwakeEntityRefSource : IFlatbufferObject
	{
		// Token: 0x1700807B RID: 32891
		// (get) Token: 0x0601B359 RID: 111449 RVA: 0x003DB1B8 File Offset: 0x003D93B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B35A RID: 111450 RVA: 0x003DB1C5 File Offset: 0x003D93C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B35B RID: 111451 RVA: 0x003DB1CC File Offset: 0x003D93CC
		public static IAwakeEntityRefSource GetRootAsIAwakeEntityRefSource(ByteBuffer _bb)
		{
			return IAwakeEntityRefSource.GetRootAsIAwakeEntityRefSource(_bb, default(IAwakeEntityRefSource));
		}

		// Token: 0x0601B35C RID: 111452 RVA: 0x003DB1E8 File Offset: 0x003D93E8
		public static IAwakeEntityRefSource GetRootAsIAwakeEntityRefSource(ByteBuffer _bb, IAwakeEntityRefSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B35D RID: 111453 RVA: 0x003DB205 File Offset: 0x003D9405
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B35E RID: 111454 RVA: 0x003DB214 File Offset: 0x003D9414
		public IAwakeEntityRefSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700807C RID: 32892
		// (get) Token: 0x0601B35F RID: 111455 RVA: 0x003DB224 File Offset: 0x003D9424
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

		// Token: 0x1700807D RID: 32893
		// (get) Token: 0x0601B360 RID: 111456 RVA: 0x003DB260 File Offset: 0x003D9460
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

		// Token: 0x0601B361 RID: 111457 RVA: 0x003DB29C File Offset: 0x003D949C
		public static Offset<IAwakeEntityRefSource> CreateIAwakeEntityRefSource(FlatBufferBuilder builder, ERefSourceType Type = ERefSourceType.AwakeEntity, int EntityId = 0)
		{
			builder.StartTable(2);
			IAwakeEntityRefSource.AddEntityId(builder, EntityId);
			IAwakeEntityRefSource.AddType(builder, Type);
			return IAwakeEntityRefSource.EndIAwakeEntityRefSource(builder);
		}

		// Token: 0x0601B362 RID: 111458 RVA: 0x003DB2B9 File Offset: 0x003D94B9
		public static void StartIAwakeEntityRefSource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B363 RID: 111459 RVA: 0x003DB2C2 File Offset: 0x003D94C2
		public static void AddType(FlatBufferBuilder builder, ERefSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B364 RID: 111460 RVA: 0x003DB2CD File Offset: 0x003D94CD
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601B365 RID: 111461 RVA: 0x003DB2D8 File Offset: 0x003D94D8
		public static Offset<IAwakeEntityRefSource> EndIAwakeEntityRefSource(FlatBufferBuilder builder)
		{
			return new Offset<IAwakeEntityRefSource>(builder.EndTable());
		}

		// Token: 0x0601B366 RID: 111462 RVA: 0x003DB2E8 File Offset: 0x003D94E8
		public IAwakeEntityRefSourceT UnPack()
		{
			IAwakeEntityRefSourceT awakeEntityRefSourceT = new IAwakeEntityRefSourceT();
			this.UnPackTo(awakeEntityRefSourceT);
			return awakeEntityRefSourceT;
		}

		// Token: 0x0601B367 RID: 111463 RVA: 0x003DB303 File Offset: 0x003D9503
		public void UnPackTo(IAwakeEntityRefSourceT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0601B368 RID: 111464 RVA: 0x003DB320 File Offset: 0x003D9520
		public static Offset<IAwakeEntityRefSource> Pack(FlatBufferBuilder builder, IAwakeEntityRefSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAwakeEntityRefSource>);
			}
			return IAwakeEntityRefSource.CreateIAwakeEntityRefSource(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400CBE5 RID: 52197
		private Table __p;
	}
}

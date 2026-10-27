using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200552A RID: 21802
	public struct IMechascoutDragInstant : IFlatbufferObject
	{
		// Token: 0x1700A101 RID: 41217
		// (get) Token: 0x06024061 RID: 147553 RVA: 0x004FA535 File Offset: 0x004F8735
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024062 RID: 147554 RVA: 0x004FA542 File Offset: 0x004F8742
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024063 RID: 147555 RVA: 0x004FA54C File Offset: 0x004F874C
		public static IMechascoutDragInstant GetRootAsIMechascoutDragInstant(ByteBuffer _bb)
		{
			return IMechascoutDragInstant.GetRootAsIMechascoutDragInstant(_bb, default(IMechascoutDragInstant));
		}

		// Token: 0x06024064 RID: 147556 RVA: 0x004FA568 File Offset: 0x004F8768
		public static IMechascoutDragInstant GetRootAsIMechascoutDragInstant(ByteBuffer _bb, IMechascoutDragInstant obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024065 RID: 147557 RVA: 0x004FA585 File Offset: 0x004F8785
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024066 RID: 147558 RVA: 0x004FA594 File Offset: 0x004F8794
		public IMechascoutDragInstant __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A102 RID: 41218
		// (get) Token: 0x06024067 RID: 147559 RVA: 0x004FA5A4 File Offset: 0x004F87A4
		public EMechascoutDragType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechascoutDragType.Instant;
				}
				return (EMechascoutDragType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024068 RID: 147560 RVA: 0x004FA5E0 File Offset: 0x004F87E0
		public static Offset<IMechascoutDragInstant> CreateIMechascoutDragInstant(FlatBufferBuilder builder, EMechascoutDragType Type = EMechascoutDragType.Instant)
		{
			builder.StartTable(1);
			IMechascoutDragInstant.AddType(builder, Type);
			return IMechascoutDragInstant.EndIMechascoutDragInstant(builder);
		}

		// Token: 0x06024069 RID: 147561 RVA: 0x004FA5F6 File Offset: 0x004F87F6
		public static void StartIMechascoutDragInstant(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602406A RID: 147562 RVA: 0x004FA5FF File Offset: 0x004F87FF
		public static void AddType(FlatBufferBuilder builder, EMechascoutDragType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602406B RID: 147563 RVA: 0x004FA60A File Offset: 0x004F880A
		public static Offset<IMechascoutDragInstant> EndIMechascoutDragInstant(FlatBufferBuilder builder)
		{
			return new Offset<IMechascoutDragInstant>(builder.EndTable());
		}

		// Token: 0x0602406C RID: 147564 RVA: 0x004FA618 File Offset: 0x004F8818
		public IMechascoutDragInstantT UnPack()
		{
			IMechascoutDragInstantT mechascoutDragInstantT = new IMechascoutDragInstantT();
			this.UnPackTo(mechascoutDragInstantT);
			return mechascoutDragInstantT;
		}

		// Token: 0x0602406D RID: 147565 RVA: 0x004FA633 File Offset: 0x004F8833
		public void UnPackTo(IMechascoutDragInstantT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602406E RID: 147566 RVA: 0x004FA644 File Offset: 0x004F8844
		public static Offset<IMechascoutDragInstant> Pack(FlatBufferBuilder builder, IMechascoutDragInstantT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechascoutDragInstant>);
			}
			return IMechascoutDragInstant.CreateIMechascoutDragInstant(builder, _o.Type);
		}

		// Token: 0x0400E828 RID: 59432
		private Table __p;
	}
}

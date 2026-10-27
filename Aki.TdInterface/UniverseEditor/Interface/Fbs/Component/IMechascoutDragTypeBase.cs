using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005530 RID: 21808
	public struct IMechascoutDragTypeBase : IFlatbufferObject
	{
		// Token: 0x1700A109 RID: 41225
		// (get) Token: 0x06024089 RID: 147593 RVA: 0x004FA8BE File Offset: 0x004F8ABE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602408A RID: 147594 RVA: 0x004FA8CB File Offset: 0x004F8ACB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602408B RID: 147595 RVA: 0x004FA8D4 File Offset: 0x004F8AD4
		public static IMechascoutDragTypeBase GetRootAsIMechascoutDragTypeBase(ByteBuffer _bb)
		{
			return IMechascoutDragTypeBase.GetRootAsIMechascoutDragTypeBase(_bb, default(IMechascoutDragTypeBase));
		}

		// Token: 0x0602408C RID: 147596 RVA: 0x004FA8F0 File Offset: 0x004F8AF0
		public static IMechascoutDragTypeBase GetRootAsIMechascoutDragTypeBase(ByteBuffer _bb, IMechascoutDragTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602408D RID: 147597 RVA: 0x004FA90D File Offset: 0x004F8B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602408E RID: 147598 RVA: 0x004FA91C File Offset: 0x004F8B1C
		public IMechascoutDragTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A10A RID: 41226
		// (get) Token: 0x0602408F RID: 147599 RVA: 0x004FA92C File Offset: 0x004F8B2C
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

		// Token: 0x06024090 RID: 147600 RVA: 0x004FA968 File Offset: 0x004F8B68
		public static Offset<IMechascoutDragTypeBase> CreateIMechascoutDragTypeBase(FlatBufferBuilder builder, EMechascoutDragType Type = EMechascoutDragType.Instant)
		{
			builder.StartTable(1);
			IMechascoutDragTypeBase.AddType(builder, Type);
			return IMechascoutDragTypeBase.EndIMechascoutDragTypeBase(builder);
		}

		// Token: 0x06024091 RID: 147601 RVA: 0x004FA97E File Offset: 0x004F8B7E
		public static void StartIMechascoutDragTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024092 RID: 147602 RVA: 0x004FA987 File Offset: 0x004F8B87
		public static void AddType(FlatBufferBuilder builder, EMechascoutDragType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024093 RID: 147603 RVA: 0x004FA992 File Offset: 0x004F8B92
		public static Offset<IMechascoutDragTypeBase> EndIMechascoutDragTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IMechascoutDragTypeBase>(builder.EndTable());
		}

		// Token: 0x06024094 RID: 147604 RVA: 0x004FA9A0 File Offset: 0x004F8BA0
		public IMechascoutDragTypeBaseT UnPack()
		{
			IMechascoutDragTypeBaseT mechascoutDragTypeBaseT = new IMechascoutDragTypeBaseT();
			this.UnPackTo(mechascoutDragTypeBaseT);
			return mechascoutDragTypeBaseT;
		}

		// Token: 0x06024095 RID: 147605 RVA: 0x004FA9BB File Offset: 0x004F8BBB
		public void UnPackTo(IMechascoutDragTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024096 RID: 147606 RVA: 0x004FA9CC File Offset: 0x004F8BCC
		public static Offset<IMechascoutDragTypeBase> Pack(FlatBufferBuilder builder, IMechascoutDragTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechascoutDragTypeBase>);
			}
			return IMechascoutDragTypeBase.CreateIMechascoutDragTypeBase(builder, _o.Type);
		}

		// Token: 0x0400E82D RID: 59437
		private Table __p;
	}
}

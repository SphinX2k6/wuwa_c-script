using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F8 RID: 29944
	public struct IPostAkEventType : IFlatbufferObject
	{
		// Token: 0x1700DC6D RID: 56429
		// (get) Token: 0x06034832 RID: 215090 RVA: 0x00711B8E File Offset: 0x0070FD8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034833 RID: 215091 RVA: 0x00711B9B File Offset: 0x0070FD9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034834 RID: 215092 RVA: 0x00711BA4 File Offset: 0x0070FDA4
		public static IPostAkEventType GetRootAsIPostAkEventType(ByteBuffer _bb)
		{
			return IPostAkEventType.GetRootAsIPostAkEventType(_bb, default(IPostAkEventType));
		}

		// Token: 0x06034835 RID: 215093 RVA: 0x00711BC0 File Offset: 0x0070FDC0
		public static IPostAkEventType GetRootAsIPostAkEventType(ByteBuffer _bb, IPostAkEventType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034836 RID: 215094 RVA: 0x00711BDD File Offset: 0x0070FDDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034837 RID: 215095 RVA: 0x00711BEC File Offset: 0x0070FDEC
		public IPostAkEventType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC6E RID: 56430
		// (get) Token: 0x06034838 RID: 215096 RVA: 0x00711BFC File Offset: 0x0070FDFC
		public EPostAkEvent Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPostAkEvent.Global;
				}
				return (EPostAkEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034839 RID: 215097 RVA: 0x00711C38 File Offset: 0x0070FE38
		public static Offset<IPostAkEventType> CreateIPostAkEventType(FlatBufferBuilder builder, EPostAkEvent Type = EPostAkEvent.Global)
		{
			builder.StartTable(1);
			IPostAkEventType.AddType(builder, Type);
			return IPostAkEventType.EndIPostAkEventType(builder);
		}

		// Token: 0x0603483A RID: 215098 RVA: 0x00711C4E File Offset: 0x0070FE4E
		public static void StartIPostAkEventType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603483B RID: 215099 RVA: 0x00711C57 File Offset: 0x0070FE57
		public static void AddType(FlatBufferBuilder builder, EPostAkEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603483C RID: 215100 RVA: 0x00711C62 File Offset: 0x0070FE62
		public static Offset<IPostAkEventType> EndIPostAkEventType(FlatBufferBuilder builder)
		{
			return new Offset<IPostAkEventType>(builder.EndTable());
		}

		// Token: 0x0603483D RID: 215101 RVA: 0x00711C70 File Offset: 0x0070FE70
		public IPostAkEventTypeT UnPack()
		{
			IPostAkEventTypeT postAkEventTypeT = new IPostAkEventTypeT();
			this.UnPackTo(postAkEventTypeT);
			return postAkEventTypeT;
		}

		// Token: 0x0603483E RID: 215102 RVA: 0x00711C8B File Offset: 0x0070FE8B
		public void UnPackTo(IPostAkEventTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603483F RID: 215103 RVA: 0x00711C9C File Offset: 0x0070FE9C
		public static Offset<IPostAkEventType> Pack(FlatBufferBuilder builder, IPostAkEventTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPostAkEventType>);
			}
			return IPostAkEventType.CreateIPostAkEventType(builder, _o.Type);
		}

		// Token: 0x040126C2 RID: 75458
		private Table __p;
	}
}

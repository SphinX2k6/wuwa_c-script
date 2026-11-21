using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C11 RID: 31761
	public struct IToolEditorActionContext : IFlatbufferObject
	{
		// Token: 0x1700EDD2 RID: 60882
		// (get) Token: 0x060393DC RID: 234460 RVA: 0x007BB532 File Offset: 0x007B9732
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060393DD RID: 234461 RVA: 0x007BB53F File Offset: 0x007B973F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060393DE RID: 234462 RVA: 0x007BB548 File Offset: 0x007B9748
		public static IToolEditorActionContext GetRootAsIToolEditorActionContext(ByteBuffer _bb)
		{
			return IToolEditorActionContext.GetRootAsIToolEditorActionContext(_bb, default(IToolEditorActionContext));
		}

		// Token: 0x060393DF RID: 234463 RVA: 0x007BB564 File Offset: 0x007B9764
		public static IToolEditorActionContext GetRootAsIToolEditorActionContext(ByteBuffer _bb, IToolEditorActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060393E0 RID: 234464 RVA: 0x007BB581 File Offset: 0x007B9781
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060393E1 RID: 234465 RVA: 0x007BB590 File Offset: 0x007B9790
		public IToolEditorActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDD3 RID: 60883
		// (get) Token: 0x060393E2 RID: 234466 RVA: 0x007BB5A0 File Offset: 0x007B97A0
		public string Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060393E3 RID: 234467 RVA: 0x007BB5D7 File Offset: 0x007B97D7
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060393E4 RID: 234468 RVA: 0x007BB5E6 File Offset: 0x007B97E6
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060393E5 RID: 234469 RVA: 0x007BB5F4 File Offset: 0x007B97F4
		public static Offset<IToolEditorActionContext> CreateIToolEditorActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IToolEditorActionContext.AddType(builder, TypeOffset);
			return IToolEditorActionContext.EndIToolEditorActionContext(builder);
		}

		// Token: 0x060393E6 RID: 234470 RVA: 0x007BB60A File Offset: 0x007B980A
		public static void StartIToolEditorActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060393E7 RID: 234471 RVA: 0x007BB613 File Offset: 0x007B9813
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x060393E8 RID: 234472 RVA: 0x007BB623 File Offset: 0x007B9823
		public static Offset<IToolEditorActionContext> EndIToolEditorActionContext(FlatBufferBuilder builder)
		{
			return new Offset<IToolEditorActionContext>(builder.EndTable());
		}

		// Token: 0x060393E9 RID: 234473 RVA: 0x007BB630 File Offset: 0x007B9830
		public IToolEditorActionContextT UnPack()
		{
			IToolEditorActionContextT toolEditorActionContextT = new IToolEditorActionContextT();
			this.UnPackTo(toolEditorActionContextT);
			return toolEditorActionContextT;
		}

		// Token: 0x060393EA RID: 234474 RVA: 0x007BB64B File Offset: 0x007B984B
		public void UnPackTo(IToolEditorActionContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060393EB RID: 234475 RVA: 0x007BB65C File Offset: 0x007B985C
		public static Offset<IToolEditorActionContext> Pack(FlatBufferBuilder builder, IToolEditorActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToolEditorActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return IToolEditorActionContext.CreateIToolEditorActionContext(builder, typeOffset);
		}

		// Token: 0x040132BB RID: 78523
		private Table __p;
	}
}

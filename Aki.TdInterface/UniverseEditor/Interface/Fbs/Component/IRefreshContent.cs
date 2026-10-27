using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005820 RID: 22560
	public struct IRefreshContent : IFlatbufferObject
	{
		// Token: 0x1700A882 RID: 43138
		// (get) Token: 0x06025EEE RID: 155374 RVA: 0x0053AFA4 File Offset: 0x005391A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025EEF RID: 155375 RVA: 0x0053AFB1 File Offset: 0x005391B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025EF0 RID: 155376 RVA: 0x0053AFB8 File Offset: 0x005391B8
		public static IRefreshContent GetRootAsIRefreshContent(ByteBuffer _bb)
		{
			return IRefreshContent.GetRootAsIRefreshContent(_bb, default(IRefreshContent));
		}

		// Token: 0x06025EF1 RID: 155377 RVA: 0x0053AFD4 File Offset: 0x005391D4
		public static IRefreshContent GetRootAsIRefreshContent(ByteBuffer _bb, IRefreshContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025EF2 RID: 155378 RVA: 0x0053AFF1 File Offset: 0x005391F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025EF3 RID: 155379 RVA: 0x0053B000 File Offset: 0x00539200
		public IRefreshContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A883 RID: 43139
		// (get) Token: 0x06025EF4 RID: 155380 RVA: 0x0053B010 File Offset: 0x00539210
		public ERefreshContent Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERefreshContent.All;
				}
				return (ERefreshContent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025EF5 RID: 155381 RVA: 0x0053B04C File Offset: 0x0053924C
		public static Offset<IRefreshContent> CreateIRefreshContent(FlatBufferBuilder builder, ERefreshContent Type = ERefreshContent.All)
		{
			builder.StartTable(1);
			IRefreshContent.AddType(builder, Type);
			return IRefreshContent.EndIRefreshContent(builder);
		}

		// Token: 0x06025EF6 RID: 155382 RVA: 0x0053B062 File Offset: 0x00539262
		public static void StartIRefreshContent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025EF7 RID: 155383 RVA: 0x0053B06B File Offset: 0x0053926B
		public static void AddType(FlatBufferBuilder builder, ERefreshContent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025EF8 RID: 155384 RVA: 0x0053B076 File Offset: 0x00539276
		public static Offset<IRefreshContent> EndIRefreshContent(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshContent>(builder.EndTable());
		}

		// Token: 0x06025EF9 RID: 155385 RVA: 0x0053B084 File Offset: 0x00539284
		public IRefreshContentT UnPack()
		{
			IRefreshContentT refreshContentT = new IRefreshContentT();
			this.UnPackTo(refreshContentT);
			return refreshContentT;
		}

		// Token: 0x06025EFA RID: 155386 RVA: 0x0053B09F File Offset: 0x0053929F
		public void UnPackTo(IRefreshContentT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025EFB RID: 155387 RVA: 0x0053B0B0 File Offset: 0x005392B0
		public static Offset<IRefreshContent> Pack(FlatBufferBuilder builder, IRefreshContentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshContent>);
			}
			return IRefreshContent.CreateIRefreshContent(builder, _o.Type);
		}

		// Token: 0x0400ED28 RID: 60712
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E27 RID: 24103
	public struct IRefreshContent : IFlatbufferObject
	{
		// Token: 0x1700B1A6 RID: 45478
		// (get) Token: 0x0602840E RID: 164878 RVA: 0x00581130 File Offset: 0x0057F330
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602840F RID: 164879 RVA: 0x0058113D File Offset: 0x0057F33D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028410 RID: 164880 RVA: 0x00581144 File Offset: 0x0057F344
		public static IRefreshContent GetRootAsIRefreshContent(ByteBuffer _bb)
		{
			return IRefreshContent.GetRootAsIRefreshContent(_bb, default(IRefreshContent));
		}

		// Token: 0x06028411 RID: 164881 RVA: 0x00581160 File Offset: 0x0057F360
		public static IRefreshContent GetRootAsIRefreshContent(ByteBuffer _bb, IRefreshContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028412 RID: 164882 RVA: 0x0058117D File Offset: 0x0057F37D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028413 RID: 164883 RVA: 0x0058118C File Offset: 0x0057F38C
		public IRefreshContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1A7 RID: 45479
		// (get) Token: 0x06028414 RID: 164884 RVA: 0x0058119C File Offset: 0x0057F39C
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

		// Token: 0x06028415 RID: 164885 RVA: 0x005811D8 File Offset: 0x0057F3D8
		public static Offset<IRefreshContent> CreateIRefreshContent(FlatBufferBuilder builder, ERefreshContent Type = ERefreshContent.All)
		{
			builder.StartTable(1);
			IRefreshContent.AddType(builder, Type);
			return IRefreshContent.EndIRefreshContent(builder);
		}

		// Token: 0x06028416 RID: 164886 RVA: 0x005811EE File Offset: 0x0057F3EE
		public static void StartIRefreshContent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028417 RID: 164887 RVA: 0x005811F7 File Offset: 0x0057F3F7
		public static void AddType(FlatBufferBuilder builder, ERefreshContent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028418 RID: 164888 RVA: 0x00581202 File Offset: 0x0057F402
		public static Offset<IRefreshContent> EndIRefreshContent(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshContent>(builder.EndTable());
		}

		// Token: 0x06028419 RID: 164889 RVA: 0x00581210 File Offset: 0x0057F410
		public IRefreshContentT UnPack()
		{
			IRefreshContentT refreshContentT = new IRefreshContentT();
			this.UnPackTo(refreshContentT);
			return refreshContentT;
		}

		// Token: 0x0602841A RID: 164890 RVA: 0x0058122B File Offset: 0x0057F42B
		public void UnPackTo(IRefreshContentT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602841B RID: 164891 RVA: 0x0058123C File Offset: 0x0057F43C
		public static Offset<IRefreshContent> Pack(FlatBufferBuilder builder, IRefreshContentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshContent>);
			}
			return IRefreshContent.CreateIRefreshContent(builder, _o.Type);
		}

		// Token: 0x0400FA13 RID: 64019
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C41 RID: 31809
	public struct ITransitionPopupStyle : IFlatbufferObject
	{
		// Token: 0x1700EE2A RID: 60970
		// (get) Token: 0x06039564 RID: 234852 RVA: 0x007BE0E9 File Offset: 0x007BC2E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039565 RID: 234853 RVA: 0x007BE0F6 File Offset: 0x007BC2F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039566 RID: 234854 RVA: 0x007BE100 File Offset: 0x007BC300
		public static ITransitionPopupStyle GetRootAsITransitionPopupStyle(ByteBuffer _bb)
		{
			return ITransitionPopupStyle.GetRootAsITransitionPopupStyle(_bb, default(ITransitionPopupStyle));
		}

		// Token: 0x06039567 RID: 234855 RVA: 0x007BE11C File Offset: 0x007BC31C
		public static ITransitionPopupStyle GetRootAsITransitionPopupStyle(ByteBuffer _bb, ITransitionPopupStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039568 RID: 234856 RVA: 0x007BE139 File Offset: 0x007BC339
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039569 RID: 234857 RVA: 0x007BE148 File Offset: 0x007BC348
		public ITransitionPopupStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE2B RID: 60971
		// (get) Token: 0x0603956A RID: 234858 RVA: 0x007BE158 File Offset: 0x007BC358
		public ETransitionPopupStyleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETransitionPopupStyleType.LeftTopTip;
				}
				return (ETransitionPopupStyleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603956B RID: 234859 RVA: 0x007BE194 File Offset: 0x007BC394
		public static Offset<ITransitionPopupStyle> CreateITransitionPopupStyle(FlatBufferBuilder builder, ETransitionPopupStyleType Type = ETransitionPopupStyleType.LeftTopTip)
		{
			builder.StartTable(1);
			ITransitionPopupStyle.AddType(builder, Type);
			return ITransitionPopupStyle.EndITransitionPopupStyle(builder);
		}

		// Token: 0x0603956C RID: 234860 RVA: 0x007BE1AA File Offset: 0x007BC3AA
		public static void StartITransitionPopupStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603956D RID: 234861 RVA: 0x007BE1B3 File Offset: 0x007BC3B3
		public static void AddType(FlatBufferBuilder builder, ETransitionPopupStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603956E RID: 234862 RVA: 0x007BE1BE File Offset: 0x007BC3BE
		public static Offset<ITransitionPopupStyle> EndITransitionPopupStyle(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupStyle>(builder.EndTable());
		}

		// Token: 0x0603956F RID: 234863 RVA: 0x007BE1CC File Offset: 0x007BC3CC
		public ITransitionPopupStyleT UnPack()
		{
			ITransitionPopupStyleT transitionPopupStyleT = new ITransitionPopupStyleT();
			this.UnPackTo(transitionPopupStyleT);
			return transitionPopupStyleT;
		}

		// Token: 0x06039570 RID: 234864 RVA: 0x007BE1E7 File Offset: 0x007BC3E7
		public void UnPackTo(ITransitionPopupStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039571 RID: 234865 RVA: 0x007BE1F8 File Offset: 0x007BC3F8
		public static Offset<ITransitionPopupStyle> Pack(FlatBufferBuilder builder, ITransitionPopupStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITransitionPopupStyle>);
			}
			return ITransitionPopupStyle.CreateITransitionPopupStyle(builder, _o.Type);
		}

		// Token: 0x040132F9 RID: 78585
		private Table __p;
	}
}

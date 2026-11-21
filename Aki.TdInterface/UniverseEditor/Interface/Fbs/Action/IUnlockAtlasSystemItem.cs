using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CB9 RID: 31929
	public struct IUnlockAtlasSystemItem : IFlatbufferObject
	{
		// Token: 0x1700EF09 RID: 61193
		// (get) Token: 0x0603998E RID: 235918 RVA: 0x007C59C2 File Offset: 0x007C3BC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603998F RID: 235919 RVA: 0x007C59CF File Offset: 0x007C3BCF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039990 RID: 235920 RVA: 0x007C59D8 File Offset: 0x007C3BD8
		public static IUnlockAtlasSystemItem GetRootAsIUnlockAtlasSystemItem(ByteBuffer _bb)
		{
			return IUnlockAtlasSystemItem.GetRootAsIUnlockAtlasSystemItem(_bb, default(IUnlockAtlasSystemItem));
		}

		// Token: 0x06039991 RID: 235921 RVA: 0x007C59F4 File Offset: 0x007C3BF4
		public static IUnlockAtlasSystemItem GetRootAsIUnlockAtlasSystemItem(ByteBuffer _bb, IUnlockAtlasSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039992 RID: 235922 RVA: 0x007C5A11 File Offset: 0x007C3C11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039993 RID: 235923 RVA: 0x007C5A20 File Offset: 0x007C3C20
		public IUnlockAtlasSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF0A RID: 61194
		// (get) Token: 0x06039994 RID: 235924 RVA: 0x007C5A30 File Offset: 0x007C3C30
		public EUnlockSystemItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUnlockSystemItemType.CookSystem;
				}
				return (EUnlockSystemItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EF0B RID: 61195
		// (get) Token: 0x06039995 RID: 235925 RVA: 0x007C5A6C File Offset: 0x007C3C6C
		public TUnlockAtlasSystemOptionV2 UnlockOptionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TUnlockAtlasSystemOptionV2.NONE;
				}
				return (TUnlockAtlasSystemOptionV2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039996 RID: 235926 RVA: 0x007C5AA8 File Offset: 0x007C3CA8
		public TTable? UnlockOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039997 RID: 235927 RVA: 0x007C5AEC File Offset: 0x007C3CEC
		public IUnlockGeographicalAtlasV2 UnlockOptionAsIUnlockGeographicalAtlasV2()
		{
			return this.UnlockOption<IUnlockGeographicalAtlasV2>().Value;
		}

		// Token: 0x06039998 RID: 235928 RVA: 0x007C5B08 File Offset: 0x007C3D08
		public IUnlockNounAtlasV2 UnlockOptionAsIUnlockNounAtlasV2()
		{
			return this.UnlockOption<IUnlockNounAtlasV2>().Value;
		}

		// Token: 0x06039999 RID: 235929 RVA: 0x007C5B24 File Offset: 0x007C3D24
		public IUnlockPanoramaAtlasV2 UnlockOptionAsIUnlockPanoramaAtlasV2()
		{
			return this.UnlockOption<IUnlockPanoramaAtlasV2>().Value;
		}

		// Token: 0x0603999A RID: 235930 RVA: 0x007C5B40 File Offset: 0x007C3D40
		public IUnlockPlotPhotoAtlasV2 UnlockOptionAsIUnlockPlotPhotoAtlasV2()
		{
			return this.UnlockOption<IUnlockPlotPhotoAtlasV2>().Value;
		}

		// Token: 0x0603999B RID: 235931 RVA: 0x007C5B5B File Offset: 0x007C3D5B
		public static Offset<IUnlockAtlasSystemItem> CreateIUnlockAtlasSystemItem(FlatBufferBuilder builder, EUnlockSystemItemType Type = EUnlockSystemItemType.CookSystem, TUnlockAtlasSystemOptionV2 UnlockOption_type = TUnlockAtlasSystemOptionV2.NONE, int UnlockOptionOffset = 0)
		{
			builder.StartTable(3);
			IUnlockAtlasSystemItem.AddUnlockOption(builder, UnlockOptionOffset);
			IUnlockAtlasSystemItem.AddUnlockOptionType(builder, UnlockOption_type);
			IUnlockAtlasSystemItem.AddType(builder, Type);
			return IUnlockAtlasSystemItem.EndIUnlockAtlasSystemItem(builder);
		}

		// Token: 0x0603999C RID: 235932 RVA: 0x007C5B7F File Offset: 0x007C3D7F
		public static void StartIUnlockAtlasSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603999D RID: 235933 RVA: 0x007C5B88 File Offset: 0x007C3D88
		public static void AddType(FlatBufferBuilder builder, EUnlockSystemItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603999E RID: 235934 RVA: 0x007C5B93 File Offset: 0x007C3D93
		public static void AddUnlockOptionType(FlatBufferBuilder builder, TUnlockAtlasSystemOptionV2 unlockOptionType)
		{
			builder.AddByte(1, (byte)unlockOptionType, 0);
		}

		// Token: 0x0603999F RID: 235935 RVA: 0x007C5B9E File Offset: 0x007C3D9E
		public static void AddUnlockOption(FlatBufferBuilder builder, int unlockOptionOffset)
		{
			builder.AddOffset(2, unlockOptionOffset, 0);
		}

		// Token: 0x060399A0 RID: 235936 RVA: 0x007C5BA9 File Offset: 0x007C3DA9
		public static Offset<IUnlockAtlasSystemItem> EndIUnlockAtlasSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockAtlasSystemItem>(builder.EndTable());
		}

		// Token: 0x060399A1 RID: 235937 RVA: 0x007C5BB8 File Offset: 0x007C3DB8
		public IUnlockAtlasSystemItemT UnPack()
		{
			IUnlockAtlasSystemItemT unlockAtlasSystemItemT = new IUnlockAtlasSystemItemT();
			this.UnPackTo(unlockAtlasSystemItemT);
			return unlockAtlasSystemItemT;
		}

		// Token: 0x060399A2 RID: 235938 RVA: 0x007C5BD4 File Offset: 0x007C3DD4
		public void UnPackTo(IUnlockAtlasSystemItemT _o)
		{
			_o.Type = this.Type;
			_o.UnlockOption = new TUnlockAtlasSystemOptionV2Union();
			_o.UnlockOption.Type = this.UnlockOptionType;
			switch (this.UnlockOptionType)
			{
			case TUnlockAtlasSystemOptionV2.IUnlockGeographicalAtlasV2:
				_o.UnlockOption.Value = ((this.UnlockOption<IUnlockGeographicalAtlasV2>() != null) ? this.UnlockOption<IUnlockGeographicalAtlasV2>().Value.UnPack() : null);
				return;
			case TUnlockAtlasSystemOptionV2.IUnlockNounAtlasV2:
				_o.UnlockOption.Value = ((this.UnlockOption<IUnlockNounAtlasV2>() != null) ? this.UnlockOption<IUnlockNounAtlasV2>().Value.UnPack() : null);
				return;
			case TUnlockAtlasSystemOptionV2.IUnlockPanoramaAtlasV2:
				_o.UnlockOption.Value = ((this.UnlockOption<IUnlockPanoramaAtlasV2>() != null) ? this.UnlockOption<IUnlockPanoramaAtlasV2>().Value.UnPack() : null);
				return;
			case TUnlockAtlasSystemOptionV2.IUnlockPlotPhotoAtlasV2:
				_o.UnlockOption.Value = ((this.UnlockOption<IUnlockPlotPhotoAtlasV2>() != null) ? this.UnlockOption<IUnlockPlotPhotoAtlasV2>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060399A3 RID: 235939 RVA: 0x007C5D04 File Offset: 0x007C3F04
		public static Offset<IUnlockAtlasSystemItem> Pack(FlatBufferBuilder builder, IUnlockAtlasSystemItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockAtlasSystemItem>);
			}
			TUnlockAtlasSystemOptionV2 unlockOption_type = (_o.UnlockOption == null) ? TUnlockAtlasSystemOptionV2.NONE : _o.UnlockOption.Type;
			int unlockOptionOffset = (_o.UnlockOption == null) ? 0 : TUnlockAtlasSystemOptionV2Union.Pack(builder, _o.UnlockOption);
			return IUnlockAtlasSystemItem.CreateIUnlockAtlasSystemItem(builder, _o.Type, unlockOption_type, unlockOptionOffset);
		}

		// Token: 0x040133BC RID: 78780
		private Table __p;
	}
}

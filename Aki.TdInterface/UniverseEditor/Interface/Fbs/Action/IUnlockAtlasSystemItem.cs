using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C3 RID: 29891
	public struct IUnlockAtlasSystemItem : IFlatbufferObject
	{
		// Token: 0x1700E2DF RID: 58079
		// (get) Token: 0x06036579 RID: 222585 RVA: 0x00762772 File Offset: 0x00760972
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603657A RID: 222586 RVA: 0x0076277F File Offset: 0x0076097F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603657B RID: 222587 RVA: 0x00762788 File Offset: 0x00760988
		public static IUnlockAtlasSystemItem GetRootAsIUnlockAtlasSystemItem(ByteBuffer _bb)
		{
			return IUnlockAtlasSystemItem.GetRootAsIUnlockAtlasSystemItem(_bb, default(IUnlockAtlasSystemItem));
		}

		// Token: 0x0603657C RID: 222588 RVA: 0x007627A4 File Offset: 0x007609A4
		public static IUnlockAtlasSystemItem GetRootAsIUnlockAtlasSystemItem(ByteBuffer _bb, IUnlockAtlasSystemItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603657D RID: 222589 RVA: 0x007627C1 File Offset: 0x007609C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603657E RID: 222590 RVA: 0x007627D0 File Offset: 0x007609D0
		public IUnlockAtlasSystemItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2E0 RID: 58080
		// (get) Token: 0x0603657F RID: 222591 RVA: 0x007627E0 File Offset: 0x007609E0
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

		// Token: 0x1700E2E1 RID: 58081
		// (get) Token: 0x06036580 RID: 222592 RVA: 0x0076281C File Offset: 0x00760A1C
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

		// Token: 0x06036581 RID: 222593 RVA: 0x00762858 File Offset: 0x00760A58
		public TTable? UnlockOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036582 RID: 222594 RVA: 0x0076289C File Offset: 0x00760A9C
		public IUnlockGeographicalAtlasV2 UnlockOptionAsIUnlockGeographicalAtlasV2()
		{
			return this.UnlockOption<IUnlockGeographicalAtlasV2>().Value;
		}

		// Token: 0x06036583 RID: 222595 RVA: 0x007628B8 File Offset: 0x00760AB8
		public IUnlockNounAtlasV2 UnlockOptionAsIUnlockNounAtlasV2()
		{
			return this.UnlockOption<IUnlockNounAtlasV2>().Value;
		}

		// Token: 0x06036584 RID: 222596 RVA: 0x007628D4 File Offset: 0x00760AD4
		public IUnlockPanoramaAtlasV2 UnlockOptionAsIUnlockPanoramaAtlasV2()
		{
			return this.UnlockOption<IUnlockPanoramaAtlasV2>().Value;
		}

		// Token: 0x06036585 RID: 222597 RVA: 0x007628F0 File Offset: 0x00760AF0
		public IUnlockPlotPhotoAtlasV2 UnlockOptionAsIUnlockPlotPhotoAtlasV2()
		{
			return this.UnlockOption<IUnlockPlotPhotoAtlasV2>().Value;
		}

		// Token: 0x06036586 RID: 222598 RVA: 0x0076290B File Offset: 0x00760B0B
		public static Offset<IUnlockAtlasSystemItem> CreateIUnlockAtlasSystemItem(FlatBufferBuilder builder, EUnlockSystemItemType Type = EUnlockSystemItemType.CookSystem, TUnlockAtlasSystemOptionV2 UnlockOption_type = TUnlockAtlasSystemOptionV2.NONE, int UnlockOptionOffset = 0)
		{
			builder.StartTable(3);
			IUnlockAtlasSystemItem.AddUnlockOption(builder, UnlockOptionOffset);
			IUnlockAtlasSystemItem.AddUnlockOptionType(builder, UnlockOption_type);
			IUnlockAtlasSystemItem.AddType(builder, Type);
			return IUnlockAtlasSystemItem.EndIUnlockAtlasSystemItem(builder);
		}

		// Token: 0x06036587 RID: 222599 RVA: 0x0076292F File Offset: 0x00760B2F
		public static void StartIUnlockAtlasSystemItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036588 RID: 222600 RVA: 0x00762938 File Offset: 0x00760B38
		public static void AddType(FlatBufferBuilder builder, EUnlockSystemItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036589 RID: 222601 RVA: 0x00762943 File Offset: 0x00760B43
		public static void AddUnlockOptionType(FlatBufferBuilder builder, TUnlockAtlasSystemOptionV2 unlockOptionType)
		{
			builder.AddByte(1, (byte)unlockOptionType, 0);
		}

		// Token: 0x0603658A RID: 222602 RVA: 0x0076294E File Offset: 0x00760B4E
		public static void AddUnlockOption(FlatBufferBuilder builder, int unlockOptionOffset)
		{
			builder.AddOffset(2, unlockOptionOffset, 0);
		}

		// Token: 0x0603658B RID: 222603 RVA: 0x00762959 File Offset: 0x00760B59
		public static Offset<IUnlockAtlasSystemItem> EndIUnlockAtlasSystemItem(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockAtlasSystemItem>(builder.EndTable());
		}

		// Token: 0x0603658C RID: 222604 RVA: 0x00762968 File Offset: 0x00760B68
		public IUnlockAtlasSystemItemT UnPack()
		{
			IUnlockAtlasSystemItemT unlockAtlasSystemItemT = new IUnlockAtlasSystemItemT();
			this.UnPackTo(unlockAtlasSystemItemT);
			return unlockAtlasSystemItemT;
		}

		// Token: 0x0603658D RID: 222605 RVA: 0x00762984 File Offset: 0x00760B84
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

		// Token: 0x0603658E RID: 222606 RVA: 0x00762AB4 File Offset: 0x00760CB4
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

		// Token: 0x0401238B RID: 74635
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EAA RID: 32426
	public class TCustomScreenUnion
	{
		// Token: 0x1700F23F RID: 62015
		// (get) Token: 0x0603A8B5 RID: 239797 RVA: 0x007E11C0 File Offset: 0x007DF3C0
		// (set) Token: 0x0603A8B6 RID: 239798 RVA: 0x007E11C8 File Offset: 0x007DF3C8
		public TCustomScreen Type { get; set; }

		// Token: 0x1700F240 RID: 62016
		// (get) Token: 0x0603A8B7 RID: 239799 RVA: 0x007E11D1 File Offset: 0x007DF3D1
		// (set) Token: 0x0603A8B8 RID: 239800 RVA: 0x007E11D9 File Offset: 0x007DF3D9
		public object Value { get; set; }

		// Token: 0x0603A8B9 RID: 239801 RVA: 0x007E11E2 File Offset: 0x007DF3E2
		public TCustomScreenUnion()
		{
			this.Type = TCustomScreen.NONE;
			this.Value = null;
		}

		// Token: 0x0603A8BA RID: 239802 RVA: 0x007E11F8 File Offset: 0x007DF3F8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A8BB RID: 239803 RVA: 0x007E120A File Offset: 0x007DF40A
		public ICustomScreenBackgroundImageT AsICustomScreenBackgroundImage()
		{
			return this.As<ICustomScreenBackgroundImageT>();
		}

		// Token: 0x0603A8BC RID: 239804 RVA: 0x007E1212 File Offset: 0x007DF412
		public static TCustomScreenUnion FromICustomScreenBackgroundImage(ICustomScreenBackgroundImageT _icustomscreenbackgroundimage)
		{
			return new TCustomScreenUnion
			{
				Type = TCustomScreen.ICustomScreenBackgroundImage,
				Value = _icustomscreenbackgroundimage
			};
		}

		// Token: 0x0603A8BD RID: 239805 RVA: 0x007E1227 File Offset: 0x007DF427
		public ICustomScreenLoadingT AsICustomScreenLoading()
		{
			return this.As<ICustomScreenLoadingT>();
		}

		// Token: 0x0603A8BE RID: 239806 RVA: 0x007E122F File Offset: 0x007DF42F
		public static TCustomScreenUnion FromICustomScreenLoading(ICustomScreenLoadingT _icustomscreenloading)
		{
			return new TCustomScreenUnion
			{
				Type = TCustomScreen.ICustomScreenLoading,
				Value = _icustomscreenloading
			};
		}

		// Token: 0x0603A8BF RID: 239807 RVA: 0x007E1244 File Offset: 0x007DF444
		public ICustomScreenSpineT AsICustomScreenSpine()
		{
			return this.As<ICustomScreenSpineT>();
		}

		// Token: 0x0603A8C0 RID: 239808 RVA: 0x007E124C File Offset: 0x007DF44C
		public static TCustomScreenUnion FromICustomScreenSpine(ICustomScreenSpineT _icustomscreenspine)
		{
			return new TCustomScreenUnion
			{
				Type = TCustomScreen.ICustomScreenSpine,
				Value = _icustomscreenspine
			};
		}

		// Token: 0x0603A8C1 RID: 239809 RVA: 0x007E1264 File Offset: 0x007DF464
		public static int Pack(FlatBufferBuilder builder, TCustomScreenUnion _o)
		{
			switch (_o.Type)
			{
			case TCustomScreen.ICustomScreenBackgroundImage:
				return ICustomScreenBackgroundImage.Pack(builder, _o.AsICustomScreenBackgroundImage()).Value;
			case TCustomScreen.ICustomScreenLoading:
				return ICustomScreenLoading.Pack(builder, _o.AsICustomScreenLoading()).Value;
			case TCustomScreen.ICustomScreenSpine:
				return ICustomScreenSpine.Pack(builder, _o.AsICustomScreenSpine()).Value;
			default:
				return 0;
			}
		}
	}
}

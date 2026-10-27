using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200769F RID: 30367
	public class TCustomScreenUnion
	{
		// Token: 0x1700E603 RID: 58883
		// (get) Token: 0x06037412 RID: 226322 RVA: 0x0077D06C File Offset: 0x0077B26C
		// (set) Token: 0x06037413 RID: 226323 RVA: 0x0077D074 File Offset: 0x0077B274
		public TCustomScreen Type { get; set; }

		// Token: 0x1700E604 RID: 58884
		// (get) Token: 0x06037414 RID: 226324 RVA: 0x0077D07D File Offset: 0x0077B27D
		// (set) Token: 0x06037415 RID: 226325 RVA: 0x0077D085 File Offset: 0x0077B285
		public object Value { get; set; }

		// Token: 0x06037416 RID: 226326 RVA: 0x0077D08E File Offset: 0x0077B28E
		public TCustomScreenUnion()
		{
			this.Type = TCustomScreen.NONE;
			this.Value = null;
		}

		// Token: 0x06037417 RID: 226327 RVA: 0x0077D0A4 File Offset: 0x0077B2A4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037418 RID: 226328 RVA: 0x0077D0B6 File Offset: 0x0077B2B6
		public ICustomScreenBackgroundImageT AsICustomScreenBackgroundImage()
		{
			return this.As<ICustomScreenBackgroundImageT>();
		}

		// Token: 0x06037419 RID: 226329 RVA: 0x0077D0BE File Offset: 0x0077B2BE
		public static TCustomScreenUnion FromICustomScreenBackgroundImage(ICustomScreenBackgroundImageT _icustomscreenbackgroundimage)
		{
			return new TCustomScreenUnion
			{
				Type = TCustomScreen.ICustomScreenBackgroundImage,
				Value = _icustomscreenbackgroundimage
			};
		}

		// Token: 0x0603741A RID: 226330 RVA: 0x0077D0D3 File Offset: 0x0077B2D3
		public ICustomScreenLoadingT AsICustomScreenLoading()
		{
			return this.As<ICustomScreenLoadingT>();
		}

		// Token: 0x0603741B RID: 226331 RVA: 0x0077D0DB File Offset: 0x0077B2DB
		public static TCustomScreenUnion FromICustomScreenLoading(ICustomScreenLoadingT _icustomscreenloading)
		{
			return new TCustomScreenUnion
			{
				Type = TCustomScreen.ICustomScreenLoading,
				Value = _icustomscreenloading
			};
		}

		// Token: 0x0603741C RID: 226332 RVA: 0x0077D0F0 File Offset: 0x0077B2F0
		public ICustomScreenSpineT AsICustomScreenSpine()
		{
			return this.As<ICustomScreenSpineT>();
		}

		// Token: 0x0603741D RID: 226333 RVA: 0x0077D0F8 File Offset: 0x0077B2F8
		public static TCustomScreenUnion FromICustomScreenSpine(ICustomScreenSpineT _icustomscreenspine)
		{
			return new TCustomScreenUnion
			{
				Type = TCustomScreen.ICustomScreenSpine,
				Value = _icustomscreenspine
			};
		}

		// Token: 0x0603741E RID: 226334 RVA: 0x0077D110 File Offset: 0x0077B310
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

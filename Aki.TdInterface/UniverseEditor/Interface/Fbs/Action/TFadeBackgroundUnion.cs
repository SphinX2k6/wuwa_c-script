using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C9 RID: 30409
	public class TFadeBackgroundUnion
	{
		// Token: 0x1700E61F RID: 58911
		// (get) Token: 0x060374E6 RID: 226534 RVA: 0x0077E446 File Offset: 0x0077C646
		// (set) Token: 0x060374E7 RID: 226535 RVA: 0x0077E44E File Offset: 0x0077C64E
		public TFadeBackground Type { get; set; }

		// Token: 0x1700E620 RID: 58912
		// (get) Token: 0x060374E8 RID: 226536 RVA: 0x0077E457 File Offset: 0x0077C657
		// (set) Token: 0x060374E9 RID: 226537 RVA: 0x0077E45F File Offset: 0x0077C65F
		public object Value { get; set; }

		// Token: 0x060374EA RID: 226538 RVA: 0x0077E468 File Offset: 0x0077C668
		public TFadeBackgroundUnion()
		{
			this.Type = TFadeBackground.NONE;
			this.Value = null;
		}

		// Token: 0x060374EB RID: 226539 RVA: 0x0077E47E File Offset: 0x0077C67E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060374EC RID: 226540 RVA: 0x0077E490 File Offset: 0x0077C690
		public IFadeBackgroundImageT AsIFadeBackgroundImage()
		{
			return this.As<IFadeBackgroundImageT>();
		}

		// Token: 0x060374ED RID: 226541 RVA: 0x0077E498 File Offset: 0x0077C698
		public static TFadeBackgroundUnion FromIFadeBackgroundImage(IFadeBackgroundImageT _ifadebackgroundimage)
		{
			return new TFadeBackgroundUnion
			{
				Type = TFadeBackground.IFadeBackgroundImage,
				Value = _ifadebackgroundimage
			};
		}

		// Token: 0x060374EE RID: 226542 RVA: 0x0077E4AD File Offset: 0x0077C6AD
		public IFadeBackgroundSpineT AsIFadeBackgroundSpine()
		{
			return this.As<IFadeBackgroundSpineT>();
		}

		// Token: 0x060374EF RID: 226543 RVA: 0x0077E4B5 File Offset: 0x0077C6B5
		public static TFadeBackgroundUnion FromIFadeBackgroundSpine(IFadeBackgroundSpineT _ifadebackgroundspine)
		{
			return new TFadeBackgroundUnion
			{
				Type = TFadeBackground.IFadeBackgroundSpine,
				Value = _ifadebackgroundspine
			};
		}

		// Token: 0x060374F0 RID: 226544 RVA: 0x0077E4CA File Offset: 0x0077C6CA
		public IFadeBackgroundUiPrefabT AsIFadeBackgroundUiPrefab()
		{
			return this.As<IFadeBackgroundUiPrefabT>();
		}

		// Token: 0x060374F1 RID: 226545 RVA: 0x0077E4D2 File Offset: 0x0077C6D2
		public static TFadeBackgroundUnion FromIFadeBackgroundUiPrefab(IFadeBackgroundUiPrefabT _ifadebackgrounduiprefab)
		{
			return new TFadeBackgroundUnion
			{
				Type = TFadeBackground.IFadeBackgroundUiPrefab,
				Value = _ifadebackgrounduiprefab
			};
		}

		// Token: 0x060374F2 RID: 226546 RVA: 0x0077E4E8 File Offset: 0x0077C6E8
		public static int Pack(FlatBufferBuilder builder, TFadeBackgroundUnion _o)
		{
			switch (_o.Type)
			{
			case TFadeBackground.IFadeBackgroundImage:
				return IFadeBackgroundImage.Pack(builder, _o.AsIFadeBackgroundImage()).Value;
			case TFadeBackground.IFadeBackgroundSpine:
				return IFadeBackgroundSpine.Pack(builder, _o.AsIFadeBackgroundSpine()).Value;
			case TFadeBackground.IFadeBackgroundUiPrefab:
				return IFadeBackgroundUiPrefab.Pack(builder, _o.AsIFadeBackgroundUiPrefab()).Value;
			default:
				return 0;
			}
		}
	}
}

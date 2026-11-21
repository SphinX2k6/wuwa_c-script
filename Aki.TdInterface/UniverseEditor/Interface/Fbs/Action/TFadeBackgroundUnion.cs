using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ED7 RID: 32471
	public class TFadeBackgroundUnion
	{
		// Token: 0x1700F25D RID: 62045
		// (get) Token: 0x0603A99B RID: 240027 RVA: 0x007E275A File Offset: 0x007E095A
		// (set) Token: 0x0603A99C RID: 240028 RVA: 0x007E2762 File Offset: 0x007E0962
		public TFadeBackground Type { get; set; }

		// Token: 0x1700F25E RID: 62046
		// (get) Token: 0x0603A99D RID: 240029 RVA: 0x007E276B File Offset: 0x007E096B
		// (set) Token: 0x0603A99E RID: 240030 RVA: 0x007E2773 File Offset: 0x007E0973
		public object Value { get; set; }

		// Token: 0x0603A99F RID: 240031 RVA: 0x007E277C File Offset: 0x007E097C
		public TFadeBackgroundUnion()
		{
			this.Type = TFadeBackground.NONE;
			this.Value = null;
		}

		// Token: 0x0603A9A0 RID: 240032 RVA: 0x007E2792 File Offset: 0x007E0992
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A9A1 RID: 240033 RVA: 0x007E27A4 File Offset: 0x007E09A4
		public IFadeBackgroundImageT AsIFadeBackgroundImage()
		{
			return this.As<IFadeBackgroundImageT>();
		}

		// Token: 0x0603A9A2 RID: 240034 RVA: 0x007E27AC File Offset: 0x007E09AC
		public static TFadeBackgroundUnion FromIFadeBackgroundImage(IFadeBackgroundImageT _ifadebackgroundimage)
		{
			return new TFadeBackgroundUnion
			{
				Type = TFadeBackground.IFadeBackgroundImage,
				Value = _ifadebackgroundimage
			};
		}

		// Token: 0x0603A9A3 RID: 240035 RVA: 0x007E27C1 File Offset: 0x007E09C1
		public IFadeBackgroundSpineT AsIFadeBackgroundSpine()
		{
			return this.As<IFadeBackgroundSpineT>();
		}

		// Token: 0x0603A9A4 RID: 240036 RVA: 0x007E27C9 File Offset: 0x007E09C9
		public static TFadeBackgroundUnion FromIFadeBackgroundSpine(IFadeBackgroundSpineT _ifadebackgroundspine)
		{
			return new TFadeBackgroundUnion
			{
				Type = TFadeBackground.IFadeBackgroundSpine,
				Value = _ifadebackgroundspine
			};
		}

		// Token: 0x0603A9A5 RID: 240037 RVA: 0x007E27DE File Offset: 0x007E09DE
		public IFadeBackgroundUiPrefabT AsIFadeBackgroundUiPrefab()
		{
			return this.As<IFadeBackgroundUiPrefabT>();
		}

		// Token: 0x0603A9A6 RID: 240038 RVA: 0x007E27E6 File Offset: 0x007E09E6
		public static TFadeBackgroundUnion FromIFadeBackgroundUiPrefab(IFadeBackgroundUiPrefabT _ifadebackgrounduiprefab)
		{
			return new TFadeBackgroundUnion
			{
				Type = TFadeBackground.IFadeBackgroundUiPrefab,
				Value = _ifadebackgrounduiprefab
			};
		}

		// Token: 0x0603A9A7 RID: 240039 RVA: 0x007E27FC File Offset: 0x007E09FC
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

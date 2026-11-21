using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006226 RID: 25126
	public class TElementalMatchConfigUnion
	{
		// Token: 0x1700BB30 RID: 47920
		// (get) Token: 0x0602AC91 RID: 175249 RVA: 0x005D822A File Offset: 0x005D642A
		// (set) Token: 0x0602AC92 RID: 175250 RVA: 0x005D8232 File Offset: 0x005D6432
		public TElementalMatchConfig Type { get; set; }

		// Token: 0x1700BB31 RID: 47921
		// (get) Token: 0x0602AC93 RID: 175251 RVA: 0x005D823B File Offset: 0x005D643B
		// (set) Token: 0x0602AC94 RID: 175252 RVA: 0x005D8243 File Offset: 0x005D6443
		public object Value { get; set; }

		// Token: 0x0602AC95 RID: 175253 RVA: 0x005D824C File Offset: 0x005D644C
		public TElementalMatchConfigUnion()
		{
			this.Type = TElementalMatchConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602AC96 RID: 175254 RVA: 0x005D8262 File Offset: 0x005D6462
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AC97 RID: 175255 RVA: 0x005D8274 File Offset: 0x005D6474
		public IFireElementalMatchT AsIFireElementalMatch()
		{
			return this.As<IFireElementalMatchT>();
		}

		// Token: 0x0602AC98 RID: 175256 RVA: 0x005D827C File Offset: 0x005D647C
		public static TElementalMatchConfigUnion FromIFireElementalMatch(IFireElementalMatchT _ifireelementalmatch)
		{
			return new TElementalMatchConfigUnion
			{
				Type = TElementalMatchConfig.IFireElementalMatch,
				Value = _ifireelementalmatch
			};
		}

		// Token: 0x0602AC99 RID: 175257 RVA: 0x005D8291 File Offset: 0x005D6491
		public IWaterElementalMatchT AsIWaterElementalMatch()
		{
			return this.As<IWaterElementalMatchT>();
		}

		// Token: 0x0602AC9A RID: 175258 RVA: 0x005D8299 File Offset: 0x005D6499
		public static TElementalMatchConfigUnion FromIWaterElementalMatch(IWaterElementalMatchT _iwaterelementalmatch)
		{
			return new TElementalMatchConfigUnion
			{
				Type = TElementalMatchConfig.IWaterElementalMatch,
				Value = _iwaterelementalmatch
			};
		}

		// Token: 0x0602AC9B RID: 175259 RVA: 0x005D82AE File Offset: 0x005D64AE
		public IWoodElementalMatchT AsIWoodElementalMatch()
		{
			return this.As<IWoodElementalMatchT>();
		}

		// Token: 0x0602AC9C RID: 175260 RVA: 0x005D82B6 File Offset: 0x005D64B6
		public static TElementalMatchConfigUnion FromIWoodElementalMatch(IWoodElementalMatchT _iwoodelementalmatch)
		{
			return new TElementalMatchConfigUnion
			{
				Type = TElementalMatchConfig.IWoodElementalMatch,
				Value = _iwoodelementalmatch
			};
		}

		// Token: 0x0602AC9D RID: 175261 RVA: 0x005D82CC File Offset: 0x005D64CC
		public static int Pack(FlatBufferBuilder builder, TElementalMatchConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TElementalMatchConfig.IFireElementalMatch:
				return IFireElementalMatch.Pack(builder, _o.AsIFireElementalMatch()).Value;
			case TElementalMatchConfig.IWaterElementalMatch:
				return IWaterElementalMatch.Pack(builder, _o.AsIWaterElementalMatch()).Value;
			case TElementalMatchConfig.IWoodElementalMatch:
				return IWoodElementalMatch.Pack(builder, _o.AsIWoodElementalMatch()).Value;
			default:
				return 0;
			}
		}
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005136 RID: 20790
	public class IElementalMatchBase_UnionUnion
	{
		// Token: 0x1700978A RID: 38794
		// (get) Token: 0x06021880 RID: 137344 RVA: 0x004A7DA9 File Offset: 0x004A5FA9
		// (set) Token: 0x06021881 RID: 137345 RVA: 0x004A7DB1 File Offset: 0x004A5FB1
		public IElementalMatchBase_Union Type { get; set; }

		// Token: 0x1700978B RID: 38795
		// (get) Token: 0x06021882 RID: 137346 RVA: 0x004A7DBA File Offset: 0x004A5FBA
		// (set) Token: 0x06021883 RID: 137347 RVA: 0x004A7DC2 File Offset: 0x004A5FC2
		public object Value { get; set; }

		// Token: 0x06021884 RID: 137348 RVA: 0x004A7DCB File Offset: 0x004A5FCB
		public IElementalMatchBase_UnionUnion()
		{
			this.Type = IElementalMatchBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021885 RID: 137349 RVA: 0x004A7DE1 File Offset: 0x004A5FE1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021886 RID: 137350 RVA: 0x004A7DF3 File Offset: 0x004A5FF3
		public IElementalMatchBaseT AsIElementalMatchBase()
		{
			return this.As<IElementalMatchBaseT>();
		}

		// Token: 0x06021887 RID: 137351 RVA: 0x004A7DFB File Offset: 0x004A5FFB
		public static IElementalMatchBase_UnionUnion FromIElementalMatchBase(IElementalMatchBaseT _ielementalmatchbase)
		{
			return new IElementalMatchBase_UnionUnion
			{
				Type = IElementalMatchBase_Union.IElementalMatchBase,
				Value = _ielementalmatchbase
			};
		}

		// Token: 0x06021888 RID: 137352 RVA: 0x004A7E10 File Offset: 0x004A6010
		public IFireElementalMatchT AsIFireElementalMatch()
		{
			return this.As<IFireElementalMatchT>();
		}

		// Token: 0x06021889 RID: 137353 RVA: 0x004A7E18 File Offset: 0x004A6018
		public static IElementalMatchBase_UnionUnion FromIFireElementalMatch(IFireElementalMatchT _ifireelementalmatch)
		{
			return new IElementalMatchBase_UnionUnion
			{
				Type = IElementalMatchBase_Union.IFireElementalMatch,
				Value = _ifireelementalmatch
			};
		}

		// Token: 0x0602188A RID: 137354 RVA: 0x004A7E2D File Offset: 0x004A602D
		public IWaterElementalMatchT AsIWaterElementalMatch()
		{
			return this.As<IWaterElementalMatchT>();
		}

		// Token: 0x0602188B RID: 137355 RVA: 0x004A7E35 File Offset: 0x004A6035
		public static IElementalMatchBase_UnionUnion FromIWaterElementalMatch(IWaterElementalMatchT _iwaterelementalmatch)
		{
			return new IElementalMatchBase_UnionUnion
			{
				Type = IElementalMatchBase_Union.IWaterElementalMatch,
				Value = _iwaterelementalmatch
			};
		}

		// Token: 0x0602188C RID: 137356 RVA: 0x004A7E4A File Offset: 0x004A604A
		public IWoodElementalMatchT AsIWoodElementalMatch()
		{
			return this.As<IWoodElementalMatchT>();
		}

		// Token: 0x0602188D RID: 137357 RVA: 0x004A7E52 File Offset: 0x004A6052
		public static IElementalMatchBase_UnionUnion FromIWoodElementalMatch(IWoodElementalMatchT _iwoodelementalmatch)
		{
			return new IElementalMatchBase_UnionUnion
			{
				Type = IElementalMatchBase_Union.IWoodElementalMatch,
				Value = _iwoodelementalmatch
			};
		}

		// Token: 0x0602188E RID: 137358 RVA: 0x004A7E68 File Offset: 0x004A6068
		public static int Pack(FlatBufferBuilder builder, IElementalMatchBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IElementalMatchBase_Union.IElementalMatchBase:
				return IElementalMatchBase.Pack(builder, _o.AsIElementalMatchBase()).Value;
			case IElementalMatchBase_Union.IFireElementalMatch:
				return IFireElementalMatch.Pack(builder, _o.AsIFireElementalMatch()).Value;
			case IElementalMatchBase_Union.IWaterElementalMatch:
				return IWaterElementalMatch.Pack(builder, _o.AsIWaterElementalMatch()).Value;
			case IElementalMatchBase_Union.IWoodElementalMatch:
				return IWoodElementalMatch.Pack(builder, _o.AsIWoodElementalMatch()).Value;
			default:
				return 0;
			}
		}
	}
}

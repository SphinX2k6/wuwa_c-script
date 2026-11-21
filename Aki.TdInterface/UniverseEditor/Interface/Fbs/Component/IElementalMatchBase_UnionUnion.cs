using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200569B RID: 22171
	public class IElementalMatchBase_UnionUnion
	{
		// Token: 0x17009F77 RID: 40823
		// (get) Token: 0x060237D4 RID: 145364 RVA: 0x004E1D35 File Offset: 0x004DFF35
		// (set) Token: 0x060237D5 RID: 145365 RVA: 0x004E1D3D File Offset: 0x004DFF3D
		public IElementalMatchBase_Union Type { get; set; }

		// Token: 0x17009F78 RID: 40824
		// (get) Token: 0x060237D6 RID: 145366 RVA: 0x004E1D46 File Offset: 0x004DFF46
		// (set) Token: 0x060237D7 RID: 145367 RVA: 0x004E1D4E File Offset: 0x004DFF4E
		public object Value { get; set; }

		// Token: 0x060237D8 RID: 145368 RVA: 0x004E1D57 File Offset: 0x004DFF57
		public IElementalMatchBase_UnionUnion()
		{
			this.Type = IElementalMatchBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060237D9 RID: 145369 RVA: 0x004E1D6D File Offset: 0x004DFF6D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060237DA RID: 145370 RVA: 0x004E1D7F File Offset: 0x004DFF7F
		public IElementalMatchBaseT AsIElementalMatchBase()
		{
			return this.As<IElementalMatchBaseT>();
		}

		// Token: 0x060237DB RID: 145371 RVA: 0x004E1D87 File Offset: 0x004DFF87
		public static IElementalMatchBase_UnionUnion FromIElementalMatchBase(IElementalMatchBaseT _ielementalmatchbase)
		{
			return new IElementalMatchBase_UnionUnion
			{
				Type = IElementalMatchBase_Union.IElementalMatchBase,
				Value = _ielementalmatchbase
			};
		}

		// Token: 0x060237DC RID: 145372 RVA: 0x004E1D9C File Offset: 0x004DFF9C
		public IFireElementalMatchT AsIFireElementalMatch()
		{
			return this.As<IFireElementalMatchT>();
		}

		// Token: 0x060237DD RID: 145373 RVA: 0x004E1DA4 File Offset: 0x004DFFA4
		public static IElementalMatchBase_UnionUnion FromIFireElementalMatch(IFireElementalMatchT _ifireelementalmatch)
		{
			return new IElementalMatchBase_UnionUnion
			{
				Type = IElementalMatchBase_Union.IFireElementalMatch,
				Value = _ifireelementalmatch
			};
		}

		// Token: 0x060237DE RID: 145374 RVA: 0x004E1DB9 File Offset: 0x004DFFB9
		public IWaterElementalMatchT AsIWaterElementalMatch()
		{
			return this.As<IWaterElementalMatchT>();
		}

		// Token: 0x060237DF RID: 145375 RVA: 0x004E1DC1 File Offset: 0x004DFFC1
		public static IElementalMatchBase_UnionUnion FromIWaterElementalMatch(IWaterElementalMatchT _iwaterelementalmatch)
		{
			return new IElementalMatchBase_UnionUnion
			{
				Type = IElementalMatchBase_Union.IWaterElementalMatch,
				Value = _iwaterelementalmatch
			};
		}

		// Token: 0x060237E0 RID: 145376 RVA: 0x004E1DD6 File Offset: 0x004DFFD6
		public IWoodElementalMatchT AsIWoodElementalMatch()
		{
			return this.As<IWoodElementalMatchT>();
		}

		// Token: 0x060237E1 RID: 145377 RVA: 0x004E1DDE File Offset: 0x004DFFDE
		public static IElementalMatchBase_UnionUnion FromIWoodElementalMatch(IWoodElementalMatchT _iwoodelementalmatch)
		{
			return new IElementalMatchBase_UnionUnion
			{
				Type = IElementalMatchBase_Union.IWoodElementalMatch,
				Value = _iwoodelementalmatch
			};
		}

		// Token: 0x060237E2 RID: 145378 RVA: 0x004E1DF4 File Offset: 0x004DFFF4
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

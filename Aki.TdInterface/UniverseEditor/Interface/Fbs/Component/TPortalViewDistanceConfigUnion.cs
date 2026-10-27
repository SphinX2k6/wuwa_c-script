using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C8B RID: 23691
	public class TPortalViewDistanceConfigUnion
	{
		// Token: 0x1700B23A RID: 45626
		// (get) Token: 0x06028947 RID: 166215 RVA: 0x0059426A File Offset: 0x0059246A
		// (set) Token: 0x06028948 RID: 166216 RVA: 0x00594272 File Offset: 0x00592472
		public TPortalViewDistanceConfig Type { get; set; }

		// Token: 0x1700B23B RID: 45627
		// (get) Token: 0x06028949 RID: 166217 RVA: 0x0059427B File Offset: 0x0059247B
		// (set) Token: 0x0602894A RID: 166218 RVA: 0x00594283 File Offset: 0x00592483
		public object Value { get; set; }

		// Token: 0x0602894B RID: 166219 RVA: 0x0059428C File Offset: 0x0059248C
		public TPortalViewDistanceConfigUnion()
		{
			this.Type = TPortalViewDistanceConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602894C RID: 166220 RVA: 0x005942A2 File Offset: 0x005924A2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602894D RID: 166221 RVA: 0x005942B4 File Offset: 0x005924B4
		public ICustomViewDistanceT AsICustomViewDistance()
		{
			return this.As<ICustomViewDistanceT>();
		}

		// Token: 0x0602894E RID: 166222 RVA: 0x005942BC File Offset: 0x005924BC
		public static TPortalViewDistanceConfigUnion FromICustomViewDistance(ICustomViewDistanceT _icustomviewdistance)
		{
			return new TPortalViewDistanceConfigUnion
			{
				Type = TPortalViewDistanceConfig.ICustomViewDistance,
				Value = _icustomviewdistance
			};
		}

		// Token: 0x0602894F RID: 166223 RVA: 0x005942D1 File Offset: 0x005924D1
		public IHighViewDistanceT AsIHighViewDistance()
		{
			return this.As<IHighViewDistanceT>();
		}

		// Token: 0x06028950 RID: 166224 RVA: 0x005942D9 File Offset: 0x005924D9
		public static TPortalViewDistanceConfigUnion FromIHighViewDistance(IHighViewDistanceT _ihighviewdistance)
		{
			return new TPortalViewDistanceConfigUnion
			{
				Type = TPortalViewDistanceConfig.IHighViewDistance,
				Value = _ihighviewdistance
			};
		}

		// Token: 0x06028951 RID: 166225 RVA: 0x005942EE File Offset: 0x005924EE
		public ILowViewDistanceT AsILowViewDistance()
		{
			return this.As<ILowViewDistanceT>();
		}

		// Token: 0x06028952 RID: 166226 RVA: 0x005942F6 File Offset: 0x005924F6
		public static TPortalViewDistanceConfigUnion FromILowViewDistance(ILowViewDistanceT _ilowviewdistance)
		{
			return new TPortalViewDistanceConfigUnion
			{
				Type = TPortalViewDistanceConfig.ILowViewDistance,
				Value = _ilowviewdistance
			};
		}

		// Token: 0x06028953 RID: 166227 RVA: 0x0059430B File Offset: 0x0059250B
		public IMidViewDistanceT AsIMidViewDistance()
		{
			return this.As<IMidViewDistanceT>();
		}

		// Token: 0x06028954 RID: 166228 RVA: 0x00594313 File Offset: 0x00592513
		public static TPortalViewDistanceConfigUnion FromIMidViewDistance(IMidViewDistanceT _imidviewdistance)
		{
			return new TPortalViewDistanceConfigUnion
			{
				Type = TPortalViewDistanceConfig.IMidViewDistance,
				Value = _imidviewdistance
			};
		}

		// Token: 0x06028955 RID: 166229 RVA: 0x00594328 File Offset: 0x00592528
		public static int Pack(FlatBufferBuilder builder, TPortalViewDistanceConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TPortalViewDistanceConfig.ICustomViewDistance:
				return ICustomViewDistance.Pack(builder, _o.AsICustomViewDistance()).Value;
			case TPortalViewDistanceConfig.IHighViewDistance:
				return IHighViewDistance.Pack(builder, _o.AsIHighViewDistance()).Value;
			case TPortalViewDistanceConfig.ILowViewDistance:
				return ILowViewDistance.Pack(builder, _o.AsILowViewDistance()).Value;
			case TPortalViewDistanceConfig.IMidViewDistance:
				return IMidViewDistance.Pack(builder, _o.AsIMidViewDistance()).Value;
			default:
				return 0;
			}
		}
	}
}

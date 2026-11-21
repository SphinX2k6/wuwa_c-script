using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B3 RID: 21427
	public class IAirWallSpawnStyle_UnionUnion
	{
		// Token: 0x17009792 RID: 38802
		// (get) Token: 0x0602171D RID: 136989 RVA: 0x0049D211 File Offset: 0x0049B411
		// (set) Token: 0x0602171E RID: 136990 RVA: 0x0049D219 File Offset: 0x0049B419
		public IAirWallSpawnStyle_Union Type { get; set; }

		// Token: 0x17009793 RID: 38803
		// (get) Token: 0x0602171F RID: 136991 RVA: 0x0049D222 File Offset: 0x0049B422
		// (set) Token: 0x06021720 RID: 136992 RVA: 0x0049D22A File Offset: 0x0049B42A
		public object Value { get; set; }

		// Token: 0x06021721 RID: 136993 RVA: 0x0049D233 File Offset: 0x0049B433
		public IAirWallSpawnStyle_UnionUnion()
		{
			this.Type = IAirWallSpawnStyle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021722 RID: 136994 RVA: 0x0049D249 File Offset: 0x0049B449
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021723 RID: 136995 RVA: 0x0049D25B File Offset: 0x0049B45B
		public IAirWallSpawnStyleT AsIAirWallSpawnStyle()
		{
			return this.As<IAirWallSpawnStyleT>();
		}

		// Token: 0x06021724 RID: 136996 RVA: 0x0049D263 File Offset: 0x0049B463
		public static IAirWallSpawnStyle_UnionUnion FromIAirWallSpawnStyle(IAirWallSpawnStyleT _iairwallspawnstyle)
		{
			return new IAirWallSpawnStyle_UnionUnion
			{
				Type = IAirWallSpawnStyle_Union.IAirWallSpawnStyle,
				Value = _iairwallspawnstyle
			};
		}

		// Token: 0x06021725 RID: 136997 RVA: 0x0049D278 File Offset: 0x0049B478
		public IAirWallAlongSplineStyleT AsIAirWallAlongSplineStyle()
		{
			return this.As<IAirWallAlongSplineStyleT>();
		}

		// Token: 0x06021726 RID: 136998 RVA: 0x0049D280 File Offset: 0x0049B480
		public static IAirWallSpawnStyle_UnionUnion FromIAirWallAlongSplineStyle(IAirWallAlongSplineStyleT _iairwallalongsplinestyle)
		{
			return new IAirWallSpawnStyle_UnionUnion
			{
				Type = IAirWallSpawnStyle_Union.IAirWallAlongSplineStyle,
				Value = _iairwallalongsplinestyle
			};
		}

		// Token: 0x06021727 RID: 136999 RVA: 0x0049D295 File Offset: 0x0049B495
		public IAirWallBothSidesStyleT AsIAirWallBothSidesStyle()
		{
			return this.As<IAirWallBothSidesStyleT>();
		}

		// Token: 0x06021728 RID: 137000 RVA: 0x0049D29D File Offset: 0x0049B49D
		public static IAirWallSpawnStyle_UnionUnion FromIAirWallBothSidesStyle(IAirWallBothSidesStyleT _iairwallbothsidesstyle)
		{
			return new IAirWallSpawnStyle_UnionUnion
			{
				Type = IAirWallSpawnStyle_Union.IAirWallBothSidesStyle,
				Value = _iairwallbothsidesstyle
			};
		}

		// Token: 0x06021729 RID: 137001 RVA: 0x0049D2B4 File Offset: 0x0049B4B4
		public static int Pack(FlatBufferBuilder builder, IAirWallSpawnStyle_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAirWallSpawnStyle_Union.IAirWallSpawnStyle:
				return IAirWallSpawnStyle.Pack(builder, _o.AsIAirWallSpawnStyle()).Value;
			case IAirWallSpawnStyle_Union.IAirWallAlongSplineStyle:
				return IAirWallAlongSplineStyle.Pack(builder, _o.AsIAirWallAlongSplineStyle()).Value;
			case IAirWallSpawnStyle_Union.IAirWallBothSidesStyle:
				return IAirWallBothSidesStyle.Pack(builder, _o.AsIAirWallBothSidesStyle()).Value;
			default:
				return 0;
			}
		}
	}
}

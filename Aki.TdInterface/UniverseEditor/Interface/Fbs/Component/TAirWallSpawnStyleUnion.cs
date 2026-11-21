using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061FC RID: 25084
	public class TAirWallSpawnStyleUnion
	{
		// Token: 0x1700BB0B RID: 47883
		// (get) Token: 0x0602AAD5 RID: 174805 RVA: 0x005D1BD2 File Offset: 0x005CFDD2
		// (set) Token: 0x0602AAD6 RID: 174806 RVA: 0x005D1BDA File Offset: 0x005CFDDA
		public TAirWallSpawnStyle Type { get; set; }

		// Token: 0x1700BB0C RID: 47884
		// (get) Token: 0x0602AAD7 RID: 174807 RVA: 0x005D1BE3 File Offset: 0x005CFDE3
		// (set) Token: 0x0602AAD8 RID: 174808 RVA: 0x005D1BEB File Offset: 0x005CFDEB
		public object Value { get; set; }

		// Token: 0x0602AAD9 RID: 174809 RVA: 0x005D1BF4 File Offset: 0x005CFDF4
		public TAirWallSpawnStyleUnion()
		{
			this.Type = TAirWallSpawnStyle.NONE;
			this.Value = null;
		}

		// Token: 0x0602AADA RID: 174810 RVA: 0x005D1C0A File Offset: 0x005CFE0A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AADB RID: 174811 RVA: 0x005D1C1C File Offset: 0x005CFE1C
		public IAirWallAlongSplineStyleT AsIAirWallAlongSplineStyle()
		{
			return this.As<IAirWallAlongSplineStyleT>();
		}

		// Token: 0x0602AADC RID: 174812 RVA: 0x005D1C24 File Offset: 0x005CFE24
		public static TAirWallSpawnStyleUnion FromIAirWallAlongSplineStyle(IAirWallAlongSplineStyleT _iairwallalongsplinestyle)
		{
			return new TAirWallSpawnStyleUnion
			{
				Type = TAirWallSpawnStyle.IAirWallAlongSplineStyle,
				Value = _iairwallalongsplinestyle
			};
		}

		// Token: 0x0602AADD RID: 174813 RVA: 0x005D1C39 File Offset: 0x005CFE39
		public IAirWallBothSidesStyleT AsIAirWallBothSidesStyle()
		{
			return this.As<IAirWallBothSidesStyleT>();
		}

		// Token: 0x0602AADE RID: 174814 RVA: 0x005D1C41 File Offset: 0x005CFE41
		public static TAirWallSpawnStyleUnion FromIAirWallBothSidesStyle(IAirWallBothSidesStyleT _iairwallbothsidesstyle)
		{
			return new TAirWallSpawnStyleUnion
			{
				Type = TAirWallSpawnStyle.IAirWallBothSidesStyle,
				Value = _iairwallbothsidesstyle
			};
		}

		// Token: 0x0602AADF RID: 174815 RVA: 0x005D1C58 File Offset: 0x005CFE58
		public static int Pack(FlatBufferBuilder builder, TAirWallSpawnStyleUnion _o)
		{
			TAirWallSpawnStyle type = _o.Type;
			if (type == TAirWallSpawnStyle.IAirWallAlongSplineStyle)
			{
				return IAirWallAlongSplineStyle.Pack(builder, _o.AsIAirWallAlongSplineStyle()).Value;
			}
			if (type != TAirWallSpawnStyle.IAirWallBothSidesStyle)
			{
				return 0;
			}
			return IAirWallBothSidesStyle.Pack(builder, _o.AsIAirWallBothSidesStyle()).Value;
		}
	}
}

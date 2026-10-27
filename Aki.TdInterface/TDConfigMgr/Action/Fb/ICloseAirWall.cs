using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002911 RID: 10513
	public class ICloseAirWall : IToggleAirWallType
	{
		// Token: 0x0600E962 RID: 59746 RVA: 0x002237DB File Offset: 0x002219DB
		[NullableContext(1)]
		public static ICloseAirWall Create(ICloseAirWall? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseAirWall
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004902 RID: 18690
		// (get) Token: 0x0600E963 RID: 59747 RVA: 0x002237FA File Offset: 0x002219FA
		public override EToggleAirWall Type
		{
			get
			{
				return (EToggleAirWall)this.Instance.Type;
			}
		}

		// Token: 0x040080D1 RID: 32977
		private ICloseAirWall Instance;
	}
}

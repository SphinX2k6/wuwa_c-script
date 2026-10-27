using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF7 RID: 3319
	public class ILowViewDistance : IViewDistanceMode
	{
		// Token: 0x06004BD2 RID: 19410 RVA: 0x000BD3BC File Offset: 0x000BB5BC
		[NullableContext(1)]
		public static ILowViewDistance Create(ILowViewDistance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILowViewDistance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06004BD3 RID: 19411 RVA: 0x000BD3DB File Offset: 0x000BB5DB
		public override EViewDistanceType Type
		{
			get
			{
				return (EViewDistanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002B5A RID: 11098
		private ILowViewDistance Instance;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF6 RID: 3318
	public class IViewDistanceMode
	{
		// Token: 0x06004BCF RID: 19407 RVA: 0x000BD388 File Offset: 0x000BB588
		[NullableContext(1)]
		public static IViewDistanceMode Create(IViewDistanceMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IViewDistanceMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x06004BD0 RID: 19408 RVA: 0x000BD3A7 File Offset: 0x000BB5A7
		public virtual EViewDistanceType Type
		{
			get
			{
				return (EViewDistanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002B59 RID: 11097
		private IViewDistanceMode Instance;
	}
}

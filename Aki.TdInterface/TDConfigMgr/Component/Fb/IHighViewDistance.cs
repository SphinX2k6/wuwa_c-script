using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF9 RID: 3321
	public class IHighViewDistance : IViewDistanceMode
	{
		// Token: 0x06004BD8 RID: 19416 RVA: 0x000BD424 File Offset: 0x000BB624
		[NullableContext(1)]
		public static IHighViewDistance Create(IHighViewDistance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHighViewDistance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06004BD9 RID: 19417 RVA: 0x000BD443 File Offset: 0x000BB643
		public override EViewDistanceType Type
		{
			get
			{
				return (EViewDistanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002B5C RID: 11100
		private IHighViewDistance Instance;
	}
}

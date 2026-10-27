using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200290B RID: 10507
	public class IPreprocessOperationConfig
	{
		// Token: 0x0600E93D RID: 59709 RVA: 0x00223378 File Offset: 0x00221578
		[NullableContext(1)]
		public static IPreprocessOperationConfig Create(IPreprocessOperationConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreprocessOperationConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048E9 RID: 18665
		// (get) Token: 0x0600E93E RID: 59710 RVA: 0x00223397 File Offset: 0x00221597
		public virtual EPreprocessOperation Type
		{
			get
			{
				return (EPreprocessOperation)this.Instance.Type;
			}
		}

		// Token: 0x040080C1 RID: 32961
		private IPreprocessOperationConfig Instance;
	}
}

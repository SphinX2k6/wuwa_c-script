using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012DA RID: 4826
	public class IEnableSystemConfig
	{
		// Token: 0x06006E4E RID: 28238 RVA: 0x0010AA42 File Offset: 0x00108C42
		[NullableContext(1)]
		public static IEnableSystemConfig Create(IEnableSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x06006E4F RID: 28239 RVA: 0x0010AA61 File Offset: 0x00108C61
		public virtual EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x04003F30 RID: 16176
		private IEnableSystemConfig Instance;
	}
}

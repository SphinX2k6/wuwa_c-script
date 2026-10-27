using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025CC RID: 9676
	public class IUiStyleBaseOfLevelD
	{
		// Token: 0x0600D981 RID: 55681 RVA: 0x00207013 File Offset: 0x00205213
		[NullableContext(1)]
		public static IUiStyleBaseOfLevelD Create(IUiStyleBaseOfLevelD? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiStyleBaseOfLevelD
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FAB RID: 16299
		// (get) Token: 0x0600D982 RID: 55682 RVA: 0x00207032 File Offset: 0x00205232
		public virtual EUiStyleTypeOfLevelD Type
		{
			get
			{
				return (EUiStyleTypeOfLevelD)this.Instance.Type;
			}
		}

		// Token: 0x040078C6 RID: 30918
		private IUiStyleBaseOfLevelD Instance;
	}
}

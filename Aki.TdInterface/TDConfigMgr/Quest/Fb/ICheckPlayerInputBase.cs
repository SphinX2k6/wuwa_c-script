using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200151C RID: 5404
	public class ICheckPlayerInputBase
	{
		// Token: 0x06007A58 RID: 31320 RVA: 0x00123F82 File Offset: 0x00122182
		public static ICheckPlayerInputBase Create(ICheckPlayerInputBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckPlayerInputBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x06007A59 RID: 31321 RVA: 0x00123FA1 File Offset: 0x001221A1
		public virtual ECheckPlayerInputType Type
		{
			get
			{
				return (ECheckPlayerInputType)this.Instance.Type;
			}
		}

		// Token: 0x0400467C RID: 18044
		private ICheckPlayerInputBase Instance;
	}
}

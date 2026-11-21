using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200144B RID: 5195
	public class ISystemPromptType
	{
		// Token: 0x06007571 RID: 30065 RVA: 0x00119F62 File Offset: 0x00118162
		public static ISystemPromptType Create(ISystemPromptType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISystemPromptType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x06007572 RID: 30066 RVA: 0x00119F81 File Offset: 0x00118181
		public virtual ESystemPromptType Type
		{
			get
			{
				return (ESystemPromptType)this.Instance.Type;
			}
		}

		// Token: 0x04004303 RID: 17155
		private ISystemPromptType Instance;
	}
}

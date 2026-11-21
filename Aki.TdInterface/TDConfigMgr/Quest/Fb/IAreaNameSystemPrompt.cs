using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200144C RID: 5196
	public class IAreaNameSystemPrompt : ISystemPromptType
	{
		// Token: 0x06007574 RID: 30068 RVA: 0x00119F96 File Offset: 0x00118196
		public static IAreaNameSystemPrompt Create(IAreaNameSystemPrompt? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAreaNameSystemPrompt
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x06007575 RID: 30069 RVA: 0x00119FB5 File Offset: 0x001181B5
		public override ESystemPromptType Type
		{
			get
			{
				return (ESystemPromptType)this.Instance.Type;
			}
		}

		// Token: 0x04004304 RID: 17156
		private IAreaNameSystemPrompt Instance;
	}
}

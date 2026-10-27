using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012FC RID: 4860
	public class IAreaNameSystemPrompt : ISystemPromptType
	{
		// Token: 0x06006ED4 RID: 28372 RVA: 0x0010BA2A File Offset: 0x00109C2A
		[NullableContext(1)]
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

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x06006ED5 RID: 28373 RVA: 0x0010BA49 File Offset: 0x00109C49
		public override ESystemPromptType Type
		{
			get
			{
				return (ESystemPromptType)this.Instance.Type;
			}
		}

		// Token: 0x04003F88 RID: 16264
		private IAreaNameSystemPrompt Instance;
	}
}

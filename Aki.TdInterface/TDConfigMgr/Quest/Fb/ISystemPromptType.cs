using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012FB RID: 4859
	public class ISystemPromptType
	{
		// Token: 0x06006ED1 RID: 28369 RVA: 0x0010B9F6 File Offset: 0x00109BF6
		[NullableContext(1)]
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

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x06006ED2 RID: 28370 RVA: 0x0010BA15 File Offset: 0x00109C15
		public virtual ESystemPromptType Type
		{
			get
			{
				return (ESystemPromptType)this.Instance.Type;
			}
		}

		// Token: 0x04003F87 RID: 16263
		private ISystemPromptType Instance;
	}
}

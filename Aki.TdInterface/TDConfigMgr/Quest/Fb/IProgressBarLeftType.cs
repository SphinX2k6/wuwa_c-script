using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200132C RID: 4908
	public class IProgressBarLeftType
	{
		// Token: 0x06007095 RID: 28821 RVA: 0x0010FBDC File Offset: 0x0010DDDC
		[NullableContext(1)]
		public static IProgressBarLeftType Create(IProgressBarLeftType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProgressBarLeftType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x06007096 RID: 28822 RVA: 0x0010FBFB File Offset: 0x0010DDFB
		public virtual EProgressBarLeftType Type
		{
			get
			{
				return (EProgressBarLeftType)this.Instance.Type;
			}
		}

		// Token: 0x040040F0 RID: 16624
		private IProgressBarLeftType Instance;
	}
}

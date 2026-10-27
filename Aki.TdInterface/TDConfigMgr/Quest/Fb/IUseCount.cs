using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200132D RID: 4909
	public class IUseCount : IProgressBarLeftType
	{
		// Token: 0x06007098 RID: 28824 RVA: 0x0010FC10 File Offset: 0x0010DE10
		[NullableContext(1)]
		public static IUseCount Create(IUseCount? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseCount
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x06007099 RID: 28825 RVA: 0x0010FC2F File Offset: 0x0010DE2F
		public override EProgressBarLeftType Type
		{
			get
			{
				return (EProgressBarLeftType)this.Instance.Type;
			}
		}

		// Token: 0x040040F1 RID: 16625
		private IUseCount Instance;
	}
}

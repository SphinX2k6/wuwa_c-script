using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200147D RID: 5245
	public class IUseCount : IProgressBarLeftType
	{
		// Token: 0x06007738 RID: 30520 RVA: 0x0011E17C File Offset: 0x0011C37C
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

		// Token: 0x170025E0 RID: 9696
		// (get) Token: 0x06007739 RID: 30521 RVA: 0x0011E19B File Offset: 0x0011C39B
		public override EProgressBarLeftType Type
		{
			get
			{
				return (EProgressBarLeftType)this.Instance.Type;
			}
		}

		// Token: 0x0400446D RID: 17517
		private IUseCount Instance;
	}
}

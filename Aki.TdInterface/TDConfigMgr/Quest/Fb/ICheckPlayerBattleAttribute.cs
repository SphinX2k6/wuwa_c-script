using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014E1 RID: 5345
	public class ICheckPlayerBattleAttribute : ITargetBattleAttribute
	{
		// Token: 0x0600792E RID: 31022 RVA: 0x00121C42 File Offset: 0x0011FE42
		public static ICheckPlayerBattleAttribute Create(ICheckPlayerBattleAttribute? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckPlayerBattleAttribute
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x0600792F RID: 31023 RVA: 0x00121C61 File Offset: 0x0011FE61
		public override ETargetBattleAttribute Type
		{
			get
			{
				return (ETargetBattleAttribute)this.Instance.Type;
			}
		}

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x06007930 RID: 31024 RVA: 0x00121C6E File Offset: 0x0011FE6E
		public virtual IHealthAttributeToTarget Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = IHealthAttributeToTarget.Create(this.Instance.Option);
				return this._OptionCache;
			}
		}

		// Token: 0x040045AF RID: 17839
		private ICheckPlayerBattleAttribute Instance;

		// Token: 0x040045B0 RID: 17840
		[Nullable(2)]
		private IHealthAttributeToTarget _OptionCache;

		// Token: 0x040045B1 RID: 17841
		private bool _OptionInited;
	}
}

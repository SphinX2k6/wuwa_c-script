using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001390 RID: 5008
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckPlayerBattleAttribute : ITargetBattleAttribute
	{
		// Token: 0x06007288 RID: 29320 RVA: 0x001135BE File Offset: 0x001117BE
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

		// Token: 0x1700253B RID: 9531
		// (get) Token: 0x06007289 RID: 29321 RVA: 0x001135DD File Offset: 0x001117DD
		public override ETargetBattleAttribute Type
		{
			get
			{
				return (ETargetBattleAttribute)this.Instance.Type;
			}
		}

		// Token: 0x1700253C RID: 9532
		// (get) Token: 0x0600728A RID: 29322 RVA: 0x001135EA File Offset: 0x001117EA
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

		// Token: 0x0400422E RID: 16942
		private ICheckPlayerBattleAttribute Instance;

		// Token: 0x0400422F RID: 16943
		[Nullable(2)]
		private IHealthAttributeToTarget _OptionCache;

		// Token: 0x04004230 RID: 16944
		private bool _OptionInited;
	}
}

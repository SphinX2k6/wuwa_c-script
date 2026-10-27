using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002697 RID: 9879
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionWithSpecialCustomLoading : ITeleportTransitionType
	{
		// Token: 0x0600DD24 RID: 56612 RVA: 0x0020DD0D File Offset: 0x0020BF0D
		public static ITeleportTransitionWithSpecialCustomLoading Create(ITeleportTransitionWithSpecialCustomLoading? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithSpecialCustomLoading
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041B8 RID: 16824
		// (get) Token: 0x0600DD25 RID: 56613 RVA: 0x0020DD2C File Offset: 0x0020BF2C
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170041B9 RID: 16825
		// (get) Token: 0x0600DD26 RID: 56614 RVA: 0x0020DD39 File Offset: 0x0020BF39
		public virtual IHonamiStoryCustomLoading LoadingType
		{
			get
			{
				if (this._LoadingTypeInited)
				{
					return this._LoadingTypeCache;
				}
				this._LoadingTypeInited = true;
				this._LoadingTypeCache = IHonamiStoryCustomLoading.Create(this.Instance.LoadingType);
				return this._LoadingTypeCache;
			}
		}

		// Token: 0x04007AD1 RID: 31441
		private ITeleportTransitionWithSpecialCustomLoading Instance;

		// Token: 0x04007AD2 RID: 31442
		[Nullable(2)]
		private IHonamiStoryCustomLoading _LoadingTypeCache;

		// Token: 0x04007AD3 RID: 31443
		private bool _LoadingTypeInited;
	}
}

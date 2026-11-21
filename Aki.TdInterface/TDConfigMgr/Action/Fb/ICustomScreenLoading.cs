using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002963 RID: 10595
	public class ICustomScreenLoading : ICustomScreenTypeBase
	{
		// Token: 0x0600EB1F RID: 60191 RVA: 0x0022A804 File Offset: 0x00228A04
		public static ICustomScreenLoading Create(ICustomScreenLoading? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenLoading
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004507 RID: 17671
		// (get) Token: 0x0600EB20 RID: 60192 RVA: 0x0022A823 File Offset: 0x00228A23
		public override ECustomScreenType Type
		{
			get
			{
				return (ECustomScreenType)this.Instance.Type;
			}
		}

		// Token: 0x17004508 RID: 17672
		// (get) Token: 0x0600EB21 RID: 60193 RVA: 0x0022A830 File Offset: 0x00228A30
		public virtual ICustomScreenLoadingCyberpunk LoadingType
		{
			get
			{
				if (this._LoadingTypeInited)
				{
					return this._LoadingTypeCache;
				}
				this._LoadingTypeInited = true;
				this._LoadingTypeCache = ICustomScreenLoadingCyberpunk.Create(this.Instance.LoadingType);
				return this._LoadingTypeCache;
			}
		}

		// Token: 0x04008181 RID: 33153
		private ICustomScreenLoading Instance;

		// Token: 0x04008182 RID: 33154
		[Nullable(2)]
		private ICustomScreenLoadingCyberpunk _LoadingTypeCache;

		// Token: 0x04008183 RID: 33155
		private bool _LoadingTypeInited;
	}
}

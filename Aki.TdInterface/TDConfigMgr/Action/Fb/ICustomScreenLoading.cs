using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026A0 RID: 9888
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomScreenLoading : ICustomScreenTypeBase
	{
		// Token: 0x0600DD48 RID: 56648 RVA: 0x0020E064 File Offset: 0x0020C264
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

		// Token: 0x170041CA RID: 16842
		// (get) Token: 0x0600DD49 RID: 56649 RVA: 0x0020E083 File Offset: 0x0020C283
		public override ECustomScreenType Type
		{
			get
			{
				return (ECustomScreenType)this.Instance.Type;
			}
		}

		// Token: 0x170041CB RID: 16843
		// (get) Token: 0x0600DD4A RID: 56650 RVA: 0x0020E090 File Offset: 0x0020C290
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

		// Token: 0x04007AE4 RID: 31460
		private ICustomScreenLoading Instance;

		// Token: 0x04007AE5 RID: 31461
		[Nullable(2)]
		private ICustomScreenLoadingCyberpunk _LoadingTypeCache;

		// Token: 0x04007AE6 RID: 31462
		private bool _LoadingTypeInited;
	}
}

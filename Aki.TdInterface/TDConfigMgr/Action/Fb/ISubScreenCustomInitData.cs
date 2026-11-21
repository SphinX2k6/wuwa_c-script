using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A70 RID: 10864
	public class ISubScreenCustomInitData : ISubScreenInitData
	{
		// Token: 0x0600EFD2 RID: 61394 RVA: 0x002326E9 File Offset: 0x002308E9
		public static ISubScreenCustomInitData Create(ISubScreenCustomInitData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenCustomInitData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047A0 RID: 18336
		// (get) Token: 0x0600EFD3 RID: 61395 RVA: 0x00232708 File Offset: 0x00230908
		public override ESubScreenInitDataType Type
		{
			get
			{
				return (ESubScreenInitDataType)this.Instance.Type;
			}
		}

		// Token: 0x170047A1 RID: 18337
		// (get) Token: 0x0600EFD4 RID: 61396 RVA: 0x00232715 File Offset: 0x00230915
		public override string SubScreenKey
		{
			get
			{
				return this.Instance.SubScreenKey;
			}
		}

		// Token: 0x170047A2 RID: 18338
		// (get) Token: 0x0600EFD5 RID: 61397 RVA: 0x00232722 File Offset: 0x00230922
		public virtual ISubScreenConfig InitConfig
		{
			get
			{
				if (this._InitConfigInited)
				{
					return this._InitConfigCache;
				}
				this._InitConfigInited = true;
				this._InitConfigCache = ISubScreenConfig.Create(this.Instance.InitConfig);
				return this._InitConfigCache;
			}
		}

		// Token: 0x040083DC RID: 33756
		private ISubScreenCustomInitData Instance;

		// Token: 0x040083DD RID: 33757
		[Nullable(2)]
		private ISubScreenConfig _InitConfigCache;

		// Token: 0x040083DE RID: 33758
		private bool _InitConfigInited;
	}
}

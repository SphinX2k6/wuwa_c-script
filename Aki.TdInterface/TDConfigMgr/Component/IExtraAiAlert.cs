using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003AD RID: 941
	public class IExtraAiAlert
	{
		// Token: 0x0600127F RID: 4735 RVA: 0x0003DC20 File Offset: 0x0003BE20
		private IExtraAiAlert_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExtraAiAlert 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExtraAiAlert_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExtraAiAlert_SetValue());
			}
			return result;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0003DC58 File Offset: 0x0003BE58
		public static IExtraAiAlert Create([Nullable(2)] IExtraAiAlert instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExtraAiAlert
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0003DC6B File Offset: 0x0003BE6B
		public static IExtraAiAlert CreateFromSetValue([Nullable(2)] IExtraAiAlert_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExtraAiAlert
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0003DC7E File Offset: 0x0003BE7E
		public IExtraAiAlert_SetValue ToSetValue()
		{
			return new IExtraAiAlert_SetValue
			{
				MoveAlert = this.MoveAlert,
				StopAlert = this.StopAlert,
				SelfStateAlert = this.SelfStateAlert
			};
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x0003DCAC File Offset: 0x0003BEAC
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x0003DCE6 File Offset: 0x0003BEE6
		public virtual int? MoveAlert
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveAlert;
				}
				IExtraAiAlert_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveAlert;
			}
			set
			{
				this.GetOrCreatePoco().MoveAlert = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0003DCF4 File Offset: 0x0003BEF4
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x0003DD2E File Offset: 0x0003BF2E
		public virtual int? StopAlert
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StopAlert;
				}
				IExtraAiAlert_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StopAlert;
			}
			set
			{
				this.GetOrCreatePoco().StopAlert = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x0003DD3C File Offset: 0x0003BF3C
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x0003DDCF File Offset: 0x0003BFCF
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IStateAlert> SelfStateAlert
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._SelfStateAlertInited)
				{
					return this._SelfStateAlertCache;
				}
				this._SelfStateAlertInited = true;
				if (this.FbInstance != null)
				{
					List<IStateAlert> selfStateAlert = this.FbInstance.SelfStateAlert;
					if (selfStateAlert != null)
					{
						this._SelfStateAlertCache = new List<IStateAlert>(selfStateAlert.Count);
						for (int i = 0; i < selfStateAlert.Count; i++)
						{
							this._SelfStateAlertCache.Add(IStateAlert.Create(selfStateAlert[i]));
						}
					}
				}
				else
				{
					IExtraAiAlert_SetValue pocoInterface = this.PocoInterface;
					this._SelfStateAlertCache = ((pocoInterface != null) ? pocoInterface.SelfStateAlert : null);
				}
				return this._SelfStateAlertCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().SelfStateAlert = value;
				this._SelfStateAlertInited = false;
			}
		}

		// Token: 0x04000F35 RID: 3893
		[Nullable(2)]
		protected IExtraAiAlert FbInstance;

		// Token: 0x04000F36 RID: 3894
		[Nullable(2)]
		protected IExtraAiAlert_SetValue PocoInterface;

		// Token: 0x04000F37 RID: 3895
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IStateAlert> _SelfStateAlertCache;

		// Token: 0x04000F38 RID: 3896
		private bool _SelfStateAlertInited;
	}
}

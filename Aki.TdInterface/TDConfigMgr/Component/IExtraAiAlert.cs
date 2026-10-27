using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000364 RID: 868
	[NullableContext(1)]
	[Nullable(0)]
	public class IExtraAiAlert
	{
		// Token: 0x0600113B RID: 4411 RVA: 0x0003A93C File Offset: 0x00038B3C
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

		// Token: 0x0600113C RID: 4412 RVA: 0x0003A974 File Offset: 0x00038B74
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

		// Token: 0x0600113D RID: 4413 RVA: 0x0003A987 File Offset: 0x00038B87
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

		// Token: 0x0600113E RID: 4414 RVA: 0x0003A99A File Offset: 0x00038B9A
		public IExtraAiAlert_SetValue ToSetValue()
		{
			return new IExtraAiAlert_SetValue
			{
				MoveAlert = this.MoveAlert,
				StopAlert = this.StopAlert,
				SelfStateAlert = this.SelfStateAlert
			};
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0003A9C8 File Offset: 0x00038BC8
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x0003AA02 File Offset: 0x00038C02
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

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x0003AA10 File Offset: 0x00038C10
		// (set) Token: 0x06001142 RID: 4418 RVA: 0x0003AA4A File Offset: 0x00038C4A
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

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x0003AA58 File Offset: 0x00038C58
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x0003AAEB File Offset: 0x00038CEB
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IStateAlert> SelfStateAlert
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().SelfStateAlert = value;
				this._SelfStateAlertInited = false;
			}
		}

		// Token: 0x04000E3E RID: 3646
		[Nullable(2)]
		protected IExtraAiAlert FbInstance;

		// Token: 0x04000E3F RID: 3647
		[Nullable(2)]
		protected IExtraAiAlert_SetValue PocoInterface;

		// Token: 0x04000E40 RID: 3648
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IStateAlert> _SelfStateAlertCache;

		// Token: 0x04000E41 RID: 3649
		private bool _SelfStateAlertInited;
	}
}

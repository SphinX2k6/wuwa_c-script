using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000969 RID: 2409
	public class TimeStopComponent : IComponentBase
	{
		// Token: 0x060035CB RID: 13771 RVA: 0x00088F68 File Offset: 0x00087168
		private TimeStopComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TimeStopComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TimeStopComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TimeStopComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x00088FA0 File Offset: 0x000871A0
		public static TimeStopComponent Create([Nullable(2)] TimeStopComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TimeStopComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x00088FB3 File Offset: 0x000871B3
		public static TimeStopComponent CreateFromSetValue([Nullable(2)] TimeStopComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TimeStopComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x00088FC8 File Offset: 0x000871C8
		public new TimeStopComponent_SetValue ToSetValue()
		{
			return new TimeStopComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ActiveState = this.ActiveState,
				StopTime = this.StopTime,
				Target = this.Target
			};
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x00089018 File Offset: 0x00087218
		// (set) Token: 0x060035D0 RID: 13776 RVA: 0x00089052 File Offset: 0x00087252
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TimeStopComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x00089060 File Offset: 0x00087260
		// (set) Token: 0x060035D2 RID: 13778 RVA: 0x0008908A File Offset: 0x0008728A
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x00089098 File Offset: 0x00087298
		// (set) Token: 0x060035D4 RID: 13780 RVA: 0x000890C3 File Offset: 0x000872C3
		public virtual string ActiveState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActiveState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ActiveState;
			}
			set
			{
				this.GetOrCreatePoco().ActiveState = value;
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x000890D1 File Offset: 0x000872D1
		// (set) Token: 0x060035D6 RID: 13782 RVA: 0x000890FC File Offset: 0x000872FC
		public virtual int StopTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StopTime;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.StopTime;
			}
			set
			{
				this.GetOrCreatePoco().StopTime = value;
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x060035D7 RID: 13783 RVA: 0x0008910C File Offset: 0x0008730C
		// (set) Token: 0x060035D8 RID: 13784 RVA: 0x0008916D File Offset: 0x0008736D
		public virtual ITimeStopTarget Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				if (this.FbInstance != null)
				{
					this._TargetCache = ITimeStopTarget.Create(this.FbInstance.Target);
				}
				else
				{
					TimeStopComponent_SetValue pocoInterface = this.PocoInterface;
					this._TargetCache = ((pocoInterface != null) ? pocoInterface.Target : null);
				}
				return this._TargetCache;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
				this._TargetInited = false;
			}
		}

		// Token: 0x0400233F RID: 9023
		[Nullable(2)]
		protected new TimeStopComponent FbInstance;

		// Token: 0x04002340 RID: 9024
		[Nullable(2)]
		protected new TimeStopComponent_SetValue PocoInterface;

		// Token: 0x04002341 RID: 9025
		private ITimeStopTarget _TargetCache;

		// Token: 0x04002342 RID: 9026
		private bool _TargetInited;
	}
}

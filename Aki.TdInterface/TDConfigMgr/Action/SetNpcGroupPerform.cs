using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021C7 RID: 8647
	[NullableContext(1)]
	[Nullable(0)]
	public class SetNpcGroupPerform : ActionParams
	{
		// Token: 0x0600BDE2 RID: 48610 RVA: 0x001B5400 File Offset: 0x001B3600
		private SetNpcGroupPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetNpcGroupPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetNpcGroupPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetNpcGroupPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600BDE3 RID: 48611 RVA: 0x001B5438 File Offset: 0x001B3638
		public static SetNpcGroupPerform Create([Nullable(2)] SetNpcGroupPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetNpcGroupPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BDE4 RID: 48612 RVA: 0x001B544B File Offset: 0x001B364B
		public static SetNpcGroupPerform CreateFromSetValue([Nullable(2)] SetNpcGroupPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetNpcGroupPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BDE5 RID: 48613 RVA: 0x001B545E File Offset: 0x001B365E
		public SetNpcGroupPerform_SetValue ToSetValue()
		{
			return new SetNpcGroupPerform_SetValue
			{
				Key = this.Key,
				PerformType = this.PerformType,
				IsWaitActionFinish = this.IsWaitActionFinish
			};
		}

		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x0600BDE6 RID: 48614 RVA: 0x001B5489 File Offset: 0x001B3689
		// (set) Token: 0x0600BDE7 RID: 48615 RVA: 0x001B54B4 File Offset: 0x001B36B4
		public virtual string Key
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Key;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Key;
			}
			set
			{
				this.GetOrCreatePoco().Key = value;
			}
		}

		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x0600BDE8 RID: 48616 RVA: 0x001B54C2 File Offset: 0x001B36C2
		// (set) Token: 0x0600BDE9 RID: 48617 RVA: 0x001B54E9 File Offset: 0x001B36E9
		public virtual ISetNpcGroupPerformType PerformType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformType;
				}
				SetNpcGroupPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformType;
			}
			set
			{
				this.GetOrCreatePoco().PerformType = value;
			}
		}

		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x0600BDEA RID: 48618 RVA: 0x001B54F8 File Offset: 0x001B36F8
		// (set) Token: 0x0600BDEB RID: 48619 RVA: 0x001B5532 File Offset: 0x001B3732
		public virtual bool? IsWaitActionFinish
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsWaitActionFinish;
				}
				SetNpcGroupPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsWaitActionFinish;
			}
			set
			{
				this.GetOrCreatePoco().IsWaitActionFinish = value;
			}
		}

		// Token: 0x04007154 RID: 29012
		[Nullable(2)]
		protected new SetNpcGroupPerform FbInstance;

		// Token: 0x04007155 RID: 29013
		[Nullable(2)]
		protected SetNpcGroupPerform_SetValue PocoInterface;
	}
}

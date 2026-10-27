using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001900 RID: 6400
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtOverrideActionInfo : ICommonBtOverrideTaskInfoBase
	{
		// Token: 0x06008923 RID: 35107 RVA: 0x00143EE8 File Offset: 0x001420E8
		private ICommonBtOverrideActionInfo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonBtOverrideActionInfo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonBtOverrideActionInfo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonBtOverrideActionInfo_SetValue());
			}
			return result;
		}

		// Token: 0x06008924 RID: 35108 RVA: 0x00143F20 File Offset: 0x00142120
		public static ICommonBtOverrideActionInfo Create([Nullable(2)] ICommonBtOverrideActionInfo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtOverrideActionInfo
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008925 RID: 35109 RVA: 0x00143F33 File Offset: 0x00142133
		public static ICommonBtOverrideActionInfo CreateFromSetValue([Nullable(2)] ICommonBtOverrideActionInfo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonBtOverrideActionInfo
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008926 RID: 35110 RVA: 0x00143F46 File Offset: 0x00142146
		public new ICommonBtOverrideActionInfo_SetValue ToSetValue()
		{
			return new ICommonBtOverrideActionInfo_SetValue
			{
				Type = this.Type,
				Action = this.Action
			};
		}

		// Token: 0x17002C66 RID: 11366
		// (get) Token: 0x06008927 RID: 35111 RVA: 0x00143F65 File Offset: 0x00142165
		// (set) Token: 0x06008928 RID: 35112 RVA: 0x00143F90 File Offset: 0x00142190
		public override ECommonBtPlaceholderTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonBtPlaceholderTargetType.Action;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C67 RID: 11367
		// (get) Token: 0x06008929 RID: 35113 RVA: 0x00143FA0 File Offset: 0x001421A0
		// (set) Token: 0x0600892A RID: 35114 RVA: 0x00144001 File Offset: 0x00142201
		public virtual ActionInfo Action
		{
			get
			{
				if (this._ActionInited)
				{
					return this._ActionCache;
				}
				this._ActionInited = true;
				if (this.FbInstance != null)
				{
					this._ActionCache = ActionInfo.Create(this.FbInstance.Action);
				}
				else
				{
					ICommonBtOverrideActionInfo_SetValue pocoInterface = this.PocoInterface;
					this._ActionCache = ((pocoInterface != null) ? pocoInterface.Action : null);
				}
				return this._ActionCache;
			}
			set
			{
				this.GetOrCreatePoco().Action = value;
				this._ActionInited = false;
			}
		}

		// Token: 0x040055FB RID: 22011
		[Nullable(2)]
		protected new ICommonBtOverrideActionInfo FbInstance;

		// Token: 0x040055FC RID: 22012
		[Nullable(2)]
		protected new ICommonBtOverrideActionInfo_SetValue PocoInterface;

		// Token: 0x040055FD RID: 22013
		private ActionInfo _ActionCache;

		// Token: 0x040055FE RID: 22014
		private bool _ActionInited;
	}
}

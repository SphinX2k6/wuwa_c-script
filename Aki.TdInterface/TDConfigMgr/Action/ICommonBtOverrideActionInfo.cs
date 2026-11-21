using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A87 RID: 6791
	public class ICommonBtOverrideActionInfo : ICommonBtOverrideTaskInfoBase
	{
		// Token: 0x06009041 RID: 36929 RVA: 0x00153670 File Offset: 0x00151870
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

		// Token: 0x06009042 RID: 36930 RVA: 0x001536A8 File Offset: 0x001518A8
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

		// Token: 0x06009043 RID: 36931 RVA: 0x001536BB File Offset: 0x001518BB
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

		// Token: 0x06009044 RID: 36932 RVA: 0x001536CE File Offset: 0x001518CE
		public new ICommonBtOverrideActionInfo_SetValue ToSetValue()
		{
			return new ICommonBtOverrideActionInfo_SetValue
			{
				Type = this.Type,
				Action = this.Action
			};
		}

		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x06009045 RID: 36933 RVA: 0x001536ED File Offset: 0x001518ED
		// (set) Token: 0x06009046 RID: 36934 RVA: 0x00153718 File Offset: 0x00151918
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

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x06009047 RID: 36935 RVA: 0x00153728 File Offset: 0x00151928
		// (set) Token: 0x06009048 RID: 36936 RVA: 0x00153789 File Offset: 0x00151989
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

		// Token: 0x04005A45 RID: 23109
		[Nullable(2)]
		protected new ICommonBtOverrideActionInfo FbInstance;

		// Token: 0x04005A46 RID: 23110
		[Nullable(2)]
		protected new ICommonBtOverrideActionInfo_SetValue PocoInterface;

		// Token: 0x04005A47 RID: 23111
		private ActionInfo _ActionCache;

		// Token: 0x04005A48 RID: 23112
		private bool _ActionInited;
	}
}

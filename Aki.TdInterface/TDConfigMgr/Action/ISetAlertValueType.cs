using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200203B RID: 8251
	public class ISetAlertValueType
	{
		// Token: 0x0600AF25 RID: 44837 RVA: 0x0018AAE4 File Offset: 0x00188CE4
		private ISetAlertValueType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetAlertValueType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetAlertValueType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetAlertValueType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF26 RID: 44838 RVA: 0x0018AB1C File Offset: 0x00188D1C
		public static ISetAlertValueType Create([Nullable(2)] ISetAlertValueType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAlertValueType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF27 RID: 44839 RVA: 0x0018AB2F File Offset: 0x00188D2F
		public static ISetAlertValueType CreateFromSetValue([Nullable(2)] ISetAlertValueType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetAlertValueType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF28 RID: 44840 RVA: 0x0018AB42 File Offset: 0x00188D42
		public ISetAlertValueType_SetValue ToSetValue()
		{
			return new ISetAlertValueType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003548 RID: 13640
		// (get) Token: 0x0600AF29 RID: 44841 RVA: 0x0018AB55 File Offset: 0x00188D55
		// (set) Token: 0x0600AF2A RID: 44842 RVA: 0x0018AB80 File Offset: 0x00188D80
		public virtual EValueChangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EValueChangeType.AddOrSub;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006855 RID: 26709
		[Nullable(2)]
		protected ISetAlertValueType FbInstance;

		// Token: 0x04006856 RID: 26710
		[Nullable(2)]
		protected ISetAlertValueType_SetValue PocoInterface;
	}
}

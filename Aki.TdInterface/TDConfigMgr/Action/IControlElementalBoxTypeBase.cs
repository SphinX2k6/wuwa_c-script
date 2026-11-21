using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AC1 RID: 6849
	public class IControlElementalBoxTypeBase
	{
		// Token: 0x06009199 RID: 37273 RVA: 0x00155B24 File Offset: 0x00153D24
		private IControlElementalBoxTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IControlElementalBoxTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IControlElementalBoxTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IControlElementalBoxTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600919A RID: 37274 RVA: 0x00155B5C File Offset: 0x00153D5C
		public static IControlElementalBoxTypeBase Create([Nullable(2)] IControlElementalBoxTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlElementalBoxTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600919B RID: 37275 RVA: 0x00155B6F File Offset: 0x00153D6F
		public static IControlElementalBoxTypeBase CreateFromSetValue([Nullable(2)] IControlElementalBoxTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IControlElementalBoxTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600919C RID: 37276 RVA: 0x00155B82 File Offset: 0x00153D82
		public IControlElementalBoxTypeBase_SetValue ToSetValue()
		{
			return new IControlElementalBoxTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x0600919D RID: 37277 RVA: 0x00155B95 File Offset: 0x00153D95
		// (set) Token: 0x0600919E RID: 37278 RVA: 0x00155BC0 File Offset: 0x00153DC0
		public virtual EControlElementalBoxType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EControlElementalBoxType.Capture;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005ADA RID: 23258
		[Nullable(2)]
		protected IControlElementalBoxTypeBase FbInstance;

		// Token: 0x04005ADB RID: 23259
		[Nullable(2)]
		protected IControlElementalBoxTypeBase_SetValue PocoInterface;
	}
}

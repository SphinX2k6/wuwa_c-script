using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000259 RID: 601
	[NullableContext(1)]
	[Nullable(0)]
	public class IComponentBase
	{
		// Token: 0x06000AE8 RID: 2792 RVA: 0x0002C7A8 File Offset: 0x0002A9A8
		private IComponentBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IComponentBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IComponentBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IComponentBase_SetValue());
			}
			return result;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0002C7E0 File Offset: 0x0002A9E0
		public static IComponentBase Create([Nullable(2)] IComponentBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IComponentBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0002C7F3 File Offset: 0x0002A9F3
		public static IComponentBase CreateFromSetValue([Nullable(2)] IComponentBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IComponentBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0002C806 File Offset: 0x0002AA06
		public IComponentBase_SetValue ToSetValue()
		{
			return new IComponentBase_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0002C828 File Offset: 0x0002AA28
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x0002C862 File Offset: 0x0002AA62
		public virtual bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				IComponentBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x0002C870 File Offset: 0x0002AA70
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x0002C89A File Offset: 0x0002AA9A
		public virtual bool? EdIsLocked
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

		// Token: 0x04000AB0 RID: 2736
		[Nullable(2)]
		protected IComponentBase FbInstance;

		// Token: 0x04000AB1 RID: 2737
		[Nullable(2)]
		protected IComponentBase_SetValue PocoInterface;
	}
}

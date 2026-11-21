using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022BE RID: 8894
	public class IVisualNovelOptionGroupConfigBase
	{
		// Token: 0x0600C1AA RID: 49578 RVA: 0x001BD8E0 File Offset: 0x001BBAE0
		private IVisualNovelOptionGroupConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelOptionGroupConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelOptionGroupConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelOptionGroupConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600C1AB RID: 49579 RVA: 0x001BD918 File Offset: 0x001BBB18
		public static IVisualNovelOptionGroupConfigBase Create([Nullable(2)] IVisualNovelOptionGroupConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C1AC RID: 49580 RVA: 0x001BD92B File Offset: 0x001BBB2B
		public static IVisualNovelOptionGroupConfigBase CreateFromSetValue([Nullable(2)] IVisualNovelOptionGroupConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C1AD RID: 49581 RVA: 0x001BD93E File Offset: 0x001BBB3E
		public IVisualNovelOptionGroupConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelOptionGroupConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x0600C1AE RID: 49582 RVA: 0x001BD951 File Offset: 0x001BBB51
		// (set) Token: 0x0600C1AF RID: 49583 RVA: 0x001BD97C File Offset: 0x001BBB7C
		public virtual EVisualNovelOptionGroupType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelOptionGroupType.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040073A7 RID: 29607
		[Nullable(2)]
		protected IVisualNovelOptionGroupConfigBase FbInstance;

		// Token: 0x040073A8 RID: 29608
		[Nullable(2)]
		protected IVisualNovelOptionGroupConfigBase_SetValue PocoInterface;
	}
}

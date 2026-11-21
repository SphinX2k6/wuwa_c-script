using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200218F RID: 8591
	public class ITalkItemStyle
	{
		// Token: 0x0600B990 RID: 47504 RVA: 0x001A9278 File Offset: 0x001A7478
		private ITalkItemStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemStyle_SetValue());
			}
			return result;
		}

		// Token: 0x0600B991 RID: 47505 RVA: 0x001A92B0 File Offset: 0x001A74B0
		public static ITalkItemStyle Create([Nullable(2)] ITalkItemStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B992 RID: 47506 RVA: 0x001A92C3 File Offset: 0x001A74C3
		public static ITalkItemStyle CreateFromSetValue([Nullable(2)] ITalkItemStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B993 RID: 47507 RVA: 0x001A92D6 File Offset: 0x001A74D6
		public ITalkItemStyle_SetValue ToSetValue()
		{
			return new ITalkItemStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x0600B994 RID: 47508 RVA: 0x001A92E9 File Offset: 0x001A74E9
		// (set) Token: 0x0600B995 RID: 47509 RVA: 0x001A9314 File Offset: 0x001A7514
		public virtual ETalkItemStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkItemStyle.InnerVoice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006F10 RID: 28432
		[Nullable(2)]
		protected ITalkItemStyle FbInstance;

		// Token: 0x04006F11 RID: 28433
		[Nullable(2)]
		protected ITalkItemStyle_SetValue PocoInterface;
	}
}

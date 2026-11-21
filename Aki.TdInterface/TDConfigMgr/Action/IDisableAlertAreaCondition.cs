using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B23 RID: 6947
	public class IDisableAlertAreaCondition
	{
		// Token: 0x06009373 RID: 37747 RVA: 0x00158CB0 File Offset: 0x00156EB0
		private IDisableAlertAreaCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableAlertAreaCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableAlertAreaCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableAlertAreaCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06009374 RID: 37748 RVA: 0x00158CE8 File Offset: 0x00156EE8
		public static IDisableAlertAreaCondition Create([Nullable(2)] IDisableAlertAreaCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAlertAreaCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009375 RID: 37749 RVA: 0x00158CFB File Offset: 0x00156EFB
		public static IDisableAlertAreaCondition CreateFromSetValue([Nullable(2)] IDisableAlertAreaCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableAlertAreaCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009376 RID: 37750 RVA: 0x00158D0E File Offset: 0x00156F0E
		public IDisableAlertAreaCondition_SetValue ToSetValue()
		{
			return new IDisableAlertAreaCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x06009377 RID: 37751 RVA: 0x00158D21 File Offset: 0x00156F21
		// (set) Token: 0x06009378 RID: 37752 RVA: 0x00158D4C File Offset: 0x00156F4C
		public virtual EDisableAlertAreaCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDisableAlertAreaCondition.DungeonCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005BA6 RID: 23462
		[Nullable(2)]
		protected IDisableAlertAreaCondition FbInstance;

		// Token: 0x04005BA7 RID: 23463
		[Nullable(2)]
		protected IDisableAlertAreaCondition_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002134 RID: 8500
	public class ISwitchDataLayersTransitionType
	{
		// Token: 0x0600B46C RID: 46188 RVA: 0x001944F0 File Offset: 0x001926F0
		private ISwitchDataLayersTransitionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwitchDataLayersTransitionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwitchDataLayersTransitionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwitchDataLayersTransitionType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B46D RID: 46189 RVA: 0x00194528 File Offset: 0x00192728
		public static ISwitchDataLayersTransitionType Create([Nullable(2)] ISwitchDataLayersTransitionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchDataLayersTransitionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B46E RID: 46190 RVA: 0x0019453B File Offset: 0x0019273B
		public static ISwitchDataLayersTransitionType CreateFromSetValue([Nullable(2)] ISwitchDataLayersTransitionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwitchDataLayersTransitionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B46F RID: 46191 RVA: 0x0019454E File Offset: 0x0019274E
		public ISwitchDataLayersTransitionType_SetValue ToSetValue()
		{
			return new ISwitchDataLayersTransitionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003677 RID: 13943
		// (get) Token: 0x0600B470 RID: 46192 RVA: 0x00194561 File Offset: 0x00192761
		// (set) Token: 0x0600B471 RID: 46193 RVA: 0x0019458C File Offset: 0x0019278C
		public virtual ESwitchDataLayersTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESwitchDataLayersTransitionType.Sequence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006ACE RID: 27342
		[Nullable(2)]
		protected ISwitchDataLayersTransitionType FbInstance;

		// Token: 0x04006ACF RID: 27343
		[Nullable(2)]
		protected ISwitchDataLayersTransitionType_SetValue PocoInterface;
	}
}

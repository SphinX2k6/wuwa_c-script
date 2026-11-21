using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E1 RID: 1505
	public class INpcSpecialMarkTriggerBlueprintFootprintEvent : INpcSpecialMarkBase
	{
		// Token: 0x06001EAE RID: 7854 RVA: 0x000569BC File Offset: 0x00054BBC
		private INpcSpecialMarkTriggerBlueprintFootprintEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcSpecialMarkTriggerBlueprintFootprintEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcSpecialMarkTriggerBlueprintFootprintEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcSpecialMarkTriggerBlueprintFootprintEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x000569F4 File Offset: 0x00054BF4
		public static INpcSpecialMarkTriggerBlueprintFootprintEvent Create([Nullable(2)] INpcSpecialMarkTriggerBlueprintFootprintEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSpecialMarkTriggerBlueprintFootprintEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00056A07 File Offset: 0x00054C07
		public static INpcSpecialMarkTriggerBlueprintFootprintEvent CreateFromSetValue([Nullable(2)] INpcSpecialMarkTriggerBlueprintFootprintEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcSpecialMarkTriggerBlueprintFootprintEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00056A1A File Offset: 0x00054C1A
		public new INpcSpecialMarkTriggerBlueprintFootprintEvent_SetValue ToSetValue()
		{
			return new INpcSpecialMarkTriggerBlueprintFootprintEvent_SetValue
			{
				Type = this.Type,
				ConfigDa = this.ConfigDa
			};
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x00056A39 File Offset: 0x00054C39
		// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x00056A64 File Offset: 0x00054C64
		public override ESpecialNpcMarkType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialNpcMarkType.TrafficLight;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x00056A72 File Offset: 0x00054C72
		// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x00056A9D File Offset: 0x00054C9D
		public virtual string ConfigDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ConfigDa;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ConfigDa;
			}
			set
			{
				this.GetOrCreatePoco().ConfigDa = value;
			}
		}

		// Token: 0x040015D1 RID: 5585
		[Nullable(2)]
		protected new INpcSpecialMarkTriggerBlueprintFootprintEvent FbInstance;

		// Token: 0x040015D2 RID: 5586
		[Nullable(2)]
		protected new INpcSpecialMarkTriggerBlueprintFootprintEvent_SetValue PocoInterface;
	}
}

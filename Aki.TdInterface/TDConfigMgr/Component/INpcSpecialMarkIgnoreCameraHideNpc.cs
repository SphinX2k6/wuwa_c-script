using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005DD RID: 1501
	public class INpcSpecialMarkIgnoreCameraHideNpc : INpcSpecialMarkBase
	{
		// Token: 0x06001E9E RID: 7838 RVA: 0x00056844 File Offset: 0x00054A44
		private INpcSpecialMarkIgnoreCameraHideNpc_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcSpecialMarkIgnoreCameraHideNpc 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcSpecialMarkIgnoreCameraHideNpc_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcSpecialMarkIgnoreCameraHideNpc_SetValue());
			}
			return result;
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0005687C File Offset: 0x00054A7C
		public static INpcSpecialMarkIgnoreCameraHideNpc Create([Nullable(2)] INpcSpecialMarkIgnoreCameraHideNpc instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSpecialMarkIgnoreCameraHideNpc
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x0005688F File Offset: 0x00054A8F
		public static INpcSpecialMarkIgnoreCameraHideNpc CreateFromSetValue([Nullable(2)] INpcSpecialMarkIgnoreCameraHideNpc_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcSpecialMarkIgnoreCameraHideNpc
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000568A2 File Offset: 0x00054AA2
		public new INpcSpecialMarkIgnoreCameraHideNpc_SetValue ToSetValue()
		{
			return new INpcSpecialMarkIgnoreCameraHideNpc_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x000568B5 File Offset: 0x00054AB5
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x000568E0 File Offset: 0x00054AE0
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

		// Token: 0x040015CB RID: 5579
		[Nullable(2)]
		protected new INpcSpecialMarkIgnoreCameraHideNpc FbInstance;

		// Token: 0x040015CC RID: 5580
		[Nullable(2)]
		protected new INpcSpecialMarkIgnoreCameraHideNpc_SetValue PocoInterface;
	}
}

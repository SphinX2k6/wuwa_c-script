using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FAC RID: 8108
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionWithCustomLoading : ITeleportTransitionType
	{
		// Token: 0x0600B24A RID: 45642 RVA: 0x0019F878 File Offset: 0x0019DA78
		private ITeleportTransitionWithCustomLoading_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionWithCustomLoading 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionWithCustomLoading_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionWithCustomLoading_SetValue());
			}
			return result;
		}

		// Token: 0x0600B24B RID: 45643 RVA: 0x0019F8B0 File Offset: 0x0019DAB0
		public static ITeleportTransitionWithCustomLoading Create([Nullable(2)] ITeleportTransitionWithCustomLoading instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCustomLoading
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B24C RID: 45644 RVA: 0x0019F8C3 File Offset: 0x0019DAC3
		public static ITeleportTransitionWithCustomLoading CreateFromSetValue([Nullable(2)] ITeleportTransitionWithCustomLoading_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCustomLoading
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B24D RID: 45645 RVA: 0x0019F8D6 File Offset: 0x0019DAD6
		public new ITeleportTransitionWithCustomLoading_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithCustomLoading_SetValue
			{
				Type = this.Type,
				ConfigId = this.ConfigId
			};
		}

		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x0600B24E RID: 45646 RVA: 0x0019F8F5 File Offset: 0x0019DAF5
		// (set) Token: 0x0600B24F RID: 45647 RVA: 0x0019F920 File Offset: 0x0019DB20
		public override ETeleportTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x0600B250 RID: 45648 RVA: 0x0019F92E File Offset: 0x0019DB2E
		// (set) Token: 0x0600B251 RID: 45649 RVA: 0x0019F959 File Offset: 0x0019DB59
		public virtual int ConfigId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ConfigId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ConfigId;
			}
			set
			{
				this.GetOrCreatePoco().ConfigId = value;
			}
		}

		// Token: 0x04006BAC RID: 27564
		[Nullable(2)]
		protected new ITeleportTransitionWithCustomLoading FbInstance;

		// Token: 0x04006BAD RID: 27565
		[Nullable(2)]
		protected new ITeleportTransitionWithCustomLoading_SetValue PocoInterface;
	}
}

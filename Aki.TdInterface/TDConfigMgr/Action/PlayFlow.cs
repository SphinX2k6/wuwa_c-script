using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002115 RID: 8469
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayFlow : ActionParams
	{
		// Token: 0x0600BA48 RID: 47688 RVA: 0x001AE69C File Offset: 0x001AC89C
		private PlayFlow_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayFlow 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayFlow_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayFlow_SetValue());
			}
			return result;
		}

		// Token: 0x0600BA49 RID: 47689 RVA: 0x001AE6D4 File Offset: 0x001AC8D4
		public static PlayFlow Create([Nullable(2)] PlayFlow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayFlow
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BA4A RID: 47690 RVA: 0x001AE6E7 File Offset: 0x001AC8E7
		public static PlayFlow CreateFromSetValue([Nullable(2)] PlayFlow_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayFlow
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BA4B RID: 47691 RVA: 0x001AE6FA File Offset: 0x001AC8FA
		public PlayFlow_SetValue ToSetValue()
		{
			return new PlayFlow_SetValue
			{
				FlowListName = this.FlowListName,
				FlowId = this.FlowId,
				StateId = this.StateId,
				FlowGuid = this.FlowGuid
			};
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x0600BA4C RID: 47692 RVA: 0x001AE731 File Offset: 0x001AC931
		// (set) Token: 0x0600BA4D RID: 47693 RVA: 0x001AE75C File Offset: 0x001AC95C
		public virtual string FlowListName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlowListName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.FlowListName;
			}
			set
			{
				this.GetOrCreatePoco().FlowListName = value;
			}
		}

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x0600BA4E RID: 47694 RVA: 0x001AE76A File Offset: 0x001AC96A
		// (set) Token: 0x0600BA4F RID: 47695 RVA: 0x001AE795 File Offset: 0x001AC995
		public virtual int FlowId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlowId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FlowId;
			}
			set
			{
				this.GetOrCreatePoco().FlowId = value;
			}
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0600BA50 RID: 47696 RVA: 0x001AE7A3 File Offset: 0x001AC9A3
		// (set) Token: 0x0600BA51 RID: 47697 RVA: 0x001AE7CE File Offset: 0x001AC9CE
		public virtual int StateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.StateId;
			}
			set
			{
				this.GetOrCreatePoco().StateId = value;
			}
		}

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x0600BA52 RID: 47698 RVA: 0x001AE7DC File Offset: 0x001AC9DC
		// (set) Token: 0x0600BA53 RID: 47699 RVA: 0x001AE803 File Offset: 0x001ACA03
		[Nullable(2)]
		public virtual string FlowGuid
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlowGuid;
				}
				PlayFlow_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FlowGuid;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FlowGuid = value;
			}
		}

		// Token: 0x04006F7F RID: 28543
		[Nullable(2)]
		protected new PlayFlow FbInstance;

		// Token: 0x04006F80 RID: 28544
		[Nullable(2)]
		protected PlayFlow_SetValue PocoInterface;
	}
}

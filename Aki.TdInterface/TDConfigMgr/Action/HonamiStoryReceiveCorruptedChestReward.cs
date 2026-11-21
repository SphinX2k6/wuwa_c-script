using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018CD RID: 6349
	public class HonamiStoryReceiveCorruptedChestReward : ActionParams
	{
		// Token: 0x06008523 RID: 34083 RVA: 0x0013D6A8 File Offset: 0x0013B8A8
		private HonamiStoryReceiveCorruptedChestReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("HonamiStoryReceiveCorruptedChestReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			HonamiStoryReceiveCorruptedChestReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new HonamiStoryReceiveCorruptedChestReward_SetValue());
			}
			return result;
		}

		// Token: 0x06008524 RID: 34084 RVA: 0x0013D6E0 File Offset: 0x0013B8E0
		public static HonamiStoryReceiveCorruptedChestReward Create([Nullable(2)] HonamiStoryReceiveCorruptedChestReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HonamiStoryReceiveCorruptedChestReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008525 RID: 34085 RVA: 0x0013D6F3 File Offset: 0x0013B8F3
		public static HonamiStoryReceiveCorruptedChestReward CreateFromSetValue([Nullable(2)] HonamiStoryReceiveCorruptedChestReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new HonamiStoryReceiveCorruptedChestReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008526 RID: 34086 RVA: 0x0013D706 File Offset: 0x0013B906
		public HonamiStoryReceiveCorruptedChestReward_SetValue ToSetValue()
		{
			return new HonamiStoryReceiveCorruptedChestReward_SetValue
			{
				Cost = this.Cost,
				CostGroup = this.CostGroup,
				ChangeSelfEntityStateAfterReceived = this.ChangeSelfEntityStateAfterReceived
			};
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x06008527 RID: 34087 RVA: 0x0013D731 File Offset: 0x0013B931
		// (set) Token: 0x06008528 RID: 34088 RVA: 0x0013D75C File Offset: 0x0013B95C
		public virtual int Cost
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Cost;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Cost;
			}
			set
			{
				this.GetOrCreatePoco().Cost = value;
			}
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x06008529 RID: 34089 RVA: 0x0013D76C File Offset: 0x0013B96C
		// (set) Token: 0x0600852A RID: 34090 RVA: 0x0013D7A6 File Offset: 0x0013B9A6
		public virtual int? CostGroup
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CostGroup;
				}
				HonamiStoryReceiveCorruptedChestReward_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CostGroup;
			}
			set
			{
				this.GetOrCreatePoco().CostGroup = value;
			}
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x0600852B RID: 34091 RVA: 0x0013D7B4 File Offset: 0x0013B9B4
		// (set) Token: 0x0600852C RID: 34092 RVA: 0x0013D7DB File Offset: 0x0013B9DB
		[Nullable(2)]
		public virtual string ChangeSelfEntityStateAfterReceived
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeSelfEntityStateAfterReceived;
				}
				HonamiStoryReceiveCorruptedChestReward_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ChangeSelfEntityStateAfterReceived;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ChangeSelfEntityStateAfterReceived = value;
			}
		}

		// Token: 0x0400549D RID: 21661
		[Nullable(2)]
		protected new HonamiStoryReceiveCorruptedChestReward FbInstance;

		// Token: 0x0400549E RID: 21662
		[Nullable(2)]
		protected HonamiStoryReceiveCorruptedChestReward_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B4F RID: 6991
	public class IDragInteractPointInteraction : IInteractPointInteraction
	{
		// Token: 0x06009485 RID: 38021 RVA: 0x0015AC9C File Offset: 0x00158E9C
		private IDragInteractPointInteraction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDragInteractPointInteraction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDragInteractPointInteraction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDragInteractPointInteraction_SetValue());
			}
			return result;
		}

		// Token: 0x06009486 RID: 38022 RVA: 0x0015ACD4 File Offset: 0x00158ED4
		public static IDragInteractPointInteraction Create([Nullable(2)] IDragInteractPointInteraction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDragInteractPointInteraction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009487 RID: 38023 RVA: 0x0015ACE7 File Offset: 0x00158EE7
		public static IDragInteractPointInteraction CreateFromSetValue([Nullable(2)] IDragInteractPointInteraction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDragInteractPointInteraction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009488 RID: 38024 RVA: 0x0015ACFA File Offset: 0x00158EFA
		public new IDragInteractPointInteraction_SetValue ToSetValue()
		{
			return new IDragInteractPointInteraction_SetValue
			{
				Type = this.Type,
				DragItemTag = this.DragItemTag,
				CheckDistance = this.CheckDistance
			};
		}

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x06009489 RID: 38025 RVA: 0x0015AD25 File Offset: 0x00158F25
		// (set) Token: 0x0600948A RID: 38026 RVA: 0x0015AD50 File Offset: 0x00158F50
		public override EInteractPointInteractionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractPointInteractionType.Drag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x0600948B RID: 38027 RVA: 0x0015AD5E File Offset: 0x00158F5E
		// (set) Token: 0x0600948C RID: 38028 RVA: 0x0015AD89 File Offset: 0x00158F89
		public virtual int DragItemTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DragItemTag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DragItemTag;
			}
			set
			{
				this.GetOrCreatePoco().DragItemTag = value;
			}
		}

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x0600948D RID: 38029 RVA: 0x0015AD98 File Offset: 0x00158F98
		// (set) Token: 0x0600948E RID: 38030 RVA: 0x0015ADD2 File Offset: 0x00158FD2
		public virtual float? CheckDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CheckDistance;
				}
				IDragInteractPointInteraction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CheckDistance;
			}
			set
			{
				this.GetOrCreatePoco().CheckDistance = value;
			}
		}

		// Token: 0x04005C1F RID: 23583
		[Nullable(2)]
		protected new IDragInteractPointInteraction FbInstance;

		// Token: 0x04005C20 RID: 23584
		[Nullable(2)]
		protected new IDragInteractPointInteraction_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011C2 RID: 4546
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackReturnDungeon
	{
		// Token: 0x06006754 RID: 26452 RVA: 0x000F7778 File Offset: 0x000F5978
		[NullableContext(1)]
		private ITrackReturnDungeon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackReturnDungeon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackReturnDungeon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackReturnDungeon_SetValue());
			}
			return result;
		}

		// Token: 0x06006755 RID: 26453 RVA: 0x000F77B0 File Offset: 0x000F59B0
		[NullableContext(1)]
		public static ITrackReturnDungeon Create([Nullable(2)] ITrackReturnDungeon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackReturnDungeon
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006756 RID: 26454 RVA: 0x000F77C3 File Offset: 0x000F59C3
		[NullableContext(1)]
		public static ITrackReturnDungeon CreateFromSetValue([Nullable(2)] ITrackReturnDungeon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackReturnDungeon
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006757 RID: 26455 RVA: 0x000F77D8 File Offset: 0x000F59D8
		[NullableContext(1)]
		public ITrackReturnDungeon_SetValue ToSetValue()
		{
			return new ITrackReturnDungeon_SetValue
			{
				DungeonId = this.DungeonId,
				IsRegroup = this.IsRegroup,
				TransitionOption = this.TransitionOption,
				TidTip = this.TidTip,
				EdTidTip = this.EdTidTip
			};
		}

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x06006758 RID: 26456 RVA: 0x000F7826 File Offset: 0x000F5A26
		// (set) Token: 0x06006759 RID: 26457 RVA: 0x000F7851 File Offset: 0x000F5A51
		public virtual int DungeonId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DungeonId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DungeonId;
			}
			set
			{
				this.GetOrCreatePoco().DungeonId = value;
			}
		}

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x0600675A RID: 26458 RVA: 0x000F7860 File Offset: 0x000F5A60
		// (set) Token: 0x0600675B RID: 26459 RVA: 0x000F789A File Offset: 0x000F5A9A
		public virtual bool? IsRegroup
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRegroup;
				}
				ITrackReturnDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsRegroup;
			}
			set
			{
				this.GetOrCreatePoco().IsRegroup = value;
			}
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x0600675C RID: 26460 RVA: 0x000F78A8 File Offset: 0x000F5AA8
		// (set) Token: 0x0600675D RID: 26461 RVA: 0x000F78CF File Offset: 0x000F5ACF
		public virtual ITeleportTransitionType TransitionOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionOption;
				}
				ITrackReturnDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TransitionOption;
			}
			set
			{
				this.GetOrCreatePoco().TransitionOption = value;
			}
		}

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x0600675E RID: 26462 RVA: 0x000F78DD File Offset: 0x000F5ADD
		// (set) Token: 0x0600675F RID: 26463 RVA: 0x000F7904 File Offset: 0x000F5B04
		public virtual string TidTip
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTip;
				}
				ITrackReturnDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidTip;
			}
			set
			{
				this.GetOrCreatePoco().TidTip = value;
			}
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x06006760 RID: 26464 RVA: 0x000F7912 File Offset: 0x000F5B12
		// (set) Token: 0x06006761 RID: 26465 RVA: 0x000F7929 File Offset: 0x000F5B29
		public virtual string EdTidTip
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidTip;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidTip = value;
			}
		}

		// Token: 0x04003E0B RID: 15883
		protected ITrackReturnDungeon FbInstance;

		// Token: 0x04003E0C RID: 15884
		protected ITrackReturnDungeon_SetValue PocoInterface;
	}
}

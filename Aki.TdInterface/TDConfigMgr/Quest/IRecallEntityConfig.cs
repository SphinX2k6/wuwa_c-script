using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001210 RID: 4624
	public class IRecallEntityConfig
	{
		// Token: 0x060067B7 RID: 26551 RVA: 0x000F8E08 File Offset: 0x000F7008
		private IRecallEntityConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecallEntityConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecallEntityConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecallEntityConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x000F8E40 File Offset: 0x000F7040
		public static IRecallEntityConfig Create([Nullable(2)] IRecallEntityConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallEntityConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060067B9 RID: 26553 RVA: 0x000F8E53 File Offset: 0x000F7053
		public static IRecallEntityConfig CreateFromSetValue([Nullable(2)] IRecallEntityConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecallEntityConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x000F8E66 File Offset: 0x000F7066
		public IRecallEntityConfig_SetValue ToSetValue()
		{
			return new IRecallEntityConfig_SetValue
			{
				EntityGroups = this.EntityGroups,
				Recalls = this.Recalls
			};
		}

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x060067BB RID: 26555 RVA: 0x000F8E88 File Offset: 0x000F7088
		// (set) Token: 0x060067BC RID: 26556 RVA: 0x000F8F1B File Offset: 0x000F711B
		public virtual List<IRecallEntityGroup> EntityGroups
		{
			get
			{
				if (this._EntityGroupsInited)
				{
					return this._EntityGroupsCache;
				}
				this._EntityGroupsInited = true;
				if (this.FbInstance != null)
				{
					List<IRecallEntityGroup> entityGroups = this.FbInstance.EntityGroups;
					if (entityGroups != null)
					{
						this._EntityGroupsCache = new List<IRecallEntityGroup>(entityGroups.Count);
						for (int i = 0; i < entityGroups.Count; i++)
						{
							this._EntityGroupsCache.Add(IRecallEntityGroup.Create(entityGroups[i]));
						}
					}
				}
				else
				{
					IRecallEntityConfig_SetValue pocoInterface = this.PocoInterface;
					this._EntityGroupsCache = ((pocoInterface != null) ? pocoInterface.EntityGroups : null);
				}
				return this._EntityGroupsCache;
			}
			set
			{
				this.GetOrCreatePoco().EntityGroups = value;
				this._EntityGroupsInited = false;
			}
		}

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x060067BD RID: 26557 RVA: 0x000F8F30 File Offset: 0x000F7130
		// (set) Token: 0x060067BE RID: 26558 RVA: 0x000F8FC3 File Offset: 0x000F71C3
		public virtual List<IRecallEntry> Recalls
		{
			get
			{
				if (this._RecallsInited)
				{
					return this._RecallsCache;
				}
				this._RecallsInited = true;
				if (this.FbInstance != null)
				{
					List<IRecallEntry> recalls = this.FbInstance.Recalls;
					if (recalls != null)
					{
						this._RecallsCache = new List<IRecallEntry>(recalls.Count);
						for (int i = 0; i < recalls.Count; i++)
						{
							this._RecallsCache.Add(IRecallEntry.Create(recalls[i]));
						}
					}
				}
				else
				{
					IRecallEntityConfig_SetValue pocoInterface = this.PocoInterface;
					this._RecallsCache = ((pocoInterface != null) ? pocoInterface.Recalls : null);
				}
				return this._RecallsCache;
			}
			set
			{
				this.GetOrCreatePoco().Recalls = value;
				this._RecallsInited = false;
			}
		}

		// Token: 0x04003E16 RID: 15894
		[Nullable(2)]
		protected IRecallEntityConfig FbInstance;

		// Token: 0x04003E17 RID: 15895
		[Nullable(2)]
		protected IRecallEntityConfig_SetValue PocoInterface;

		// Token: 0x04003E18 RID: 15896
		private List<IRecallEntityGroup> _EntityGroupsCache;

		// Token: 0x04003E19 RID: 15897
		private bool _EntityGroupsInited;

		// Token: 0x04003E1A RID: 15898
		private List<IRecallEntry> _RecallsCache;

		// Token: 0x04003E1B RID: 15899
		private bool _RecallsInited;
	}
}

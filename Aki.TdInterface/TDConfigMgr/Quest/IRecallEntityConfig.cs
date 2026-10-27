using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010E2 RID: 4322
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallEntityConfig
	{
		// Token: 0x060061BE RID: 25022 RVA: 0x000EBCE8 File Offset: 0x000E9EE8
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

		// Token: 0x060061BF RID: 25023 RVA: 0x000EBD20 File Offset: 0x000E9F20
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

		// Token: 0x060061C0 RID: 25024 RVA: 0x000EBD33 File Offset: 0x000E9F33
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

		// Token: 0x060061C1 RID: 25025 RVA: 0x000EBD46 File Offset: 0x000E9F46
		public IRecallEntityConfig_SetValue ToSetValue()
		{
			return new IRecallEntityConfig_SetValue
			{
				EntityGroups = this.EntityGroups,
				Recalls = this.Recalls
			};
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x060061C2 RID: 25026 RVA: 0x000EBD68 File Offset: 0x000E9F68
		// (set) Token: 0x060061C3 RID: 25027 RVA: 0x000EBDFB File Offset: 0x000E9FFB
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

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x060061C4 RID: 25028 RVA: 0x000EBE10 File Offset: 0x000EA010
		// (set) Token: 0x060061C5 RID: 25029 RVA: 0x000EBEA3 File Offset: 0x000EA0A3
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

		// Token: 0x04003AC9 RID: 15049
		[Nullable(2)]
		protected IRecallEntityConfig FbInstance;

		// Token: 0x04003ACA RID: 15050
		[Nullable(2)]
		protected IRecallEntityConfig_SetValue PocoInterface;

		// Token: 0x04003ACB RID: 15051
		private List<IRecallEntityGroup> _EntityGroupsCache;

		// Token: 0x04003ACC RID: 15052
		private bool _EntityGroupsInited;

		// Token: 0x04003ACD RID: 15053
		private List<IRecallEntry> _RecallsCache;

		// Token: 0x04003ACE RID: 15054
		private bool _RecallsInited;
	}
}

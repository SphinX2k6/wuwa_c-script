using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004C4 RID: 1220
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelSequenceSectionInfo
	{
		// Token: 0x060018C2 RID: 6338 RVA: 0x00049DF4 File Offset: 0x00047FF4
		private ILevelSequenceSectionInfo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelSequenceSectionInfo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelSequenceSectionInfo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelSequenceSectionInfo_SetValue());
			}
			return result;
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00049E2C File Offset: 0x0004802C
		public static ILevelSequenceSectionInfo Create([Nullable(2)] ILevelSequenceSectionInfo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelSequenceSectionInfo
			{
				FbInstance = instance
			};
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00049E3F File Offset: 0x0004803F
		public static ILevelSequenceSectionInfo CreateFromSetValue([Nullable(2)] ILevelSequenceSectionInfo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelSequenceSectionInfo
			{
				PocoInterface = value
			};
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00049E54 File Offset: 0x00048054
		public ILevelSequenceSectionInfo_SetValue ToSetValue()
		{
			return new ILevelSequenceSectionInfo_SetValue
			{
				Type = this.Type,
				Key = this.Key,
				FrameId = this.FrameId,
				State = this.State,
				LoopStates = this.LoopStates,
				ActionList = this.ActionList
			};
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060018C6 RID: 6342 RVA: 0x00049EAE File Offset: 0x000480AE
		// (set) Token: 0x060018C7 RID: 6343 RVA: 0x00049ED9 File Offset: 0x000480D9
		public virtual ELevelSequenceSectionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELevelSequenceSectionType.Mark;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x00049EE7 File Offset: 0x000480E7
		// (set) Token: 0x060018C9 RID: 6345 RVA: 0x00049F12 File Offset: 0x00048112
		public virtual string Key
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Key;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Key;
			}
			set
			{
				this.GetOrCreatePoco().Key = value;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x00049F20 File Offset: 0x00048120
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x00049F4B File Offset: 0x0004814B
		public virtual int FrameId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FrameId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FrameId;
			}
			set
			{
				this.GetOrCreatePoco().FrameId = value;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x00049F59 File Offset: 0x00048159
		// (set) Token: 0x060018CD RID: 6349 RVA: 0x00049F80 File Offset: 0x00048180
		[Nullable(2)]
		public virtual string State
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				ILevelSequenceSectionInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.State;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x00049F8E File Offset: 0x0004818E
		// (set) Token: 0x060018CF RID: 6351 RVA: 0x00049FB5 File Offset: 0x000481B5
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> LoopStates
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoopStates;
				}
				ILevelSequenceSectionInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LoopStates;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().LoopStates = value;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x00049FC4 File Offset: 0x000481C4
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x0004A057 File Offset: 0x00048257
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> ActionList
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActionListInited)
				{
					return this._ActionListCache;
				}
				this._ActionListInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> actionList = this.FbInstance.ActionList;
					if (actionList != null)
					{
						this._ActionListCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(actionList.Count);
						for (int i = 0; i < actionList.Count; i++)
						{
							this._ActionListCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(actionList[i]));
						}
					}
				}
				else
				{
					ILevelSequenceSectionInfo_SetValue pocoInterface = this.PocoInterface;
					this._ActionListCache = ((pocoInterface != null) ? pocoInterface.ActionList : null);
				}
				return this._ActionListCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().ActionList = value;
				this._ActionListInited = false;
			}
		}

		// Token: 0x04001254 RID: 4692
		[Nullable(2)]
		protected ILevelSequenceSectionInfo FbInstance;

		// Token: 0x04001255 RID: 4693
		[Nullable(2)]
		protected ILevelSequenceSectionInfo_SetValue PocoInterface;

		// Token: 0x04001256 RID: 4694
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionListCache;

		// Token: 0x04001257 RID: 4695
		private bool _ActionListInited;
	}
}

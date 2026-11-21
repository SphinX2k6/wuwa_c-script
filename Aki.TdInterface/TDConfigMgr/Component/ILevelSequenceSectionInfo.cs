using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200051D RID: 1309
	public class ILevelSequenceSectionInfo
	{
		// Token: 0x06001A5C RID: 6748 RVA: 0x0004DB3C File Offset: 0x0004BD3C
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

		// Token: 0x06001A5D RID: 6749 RVA: 0x0004DB74 File Offset: 0x0004BD74
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

		// Token: 0x06001A5E RID: 6750 RVA: 0x0004DB87 File Offset: 0x0004BD87
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

		// Token: 0x06001A5F RID: 6751 RVA: 0x0004DB9C File Offset: 0x0004BD9C
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

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x0004DBF6 File Offset: 0x0004BDF6
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0004DC21 File Offset: 0x0004BE21
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

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0004DC2F File Offset: 0x0004BE2F
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0004DC5A File Offset: 0x0004BE5A
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

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x0004DC68 File Offset: 0x0004BE68
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x0004DC93 File Offset: 0x0004BE93
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

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x0004DCA1 File Offset: 0x0004BEA1
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x0004DCC8 File Offset: 0x0004BEC8
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

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0004DCD6 File Offset: 0x0004BED6
		// (set) Token: 0x06001A69 RID: 6761 RVA: 0x0004DCFD File Offset: 0x0004BEFD
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> LoopStates
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().LoopStates = value;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x0004DD0C File Offset: 0x0004BF0C
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x0004DD9F File Offset: 0x0004BF9F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> ActionList
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().ActionList = value;
				this._ActionListInited = false;
			}
		}

		// Token: 0x04001376 RID: 4982
		[Nullable(2)]
		protected ILevelSequenceSectionInfo FbInstance;

		// Token: 0x04001377 RID: 4983
		[Nullable(2)]
		protected ILevelSequenceSectionInfo_SetValue PocoInterface;

		// Token: 0x04001378 RID: 4984
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionListCache;

		// Token: 0x04001379 RID: 4985
		private bool _ActionListInited;
	}
}

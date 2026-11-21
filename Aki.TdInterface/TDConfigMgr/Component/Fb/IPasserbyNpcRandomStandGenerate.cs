using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC4 RID: 3524
	public class IPasserbyNpcRandomStandGenerate : IPasserbyNpcGenerateTypeBase
	{
		// Token: 0x06005004 RID: 20484 RVA: 0x000C6D7D File Offset: 0x000C4F7D
		public static IPasserbyNpcRandomStandGenerate Create(IPasserbyNpcRandomStandGenerate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcRandomStandGenerate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x06005005 RID: 20485 RVA: 0x000C6D9C File Offset: 0x000C4F9C
		public override EPasserbyNpcGenerateType Type
		{
			get
			{
				return (EPasserbyNpcGenerateType)this.Instance.Type;
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06005006 RID: 20486 RVA: 0x000C6DA9 File Offset: 0x000C4FA9
		public virtual IPasserbyNpcSelfSpawnCenterPos SpawnCenterPos
		{
			get
			{
				if (this._SpawnCenterPosInited)
				{
					return this._SpawnCenterPosCache;
				}
				this._SpawnCenterPosInited = true;
				this._SpawnCenterPosCache = IPasserbyNpcSelfSpawnCenterPos.Create(this.Instance.SpawnCenterPos);
				return this._SpawnCenterPosCache;
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06005007 RID: 20487 RVA: 0x000C6DE0 File Offset: 0x000C4FE0
		public virtual List<IPasserbyNpcRandomGroup> Groups
		{
			get
			{
				if (this._GroupsInited)
				{
					return this._GroupsCache;
				}
				this._GroupsInited = true;
				int groupsLength = this.Instance.GroupsLength;
				this._GroupsCache = new List<IPasserbyNpcRandomGroup>(groupsLength);
				for (int i = 0; i < groupsLength; i++)
				{
					this._GroupsCache.Add(IPasserbyNpcRandomGroup.Create(this.Instance.Groups(i)));
				}
				return this._GroupsCache;
			}
		}

		// Token: 0x04002D95 RID: 11669
		private IPasserbyNpcRandomStandGenerate Instance;

		// Token: 0x04002D96 RID: 11670
		[Nullable(2)]
		private IPasserbyNpcSelfSpawnCenterPos _SpawnCenterPosCache;

		// Token: 0x04002D97 RID: 11671
		private bool _SpawnCenterPosInited;

		// Token: 0x04002D98 RID: 11672
		private List<IPasserbyNpcRandomGroup> _GroupsCache;

		// Token: 0x04002D99 RID: 11673
		private bool _GroupsInited;
	}
}

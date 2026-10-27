using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E07 RID: 3591
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoLevelCenter : IWuWaGoEntityBase
	{
		// Token: 0x0600514A RID: 20810 RVA: 0x000C8901 File Offset: 0x000C6B01
		public static IWuWaGoLevelCenter Create(IWuWaGoLevelCenter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoLevelCenter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x0600514B RID: 20811 RVA: 0x000C8920 File Offset: 0x000C6B20
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x0600514C RID: 20812 RVA: 0x000C892D File Offset: 0x000C6B2D
		public virtual string LevelKey
		{
			get
			{
				return this.Instance.LevelKey;
			}
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x0600514D RID: 20813 RVA: 0x000C893C File Offset: 0x000C6B3C
		public virtual List<int> LevelEntityIds
		{
			get
			{
				if (this._LevelEntityIdsInited)
				{
					return this._LevelEntityIdsCache;
				}
				this._LevelEntityIdsInited = true;
				int levelEntityIdsLength = this.Instance.LevelEntityIdsLength;
				this._LevelEntityIdsCache = new List<int>(levelEntityIdsLength);
				for (int i = 0; i < levelEntityIdsLength; i++)
				{
					this._LevelEntityIdsCache.Add(this.Instance.LevelEntityIds(i));
				}
				return this._LevelEntityIdsCache;
			}
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x0600514E RID: 20814 RVA: 0x000C89A0 File Offset: 0x000C6BA0
		[Nullable(2)]
		public virtual string EdActorPath
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04002EC8 RID: 11976
		private IWuWaGoLevelCenter Instance;

		// Token: 0x04002EC9 RID: 11977
		private List<int> _LevelEntityIdsCache;

		// Token: 0x04002ECA RID: 11978
		private bool _LevelEntityIdsInited;
	}
}

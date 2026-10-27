using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002932 RID: 10546
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportDungeonFunction : EnableFunction
	{
		// Token: 0x0600E9F7 RID: 59895 RVA: 0x00224687 File Offset: 0x00222887
		[NullableContext(1)]
		public static ITeleportDungeonFunction Create(ITeleportDungeonFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportDungeonFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004955 RID: 18773
		// (get) Token: 0x0600E9F8 RID: 59896 RVA: 0x002246A6 File Offset: 0x002228A6
		public override EEnableFunctionType Type
		{
			get
			{
				return (EEnableFunctionType)this.Instance.Type;
			}
		}

		// Token: 0x17004956 RID: 18774
		// (get) Token: 0x0600E9F9 RID: 59897 RVA: 0x002246B3 File Offset: 0x002228B3
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x17004957 RID: 18775
		// (get) Token: 0x0600E9FA RID: 59898 RVA: 0x002246C0 File Offset: 0x002228C0
		public virtual List<int> DungeonList
		{
			get
			{
				if (this._DungeonListInited)
				{
					return this._DungeonListCache;
				}
				this._DungeonListInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int dungeonListLength = this.Instance.DungeonListLength;
				this._DungeonListCache = new List<int>(dungeonListLength);
				for (int i = 0; i < dungeonListLength; i++)
				{
					this._DungeonListCache.Add(this.Instance.DungeonList(i));
				}
				return this._DungeonListCache;
			}
		}

		// Token: 0x0400810C RID: 33036
		private ITeleportDungeonFunction Instance;

		// Token: 0x0400810D RID: 33037
		private List<int> _DungeonListCache;

		// Token: 0x0400810E RID: 33038
		private bool _DungeonListInited;
	}
}

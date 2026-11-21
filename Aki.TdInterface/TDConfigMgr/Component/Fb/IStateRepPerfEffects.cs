using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B5D RID: 2909
	public class IStateRepPerfEffects : IStateRepPerfBase
	{
		// Token: 0x0600426C RID: 17004 RVA: 0x000A8C09 File Offset: 0x000A6E09
		public static IStateRepPerfEffects Create(IStateRepPerfEffects? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfEffects
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x0600426D RID: 17005 RVA: 0x000A8C28 File Offset: 0x000A6E28
		public override EStateRepPerfType Type
		{
			get
			{
				return (EStateRepPerfType)this.Instance.Type;
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x0600426E RID: 17006 RVA: 0x000A8C38 File Offset: 0x000A6E38
		public virtual List<int> GamePlayCues
		{
			get
			{
				if (this._GamePlayCuesInited)
				{
					return this._GamePlayCuesCache;
				}
				this._GamePlayCuesInited = true;
				int gamePlayCuesLength = this.Instance.GamePlayCuesLength;
				this._GamePlayCuesCache = new List<int>(gamePlayCuesLength);
				for (int i = 0; i < gamePlayCuesLength; i++)
				{
					this._GamePlayCuesCache.Add(this.Instance.GamePlayCues(i));
				}
				return this._GamePlayCuesCache;
			}
		}

		// Token: 0x040024C8 RID: 9416
		private IStateRepPerfEffects Instance;

		// Token: 0x040024C9 RID: 9417
		private List<int> _GamePlayCuesCache;

		// Token: 0x040024CA RID: 9418
		private bool _GamePlayCuesInited;
	}
}

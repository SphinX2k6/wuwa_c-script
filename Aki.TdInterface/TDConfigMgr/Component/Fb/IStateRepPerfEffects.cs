using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A93 RID: 2707
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateRepPerfEffects : IStateRepPerfBase
	{
		// Token: 0x06003E43 RID: 15939 RVA: 0x0009F651 File Offset: 0x0009D851
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

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06003E44 RID: 15940 RVA: 0x0009F670 File Offset: 0x0009D870
		public override EStateRepPerfType Type
		{
			get
			{
				return (EStateRepPerfType)this.Instance.Type;
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06003E45 RID: 15941 RVA: 0x0009F680 File Offset: 0x0009D880
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

		// Token: 0x040022AC RID: 8876
		private IStateRepPerfEffects Instance;

		// Token: 0x040022AD RID: 8877
		private List<int> _GamePlayCuesCache;

		// Token: 0x040022AE RID: 8878
		private bool _GamePlayCuesInited;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D8B RID: 3467
	[NullableContext(1)]
	[Nullable(0)]
	public class IChildEntityStateControl
	{
		// Token: 0x06004ED6 RID: 20182 RVA: 0x000C3741 File Offset: 0x000C1941
		public static IChildEntityStateControl Create(IChildEntityStateControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChildEntityStateControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x06004ED7 RID: 20183 RVA: 0x000C3760 File Offset: 0x000C1960
		public virtual ETemplateEntityGroupType GroupType
		{
			get
			{
				return (ETemplateEntityGroupType)this.Instance.GroupType;
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x06004ED8 RID: 20184 RVA: 0x000C376D File Offset: 0x000C196D
		public virtual string InitState
		{
			get
			{
				return this.Instance.InitState;
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x06004ED9 RID: 20185 RVA: 0x000C377C File Offset: 0x000C197C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IChildStateChangedConfig> OnChildStateChangedConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._OnChildStateChangedConfigsInited)
				{
					return this._OnChildStateChangedConfigsCache;
				}
				this._OnChildStateChangedConfigsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int onChildStateChangedConfigsLength = this.Instance.OnChildStateChangedConfigsLength;
				this._OnChildStateChangedConfigsCache = new List<IChildStateChangedConfig>(onChildStateChangedConfigsLength);
				for (int i = 0; i < onChildStateChangedConfigsLength; i++)
				{
					this._OnChildStateChangedConfigsCache.Add(IChildStateChangedConfig.Create(this.Instance.OnChildStateChangedConfigs(i)));
				}
				return this._OnChildStateChangedConfigsCache;
			}
		}

		// Token: 0x04002D44 RID: 11588
		private IChildEntityStateControl Instance;

		// Token: 0x04002D45 RID: 11589
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IChildStateChangedConfig> _OnChildStateChangedConfigsCache;

		// Token: 0x04002D46 RID: 11590
		private bool _OnChildStateChangedConfigsInited;
	}
}

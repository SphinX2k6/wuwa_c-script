using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E87 RID: 3719
	public class IChildEntityStateControl
	{
		// Token: 0x060053FB RID: 21499 RVA: 0x000CEF91 File Offset: 0x000CD191
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

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x000CEFB0 File Offset: 0x000CD1B0
		public virtual ETemplateEntityGroupType GroupType
		{
			get
			{
				return (ETemplateEntityGroupType)this.Instance.GroupType;
			}
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x060053FD RID: 21501 RVA: 0x000CEFBD File Offset: 0x000CD1BD
		public virtual string InitState
		{
			get
			{
				return this.Instance.InitState;
			}
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x060053FE RID: 21502 RVA: 0x000CEFCC File Offset: 0x000CD1CC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IChildStateChangedConfig> OnChildStateChangedConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x0400300A RID: 12298
		private IChildEntityStateControl Instance;

		// Token: 0x0400300B RID: 12299
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IChildStateChangedConfig> _OnChildStateChangedConfigsCache;

		// Token: 0x0400300C RID: 12300
		private bool _OnChildStateChangedConfigsInited;
	}
}

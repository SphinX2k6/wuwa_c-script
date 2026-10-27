using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200023D RID: 573
	[NullableContext(1)]
	[Nullable(0)]
	public class IChildEntityStateControl
	{
		// Token: 0x06000A36 RID: 2614 RVA: 0x0002AEF4 File Offset: 0x000290F4
		private IChildEntityStateControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChildEntityStateControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChildEntityStateControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChildEntityStateControl_SetValue());
			}
			return result;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0002AF2C File Offset: 0x0002912C
		public static IChildEntityStateControl Create([Nullable(2)] IChildEntityStateControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChildEntityStateControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0002AF3F File Offset: 0x0002913F
		public static IChildEntityStateControl CreateFromSetValue([Nullable(2)] IChildEntityStateControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChildEntityStateControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0002AF52 File Offset: 0x00029152
		public IChildEntityStateControl_SetValue ToSetValue()
		{
			return new IChildEntityStateControl_SetValue
			{
				GroupType = this.GroupType,
				InitState = this.InitState,
				OnChildStateChangedConfigs = this.OnChildStateChangedConfigs
			};
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x0002AF7D File Offset: 0x0002917D
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x0002AFA8 File Offset: 0x000291A8
		public virtual ETemplateEntityGroupType GroupType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GroupType;
				}
				if (this.PocoInterface == null)
				{
					return (ETemplateEntityGroupType)0;
				}
				return this.PocoInterface.GroupType;
			}
			set
			{
				this.GetOrCreatePoco().GroupType = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x0002AFB6 File Offset: 0x000291B6
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x0002AFE1 File Offset: 0x000291E1
		public virtual string InitState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.InitState;
			}
			set
			{
				this.GetOrCreatePoco().InitState = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0002AFF0 File Offset: 0x000291F0
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x0002B083 File Offset: 0x00029283
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
				if (this.FbInstance != null)
				{
					List<IChildStateChangedConfig> onChildStateChangedConfigs = this.FbInstance.OnChildStateChangedConfigs;
					if (onChildStateChangedConfigs != null)
					{
						this._OnChildStateChangedConfigsCache = new List<IChildStateChangedConfig>(onChildStateChangedConfigs.Count);
						for (int i = 0; i < onChildStateChangedConfigs.Count; i++)
						{
							this._OnChildStateChangedConfigsCache.Add(IChildStateChangedConfig.Create(onChildStateChangedConfigs[i]));
						}
					}
				}
				else
				{
					IChildEntityStateControl_SetValue pocoInterface = this.PocoInterface;
					this._OnChildStateChangedConfigsCache = ((pocoInterface != null) ? pocoInterface.OnChildStateChangedConfigs : null);
				}
				return this._OnChildStateChangedConfigsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().OnChildStateChangedConfigs = value;
				this._OnChildStateChangedConfigsInited = false;
			}
		}

		// Token: 0x04000A45 RID: 2629
		[Nullable(2)]
		protected IChildEntityStateControl FbInstance;

		// Token: 0x04000A46 RID: 2630
		[Nullable(2)]
		protected IChildEntityStateControl_SetValue PocoInterface;

		// Token: 0x04000A47 RID: 2631
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IChildStateChangedConfig> _OnChildStateChangedConfigsCache;

		// Token: 0x04000A48 RID: 2632
		private bool _OnChildStateChangedConfigsInited;
	}
}

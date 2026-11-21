using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000264 RID: 612
	public class IChildEntityStateControl
	{
		// Token: 0x06000AAA RID: 2730 RVA: 0x0002C6B4 File Offset: 0x0002A8B4
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

		// Token: 0x06000AAB RID: 2731 RVA: 0x0002C6EC File Offset: 0x0002A8EC
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

		// Token: 0x06000AAC RID: 2732 RVA: 0x0002C6FF File Offset: 0x0002A8FF
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

		// Token: 0x06000AAD RID: 2733 RVA: 0x0002C712 File Offset: 0x0002A912
		public IChildEntityStateControl_SetValue ToSetValue()
		{
			return new IChildEntityStateControl_SetValue
			{
				GroupType = this.GroupType,
				InitState = this.InitState,
				OnChildStateChangedConfigs = this.OnChildStateChangedConfigs
			};
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0002C73D File Offset: 0x0002A93D
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x0002C768 File Offset: 0x0002A968
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

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0002C776 File Offset: 0x0002A976
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x0002C7A1 File Offset: 0x0002A9A1
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

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x0002C7B0 File Offset: 0x0002A9B0
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x0002C843 File Offset: 0x0002AA43
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().OnChildStateChangedConfigs = value;
				this._OnChildStateChangedConfigsInited = false;
			}
		}

		// Token: 0x04000ACF RID: 2767
		[Nullable(2)]
		protected IChildEntityStateControl FbInstance;

		// Token: 0x04000AD0 RID: 2768
		[Nullable(2)]
		protected IChildEntityStateControl_SetValue PocoInterface;

		// Token: 0x04000AD1 RID: 2769
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IChildStateChangedConfig> _OnChildStateChangedConfigsCache;

		// Token: 0x04000AD2 RID: 2770
		private bool _OnChildStateChangedConfigsInited;
	}
}

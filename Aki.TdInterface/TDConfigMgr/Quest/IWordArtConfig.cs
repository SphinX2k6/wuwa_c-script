using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001212 RID: 4626
	[NullableContext(1)]
	[Nullable(0)]
	public class IWordArtConfig
	{
		// Token: 0x060068F2 RID: 26866 RVA: 0x000FA44C File Offset: 0x000F864C
		private IWordArtConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWordArtConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWordArtConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWordArtConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x000FA484 File Offset: 0x000F8684
		public static IWordArtConfig Create([Nullable(2)] IWordArtConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWordArtConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x000FA497 File Offset: 0x000F8697
		public static IWordArtConfig CreateFromSetValue([Nullable(2)] IWordArtConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWordArtConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x000FA4AA File Offset: 0x000F86AA
		public IWordArtConfig_SetValue ToSetValue()
		{
			return new IWordArtConfig_SetValue
			{
				EffectiveTarget = this.EffectiveTarget,
				Resource = this.Resource
			};
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x060068F6 RID: 26870 RVA: 0x000FA4CC File Offset: 0x000F86CC
		// (set) Token: 0x060068F7 RID: 26871 RVA: 0x000FA52D File Offset: 0x000F872D
		public virtual INumberWordArtEffectiveTargetType EffectiveTarget
		{
			get
			{
				if (this._EffectiveTargetInited)
				{
					return this._EffectiveTargetCache;
				}
				this._EffectiveTargetInited = true;
				if (this.FbInstance != null)
				{
					this._EffectiveTargetCache = INumberWordArtEffectiveTargetType.Create(this.FbInstance.EffectiveTarget);
				}
				else
				{
					IWordArtConfig_SetValue pocoInterface = this.PocoInterface;
					this._EffectiveTargetCache = ((pocoInterface != null) ? pocoInterface.EffectiveTarget : null);
				}
				return this._EffectiveTargetCache;
			}
			set
			{
				this.GetOrCreatePoco().EffectiveTarget = value;
				this._EffectiveTargetInited = false;
			}
		}

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x060068F8 RID: 26872 RVA: 0x000FA544 File Offset: 0x000F8744
		// (set) Token: 0x060068F9 RID: 26873 RVA: 0x000FA5A5 File Offset: 0x000F87A5
		public virtual IWordArtDefaultResourceType Resource
		{
			get
			{
				if (this._ResourceInited)
				{
					return this._ResourceCache;
				}
				this._ResourceInited = true;
				if (this.FbInstance != null)
				{
					this._ResourceCache = IWordArtDefaultResourceType.Create(this.FbInstance.Resource);
				}
				else
				{
					IWordArtConfig_SetValue pocoInterface = this.PocoInterface;
					this._ResourceCache = ((pocoInterface != null) ? pocoInterface.Resource : null);
				}
				return this._ResourceCache;
			}
			set
			{
				this.GetOrCreatePoco().Resource = value;
				this._ResourceInited = false;
			}
		}

		// Token: 0x04003EC4 RID: 16068
		[Nullable(2)]
		protected IWordArtConfig FbInstance;

		// Token: 0x04003EC5 RID: 16069
		[Nullable(2)]
		protected IWordArtConfig_SetValue PocoInterface;

		// Token: 0x04003EC6 RID: 16070
		private INumberWordArtEffectiveTargetType _EffectiveTargetCache;

		// Token: 0x04003EC7 RID: 16071
		private bool _EffectiveTargetInited;

		// Token: 0x04003EC8 RID: 16072
		private IWordArtDefaultResourceType _ResourceCache;

		// Token: 0x04003EC9 RID: 16073
		private bool _ResourceInited;
	}
}

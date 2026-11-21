using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FA7 RID: 8103
	public class IRemoveEffectBase
	{
		// Token: 0x0600AC45 RID: 44101 RVA: 0x001858DC File Offset: 0x00183ADC
		private IRemoveEffectBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRemoveEffectBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRemoveEffectBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRemoveEffectBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC46 RID: 44102 RVA: 0x00185914 File Offset: 0x00183B14
		public static IRemoveEffectBase Create([Nullable(2)] IRemoveEffectBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemoveEffectBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC47 RID: 44103 RVA: 0x00185927 File Offset: 0x00183B27
		public static IRemoveEffectBase CreateFromSetValue([Nullable(2)] IRemoveEffectBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRemoveEffectBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC48 RID: 44104 RVA: 0x0018593A File Offset: 0x00183B3A
		public IRemoveEffectBase_SetValue ToSetValue()
		{
			return new IRemoveEffectBase_SetValue
			{
				Type = this.Type,
				Path = this.Path
			};
		}

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x0600AC49 RID: 44105 RVA: 0x00185959 File Offset: 0x00183B59
		// (set) Token: 0x0600AC4A RID: 44106 RVA: 0x00185984 File Offset: 0x00183B84
		public virtual EEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEffectType.Effect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x0600AC4B RID: 44107 RVA: 0x00185992 File Offset: 0x00183B92
		// (set) Token: 0x0600AC4C RID: 44108 RVA: 0x001859BD File Offset: 0x00183BBD
		public virtual string Path
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Path;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Path;
			}
			set
			{
				this.GetOrCreatePoco().Path = value;
			}
		}

		// Token: 0x04006701 RID: 26369
		[Nullable(2)]
		protected IRemoveEffectBase FbInstance;

		// Token: 0x04006702 RID: 26370
		[Nullable(2)]
		protected IRemoveEffectBase_SetValue PocoInterface;
	}
}

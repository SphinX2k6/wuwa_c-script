using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D94 RID: 7572
	[NullableContext(1)]
	[Nullable(0)]
	public class IRemoveEffectBase
	{
		// Token: 0x0600A24D RID: 41549 RVA: 0x00171370 File Offset: 0x0016F570
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

		// Token: 0x0600A24E RID: 41550 RVA: 0x001713A8 File Offset: 0x0016F5A8
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

		// Token: 0x0600A24F RID: 41551 RVA: 0x001713BB File Offset: 0x0016F5BB
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

		// Token: 0x0600A250 RID: 41552 RVA: 0x001713CE File Offset: 0x0016F5CE
		public IRemoveEffectBase_SetValue ToSetValue()
		{
			return new IRemoveEffectBase_SetValue
			{
				Type = this.Type,
				Path = this.Path
			};
		}

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x0600A251 RID: 41553 RVA: 0x001713ED File Offset: 0x0016F5ED
		// (set) Token: 0x0600A252 RID: 41554 RVA: 0x00171418 File Offset: 0x0016F618
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

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0600A253 RID: 41555 RVA: 0x00171426 File Offset: 0x0016F626
		// (set) Token: 0x0600A254 RID: 41556 RVA: 0x00171451 File Offset: 0x0016F651
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

		// Token: 0x04006180 RID: 24960
		[Nullable(2)]
		protected IRemoveEffectBase FbInstance;

		// Token: 0x04006181 RID: 24961
		[Nullable(2)]
		protected IRemoveEffectBase_SetValue PocoInterface;
	}
}

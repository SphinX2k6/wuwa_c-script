using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200093A RID: 2362
	public class SimpleCombatComponent : IComponentBase
	{
		// Token: 0x0600344F RID: 13391 RVA: 0x00085788 File Offset: 0x00083988
		private SimpleCombatComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SimpleCombatComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SimpleCombatComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SimpleCombatComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x000857C0 File Offset: 0x000839C0
		public static SimpleCombatComponent Create([Nullable(2)] SimpleCombatComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SimpleCombatComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x000857D3 File Offset: 0x000839D3
		public static SimpleCombatComponent CreateFromSetValue([Nullable(2)] SimpleCombatComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SimpleCombatComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x000857E6 File Offset: 0x000839E6
		public new SimpleCombatComponent_SetValue ToSetValue()
		{
			return new SimpleCombatComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Id = this.Id
			};
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06003453 RID: 13395 RVA: 0x00085814 File Offset: 0x00083A14
		// (set) Token: 0x06003454 RID: 13396 RVA: 0x0008584E File Offset: 0x00083A4E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SimpleCombatComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06003455 RID: 13397 RVA: 0x0008585C File Offset: 0x00083A5C
		// (set) Token: 0x06003456 RID: 13398 RVA: 0x00085886 File Offset: 0x00083A86
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06003457 RID: 13399 RVA: 0x00085894 File Offset: 0x00083A94
		// (set) Token: 0x06003458 RID: 13400 RVA: 0x000858BF File Offset: 0x00083ABF
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04002258 RID: 8792
		[Nullable(2)]
		protected new SimpleCombatComponent FbInstance;

		// Token: 0x04002259 RID: 8793
		[Nullable(2)]
		protected new SimpleCombatComponent_SetValue PocoInterface;
	}
}

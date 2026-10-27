using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008CC RID: 2252
	[NullableContext(1)]
	[Nullable(0)]
	public class TreasureBoxComponent : IComponentBase
	{
		// Token: 0x060032D3 RID: 13011 RVA: 0x00082654 File Offset: 0x00080854
		private TreasureBoxComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TreasureBoxComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TreasureBoxComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TreasureBoxComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x0008268C File Offset: 0x0008088C
		public static TreasureBoxComponent Create([Nullable(2)] TreasureBoxComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TreasureBoxComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x0008269F File Offset: 0x0008089F
		public static TreasureBoxComponent CreateFromSetValue([Nullable(2)] TreasureBoxComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TreasureBoxComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x000826B2 File Offset: 0x000808B2
		public new TreasureBoxComponent_SetValue ToSetValue()
		{
			return new TreasureBoxComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				TypeId = this.TypeId,
				IsSupportDiscoverDevice = this.IsSupportDiscoverDevice
			};
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x060032D7 RID: 13015 RVA: 0x000826EC File Offset: 0x000808EC
		// (set) Token: 0x060032D8 RID: 13016 RVA: 0x00082726 File Offset: 0x00080926
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TreasureBoxComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x060032D9 RID: 13017 RVA: 0x00082734 File Offset: 0x00080934
		// (set) Token: 0x060032DA RID: 13018 RVA: 0x0008275E File Offset: 0x0008095E
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

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x060032DB RID: 13019 RVA: 0x0008276C File Offset: 0x0008096C
		// (set) Token: 0x060032DC RID: 13020 RVA: 0x00082797 File Offset: 0x00080997
		public virtual int TypeId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TypeId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TypeId;
			}
			set
			{
				this.GetOrCreatePoco().TypeId = value;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x060032DD RID: 13021 RVA: 0x000827A8 File Offset: 0x000809A8
		// (set) Token: 0x060032DE RID: 13022 RVA: 0x000827E2 File Offset: 0x000809E2
		public virtual bool? IsSupportDiscoverDevice
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSupportDiscoverDevice;
				}
				TreasureBoxComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsSupportDiscoverDevice;
			}
			set
			{
				this.GetOrCreatePoco().IsSupportDiscoverDevice = value;
			}
		}

		// Token: 0x04002160 RID: 8544
		[Nullable(2)]
		protected new TreasureBoxComponent FbInstance;

		// Token: 0x04002161 RID: 8545
		[Nullable(2)]
		protected new TreasureBoxComponent_SetValue PocoInterface;
	}
}

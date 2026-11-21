using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000983 RID: 2435
	public class VisionComponent : IComponentBase
	{
		// Token: 0x060036B9 RID: 14009 RVA: 0x0008B31C File Offset: 0x0008951C
		private VisionComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VisionComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VisionComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VisionComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x0008B354 File Offset: 0x00089554
		public static VisionComponent Create([Nullable(2)] VisionComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VisionComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x0008B367 File Offset: 0x00089567
		public static VisionComponent CreateFromSetValue([Nullable(2)] VisionComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VisionComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x0008B37A File Offset: 0x0008957A
		public new VisionComponent_SetValue ToSetValue()
		{
			return new VisionComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				VisionId = this.VisionId
			};
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x060036BD RID: 14013 RVA: 0x0008B3A8 File Offset: 0x000895A8
		// (set) Token: 0x060036BE RID: 14014 RVA: 0x0008B3E2 File Offset: 0x000895E2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				VisionComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x060036BF RID: 14015 RVA: 0x0008B3F0 File Offset: 0x000895F0
		// (set) Token: 0x060036C0 RID: 14016 RVA: 0x0008B41A File Offset: 0x0008961A
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

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x060036C1 RID: 14017 RVA: 0x0008B428 File Offset: 0x00089628
		// (set) Token: 0x060036C2 RID: 14018 RVA: 0x0008B453 File Offset: 0x00089653
		public virtual int VisionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisionId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.VisionId;
			}
			set
			{
				this.GetOrCreatePoco().VisionId = value;
			}
		}

		// Token: 0x040023D1 RID: 9169
		[Nullable(2)]
		protected new VisionComponent FbInstance;

		// Token: 0x040023D2 RID: 9170
		[Nullable(2)]
		protected new VisionComponent_SetValue PocoInterface;
	}
}

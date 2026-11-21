using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000987 RID: 2439
	public class VisionItemComponent : IComponentBase
	{
		// Token: 0x060036D9 RID: 14041 RVA: 0x0008B74C File Offset: 0x0008994C
		private VisionItemComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VisionItemComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VisionItemComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VisionItemComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x0008B784 File Offset: 0x00089984
		public static VisionItemComponent Create([Nullable(2)] VisionItemComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VisionItemComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x0008B797 File Offset: 0x00089997
		public static VisionItemComponent CreateFromSetValue([Nullable(2)] VisionItemComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VisionItemComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x0008B7AA File Offset: 0x000899AA
		public new VisionItemComponent_SetValue ToSetValue()
		{
			return new VisionItemComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x060036DD RID: 14045 RVA: 0x0008B7CC File Offset: 0x000899CC
		// (set) Token: 0x060036DE RID: 14046 RVA: 0x0008B806 File Offset: 0x00089A06
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				VisionItemComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x060036DF RID: 14047 RVA: 0x0008B814 File Offset: 0x00089A14
		// (set) Token: 0x060036E0 RID: 14048 RVA: 0x0008B83E File Offset: 0x00089A3E
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

		// Token: 0x040023E1 RID: 9185
		[Nullable(2)]
		protected new VisionItemComponent FbInstance;

		// Token: 0x040023E2 RID: 9186
		[Nullable(2)]
		protected new VisionItemComponent_SetValue PocoInterface;
	}
}

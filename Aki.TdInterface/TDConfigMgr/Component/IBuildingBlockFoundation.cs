using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200022C RID: 556
	public class IBuildingBlockFoundation : IItemFoundationType
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x00028984 File Offset: 0x00026B84
		private IBuildingBlockFoundation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBuildingBlockFoundation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBuildingBlockFoundation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBuildingBlockFoundation_SetValue());
			}
			return result;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000289BC File Offset: 0x00026BBC
		public static IBuildingBlockFoundation Create([Nullable(2)] IBuildingBlockFoundation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBuildingBlockFoundation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x000289CF File Offset: 0x00026BCF
		public static IBuildingBlockFoundation CreateFromSetValue([Nullable(2)] IBuildingBlockFoundation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBuildingBlockFoundation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x000289E2 File Offset: 0x00026BE2
		public new IBuildingBlockFoundation_SetValue ToSetValue()
		{
			return new IBuildingBlockFoundation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x000289F5 File Offset: 0x00026BF5
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00028A20 File Offset: 0x00026C20
		public override EItemFoundation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EItemFoundation.CategoryMatching;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040009C2 RID: 2498
		[Nullable(2)]
		protected new IBuildingBlockFoundation FbInstance;

		// Token: 0x040009C3 RID: 2499
		[Nullable(2)]
		protected new IBuildingBlockFoundation_SetValue PocoInterface;
	}
}

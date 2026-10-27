using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000203 RID: 515
	[NullableContext(1)]
	[Nullable(0)]
	public class IBuildingBlockFoundation : IItemFoundationType
	{
		// Token: 0x06000888 RID: 2184 RVA: 0x00027030 File Offset: 0x00025230
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

		// Token: 0x06000889 RID: 2185 RVA: 0x00027068 File Offset: 0x00025268
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

		// Token: 0x0600088A RID: 2186 RVA: 0x0002707B File Offset: 0x0002527B
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

		// Token: 0x0600088B RID: 2187 RVA: 0x0002708E File Offset: 0x0002528E
		public new IBuildingBlockFoundation_SetValue ToSetValue()
		{
			return new IBuildingBlockFoundation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x000270A1 File Offset: 0x000252A1
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x000270CC File Offset: 0x000252CC
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

		// Token: 0x04000931 RID: 2353
		[Nullable(2)]
		protected new IBuildingBlockFoundation FbInstance;

		// Token: 0x04000932 RID: 2354
		[Nullable(2)]
		protected new IBuildingBlockFoundation_SetValue PocoInterface;
	}
}

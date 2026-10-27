using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D6E RID: 7534
	[NullableContext(1)]
	[Nullable(0)]
	public class IQiuyuanQinggongExploration1 : ILeisureInteractType
	{
		// Token: 0x0600A189 RID: 41353 RVA: 0x0016FE4C File Offset: 0x0016E04C
		private IQiuyuanQinggongExploration1_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQiuyuanQinggongExploration1 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQiuyuanQinggongExploration1_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQiuyuanQinggongExploration1_SetValue());
			}
			return result;
		}

		// Token: 0x0600A18A RID: 41354 RVA: 0x0016FE84 File Offset: 0x0016E084
		public static IQiuyuanQinggongExploration1 Create([Nullable(2)] IQiuyuanQinggongExploration1 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration1
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A18B RID: 41355 RVA: 0x0016FE97 File Offset: 0x0016E097
		public static IQiuyuanQinggongExploration1 CreateFromSetValue([Nullable(2)] IQiuyuanQinggongExploration1_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration1
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A18C RID: 41356 RVA: 0x0016FEAA File Offset: 0x0016E0AA
		public new IQiuyuanQinggongExploration1_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongExploration1_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0600A18D RID: 41357 RVA: 0x0016FEBD File Offset: 0x0016E0BD
		// (set) Token: 0x0600A18E RID: 41358 RVA: 0x0016FEE8 File Offset: 0x0016E0E8
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400612D RID: 24877
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration1 FbInstance;

		// Token: 0x0400612E RID: 24878
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration1_SetValue PocoInterface;
	}
}

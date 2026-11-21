using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003D5 RID: 981
	public class IFishingPointAdditionalInfo : IInteractAdditionalInfo
	{
		// Token: 0x06001345 RID: 4933 RVA: 0x0003F1B8 File Offset: 0x0003D3B8
		private IFishingPointAdditionalInfo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFishingPointAdditionalInfo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFishingPointAdditionalInfo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFishingPointAdditionalInfo_SetValue());
			}
			return result;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0003F1F0 File Offset: 0x0003D3F0
		public static IFishingPointAdditionalInfo Create([Nullable(2)] IFishingPointAdditionalInfo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFishingPointAdditionalInfo
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0003F203 File Offset: 0x0003D403
		public static IFishingPointAdditionalInfo CreateFromSetValue([Nullable(2)] IFishingPointAdditionalInfo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFishingPointAdditionalInfo
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0003F216 File Offset: 0x0003D416
		public new IFishingPointAdditionalInfo_SetValue ToSetValue()
		{
			return new IFishingPointAdditionalInfo_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x0003F229 File Offset: 0x0003D429
		// (set) Token: 0x0600134A RID: 4938 RVA: 0x0003F254 File Offset: 0x0003D454
		public override EInteractAdditionalInfoType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractAdditionalInfoType.FishingPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000F90 RID: 3984
		[Nullable(2)]
		protected new IFishingPointAdditionalInfo FbInstance;

		// Token: 0x04000F91 RID: 3985
		[Nullable(2)]
		protected new IFishingPointAdditionalInfo_SetValue PocoInterface;
	}
}

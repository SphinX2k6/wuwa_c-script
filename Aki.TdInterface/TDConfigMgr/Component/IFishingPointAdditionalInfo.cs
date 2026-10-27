using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200038C RID: 908
	[NullableContext(1)]
	[Nullable(0)]
	public class IFishingPointAdditionalInfo : IInteractAdditionalInfo
	{
		// Token: 0x06001201 RID: 4609 RVA: 0x0003BED4 File Offset: 0x0003A0D4
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

		// Token: 0x06001202 RID: 4610 RVA: 0x0003BF0C File Offset: 0x0003A10C
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

		// Token: 0x06001203 RID: 4611 RVA: 0x0003BF1F File Offset: 0x0003A11F
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

		// Token: 0x06001204 RID: 4612 RVA: 0x0003BF32 File Offset: 0x0003A132
		public new IFishingPointAdditionalInfo_SetValue ToSetValue()
		{
			return new IFishingPointAdditionalInfo_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x0003BF45 File Offset: 0x0003A145
		// (set) Token: 0x06001206 RID: 4614 RVA: 0x0003BF70 File Offset: 0x0003A170
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

		// Token: 0x04000E99 RID: 3737
		[Nullable(2)]
		protected new IFishingPointAdditionalInfo FbInstance;

		// Token: 0x04000E9A RID: 3738
		[Nullable(2)]
		protected new IFishingPointAdditionalInfo_SetValue PocoInterface;
	}
}

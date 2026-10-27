using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CF8 RID: 7416
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlaceholderCollectibleMarkerType : ICollectibleMarkerType
	{
		// Token: 0x06009F27 RID: 40743 RVA: 0x0016BB28 File Offset: 0x00169D28
		private IPlaceholderCollectibleMarkerType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlaceholderCollectibleMarkerType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlaceholderCollectibleMarkerType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlaceholderCollectibleMarkerType_SetValue());
			}
			return result;
		}

		// Token: 0x06009F28 RID: 40744 RVA: 0x0016BB60 File Offset: 0x00169D60
		public static IPlaceholderCollectibleMarkerType Create([Nullable(2)] IPlaceholderCollectibleMarkerType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlaceholderCollectibleMarkerType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F29 RID: 40745 RVA: 0x0016BB73 File Offset: 0x00169D73
		public static IPlaceholderCollectibleMarkerType CreateFromSetValue([Nullable(2)] IPlaceholderCollectibleMarkerType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlaceholderCollectibleMarkerType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F2A RID: 40746 RVA: 0x0016BB86 File Offset: 0x00169D86
		public new IPlaceholderCollectibleMarkerType_SetValue ToSetValue()
		{
			return new IPlaceholderCollectibleMarkerType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x06009F2B RID: 40747 RVA: 0x0016BB99 File Offset: 0x00169D99
		// (set) Token: 0x06009F2C RID: 40748 RVA: 0x0016BBC4 File Offset: 0x00169DC4
		public override ECollectibleMarkerType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECollectibleMarkerType.Placeholder;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400601B RID: 24603
		[Nullable(2)]
		protected new IPlaceholderCollectibleMarkerType FbInstance;

		// Token: 0x0400601C RID: 24604
		[Nullable(2)]
		protected new IPlaceholderCollectibleMarkerType_SetValue PocoInterface;
	}
}

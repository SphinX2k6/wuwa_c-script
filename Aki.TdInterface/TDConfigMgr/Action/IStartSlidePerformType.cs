using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EB5 RID: 7861
	[NullableContext(1)]
	[Nullable(0)]
	public class IStartSlidePerformType
	{
		// Token: 0x0600A822 RID: 43042 RVA: 0x0017BB24 File Offset: 0x00179D24
		private IStartSlidePerformType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStartSlidePerformType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStartSlidePerformType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStartSlidePerformType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A823 RID: 43043 RVA: 0x0017BB5C File Offset: 0x00179D5C
		public static IStartSlidePerformType Create([Nullable(2)] IStartSlidePerformType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStartSlidePerformType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A824 RID: 43044 RVA: 0x0017BB6F File Offset: 0x00179D6F
		public static IStartSlidePerformType CreateFromSetValue([Nullable(2)] IStartSlidePerformType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStartSlidePerformType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A825 RID: 43045 RVA: 0x0017BB82 File Offset: 0x00179D82
		public IStartSlidePerformType_SetValue ToSetValue()
		{
			return new IStartSlidePerformType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0600A826 RID: 43046 RVA: 0x0017BB95 File Offset: 0x00179D95
		// (set) Token: 0x0600A827 RID: 43047 RVA: 0x0017BBC0 File Offset: 0x00179DC0
		public virtual ESlidePerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESlidePerformType.SlopeSlide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006432 RID: 25650
		[Nullable(2)]
		protected IStartSlidePerformType FbInstance;

		// Token: 0x04006433 RID: 25651
		[Nullable(2)]
		protected IStartSlidePerformType_SetValue PocoInterface;
	}
}

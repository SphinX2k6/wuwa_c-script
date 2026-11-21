using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CC4 RID: 7364
	public class IHonamiStoryCustomLoading : ISpecialCustomLoadingOption
	{
		// Token: 0x06009C5E RID: 40030 RVA: 0x00168934 File Offset: 0x00166B34
		private IHonamiStoryCustomLoading_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHonamiStoryCustomLoading 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHonamiStoryCustomLoading_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHonamiStoryCustomLoading_SetValue());
			}
			return result;
		}

		// Token: 0x06009C5F RID: 40031 RVA: 0x0016896C File Offset: 0x00166B6C
		public static IHonamiStoryCustomLoading Create([Nullable(2)] IHonamiStoryCustomLoading instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHonamiStoryCustomLoading
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C60 RID: 40032 RVA: 0x0016897F File Offset: 0x00166B7F
		public static IHonamiStoryCustomLoading CreateFromSetValue([Nullable(2)] IHonamiStoryCustomLoading_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHonamiStoryCustomLoading
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C61 RID: 40033 RVA: 0x00168992 File Offset: 0x00166B92
		public new IHonamiStoryCustomLoading_SetValue ToSetValue()
		{
			return new IHonamiStoryCustomLoading_SetValue
			{
				Type = this.Type,
				LoadingId = this.LoadingId
			};
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x06009C62 RID: 40034 RVA: 0x001689B1 File Offset: 0x00166BB1
		// (set) Token: 0x06009C63 RID: 40035 RVA: 0x001689DC File Offset: 0x00166BDC
		public override ESpecialCustomLoadingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialCustomLoadingType.HonamiStory;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x06009C64 RID: 40036 RVA: 0x001689EA File Offset: 0x00166BEA
		// (set) Token: 0x06009C65 RID: 40037 RVA: 0x00168A15 File Offset: 0x00166C15
		public virtual int LoadingId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoadingId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LoadingId;
			}
			set
			{
				this.GetOrCreatePoco().LoadingId = value;
			}
		}

		// Token: 0x04005FA1 RID: 24481
		[Nullable(2)]
		protected new IHonamiStoryCustomLoading FbInstance;

		// Token: 0x04005FA2 RID: 24482
		[Nullable(2)]
		protected new IHonamiStoryCustomLoading_SetValue PocoInterface;
	}
}

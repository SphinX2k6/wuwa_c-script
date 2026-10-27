using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B15 RID: 6933
	[NullableContext(1)]
	[Nullable(0)]
	public class IHonamiStoryCustomLoading : ISpecialCustomLoadingOption
	{
		// Token: 0x06009474 RID: 38004 RVA: 0x00157C58 File Offset: 0x00155E58
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

		// Token: 0x06009475 RID: 38005 RVA: 0x00157C90 File Offset: 0x00155E90
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

		// Token: 0x06009476 RID: 38006 RVA: 0x00157CA3 File Offset: 0x00155EA3
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

		// Token: 0x06009477 RID: 38007 RVA: 0x00157CB6 File Offset: 0x00155EB6
		public new IHonamiStoryCustomLoading_SetValue ToSetValue()
		{
			return new IHonamiStoryCustomLoading_SetValue
			{
				Type = this.Type,
				LoadingId = this.LoadingId
			};
		}

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x06009478 RID: 38008 RVA: 0x00157CD5 File Offset: 0x00155ED5
		// (set) Token: 0x06009479 RID: 38009 RVA: 0x00157D00 File Offset: 0x00155F00
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

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x0600947A RID: 38010 RVA: 0x00157D0E File Offset: 0x00155F0E
		// (set) Token: 0x0600947B RID: 38011 RVA: 0x00157D39 File Offset: 0x00155F39
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

		// Token: 0x04005B03 RID: 23299
		[Nullable(2)]
		protected new IHonamiStoryCustomLoading FbInstance;

		// Token: 0x04005B04 RID: 23300
		[Nullable(2)]
		protected new IHonamiStoryCustomLoading_SetValue PocoInterface;
	}
}

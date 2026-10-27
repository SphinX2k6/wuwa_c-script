using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E85 RID: 7813
	[NullableContext(1)]
	[Nullable(0)]
	public class ISlideConfig : ISportConfig
	{
		// Token: 0x0600A72C RID: 42796 RVA: 0x00179F9C File Offset: 0x0017819C
		private ISlideConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlideConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlideConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlideConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A72D RID: 42797 RVA: 0x00179FD4 File Offset: 0x001781D4
		public static ISlideConfig Create([Nullable(2)] ISlideConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A72E RID: 42798 RVA: 0x00179FE7 File Offset: 0x001781E7
		public static ISlideConfig CreateFromSetValue([Nullable(2)] ISlideConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlideConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A72F RID: 42799 RVA: 0x00179FFA File Offset: 0x001781FA
		public new ISlideConfig_SetValue ToSetValue()
		{
			return new ISlideConfig_SetValue
			{
				Type = this.Type,
				SlideId = this.SlideId
			};
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0600A730 RID: 42800 RVA: 0x0017A019 File Offset: 0x00178219
		// (set) Token: 0x0600A731 RID: 42801 RVA: 0x0017A044 File Offset: 0x00178244
		public override ESportStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESportStateType.Slide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0600A732 RID: 42802 RVA: 0x0017A052 File Offset: 0x00178252
		// (set) Token: 0x0600A733 RID: 42803 RVA: 0x0017A07D File Offset: 0x0017827D
		public virtual int SlideId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SlideId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SlideId;
			}
			set
			{
				this.GetOrCreatePoco().SlideId = value;
			}
		}

		// Token: 0x040063C3 RID: 25539
		[Nullable(2)]
		protected new ISlideConfig FbInstance;

		// Token: 0x040063C4 RID: 25540
		[Nullable(2)]
		protected new ISlideConfig_SetValue PocoInterface;
	}
}

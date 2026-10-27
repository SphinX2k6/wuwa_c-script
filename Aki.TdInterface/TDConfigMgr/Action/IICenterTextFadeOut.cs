using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B21 RID: 6945
	[NullableContext(1)]
	[Nullable(0)]
	public class IICenterTextFadeOut : ICenterTextShowType
	{
		// Token: 0x060094B0 RID: 38064 RVA: 0x00158258 File Offset: 0x00156458
		private IICenterTextFadeOut_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IICenterTextFadeOut 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IICenterTextFadeOut_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IICenterTextFadeOut_SetValue());
			}
			return result;
		}

		// Token: 0x060094B1 RID: 38065 RVA: 0x00158290 File Offset: 0x00156490
		public static IICenterTextFadeOut Create([Nullable(2)] IICenterTextFadeOut instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IICenterTextFadeOut
			{
				FbInstance = instance
			};
		}

		// Token: 0x060094B2 RID: 38066 RVA: 0x001582A3 File Offset: 0x001564A3
		public static IICenterTextFadeOut CreateFromSetValue([Nullable(2)] IICenterTextFadeOut_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IICenterTextFadeOut
			{
				PocoInterface = value
			};
		}

		// Token: 0x060094B3 RID: 38067 RVA: 0x001582B6 File Offset: 0x001564B6
		public new IICenterTextFadeOut_SetValue ToSetValue()
		{
			return new IICenterTextFadeOut_SetValue
			{
				Type = this.Type,
				FadeInTime = this.FadeInTime,
				FadeOutTime = this.FadeOutTime
			};
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x060094B4 RID: 38068 RVA: 0x001582E1 File Offset: 0x001564E1
		// (set) Token: 0x060094B5 RID: 38069 RVA: 0x0015830C File Offset: 0x0015650C
		public override ECenterTextShowAnim Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECenterTextShowAnim.ShowAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x060094B6 RID: 38070 RVA: 0x0015831A File Offset: 0x0015651A
		// (set) Token: 0x060094B7 RID: 38071 RVA: 0x00158349 File Offset: 0x00156549
		public virtual float FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeInTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeInTime = value;
			}
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x060094B8 RID: 38072 RVA: 0x00158357 File Offset: 0x00156557
		// (set) Token: 0x060094B9 RID: 38073 RVA: 0x00158386 File Offset: 0x00156586
		public virtual float FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutTime = value;
			}
		}

		// Token: 0x04005B1B RID: 23323
		[Nullable(2)]
		protected new IICenterTextFadeOut FbInstance;

		// Token: 0x04005B1C RID: 23324
		[Nullable(2)]
		protected new IICenterTextFadeOut_SetValue PocoInterface;
	}
}

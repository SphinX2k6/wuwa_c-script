using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002D0 RID: 720
	public class ICountDownTextTip : ITrampleTipType
	{
		// Token: 0x06000D47 RID: 3399 RVA: 0x00032844 File Offset: 0x00030A44
		private ICountDownTextTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICountDownTextTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICountDownTextTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICountDownTextTip_SetValue());
			}
			return result;
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0003287C File Offset: 0x00030A7C
		public static ICountDownTextTip Create([Nullable(2)] ICountDownTextTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICountDownTextTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0003288F File Offset: 0x00030A8F
		public static ICountDownTextTip CreateFromSetValue([Nullable(2)] ICountDownTextTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICountDownTextTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x000328A2 File Offset: 0x00030AA2
		public new ICountDownTextTip_SetValue ToSetValue()
		{
			return new ICountDownTextTip_SetValue
			{
				Type = this.Type,
				TidCountDownTip = this.TidCountDownTip,
				EdTidCountDownTip = this.EdTidCountDownTip
			};
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x000328CD File Offset: 0x00030ACD
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x000328F8 File Offset: 0x00030AF8
		public override ETrampleTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrampleTipType.CountDownTextTip;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x00032906 File Offset: 0x00030B06
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x00032931 File Offset: 0x00030B31
		public virtual string TidCountDownTip
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidCountDownTip;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidCountDownTip;
			}
			set
			{
				this.GetOrCreatePoco().TidCountDownTip = value;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x0003293F File Offset: 0x00030B3F
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x00032956 File Offset: 0x00030B56
		[Nullable(2)]
		public virtual string EdTidCountDownTip
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidCountDownTip;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidCountDownTip = value;
			}
		}

		// Token: 0x04000C6E RID: 3182
		[Nullable(2)]
		protected new ICountDownTextTip FbInstance;

		// Token: 0x04000C6F RID: 3183
		[Nullable(2)]
		protected new ICountDownTextTip_SetValue PocoInterface;
	}
}

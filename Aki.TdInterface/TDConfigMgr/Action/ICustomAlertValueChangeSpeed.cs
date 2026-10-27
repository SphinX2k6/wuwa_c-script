using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001948 RID: 6472
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomAlertValueChangeSpeed : IAlertValueSpeedChangeType
	{
		// Token: 0x06008AB1 RID: 35505 RVA: 0x0014684C File Offset: 0x00144A4C
		private ICustomAlertValueChangeSpeed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomAlertValueChangeSpeed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomAlertValueChangeSpeed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomAlertValueChangeSpeed_SetValue());
			}
			return result;
		}

		// Token: 0x06008AB2 RID: 35506 RVA: 0x00146884 File Offset: 0x00144A84
		public static ICustomAlertValueChangeSpeed Create([Nullable(2)] ICustomAlertValueChangeSpeed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomAlertValueChangeSpeed
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008AB3 RID: 35507 RVA: 0x00146897 File Offset: 0x00144A97
		public static ICustomAlertValueChangeSpeed CreateFromSetValue([Nullable(2)] ICustomAlertValueChangeSpeed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomAlertValueChangeSpeed
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008AB4 RID: 35508 RVA: 0x001468AA File Offset: 0x00144AAA
		public new ICustomAlertValueChangeSpeed_SetValue ToSetValue()
		{
			return new ICustomAlertValueChangeSpeed_SetValue
			{
				Type = this.Type,
				CustomValue = this.CustomValue
			};
		}

		// Token: 0x17002CC1 RID: 11457
		// (get) Token: 0x06008AB5 RID: 35509 RVA: 0x001468C9 File Offset: 0x00144AC9
		// (set) Token: 0x06008AB6 RID: 35510 RVA: 0x001468F4 File Offset: 0x00144AF4
		public override EValueChangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EValueChangeType.AddOrSub;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002CC2 RID: 11458
		// (get) Token: 0x06008AB7 RID: 35511 RVA: 0x00146902 File Offset: 0x00144B02
		// (set) Token: 0x06008AB8 RID: 35512 RVA: 0x00146931 File Offset: 0x00144B31
		public virtual float CustomValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CustomValue;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.CustomValue;
			}
			set
			{
				this.GetOrCreatePoco().CustomValue = value;
			}
		}

		// Token: 0x040056A4 RID: 22180
		[Nullable(2)]
		protected new ICustomAlertValueChangeSpeed FbInstance;

		// Token: 0x040056A5 RID: 22181
		[Nullable(2)]
		protected new ICustomAlertValueChangeSpeed_SetValue PocoInterface;
	}
}

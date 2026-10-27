using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AC3 RID: 6851
	[NullableContext(2)]
	[Nullable(0)]
	public class IGamePadInteractVibration
	{
		// Token: 0x060092EE RID: 37614 RVA: 0x00155550 File Offset: 0x00153750
		[NullableContext(1)]
		private IGamePadInteractVibration_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGamePadInteractVibration 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGamePadInteractVibration_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGamePadInteractVibration_SetValue());
			}
			return result;
		}

		// Token: 0x060092EF RID: 37615 RVA: 0x00155588 File Offset: 0x00153788
		[NullableContext(1)]
		public static IGamePadInteractVibration Create([Nullable(2)] IGamePadInteractVibration instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGamePadInteractVibration
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092F0 RID: 37616 RVA: 0x0015559B File Offset: 0x0015379B
		[NullableContext(1)]
		public static IGamePadInteractVibration CreateFromSetValue([Nullable(2)] IGamePadInteractVibration_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGamePadInteractVibration
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092F1 RID: 37617 RVA: 0x001555AE File Offset: 0x001537AE
		[NullableContext(1)]
		public IGamePadInteractVibration_SetValue ToSetValue()
		{
			return new IGamePadInteractVibration_SetValue
			{
				LongPressingEffect = this.LongPressingEffect,
				LongPressFinishedEffect = this.LongPressFinishedEffect
			};
		}

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x060092F2 RID: 37618 RVA: 0x001555CD File Offset: 0x001537CD
		// (set) Token: 0x060092F3 RID: 37619 RVA: 0x001555F4 File Offset: 0x001537F4
		public virtual string LongPressingEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LongPressingEffect;
				}
				IGamePadInteractVibration_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LongPressingEffect;
			}
			set
			{
				this.GetOrCreatePoco().LongPressingEffect = value;
			}
		}

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x060092F4 RID: 37620 RVA: 0x00155602 File Offset: 0x00153802
		// (set) Token: 0x060092F5 RID: 37621 RVA: 0x00155629 File Offset: 0x00153829
		public virtual string LongPressFinishedEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LongPressFinishedEffect;
				}
				IGamePadInteractVibration_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LongPressFinishedEffect;
			}
			set
			{
				this.GetOrCreatePoco().LongPressFinishedEffect = value;
			}
		}

		// Token: 0x04005A65 RID: 23141
		protected IGamePadInteractVibration FbInstance;

		// Token: 0x04005A66 RID: 23142
		protected IGamePadInteractVibration_SetValue PocoInterface;
	}
}

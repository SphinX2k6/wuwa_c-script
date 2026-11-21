using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FCB RID: 8139
	[JsonConverter(typeof(IResetPresentationFailureConverter))]
	public class IResetPresentationFailure : IPresentationType
	{
		// Token: 0x0600ACEF RID: 44271 RVA: 0x00186A84 File Offset: 0x00184C84
		private IResetPresentationFailure_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResetPresentationFailure 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResetPresentationFailure_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResetPresentationFailure_SetValue());
			}
			return result;
		}

		// Token: 0x0600ACF0 RID: 44272 RVA: 0x00186ABC File Offset: 0x00184CBC
		public static IResetPresentationFailure Create([Nullable(2)] IResetPresentationFailure instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPresentationFailure
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ACF1 RID: 44273 RVA: 0x00186ACF File Offset: 0x00184CCF
		public static IResetPresentationFailure CreateFromSetValue([Nullable(2)] IResetPresentationFailure_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResetPresentationFailure
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ACF2 RID: 44274 RVA: 0x00186AE2 File Offset: 0x00184CE2
		public new IResetPresentationFailure_SetValue ToSetValue()
		{
			return new IResetPresentationFailure_SetValue
			{
				Type = this.Type,
				Duration = this.Duration,
				GamePlayCues = this.GamePlayCues
			};
		}

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x0600ACF3 RID: 44275 RVA: 0x00186B0D File Offset: 0x00184D0D
		// (set) Token: 0x0600ACF4 RID: 44276 RVA: 0x00186B38 File Offset: 0x00184D38
		public override EResetPresentationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EResetPresentationType.Failure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x0600ACF5 RID: 44277 RVA: 0x00186B46 File Offset: 0x00184D46
		// (set) Token: 0x0600ACF6 RID: 44278 RVA: 0x00186B75 File Offset: 0x00184D75
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x0600ACF7 RID: 44279 RVA: 0x00186B83 File Offset: 0x00184D83
		// (set) Token: 0x0600ACF8 RID: 44280 RVA: 0x00186BAA File Offset: 0x00184DAA
		public virtual List<int> GamePlayCues
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GamePlayCues;
				}
				IResetPresentationFailure_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GamePlayCues;
			}
			set
			{
				this.GetOrCreatePoco().GamePlayCues = value;
			}
		}

		// Token: 0x0400674C RID: 26444
		[Nullable(2)]
		protected new IResetPresentationFailure FbInstance;

		// Token: 0x0400674D RID: 26445
		[Nullable(2)]
		protected new IResetPresentationFailure_SetValue PocoInterface;
	}
}

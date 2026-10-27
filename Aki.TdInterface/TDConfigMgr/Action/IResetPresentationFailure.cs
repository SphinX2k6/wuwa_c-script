using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DB4 RID: 7604
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IResetPresentationFailureConverter))]
	public class IResetPresentationFailure : IPresentationType
	{
		// Token: 0x0600A2E5 RID: 41701 RVA: 0x0017235C File Offset: 0x0017055C
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

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x00172394 File Offset: 0x00170594
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

		// Token: 0x0600A2E7 RID: 41703 RVA: 0x001723A7 File Offset: 0x001705A7
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

		// Token: 0x0600A2E8 RID: 41704 RVA: 0x001723BA File Offset: 0x001705BA
		public new IResetPresentationFailure_SetValue ToSetValue()
		{
			return new IResetPresentationFailure_SetValue
			{
				Type = this.Type,
				Duration = this.Duration,
				GamePlayCues = this.GamePlayCues
			};
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0600A2E9 RID: 41705 RVA: 0x001723E5 File Offset: 0x001705E5
		// (set) Token: 0x0600A2EA RID: 41706 RVA: 0x00172410 File Offset: 0x00170610
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

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x0600A2EB RID: 41707 RVA: 0x0017241E File Offset: 0x0017061E
		// (set) Token: 0x0600A2EC RID: 41708 RVA: 0x0017244D File Offset: 0x0017064D
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

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0600A2ED RID: 41709 RVA: 0x0017245B File Offset: 0x0017065B
		// (set) Token: 0x0600A2EE RID: 41710 RVA: 0x00172482 File Offset: 0x00170682
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

		// Token: 0x040061C4 RID: 25028
		[Nullable(2)]
		protected new IResetPresentationFailure FbInstance;

		// Token: 0x040061C5 RID: 25029
		[Nullable(2)]
		protected new IResetPresentationFailure_SetValue PocoInterface;
	}
}

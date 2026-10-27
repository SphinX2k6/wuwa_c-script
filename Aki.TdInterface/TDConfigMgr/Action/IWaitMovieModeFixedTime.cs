using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020B3 RID: 8371
	[NullableContext(1)]
	[Nullable(0)]
	public class IWaitMovieModeFixedTime : IEnterMovieModeDurationType
	{
		// Token: 0x0600B818 RID: 47128 RVA: 0x001AA410 File Offset: 0x001A8610
		private IWaitMovieModeFixedTime_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWaitMovieModeFixedTime 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWaitMovieModeFixedTime_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWaitMovieModeFixedTime_SetValue());
			}
			return result;
		}

		// Token: 0x0600B819 RID: 47129 RVA: 0x001AA448 File Offset: 0x001A8648
		public static IWaitMovieModeFixedTime Create([Nullable(2)] IWaitMovieModeFixedTime instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaitMovieModeFixedTime
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B81A RID: 47130 RVA: 0x001AA45B File Offset: 0x001A865B
		public static IWaitMovieModeFixedTime CreateFromSetValue([Nullable(2)] IWaitMovieModeFixedTime_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWaitMovieModeFixedTime
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B81B RID: 47131 RVA: 0x001AA46E File Offset: 0x001A866E
		public new IWaitMovieModeFixedTime_SetValue ToSetValue()
		{
			return new IWaitMovieModeFixedTime_SetValue
			{
				Type = this.Type,
				Duration = this.Duration
			};
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x0600B81C RID: 47132 RVA: 0x001AA48D File Offset: 0x001A868D
		// (set) Token: 0x0600B81D RID: 47133 RVA: 0x001AA4B8 File Offset: 0x001A86B8
		public override EEnterMovieModeDurationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnterMovieModeDurationType.BorderAnimFinished;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x0600B81E RID: 47134 RVA: 0x001AA4C6 File Offset: 0x001A86C6
		// (set) Token: 0x0600B81F RID: 47135 RVA: 0x001AA4F5 File Offset: 0x001A86F5
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

		// Token: 0x04006E69 RID: 28265
		[Nullable(2)]
		protected new IWaitMovieModeFixedTime FbInstance;

		// Token: 0x04006E6A RID: 28266
		[Nullable(2)]
		protected new IWaitMovieModeFixedTime_SetValue PocoInterface;
	}
}

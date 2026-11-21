using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002308 RID: 8968
	public class IWaitMovieModeFixedTime : IEnterMovieModeDurationType
	{
		// Token: 0x0600C370 RID: 50032 RVA: 0x001C1058 File Offset: 0x001BF258
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

		// Token: 0x0600C371 RID: 50033 RVA: 0x001C1090 File Offset: 0x001BF290
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

		// Token: 0x0600C372 RID: 50034 RVA: 0x001C10A3 File Offset: 0x001BF2A3
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

		// Token: 0x0600C373 RID: 50035 RVA: 0x001C10B6 File Offset: 0x001BF2B6
		public new IWaitMovieModeFixedTime_SetValue ToSetValue()
		{
			return new IWaitMovieModeFixedTime_SetValue
			{
				Type = this.Type,
				Duration = this.Duration
			};
		}

		// Token: 0x17003B3C RID: 15164
		// (get) Token: 0x0600C374 RID: 50036 RVA: 0x001C10D5 File Offset: 0x001BF2D5
		// (set) Token: 0x0600C375 RID: 50037 RVA: 0x001C1100 File Offset: 0x001BF300
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

		// Token: 0x17003B3D RID: 15165
		// (get) Token: 0x0600C376 RID: 50038 RVA: 0x001C110E File Offset: 0x001BF30E
		// (set) Token: 0x0600C377 RID: 50039 RVA: 0x001C113D File Offset: 0x001BF33D
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

		// Token: 0x04007487 RID: 29831
		[Nullable(2)]
		protected new IWaitMovieModeFixedTime FbInstance;

		// Token: 0x04007488 RID: 29832
		[Nullable(2)]
		protected new IWaitMovieModeFixedTime_SetValue PocoInterface;
	}
}

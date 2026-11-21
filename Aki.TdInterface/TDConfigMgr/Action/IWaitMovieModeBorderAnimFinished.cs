using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002306 RID: 8966
	public class IWaitMovieModeBorderAnimFinished : IEnterMovieModeDurationType
	{
		// Token: 0x0600C368 RID: 50024 RVA: 0x001C0F9C File Offset: 0x001BF19C
		private IWaitMovieModeBorderAnimFinished_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWaitMovieModeBorderAnimFinished 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWaitMovieModeBorderAnimFinished_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWaitMovieModeBorderAnimFinished_SetValue());
			}
			return result;
		}

		// Token: 0x0600C369 RID: 50025 RVA: 0x001C0FD4 File Offset: 0x001BF1D4
		public static IWaitMovieModeBorderAnimFinished Create([Nullable(2)] IWaitMovieModeBorderAnimFinished instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaitMovieModeBorderAnimFinished
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C36A RID: 50026 RVA: 0x001C0FE7 File Offset: 0x001BF1E7
		public static IWaitMovieModeBorderAnimFinished CreateFromSetValue([Nullable(2)] IWaitMovieModeBorderAnimFinished_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWaitMovieModeBorderAnimFinished
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C36B RID: 50027 RVA: 0x001C0FFA File Offset: 0x001BF1FA
		public new IWaitMovieModeBorderAnimFinished_SetValue ToSetValue()
		{
			return new IWaitMovieModeBorderAnimFinished_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003B3B RID: 15163
		// (get) Token: 0x0600C36C RID: 50028 RVA: 0x001C100D File Offset: 0x001BF20D
		// (set) Token: 0x0600C36D RID: 50029 RVA: 0x001C1038 File Offset: 0x001BF238
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

		// Token: 0x04007484 RID: 29828
		[Nullable(2)]
		protected new IWaitMovieModeBorderAnimFinished FbInstance;

		// Token: 0x04007485 RID: 29829
		[Nullable(2)]
		protected new IWaitMovieModeBorderAnimFinished_SetValue PocoInterface;
	}
}

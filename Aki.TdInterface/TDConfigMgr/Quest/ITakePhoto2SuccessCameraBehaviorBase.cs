using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012AC RID: 4780
	public class ITakePhoto2SuccessCameraBehaviorBase
	{
		// Token: 0x06006BA9 RID: 27561 RVA: 0x00100F38 File Offset: 0x000FF138
		private ITakePhoto2SuccessCameraBehaviorBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2SuccessCameraBehaviorBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2SuccessCameraBehaviorBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2SuccessCameraBehaviorBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006BAA RID: 27562 RVA: 0x00100F70 File Offset: 0x000FF170
		public static ITakePhoto2SuccessCameraBehaviorBase Create([Nullable(2)] ITakePhoto2SuccessCameraBehaviorBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2SuccessCameraBehaviorBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006BAB RID: 27563 RVA: 0x00100F83 File Offset: 0x000FF183
		public static ITakePhoto2SuccessCameraBehaviorBase CreateFromSetValue([Nullable(2)] ITakePhoto2SuccessCameraBehaviorBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2SuccessCameraBehaviorBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006BAC RID: 27564 RVA: 0x00100F96 File Offset: 0x000FF196
		public ITakePhoto2SuccessCameraBehaviorBase_SetValue ToSetValue()
		{
			return new ITakePhoto2SuccessCameraBehaviorBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x06006BAD RID: 27565 RVA: 0x00100FA9 File Offset: 0x000FF1A9
		// (set) Token: 0x06006BAE RID: 27566 RVA: 0x00100FD4 File Offset: 0x000FF1D4
		public virtual ETakePhoto2SuccessCameraBehavior Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETakePhoto2SuccessCameraBehavior.KeepOpen;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400404C RID: 16460
		[Nullable(2)]
		protected ITakePhoto2SuccessCameraBehaviorBase FbInstance;

		// Token: 0x0400404D RID: 16461
		[Nullable(2)]
		protected ITakePhoto2SuccessCameraBehaviorBase_SetValue PocoInterface;
	}
}

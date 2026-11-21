using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001298 RID: 4760
	public class ITakePhoto2BeforeYourEyesMode : ITakePhoto2ModeBase
	{
		// Token: 0x06006B25 RID: 27429 RVA: 0x000FFD84 File Offset: 0x000FDF84
		private ITakePhoto2BeforeYourEyesMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2BeforeYourEyesMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2BeforeYourEyesMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2BeforeYourEyesMode_SetValue());
			}
			return result;
		}

		// Token: 0x06006B26 RID: 27430 RVA: 0x000FFDBC File Offset: 0x000FDFBC
		public static ITakePhoto2BeforeYourEyesMode Create([Nullable(2)] ITakePhoto2BeforeYourEyesMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2BeforeYourEyesMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006B27 RID: 27431 RVA: 0x000FFDCF File Offset: 0x000FDFCF
		public static ITakePhoto2BeforeYourEyesMode CreateFromSetValue([Nullable(2)] ITakePhoto2BeforeYourEyesMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2BeforeYourEyesMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x000FFDE2 File Offset: 0x000FDFE2
		public new ITakePhoto2BeforeYourEyesMode_SetValue ToSetValue()
		{
			return new ITakePhoto2BeforeYourEyesMode_SetValue
			{
				Type = this.Type,
				SuccessCameraBehavior = this.SuccessCameraBehavior
			};
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x06006B29 RID: 27433 RVA: 0x000FFE01 File Offset: 0x000FE001
		// (set) Token: 0x06006B2A RID: 27434 RVA: 0x000FFE2C File Offset: 0x000FE02C
		public override ETakePhoto2Mode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETakePhoto2Mode.BeforeYourEyes;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x06006B2B RID: 27435 RVA: 0x000FFE3A File Offset: 0x000FE03A
		// (set) Token: 0x06006B2C RID: 27436 RVA: 0x000FFE61 File Offset: 0x000FE061
		public virtual ITakePhoto2SuccessCameraBehaviorBase SuccessCameraBehavior
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SuccessCameraBehavior;
				}
				ITakePhoto2BeforeYourEyesMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SuccessCameraBehavior;
			}
			set
			{
				this.GetOrCreatePoco().SuccessCameraBehavior = value;
			}
		}

		// Token: 0x04003FFA RID: 16378
		[Nullable(2)]
		protected new ITakePhoto2BeforeYourEyesMode FbInstance;

		// Token: 0x04003FFB RID: 16379
		[Nullable(2)]
		protected new ITakePhoto2BeforeYourEyesMode_SetValue PocoInterface;
	}
}

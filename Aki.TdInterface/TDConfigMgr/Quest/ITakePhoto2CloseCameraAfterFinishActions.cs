using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200129C RID: 4764
	public class ITakePhoto2CloseCameraAfterFinishActions : ITakePhoto2SuccessCameraBehaviorBase
	{
		// Token: 0x06006B39 RID: 27449 RVA: 0x000FFF80 File Offset: 0x000FE180
		private ITakePhoto2CloseCameraAfterFinishActions_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2CloseCameraAfterFinishActions 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2CloseCameraAfterFinishActions_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2CloseCameraAfterFinishActions_SetValue());
			}
			return result;
		}

		// Token: 0x06006B3A RID: 27450 RVA: 0x000FFFB8 File Offset: 0x000FE1B8
		public static ITakePhoto2CloseCameraAfterFinishActions Create([Nullable(2)] ITakePhoto2CloseCameraAfterFinishActions instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2CloseCameraAfterFinishActions
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x000FFFCB File Offset: 0x000FE1CB
		public static ITakePhoto2CloseCameraAfterFinishActions CreateFromSetValue([Nullable(2)] ITakePhoto2CloseCameraAfterFinishActions_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2CloseCameraAfterFinishActions
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006B3C RID: 27452 RVA: 0x000FFFDE File Offset: 0x000FE1DE
		public new ITakePhoto2CloseCameraAfterFinishActions_SetValue ToSetValue()
		{
			return new ITakePhoto2CloseCameraAfterFinishActions_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x06006B3D RID: 27453 RVA: 0x000FFFF1 File Offset: 0x000FE1F1
		// (set) Token: 0x06006B3E RID: 27454 RVA: 0x0010001C File Offset: 0x000FE21C
		public override ETakePhoto2SuccessCameraBehavior Type
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

		// Token: 0x04004002 RID: 16386
		[Nullable(2)]
		protected new ITakePhoto2CloseCameraAfterFinishActions FbInstance;

		// Token: 0x04004003 RID: 16387
		[Nullable(2)]
		protected new ITakePhoto2CloseCameraAfterFinishActions_SetValue PocoInterface;
	}
}

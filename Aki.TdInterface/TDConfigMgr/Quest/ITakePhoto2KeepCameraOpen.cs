using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A2 RID: 4770
	public class ITakePhoto2KeepCameraOpen : ITakePhoto2SuccessCameraBehaviorBase
	{
		// Token: 0x06006B79 RID: 27513 RVA: 0x001009E0 File Offset: 0x000FEBE0
		private ITakePhoto2KeepCameraOpen_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2KeepCameraOpen 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2KeepCameraOpen_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2KeepCameraOpen_SetValue());
			}
			return result;
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x00100A18 File Offset: 0x000FEC18
		public static ITakePhoto2KeepCameraOpen Create([Nullable(2)] ITakePhoto2KeepCameraOpen instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2KeepCameraOpen
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x00100A2B File Offset: 0x000FEC2B
		public static ITakePhoto2KeepCameraOpen CreateFromSetValue([Nullable(2)] ITakePhoto2KeepCameraOpen_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2KeepCameraOpen
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x00100A3E File Offset: 0x000FEC3E
		public new ITakePhoto2KeepCameraOpen_SetValue ToSetValue()
		{
			return new ITakePhoto2KeepCameraOpen_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x06006B7D RID: 27517 RVA: 0x00100A51 File Offset: 0x000FEC51
		// (set) Token: 0x06006B7E RID: 27518 RVA: 0x00100A7C File Offset: 0x000FEC7C
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

		// Token: 0x04004035 RID: 16437
		[Nullable(2)]
		protected new ITakePhoto2KeepCameraOpen FbInstance;

		// Token: 0x04004036 RID: 16438
		[Nullable(2)]
		protected new ITakePhoto2KeepCameraOpen_SetValue PocoInterface;
	}
}

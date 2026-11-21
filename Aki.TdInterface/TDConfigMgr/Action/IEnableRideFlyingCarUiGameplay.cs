using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B7B RID: 7035
	public class IEnableRideFlyingCarUiGameplay : IToggleRideFlyingCarUiGameplayConfig
	{
		// Token: 0x06009563 RID: 38243 RVA: 0x0015C3F0 File Offset: 0x0015A5F0
		private IEnableRideFlyingCarUiGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableRideFlyingCarUiGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableRideFlyingCarUiGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableRideFlyingCarUiGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x06009564 RID: 38244 RVA: 0x0015C428 File Offset: 0x0015A628
		public static IEnableRideFlyingCarUiGameplay Create([Nullable(2)] IEnableRideFlyingCarUiGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableRideFlyingCarUiGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009565 RID: 38245 RVA: 0x0015C43B File Offset: 0x0015A63B
		public static IEnableRideFlyingCarUiGameplay CreateFromSetValue([Nullable(2)] IEnableRideFlyingCarUiGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableRideFlyingCarUiGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009566 RID: 38246 RVA: 0x0015C44E File Offset: 0x0015A64E
		public new IEnableRideFlyingCarUiGameplay_SetValue ToSetValue()
		{
			return new IEnableRideFlyingCarUiGameplay_SetValue
			{
				Type = this.Type,
				FirstPersonCameraTag = this.FirstPersonCameraTag,
				ThirdPersonCameraTag = this.ThirdPersonCameraTag
			};
		}

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x06009567 RID: 38247 RVA: 0x0015C479 File Offset: 0x0015A679
		// (set) Token: 0x06009568 RID: 38248 RVA: 0x0015C4A4 File Offset: 0x0015A6A4
		public override EToggleRideFlyingCarUiGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EToggleRideFlyingCarUiGameplayType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x06009569 RID: 38249 RVA: 0x0015C4B4 File Offset: 0x0015A6B4
		// (set) Token: 0x0600956A RID: 38250 RVA: 0x0015C4EE File Offset: 0x0015A6EE
		public virtual int? FirstPersonCameraTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FirstPersonCameraTag;
				}
				IEnableRideFlyingCarUiGameplay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FirstPersonCameraTag;
			}
			set
			{
				this.GetOrCreatePoco().FirstPersonCameraTag = value;
			}
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x0600956B RID: 38251 RVA: 0x0015C4FC File Offset: 0x0015A6FC
		// (set) Token: 0x0600956C RID: 38252 RVA: 0x0015C536 File Offset: 0x0015A736
		public virtual int? ThirdPersonCameraTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ThirdPersonCameraTag;
				}
				IEnableRideFlyingCarUiGameplay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ThirdPersonCameraTag;
			}
			set
			{
				this.GetOrCreatePoco().ThirdPersonCameraTag = value;
			}
		}

		// Token: 0x04005C7E RID: 23678
		[Nullable(2)]
		protected new IEnableRideFlyingCarUiGameplay FbInstance;

		// Token: 0x04005C7F RID: 23679
		[Nullable(2)]
		protected new IEnableRideFlyingCarUiGameplay_SetValue PocoInterface;
	}
}

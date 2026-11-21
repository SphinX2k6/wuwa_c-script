using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FD3 RID: 8147
	public class IRideFlyingCar : IUiGame
	{
		// Token: 0x0600AD15 RID: 44309 RVA: 0x00186E3C File Offset: 0x0018503C
		private IRideFlyingCar_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRideFlyingCar 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRideFlyingCar_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRideFlyingCar_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD16 RID: 44310 RVA: 0x00186E74 File Offset: 0x00185074
		public static IRideFlyingCar Create([Nullable(2)] IRideFlyingCar instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRideFlyingCar
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD17 RID: 44311 RVA: 0x00186E87 File Offset: 0x00185087
		public static IRideFlyingCar CreateFromSetValue([Nullable(2)] IRideFlyingCar_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRideFlyingCar
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD18 RID: 44312 RVA: 0x00186E9A File Offset: 0x0018509A
		public new IRideFlyingCar_SetValue ToSetValue()
		{
			return new IRideFlyingCar_SetValue
			{
				Type = this.Type,
				FirstPersonCameraTag = this.FirstPersonCameraTag,
				ThirdPersonCameraTag = this.ThirdPersonCameraTag
			};
		}

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x0600AD19 RID: 44313 RVA: 0x00186EC5 File Offset: 0x001850C5
		// (set) Token: 0x0600AD1A RID: 44314 RVA: 0x00186EF0 File Offset: 0x001850F0
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x0600AD1B RID: 44315 RVA: 0x00186F00 File Offset: 0x00185100
		// (set) Token: 0x0600AD1C RID: 44316 RVA: 0x00186F3A File Offset: 0x0018513A
		public virtual int? FirstPersonCameraTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FirstPersonCameraTag;
				}
				IRideFlyingCar_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x0600AD1D RID: 44317 RVA: 0x00186F48 File Offset: 0x00185148
		// (set) Token: 0x0600AD1E RID: 44318 RVA: 0x00186F82 File Offset: 0x00185182
		public virtual int? ThirdPersonCameraTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ThirdPersonCameraTag;
				}
				IRideFlyingCar_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400675B RID: 26459
		[Nullable(2)]
		protected new IRideFlyingCar FbInstance;

		// Token: 0x0400675C RID: 26460
		[Nullable(2)]
		protected new IRideFlyingCar_SetValue PocoInterface;
	}
}

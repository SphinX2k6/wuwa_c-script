using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DBC RID: 7612
	[NullableContext(1)]
	[Nullable(0)]
	public class IRideFlyingCar : IUiGame
	{
		// Token: 0x0600A30B RID: 41739 RVA: 0x00172714 File Offset: 0x00170914
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

		// Token: 0x0600A30C RID: 41740 RVA: 0x0017274C File Offset: 0x0017094C
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

		// Token: 0x0600A30D RID: 41741 RVA: 0x0017275F File Offset: 0x0017095F
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

		// Token: 0x0600A30E RID: 41742 RVA: 0x00172772 File Offset: 0x00170972
		public new IRideFlyingCar_SetValue ToSetValue()
		{
			return new IRideFlyingCar_SetValue
			{
				Type = this.Type,
				FirstPersonCameraTag = this.FirstPersonCameraTag,
				ThirdPersonCameraTag = this.ThirdPersonCameraTag
			};
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0600A30F RID: 41743 RVA: 0x0017279D File Offset: 0x0017099D
		// (set) Token: 0x0600A310 RID: 41744 RVA: 0x001727C8 File Offset: 0x001709C8
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

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x0600A311 RID: 41745 RVA: 0x001727D8 File Offset: 0x001709D8
		// (set) Token: 0x0600A312 RID: 41746 RVA: 0x00172812 File Offset: 0x00170A12
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

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x0600A313 RID: 41747 RVA: 0x00172820 File Offset: 0x00170A20
		// (set) Token: 0x0600A314 RID: 41748 RVA: 0x0017285A File Offset: 0x00170A5A
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

		// Token: 0x040061D3 RID: 25043
		[Nullable(2)]
		protected new IRideFlyingCar FbInstance;

		// Token: 0x040061D4 RID: 25044
		[Nullable(2)]
		protected new IRideFlyingCar_SetValue PocoInterface;
	}
}

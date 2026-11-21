using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002410 RID: 9232
	public class SetCameraAnim : ActionParams
	{
		// Token: 0x0600C8DA RID: 51418 RVA: 0x001CB07C File Offset: 0x001C927C
		private SetCameraAnim_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetCameraAnim 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetCameraAnim_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetCameraAnim_SetValue());
			}
			return result;
		}

		// Token: 0x0600C8DB RID: 51419 RVA: 0x001CB0B4 File Offset: 0x001C92B4
		public static SetCameraAnim Create([Nullable(2)] SetCameraAnim instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetCameraAnim
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C8DC RID: 51420 RVA: 0x001CB0C7 File Offset: 0x001C92C7
		public static SetCameraAnim CreateFromSetValue([Nullable(2)] SetCameraAnim_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetCameraAnim
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C8DD RID: 51421 RVA: 0x001CB0DA File Offset: 0x001C92DA
		public SetCameraAnim_SetValue ToSetValue()
		{
			return new SetCameraAnim_SetValue
			{
				CameraAnimDataAsset = this.CameraAnimDataAsset,
				Speed = this.Speed,
				UseNoise = this.UseNoise
			};
		}

		// Token: 0x17003C6D RID: 15469
		// (get) Token: 0x0600C8DE RID: 51422 RVA: 0x001CB105 File Offset: 0x001C9305
		// (set) Token: 0x0600C8DF RID: 51423 RVA: 0x001CB130 File Offset: 0x001C9330
		public virtual string CameraAnimDataAsset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CameraAnimDataAsset;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.CameraAnimDataAsset;
			}
			set
			{
				this.GetOrCreatePoco().CameraAnimDataAsset = value;
			}
		}

		// Token: 0x17003C6E RID: 15470
		// (get) Token: 0x0600C8E0 RID: 51424 RVA: 0x001CB13E File Offset: 0x001C933E
		// (set) Token: 0x0600C8E1 RID: 51425 RVA: 0x001CB16D File Offset: 0x001C936D
		public virtual float Speed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Speed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Speed;
			}
			set
			{
				this.GetOrCreatePoco().Speed = value;
			}
		}

		// Token: 0x17003C6F RID: 15471
		// (get) Token: 0x0600C8E2 RID: 51426 RVA: 0x001CB17C File Offset: 0x001C937C
		// (set) Token: 0x0600C8E3 RID: 51427 RVA: 0x001CB1B6 File Offset: 0x001C93B6
		public virtual bool? UseNoise
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UseNoise;
				}
				SetCameraAnim_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UseNoise;
			}
			set
			{
				this.GetOrCreatePoco().UseNoise = value;
			}
		}

		// Token: 0x04007726 RID: 30502
		[Nullable(2)]
		protected new SetCameraAnim FbInstance;

		// Token: 0x04007727 RID: 30503
		[Nullable(2)]
		protected SetCameraAnim_SetValue PocoInterface;
	}
}

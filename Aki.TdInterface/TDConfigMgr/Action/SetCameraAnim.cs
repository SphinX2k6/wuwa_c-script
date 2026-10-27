using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021A5 RID: 8613
	[NullableContext(1)]
	[Nullable(0)]
	public class SetCameraAnim : ActionParams
	{
		// Token: 0x0600BD20 RID: 48416 RVA: 0x001B3A44 File Offset: 0x001B1C44
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

		// Token: 0x0600BD21 RID: 48417 RVA: 0x001B3A7C File Offset: 0x001B1C7C
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

		// Token: 0x0600BD22 RID: 48418 RVA: 0x001B3A8F File Offset: 0x001B1C8F
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

		// Token: 0x0600BD23 RID: 48419 RVA: 0x001B3AA2 File Offset: 0x001B1CA2
		public SetCameraAnim_SetValue ToSetValue()
		{
			return new SetCameraAnim_SetValue
			{
				CameraAnimDataAsset = this.CameraAnimDataAsset,
				Speed = this.Speed,
				UseNoise = this.UseNoise
			};
		}

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x0600BD24 RID: 48420 RVA: 0x001B3ACD File Offset: 0x001B1CCD
		// (set) Token: 0x0600BD25 RID: 48421 RVA: 0x001B3AF8 File Offset: 0x001B1CF8
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

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x0600BD26 RID: 48422 RVA: 0x001B3B06 File Offset: 0x001B1D06
		// (set) Token: 0x0600BD27 RID: 48423 RVA: 0x001B3B35 File Offset: 0x001B1D35
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

		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x0600BD28 RID: 48424 RVA: 0x001B3B44 File Offset: 0x001B1D44
		// (set) Token: 0x0600BD29 RID: 48425 RVA: 0x001B3B7E File Offset: 0x001B1D7E
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

		// Token: 0x040070DE RID: 28894
		[Nullable(2)]
		protected new SetCameraAnim FbInstance;

		// Token: 0x040070DF RID: 28895
		[Nullable(2)]
		protected SetCameraAnim_SetValue PocoInterface;
	}
}

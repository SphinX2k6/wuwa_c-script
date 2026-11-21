using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019C5 RID: 6597
	public class ICameraData
	{
		// Token: 0x06008C39 RID: 35897 RVA: 0x0014C1C0 File Offset: 0x0014A3C0
		private ICameraData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraData_SetValue());
			}
			return result;
		}

		// Token: 0x06008C3A RID: 35898 RVA: 0x0014C1F8 File Offset: 0x0014A3F8
		public static ICameraData Create([Nullable(2)] ICameraData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C3B RID: 35899 RVA: 0x0014C20B File Offset: 0x0014A40B
		public static ICameraData CreateFromSetValue([Nullable(2)] ICameraData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C3C RID: 35900 RVA: 0x0014C21E File Offset: 0x0014A41E
		public ICameraData_SetValue ToSetValue()
		{
			return new ICameraData_SetValue
			{
				Camera = this.Camera,
				CameraAnim = this.CameraAnim
			};
		}

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x06008C3D RID: 35901 RVA: 0x0014C240 File Offset: 0x0014A440
		// (set) Token: 0x06008C3E RID: 35902 RVA: 0x0014C2A1 File Offset: 0x0014A4A1
		public virtual IFlowTemplateMode Camera
		{
			get
			{
				if (this._CameraInited)
				{
					return this._CameraCache;
				}
				this._CameraInited = true;
				if (this.FbInstance != null)
				{
					this._CameraCache = IFlowTemplateMode.Create(this.FbInstance.Camera);
				}
				else
				{
					ICameraData_SetValue pocoInterface = this.PocoInterface;
					this._CameraCache = ((pocoInterface != null) ? pocoInterface.Camera : null);
				}
				return this._CameraCache;
			}
			set
			{
				this.GetOrCreatePoco().Camera = value;
				this._CameraInited = false;
			}
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x06008C3F RID: 35903 RVA: 0x0014C2B8 File Offset: 0x0014A4B8
		// (set) Token: 0x06008C40 RID: 35904 RVA: 0x0014C319 File Offset: 0x0014A519
		[Nullable(2)]
		public virtual SetCameraAnim CameraAnim
		{
			[NullableContext(2)]
			get
			{
				if (this._CameraAnimInited)
				{
					return this._CameraAnimCache;
				}
				this._CameraAnimInited = true;
				if (this.FbInstance != null)
				{
					this._CameraAnimCache = SetCameraAnim.Create(this.FbInstance.CameraAnim);
				}
				else
				{
					ICameraData_SetValue pocoInterface = this.PocoInterface;
					this._CameraAnimCache = ((pocoInterface != null) ? pocoInterface.CameraAnim : null);
				}
				return this._CameraAnimCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CameraAnim = value;
				this._CameraAnimInited = false;
			}
		}

		// Token: 0x04005864 RID: 22628
		[Nullable(2)]
		protected ICameraData FbInstance;

		// Token: 0x04005865 RID: 22629
		[Nullable(2)]
		protected ICameraData_SetValue PocoInterface;

		// Token: 0x04005866 RID: 22630
		private IFlowTemplateMode _CameraCache;

		// Token: 0x04005867 RID: 22631
		private bool _CameraInited;

		// Token: 0x04005868 RID: 22632
		private SetCameraAnim _CameraAnimCache;

		// Token: 0x04005869 RID: 22633
		private bool _CameraAnimInited;
	}
}

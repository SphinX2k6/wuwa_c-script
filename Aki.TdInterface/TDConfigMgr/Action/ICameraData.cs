using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200183A RID: 6202
	[NullableContext(1)]
	[Nullable(0)]
	public class ICameraData
	{
		// Token: 0x06008513 RID: 34067 RVA: 0x0013C9CC File Offset: 0x0013ABCC
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

		// Token: 0x06008514 RID: 34068 RVA: 0x0013CA04 File Offset: 0x0013AC04
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

		// Token: 0x06008515 RID: 34069 RVA: 0x0013CA17 File Offset: 0x0013AC17
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

		// Token: 0x06008516 RID: 34070 RVA: 0x0013CA2A File Offset: 0x0013AC2A
		public ICameraData_SetValue ToSetValue()
		{
			return new ICameraData_SetValue
			{
				Camera = this.Camera,
				CameraAnim = this.CameraAnim
			};
		}

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x06008517 RID: 34071 RVA: 0x0013CA4C File Offset: 0x0013AC4C
		// (set) Token: 0x06008518 RID: 34072 RVA: 0x0013CAAD File Offset: 0x0013ACAD
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

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x06008519 RID: 34073 RVA: 0x0013CAC4 File Offset: 0x0013ACC4
		// (set) Token: 0x0600851A RID: 34074 RVA: 0x0013CB25 File Offset: 0x0013AD25
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

		// Token: 0x04005418 RID: 21528
		[Nullable(2)]
		protected ICameraData FbInstance;

		// Token: 0x04005419 RID: 21529
		[Nullable(2)]
		protected ICameraData_SetValue PocoInterface;

		// Token: 0x0400541A RID: 21530
		private IFlowTemplateMode _CameraCache;

		// Token: 0x0400541B RID: 21531
		private bool _CameraInited;

		// Token: 0x0400541C RID: 21532
		private SetCameraAnim _CameraAnimCache;

		// Token: 0x0400541D RID: 21533
		private bool _CameraAnimInited;
	}
}

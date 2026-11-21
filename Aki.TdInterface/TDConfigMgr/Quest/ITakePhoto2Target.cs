using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B0 RID: 4784
	public class ITakePhoto2Target
	{
		// Token: 0x06006BC3 RID: 27587 RVA: 0x001012A0 File Offset: 0x000FF4A0
		private ITakePhoto2Target_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2Target 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2Target_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2Target_SetValue());
			}
			return result;
		}

		// Token: 0x06006BC4 RID: 27588 RVA: 0x001012D8 File Offset: 0x000FF4D8
		public static ITakePhoto2Target Create([Nullable(2)] ITakePhoto2Target instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2Target
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006BC5 RID: 27589 RVA: 0x001012EB File Offset: 0x000FF4EB
		public static ITakePhoto2Target CreateFromSetValue([Nullable(2)] ITakePhoto2Target_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2Target
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x001012FE File Offset: 0x000FF4FE
		public ITakePhoto2Target_SetValue ToSetValue()
		{
			return new ITakePhoto2Target_SetValue
			{
				Type = this.Type,
				IsOptionalTarget = this.IsOptionalTarget,
				TargetCameraDistanceCondition = this.TargetCameraDistanceCondition
			};
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x06006BC7 RID: 27591 RVA: 0x00101329 File Offset: 0x000FF529
		// (set) Token: 0x06006BC8 RID: 27592 RVA: 0x00101354 File Offset: 0x000FF554
		public virtual ETakePhoto2TargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETakePhoto2TargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x06006BC9 RID: 27593 RVA: 0x00101364 File Offset: 0x000FF564
		// (set) Token: 0x06006BCA RID: 27594 RVA: 0x0010139E File Offset: 0x000FF59E
		public virtual bool? IsOptionalTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOptionalTarget;
				}
				ITakePhoto2Target_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOptionalTarget;
			}
			set
			{
				this.GetOrCreatePoco().IsOptionalTarget = value;
			}
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x06006BCB RID: 27595 RVA: 0x001013AC File Offset: 0x000FF5AC
		// (set) Token: 0x06006BCC RID: 27596 RVA: 0x0010140D File Offset: 0x000FF60D
		[Nullable(2)]
		public virtual ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition
		{
			[NullableContext(2)]
			get
			{
				if (this._TargetCameraDistanceConditionInited)
				{
					return this._TargetCameraDistanceConditionCache;
				}
				this._TargetCameraDistanceConditionInited = true;
				if (this.FbInstance != null)
				{
					this._TargetCameraDistanceConditionCache = ITakePhoto2TargetCameraDistanceCondition.Create(this.FbInstance.TargetCameraDistanceCondition);
				}
				else
				{
					ITakePhoto2Target_SetValue pocoInterface = this.PocoInterface;
					this._TargetCameraDistanceConditionCache = ((pocoInterface != null) ? pocoInterface.TargetCameraDistanceCondition : null);
				}
				return this._TargetCameraDistanceConditionCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TargetCameraDistanceCondition = value;
				this._TargetCameraDistanceConditionInited = false;
			}
		}

		// Token: 0x0400405B RID: 16475
		[Nullable(2)]
		protected ITakePhoto2Target FbInstance;

		// Token: 0x0400405C RID: 16476
		[Nullable(2)]
		protected ITakePhoto2Target_SetValue PocoInterface;

		// Token: 0x0400405D RID: 16477
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x0400405E RID: 16478
		private bool _TargetCameraDistanceConditionInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006B7 RID: 1719
	public class IPrefabCompTransform
	{
		// Token: 0x06002458 RID: 9304 RVA: 0x000631F0 File Offset: 0x000613F0
		private IPrefabCompTransform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPrefabCompTransform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPrefabCompTransform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPrefabCompTransform_SetValue());
			}
			return result;
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x00063228 File Offset: 0x00061428
		public static IPrefabCompTransform Create([Nullable(2)] IPrefabCompTransform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPrefabCompTransform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x0006323B File Offset: 0x0006143B
		public static IPrefabCompTransform CreateFromSetValue([Nullable(2)] IPrefabCompTransform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPrefabCompTransform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x0006324E File Offset: 0x0006144E
		public IPrefabCompTransform_SetValue ToSetValue()
		{
			return new IPrefabCompTransform_SetValue
			{
				ReferenceActorKey = this.ReferenceActorKey,
				Location = this.Location,
				Rotation = this.Rotation,
				Scale = this.Scale
			};
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x00063285 File Offset: 0x00061485
		// (set) Token: 0x0600245D RID: 9309 RVA: 0x000632B0 File Offset: 0x000614B0
		public virtual string ReferenceActorKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ReferenceActorKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ReferenceActorKey;
			}
			set
			{
				this.GetOrCreatePoco().ReferenceActorKey = value;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x000632C0 File Offset: 0x000614C0
		// (set) Token: 0x0600245F RID: 9311 RVA: 0x00063321 File Offset: 0x00061521
		[Nullable(2)]
		public virtual IPrefabCompTransformItem Location
		{
			[NullableContext(2)]
			get
			{
				if (this._LocationInited)
				{
					return this._LocationCache;
				}
				this._LocationInited = true;
				if (this.FbInstance != null)
				{
					this._LocationCache = IPrefabCompTransformItem.Create(this.FbInstance.Location);
				}
				else
				{
					IPrefabCompTransform_SetValue pocoInterface = this.PocoInterface;
					this._LocationCache = ((pocoInterface != null) ? pocoInterface.Location : null);
				}
				return this._LocationCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Location = value;
				this._LocationInited = false;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x00063338 File Offset: 0x00061538
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x00063399 File Offset: 0x00061599
		[Nullable(2)]
		public virtual IPrefabCompTransformItem Rotation
		{
			[NullableContext(2)]
			get
			{
				if (this._RotationInited)
				{
					return this._RotationCache;
				}
				this._RotationInited = true;
				if (this.FbInstance != null)
				{
					this._RotationCache = IPrefabCompTransformItem.Create(this.FbInstance.Rotation);
				}
				else
				{
					IPrefabCompTransform_SetValue pocoInterface = this.PocoInterface;
					this._RotationCache = ((pocoInterface != null) ? pocoInterface.Rotation : null);
				}
				return this._RotationCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Rotation = value;
				this._RotationInited = false;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x000633B0 File Offset: 0x000615B0
		// (set) Token: 0x06002463 RID: 9315 RVA: 0x00063411 File Offset: 0x00061611
		[Nullable(2)]
		public virtual IPrefabCompTransformItem Scale
		{
			[NullableContext(2)]
			get
			{
				if (this._ScaleInited)
				{
					return this._ScaleCache;
				}
				this._ScaleInited = true;
				if (this.FbInstance != null)
				{
					this._ScaleCache = IPrefabCompTransformItem.Create(this.FbInstance.Scale);
				}
				else
				{
					IPrefabCompTransform_SetValue pocoInterface = this.PocoInterface;
					this._ScaleCache = ((pocoInterface != null) ? pocoInterface.Scale : null);
				}
				return this._ScaleCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Scale = value;
				this._ScaleInited = false;
			}
		}

		// Token: 0x0400193B RID: 6459
		[Nullable(2)]
		protected IPrefabCompTransform FbInstance;

		// Token: 0x0400193C RID: 6460
		[Nullable(2)]
		protected IPrefabCompTransform_SetValue PocoInterface;

		// Token: 0x0400193D RID: 6461
		private IPrefabCompTransformItem _LocationCache;

		// Token: 0x0400193E RID: 6462
		private bool _LocationInited;

		// Token: 0x0400193F RID: 6463
		private IPrefabCompTransformItem _RotationCache;

		// Token: 0x04001940 RID: 6464
		private bool _RotationInited;

		// Token: 0x04001941 RID: 6465
		private IPrefabCompTransformItem _ScaleCache;

		// Token: 0x04001942 RID: 6466
		private bool _ScaleInited;
	}
}

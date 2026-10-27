using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200061A RID: 1562
	[NullableContext(2)]
	[Nullable(0)]
	public class IPrefabCompTransform
	{
		// Token: 0x06002152 RID: 8530 RVA: 0x0005C4DC File Offset: 0x0005A6DC
		[NullableContext(1)]
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

		// Token: 0x06002153 RID: 8531 RVA: 0x0005C514 File Offset: 0x0005A714
		[NullableContext(1)]
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

		// Token: 0x06002154 RID: 8532 RVA: 0x0005C527 File Offset: 0x0005A727
		[NullableContext(1)]
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

		// Token: 0x06002155 RID: 8533 RVA: 0x0005C53A File Offset: 0x0005A73A
		[NullableContext(1)]
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

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x0005C571 File Offset: 0x0005A771
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x0005C59C File Offset: 0x0005A79C
		[Nullable(1)]
		public virtual string ReferenceActorKey
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().ReferenceActorKey = value;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x0005C5AC File Offset: 0x0005A7AC
		// (set) Token: 0x06002159 RID: 8537 RVA: 0x0005C60D File Offset: 0x0005A80D
		public virtual IPrefabCompTransformItem Location
		{
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
			set
			{
				this.GetOrCreatePoco().Location = value;
				this._LocationInited = false;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x0005C624 File Offset: 0x0005A824
		// (set) Token: 0x0600215B RID: 8539 RVA: 0x0005C685 File Offset: 0x0005A885
		public virtual IPrefabCompTransformItem Rotation
		{
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
			set
			{
				this.GetOrCreatePoco().Rotation = value;
				this._RotationInited = false;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x0005C69C File Offset: 0x0005A89C
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x0005C6FD File Offset: 0x0005A8FD
		public virtual IPrefabCompTransformItem Scale
		{
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
			set
			{
				this.GetOrCreatePoco().Scale = value;
				this._ScaleInited = false;
			}
		}

		// Token: 0x04001749 RID: 5961
		protected IPrefabCompTransform FbInstance;

		// Token: 0x0400174A RID: 5962
		protected IPrefabCompTransform_SetValue PocoInterface;

		// Token: 0x0400174B RID: 5963
		[Nullable(1)]
		private IPrefabCompTransformItem _LocationCache;

		// Token: 0x0400174C RID: 5964
		private bool _LocationInited;

		// Token: 0x0400174D RID: 5965
		[Nullable(1)]
		private IPrefabCompTransformItem _RotationCache;

		// Token: 0x0400174E RID: 5966
		private bool _RotationInited;

		// Token: 0x0400174F RID: 5967
		[Nullable(1)]
		private IPrefabCompTransformItem _ScaleCache;

		// Token: 0x04001750 RID: 5968
		private bool _ScaleInited;
	}
}

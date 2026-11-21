using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E6D RID: 3693
	[NullableContext(2)]
	[Nullable(0)]
	public class IPrefabCompTransform
	{
		// Token: 0x06005373 RID: 21363 RVA: 0x000CDD5E File Offset: 0x000CBF5E
		[NullableContext(0)]
		public static IPrefabCompTransform Create(IPrefabCompTransform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPrefabCompTransform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x06005374 RID: 21364 RVA: 0x000CDD7D File Offset: 0x000CBF7D
		[Nullable(0)]
		public virtual string ReferenceActorKey
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.ReferenceActorKey;
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x06005375 RID: 21365 RVA: 0x000CDD8A File Offset: 0x000CBF8A
		public virtual IPrefabCompTransformItem Location
		{
			get
			{
				if (this._LocationInited)
				{
					return this._LocationCache;
				}
				this._LocationInited = true;
				this._LocationCache = IPrefabCompTransformItem.Create(this.Instance.Location);
				return this._LocationCache;
			}
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x06005376 RID: 21366 RVA: 0x000CDDBE File Offset: 0x000CBFBE
		public virtual IPrefabCompTransformItem Rotation
		{
			get
			{
				if (this._RotationInited)
				{
					return this._RotationCache;
				}
				this._RotationInited = true;
				this._RotationCache = IPrefabCompTransformItem.Create(this.Instance.Rotation);
				return this._RotationCache;
			}
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x06005377 RID: 21367 RVA: 0x000CDDF2 File Offset: 0x000CBFF2
		public virtual IPrefabCompTransformItem Scale
		{
			get
			{
				if (this._ScaleInited)
				{
					return this._ScaleCache;
				}
				this._ScaleInited = true;
				this._ScaleCache = IPrefabCompTransformItem.Create(this.Instance.Scale);
				return this._ScaleCache;
			}
		}

		// Token: 0x04002FB0 RID: 12208
		private IPrefabCompTransform Instance;

		// Token: 0x04002FB1 RID: 12209
		private IPrefabCompTransformItem _LocationCache;

		// Token: 0x04002FB2 RID: 12210
		private bool _LocationInited;

		// Token: 0x04002FB3 RID: 12211
		private IPrefabCompTransformItem _RotationCache;

		// Token: 0x04002FB4 RID: 12212
		private bool _RotationInited;

		// Token: 0x04002FB5 RID: 12213
		private IPrefabCompTransformItem _ScaleCache;

		// Token: 0x04002FB6 RID: 12214
		private bool _ScaleInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D71 RID: 3441
	[NullableContext(2)]
	[Nullable(0)]
	public class IPrefabCompTransform
	{
		// Token: 0x06004E4E RID: 20046 RVA: 0x000C250E File Offset: 0x000C070E
		[NullableContext(1)]
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

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06004E4F RID: 20047 RVA: 0x000C252D File Offset: 0x000C072D
		[Nullable(1)]
		public virtual string ReferenceActorKey
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.ReferenceActorKey;
			}
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06004E50 RID: 20048 RVA: 0x000C253A File Offset: 0x000C073A
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

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06004E51 RID: 20049 RVA: 0x000C256E File Offset: 0x000C076E
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

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06004E52 RID: 20050 RVA: 0x000C25A2 File Offset: 0x000C07A2
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

		// Token: 0x04002CEA RID: 11498
		private IPrefabCompTransform Instance;

		// Token: 0x04002CEB RID: 11499
		private IPrefabCompTransformItem _LocationCache;

		// Token: 0x04002CEC RID: 11500
		private bool _LocationInited;

		// Token: 0x04002CED RID: 11501
		private IPrefabCompTransformItem _RotationCache;

		// Token: 0x04002CEE RID: 11502
		private bool _RotationInited;

		// Token: 0x04002CEF RID: 11503
		private IPrefabCompTransformItem _ScaleCache;

		// Token: 0x04002CF0 RID: 11504
		private bool _ScaleInited;
	}
}

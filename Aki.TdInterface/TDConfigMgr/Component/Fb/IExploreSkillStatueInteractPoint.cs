using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D91 RID: 3473
	public class IExploreSkillStatueInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06004F01 RID: 20225 RVA: 0x000C4B81 File Offset: 0x000C2D81
		public static IExploreSkillStatueInteractPoint Create(IExploreSkillStatueInteractPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillStatueInteractPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06004F02 RID: 20226 RVA: 0x000C4BA0 File Offset: 0x000C2DA0
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06004F03 RID: 20227 RVA: 0x000C4BAD File Offset: 0x000C2DAD
		public virtual float PullTime
		{
			get
			{
				return this.Instance.PullTime;
			}
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06004F04 RID: 20228 RVA: 0x000C4BBC File Offset: 0x000C2DBC
		public virtual List<string> HangingPointList
		{
			get
			{
				if (this._HangingPointListInited)
				{
					return this._HangingPointListCache;
				}
				this._HangingPointListInited = true;
				int hangingPointListLength = this.Instance.HangingPointListLength;
				this._HangingPointListCache = new List<string>(hangingPointListLength);
				for (int i = 0; i < hangingPointListLength; i++)
				{
					this._HangingPointListCache.Add(this.Instance.HangingPointList(i));
				}
				return this._HangingPointListCache;
			}
		}

		// Token: 0x04002CE4 RID: 11492
		private IExploreSkillStatueInteractPoint Instance;

		// Token: 0x04002CE5 RID: 11493
		private List<string> _HangingPointListCache;

		// Token: 0x04002CE6 RID: 11494
		private bool _HangingPointListInited;
	}
}

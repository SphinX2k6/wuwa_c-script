using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CAF RID: 3247
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillStatueInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06004A53 RID: 19027 RVA: 0x000BA171 File Offset: 0x000B8371
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

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06004A54 RID: 19028 RVA: 0x000BA190 File Offset: 0x000B8390
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06004A55 RID: 19029 RVA: 0x000BA19D File Offset: 0x000B839D
		public virtual float PullTime
		{
			get
			{
				return this.Instance.PullTime;
			}
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x06004A56 RID: 19030 RVA: 0x000BA1AC File Offset: 0x000B83AC
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

		// Token: 0x04002A6A RID: 10858
		private IExploreSkillStatueInteractPoint Instance;

		// Token: 0x04002A6B RID: 10859
		private List<string> _HangingPointListCache;

		// Token: 0x04002A6C RID: 10860
		private bool _HangingPointListInited;
	}
}

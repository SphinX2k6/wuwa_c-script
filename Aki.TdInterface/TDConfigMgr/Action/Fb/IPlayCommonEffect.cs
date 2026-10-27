using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025E6 RID: 9702
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayCommonEffect : PlayEffect2
	{
		// Token: 0x0600DA09 RID: 55817 RVA: 0x0020811B File Offset: 0x0020631B
		public static IPlayCommonEffect Create(IPlayCommonEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayCommonEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FFF RID: 16383
		// (get) Token: 0x0600DA0A RID: 55818 RVA: 0x0020813A File Offset: 0x0020633A
		public override EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004000 RID: 16384
		// (get) Token: 0x0600DA0B RID: 55819 RVA: 0x00208147 File Offset: 0x00206347
		public override string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x17004001 RID: 16385
		// (get) Token: 0x0600DA0C RID: 55820 RVA: 0x00208154 File Offset: 0x00206354
		public virtual IBasePos2 Pos2
		{
			get
			{
				if (this._Pos2Inited)
				{
					return this._Pos2Cache;
				}
				this._Pos2Inited = true;
				this._Pos2Cache = ActionReadHelper.ReadIPlayCommonEffect_Pos2(this.Instance);
				return this._Pos2Cache;
			}
		}

		// Token: 0x17004002 RID: 16386
		// (get) Token: 0x0600DA0D RID: 55821 RVA: 0x00208184 File Offset: 0x00206384
		public virtual float? DestroyTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DestroyTime);
			}
		}

		// Token: 0x17004003 RID: 16387
		// (get) Token: 0x0600DA0E RID: 55822 RVA: 0x002081BC File Offset: 0x002063BC
		public virtual bool? PlayEffectEnd
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.PlayEffectEnd);
			}
		}

		// Token: 0x04007918 RID: 31000
		private IPlayCommonEffect Instance;

		// Token: 0x04007919 RID: 31001
		private IBasePos2 _Pos2Cache;

		// Token: 0x0400791A RID: 31002
		private bool _Pos2Inited;
	}
}

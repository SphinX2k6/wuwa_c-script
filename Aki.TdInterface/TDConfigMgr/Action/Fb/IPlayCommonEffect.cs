using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A5 RID: 10405
	public class IPlayCommonEffect : PlayEffect2
	{
		// Token: 0x0600E7D2 RID: 59346 RVA: 0x00224807 File Offset: 0x00222A07
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

		// Token: 0x17004336 RID: 17206
		// (get) Token: 0x0600E7D3 RID: 59347 RVA: 0x00224826 File Offset: 0x00222A26
		public override EEffectType Type
		{
			get
			{
				return (EEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004337 RID: 17207
		// (get) Token: 0x0600E7D4 RID: 59348 RVA: 0x00224833 File Offset: 0x00222A33
		public override string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x17004338 RID: 17208
		// (get) Token: 0x0600E7D5 RID: 59349 RVA: 0x00224840 File Offset: 0x00222A40
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

		// Token: 0x17004339 RID: 17209
		// (get) Token: 0x0600E7D6 RID: 59350 RVA: 0x00224870 File Offset: 0x00222A70
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

		// Token: 0x1700433A RID: 17210
		// (get) Token: 0x0600E7D7 RID: 59351 RVA: 0x002248A8 File Offset: 0x00222AA8
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

		// Token: 0x04007FAF RID: 32687
		private IPlayCommonEffect Instance;

		// Token: 0x04007FB0 RID: 32688
		private IBasePos2 _Pos2Cache;

		// Token: 0x04007FB1 RID: 32689
		private bool _Pos2Inited;
	}
}

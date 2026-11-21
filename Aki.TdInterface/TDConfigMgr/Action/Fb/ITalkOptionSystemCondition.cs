using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B5 RID: 10165
	public class ITalkOptionSystemCondition : ITalkOptionPreConditionBase
	{
		// Token: 0x0600E0FA RID: 57594 RVA: 0x002115A1 File Offset: 0x0020F7A1
		public static ITalkOptionSystemCondition Create(ITalkOptionSystemCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionSystemCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E3E RID: 15934
		// (get) Token: 0x0600E0FB RID: 57595 RVA: 0x002115C0 File Offset: 0x0020F7C0
		public override ETalkOptionPreConditionType Type
		{
			get
			{
				return (ETalkOptionPreConditionType)this.Instance.Type;
			}
		}

		// Token: 0x17003E3F RID: 15935
		// (get) Token: 0x0600E0FC RID: 57596 RVA: 0x002115CD File Offset: 0x0020F7CD
		public virtual ITalkOptionConditionSolarSchool System
		{
			get
			{
				if (this._SystemInited)
				{
					return this._SystemCache;
				}
				this._SystemInited = true;
				this._SystemCache = ITalkOptionConditionSolarSchool.Create(this.Instance.System);
				return this._SystemCache;
			}
		}

		// Token: 0x17003E40 RID: 15936
		// (get) Token: 0x0600E0FD RID: 57597 RVA: 0x00211604 File Offset: 0x0020F804
		public virtual bool? HideWhenUnmet
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.HideWhenUnmet);
			}
		}

		// Token: 0x17003E41 RID: 15937
		// (get) Token: 0x0600E0FE RID: 57598 RVA: 0x0021163C File Offset: 0x0020F83C
		public virtual bool? HideConditionTextWhenUnmet
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.HideConditionTextWhenUnmet);
			}
		}

		// Token: 0x17003E42 RID: 15938
		// (get) Token: 0x0600E0FF RID: 57599 RVA: 0x00211672 File Offset: 0x0020F872
		[Nullable(2)]
		public virtual string TidReplaceTextWhenUnmet
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.TidReplaceTextWhenUnmet;
			}
		}

		// Token: 0x04007A51 RID: 31313
		private ITalkOptionSystemCondition Instance;

		// Token: 0x04007A52 RID: 31314
		[Nullable(2)]
		private ITalkOptionConditionSolarSchool _SystemCache;

		// Token: 0x04007A53 RID: 31315
		private bool _SystemInited;
	}
}

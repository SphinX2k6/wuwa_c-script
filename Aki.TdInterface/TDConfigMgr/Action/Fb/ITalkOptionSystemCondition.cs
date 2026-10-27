using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200250F RID: 9487
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionSystemCondition : ITalkOptionPreConditionBase
	{
		// Token: 0x0600D39E RID: 54174 RVA: 0x001F5BA9 File Offset: 0x001F3DA9
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

		// Token: 0x17003B42 RID: 15170
		// (get) Token: 0x0600D39F RID: 54175 RVA: 0x001F5BC8 File Offset: 0x001F3DC8
		public override ETalkOptionPreConditionType Type
		{
			get
			{
				return (ETalkOptionPreConditionType)this.Instance.Type;
			}
		}

		// Token: 0x17003B43 RID: 15171
		// (get) Token: 0x0600D3A0 RID: 54176 RVA: 0x001F5BD5 File Offset: 0x001F3DD5
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

		// Token: 0x17003B44 RID: 15172
		// (get) Token: 0x0600D3A1 RID: 54177 RVA: 0x001F5C0C File Offset: 0x001F3E0C
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

		// Token: 0x17003B45 RID: 15173
		// (get) Token: 0x0600D3A2 RID: 54178 RVA: 0x001F5C44 File Offset: 0x001F3E44
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

		// Token: 0x17003B46 RID: 15174
		// (get) Token: 0x0600D3A3 RID: 54179 RVA: 0x001F5C7A File Offset: 0x001F3E7A
		[Nullable(2)]
		public virtual string TidReplaceTextWhenUnmet
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.TidReplaceTextWhenUnmet;
			}
		}

		// Token: 0x040073FF RID: 29695
		private ITalkOptionSystemCondition Instance;

		// Token: 0x04007400 RID: 29696
		[Nullable(2)]
		private ITalkOptionConditionSolarSchool _SystemCache;

		// Token: 0x04007401 RID: 29697
		private bool _SystemInited;
	}
}

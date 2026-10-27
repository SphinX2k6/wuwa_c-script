using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002755 RID: 10069
	[NullableContext(1)]
	[Nullable(0)]
	public class INightmareLordTip : ICommonTipType
	{
		// Token: 0x0600E054 RID: 57428 RVA: 0x00212F14 File Offset: 0x00211114
		public static INightmareLordTip Create(INightmareLordTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INightmareLordTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700436C RID: 17260
		// (get) Token: 0x0600E055 RID: 57429 RVA: 0x00212F33 File Offset: 0x00211133
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700436D RID: 17261
		// (get) Token: 0x0600E056 RID: 57430 RVA: 0x00212F40 File Offset: 0x00211140
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x1700436E RID: 17262
		// (get) Token: 0x0600E057 RID: 57431 RVA: 0x00212F4D File Offset: 0x0021114D
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x1700436F RID: 17263
		// (get) Token: 0x0600E058 RID: 57432 RVA: 0x00212F5A File Offset: 0x0021115A
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17004370 RID: 17264
		// (get) Token: 0x0600E059 RID: 57433 RVA: 0x00212F5D File Offset: 0x0021115D
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C53 RID: 31827
		private INightmareLordTip Instance;
	}
}

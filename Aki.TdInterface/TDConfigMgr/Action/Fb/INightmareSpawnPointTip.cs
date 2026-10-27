using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002756 RID: 10070
	[NullableContext(1)]
	[Nullable(0)]
	public class INightmareSpawnPointTip : ICommonTipType
	{
		// Token: 0x0600E05B RID: 57435 RVA: 0x00212F68 File Offset: 0x00211168
		public static INightmareSpawnPointTip Create(INightmareSpawnPointTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INightmareSpawnPointTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004371 RID: 17265
		// (get) Token: 0x0600E05C RID: 57436 RVA: 0x00212F87 File Offset: 0x00211187
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004372 RID: 17266
		// (get) Token: 0x0600E05D RID: 57437 RVA: 0x00212F94 File Offset: 0x00211194
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x17004373 RID: 17267
		// (get) Token: 0x0600E05E RID: 57438 RVA: 0x00212FA1 File Offset: 0x002111A1
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x17004374 RID: 17268
		// (get) Token: 0x0600E05F RID: 57439 RVA: 0x00212FAE File Offset: 0x002111AE
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17004375 RID: 17269
		// (get) Token: 0x0600E060 RID: 57440 RVA: 0x00212FB1 File Offset: 0x002111B1
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C54 RID: 31828
		private INightmareSpawnPointTip Instance;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013AE RID: 5038
	public class ITakePhoto2PosCondition
	{
		// Token: 0x06007319 RID: 29465 RVA: 0x00114749 File Offset: 0x00112949
		[NullableContext(1)]
		public static ITakePhoto2PosCondition Create(ITakePhoto2PosCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2PosCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x0600731A RID: 29466 RVA: 0x00114768 File Offset: 0x00112968
		public virtual int RangeEntity
		{
			get
			{
				return this.Instance.RangeEntity;
			}
		}

		// Token: 0x04004290 RID: 17040
		private ITakePhoto2PosCondition Instance;
	}
}

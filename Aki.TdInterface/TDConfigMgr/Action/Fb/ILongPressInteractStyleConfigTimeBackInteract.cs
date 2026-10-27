using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002614 RID: 9748
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressInteractStyleConfigTimeBackInteract : ILongPressInteractStyleConfig
	{
		// Token: 0x0600DAD5 RID: 56021 RVA: 0x002097FD File Offset: 0x002079FD
		[NullableContext(1)]
		public static ILongPressInteractStyleConfigTimeBackInteract Create(ILongPressInteractStyleConfigTimeBackInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfigTimeBackInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700406F RID: 16495
		// (get) Token: 0x0600DAD6 RID: 56022 RVA: 0x0020981C File Offset: 0x00207A1C
		public override ELongPressInteractStyle Type
		{
			get
			{
				return (ELongPressInteractStyle)this.Instance.Type;
			}
		}

		// Token: 0x17004070 RID: 16496
		// (get) Token: 0x0600DAD7 RID: 56023 RVA: 0x00209829 File Offset: 0x00207A29
		public virtual string TidContent
		{
			get
			{
				return this.Instance.TidContent;
			}
		}

		// Token: 0x17004071 RID: 16497
		// (get) Token: 0x0600DAD8 RID: 56024 RVA: 0x00209838 File Offset: 0x00207A38
		public virtual float? StartProgress
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.StartProgress);
			}
		}

		// Token: 0x17004072 RID: 16498
		// (get) Token: 0x0600DAD9 RID: 56025 RVA: 0x0020986E File Offset: 0x00207A6E
		public virtual string EdTidContent
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400798A RID: 31114
		private ILongPressInteractStyleConfigTimeBackInteract Instance;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025AD RID: 9645
	public class IUniversalTone
	{
		// Token: 0x0600D8FA RID: 55546 RVA: 0x002060B9 File Offset: 0x002042B9
		[NullableContext(1)]
		public static IUniversalTone Create(IUniversalTone? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUniversalTone
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F62 RID: 16226
		// (get) Token: 0x0600D8FB RID: 55547 RVA: 0x002060D8 File Offset: 0x002042D8
		public virtual int UniversalToneId
		{
			get
			{
				return this.Instance.UniversalToneId;
			}
		}

		// Token: 0x17003F63 RID: 16227
		// (get) Token: 0x0600D8FC RID: 55548 RVA: 0x002060E8 File Offset: 0x002042E8
		public virtual int? TimberId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TimberId);
			}
		}

		// Token: 0x0400788B RID: 30859
		private IUniversalTone Instance;
	}
}

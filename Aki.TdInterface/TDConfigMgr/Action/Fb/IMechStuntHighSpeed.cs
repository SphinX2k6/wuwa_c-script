using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE1 RID: 10977
	public class IMechStuntHighSpeed : IMechStuntConfigType
	{
		// Token: 0x0600F1A6 RID: 61862 RVA: 0x00235586 File Offset: 0x00233786
		public static IMechStuntHighSpeed Create(IMechStuntHighSpeed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntHighSpeed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004892 RID: 18578
		// (get) Token: 0x0600F1A7 RID: 61863 RVA: 0x002355A5 File Offset: 0x002337A5
		public override EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x040084B1 RID: 33969
		private IMechStuntHighSpeed Instance;
	}
}

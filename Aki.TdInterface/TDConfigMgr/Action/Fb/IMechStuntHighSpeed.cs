using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200280E RID: 10254
	public class IMechStuntHighSpeed : IMechStuntConfigType
	{
		// Token: 0x0600E381 RID: 58241 RVA: 0x00218722 File Offset: 0x00216922
		[NullableContext(1)]
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

		// Token: 0x17004527 RID: 17703
		// (get) Token: 0x0600E382 RID: 58242 RVA: 0x00218741 File Offset: 0x00216941
		public override EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x04007DF4 RID: 32244
		private IMechStuntHighSpeed Instance;
	}
}

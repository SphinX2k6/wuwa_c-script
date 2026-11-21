using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DFC RID: 11772
	public class IElementalBoxTargetPrefabPos : IElementalBoxTargetPosTypeBase
	{
		// Token: 0x0600FFEE RID: 65518 RVA: 0x0024D95F File Offset: 0x0024BB5F
		public static IElementalBoxTargetPrefabPos Create(IElementalBoxTargetPrefabPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IElementalBoxTargetPrefabPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050A4 RID: 20644
		// (get) Token: 0x0600FFEF RID: 65519 RVA: 0x0024D97E File Offset: 0x0024BB7E
		public override EElementalBoxTargetPosType Type
		{
			get
			{
				return (EElementalBoxTargetPosType)this.Instance.Type;
			}
		}

		// Token: 0x170050A5 RID: 20645
		// (get) Token: 0x0600FFF0 RID: 65520 RVA: 0x0024D98B File Offset: 0x0024BB8B
		public virtual string TargetKey
		{
			get
			{
				return this.Instance.TargetKey;
			}
		}

		// Token: 0x04008BAC RID: 35756
		private IElementalBoxTargetPrefabPos Instance;
	}
}

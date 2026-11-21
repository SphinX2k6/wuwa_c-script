using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E82 RID: 3714
	public class ISpawnConfigType
	{
		// Token: 0x060053E7 RID: 21479 RVA: 0x000CECE9 File Offset: 0x000CCEE9
		public static ISpawnConfigType Create(ISpawnConfigType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnConfigType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x060053E8 RID: 21480 RVA: 0x000CED08 File Offset: 0x000CCF08
		public virtual ESpawnConfigType Type
		{
			get
			{
				return (ESpawnConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04002FF9 RID: 12281
		private ISpawnConfigType Instance;
	}
}

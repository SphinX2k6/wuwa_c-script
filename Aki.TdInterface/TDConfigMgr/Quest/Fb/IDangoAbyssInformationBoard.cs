using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012D3 RID: 4819
	public class IDangoAbyssInformationBoard : IInformationBoardType
	{
		// Token: 0x06006E31 RID: 28209 RVA: 0x0010A847 File Offset: 0x00108A47
		[NullableContext(1)]
		public static IDangoAbyssInformationBoard Create(IDangoAbyssInformationBoard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDangoAbyssInformationBoard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x06006E32 RID: 28210 RVA: 0x0010A866 File Offset: 0x00108A66
		public override EInformationBoardType Type
		{
			get
			{
				return (EInformationBoardType)this.Instance.Type;
			}
		}

		// Token: 0x04003F27 RID: 16167
		private IDangoAbyssInformationBoard Instance;
	}
}

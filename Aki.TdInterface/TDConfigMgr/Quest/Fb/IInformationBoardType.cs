using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012D2 RID: 4818
	public class IInformationBoardType
	{
		// Token: 0x06006E2E RID: 28206 RVA: 0x0010A813 File Offset: 0x00108A13
		[NullableContext(1)]
		public static IInformationBoardType Create(IInformationBoardType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationBoardType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x06006E2F RID: 28207 RVA: 0x0010A832 File Offset: 0x00108A32
		public virtual EInformationBoardType Type
		{
			get
			{
				return (EInformationBoardType)this.Instance.Type;
			}
		}

		// Token: 0x04003F26 RID: 16166
		private IInformationBoardType Instance;
	}
}

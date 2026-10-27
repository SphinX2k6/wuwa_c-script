using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012D6 RID: 4822
	public class IStalkingGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x06006E3A RID: 28218 RVA: 0x0010A90A File Offset: 0x00108B0A
		[NullableContext(1)]
		public static IStalkingGamePlayConfig Create(IStalkingGamePlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStalkingGamePlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x06006E3B RID: 28219 RVA: 0x0010A929 File Offset: 0x00108B29
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				return (ESpecialGamePlayConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04003F2C RID: 16172
		private IStalkingGamePlayConfig Instance;
	}
}

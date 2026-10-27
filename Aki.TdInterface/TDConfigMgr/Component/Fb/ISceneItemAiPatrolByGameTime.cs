using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D75 RID: 3445
	public class ISceneItemAiPatrolByGameTime : ISceneItemAiPatrolType
	{
		// Token: 0x06004E64 RID: 20068 RVA: 0x000C285F File Offset: 0x000C0A5F
		[NullableContext(1)]
		public static ISceneItemAiPatrolByGameTime Create(ISceneItemAiPatrolByGameTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemAiPatrolByGameTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x06004E65 RID: 20069 RVA: 0x000C287E File Offset: 0x000C0A7E
		public override ESceneItemAiPatrolType Type
		{
			get
			{
				return (ESceneItemAiPatrolType)this.Instance.Type;
			}
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x06004E66 RID: 20070 RVA: 0x000C288B File Offset: 0x000C0A8B
		public virtual int Spline
		{
			get
			{
				return this.Instance.Spline;
			}
		}

		// Token: 0x04002CFE RID: 11518
		private ISceneItemAiPatrolByGameTime Instance;
	}
}

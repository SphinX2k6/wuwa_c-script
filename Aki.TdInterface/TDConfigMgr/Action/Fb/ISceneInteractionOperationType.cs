using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200294D RID: 10573
	public class ISceneInteractionOperationType
	{
		// Token: 0x0600EA7A RID: 60026 RVA: 0x0022566E File Offset: 0x0022386E
		[NullableContext(1)]
		public static ISceneInteractionOperationType Create(ISceneInteractionOperationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneInteractionOperationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049A2 RID: 18850
		// (get) Token: 0x0600EA7B RID: 60027 RVA: 0x0022568D File Offset: 0x0022388D
		public virtual ESceneInteractionOperationType Type
		{
			get
			{
				return (ESceneInteractionOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400813D RID: 33085
		private ISceneInteractionOperationType Instance;
	}
}

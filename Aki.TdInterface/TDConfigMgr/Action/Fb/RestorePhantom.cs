using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200288C RID: 10380
	public class RestorePhantom : ActionParams
	{
		// Token: 0x0600E5EE RID: 58862 RVA: 0x0021CBE0 File Offset: 0x0021ADE0
		[NullableContext(1)]
		public static RestorePhantom Create(IRestorePhantom? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RestorePhantom
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007F1E RID: 32542
		private IRestorePhantom Instance;
	}
}

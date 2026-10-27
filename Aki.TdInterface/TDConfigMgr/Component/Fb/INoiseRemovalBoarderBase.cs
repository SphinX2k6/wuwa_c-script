using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E48 RID: 3656
	public class INoiseRemovalBoarderBase
	{
		// Token: 0x06005292 RID: 21138 RVA: 0x000CB367 File Offset: 0x000C9567
		[NullableContext(1)]
		public static INoiseRemovalBoarderBase Create(INoiseRemovalBoarderBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INoiseRemovalBoarderBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06005293 RID: 21139 RVA: 0x000CB386 File Offset: 0x000C9586
		public virtual ENoiseRemovalBoarderShape Type
		{
			get
			{
				return (ENoiseRemovalBoarderShape)this.Instance.Type;
			}
		}

		// Token: 0x04002F97 RID: 12183
		private INoiseRemovalBoarderBase Instance;
	}
}

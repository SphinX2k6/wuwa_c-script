using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024FD RID: 9469
	public class IOpenGlobalTimeScale : ISetGlobalTimeScaleType
	{
		// Token: 0x0600D35D RID: 54109 RVA: 0x001F565E File Offset: 0x001F385E
		[NullableContext(1)]
		public static IOpenGlobalTimeScale Create(IOpenGlobalTimeScale? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenGlobalTimeScale
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B25 RID: 15141
		// (get) Token: 0x0600D35E RID: 54110 RVA: 0x001F567D File Offset: 0x001F387D
		public override ESetTimeScaleType Type
		{
			get
			{
				return (ESetTimeScaleType)this.Instance.Type;
			}
		}

		// Token: 0x17003B26 RID: 15142
		// (get) Token: 0x0600D35F RID: 54111 RVA: 0x001F568A File Offset: 0x001F388A
		public virtual float TimeScale
		{
			get
			{
				return this.Instance.TimeScale;
			}
		}

		// Token: 0x17003B27 RID: 15143
		// (get) Token: 0x0600D360 RID: 54112 RVA: 0x001F5697 File Offset: 0x001F3897
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x040073E3 RID: 29667
		private IOpenGlobalTimeScale Instance;
	}
}

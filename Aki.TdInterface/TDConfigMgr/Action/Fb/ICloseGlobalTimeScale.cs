using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024FE RID: 9470
	public class ICloseGlobalTimeScale : ISetGlobalTimeScaleType
	{
		// Token: 0x0600D362 RID: 54114 RVA: 0x001F56AC File Offset: 0x001F38AC
		[NullableContext(1)]
		public static ICloseGlobalTimeScale Create(ICloseGlobalTimeScale? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseGlobalTimeScale
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B28 RID: 15144
		// (get) Token: 0x0600D363 RID: 54115 RVA: 0x001F56CB File Offset: 0x001F38CB
		public override ESetTimeScaleType Type
		{
			get
			{
				return (ESetTimeScaleType)this.Instance.Type;
			}
		}

		// Token: 0x17003B29 RID: 15145
		// (get) Token: 0x0600D364 RID: 54116 RVA: 0x001F56D8 File Offset: 0x001F38D8
		public virtual ETimeScaleCloseSource? TimeScaleCloseSource
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new ETimeScaleCloseSource?((ETimeScaleCloseSource)this.Instance.TimeScaleCloseSource);
			}
		}

		// Token: 0x040073E4 RID: 29668
		private ICloseGlobalTimeScale Instance;
	}
}

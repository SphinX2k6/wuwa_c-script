using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A4 RID: 10148
	public class ICloseGlobalTimeScale : ISetGlobalTimeScaleType
	{
		// Token: 0x0600E0BE RID: 57534 RVA: 0x002110A4 File Offset: 0x0020F2A4
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

		// Token: 0x17003E24 RID: 15908
		// (get) Token: 0x0600E0BF RID: 57535 RVA: 0x002110C3 File Offset: 0x0020F2C3
		public override ESetTimeScaleType Type
		{
			get
			{
				return (ESetTimeScaleType)this.Instance.Type;
			}
		}

		// Token: 0x17003E25 RID: 15909
		// (get) Token: 0x0600E0C0 RID: 57536 RVA: 0x002110D0 File Offset: 0x0020F2D0
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

		// Token: 0x04007A36 RID: 31286
		private ICloseGlobalTimeScale Instance;
	}
}

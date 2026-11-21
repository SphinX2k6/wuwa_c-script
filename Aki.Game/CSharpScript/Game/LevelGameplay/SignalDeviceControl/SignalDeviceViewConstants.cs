using System;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl
{
	// Token: 0x02005BAC RID: 23468
	public class SignalDeviceViewConstants
	{
		// Token: 0x17006DFE RID: 28158
		// (get) Token: 0x06039B3C RID: 236348 RVA: 0x01033665 File Offset: 0x01031865
		public static int GRIDNUM
		{
			get
			{
				return SignalDeviceModel.ROWNUM * SignalDeviceModel.ROWNUM;
			}
		}
	}
}

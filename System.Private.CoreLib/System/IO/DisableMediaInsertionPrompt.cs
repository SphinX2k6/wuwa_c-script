using System;

namespace System.IO
{
	// Token: 0x02000850 RID: 2128
	internal struct DisableMediaInsertionPrompt : IDisposable
	{
		// Token: 0x06008783 RID: 34691 RVA: 0x00147C28 File Offset: 0x00145E28
		public static DisableMediaInsertionPrompt Create()
		{
			DisableMediaInsertionPrompt result = default(DisableMediaInsertionPrompt);
			result._disableSuccess = Interop.Kernel32.SetThreadErrorMode(1U, out result._oldMode);
			return result;
		}

		// Token: 0x06008784 RID: 34692 RVA: 0x00147C54 File Offset: 0x00145E54
		public void Dispose()
		{
			if (this._disableSuccess)
			{
				uint num;
				Interop.Kernel32.SetThreadErrorMode(this._oldMode, out num);
			}
		}

		// Token: 0x04001D74 RID: 7540
		private bool _disableSuccess;

		// Token: 0x04001D75 RID: 7541
		private uint _oldMode;
	}
}

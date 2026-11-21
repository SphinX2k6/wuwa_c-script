using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005E9 RID: 1513
	public sealed class PosixSignalRegistration : IDisposable
	{
		// Token: 0x0600715D RID: 29021 RVA: 0x0010FC9F File Offset: 0x0010DE9F
		[NullableContext(1)]
		[UnsupportedOSPlatform("android")]
		[UnsupportedOSPlatform("browser")]
		[UnsupportedOSPlatform("ios")]
		[UnsupportedOSPlatform("tvos")]
		public static PosixSignalRegistration Create(PosixSignal signal, Action<PosixSignalContext> handler)
		{
			ArgumentNullException.ThrowIfNull(handler, "handler");
			return PosixSignalRegistration.Register(signal, handler);
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x0010FCB3 File Offset: 0x0010DEB3
		private PosixSignalRegistration(PosixSignalRegistration.Token token)
		{
			this._token = token;
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x0010FCC2 File Offset: 0x0010DEC2
		public void Dispose()
		{
			this.Unregister();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x0010FCD0 File Offset: 0x0010DED0
		~PosixSignalRegistration()
		{
			this.Unregister();
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x0010FCFC File Offset: 0x0010DEFC
		private static PosixSignalRegistration Register(PosixSignal signal, Action<PosixSignalContext> handler)
		{
			if (signal - PosixSignal.SIGTERM > 3)
			{
				throw new PlatformNotSupportedException();
			}
			PosixSignalRegistration.Token token = new PosixSignalRegistration.Token(signal, handler);
			PosixSignalRegistration result = new PosixSignalRegistration(token);
			HashSet<PosixSignalRegistration.Token> obj = PosixSignalRegistration.s_registrations;
			lock (obj)
			{
				if (PosixSignalRegistration.s_registrations.Count == 0 && !Interop.Kernel32.SetConsoleCtrlHandler(ldftn(HandlerRoutine), 1))
				{
					throw Win32Marshal.GetExceptionForLastWin32Error("");
				}
				PosixSignalRegistration.s_registrations.Add(token);
			}
			return result;
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x0010FD84 File Offset: 0x0010DF84
		private void Unregister()
		{
			HashSet<PosixSignalRegistration.Token> obj = PosixSignalRegistration.s_registrations;
			lock (obj)
			{
				PosixSignalRegistration.Token token = this._token;
				if (token != null)
				{
					this._token = null;
					PosixSignalRegistration.s_registrations.Remove(token);
					if (PosixSignalRegistration.s_registrations.Count == 0 && !Interop.Kernel32.SetConsoleCtrlHandler(ldftn(HandlerRoutine), 0))
					{
						int lastPInvokeError = Marshal.GetLastPInvokeError();
						if (lastPInvokeError != 87)
						{
							throw Win32Marshal.GetExceptionForWin32Error(lastPInvokeError, "", null);
						}
					}
				}
			}
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x0010FE0C File Offset: 0x0010E00C
		[UnmanagedCallersOnly]
		private static Interop.BOOL HandlerRoutine(int dwCtrlType)
		{
			PosixSignal posixSignal;
			switch (dwCtrlType)
			{
			case 0:
				posixSignal = PosixSignal.SIGINT;
				goto IL_39;
			case 1:
				posixSignal = PosixSignal.SIGQUIT;
				goto IL_39;
			case 2:
				posixSignal = PosixSignal.SIGHUP;
				goto IL_39;
			case 6:
				posixSignal = PosixSignal.SIGTERM;
				goto IL_39;
			}
			return Interop.BOOL.FALSE;
			IL_39:
			List<PosixSignalRegistration.Token> list = null;
			HashSet<PosixSignalRegistration.Token> obj = PosixSignalRegistration.s_registrations;
			lock (obj)
			{
				foreach (PosixSignalRegistration.Token token in PosixSignalRegistration.s_registrations)
				{
					if (token.Signal == posixSignal)
					{
						List<PosixSignalRegistration.Token> list2;
						if ((list2 = list) == null)
						{
							list2 = (list = new List<PosixSignalRegistration.Token>());
						}
						list2.Add(token);
					}
				}
			}
			if (list == null)
			{
				return Interop.BOOL.FALSE;
			}
			PosixSignalContext posixSignalContext = new PosixSignalContext(posixSignal);
			foreach (PosixSignalRegistration.Token token2 in list)
			{
				token2.Handler(posixSignalContext);
			}
			if (!posixSignalContext.Cancel)
			{
				return Interop.BOOL.FALSE;
			}
			return Interop.BOOL.TRUE;
		}

		// Token: 0x040012C4 RID: 4804
		private PosixSignalRegistration.Token _token;

		// Token: 0x040012C5 RID: 4805
		private static readonly HashSet<PosixSignalRegistration.Token> s_registrations = new HashSet<PosixSignalRegistration.Token>();

		// Token: 0x020005EA RID: 1514
		private sealed class Token
		{
			// Token: 0x06007165 RID: 29029 RVA: 0x0010FF40 File Offset: 0x0010E140
			public Token(PosixSignal signal, Action<PosixSignalContext> handler)
			{
				this.Signal = signal;
				this.Handler = handler;
			}

			// Token: 0x17000DF2 RID: 3570
			// (get) Token: 0x06007166 RID: 29030 RVA: 0x0010FF56 File Offset: 0x0010E156
			public PosixSignal Signal { get; }

			// Token: 0x17000DF3 RID: 3571
			// (get) Token: 0x06007167 RID: 29031 RVA: 0x0010FF5E File Offset: 0x0010E15E
			public Action<PosixSignalContext> Handler { get; }
		}
	}
}

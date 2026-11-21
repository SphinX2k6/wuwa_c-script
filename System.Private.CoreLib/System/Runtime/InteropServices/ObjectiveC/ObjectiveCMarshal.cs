using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Runtime.InteropServices.ObjectiveC
{
	// Token: 0x02000601 RID: 1537
	[SupportedOSPlatform("macos")]
	[CLSCompliant(false)]
	public static class ObjectiveCMarshal
	{
		// Token: 0x060071B5 RID: 29109 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void Initialize(method beginEndCallback, isReferencedCallback, void trackedObjectEnteredFinalization, [Nullable(1)] method unhandledExceptionPropagationHandler)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060071B6 RID: 29110 RVA: 0x00110910 File Offset: 0x0010EB10
		public static GCHandle CreateReferenceTrackingHandle([Nullable(1)] object obj, out Span<IntPtr> taggedMemory)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060071B7 RID: 29111 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void SetMessageSendCallback(ObjectiveCMarshal.MessageSendFunction msgSendFunction, IntPtr func)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060071B8 RID: 29112 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(2)]
		public static void SetMessageSendPendingException(Exception exception)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x02000602 RID: 1538
		// (Invoke) Token: 0x060071BA RID: 29114
		public delegate method UnhandledExceptionPropagationHandler([Nullable(1)] void exception, void lastMethod, [Out] IntPtr context);

		// Token: 0x02000603 RID: 1539
		public enum MessageSendFunction
		{
			// Token: 0x04001337 RID: 4919
			MsgSend,
			// Token: 0x04001338 RID: 4920
			MsgSendFpret,
			// Token: 0x04001339 RID: 4921
			MsgSendStret,
			// Token: 0x0400133A RID: 4922
			MsgSendSuper,
			// Token: 0x0400133B RID: 4923
			MsgSendSuperStret
		}
	}
}

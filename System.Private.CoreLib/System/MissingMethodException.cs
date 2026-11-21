using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000171 RID: 369
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class MissingMethodException : MissingMemberException
	{
		// Token: 0x06001893 RID: 6291 RVA: 0x0004CBA5 File Offset: 0x0004ADA5
		public MissingMethodException() : base(SR.Arg_MissingMethodException)
		{
			base.HResult = -2146233069;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x0004CBBD File Offset: 0x0004ADBD
		[NullableContext(2)]
		public MissingMethodException(string message) : base(message ?? SR.Arg_MissingMethodException)
		{
			base.HResult = -2146233069;
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0004CBDA File Offset: 0x0004ADDA
		[NullableContext(2)]
		public MissingMethodException(string message, Exception inner) : base(message ?? SR.Arg_MissingMethodException, inner)
		{
			base.HResult = -2146233069;
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0004CBF8 File Offset: 0x0004ADF8
		[NullableContext(2)]
		public MissingMethodException(string className, string methodName)
		{
			this.ClassName = className;
			this.MemberName = methodName;
			base.HResult = -2146233069;
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x0004CA1B File Offset: 0x0004AC1B
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MissingMethodException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x0004CC19 File Offset: 0x0004AE19
		public override string Message
		{
			get
			{
				if (this.ClassName != null)
				{
					return SR.Format(SR.MissingMethod_Name, this.ClassName, this.MemberName);
				}
				return base.Message;
			}
		}
	}
}

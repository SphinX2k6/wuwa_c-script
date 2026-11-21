using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200016F RID: 367
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class MissingFieldException : MissingMemberException, ISerializable
	{
		// Token: 0x06001886 RID: 6278 RVA: 0x0004C9A7 File Offset: 0x0004ABA7
		public MissingFieldException() : base(SR.Arg_MissingFieldException)
		{
			base.HResult = -2146233071;
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x0004C9BF File Offset: 0x0004ABBF
		[NullableContext(2)]
		public MissingFieldException(string message) : base(message ?? SR.Arg_MissingFieldException)
		{
			base.HResult = -2146233071;
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0004C9DC File Offset: 0x0004ABDC
		[NullableContext(2)]
		public MissingFieldException(string message, Exception inner) : base(message ?? SR.Arg_MissingFieldException, inner)
		{
			base.HResult = -2146233071;
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x0004C9FA File Offset: 0x0004ABFA
		[NullableContext(2)]
		public MissingFieldException(string className, string fieldName)
		{
			this.ClassName = className;
			this.MemberName = fieldName;
			base.HResult = -2146233071;
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0004CA1B File Offset: 0x0004AC1B
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MissingFieldException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x0004CA25 File Offset: 0x0004AC25
		public override string Message
		{
			get
			{
				if (this.ClassName == null)
				{
					return base.Message;
				}
				return SR.Format(SR.MissingField_Name, this.ClassName, this.MemberName);
			}
		}
	}
}

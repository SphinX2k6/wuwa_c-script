using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000170 RID: 368
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class MissingMemberException : MemberAccessException
	{
		// Token: 0x0600188C RID: 6284 RVA: 0x0004CA4C File Offset: 0x0004AC4C
		public MissingMemberException() : base(SR.Arg_MissingMemberException)
		{
			base.HResult = -2146233070;
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0004CA64 File Offset: 0x0004AC64
		public MissingMemberException(string message) : base(message ?? SR.Arg_MissingMemberException)
		{
			base.HResult = -2146233070;
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x0004CA81 File Offset: 0x0004AC81
		public MissingMemberException(string message, Exception inner) : base(message ?? SR.Arg_MissingMemberException, inner)
		{
			base.HResult = -2146233070;
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0004CA9F File Offset: 0x0004AC9F
		public MissingMemberException(string className, string memberName)
		{
			this.ClassName = className;
			this.MemberName = memberName;
			base.HResult = -2146233070;
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0004CAC0 File Offset: 0x0004ACC0
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected MissingMemberException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.ClassName = info.GetString("MMClassName");
			this.MemberName = info.GetString("MMMemberName");
			this.Signature = (byte[])info.GetValue("MMSignature", typeof(byte[]));
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0004CB18 File Offset: 0x0004AD18
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("MMClassName", this.ClassName, typeof(string));
			info.AddValue("MMMemberName", this.MemberName, typeof(string));
			info.AddValue("MMSignature", this.Signature, typeof(byte[]));
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x0004CB7E File Offset: 0x0004AD7E
		[Nullable(1)]
		public override string Message
		{
			[NullableContext(1)]
			get
			{
				if (this.ClassName == null)
				{
					return base.Message;
				}
				return SR.Format(SR.MissingMember_Name, this.ClassName, this.MemberName);
			}
		}

		// Token: 0x04000511 RID: 1297
		protected string ClassName;

		// Token: 0x04000512 RID: 1298
		protected string MemberName;

		// Token: 0x04000513 RID: 1299
		protected byte[] Signature;
	}
}

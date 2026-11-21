using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000174 RID: 372
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class NotFiniteNumberException : ArithmeticException
	{
		// Token: 0x0600189E RID: 6302 RVA: 0x0004CC93 File Offset: 0x0004AE93
		public NotFiniteNumberException() : base(SR.Arg_NotFiniteNumberException)
		{
			this._offendingNumber = 0.0;
			base.HResult = -2146233048;
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0004CCBA File Offset: 0x0004AEBA
		public NotFiniteNumberException(double offendingNumber)
		{
			this._offendingNumber = offendingNumber;
			base.HResult = -2146233048;
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0004CCD4 File Offset: 0x0004AED4
		public NotFiniteNumberException(string message) : base(message ?? SR.Arg_NotFiniteNumberException)
		{
			this._offendingNumber = 0.0;
			base.HResult = -2146233048;
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0004CD00 File Offset: 0x0004AF00
		public NotFiniteNumberException(string message, double offendingNumber) : base(message ?? SR.Arg_NotFiniteNumberException)
		{
			this._offendingNumber = offendingNumber;
			base.HResult = -2146233048;
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0004CD24 File Offset: 0x0004AF24
		public NotFiniteNumberException(string message, Exception innerException) : base(message ?? SR.Arg_NotFiniteNumberException, innerException)
		{
			base.HResult = -2146233048;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0004CD42 File Offset: 0x0004AF42
		public NotFiniteNumberException(string message, double offendingNumber, Exception innerException) : base(message ?? SR.Arg_NotFiniteNumberException, innerException)
		{
			this._offendingNumber = offendingNumber;
			base.HResult = -2146233048;
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0004CD67 File Offset: 0x0004AF67
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected NotFiniteNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._offendingNumber = info.GetDouble("OffendingNumber");
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0004CD82 File Offset: 0x0004AF82
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("OffendingNumber", this._offendingNumber, typeof(double));
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x0004CDAC File Offset: 0x0004AFAC
		public double OffendingNumber
		{
			get
			{
				return this._offendingNumber;
			}
		}

		// Token: 0x04000514 RID: 1300
		private readonly double _offendingNumber;
	}
}

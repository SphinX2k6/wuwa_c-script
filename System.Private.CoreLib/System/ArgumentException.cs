using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000CC RID: 204
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ArgumentException : SystemException
	{
		// Token: 0x060009CA RID: 2506 RVA: 0x0001E3D9 File Offset: 0x0001C5D9
		public ArgumentException() : base(SR.Arg_ArgumentException)
		{
			base.HResult = -2147024809;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0001E3F1 File Offset: 0x0001C5F1
		public ArgumentException(string message) : base(message)
		{
			base.HResult = -2147024809;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0001E405 File Offset: 0x0001C605
		public ArgumentException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024809;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0001E41A File Offset: 0x0001C61A
		public ArgumentException(string message, string paramName, Exception innerException) : base(message, innerException)
		{
			this._paramName = paramName;
			base.HResult = -2147024809;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0001E436 File Offset: 0x0001C636
		public ArgumentException(string message, string paramName) : base(message)
		{
			this._paramName = paramName;
			base.HResult = -2147024809;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0001E451 File Offset: 0x0001C651
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._paramName = info.GetString("ParamName");
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0001E46C File Offset: 0x0001C66C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("ParamName", this._paramName, typeof(string));
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0001E494 File Offset: 0x0001C694
		[Nullable(1)]
		public override string Message
		{
			[NullableContext(1)]
			get
			{
				this.SetMessageField();
				string text = base.Message;
				if (!string.IsNullOrEmpty(this._paramName))
				{
					text = text + " " + SR.Format(SR.Arg_ParamName_Name, this._paramName);
				}
				return text;
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0001E4D8 File Offset: 0x0001C6D8
		private void SetMessageField()
		{
			if (this._message == null && base.HResult == -2147024809)
			{
				this._message = SR.Arg_ArgumentException;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0001E4FA File Offset: 0x0001C6FA
		public virtual string ParamName
		{
			get
			{
				return this._paramName;
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0001E502 File Offset: 0x0001C702
		public static void ThrowIfNullOrEmpty([NotNull] string argument, [CallerArgumentExpression("argument")] string paramName = null)
		{
			if (string.IsNullOrEmpty(argument))
			{
				ArgumentException.ThrowNullOrEmptyException(argument, paramName);
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0001E513 File Offset: 0x0001C713
		public static void ThrowIfNullOrWhiteSpace([NotNull] string argument, [CallerArgumentExpression("argument")] string paramName = null)
		{
			if (string.IsNullOrWhiteSpace(argument))
			{
				ArgumentException.ThrowNullOrWhiteSpaceException(argument, paramName);
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0001E524 File Offset: 0x0001C724
		[DoesNotReturn]
		private static void ThrowNullOrEmptyException(string argument, string paramName)
		{
			ArgumentNullException.ThrowIfNull(argument, paramName);
			throw new ArgumentException(SR.Argument_EmptyString, paramName);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0001E538 File Offset: 0x0001C738
		[DoesNotReturn]
		private static void ThrowNullOrWhiteSpaceException(string argument, string paramName)
		{
			ArgumentNullException.ThrowIfNull(argument, paramName);
			throw new ArgumentException(SR.Argument_EmptyOrWhiteSpaceString, paramName);
		}

		// Token: 0x040002D7 RID: 727
		private readonly string _paramName;
	}
}

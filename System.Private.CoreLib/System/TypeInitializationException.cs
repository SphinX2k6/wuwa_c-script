using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001E5 RID: 485
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class TypeInitializationException : SystemException
	{
		// Token: 0x060024A2 RID: 9378 RVA: 0x00071DC8 File Offset: 0x0006FFC8
		[NullableContext(2)]
		public TypeInitializationException(string fullTypeName, Exception innerException) : this(fullTypeName, SR.Format(SR.TypeInitialization_Type, fullTypeName), innerException)
		{
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x00071DDD File Offset: 0x0006FFDD
		internal TypeInitializationException(string message) : base(message ?? SR.TypeInitialization_Default)
		{
			base.HResult = -2146233036;
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x00071DFA File Offset: 0x0006FFFA
		internal TypeInitializationException(string fullTypeName, string message, Exception innerException) : base(message ?? SR.TypeInitialization_Default, innerException)
		{
			this._typeName = fullTypeName;
			base.HResult = -2146233036;
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00071E1F File Offset: 0x0007001F
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private TypeInitializationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._typeName = info.GetString("TypeName");
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x00071E3A File Offset: 0x0007003A
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("TypeName", this.TypeName, typeof(string));
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x00071E5F File Offset: 0x0007005F
		public string TypeName
		{
			get
			{
				return this._typeName ?? string.Empty;
			}
		}

		// Token: 0x040006E1 RID: 1761
		private readonly string _typeName;
	}
}

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Globalization
{
	// Token: 0x020002DA RID: 730
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class CultureNotFoundException : ArgumentException
	{
		// Token: 0x060035EE RID: 13806 RVA: 0x000AF6E5 File Offset: 0x000AD8E5
		public CultureNotFoundException() : base(CultureNotFoundException.DefaultMessage)
		{
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x000AF6F2 File Offset: 0x000AD8F2
		public CultureNotFoundException(string message) : base(message ?? CultureNotFoundException.DefaultMessage)
		{
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x000AF704 File Offset: 0x000AD904
		public CultureNotFoundException(string paramName, string message) : base(message ?? CultureNotFoundException.DefaultMessage, paramName)
		{
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x000AF717 File Offset: 0x000AD917
		public CultureNotFoundException(string message, Exception innerException) : base(message ?? CultureNotFoundException.DefaultMessage, innerException)
		{
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x000AF72A File Offset: 0x000AD92A
		public CultureNotFoundException(string paramName, string invalidCultureName, string message) : base(message ?? CultureNotFoundException.DefaultMessage, paramName)
		{
			this._invalidCultureName = invalidCultureName;
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x000AF744 File Offset: 0x000AD944
		public CultureNotFoundException(string message, string invalidCultureName, Exception innerException) : base(message ?? CultureNotFoundException.DefaultMessage, innerException)
		{
			this._invalidCultureName = invalidCultureName;
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x000AF75E File Offset: 0x000AD95E
		public CultureNotFoundException(string message, int invalidCultureId, Exception innerException) : base(message ?? CultureNotFoundException.DefaultMessage, innerException)
		{
			this._invalidCultureId = new int?(invalidCultureId);
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x000AF77D File Offset: 0x000AD97D
		public CultureNotFoundException(string paramName, int invalidCultureId, string message) : base(message ?? CultureNotFoundException.DefaultMessage, paramName)
		{
			this._invalidCultureId = new int?(invalidCultureId);
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x000AF79C File Offset: 0x000AD99C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CultureNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._invalidCultureId = (int?)info.GetValue("InvalidCultureId", typeof(int?));
			this._invalidCultureName = (string)info.GetValue("InvalidCultureName", typeof(string));
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x000AF7F4 File Offset: 0x000AD9F4
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("InvalidCultureId", this._invalidCultureId, typeof(int?));
			info.AddValue("InvalidCultureName", this._invalidCultureName, typeof(string));
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060035F8 RID: 13816 RVA: 0x000AF844 File Offset: 0x000ADA44
		public virtual int? InvalidCultureId
		{
			get
			{
				return this._invalidCultureId;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x060035F9 RID: 13817 RVA: 0x000AF84C File Offset: 0x000ADA4C
		public virtual string InvalidCultureName
		{
			get
			{
				return this._invalidCultureName;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060035FA RID: 13818 RVA: 0x000AF854 File Offset: 0x000ADA54
		[Nullable(1)]
		private static string DefaultMessage
		{
			get
			{
				return SR.Argument_CultureNotSupported;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060035FB RID: 13819 RVA: 0x000AF85C File Offset: 0x000ADA5C
		private string FormattedInvalidCultureId
		{
			get
			{
				if (this.InvalidCultureId == null)
				{
					return this.InvalidCultureName;
				}
				return string.Format(CultureInfo.InvariantCulture, "{0} (0x{0:x4})", this.InvalidCultureId.Value);
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060035FC RID: 13820 RVA: 0x000AF8A4 File Offset: 0x000ADAA4
		[Nullable(1)]
		public override string Message
		{
			[NullableContext(1)]
			get
			{
				string message = base.Message;
				if (this._invalidCultureId == null && this._invalidCultureName == null)
				{
					return message;
				}
				string text = SR.Format(SR.Argument_CultureInvalidIdentifier, this.FormattedInvalidCultureId);
				if (message == null)
				{
					return text;
				}
				return message + "\r\n" + text;
			}
		}

		// Token: 0x040009FD RID: 2557
		private readonly string _invalidCultureName;

		// Token: 0x040009FE RID: 2558
		private readonly int? _invalidCultureId;
	}
}

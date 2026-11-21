using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006D0 RID: 1744
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("System.Runtime.Extensions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[Serializable]
	public sealed class SwitchExpressionException : InvalidOperationException
	{
		// Token: 0x06007492 RID: 29842 RVA: 0x001159DA File Offset: 0x00113BDA
		public SwitchExpressionException() : base(SR.Arg_SwitchExpressionException)
		{
		}

		// Token: 0x06007493 RID: 29843 RVA: 0x001159E7 File Offset: 0x00113BE7
		public SwitchExpressionException(Exception innerException) : base(SR.Arg_SwitchExpressionException, innerException)
		{
		}

		// Token: 0x06007494 RID: 29844 RVA: 0x001159F5 File Offset: 0x00113BF5
		public SwitchExpressionException(object unmatchedValue) : this()
		{
			this.UnmatchedValue = unmatchedValue;
		}

		// Token: 0x06007495 RID: 29845 RVA: 0x00115A04 File Offset: 0x00113C04
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private SwitchExpressionException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.UnmatchedValue = info.GetValue("UnmatchedValue", typeof(object));
		}

		// Token: 0x06007496 RID: 29846 RVA: 0x00115A29 File Offset: 0x00113C29
		public SwitchExpressionException(string message) : base(message ?? SR.Arg_SwitchExpressionException)
		{
		}

		// Token: 0x06007497 RID: 29847 RVA: 0x00115A3B File Offset: 0x00113C3B
		public SwitchExpressionException(string message, Exception innerException) : base(message ?? SR.Arg_SwitchExpressionException, innerException)
		{
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06007498 RID: 29848 RVA: 0x00115A4E File Offset: 0x00113C4E
		public object UnmatchedValue { get; }

		// Token: 0x06007499 RID: 29849 RVA: 0x00115A56 File Offset: 0x00113C56
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("UnmatchedValue", this.UnmatchedValue, typeof(object));
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x0600749A RID: 29850 RVA: 0x00115A7C File Offset: 0x00113C7C
		[Nullable(1)]
		public override string Message
		{
			[NullableContext(1)]
			get
			{
				if (this.UnmatchedValue == null)
				{
					return base.Message;
				}
				string str = SR.Format(SR.SwitchExpressionException_UnmatchedValue, this.UnmatchedValue);
				return base.Message + "\r\n" + str;
			}
		}
	}
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
	// Token: 0x0200052A RID: 1322
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct StreamingContext
	{
		// Token: 0x060048E4 RID: 18660 RVA: 0x000F1F2E File Offset: 0x000F012E
		[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public StreamingContext(StreamingContextStates state)
		{
			this = new StreamingContext(state, null);
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x000F1F38 File Offset: 0x000F0138
		[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public StreamingContext(StreamingContextStates state, object additional)
		{
			this._state = state;
			this._additionalContext = additional;
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x000F1F48 File Offset: 0x000F0148
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is StreamingContext)
			{
				StreamingContext streamingContext = (StreamingContext)obj;
				return streamingContext._additionalContext == this._additionalContext && streamingContext._state == this._state;
			}
			return false;
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x000F1F84 File Offset: 0x000F0184
		public override int GetHashCode()
		{
			return (int)this._state;
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x060048E8 RID: 18664 RVA: 0x000F1F84 File Offset: 0x000F0184
		[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public StreamingContextStates State
		{
			get
			{
				return this._state;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x060048E9 RID: 18665 RVA: 0x000F1F8C File Offset: 0x000F018C
		public object Context
		{
			get
			{
				return this._additionalContext;
			}
		}

		// Token: 0x04001172 RID: 4466
		private readonly object _additionalContext;

		// Token: 0x04001173 RID: 4467
		[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private readonly StreamingContextStates _state;
	}
}

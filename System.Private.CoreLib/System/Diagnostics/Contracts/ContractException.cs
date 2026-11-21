using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Diagnostics.Contracts
{
	// Token: 0x02000893 RID: 2195
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class ContractException : Exception
	{
		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06008993 RID: 35219 RVA: 0x0014E350 File Offset: 0x0014C550
		public ContractFailureKind Kind
		{
			get
			{
				return this._kind;
			}
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06008994 RID: 35220 RVA: 0x0014E358 File Offset: 0x0014C558
		[Nullable(1)]
		public string Failure
		{
			[NullableContext(1)]
			get
			{
				return this.Message;
			}
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06008995 RID: 35221 RVA: 0x0014E360 File Offset: 0x0014C560
		public string UserMessage
		{
			get
			{
				return this._userMessage;
			}
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06008996 RID: 35222 RVA: 0x0014E368 File Offset: 0x0014C568
		public string Condition
		{
			get
			{
				return this._condition;
			}
		}

		// Token: 0x06008997 RID: 35223 RVA: 0x0014E370 File Offset: 0x0014C570
		public ContractException(ContractFailureKind kind, string failure, string userMessage, string condition, Exception innerException) : base(failure, innerException)
		{
			base.HResult = -2146233022;
			this._kind = kind;
			this._userMessage = userMessage;
			this._condition = condition;
		}

		// Token: 0x06008998 RID: 35224 RVA: 0x0014E39C File Offset: 0x0014C59C
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private ContractException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._kind = (ContractFailureKind)info.GetInt32("Kind");
			this._userMessage = info.GetString("UserMessage");
			this._condition = info.GetString("Condition");
		}

		// Token: 0x06008999 RID: 35225 RVA: 0x0014E3DC File Offset: 0x0014C5DC
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("Kind", this._kind);
			info.AddValue("UserMessage", this._userMessage);
			info.AddValue("Condition", this._condition);
		}

		// Token: 0x04001E4C RID: 7756
		private readonly ContractFailureKind _kind;

		// Token: 0x04001E4D RID: 7757
		private readonly string _userMessage;

		// Token: 0x04001E4E RID: 7758
		private readonly string _condition;
	}
}

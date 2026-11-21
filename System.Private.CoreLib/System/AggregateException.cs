using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;
using System.Text;

namespace System
{
	// Token: 0x020000C4 RID: 196
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("Count = {InnerExceptionCount}")]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class AggregateException : Exception
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x0001CD6B File Offset: 0x0001AF6B
		public AggregateException() : this(SR.AggregateException_ctor_DefaultMessage)
		{
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0001CD78 File Offset: 0x0001AF78
		[NullableContext(2)]
		public AggregateException(string message) : base(message ?? SR.AggregateException_ctor_DefaultMessage)
		{
			this._innerExceptions = Array.Empty<Exception>();
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0001CD95 File Offset: 0x0001AF95
		public AggregateException([Nullable(2)] string message, Exception innerException) : base(message ?? SR.AggregateException_ctor_DefaultMessage, innerException)
		{
			ArgumentNullException.ThrowIfNull(innerException, "innerException");
			this._innerExceptions = new Exception[]
			{
				innerException
			};
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0001CDC3 File Offset: 0x0001AFC3
		public AggregateException(IEnumerable<Exception> innerExceptions)
		{
			string aggregateException_ctor_DefaultMessage = SR.AggregateException_ctor_DefaultMessage;
			if (innerExceptions == null)
			{
				throw new ArgumentNullException("innerExceptions");
			}
			this..ctor(aggregateException_ctor_DefaultMessage, innerExceptions);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0001CDE0 File Offset: 0x0001AFE0
		public AggregateException(params Exception[] innerExceptions)
		{
			string aggregateException_ctor_DefaultMessage = SR.AggregateException_ctor_DefaultMessage;
			if (innerExceptions == null)
			{
				throw new ArgumentNullException("innerExceptions");
			}
			this..ctor(aggregateException_ctor_DefaultMessage, innerExceptions);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0001CDFD File Offset: 0x0001AFFD
		public AggregateException([Nullable(2)] string message, IEnumerable<Exception> innerExceptions)
		{
			if (innerExceptions == null)
			{
				throw new ArgumentNullException("innerExceptions");
			}
			this..ctor(message, new List<Exception>(innerExceptions).ToArray(), false);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0001CE21 File Offset: 0x0001B021
		public AggregateException([Nullable(2)] string message, params Exception[] innerExceptions)
		{
			if (innerExceptions == null)
			{
				throw new ArgumentNullException("innerExceptions");
			}
			this..ctor(message, innerExceptions, true);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0001CE3C File Offset: 0x0001B03C
		private AggregateException(string message, Exception[] innerExceptions, bool cloneExceptions) : base(message ?? SR.AggregateException_ctor_DefaultMessage, (innerExceptions.Length != 0) ? innerExceptions[0] : null)
		{
			this._innerExceptions = (cloneExceptions ? new Exception[innerExceptions.Length] : innerExceptions);
			for (int i = 0; i < this._innerExceptions.Length; i++)
			{
				this._innerExceptions[i] = innerExceptions[i];
				if (innerExceptions[i] == null)
				{
					throw new ArgumentException(SR.AggregateException_ctor_InnerExceptionNull);
				}
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0001CEA5 File Offset: 0x0001B0A5
		internal AggregateException(List<ExceptionDispatchInfo> innerExceptionInfos) : this(SR.AggregateException_ctor_DefaultMessage, innerExceptionInfos)
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0001CEB4 File Offset: 0x0001B0B4
		internal AggregateException(string message, List<ExceptionDispatchInfo> innerExceptionInfos) : base(message, (innerExceptionInfos.Count != 0) ? innerExceptionInfos[0].SourceException : null)
		{
			this._innerExceptions = new Exception[innerExceptionInfos.Count];
			for (int i = 0; i < this._innerExceptions.Length; i++)
			{
				this._innerExceptions[i] = innerExceptionInfos[i].SourceException;
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0001CF17 File Offset: 0x0001B117
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected AggregateException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			Exception[] array = info.GetValue("InnerExceptions", typeof(Exception[])) as Exception[];
			if (array == null)
			{
				throw new SerializationException(SR.AggregateException_DeserializationFailure);
			}
			this._innerExceptions = array;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0001CF50 File Offset: 0x0001B150
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("InnerExceptions", this._innerExceptions, typeof(Exception[]));
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0001CF78 File Offset: 0x0001B178
		public override Exception GetBaseException()
		{
			Exception ex = this;
			AggregateException ex2 = this;
			while (ex2 != null && ex2.InnerExceptions.Count == 1)
			{
				ex = ex.InnerException;
				ex2 = (ex as AggregateException);
			}
			return ex;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x0001CFAC File Offset: 0x0001B1AC
		public ReadOnlyCollection<Exception> InnerExceptions
		{
			get
			{
				ReadOnlyCollection<Exception> result;
				if ((result = this._rocView) == null)
				{
					result = (this._rocView = new ReadOnlyCollection<Exception>(this._innerExceptions));
				}
				return result;
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0001CFD8 File Offset: 0x0001B1D8
		public void Handle(Func<Exception, bool> predicate)
		{
			ArgumentNullException.ThrowIfNull(predicate, "predicate");
			List<Exception> list = null;
			for (int i = 0; i < this._innerExceptions.Length; i++)
			{
				if (!predicate(this._innerExceptions[i]))
				{
					if (list == null)
					{
						list = new List<Exception>();
					}
					list.Add(this._innerExceptions[i]);
				}
			}
			if (list != null)
			{
				throw new AggregateException(this.Message, list.ToArray(), false);
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0001D044 File Offset: 0x0001B244
		public AggregateException Flatten()
		{
			List<Exception> list = new List<Exception>();
			List<AggregateException> list2 = new List<AggregateException>
			{
				this
			};
			int num = 0;
			while (list2.Count > num)
			{
				ReadOnlyCollection<Exception> innerExceptions = list2[num++].InnerExceptions;
				for (int i = 0; i < innerExceptions.Count; i++)
				{
					Exception ex = innerExceptions[i];
					if (ex != null)
					{
						AggregateException ex2 = ex as AggregateException;
						if (ex2 != null)
						{
							list2.Add(ex2);
						}
						else
						{
							list.Add(ex);
						}
					}
				}
			}
			return new AggregateException((base.GetType() == typeof(AggregateException)) ? base.Message : this.Message, list.ToArray(), false);
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
		public unsafe override string Message
		{
			get
			{
				if (this._innerExceptions.Length == 0)
				{
					return base.Message;
				}
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
				ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
				valueStringBuilder.Append(base.Message);
				valueStringBuilder.Append(' ');
				for (int i = 0; i < this._innerExceptions.Length; i++)
				{
					valueStringBuilder.Append('(');
					valueStringBuilder.Append(this._innerExceptions[i].Message);
					valueStringBuilder.Append(") ");
				}
				int length = valueStringBuilder.Length;
				valueStringBuilder.Length = length - 1;
				return valueStringBuilder.ToString();
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0001D1A0 File Offset: 0x0001B3A0
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(base.ToString());
			for (int i = 0; i < this._innerExceptions.Length; i++)
			{
				if (this._innerExceptions[i] != base.InnerException)
				{
					stringBuilder.Append("\r\n ---> ");
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, SR.AggregateException_InnerException, i);
					stringBuilder.Append(this._innerExceptions[i].ToString());
					stringBuilder.Append("<---");
					stringBuilder.AppendLine();
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x0001D233 File Offset: 0x0001B433
		internal int InnerExceptionCount
		{
			get
			{
				return this._innerExceptions.Length;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0001D23D File Offset: 0x0001B43D
		internal Exception[] InternalInnerExceptions
		{
			get
			{
				return this._innerExceptions;
			}
		}

		// Token: 0x040002C3 RID: 707
		private readonly Exception[] _innerExceptions;

		// Token: 0x040002C4 RID: 708
		private ReadOnlyCollection<Exception> _rocView;
	}
}

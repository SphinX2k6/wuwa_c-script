using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace System.Reflection
{
	// Token: 0x02000773 RID: 1907
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class ReflectionTypeLoadException : SystemException
	{
		// Token: 0x06007A22 RID: 31266 RVA: 0x001217E7 File Offset: 0x0011F9E7
		[NullableContext(2)]
		public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions) : this(classes, exceptions, null)
		{
		}

		// Token: 0x06007A23 RID: 31267 RVA: 0x001217F2 File Offset: 0x0011F9F2
		[NullableContext(2)]
		public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions, string message) : base(message)
		{
			this.Types = (classes ?? Type.EmptyTypes);
			this.LoaderExceptions = (exceptions ?? Array.Empty<Exception>());
			base.HResult = -2146232830;
		}

		// Token: 0x06007A24 RID: 31268 RVA: 0x00121826 File Offset: 0x0011FA26
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private ReflectionTypeLoadException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.Types = Type.EmptyTypes;
			this.LoaderExceptions = (((Exception[])info.GetValue("Exceptions", typeof(Exception[]))) ?? Array.Empty<Exception>());
		}

		// Token: 0x06007A25 RID: 31269 RVA: 0x00121864 File Offset: 0x0011FA64
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("Types", null, typeof(Type[]));
			info.AddValue("Exceptions", this.LoaderExceptions, typeof(Exception[]));
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06007A26 RID: 31270 RVA: 0x0012189F File Offset: 0x0011FA9F
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public Type[] Types { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; }

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06007A27 RID: 31271 RVA: 0x001218A7 File Offset: 0x0011FAA7
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public Exception[] LoaderExceptions { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; }

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06007A28 RID: 31272 RVA: 0x001218AF File Offset: 0x0011FAAF
		public override string Message
		{
			get
			{
				return this.CreateString(true);
			}
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x001218B8 File Offset: 0x0011FAB8
		public override string ToString()
		{
			return this.CreateString(false);
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x001218C4 File Offset: 0x0011FAC4
		private string CreateString(bool isMessage)
		{
			string text = isMessage ? base.Message : base.ToString();
			Exception[] loaderExceptions = this.LoaderExceptions;
			if (loaderExceptions.Length == 0)
			{
				return text;
			}
			StringBuilder stringBuilder = new StringBuilder(text);
			foreach (Exception ex in loaderExceptions)
			{
				if (ex != null)
				{
					stringBuilder.AppendLine().Append(isMessage ? ex.Message : ex.ToString());
				}
			}
			return stringBuilder.ToString();
		}
	}
}

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x020009E4 RID: 2532
	[Serializable]
	public class NonRandomizedStringEqualityComparer : IEqualityComparer<string>, IInternalStringEqualityComparer, ISerializable
	{
		// Token: 0x060093EA RID: 37866 RVA: 0x001711F6 File Offset: 0x0016F3F6
		private NonRandomizedStringEqualityComparer(IEqualityComparer<string> underlyingComparer)
		{
			this._underlyingComparer = underlyingComparer;
		}

		// Token: 0x060093EB RID: 37867 RVA: 0x00171205 File Offset: 0x0016F405
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected NonRandomizedStringEqualityComparer(SerializationInfo information, StreamingContext context) : this(EqualityComparer<string>.Default)
		{
		}

		// Token: 0x060093EC RID: 37868 RVA: 0x000666FD File Offset: 0x000648FD
		[NullableContext(2)]
		public virtual bool Equals(string x, string y)
		{
			return string.Equals(x, y);
		}

		// Token: 0x060093ED RID: 37869 RVA: 0x00171212 File Offset: 0x0016F412
		[NullableContext(2)]
		public virtual int GetHashCode(string obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.GetNonRandomizedHashCode();
		}

		// Token: 0x060093EE RID: 37870 RVA: 0x0017121F File Offset: 0x0016F41F
		internal virtual RandomizedStringEqualityComparer GetRandomizedEqualityComparer()
		{
			return RandomizedStringEqualityComparer.Create(this._underlyingComparer, false);
		}

		// Token: 0x060093EF RID: 37871 RVA: 0x0017122D File Offset: 0x0016F42D
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public virtual IEqualityComparer<string> GetUnderlyingEqualityComparer()
		{
			return this._underlyingComparer;
		}

		// Token: 0x060093F0 RID: 37872 RVA: 0x0016D714 File Offset: 0x0016B914
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.SetType(typeof(GenericEqualityComparer<string>));
		}

		// Token: 0x060093F1 RID: 37873 RVA: 0x00171235 File Offset: 0x0016F435
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static IEqualityComparer<string> GetStringComparer(object comparer)
		{
			if (comparer == EqualityComparer<string>.Default)
			{
				return NonRandomizedStringEqualityComparer.WrappedAroundDefaultComparer;
			}
			if (comparer == StringComparer.Ordinal)
			{
				return NonRandomizedStringEqualityComparer.WrappedAroundStringComparerOrdinal;
			}
			if (comparer == StringComparer.OrdinalIgnoreCase)
			{
				return NonRandomizedStringEqualityComparer.WrappedAroundStringComparerOrdinalIgnoreCase;
			}
			return null;
		}

		// Token: 0x040022B3 RID: 8883
		private static readonly NonRandomizedStringEqualityComparer WrappedAroundDefaultComparer = new NonRandomizedStringEqualityComparer.OrdinalComparer(EqualityComparer<string>.Default);

		// Token: 0x040022B4 RID: 8884
		private static readonly NonRandomizedStringEqualityComparer WrappedAroundStringComparerOrdinal = new NonRandomizedStringEqualityComparer.OrdinalComparer(StringComparer.Ordinal);

		// Token: 0x040022B5 RID: 8885
		private static readonly NonRandomizedStringEqualityComparer WrappedAroundStringComparerOrdinalIgnoreCase = new NonRandomizedStringEqualityComparer.OrdinalIgnoreCaseComparer(StringComparer.OrdinalIgnoreCase);

		// Token: 0x040022B6 RID: 8886
		private readonly IEqualityComparer<string> _underlyingComparer;

		// Token: 0x020009E5 RID: 2533
		private sealed class OrdinalComparer : NonRandomizedStringEqualityComparer, IAlternateEqualityComparer<ReadOnlySpan<char>, string>
		{
			// Token: 0x060093F3 RID: 37875 RVA: 0x00171291 File Offset: 0x0016F491
			internal OrdinalComparer(IEqualityComparer<string> wrappedComparer) : base(wrappedComparer)
			{
			}

			// Token: 0x060093F4 RID: 37876 RVA: 0x000666FD File Offset: 0x000648FD
			public override bool Equals(string x, string y)
			{
				return string.Equals(x, y);
			}

			// Token: 0x060093F5 RID: 37877 RVA: 0x0017129A File Offset: 0x0016F49A
			public override int GetHashCode(string obj)
			{
				return obj.GetNonRandomizedHashCode();
			}

			// Token: 0x060093F6 RID: 37878 RVA: 0x001712A2 File Offset: 0x0016F4A2
			int IAlternateEqualityComparer<ReadOnlySpan<char>, string>.GetHashCode(ReadOnlySpan<char> span)
			{
				return string.GetNonRandomizedHashCode(span);
			}

			// Token: 0x060093F7 RID: 37879 RVA: 0x00066717 File Offset: 0x00064917
			bool IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Equals(ReadOnlySpan<char> span, string target)
			{
				return (!span.IsEmpty || target != null) && span.SequenceEqual(target);
			}

			// Token: 0x060093F8 RID: 37880 RVA: 0x000664B5 File Offset: 0x000646B5
			string IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Create(ReadOnlySpan<char> span)
			{
				return span.ToString();
			}
		}

		// Token: 0x020009E6 RID: 2534
		private sealed class OrdinalIgnoreCaseComparer : NonRandomizedStringEqualityComparer, IAlternateEqualityComparer<ReadOnlySpan<char>, string>
		{
			// Token: 0x060093F9 RID: 37881 RVA: 0x00171291 File Offset: 0x0016F491
			internal OrdinalIgnoreCaseComparer(IEqualityComparer<string> wrappedComparer) : base(wrappedComparer)
			{
			}

			// Token: 0x060093FA RID: 37882 RVA: 0x0017117A File Offset: 0x0016F37A
			public override bool Equals(string x, string y)
			{
				return string.EqualsOrdinalIgnoreCase(x, y);
			}

			// Token: 0x060093FB RID: 37883 RVA: 0x001712AA File Offset: 0x0016F4AA
			public override int GetHashCode(string obj)
			{
				return obj.GetNonRandomizedHashCodeOrdinalIgnoreCase();
			}

			// Token: 0x060093FC RID: 37884 RVA: 0x001712B2 File Offset: 0x0016F4B2
			int IAlternateEqualityComparer<ReadOnlySpan<char>, string>.GetHashCode(ReadOnlySpan<char> span)
			{
				return string.GetNonRandomizedHashCodeOrdinalIgnoreCase(span);
			}

			// Token: 0x060093FD RID: 37885 RVA: 0x000667E5 File Offset: 0x000649E5
			bool IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Equals(ReadOnlySpan<char> span, string target)
			{
				return (!span.IsEmpty || target != null) && span.EqualsOrdinalIgnoreCase(target);
			}

			// Token: 0x060093FE RID: 37886 RVA: 0x000664B5 File Offset: 0x000646B5
			string IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Create(ReadOnlySpan<char> span)
			{
				return span.ToString();
			}

			// Token: 0x060093FF RID: 37887 RVA: 0x001712BA File Offset: 0x0016F4BA
			internal override RandomizedStringEqualityComparer GetRandomizedEqualityComparer()
			{
				return RandomizedStringEqualityComparer.Create(this._underlyingComparer, true);
			}
		}
	}
}

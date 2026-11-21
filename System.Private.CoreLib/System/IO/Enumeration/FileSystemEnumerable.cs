using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.IO.Enumeration
{
	// Token: 0x02000869 RID: 2153
	public class FileSystemEnumerable<[Nullable(2)] TResult> : IEnumerable<!0>, IEnumerable
	{
		// Token: 0x06008884 RID: 34948 RVA: 0x0014BEE4 File Offset: 0x0014A0E4
		[NullableContext(1)]
		public FileSystemEnumerable(string directory, [Nullable(new byte[]
		{
			1,
			0
		})] FileSystemEnumerable<TResult>.FindTransform transform, [Nullable(2)] EnumerationOptions options = null) : this(directory, transform, options, false)
		{
		}

		// Token: 0x06008885 RID: 34949 RVA: 0x0014BEF0 File Offset: 0x0014A0F0
		internal FileSystemEnumerable(string directory, FileSystemEnumerable<TResult>.FindTransform transform, EnumerationOptions options, bool isNormalized)
		{
			ArgumentNullException.ThrowIfNull(directory, "directory");
			ArgumentNullException.ThrowIfNull(transform, "transform");
			this._directory = directory;
			this._transform = transform;
			this._options = (options ?? EnumerationOptions.Default);
			this._enumerator = new FileSystemEnumerable<TResult>.DelegateEnumerator(this, isNormalized);
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x06008886 RID: 34950 RVA: 0x0014BF45 File Offset: 0x0014A145
		// (set) Token: 0x06008887 RID: 34951 RVA: 0x0014BF4D File Offset: 0x0014A14D
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public FileSystemEnumerable<TResult>.FindPredicate ShouldIncludePredicate { [return: Nullable(new byte[]
		{
			2,
			0
		})] get; [param: Nullable(new byte[]
		{
			2,
			0
		})] set; }

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x06008888 RID: 34952 RVA: 0x0014BF56 File Offset: 0x0014A156
		// (set) Token: 0x06008889 RID: 34953 RVA: 0x0014BF5E File Offset: 0x0014A15E
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public FileSystemEnumerable<TResult>.FindPredicate ShouldRecursePredicate { [return: Nullable(new byte[]
		{
			2,
			0
		})] get; [param: Nullable(new byte[]
		{
			2,
			0
		})] set; }

		// Token: 0x0600888A RID: 34954 RVA: 0x0014BF67 File Offset: 0x0014A167
		[NullableContext(1)]
		public IEnumerator<TResult> GetEnumerator()
		{
			return Interlocked.Exchange<FileSystemEnumerable<TResult>.DelegateEnumerator>(ref this._enumerator, null) ?? new FileSystemEnumerable<TResult>.DelegateEnumerator(this, false);
		}

		// Token: 0x0600888B RID: 34955 RVA: 0x0014BF80 File Offset: 0x0014A180
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04001DEB RID: 7659
		private FileSystemEnumerable<TResult>.DelegateEnumerator _enumerator;

		// Token: 0x04001DEC RID: 7660
		private readonly FileSystemEnumerable<TResult>.FindTransform _transform;

		// Token: 0x04001DED RID: 7661
		private readonly EnumerationOptions _options;

		// Token: 0x04001DEE RID: 7662
		private readonly string _directory;

		// Token: 0x0200086A RID: 2154
		// (Invoke) Token: 0x0600888D RID: 34957
		public delegate bool FindPredicate(ref FileSystemEntry entry);

		// Token: 0x0200086B RID: 2155
		// (Invoke) Token: 0x06008891 RID: 34961
		public delegate TResult FindTransform(ref FileSystemEntry entry);

		// Token: 0x0200086C RID: 2156
		private sealed class DelegateEnumerator : FileSystemEnumerator<TResult>
		{
			// Token: 0x06008894 RID: 34964 RVA: 0x0014BF88 File Offset: 0x0014A188
			public DelegateEnumerator(FileSystemEnumerable<TResult> enumerable, bool isNormalized) : base(enumerable._directory, isNormalized, enumerable._options)
			{
				this._enumerable = enumerable;
			}

			// Token: 0x06008895 RID: 34965 RVA: 0x0014BFA4 File Offset: 0x0014A1A4
			protected override TResult TransformEntry(ref FileSystemEntry entry)
			{
				return this._enumerable._transform(ref entry);
			}

			// Token: 0x06008896 RID: 34966 RVA: 0x0014BFB7 File Offset: 0x0014A1B7
			protected override bool ShouldRecurseIntoEntry(ref FileSystemEntry entry)
			{
				FileSystemEnumerable<TResult>.FindPredicate shouldRecursePredicate = this._enumerable.ShouldRecursePredicate;
				return shouldRecursePredicate == null || shouldRecursePredicate(ref entry);
			}

			// Token: 0x06008897 RID: 34967 RVA: 0x0014BFD0 File Offset: 0x0014A1D0
			protected override bool ShouldIncludeEntry(ref FileSystemEntry entry)
			{
				FileSystemEnumerable<TResult>.FindPredicate shouldIncludePredicate = this._enumerable.ShouldIncludePredicate;
				return shouldIncludePredicate == null || shouldIncludePredicate(ref entry);
			}

			// Token: 0x04001DF1 RID: 7665
			private readonly FileSystemEnumerable<TResult> _enumerable;
		}
	}
}

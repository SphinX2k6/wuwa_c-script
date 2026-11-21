using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Versioning
{
	// Token: 0x02000509 RID: 1289
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class FrameworkName : IEquatable<FrameworkName>
	{
		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06004848 RID: 18504 RVA: 0x000F0AFF File Offset: 0x000EECFF
		public string Identifier
		{
			get
			{
				return this._identifier;
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06004849 RID: 18505 RVA: 0x000F0B07 File Offset: 0x000EED07
		public Version Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x0600484A RID: 18506 RVA: 0x000F0B0F File Offset: 0x000EED0F
		public string Profile
		{
			get
			{
				return this._profile;
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x0600484B RID: 18507 RVA: 0x000F0B18 File Offset: 0x000EED18
		public string FullName
		{
			get
			{
				if (this._fullName == null)
				{
					string fullName;
					if (!string.IsNullOrEmpty(this.Profile))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 5);
						defaultInterpolatedStringHandler.AppendFormatted(this.Identifier);
						defaultInterpolatedStringHandler.AppendFormatted(",Version=v");
						defaultInterpolatedStringHandler.AppendFormatted<Version>(this.Version);
						defaultInterpolatedStringHandler.AppendFormatted(",Profile=");
						defaultInterpolatedStringHandler.AppendFormatted(this.Profile);
						fullName = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 3);
						defaultInterpolatedStringHandler.AppendFormatted(this.Identifier);
						defaultInterpolatedStringHandler.AppendFormatted(",Version=v");
						defaultInterpolatedStringHandler.AppendFormatted<Version>(this.Version);
						fullName = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					this._fullName = fullName;
				}
				return this._fullName;
			}
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x000F0BD0 File Offset: 0x000EEDD0
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return this.Equals(obj as FrameworkName);
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x000F0BDE File Offset: 0x000EEDDE
		[NullableContext(2)]
		public bool Equals([NotNullWhen(true)] FrameworkName other)
		{
			return other != null && (this.Identifier == other.Identifier && this.Version == other.Version) && this.Profile == other.Profile;
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x000F0C1E File Offset: 0x000EEE1E
		public override int GetHashCode()
		{
			return this.Identifier.GetHashCode() ^ this.Version.GetHashCode() ^ this.Profile.GetHashCode();
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x000F0C43 File Offset: 0x000EEE43
		public override string ToString()
		{
			return this.FullName;
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x000F0C4B File Offset: 0x000EEE4B
		public FrameworkName(string identifier, Version version) : this(identifier, version, null)
		{
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x000F0C58 File Offset: 0x000EEE58
		public FrameworkName(string identifier, Version version, [Nullable(2)] string profile)
		{
			identifier = ((identifier != null) ? identifier.Trim() : null);
			ArgumentException.ThrowIfNullOrEmpty(identifier, "identifier");
			ArgumentNullException.ThrowIfNull(version, "version");
			this._identifier = identifier;
			this._version = version;
			this._profile = ((profile == null) ? string.Empty : profile.Trim());
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x000F0CB4 File Offset: 0x000EEEB4
		public unsafe FrameworkName(string frameworkName)
		{
			ArgumentException.ThrowIfNullOrEmpty(frameworkName, "frameworkName");
			ReadOnlySpan<char> source = frameworkName;
			Span<Range> destination = new Span<Range>(stackalloc byte[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(Range))], 4);
			int num = source.Split(destination, ',', StringSplitOptions.None);
			if (num - 2 > 1)
			{
				throw new ArgumentException(SR.Argument_FrameworkNameTooShort, "frameworkName");
			}
			destination = destination.Slice(0, num);
			Range range = *destination[0];
			int length = source.Length;
			int offset = range.Start.GetOffset(length);
			int length2 = range.End.GetOffset(length) - offset;
			this._identifier = source.Slice(offset, length2).Trim().ToString();
			if (this._identifier.Length == 0)
			{
				throw new ArgumentException(SR.Argument_FrameworkNameInvalid, "frameworkName");
			}
			bool flag = false;
			this._profile = string.Empty;
			int i = 1;
			while (i < destination.Length)
			{
				range = *destination[i];
				length2 = source.Length;
				offset = range.Start.GetOffset(length2);
				length = range.End.GetOffset(length2) - offset;
				ReadOnlySpan<char> span = source.Slice(offset, length);
				int num2 = span.IndexOf('=');
				if (num2 < 0 || num2 != span.LastIndexOf('='))
				{
					throw new ArgumentException(SR.Argument_FrameworkNameInvalid, "frameworkName");
				}
				ReadOnlySpan<char> span2 = span.Slice(0, num2).Trim();
				ReadOnlySpan<char> input = span.Slice(num2 + 1).Trim();
				if (span2.Equals("Version", StringComparison.OrdinalIgnoreCase))
				{
					flag = true;
					if (input.Length > 0 && (*input[0] == 118 || *input[0] == 86))
					{
						input = input.Slice(1);
					}
					try
					{
						this._version = Version.Parse(input);
						goto IL_245;
					}
					catch (Exception innerException)
					{
						throw new ArgumentException(SR.Argument_FrameworkNameInvalidVersion, "frameworkName", innerException);
					}
					goto IL_202;
				}
				goto IL_202;
				IL_245:
				i++;
				continue;
				IL_202:
				if (!span2.Equals("Profile", StringComparison.OrdinalIgnoreCase))
				{
					throw new ArgumentException(SR.Argument_FrameworkNameInvalid, "frameworkName");
				}
				if (input.Length > 0)
				{
					this._profile = input.ToString();
					goto IL_245;
				}
				goto IL_245;
			}
			if (!flag)
			{
				throw new ArgumentException(SR.Argument_FrameworkNameMissingVersion, "frameworkName");
			}
		}

		// Token: 0x06004853 RID: 18515 RVA: 0x000F0F40 File Offset: 0x000EF140
		[NullableContext(2)]
		public static bool operator ==(FrameworkName left, FrameworkName right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x000F0F51 File Offset: 0x000EF151
		[NullableContext(2)]
		public static bool operator !=(FrameworkName left, FrameworkName right)
		{
			return !(left == right);
		}

		// Token: 0x0400113A RID: 4410
		private readonly string _identifier;

		// Token: 0x0400113B RID: 4411
		private readonly Version _version;

		// Token: 0x0400113C RID: 4412
		private readonly string _profile;

		// Token: 0x0400113D RID: 4413
		private string _fullName;
	}
}

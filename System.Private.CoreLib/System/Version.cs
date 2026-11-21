using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020001FA RID: 506
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>, ISpanFormattable, IFormattable, IUtf8SpanFormattable
	{
		// Token: 0x06002846 RID: 10310 RVA: 0x0007CA30 File Offset: 0x0007AC30
		public Version(int major, int minor, int build, int revision)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(major, "major");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(minor, "minor");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(build, "build");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(revision, "revision");
			this._Major = major;
			this._Minor = minor;
			this._Build = build;
			this._Revision = revision;
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x0007CA90 File Offset: 0x0007AC90
		public Version(int major, int minor, int build)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(major, "major");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(minor, "minor");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(build, "build");
			this._Major = major;
			this._Minor = minor;
			this._Build = build;
			this._Revision = -1;
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x0007CAE0 File Offset: 0x0007ACE0
		public Version(int major, int minor)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(major, "major");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(minor, "minor");
			this._Major = major;
			this._Minor = minor;
			this._Build = -1;
			this._Revision = -1;
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x0007CB1C File Offset: 0x0007AD1C
		[NullableContext(1)]
		public Version(string version)
		{
			Version version2 = Version.Parse(version);
			this._Major = version2.Major;
			this._Minor = version2.Minor;
			this._Build = version2.Build;
			this._Revision = version2.Revision;
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x0007CB66 File Offset: 0x0007AD66
		public Version()
		{
			this._Build = -1;
			this._Revision = -1;
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x0007CB7C File Offset: 0x0007AD7C
		private Version(Version version)
		{
			this._Major = version._Major;
			this._Minor = version._Minor;
			this._Build = version._Build;
			this._Revision = version._Revision;
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x0007CBB4 File Offset: 0x0007ADB4
		[NullableContext(1)]
		public object Clone()
		{
			return new Version(this);
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x0600284D RID: 10317 RVA: 0x0007CBBC File Offset: 0x0007ADBC
		public int Major
		{
			get
			{
				return this._Major;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x0600284E RID: 10318 RVA: 0x0007CBC4 File Offset: 0x0007ADC4
		public int Minor
		{
			get
			{
				return this._Minor;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x0007CBCC File Offset: 0x0007ADCC
		public int Build
		{
			get
			{
				return this._Build;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x0007CBD4 File Offset: 0x0007ADD4
		public int Revision
		{
			get
			{
				return this._Revision;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x0007CBDC File Offset: 0x0007ADDC
		public short MajorRevision
		{
			get
			{
				return (short)(this._Revision >> 16);
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06002852 RID: 10322 RVA: 0x0007CBE8 File Offset: 0x0007ADE8
		public short MinorRevision
		{
			get
			{
				return (short)(this._Revision & 65535);
			}
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x0007CBF8 File Offset: 0x0007ADF8
		[NullableContext(2)]
		public int CompareTo(object version)
		{
			if (version == null)
			{
				return 1;
			}
			Version version2 = version as Version;
			if (version2 != null)
			{
				return this.CompareTo(version2);
			}
			throw new ArgumentException(SR.Arg_MustBeVersion, "version");
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x0007CC2C File Offset: 0x0007AE2C
		[NullableContext(2)]
		public int CompareTo(Version value)
		{
			if (value == this)
			{
				return 0;
			}
			if (value == null)
			{
				return 1;
			}
			if (this._Major == value._Major)
			{
				if (this._Minor == value._Minor)
				{
					if (this._Build == value._Build)
					{
						if (this._Revision == value._Revision)
						{
							return 0;
						}
						if (this._Revision <= value._Revision)
						{
							return -1;
						}
						return 1;
					}
					else
					{
						if (this._Build <= value._Build)
						{
							return -1;
						}
						return 1;
					}
				}
				else
				{
					if (this._Minor <= value._Minor)
					{
						return -1;
					}
					return 1;
				}
			}
			else
			{
				if (this._Major <= value._Major)
				{
					return -1;
				}
				return 1;
			}
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x0007CCCB File Offset: 0x0007AECB
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return this.Equals(obj as Version);
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x0007CCDC File Offset: 0x0007AEDC
		[NullableContext(2)]
		public bool Equals([NotNullWhen(true)] Version obj)
		{
			return obj == this || (obj != null && this._Major == obj._Major && this._Minor == obj._Minor && this._Build == obj._Build && this._Revision == obj._Revision);
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x0007CD2C File Offset: 0x0007AF2C
		public override int GetHashCode()
		{
			return 0 | (this._Major & 15) << 28 | (this._Minor & 255) << 20 | (this._Build & 255) << 12 | (this._Revision & 4095);
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x0007CD69 File Offset: 0x0007AF69
		[NullableContext(1)]
		public override string ToString()
		{
			return this.ToString(this.DefaultFormatFieldCount);
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x0007CD78 File Offset: 0x0007AF78
		[NullableContext(1)]
		public unsafe string ToString(int fieldCount)
		{
			Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)94], 47);
			int length;
			this.TryFormat(destination, fieldCount, out length);
			return destination.Slice(0, length).ToString();
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x0000CB82 File Offset: 0x0000AD82
		string IFormattable.ToString(string format, IFormatProvider formatProvider)
		{
			return this.ToString();
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x0007CDB4 File Offset: 0x0007AFB4
		public bool TryFormat(Span<char> destination, out int charsWritten)
		{
			return this.TryFormatCore<char>(destination, this.DefaultFormatFieldCount, out charsWritten);
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x0007CDC4 File Offset: 0x0007AFC4
		public bool TryFormat(Span<char> destination, int fieldCount, out int charsWritten)
		{
			return this.TryFormatCore<char>(destination, fieldCount, out charsWritten);
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x0007CDCF File Offset: 0x0007AFCF
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten)
		{
			return this.TryFormatCore<byte>(utf8Destination, this.DefaultFormatFieldCount, out bytesWritten);
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x0007CDDF File Offset: 0x0007AFDF
		public bool TryFormat(Span<byte> utf8Destination, int fieldCount, out int bytesWritten)
		{
			return this.TryFormatCore<byte>(utf8Destination, fieldCount, out bytesWritten);
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x0007CDEC File Offset: 0x0007AFEC
		private unsafe bool TryFormatCore<[IsUnmanaged] TChar>(Span<TChar> destination, int fieldCount, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (fieldCount <= 4)
			{
				if (fieldCount >= 3)
				{
					if (this._Build == -1)
					{
						Version.<TryFormatCore>g__ThrowArgumentException|35_0<TChar>("2");
					}
					else if (fieldCount == 4)
					{
						if (this._Revision == -1)
						{
							Version.<TryFormatCore>g__ThrowArgumentException|35_0<TChar>("3");
						}
					}
				}
			}
			else
			{
				Version.<TryFormatCore>g__ThrowArgumentException|35_0<TChar>("4");
			}
			int num = 0;
			for (int i = 0; i < fieldCount; i++)
			{
				if (i != 0)
				{
					if (destination.IsEmpty)
					{
						charsWritten = 0;
						return false;
					}
					*destination[0] = IUtfChar<TChar>.CastFrom('.');
					destination = destination.Slice(1);
					num++;
				}
				int num2;
				switch (i)
				{
				case 0:
					num2 = this._Major;
					break;
				case 1:
					num2 = this._Minor;
					break;
				case 2:
					num2 = this._Build;
					break;
				default:
					num2 = this._Revision;
					break;
				}
				int num3 = num2;
				int num5;
				bool flag;
				if (!(typeof(TChar) == typeof(char)))
				{
					uint num4 = (uint)num3;
					flag = num4.TryFormat(Unsafe.BitCast<Span<TChar>, Span<byte>>(destination), out num5, default(ReadOnlySpan<char>), CultureInfo.InvariantCulture);
				}
				else
				{
					uint num4 = (uint)num3;
					flag = num4.TryFormat(Unsafe.BitCast<Span<TChar>, Span<char>>(destination), out num5, default(ReadOnlySpan<char>), null);
				}
				if (!flag)
				{
					charsWritten = 0;
					return false;
				}
				num += num5;
				destination = destination.Slice(num5);
			}
			charsWritten = num;
			return true;
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x0007CDB4 File Offset: 0x0007AFB4
		bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			return this.TryFormatCore<char>(destination, this.DefaultFormatFieldCount, out charsWritten);
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x0007CDCF File Offset: 0x0007AFCF
		bool IUtf8SpanFormattable.TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			return this.TryFormatCore<byte>(utf8Destination, this.DefaultFormatFieldCount, out bytesWritten);
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x0007CF3D File Offset: 0x0007B13D
		private int DefaultFormatFieldCount
		{
			get
			{
				if (this._Build == -1)
				{
					return 2;
				}
				if (this._Revision != -1)
				{
					return 4;
				}
				return 3;
			}
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x0007CF56 File Offset: 0x0007B156
		[NullableContext(1)]
		public static Version Parse(string input)
		{
			ArgumentNullException.ThrowIfNull(input, "input");
			return Version.ParseVersion(input.AsSpan(), true);
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x0007CF6F File Offset: 0x0007B16F
		[return: Nullable(1)]
		public static Version Parse(ReadOnlySpan<char> input)
		{
			return Version.ParseVersion(input, true);
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x0007CF78 File Offset: 0x0007B178
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string input, [NotNullWhen(true)] out Version result)
		{
			if (input == null)
			{
				result = null;
				return false;
			}
			Version v;
			result = (v = Version.ParseVersion(input.AsSpan(), false));
			return v != null;
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x0007CFA4 File Offset: 0x0007B1A4
		public static bool TryParse(ReadOnlySpan<char> input, [Nullable(2)] [NotNullWhen(true)] out Version result)
		{
			Version v;
			result = (v = Version.ParseVersion(input, false));
			return v != null;
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x0007CFC4 File Offset: 0x0007B1C4
		private static Version ParseVersion(ReadOnlySpan<char> input, bool throwOnFailure)
		{
			int num = input.IndexOf('.');
			if (num < 0)
			{
				if (throwOnFailure)
				{
					throw new ArgumentException(SR.Arg_VersionString, "input");
				}
				return null;
			}
			else
			{
				int num2 = -1;
				int num3 = input.Slice(num + 1).IndexOf('.');
				if (num3 >= 0)
				{
					num3 += num + 1;
					num2 = input.Slice(num3 + 1).IndexOf('.');
					if (num2 >= 0)
					{
						num2 += num3 + 1;
						if (input.Slice(num2 + 1).Contains('.'))
						{
							if (throwOnFailure)
							{
								throw new ArgumentException(SR.Arg_VersionString, "input");
							}
							return null;
						}
					}
				}
				int major;
				if (!Version.TryParseComponent(input.Slice(0, num), "input", throwOnFailure, out major))
				{
					return null;
				}
				if (num3 != -1)
				{
					int minor;
					if (!Version.TryParseComponent(input.Slice(num + 1, num3 - num - 1), "input", throwOnFailure, out minor))
					{
						return null;
					}
					if (num2 != -1)
					{
						int build;
						int revision;
						if (!Version.TryParseComponent(input.Slice(num3 + 1, num2 - num3 - 1), "build", throwOnFailure, out build) || !Version.TryParseComponent(input.Slice(num2 + 1), "revision", throwOnFailure, out revision))
						{
							return null;
						}
						return new Version(major, minor, build, revision);
					}
					else
					{
						int build;
						if (!Version.TryParseComponent(input.Slice(num3 + 1), "build", throwOnFailure, out build))
						{
							return null;
						}
						return new Version(major, minor, build);
					}
				}
				else
				{
					int minor;
					if (!Version.TryParseComponent(input.Slice(num + 1), "input", throwOnFailure, out minor))
					{
						return null;
					}
					return new Version(major, minor);
				}
			}
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x0007D129 File Offset: 0x0007B329
		private static bool TryParseComponent(ReadOnlySpan<char> component, string componentName, bool throwOnFailure, out int parsedComponent)
		{
			if (throwOnFailure)
			{
				parsedComponent = int.Parse(component, NumberStyles.Integer, CultureInfo.InvariantCulture);
				ArgumentOutOfRangeException.ThrowIfNegative<int>(parsedComponent, componentName);
				return true;
			}
			return int.TryParse(component, NumberStyles.Integer, CultureInfo.InvariantCulture, out parsedComponent) && parsedComponent >= 0;
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x0007D15F File Offset: 0x0007B35F
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Version v1, Version v2)
		{
			if (v2 == null)
			{
				return v1 == null;
			}
			return v2 == v1 || v2.Equals(v1);
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x0007D176 File Offset: 0x0007B376
		[NullableContext(2)]
		public static bool operator !=(Version v1, Version v2)
		{
			return !(v1 == v2);
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x0007D182 File Offset: 0x0007B382
		[NullableContext(2)]
		public static bool operator <(Version v1, Version v2)
		{
			if (v1 == null)
			{
				return v2 != null;
			}
			return v1.CompareTo(v2) < 0;
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x0007D196 File Offset: 0x0007B396
		[NullableContext(2)]
		public static bool operator <=(Version v1, Version v2)
		{
			return v1 == null || v1.CompareTo(v2) <= 0;
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x0007D1AA File Offset: 0x0007B3AA
		[NullableContext(2)]
		public static bool operator >(Version v1, Version v2)
		{
			return v2 < v1;
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x0007D1B3 File Offset: 0x0007B3B3
		[NullableContext(2)]
		public static bool operator >=(Version v1, Version v2)
		{
			return v2 <= v1;
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x0007D1BC File Offset: 0x0007B3BC
		[CompilerGenerated]
		internal static void <TryFormatCore>g__ThrowArgumentException|35_0<[IsUnmanaged] TChar>(string failureUpperBound) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			throw new ArgumentException(SR.Format(SR.ArgumentOutOfRange_Bounds_Lower_Upper, "0", failureUpperBound), "fieldCount");
		}

		// Token: 0x04000717 RID: 1815
		private readonly int _Major;

		// Token: 0x04000718 RID: 1816
		private readonly int _Minor;

		// Token: 0x04000719 RID: 1817
		private readonly int _Build;

		// Token: 0x0400071A RID: 1818
		private readonly int _Revision;
	}
}

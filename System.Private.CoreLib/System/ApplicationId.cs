using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	// Token: 0x020000CB RID: 203
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class ApplicationId
	{
		// Token: 0x060009C0 RID: 2496 RVA: 0x0001E188 File Offset: 0x0001C388
		public ApplicationId(byte[] publicKeyToken, string name, Version version, [Nullable(2)] string processorArchitecture, [Nullable(2)] string culture)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			ArgumentNullException.ThrowIfNull(version, "version");
			ArgumentNullException.ThrowIfNull(publicKeyToken, "publicKeyToken");
			this._publicKeyToken = (byte[])publicKeyToken.Clone();
			this.Name = name;
			this.Version = version;
			this.ProcessorArchitecture = processorArchitecture;
			this.Culture = culture;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0001E1EB File Offset: 0x0001C3EB
		[Nullable(2)]
		public string Culture { [NullableContext(2)] get; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0001E1F3 File Offset: 0x0001C3F3
		public string Name { get; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0001E1FB File Offset: 0x0001C3FB
		[Nullable(2)]
		public string ProcessorArchitecture { [NullableContext(2)] get; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0001E203 File Offset: 0x0001C403
		public Version Version { get; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x0001E20B File Offset: 0x0001C40B
		public byte[] PublicKeyToken
		{
			get
			{
				return (byte[])this._publicKeyToken.Clone();
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0001E21D File Offset: 0x0001C41D
		public ApplicationId Copy()
		{
			return new ApplicationId(this._publicKeyToken, this.Name, this.Version, this.ProcessorArchitecture, this.Culture);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0001E244 File Offset: 0x0001C444
		public unsafe override string ToString()
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			valueStringBuilder.Append(this.Name);
			if (this.Culture != null)
			{
				valueStringBuilder.Append(", culture=\"");
				valueStringBuilder.Append(this.Culture);
				valueStringBuilder.Append('"');
			}
			valueStringBuilder.Append(", version=\"");
			valueStringBuilder.Append(this.Version.ToString());
			valueStringBuilder.Append('"');
			if (this._publicKeyToken != null)
			{
				valueStringBuilder.Append(", publicKeyToken=\"");
				HexConverter.EncodeToUtf16(this._publicKeyToken, valueStringBuilder.AppendSpan(2 * this._publicKeyToken.Length), HexConverter.Casing.Upper);
				valueStringBuilder.Append('"');
			}
			if (this.ProcessorArchitecture != null)
			{
				valueStringBuilder.Append(", processorArchitecture =\"");
				valueStringBuilder.Append(this.ProcessorArchitecture);
				valueStringBuilder.Append('"');
			}
			return valueStringBuilder.ToString();
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0001E340 File Offset: 0x0001C540
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object o)
		{
			ApplicationId applicationId = o as ApplicationId;
			return applicationId != null && object.Equals(this.Name, applicationId.Name) && object.Equals(this.Version, applicationId.Version) && object.Equals(this.ProcessorArchitecture, applicationId.ProcessorArchitecture) && object.Equals(this.Culture, applicationId.Culture) && this._publicKeyToken.AsSpan<byte>().SequenceEqual(applicationId._publicKeyToken);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0001E3C0 File Offset: 0x0001C5C0
		public override int GetHashCode()
		{
			return this.Name.GetHashCode() ^ this.Version.GetHashCode();
		}

		// Token: 0x040002D2 RID: 722
		private readonly byte[] _publicKeyToken;
	}
}

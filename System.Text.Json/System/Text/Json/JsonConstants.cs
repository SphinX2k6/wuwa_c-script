using System;

namespace System.Text.Json
{
	// Token: 0x02000011 RID: 17
	internal static class JsonConstants
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000052E9 File Offset: 0x000034E9
		public unsafe static ReadOnlySpan<byte> Utf8Bom
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.F1945CD6C19E56B3C1C78943EF5EC18116907A4CA1EFC40A57D48AB1DB7ADFC5), 3);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x000052F6 File Offset: 0x000034F6
		public unsafe static ReadOnlySpan<byte> TrueValue
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.DEBC2F07DB78D52D2DEF07B7BC620D7042367501D9439A62BA09B559A98E0957), 4);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00005303 File Offset: 0x00003503
		public unsafe static ReadOnlySpan<byte> FalseValue
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.98151954F217A510702D236DE168CC35D0AB2F99C4479CC9B07EEEDE7EF73A66), 5);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00005310 File Offset: 0x00003510
		public unsafe static ReadOnlySpan<byte> NullValue
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.97CCCB1B1197F11C6EDBB0D93975220592EF8FAF618C8770A131E4F7DFE567CC), 4);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000531D File Offset: 0x0000351D
		public unsafe static ReadOnlySpan<byte> NaNValue
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.5AC07401E4F83150BC0552D68E463CFF181D33C5DBEE917B7C8F7AD508FF81C4), 3);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000532A File Offset: 0x0000352A
		public unsafe static ReadOnlySpan<byte> PositiveInfinityValue
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.13DEB4F81E4D9ED6197EEFBA2DF8CE10439D53D30FBA199F61461E159C624CED), 8);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00005337 File Offset: 0x00003537
		public unsafe static ReadOnlySpan<byte> NegativeInfinityValue
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.DD8F6C9CBF007866E6C260785EFAAE6C32A8228CE7CE3CDE5F87B28CDFCD2AC3), 9);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00005345 File Offset: 0x00003545
		public unsafe static ReadOnlySpan<byte> Delimiters
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.2D3ECB0435B638C234311ED9076E86553842EFB85DA106574F2ED7DA85605804), 8);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00005352 File Offset: 0x00003552
		public unsafe static ReadOnlySpan<byte> EscapableChars
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.D99A2E8B9B20C0C331F6C7128C2EA35622C429B103209CADD52E77B45309B8EE), 8);
			}
		}
	}
}

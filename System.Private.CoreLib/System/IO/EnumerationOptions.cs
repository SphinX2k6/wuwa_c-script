using System;
using System.Runtime.CompilerServices;

namespace System.IO
{
	// Token: 0x020007E5 RID: 2021
	[NullableContext(1)]
	[Nullable(0)]
	public class EnumerationOptions
	{
		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06008199 RID: 33177 RVA: 0x00133D6F File Offset: 0x00131F6F
		internal static EnumerationOptions Compatible { get; } = new EnumerationOptions
		{
			MatchType = MatchType.Win32,
			AttributesToSkip = FileAttributes.None,
			IgnoreInaccessible = false
		};

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x0600819A RID: 33178 RVA: 0x00133D76 File Offset: 0x00131F76
		private static EnumerationOptions CompatibleRecursive { get; } = new EnumerationOptions
		{
			RecurseSubdirectories = true,
			MatchType = MatchType.Win32,
			AttributesToSkip = FileAttributes.None,
			IgnoreInaccessible = false
		};

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x0600819B RID: 33179 RVA: 0x00133D7D File Offset: 0x00131F7D
		internal static EnumerationOptions Default { get; } = new EnumerationOptions();

		// Token: 0x0600819C RID: 33180 RVA: 0x00133D84 File Offset: 0x00131F84
		public EnumerationOptions()
		{
			this.IgnoreInaccessible = true;
			this.AttributesToSkip = (FileAttributes.Hidden | FileAttributes.System);
			this.MaxRecursionDepth = int.MaxValue;
		}

		// Token: 0x0600819D RID: 33181 RVA: 0x00133DA5 File Offset: 0x00131FA5
		internal static EnumerationOptions FromSearchOption(SearchOption searchOption)
		{
			if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
			{
				throw new ArgumentOutOfRangeException("searchOption", SR.ArgumentOutOfRange_Enum);
			}
			if (searchOption != SearchOption.AllDirectories)
			{
				return EnumerationOptions.Compatible;
			}
			return EnumerationOptions.CompatibleRecursive;
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x0600819E RID: 33182 RVA: 0x00133DCD File Offset: 0x00131FCD
		// (set) Token: 0x0600819F RID: 33183 RVA: 0x00133DD5 File Offset: 0x00131FD5
		public bool RecurseSubdirectories { get; set; }

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x060081A0 RID: 33184 RVA: 0x00133DDE File Offset: 0x00131FDE
		// (set) Token: 0x060081A1 RID: 33185 RVA: 0x00133DE6 File Offset: 0x00131FE6
		public bool IgnoreInaccessible { get; set; }

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x060081A2 RID: 33186 RVA: 0x00133DEF File Offset: 0x00131FEF
		// (set) Token: 0x060081A3 RID: 33187 RVA: 0x00133DF7 File Offset: 0x00131FF7
		public int BufferSize { get; set; }

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x060081A4 RID: 33188 RVA: 0x00133E00 File Offset: 0x00132000
		// (set) Token: 0x060081A5 RID: 33189 RVA: 0x00133E08 File Offset: 0x00132008
		public FileAttributes AttributesToSkip { get; set; }

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x060081A6 RID: 33190 RVA: 0x00133E11 File Offset: 0x00132011
		// (set) Token: 0x060081A7 RID: 33191 RVA: 0x00133E19 File Offset: 0x00132019
		public MatchType MatchType { get; set; }

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x060081A8 RID: 33192 RVA: 0x00133E22 File Offset: 0x00132022
		// (set) Token: 0x060081A9 RID: 33193 RVA: 0x00133E2A File Offset: 0x0013202A
		public MatchCasing MatchCasing { get; set; }

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x060081AA RID: 33194 RVA: 0x00133E33 File Offset: 0x00132033
		// (set) Token: 0x060081AB RID: 33195 RVA: 0x00133E3B File Offset: 0x0013203B
		public int MaxRecursionDepth
		{
			get
			{
				return this._maxRecursionDepth;
			}
			set
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(value, "value");
				this._maxRecursionDepth = value;
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x060081AC RID: 33196 RVA: 0x00133E4F File Offset: 0x0013204F
		// (set) Token: 0x060081AD RID: 33197 RVA: 0x00133E57 File Offset: 0x00132057
		public bool ReturnSpecialDirectories { get; set; }

		// Token: 0x04001B16 RID: 6934
		private int _maxRecursionDepth;
	}
}

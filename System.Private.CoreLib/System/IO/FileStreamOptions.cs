using System;
using System.IO.Strategies;
using System.Runtime.Versioning;

namespace System.IO
{
	// Token: 0x020007FA RID: 2042
	public sealed class FileStreamOptions
	{
		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x060082BD RID: 33469 RVA: 0x0013753E File Offset: 0x0013573E
		// (set) Token: 0x060082BE RID: 33470 RVA: 0x00137546 File Offset: 0x00135746
		public FileMode Mode
		{
			get
			{
				return this._mode;
			}
			set
			{
				if (value < FileMode.CreateNew || value > FileMode.Append)
				{
					ThrowHelper.ArgumentOutOfRangeException_Enum_Value();
				}
				this._mode = value;
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x060082BF RID: 33471 RVA: 0x0013755C File Offset: 0x0013575C
		// (set) Token: 0x060082C0 RID: 33472 RVA: 0x00137564 File Offset: 0x00135764
		public FileAccess Access
		{
			get
			{
				return this._access;
			}
			set
			{
				if (value < FileAccess.Read || value > FileAccess.ReadWrite)
				{
					ThrowHelper.ArgumentOutOfRangeException_Enum_Value();
				}
				this._access = value;
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x060082C1 RID: 33473 RVA: 0x0013757A File Offset: 0x0013577A
		// (set) Token: 0x060082C2 RID: 33474 RVA: 0x00137584 File Offset: 0x00135784
		public FileShare Share
		{
			get
			{
				return this._share;
			}
			set
			{
				FileShare fileShare = value & ~FileShare.Inheritable;
				if (fileShare < FileShare.None || fileShare > (FileShare.Read | FileShare.Write | FileShare.Delete))
				{
					ThrowHelper.ArgumentOutOfRangeException_Enum_Value();
				}
				this._share = value;
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x060082C3 RID: 33475 RVA: 0x001375AA File Offset: 0x001357AA
		// (set) Token: 0x060082C4 RID: 33476 RVA: 0x001375B2 File Offset: 0x001357B2
		public FileOptions Options
		{
			get
			{
				return this._options;
			}
			set
			{
				if (FileStreamHelpers.AreInvalid(value))
				{
					ThrowHelper.ArgumentOutOfRangeException_Enum_Value();
				}
				this._options = value;
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x060082C5 RID: 33477 RVA: 0x001375C8 File Offset: 0x001357C8
		// (set) Token: 0x060082C6 RID: 33478 RVA: 0x001375D0 File Offset: 0x001357D0
		public long PreallocationSize
		{
			get
			{
				return this._preallocationSize;
			}
			set
			{
				ArgumentOutOfRangeException.ThrowIfNegative<long>(value, "value");
				this._preallocationSize = value;
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x060082C7 RID: 33479 RVA: 0x001375E4 File Offset: 0x001357E4
		// (set) Token: 0x060082C8 RID: 33480 RVA: 0x001375EC File Offset: 0x001357EC
		public int BufferSize
		{
			get
			{
				return this._bufferSize;
			}
			set
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(value, "value");
				this._bufferSize = value;
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x060082C9 RID: 33481 RVA: 0x00137600 File Offset: 0x00135800
		// (set) Token: 0x060082CA RID: 33482 RVA: 0x00137608 File Offset: 0x00135808
		public UnixFileMode? UnixCreateMode
		{
			get
			{
				return this._unixCreateMode;
			}
			[UnsupportedOSPlatform("windows")]
			set
			{
				throw new PlatformNotSupportedException(SR.PlatformNotSupported_UnixFileMode);
			}
		}

		// Token: 0x04001BAD RID: 7085
		private FileMode _mode = FileMode.Open;

		// Token: 0x04001BAE RID: 7086
		private FileAccess _access = FileAccess.Read;

		// Token: 0x04001BAF RID: 7087
		private FileShare _share = FileShare.Read;

		// Token: 0x04001BB0 RID: 7088
		private FileOptions _options;

		// Token: 0x04001BB1 RID: 7089
		private long _preallocationSize;

		// Token: 0x04001BB2 RID: 7090
		private int _bufferSize = 4096;

		// Token: 0x04001BB3 RID: 7091
		private UnixFileMode? _unixCreateMode;
	}
}

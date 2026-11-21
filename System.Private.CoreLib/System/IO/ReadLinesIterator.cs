using System;
using System.Text;

namespace System.IO
{
	// Token: 0x02000814 RID: 2068
	internal sealed class ReadLinesIterator : Iterator<string>
	{
		// Token: 0x060083FE RID: 33790 RVA: 0x0013CB2E File Offset: 0x0013AD2E
		private ReadLinesIterator(string path, Encoding encoding, StreamReader reader)
		{
			this._path = path;
			this._encoding = encoding;
			this._reader = reader;
		}

		// Token: 0x060083FF RID: 33791 RVA: 0x0013CB4B File Offset: 0x0013AD4B
		public override bool MoveNext()
		{
			if (this._reader != null)
			{
				this.current = this._reader.ReadLine();
				if (this.current != null)
				{
					return true;
				}
				base.Dispose();
			}
			return false;
		}

		// Token: 0x06008400 RID: 33792 RVA: 0x0013CB77 File Offset: 0x0013AD77
		protected override Iterator<string> Clone()
		{
			return ReadLinesIterator.CreateIterator(this._path, this._encoding, this._reader);
		}

		// Token: 0x06008401 RID: 33793 RVA: 0x0013CB90 File Offset: 0x0013AD90
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					StreamReader reader = this._reader;
					if (reader != null)
					{
						reader.Dispose();
					}
				}
			}
			finally
			{
				this._reader = null;
				base.Dispose(disposing);
			}
		}

		// Token: 0x06008402 RID: 33794 RVA: 0x0013CBD4 File Offset: 0x0013ADD4
		internal static ReadLinesIterator CreateIterator(string path, Encoding encoding)
		{
			return ReadLinesIterator.CreateIterator(path, encoding, null);
		}

		// Token: 0x06008403 RID: 33795 RVA: 0x0013CBDE File Offset: 0x0013ADDE
		private static ReadLinesIterator CreateIterator(string path, Encoding encoding, StreamReader reader)
		{
			return new ReadLinesIterator(path, encoding, reader ?? new StreamReader(path, encoding));
		}

		// Token: 0x04001C14 RID: 7188
		private readonly string _path;

		// Token: 0x04001C15 RID: 7189
		private readonly Encoding _encoding;

		// Token: 0x04001C16 RID: 7190
		private StreamReader _reader;
	}
}

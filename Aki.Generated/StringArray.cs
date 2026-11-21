using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200131E RID: 4894
	public struct StringArray : IFlatbufferObject
	{
		// Token: 0x170042B2 RID: 17074
		// (get) Token: 0x0600F934 RID: 63796 RVA: 0x00375AFC File Offset: 0x00373CFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F935 RID: 63797 RVA: 0x00375B09 File Offset: 0x00373D09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F936 RID: 63798 RVA: 0x00375B10 File Offset: 0x00373D10
		public static StringArray GetRootAsStringArray(ByteBuffer _bb)
		{
			return StringArray.GetRootAsStringArray(_bb, default(StringArray));
		}

		// Token: 0x0600F937 RID: 63799 RVA: 0x00375B2C File Offset: 0x00373D2C
		public static StringArray GetRootAsStringArray(ByteBuffer _bb, StringArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F938 RID: 63800 RVA: 0x00375B49 File Offset: 0x00373D49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F939 RID: 63801 RVA: 0x00375B58 File Offset: 0x00373D58
		public StringArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F93A RID: 63802 RVA: 0x00375B68 File Offset: 0x00373D68
		public string ArrayString(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170042B3 RID: 17075
		// (get) Token: 0x0600F93B RID: 63803 RVA: 0x00375BA4 File Offset: 0x00373DA4
		public int ArrayStringLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F93C RID: 63804 RVA: 0x00375BCF File Offset: 0x00373DCF
		[NullableContext(1)]
		public string[] ArrayString()
		{
			return this.ArrayStringIter().ToArray<string>();
		}

		// Token: 0x0600F93D RID: 63805 RVA: 0x00375BDC File Offset: 0x00373DDC
		[NullableContext(1)]
		public IEnumerable<string> ArrayStringIter()
		{
			StringArray.<ArrayStringIter>d__12 <ArrayStringIter>d__ = new StringArray.<ArrayStringIter>d__12(-2);
			<ArrayStringIter>d__.<>3__<>4__this = this;
			return <ArrayStringIter>d__;
		}

		// Token: 0x040059A4 RID: 22948
		private Table __p;
	}
}

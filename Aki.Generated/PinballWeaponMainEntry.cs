using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001023 RID: 4131
	public struct PinballWeaponMainEntry : IFlatbufferObject
	{
		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x0600B6DC RID: 46812 RVA: 0x002E25BF File Offset: 0x002E07BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B6DD RID: 46813 RVA: 0x002E25CC File Offset: 0x002E07CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B6DE RID: 46814 RVA: 0x002E25D4 File Offset: 0x002E07D4
		public static PinballWeaponMainEntry GetRootAsPinballWeaponMainEntry(ByteBuffer _bb)
		{
			return PinballWeaponMainEntry.GetRootAsPinballWeaponMainEntry(_bb, default(PinballWeaponMainEntry));
		}

		// Token: 0x0600B6DF RID: 46815 RVA: 0x002E25F0 File Offset: 0x002E07F0
		public static PinballWeaponMainEntry GetRootAsPinballWeaponMainEntry(ByteBuffer _bb, PinballWeaponMainEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B6E0 RID: 46816 RVA: 0x002E260D File Offset: 0x002E080D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B6E1 RID: 46817 RVA: 0x002E261C File Offset: 0x002E081C
		public PinballWeaponMainEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A6A RID: 10858
		// (get) Token: 0x0600B6E2 RID: 46818 RVA: 0x002E262C File Offset: 0x002E082C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A6B RID: 10859
		// (get) Token: 0x0600B6E3 RID: 46819 RVA: 0x002E2668 File Offset: 0x002E0868
		public string ProperDesc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B6E4 RID: 46820 RVA: 0x002E269F File Offset: 0x002E089F
		public Span<byte> GetProperDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B6E5 RID: 46821 RVA: 0x002E26AE File Offset: 0x002E08AE
		public byte[] GetProperDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B6E6 RID: 46822 RVA: 0x002E26C8 File Offset: 0x002E08C8
		public string ProperVal(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x0600B6E7 RID: 46823 RVA: 0x002E2704 File Offset: 0x002E0904
		public int ProperValLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x0600B6E8 RID: 46824 RVA: 0x002E2730 File Offset: 0x002E0930
		public int Buff
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x0600B6E9 RID: 46825 RVA: 0x002E2770 File Offset: 0x002E0970
		public int KscAttrType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x0600B6EA RID: 46826 RVA: 0x002E27B0 File Offset: 0x002E09B0
		public int KscAttrValue
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B6EB RID: 46827 RVA: 0x002E27ED File Offset: 0x002E09ED
		[NullableContext(1)]
		public string[] ProperVal()
		{
			return this.ProperValIter().ToArray<string>();
		}

		// Token: 0x0600B6EC RID: 46828 RVA: 0x002E27FA File Offset: 0x002E09FA
		[NullableContext(1)]
		public IEnumerable<string> ProperValIter()
		{
			PinballWeaponMainEntry.<ProperValIter>d__24 <ProperValIter>d__ = new PinballWeaponMainEntry.<ProperValIter>d__24(-2);
			<ProperValIter>d__.<>3__<>4__this = this;
			return <ProperValIter>d__;
		}

		// Token: 0x040055ED RID: 21997
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001025 RID: 4133
	public struct PinballWeaponSubEntry : IFlatbufferObject
	{
		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x0600B6FD RID: 46845 RVA: 0x002E29D8 File Offset: 0x002E0BD8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B6FE RID: 46846 RVA: 0x002E29E5 File Offset: 0x002E0BE5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B6FF RID: 46847 RVA: 0x002E29EC File Offset: 0x002E0BEC
		public static PinballWeaponSubEntry GetRootAsPinballWeaponSubEntry(ByteBuffer _bb)
		{
			return PinballWeaponSubEntry.GetRootAsPinballWeaponSubEntry(_bb, default(PinballWeaponSubEntry));
		}

		// Token: 0x0600B700 RID: 46848 RVA: 0x002E2A08 File Offset: 0x002E0C08
		public static PinballWeaponSubEntry GetRootAsPinballWeaponSubEntry(ByteBuffer _bb, PinballWeaponSubEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B701 RID: 46849 RVA: 0x002E2A25 File Offset: 0x002E0C25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B702 RID: 46850 RVA: 0x002E2A34 File Offset: 0x002E0C34
		public PinballWeaponSubEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A76 RID: 10870
		// (get) Token: 0x0600B703 RID: 46851 RVA: 0x002E2A44 File Offset: 0x002E0C44
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

		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x0600B704 RID: 46852 RVA: 0x002E2A80 File Offset: 0x002E0C80
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

		// Token: 0x0600B705 RID: 46853 RVA: 0x002E2AB7 File Offset: 0x002E0CB7
		public Span<byte> GetProperDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B706 RID: 46854 RVA: 0x002E2AC6 File Offset: 0x002E0CC6
		public byte[] GetProperDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B707 RID: 46855 RVA: 0x002E2AE0 File Offset: 0x002E0CE0
		public string ProperVal(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A78 RID: 10872
		// (get) Token: 0x0600B708 RID: 46856 RVA: 0x002E2B1C File Offset: 0x002E0D1C
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

		// Token: 0x17002A79 RID: 10873
		// (get) Token: 0x0600B709 RID: 46857 RVA: 0x002E2B48 File Offset: 0x002E0D48
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

		// Token: 0x17002A7A RID: 10874
		// (get) Token: 0x0600B70A RID: 46858 RVA: 0x002E2B88 File Offset: 0x002E0D88
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

		// Token: 0x17002A7B RID: 10875
		// (get) Token: 0x0600B70B RID: 46859 RVA: 0x002E2BC8 File Offset: 0x002E0DC8
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

		// Token: 0x0600B70C RID: 46860 RVA: 0x002E2C05 File Offset: 0x002E0E05
		[NullableContext(1)]
		public string[] ProperVal()
		{
			return this.ProperValIter().ToArray<string>();
		}

		// Token: 0x0600B70D RID: 46861 RVA: 0x002E2C12 File Offset: 0x002E0E12
		[NullableContext(1)]
		public IEnumerable<string> ProperValIter()
		{
			PinballWeaponSubEntry.<ProperValIter>d__24 <ProperValIter>d__ = new PinballWeaponSubEntry.<ProperValIter>d__24(-2);
			<ProperValIter>d__.<>3__<>4__this = this;
			return <ProperValIter>d__;
		}

		// Token: 0x040055EF RID: 21999
		private Table __p;
	}
}

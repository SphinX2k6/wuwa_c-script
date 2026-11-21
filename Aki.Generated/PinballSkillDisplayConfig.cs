using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200101D RID: 4125
	public struct PinballSkillDisplayConfig : IFlatbufferObject
	{
		// Token: 0x17002A3E RID: 10814
		// (get) Token: 0x0600B670 RID: 46704 RVA: 0x002E1759 File Offset: 0x002DF959
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B671 RID: 46705 RVA: 0x002E1766 File Offset: 0x002DF966
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B672 RID: 46706 RVA: 0x002E1770 File Offset: 0x002DF970
		public static PinballSkillDisplayConfig GetRootAsPinballSkillDisplayConfig(ByteBuffer _bb)
		{
			return PinballSkillDisplayConfig.GetRootAsPinballSkillDisplayConfig(_bb, default(PinballSkillDisplayConfig));
		}

		// Token: 0x0600B673 RID: 46707 RVA: 0x002E178C File Offset: 0x002DF98C
		public static PinballSkillDisplayConfig GetRootAsPinballSkillDisplayConfig(ByteBuffer _bb, PinballSkillDisplayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B674 RID: 46708 RVA: 0x002E17A9 File Offset: 0x002DF9A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B675 RID: 46709 RVA: 0x002E17B8 File Offset: 0x002DF9B8
		public PinballSkillDisplayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A3F RID: 10815
		// (get) Token: 0x0600B676 RID: 46710 RVA: 0x002E17C8 File Offset: 0x002DF9C8
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

		// Token: 0x17002A40 RID: 10816
		// (get) Token: 0x0600B677 RID: 46711 RVA: 0x002E1804 File Offset: 0x002DFA04
		public string Name
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

		// Token: 0x0600B678 RID: 46712 RVA: 0x002E183B File Offset: 0x002DFA3B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B679 RID: 46713 RVA: 0x002E184A File Offset: 0x002DFA4A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A41 RID: 10817
		// (get) Token: 0x0600B67A RID: 46714 RVA: 0x002E1864 File Offset: 0x002DFA64
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B67B RID: 46715 RVA: 0x002E189B File Offset: 0x002DFA9B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B67C RID: 46716 RVA: 0x002E18AA File Offset: 0x002DFAAA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B67D RID: 46717 RVA: 0x002E18C4 File Offset: 0x002DFAC4
		public string ValueList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A42 RID: 10818
		// (get) Token: 0x0600B67E RID: 46718 RVA: 0x002E1900 File Offset: 0x002DFB00
		public int ValueListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x0600B67F RID: 46719 RVA: 0x002E192C File Offset: 0x002DFB2C
		public bool IsCaptainSkill
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600B680 RID: 46720 RVA: 0x002E196C File Offset: 0x002DFB6C
		[NullableContext(1)]
		public string[] ValueList()
		{
			return this.ValueListIter().ToArray<string>();
		}

		// Token: 0x0600B681 RID: 46721 RVA: 0x002E1979 File Offset: 0x002DFB79
		[NullableContext(1)]
		public IEnumerable<string> ValueListIter()
		{
			PinballSkillDisplayConfig.<ValueListIter>d__24 <ValueListIter>d__ = new PinballSkillDisplayConfig.<ValueListIter>d__24(-2);
			<ValueListIter>d__.<>3__<>4__this = this;
			return <ValueListIter>d__;
		}

		// Token: 0x040055E7 RID: 21991
		private Table __p;
	}
}

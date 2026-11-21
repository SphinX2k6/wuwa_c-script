using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E14 RID: 3604
	public struct HonamiStoryAreaTask : IFlatbufferObject
	{
		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x0600851A RID: 34074 RVA: 0x00273E6C File Offset: 0x0027206C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600851B RID: 34075 RVA: 0x00273E79 File Offset: 0x00272079
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600851C RID: 34076 RVA: 0x00273E80 File Offset: 0x00272080
		public static HonamiStoryAreaTask GetRootAsHonamiStoryAreaTask(ByteBuffer _bb)
		{
			return HonamiStoryAreaTask.GetRootAsHonamiStoryAreaTask(_bb, default(HonamiStoryAreaTask));
		}

		// Token: 0x0600851D RID: 34077 RVA: 0x00273E9C File Offset: 0x0027209C
		public static HonamiStoryAreaTask GetRootAsHonamiStoryAreaTask(ByteBuffer _bb, HonamiStoryAreaTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600851E RID: 34078 RVA: 0x00273EB9 File Offset: 0x002720B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600851F RID: 34079 RVA: 0x00273EC8 File Offset: 0x002720C8
		public HonamiStoryAreaTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06008520 RID: 34080 RVA: 0x00273ED8 File Offset: 0x002720D8
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

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06008521 RID: 34081 RVA: 0x00273F14 File Offset: 0x00272114
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06008522 RID: 34082 RVA: 0x00273F50 File Offset: 0x00272150
		public int AreaId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06008523 RID: 34083 RVA: 0x00273F8C File Offset: 0x0027218C
		public int DropId
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

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06008524 RID: 34084 RVA: 0x00273FCC File Offset: 0x002721CC
		public int Weight
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

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06008525 RID: 34085 RVA: 0x0027400C File Offset: 0x0027220C
		public int TaskType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06008526 RID: 34086 RVA: 0x0027404C File Offset: 0x0027224C
		public string MainTargetDesText
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008527 RID: 34087 RVA: 0x00274084 File Offset: 0x00272284
		public Span<byte> GetMainTargetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008528 RID: 34088 RVA: 0x00274094 File Offset: 0x00272294
		public byte[] GetMainTargetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06008529 RID: 34089 RVA: 0x002740AC File Offset: 0x002722AC
		public string TargetDesText(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x0600852A RID: 34090 RVA: 0x002740E8 File Offset: 0x002722E8
		public int TargetDesTextLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x0600852B RID: 34091 RVA: 0x00274114 File Offset: 0x00272314
		public string Name
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600852C RID: 34092 RVA: 0x0027414C File Offset: 0x0027234C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600852D RID: 34093 RVA: 0x0027415C File Offset: 0x0027235C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x0600852E RID: 34094 RVA: 0x00274174 File Offset: 0x00272374
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600852F RID: 34095 RVA: 0x002741AC File Offset: 0x002723AC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008530 RID: 34096 RVA: 0x002741BC File Offset: 0x002723BC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06008531 RID: 34097 RVA: 0x002741D4 File Offset: 0x002723D4
		public int BTId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008532 RID: 34098 RVA: 0x00274211 File Offset: 0x00272411
		[NullableContext(1)]
		public string[] TargetDesText()
		{
			return this.TargetDesTextIter().ToArray<string>();
		}

		// Token: 0x06008533 RID: 34099 RVA: 0x0027421E File Offset: 0x0027241E
		[NullableContext(1)]
		public IEnumerable<string> TargetDesTextIter()
		{
			HonamiStoryAreaTask.<TargetDesTextIter>d__38 <TargetDesTextIter>d__ = new HonamiStoryAreaTask.<TargetDesTextIter>d__38(-2);
			<TargetDesTextIter>d__.<>3__<>4__this = this;
			return <TargetDesTextIter>d__;
		}

		// Token: 0x0400538D RID: 21389
		private Table __p;
	}
}

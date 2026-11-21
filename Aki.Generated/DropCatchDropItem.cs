using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CED RID: 3309
	public struct DropCatchDropItem : IFlatbufferObject
	{
		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06006B0F RID: 27407 RVA: 0x00239AE8 File Offset: 0x00237CE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006B10 RID: 27408 RVA: 0x00239AF5 File Offset: 0x00237CF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006B11 RID: 27409 RVA: 0x00239AFC File Offset: 0x00237CFC
		public static DropCatchDropItem GetRootAsDropCatchDropItem(ByteBuffer _bb)
		{
			return DropCatchDropItem.GetRootAsDropCatchDropItem(_bb, default(DropCatchDropItem));
		}

		// Token: 0x06006B12 RID: 27410 RVA: 0x00239B18 File Offset: 0x00237D18
		public static DropCatchDropItem GetRootAsDropCatchDropItem(ByteBuffer _bb, DropCatchDropItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006B13 RID: 27411 RVA: 0x00239B35 File Offset: 0x00237D35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006B14 RID: 27412 RVA: 0x00239B44 File Offset: 0x00237D44
		public DropCatchDropItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06006B15 RID: 27413 RVA: 0x00239B54 File Offset: 0x00237D54
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

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06006B16 RID: 27414 RVA: 0x00239B90 File Offset: 0x00237D90
		public float MoveSpeed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006B17 RID: 27415 RVA: 0x00239BD0 File Offset: 0x00237DD0
		public float Size(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06006B18 RID: 27416 RVA: 0x00239C14 File Offset: 0x00237E14
		public int SizeLength
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

		// Token: 0x06006B19 RID: 27417 RVA: 0x00239C3F File Offset: 0x00237E3F
		public Span<float> GetSizeBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x06006B1A RID: 27418 RVA: 0x00239C4E File Offset: 0x00237E4E
		public float[] GetSizeArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06006B1B RID: 27419 RVA: 0x00239C68 File Offset: 0x00237E68
		public string EffectCommands
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006B1C RID: 27420 RVA: 0x00239CA0 File Offset: 0x00237EA0
		public Span<byte> GetEffectCommandsBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006B1D RID: 27421 RVA: 0x00239CB0 File Offset: 0x00237EB0
		public byte[] GetEffectCommandsArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06006B1E RID: 27422 RVA: 0x00239CC8 File Offset: 0x00237EC8
		public int Score
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

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06006B1F RID: 27423 RVA: 0x00239D08 File Offset: 0x00237F08
		public int Energy
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

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06006B20 RID: 27424 RVA: 0x00239D48 File Offset: 0x00237F48
		public int EffectType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06006B21 RID: 27425 RVA: 0x00239D88 File Offset: 0x00237F88
		public string Name
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006B22 RID: 27426 RVA: 0x00239DC0 File Offset: 0x00237FC0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006B23 RID: 27427 RVA: 0x00239DD0 File Offset: 0x00237FD0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06006B24 RID: 27428 RVA: 0x00239DE8 File Offset: 0x00237FE8
		public string Desc
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

		// Token: 0x06006B25 RID: 27429 RVA: 0x00239E20 File Offset: 0x00238020
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006B26 RID: 27430 RVA: 0x00239E30 File Offset: 0x00238030
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06006B27 RID: 27431 RVA: 0x00239E48 File Offset: 0x00238048
		public string Icon
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

		// Token: 0x06006B28 RID: 27432 RVA: 0x00239E80 File Offset: 0x00238080
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006B29 RID: 27433 RVA: 0x00239E90 File Offset: 0x00238090
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06006B2A RID: 27434 RVA: 0x00239EA8 File Offset: 0x002380A8
		public int Priority
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

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06006B2B RID: 27435 RVA: 0x00239EE8 File Offset: 0x002380E8
		public int NiagaraType
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06006B2C RID: 27436 RVA: 0x00239F28 File Offset: 0x00238128
		public int ItemTemplate
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006B2D RID: 27437 RVA: 0x00239F65 File Offset: 0x00238165
		[NullableContext(1)]
		public float[] Size()
		{
			return this.GetSizeArray();
		}

		// Token: 0x06006B2E RID: 27438 RVA: 0x00239F6D File Offset: 0x0023816D
		[NullableContext(1)]
		public IEnumerable<float> SizeIter()
		{
			DropCatchDropItem.<SizeIter>d__46 <SizeIter>d__ = new DropCatchDropItem.<SizeIter>d__46(-2);
			<SizeIter>d__.<>3__<>4__this = this;
			return <SizeIter>d__;
		}

		// Token: 0x04005229 RID: 21033
		private Table __p;
	}
}

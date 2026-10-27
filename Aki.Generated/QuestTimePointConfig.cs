using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F79 RID: 3961
	public struct QuestTimePointConfig : IFlatbufferObject
	{
		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x0600B678 RID: 46712 RVA: 0x002D1995 File Offset: 0x002CFB95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B679 RID: 46713 RVA: 0x002D19A2 File Offset: 0x002CFBA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B67A RID: 46714 RVA: 0x002D19AC File Offset: 0x002CFBAC
		public static QuestTimePointConfig GetRootAsQuestTimePointConfig(ByteBuffer _bb)
		{
			return QuestTimePointConfig.GetRootAsQuestTimePointConfig(_bb, default(QuestTimePointConfig));
		}

		// Token: 0x0600B67B RID: 46715 RVA: 0x002D19C8 File Offset: 0x002CFBC8
		public static QuestTimePointConfig GetRootAsQuestTimePointConfig(ByteBuffer _bb, QuestTimePointConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B67C RID: 46716 RVA: 0x002D19E5 File Offset: 0x002CFBE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B67D RID: 46717 RVA: 0x002D19F4 File Offset: 0x002CFBF4
		public QuestTimePointConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x0600B67E RID: 46718 RVA: 0x002D1A04 File Offset: 0x002CFC04
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

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x0600B67F RID: 46719 RVA: 0x002D1A40 File Offset: 0x002CFC40
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

		// Token: 0x0600B680 RID: 46720 RVA: 0x002D1A77 File Offset: 0x002CFC77
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B681 RID: 46721 RVA: 0x002D1A86 File Offset: 0x002CFC86
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x0600B682 RID: 46722 RVA: 0x002D1AA0 File Offset: 0x002CFCA0
		public string NameBottom
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

		// Token: 0x0600B683 RID: 46723 RVA: 0x002D1AD7 File Offset: 0x002CFCD7
		public Span<byte> GetNameBottomBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B684 RID: 46724 RVA: 0x002D1AE6 File Offset: 0x002CFCE6
		public byte[] GetNameBottomArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x0600B685 RID: 46725 RVA: 0x002D1B00 File Offset: 0x002CFD00
		public int UnlockCondition
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

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x0600B686 RID: 46726 RVA: 0x002D1B40 File Offset: 0x002CFD40
		public int QuestId
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

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x0600B687 RID: 46727 RVA: 0x002D1B80 File Offset: 0x002CFD80
		public string ScreenEffect
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B688 RID: 46728 RVA: 0x002D1BB8 File Offset: 0x002CFDB8
		public Span<byte> GetScreenEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B689 RID: 46729 RVA: 0x002D1BC8 File Offset: 0x002CFDC8
		public byte[] GetScreenEffectArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x0600B68A RID: 46730 RVA: 0x002D1BE0 File Offset: 0x002CFDE0
		public int BranchPage
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

		// Token: 0x0600B68B RID: 46731 RVA: 0x002D1C20 File Offset: 0x002CFE20
		public int ComponentGroup(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x0600B68C RID: 46732 RVA: 0x002D1C60 File Offset: 0x002CFE60
		public int ComponentGroupLength
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

		// Token: 0x0600B68D RID: 46733 RVA: 0x002D1C8C File Offset: 0x002CFE8C
		public Span<int> GetComponentGroupBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600B68E RID: 46734 RVA: 0x002D1C9C File Offset: 0x002CFE9C
		public int[] GetComponentGroupArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x0600B68F RID: 46735 RVA: 0x002D1CB4 File Offset: 0x002CFEB4
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x0600B690 RID: 46736 RVA: 0x002D1CF4 File Offset: 0x002CFEF4
		public string Title
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

		// Token: 0x0600B691 RID: 46737 RVA: 0x002D1D2C File Offset: 0x002CFF2C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B692 RID: 46738 RVA: 0x002D1D3C File Offset: 0x002CFF3C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x0600B693 RID: 46739 RVA: 0x002D1D54 File Offset: 0x002CFF54
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B694 RID: 46740 RVA: 0x002D1D8C File Offset: 0x002CFF8C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B695 RID: 46741 RVA: 0x002D1D9C File Offset: 0x002CFF9C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x0600B696 RID: 46742 RVA: 0x002D1DB4 File Offset: 0x002CFFB4
		public bool IsBranchNode
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600B697 RID: 46743 RVA: 0x002D1DF4 File Offset: 0x002CFFF4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ComponentGroupIter()或GetComponentGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ComponentGroup()
		{
			QuestTimePointConfig questTimePointConfig = this;
			return questTimePointConfig.GetComponentGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B698 RID: 46744 RVA: 0x002D1E18 File Offset: 0x002D0018
		[NullableContext(1)]
		public readonly IEnumerable<int> ComponentGroupIter()
		{
			QuestTimePointConfig.<ComponentGroupIter>d__46 <ComponentGroupIter>d__ = new QuestTimePointConfig.<ComponentGroupIter>d__46(-2);
			<ComponentGroupIter>d__.<>3__<>4__this = this;
			return <ComponentGroupIter>d__;
		}

		// Token: 0x04005047 RID: 20551
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001217 RID: 4631
	public struct SpecialItem : IFlatbufferObject
	{
		// Token: 0x17003B2A RID: 15146
		// (get) Token: 0x0600E538 RID: 58680 RVA: 0x003496C1 File Offset: 0x003478C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E539 RID: 58681 RVA: 0x003496CE File Offset: 0x003478CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E53A RID: 58682 RVA: 0x003496D8 File Offset: 0x003478D8
		public static SpecialItem GetRootAsSpecialItem(ByteBuffer _bb)
		{
			return SpecialItem.GetRootAsSpecialItem(_bb, default(SpecialItem));
		}

		// Token: 0x0600E53B RID: 58683 RVA: 0x003496F4 File Offset: 0x003478F4
		public static SpecialItem GetRootAsSpecialItem(ByteBuffer _bb, SpecialItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E53C RID: 58684 RVA: 0x00349711 File Offset: 0x00347911
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E53D RID: 58685 RVA: 0x00349720 File Offset: 0x00347920
		public SpecialItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B2B RID: 15147
		// (get) Token: 0x0600E53E RID: 58686 RVA: 0x00349730 File Offset: 0x00347930
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

		// Token: 0x0600E53F RID: 58687 RVA: 0x0034976C File Offset: 0x0034796C
		public int UseButtonAdditionParam(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B2C RID: 15148
		// (get) Token: 0x0600E540 RID: 58688 RVA: 0x003497AC File Offset: 0x003479AC
		public int UseButtonAdditionParamLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E541 RID: 58689 RVA: 0x003497D7 File Offset: 0x003479D7
		public Span<int> GetUseButtonAdditionParamBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600E542 RID: 58690 RVA: 0x003497E6 File Offset: 0x003479E6
		public int[] GetUseButtonAdditionParamArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17003B2D RID: 15149
		// (get) Token: 0x0600E543 RID: 58691 RVA: 0x00349800 File Offset: 0x00347A00
		public int SpecialItemType
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

		// Token: 0x0600E544 RID: 58692 RVA: 0x0034983C File Offset: 0x00347A3C
		public string Parameters(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B2E RID: 15150
		// (get) Token: 0x0600E545 RID: 58693 RVA: 0x00349878 File Offset: 0x00347A78
		public int ParametersLength
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

		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x0600E546 RID: 58694 RVA: 0x003498A4 File Offset: 0x00347AA4
		public bool UseInMultiMode
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x0600E547 RID: 58695 RVA: 0x003498E4 File Offset: 0x00347AE4
		public bool UseInstance
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600E548 RID: 58696 RVA: 0x00349924 File Offset: 0x00347B24
		public string BanTags(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B31 RID: 15153
		// (get) Token: 0x0600E549 RID: 58697 RVA: 0x00349960 File Offset: 0x00347B60
		public int BanTagsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E54A RID: 58698 RVA: 0x0034998C File Offset: 0x00347B8C
		public string AllowTags(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x0600E54B RID: 58699 RVA: 0x003499C8 File Offset: 0x00347BC8
		public int AllowTagsLength
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

		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x0600E54C RID: 58700 RVA: 0x003499F4 File Offset: 0x00347BF4
		public int SummonConfigId
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

		// Token: 0x17003B34 RID: 15156
		// (get) Token: 0x0600E54D RID: 58701 RVA: 0x00349A34 File Offset: 0x00347C34
		public bool NeedShowNum
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003B35 RID: 15157
		// (get) Token: 0x0600E54E RID: 58702 RVA: 0x00349A74 File Offset: 0x00347C74
		public int PreviewModelId
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

		// Token: 0x17003B36 RID: 15158
		// (get) Token: 0x0600E54F RID: 58703 RVA: 0x00349AB4 File Offset: 0x00347CB4
		public string PreviewMontage
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E550 RID: 58704 RVA: 0x00349AEC File Offset: 0x00347CEC
		public Span<byte> GetPreviewMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600E551 RID: 58705 RVA: 0x00349AFC File Offset: 0x00347CFC
		public byte[] GetPreviewMontageArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E552 RID: 58706 RVA: 0x00349B14 File Offset: 0x00347D14
		[NullableContext(1)]
		public string[] AllowTags()
		{
			return this.AllowTagsIter().ToArray<string>();
		}

		// Token: 0x0600E553 RID: 58707 RVA: 0x00349B21 File Offset: 0x00347D21
		[NullableContext(1)]
		public IEnumerable<string> AllowTagsIter()
		{
			SpecialItem.<AllowTagsIter>d__41 <AllowTagsIter>d__ = new SpecialItem.<AllowTagsIter>d__41(-2);
			<AllowTagsIter>d__.<>3__<>4__this = this;
			return <AllowTagsIter>d__;
		}

		// Token: 0x0600E554 RID: 58708 RVA: 0x00349B36 File Offset: 0x00347D36
		[NullableContext(1)]
		public string[] BanTags()
		{
			return this.BanTagsIter().ToArray<string>();
		}

		// Token: 0x0600E555 RID: 58709 RVA: 0x00349B43 File Offset: 0x00347D43
		[NullableContext(1)]
		public IEnumerable<string> BanTagsIter()
		{
			SpecialItem.<BanTagsIter>d__43 <BanTagsIter>d__ = new SpecialItem.<BanTagsIter>d__43(-2);
			<BanTagsIter>d__.<>3__<>4__this = this;
			return <BanTagsIter>d__;
		}

		// Token: 0x0600E556 RID: 58710 RVA: 0x00349B58 File Offset: 0x00347D58
		[NullableContext(1)]
		public string[] Parameters()
		{
			return this.ParametersIter().ToArray<string>();
		}

		// Token: 0x0600E557 RID: 58711 RVA: 0x00349B65 File Offset: 0x00347D65
		[NullableContext(1)]
		public IEnumerable<string> ParametersIter()
		{
			SpecialItem.<ParametersIter>d__45 <ParametersIter>d__ = new SpecialItem.<ParametersIter>d__45(-2);
			<ParametersIter>d__.<>3__<>4__this = this;
			return <ParametersIter>d__;
		}

		// Token: 0x0600E558 RID: 58712 RVA: 0x00349B7A File Offset: 0x00347D7A
		[NullableContext(1)]
		public int[] UseButtonAdditionParam()
		{
			return this.GetUseButtonAdditionParamArray();
		}

		// Token: 0x0600E559 RID: 58713 RVA: 0x00349B82 File Offset: 0x00347D82
		[NullableContext(1)]
		public IEnumerable<int> UseButtonAdditionParamIter()
		{
			SpecialItem.<UseButtonAdditionParamIter>d__47 <UseButtonAdditionParamIter>d__ = new SpecialItem.<UseButtonAdditionParamIter>d__47(-2);
			<UseButtonAdditionParamIter>d__.<>3__<>4__this = this;
			return <UseButtonAdditionParamIter>d__;
		}

		// Token: 0x04005857 RID: 22615
		private Table __p;
	}
}

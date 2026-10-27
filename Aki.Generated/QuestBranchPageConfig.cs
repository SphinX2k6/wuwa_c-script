using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F67 RID: 3943
	public struct QuestBranchPageConfig : IFlatbufferObject
	{
		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x0600B511 RID: 46353 RVA: 0x002CECF9 File Offset: 0x002CCEF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B512 RID: 46354 RVA: 0x002CED06 File Offset: 0x002CCF06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B513 RID: 46355 RVA: 0x002CED10 File Offset: 0x002CCF10
		public static QuestBranchPageConfig GetRootAsQuestBranchPageConfig(ByteBuffer _bb)
		{
			return QuestBranchPageConfig.GetRootAsQuestBranchPageConfig(_bb, default(QuestBranchPageConfig));
		}

		// Token: 0x0600B514 RID: 46356 RVA: 0x002CED2C File Offset: 0x002CCF2C
		public static QuestBranchPageConfig GetRootAsQuestBranchPageConfig(ByteBuffer _bb, QuestBranchPageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B515 RID: 46357 RVA: 0x002CED49 File Offset: 0x002CCF49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B516 RID: 46358 RVA: 0x002CED58 File Offset: 0x002CCF58
		public QuestBranchPageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x0600B517 RID: 46359 RVA: 0x002CED68 File Offset: 0x002CCF68
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

		// Token: 0x0600B518 RID: 46360 RVA: 0x002CEDA4 File Offset: 0x002CCFA4
		public int Branch(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x0600B519 RID: 46361 RVA: 0x002CEDE4 File Offset: 0x002CCFE4
		public int BranchLength
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

		// Token: 0x0600B51A RID: 46362 RVA: 0x002CEE0F File Offset: 0x002CD00F
		public Span<int> GetBranchBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B51B RID: 46363 RVA: 0x002CEE1E File Offset: 0x002CD01E
		public int[] GetBranchArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600B51C RID: 46364 RVA: 0x002CEE38 File Offset: 0x002CD038
		public IntVector2D? QuestNodes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IntVector2D?(default(IntVector2D).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x0600B51D RID: 46365 RVA: 0x002CEE98 File Offset: 0x002CD098
		public int QuestNodesLength
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

		// Token: 0x0600B51E RID: 46366 RVA: 0x002CEEC4 File Offset: 0x002CD0C4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BranchIter()或GetBranchBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Branch()
		{
			QuestBranchPageConfig questBranchPageConfig = this;
			return questBranchPageConfig.GetBranchArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B51F RID: 46367 RVA: 0x002CEEE8 File Offset: 0x002CD0E8
		[NullableContext(1)]
		public readonly IEnumerable<int> BranchIter()
		{
			QuestBranchPageConfig.<BranchIter>d__19 <BranchIter>d__ = new QuestBranchPageConfig.<BranchIter>d__19(-2);
			<BranchIter>d__.<>3__<>4__this = this;
			return <BranchIter>d__;
		}

		// Token: 0x0600B520 RID: 46368 RVA: 0x002CEEFD File Offset: 0x002CD0FD
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QuestNodesIter()或GetQuestNodesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntVector2D[] QuestNodes()
		{
			return this.QuestNodesIter().ToArray<IntVector2D>();
		}

		// Token: 0x0600B521 RID: 46369 RVA: 0x002CEF0A File Offset: 0x002CD10A
		[NullableContext(1)]
		public readonly IEnumerable<IntVector2D> QuestNodesIter()
		{
			QuestBranchPageConfig.<QuestNodesIter>d__21 <QuestNodesIter>d__ = new QuestBranchPageConfig.<QuestNodesIter>d__21(-2);
			<QuestNodesIter>d__.<>3__<>4__this = this;
			return <QuestNodesIter>d__;
		}

		// Token: 0x04005035 RID: 20533
		private Table __p;
	}
}

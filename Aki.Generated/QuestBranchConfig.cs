using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F66 RID: 3942
	public struct QuestBranchConfig : IFlatbufferObject
	{
		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x0600B4F0 RID: 46320 RVA: 0x002CE8CD File Offset: 0x002CCACD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B4F1 RID: 46321 RVA: 0x002CE8DA File Offset: 0x002CCADA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B4F2 RID: 46322 RVA: 0x002CE8E4 File Offset: 0x002CCAE4
		public static QuestBranchConfig GetRootAsQuestBranchConfig(ByteBuffer _bb)
		{
			return QuestBranchConfig.GetRootAsQuestBranchConfig(_bb, default(QuestBranchConfig));
		}

		// Token: 0x0600B4F3 RID: 46323 RVA: 0x002CE900 File Offset: 0x002CCB00
		public static QuestBranchConfig GetRootAsQuestBranchConfig(ByteBuffer _bb, QuestBranchConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B4F4 RID: 46324 RVA: 0x002CE91D File Offset: 0x002CCB1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B4F5 RID: 46325 RVA: 0x002CE92C File Offset: 0x002CCB2C
		public QuestBranchConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x0600B4F6 RID: 46326 RVA: 0x002CE93C File Offset: 0x002CCB3C
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

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x0600B4F7 RID: 46327 RVA: 0x002CE978 File Offset: 0x002CCB78
		public int CompleteCondition
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

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x0600B4F8 RID: 46328 RVA: 0x002CE9B4 File Offset: 0x002CCBB4
		public string Icon
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

		// Token: 0x0600B4F9 RID: 46329 RVA: 0x002CE9EB File Offset: 0x002CCBEB
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B4FA RID: 46330 RVA: 0x002CE9FA File Offset: 0x002CCBFA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B4FB RID: 46331 RVA: 0x002CEA14 File Offset: 0x002CCC14
		public string Icons(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002B85 RID: 11141
		// (get) Token: 0x0600B4FC RID: 46332 RVA: 0x002CEA50 File Offset: 0x002CCC50
		public int IconsLength
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

		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x0600B4FD RID: 46333 RVA: 0x002CEA7C File Offset: 0x002CCC7C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4FE RID: 46334 RVA: 0x002CEAB4 File Offset: 0x002CCCB4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x002CEAC4 File Offset: 0x002CCCC4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x0600B500 RID: 46336 RVA: 0x002CEADC File Offset: 0x002CCCDC
		public string Desc
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

		// Token: 0x0600B501 RID: 46337 RVA: 0x002CEB14 File Offset: 0x002CCD14
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B502 RID: 46338 RVA: 0x002CEB24 File Offset: 0x002CCD24
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B503 RID: 46339 RVA: 0x002CEB3C File Offset: 0x002CCD3C
		public int ShownAreaRoute(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x0600B504 RID: 46340 RVA: 0x002CEB7C File Offset: 0x002CCD7C
		public int ShownAreaRouteLength
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

		// Token: 0x0600B505 RID: 46341 RVA: 0x002CEBA8 File Offset: 0x002CCDA8
		public Span<int> GetShownAreaRouteBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600B506 RID: 46342 RVA: 0x002CEBB8 File Offset: 0x002CCDB8
		public int[] GetShownAreaRouteArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600B507 RID: 46343 RVA: 0x002CEBD0 File Offset: 0x002CCDD0
		public int Component(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x0600B508 RID: 46344 RVA: 0x002CEC10 File Offset: 0x002CCE10
		public int ComponentLength
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

		// Token: 0x0600B509 RID: 46345 RVA: 0x002CEC3C File Offset: 0x002CCE3C
		public Span<int> GetComponentBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600B50A RID: 46346 RVA: 0x002CEC4C File Offset: 0x002CCE4C
		public int[] GetComponentArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600B50B RID: 46347 RVA: 0x002CEC64 File Offset: 0x002CCE64
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ComponentIter()或GetComponentBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Component()
		{
			QuestBranchConfig questBranchConfig = this;
			return questBranchConfig.GetComponentArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B50C RID: 46348 RVA: 0x002CEC88 File Offset: 0x002CCE88
		[NullableContext(1)]
		public readonly IEnumerable<int> ComponentIter()
		{
			QuestBranchConfig.<ComponentIter>d__38 <ComponentIter>d__ = new QuestBranchConfig.<ComponentIter>d__38(-2);
			<ComponentIter>d__.<>3__<>4__this = this;
			return <ComponentIter>d__;
		}

		// Token: 0x0600B50D RID: 46349 RVA: 0x002CEC9D File Offset: 0x002CCE9D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IconsIter()或GetIconsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Icons()
		{
			return this.IconsIter().ToArray<string>();
		}

		// Token: 0x0600B50E RID: 46350 RVA: 0x002CECAA File Offset: 0x002CCEAA
		[NullableContext(1)]
		public readonly IEnumerable<string> IconsIter()
		{
			QuestBranchConfig.<IconsIter>d__40 <IconsIter>d__ = new QuestBranchConfig.<IconsIter>d__40(-2);
			<IconsIter>d__.<>3__<>4__this = this;
			return <IconsIter>d__;
		}

		// Token: 0x0600B50F RID: 46351 RVA: 0x002CECC0 File Offset: 0x002CCEC0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShownAreaRouteIter()或GetShownAreaRouteBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShownAreaRoute()
		{
			QuestBranchConfig questBranchConfig = this;
			return questBranchConfig.GetShownAreaRouteArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B510 RID: 46352 RVA: 0x002CECE4 File Offset: 0x002CCEE4
		[NullableContext(1)]
		public readonly IEnumerable<int> ShownAreaRouteIter()
		{
			QuestBranchConfig.<ShownAreaRouteIter>d__42 <ShownAreaRouteIter>d__ = new QuestBranchConfig.<ShownAreaRouteIter>d__42(-2);
			<ShownAreaRouteIter>d__.<>3__<>4__this = this;
			return <ShownAreaRouteIter>d__;
		}

		// Token: 0x04005034 RID: 20532
		private Table __p;
	}
}

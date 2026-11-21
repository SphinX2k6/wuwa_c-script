using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200104D RID: 4173
	public struct QuestBranchConfig : IFlatbufferObject
	{
		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x0600BB2D RID: 47917 RVA: 0x002EB543 File Offset: 0x002E9743
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB2E RID: 47918 RVA: 0x002EB550 File Offset: 0x002E9750
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB2F RID: 47919 RVA: 0x002EB558 File Offset: 0x002E9758
		public static QuestBranchConfig GetRootAsQuestBranchConfig(ByteBuffer _bb)
		{
			return QuestBranchConfig.GetRootAsQuestBranchConfig(_bb, default(QuestBranchConfig));
		}

		// Token: 0x0600BB30 RID: 47920 RVA: 0x002EB574 File Offset: 0x002E9774
		public static QuestBranchConfig GetRootAsQuestBranchConfig(ByteBuffer _bb, QuestBranchConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB31 RID: 47921 RVA: 0x002EB591 File Offset: 0x002E9791
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB32 RID: 47922 RVA: 0x002EB5A0 File Offset: 0x002E97A0
		public QuestBranchConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x0600BB33 RID: 47923 RVA: 0x002EB5B0 File Offset: 0x002E97B0
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

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x0600BB34 RID: 47924 RVA: 0x002EB5EC File Offset: 0x002E97EC
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

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x0600BB35 RID: 47925 RVA: 0x002EB628 File Offset: 0x002E9828
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

		// Token: 0x0600BB36 RID: 47926 RVA: 0x002EB65F File Offset: 0x002E985F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BB37 RID: 47927 RVA: 0x002EB66E File Offset: 0x002E986E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BB38 RID: 47928 RVA: 0x002EB688 File Offset: 0x002E9888
		public string Icons(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x0600BB39 RID: 47929 RVA: 0x002EB6C4 File Offset: 0x002E98C4
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

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x0600BB3A RID: 47930 RVA: 0x002EB6F0 File Offset: 0x002E98F0
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

		// Token: 0x0600BB3B RID: 47931 RVA: 0x002EB728 File Offset: 0x002E9928
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BB3C RID: 47932 RVA: 0x002EB738 File Offset: 0x002E9938
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x0600BB3D RID: 47933 RVA: 0x002EB750 File Offset: 0x002E9950
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

		// Token: 0x0600BB3E RID: 47934 RVA: 0x002EB788 File Offset: 0x002E9988
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BB3F RID: 47935 RVA: 0x002EB798 File Offset: 0x002E9998
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BB40 RID: 47936 RVA: 0x002EB7B0 File Offset: 0x002E99B0
		public int ShownAreaRoute(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x0600BB41 RID: 47937 RVA: 0x002EB7F0 File Offset: 0x002E99F0
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

		// Token: 0x0600BB42 RID: 47938 RVA: 0x002EB81C File Offset: 0x002E9A1C
		public Span<int> GetShownAreaRouteBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600BB43 RID: 47939 RVA: 0x002EB82C File Offset: 0x002E9A2C
		public int[] GetShownAreaRouteArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600BB44 RID: 47940 RVA: 0x002EB844 File Offset: 0x002E9A44
		public int Component(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x0600BB45 RID: 47941 RVA: 0x002EB884 File Offset: 0x002E9A84
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

		// Token: 0x0600BB46 RID: 47942 RVA: 0x002EB8B0 File Offset: 0x002E9AB0
		public Span<int> GetComponentBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600BB47 RID: 47943 RVA: 0x002EB8C0 File Offset: 0x002E9AC0
		public int[] GetComponentArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600BB48 RID: 47944 RVA: 0x002EB8D8 File Offset: 0x002E9AD8
		[NullableContext(1)]
		public int[] Component()
		{
			return this.GetComponentArray();
		}

		// Token: 0x0600BB49 RID: 47945 RVA: 0x002EB8E0 File Offset: 0x002E9AE0
		[NullableContext(1)]
		public IEnumerable<int> ComponentIter()
		{
			QuestBranchConfig.<ComponentIter>d__38 <ComponentIter>d__ = new QuestBranchConfig.<ComponentIter>d__38(-2);
			<ComponentIter>d__.<>3__<>4__this = this;
			return <ComponentIter>d__;
		}

		// Token: 0x0600BB4A RID: 47946 RVA: 0x002EB8F5 File Offset: 0x002E9AF5
		[NullableContext(1)]
		public string[] Icons()
		{
			return this.IconsIter().ToArray<string>();
		}

		// Token: 0x0600BB4B RID: 47947 RVA: 0x002EB902 File Offset: 0x002E9B02
		[NullableContext(1)]
		public IEnumerable<string> IconsIter()
		{
			QuestBranchConfig.<IconsIter>d__40 <IconsIter>d__ = new QuestBranchConfig.<IconsIter>d__40(-2);
			<IconsIter>d__.<>3__<>4__this = this;
			return <IconsIter>d__;
		}

		// Token: 0x0600BB4C RID: 47948 RVA: 0x002EB917 File Offset: 0x002E9B17
		[NullableContext(1)]
		public int[] ShownAreaRoute()
		{
			return this.GetShownAreaRouteArray();
		}

		// Token: 0x0600BB4D RID: 47949 RVA: 0x002EB91F File Offset: 0x002E9B1F
		[NullableContext(1)]
		public IEnumerable<int> ShownAreaRouteIter()
		{
			QuestBranchConfig.<ShownAreaRouteIter>d__42 <ShownAreaRouteIter>d__ = new QuestBranchConfig.<ShownAreaRouteIter>d__42(-2);
			<ShownAreaRouteIter>d__.<>3__<>4__this = this;
			return <ShownAreaRouteIter>d__;
		}

		// Token: 0x0400561B RID: 22043
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC0 RID: 3520
	public struct LevelEntityConfig : IFlatbufferObject
	{
		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06008D5D RID: 36189 RVA: 0x00276365 File Offset: 0x00274565
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D5E RID: 36190 RVA: 0x00276372 File Offset: 0x00274572
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D5F RID: 36191 RVA: 0x0027637C File Offset: 0x0027457C
		public static LevelEntityConfig GetRootAsLevelEntityConfig(ByteBuffer _bb)
		{
			return LevelEntityConfig.GetRootAsLevelEntityConfig(_bb, default(LevelEntityConfig));
		}

		// Token: 0x06008D60 RID: 36192 RVA: 0x00276398 File Offset: 0x00274598
		public static LevelEntityConfig GetRootAsLevelEntityConfig(ByteBuffer _bb, LevelEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D61 RID: 36193 RVA: 0x002763B5 File Offset: 0x002745B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D62 RID: 36194 RVA: 0x002763C4 File Offset: 0x002745C4
		public LevelEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x06008D63 RID: 36195 RVA: 0x002763D4 File Offset: 0x002745D4
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

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x06008D64 RID: 36196 RVA: 0x00276410 File Offset: 0x00274610
		public int MapId
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

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x06008D65 RID: 36197 RVA: 0x0027644C File Offset: 0x0027464C
		public int EntityId
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

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x06008D66 RID: 36198 RVA: 0x00276488 File Offset: 0x00274688
		public string BlueprintType
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

		// Token: 0x06008D67 RID: 36199 RVA: 0x002764C0 File Offset: 0x002746C0
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008D68 RID: 36200 RVA: 0x002764D0 File Offset: 0x002746D0
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06008D69 RID: 36201 RVA: 0x002764E8 File Offset: 0x002746E8
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

		// Token: 0x06008D6A RID: 36202 RVA: 0x00276520 File Offset: 0x00274720
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008D6B RID: 36203 RVA: 0x00276530 File Offset: 0x00274730
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x06008D6C RID: 36204 RVA: 0x00276548 File Offset: 0x00274748
		public bool InSleep
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06008D6D RID: 36205 RVA: 0x00276588 File Offset: 0x00274788
		public bool IsHidden
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06008D6E RID: 36206 RVA: 0x002765C8 File Offset: 0x002747C8
		public int AreaId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06008D6F RID: 36207 RVA: 0x00276608 File Offset: 0x00274808
		public bool IsScaleEnabled
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008D70 RID: 36208 RVA: 0x00276648 File Offset: 0x00274848
		public IntVector? Transform(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new IntVector?(default(IntVector).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06008D71 RID: 36209 RVA: 0x002766AC File Offset: 0x002748AC
		public int TransformLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06008D72 RID: 36210 RVA: 0x002766D8 File Offset: 0x002748D8
		public string ComponentsData
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

		// Token: 0x06008D73 RID: 36211 RVA: 0x00276710 File Offset: 0x00274910
		public Span<byte> GetComponentsDataBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008D74 RID: 36212 RVA: 0x00276720 File Offset: 0x00274920
		public byte[] GetComponentsDataArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06008D75 RID: 36213 RVA: 0x00276738 File Offset: 0x00274938
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TransformIter()或GetTransformBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntVector[] Transform()
		{
			return this.TransformIter().ToArray<IntVector>();
		}

		// Token: 0x06008D76 RID: 36214 RVA: 0x00276745 File Offset: 0x00274945
		[NullableContext(1)]
		public readonly IEnumerable<IntVector> TransformIter()
		{
			LevelEntityConfig.<TransformIter>d__38 <TransformIter>d__ = new LevelEntityConfig.<TransformIter>d__38(-2);
			<TransformIter>d__.<>3__<>4__this = this;
			return <TransformIter>d__;
		}

		// Token: 0x04004E56 RID: 20054
		private Table __p;
	}
}

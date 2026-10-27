using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B5E RID: 2910
	public struct CalabashMesh : IFlatbufferObject
	{
		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06005213 RID: 21011 RVA: 0x001EE9BE File Offset: 0x001ECBBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005214 RID: 21012 RVA: 0x001EE9CB File Offset: 0x001ECBCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005215 RID: 21013 RVA: 0x001EE9D4 File Offset: 0x001ECBD4
		public static CalabashMesh GetRootAsCalabashMesh(ByteBuffer _bb)
		{
			return CalabashMesh.GetRootAsCalabashMesh(_bb, default(CalabashMesh));
		}

		// Token: 0x06005216 RID: 21014 RVA: 0x001EE9F0 File Offset: 0x001ECBF0
		public static CalabashMesh GetRootAsCalabashMesh(ByteBuffer _bb, CalabashMesh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005217 RID: 21015 RVA: 0x001EEA0D File Offset: 0x001ECC0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005218 RID: 21016 RVA: 0x001EEA1C File Offset: 0x001ECC1C
		public CalabashMesh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06005219 RID: 21017 RVA: 0x001EEA2C File Offset: 0x001ECC2C
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

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600521A RID: 21018 RVA: 0x001EEA68 File Offset: 0x001ECC68
		public int MeshId
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

		// Token: 0x0600521B RID: 21019 RVA: 0x001EEAA4 File Offset: 0x001ECCA4
		public string OldEffects(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600521C RID: 21020 RVA: 0x001EEAE0 File Offset: 0x001ECCE0
		public int OldEffectsLength
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

		// Token: 0x0600521D RID: 21021 RVA: 0x001EEB0C File Offset: 0x001ECD0C
		public string NewEffects(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x0600521E RID: 21022 RVA: 0x001EEB48 File Offset: 0x001ECD48
		public int NewEffectsLength
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

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x0600521F RID: 21023 RVA: 0x001EEB74 File Offset: 0x001ECD74
		public int HideParaglider
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x001EEBB1 File Offset: 0x001ECDB1
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NewEffectsIter()或GetNewEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] NewEffects()
		{
			return this.NewEffectsIter().ToArray<string>();
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x001EEBBE File Offset: 0x001ECDBE
		[NullableContext(1)]
		public readonly IEnumerable<string> NewEffectsIter()
		{
			CalabashMesh.<NewEffectsIter>d__21 <NewEffectsIter>d__ = new CalabashMesh.<NewEffectsIter>d__21(-2);
			<NewEffectsIter>d__.<>3__<>4__this = this;
			return <NewEffectsIter>d__;
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x001EEBD3 File Offset: 0x001ECDD3
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OldEffectsIter()或GetOldEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] OldEffects()
		{
			return this.OldEffectsIter().ToArray<string>();
		}

		// Token: 0x06005223 RID: 21027 RVA: 0x001EEBE0 File Offset: 0x001ECDE0
		[NullableContext(1)]
		public readonly IEnumerable<string> OldEffectsIter()
		{
			CalabashMesh.<OldEffectsIter>d__23 <OldEffectsIter>d__ = new CalabashMesh.<OldEffectsIter>d__23(-2);
			<OldEffectsIter>d__.<>3__<>4__this = this;
			return <OldEffectsIter>d__;
		}

		// Token: 0x04004B5E RID: 19294
		private Table __p;
	}
}

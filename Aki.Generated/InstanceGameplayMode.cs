using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D73 RID: 3443
	public struct InstanceGameplayMode : IFlatbufferObject
	{
		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x0600858A RID: 34186 RVA: 0x0026428C File Offset: 0x0026248C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600858B RID: 34187 RVA: 0x00264299 File Offset: 0x00262499
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600858C RID: 34188 RVA: 0x002642A0 File Offset: 0x002624A0
		public static InstanceGameplayMode GetRootAsInstanceGameplayMode(ByteBuffer _bb)
		{
			return InstanceGameplayMode.GetRootAsInstanceGameplayMode(_bb, default(InstanceGameplayMode));
		}

		// Token: 0x0600858D RID: 34189 RVA: 0x002642BC File Offset: 0x002624BC
		public static InstanceGameplayMode GetRootAsInstanceGameplayMode(ByteBuffer _bb, InstanceGameplayMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600858E RID: 34190 RVA: 0x002642D9 File Offset: 0x002624D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600858F RID: 34191 RVA: 0x002642E8 File Offset: 0x002624E8
		public InstanceGameplayMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06008590 RID: 34192 RVA: 0x002642F8 File Offset: 0x002624F8
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

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06008591 RID: 34193 RVA: 0x00264334 File Offset: 0x00262534
		public bool DisableAllPlayerRole
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06008592 RID: 34194 RVA: 0x00264374 File Offset: 0x00262574
		public int DefaultCameraMode
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

		// Token: 0x06008593 RID: 34195 RVA: 0x002643B0 File Offset: 0x002625B0
		public int CameraParams(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06008594 RID: 34196 RVA: 0x002643F0 File Offset: 0x002625F0
		public int CameraParamsLength
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

		// Token: 0x06008595 RID: 34197 RVA: 0x0026441C File Offset: 0x0026261C
		public Span<int> GetCameraParamsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008596 RID: 34198 RVA: 0x0026442C File Offset: 0x0026262C
		public int[] GetCameraParamsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06008597 RID: 34199 RVA: 0x00264444 File Offset: 0x00262644
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CameraParamsIter()或GetCameraParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CameraParams()
		{
			InstanceGameplayMode instanceGameplayMode = this;
			return instanceGameplayMode.GetCameraParamsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008598 RID: 34200 RVA: 0x00264468 File Offset: 0x00262668
		[NullableContext(1)]
		public readonly IEnumerable<int> CameraParamsIter()
		{
			InstanceGameplayMode.<CameraParamsIter>d__20 <CameraParamsIter>d__ = new InstanceGameplayMode.<CameraParamsIter>d__20(-2);
			<CameraParamsIter>d__.<>3__<>4__this = this;
			return <CameraParamsIter>d__;
		}

		// Token: 0x04004DFB RID: 19963
		private Table __p;
	}
}

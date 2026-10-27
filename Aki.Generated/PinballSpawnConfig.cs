using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F39 RID: 3897
	public struct PinballSpawnConfig : IFlatbufferObject
	{
		// Token: 0x170029DE RID: 10718
		// (get) Token: 0x0600B061 RID: 45153 RVA: 0x002C5032 File Offset: 0x002C3232
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B062 RID: 45154 RVA: 0x002C503F File Offset: 0x002C323F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x002C5048 File Offset: 0x002C3248
		public static PinballSpawnConfig GetRootAsPinballSpawnConfig(ByteBuffer _bb)
		{
			return PinballSpawnConfig.GetRootAsPinballSpawnConfig(_bb, default(PinballSpawnConfig));
		}

		// Token: 0x0600B064 RID: 45156 RVA: 0x002C5064 File Offset: 0x002C3264
		public static PinballSpawnConfig GetRootAsPinballSpawnConfig(ByteBuffer _bb, PinballSpawnConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x002C5081 File Offset: 0x002C3281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B066 RID: 45158 RVA: 0x002C5090 File Offset: 0x002C3290
		public PinballSpawnConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029DF RID: 10719
		// (get) Token: 0x0600B067 RID: 45159 RVA: 0x002C50A0 File Offset: 0x002C32A0
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

		// Token: 0x0600B068 RID: 45160 RVA: 0x002C50DC File Offset: 0x002C32DC
		public int MonsterIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029E0 RID: 10720
		// (get) Token: 0x0600B069 RID: 45161 RVA: 0x002C511C File Offset: 0x002C331C
		public int MonsterIdsLength
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

		// Token: 0x0600B06A RID: 45162 RVA: 0x002C5147 File Offset: 0x002C3347
		public Span<int> GetMonsterIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B06B RID: 45163 RVA: 0x002C5156 File Offset: 0x002C3356
		public int[] GetMonsterIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600B06C RID: 45164 RVA: 0x002C5170 File Offset: 0x002C3370
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterIdsIter()或GetMonsterIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MonsterIds()
		{
			PinballSpawnConfig pinballSpawnConfig = this;
			return pinballSpawnConfig.GetMonsterIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B06D RID: 45165 RVA: 0x002C5194 File Offset: 0x002C3394
		[NullableContext(1)]
		public readonly IEnumerable<int> MonsterIdsIter()
		{
			PinballSpawnConfig.<MonsterIdsIter>d__16 <MonsterIdsIter>d__ = new PinballSpawnConfig.<MonsterIdsIter>d__16(-2);
			<MonsterIdsIter>d__.<>3__<>4__this = this;
			return <MonsterIdsIter>d__;
		}

		// Token: 0x04005003 RID: 20483
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E19 RID: 3609
	public struct HonamiStoryEffect : IFlatbufferObject
	{
		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06008582 RID: 34178 RVA: 0x00274D88 File Offset: 0x00272F88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008583 RID: 34179 RVA: 0x00274D95 File Offset: 0x00272F95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008584 RID: 34180 RVA: 0x00274D9C File Offset: 0x00272F9C
		public static HonamiStoryEffect GetRootAsHonamiStoryEffect(ByteBuffer _bb)
		{
			return HonamiStoryEffect.GetRootAsHonamiStoryEffect(_bb, default(HonamiStoryEffect));
		}

		// Token: 0x06008585 RID: 34181 RVA: 0x00274DB8 File Offset: 0x00272FB8
		public static HonamiStoryEffect GetRootAsHonamiStoryEffect(ByteBuffer _bb, HonamiStoryEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008586 RID: 34182 RVA: 0x00274DD5 File Offset: 0x00272FD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008587 RID: 34183 RVA: 0x00274DE4 File Offset: 0x00272FE4
		public HonamiStoryEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06008588 RID: 34184 RVA: 0x00274DF4 File Offset: 0x00272FF4
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

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06008589 RID: 34185 RVA: 0x00274E30 File Offset: 0x00273030
		public int EffectType
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

		// Token: 0x0600858A RID: 34186 RVA: 0x00274E6C File Offset: 0x0027306C
		public string Param(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x0600858B RID: 34187 RVA: 0x00274EA8 File Offset: 0x002730A8
		public int ParamLength
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

		// Token: 0x0600858C RID: 34188 RVA: 0x00274ED3 File Offset: 0x002730D3
		[NullableContext(1)]
		public string[] Param()
		{
			return this.ParamIter().ToArray<string>();
		}

		// Token: 0x0600858D RID: 34189 RVA: 0x00274EE0 File Offset: 0x002730E0
		[NullableContext(1)]
		public IEnumerable<string> ParamIter()
		{
			HonamiStoryEffect.<ParamIter>d__16 <ParamIter>d__ = new HonamiStoryEffect.<ParamIter>d__16(-2);
			<ParamIter>d__.<>3__<>4__this = this;
			return <ParamIter>d__;
		}

		// Token: 0x04005393 RID: 21395
		private Table __p;
	}
}

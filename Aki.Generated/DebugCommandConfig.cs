using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC6 RID: 3270
	public struct DebugCommandConfig : IFlatbufferObject
	{
		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x0600670C RID: 26380 RVA: 0x0023098C File Offset: 0x0022EB8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600670D RID: 26381 RVA: 0x00230999 File Offset: 0x0022EB99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600670E RID: 26382 RVA: 0x002309A0 File Offset: 0x0022EBA0
		public static DebugCommandConfig GetRootAsDebugCommandConfig(ByteBuffer _bb)
		{
			return DebugCommandConfig.GetRootAsDebugCommandConfig(_bb, default(DebugCommandConfig));
		}

		// Token: 0x0600670F RID: 26383 RVA: 0x002309BC File Offset: 0x0022EBBC
		public static DebugCommandConfig GetRootAsDebugCommandConfig(ByteBuffer _bb, DebugCommandConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006710 RID: 26384 RVA: 0x002309D9 File Offset: 0x0022EBD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006711 RID: 26385 RVA: 0x002309E8 File Offset: 0x0022EBE8
		public DebugCommandConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06006712 RID: 26386 RVA: 0x002309F8 File Offset: 0x0022EBF8
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

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06006713 RID: 26387 RVA: 0x00230A34 File Offset: 0x0022EC34
		public int GetTargetStage
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

		// Token: 0x06006714 RID: 26388 RVA: 0x00230A70 File Offset: 0x0022EC70
		public string ParamGetTarget(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06006715 RID: 26389 RVA: 0x00230AAC File Offset: 0x0022ECAC
		public int ParamGetTargetLength
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

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06006716 RID: 26390 RVA: 0x00230AD8 File Offset: 0x0022ECD8
		public int EffectStage
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

		// Token: 0x06006717 RID: 26391 RVA: 0x00230B18 File Offset: 0x0022ED18
		public string ParamEffect(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06006718 RID: 26392 RVA: 0x00230B54 File Offset: 0x0022ED54
		public int ParamEffectLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006719 RID: 26393 RVA: 0x00230B80 File Offset: 0x0022ED80
		[NullableContext(1)]
		public string[] ParamEffect()
		{
			return this.ParamEffectIter().ToArray<string>();
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x00230B8D File Offset: 0x0022ED8D
		[NullableContext(1)]
		public IEnumerable<string> ParamEffectIter()
		{
			DebugCommandConfig.<ParamEffectIter>d__21 <ParamEffectIter>d__ = new DebugCommandConfig.<ParamEffectIter>d__21(-2);
			<ParamEffectIter>d__.<>3__<>4__this = this;
			return <ParamEffectIter>d__;
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x00230BA2 File Offset: 0x0022EDA2
		[NullableContext(1)]
		public string[] ParamGetTarget()
		{
			return this.ParamGetTargetIter().ToArray<string>();
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x00230BAF File Offset: 0x0022EDAF
		[NullableContext(1)]
		public IEnumerable<string> ParamGetTargetIter()
		{
			DebugCommandConfig.<ParamGetTargetIter>d__23 <ParamGetTargetIter>d__ = new DebugCommandConfig.<ParamGetTargetIter>d__23(-2);
			<ParamGetTargetIter>d__.<>3__<>4__this = this;
			return <ParamGetTargetIter>d__;
		}

		// Token: 0x040051F3 RID: 20979
		private Table __p;
	}
}

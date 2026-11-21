using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200100B RID: 4107
	public struct PinballCommonItem : IFlatbufferObject
	{
		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x0600B499 RID: 46233 RVA: 0x002DD578 File Offset: 0x002DB778
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B49A RID: 46234 RVA: 0x002DD585 File Offset: 0x002DB785
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B49B RID: 46235 RVA: 0x002DD58C File Offset: 0x002DB78C
		public static PinballCommonItem GetRootAsPinballCommonItem(ByteBuffer _bb)
		{
			return PinballCommonItem.GetRootAsPinballCommonItem(_bb, default(PinballCommonItem));
		}

		// Token: 0x0600B49C RID: 46236 RVA: 0x002DD5A8 File Offset: 0x002DB7A8
		public static PinballCommonItem GetRootAsPinballCommonItem(ByteBuffer _bb, PinballCommonItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B49D RID: 46237 RVA: 0x002DD5C5 File Offset: 0x002DB7C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B49E RID: 46238 RVA: 0x002DD5D4 File Offset: 0x002DB7D4
		public PinballCommonItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x0600B49F RID: 46239 RVA: 0x002DD5E4 File Offset: 0x002DB7E4
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

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x0600B4A0 RID: 46240 RVA: 0x002DD620 File Offset: 0x002DB820
		public int DataId
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

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x0600B4A1 RID: 46241 RVA: 0x002DD65C File Offset: 0x002DB85C
		public int TemplateId
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

		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x0600B4A2 RID: 46242 RVA: 0x002DD698 File Offset: 0x002DB898
		public int SimpleCombatSubtypeId
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

		// Token: 0x0600B4A3 RID: 46243 RVA: 0x002DD6D8 File Offset: 0x002DB8D8
		public int AbsorbEffects(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002984 RID: 10628
		// (get) Token: 0x0600B4A4 RID: 46244 RVA: 0x002DD718 File Offset: 0x002DB918
		public int AbsorbEffectsLength
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

		// Token: 0x0600B4A5 RID: 46245 RVA: 0x002DD744 File Offset: 0x002DB944
		public Span<int> GetAbsorbEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600B4A6 RID: 46246 RVA: 0x002DD754 File Offset: 0x002DB954
		public int[] GetAbsorbEffectsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17002985 RID: 10629
		// (get) Token: 0x0600B4A7 RID: 46247 RVA: 0x002DD76C File Offset: 0x002DB96C
		public int ContentType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x0600B4A8 RID: 46248 RVA: 0x002DD7AC File Offset: 0x002DB9AC
		public int Deathrattle
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4A9 RID: 46249 RVA: 0x002DD7E9 File Offset: 0x002DB9E9
		[NullableContext(1)]
		public int[] AbsorbEffects()
		{
			return this.GetAbsorbEffectsArray();
		}

		// Token: 0x0600B4AA RID: 46250 RVA: 0x002DD7F1 File Offset: 0x002DB9F1
		[NullableContext(1)]
		public IEnumerable<int> AbsorbEffectsIter()
		{
			PinballCommonItem.<AbsorbEffectsIter>d__26 <AbsorbEffectsIter>d__ = new PinballCommonItem.<AbsorbEffectsIter>d__26(-2);
			<AbsorbEffectsIter>d__.<>3__<>4__this = this;
			return <AbsorbEffectsIter>d__;
		}

		// Token: 0x040055D4 RID: 21972
		private Table __p;
	}
}

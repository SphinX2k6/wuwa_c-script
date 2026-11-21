using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D6B RID: 3435
	public struct FishingPosition : IFlatbufferObject
	{
		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x0600760B RID: 30219 RVA: 0x00251E59 File Offset: 0x00250059
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600760C RID: 30220 RVA: 0x00251E66 File Offset: 0x00250066
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600760D RID: 30221 RVA: 0x00251E70 File Offset: 0x00250070
		public static FishingPosition GetRootAsFishingPosition(ByteBuffer _bb)
		{
			return FishingPosition.GetRootAsFishingPosition(_bb, default(FishingPosition));
		}

		// Token: 0x0600760E RID: 30222 RVA: 0x00251E8C File Offset: 0x0025008C
		public static FishingPosition GetRootAsFishingPosition(ByteBuffer _bb, FishingPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x00251EA9 File Offset: 0x002500A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x00251EB8 File Offset: 0x002500B8
		public FishingPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x06007611 RID: 30225 RVA: 0x00251EC8 File Offset: 0x002500C8
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

		// Token: 0x06007612 RID: 30226 RVA: 0x00251F04 File Offset: 0x00250104
		public int Position(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x06007613 RID: 30227 RVA: 0x00251F44 File Offset: 0x00250144
		public int PositionLength
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

		// Token: 0x06007614 RID: 30228 RVA: 0x00251F6F File Offset: 0x0025016F
		public Span<int> GetPositionBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06007615 RID: 30229 RVA: 0x00251F7E File Offset: 0x0025017E
		public int[] GetPositionArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x00251F98 File Offset: 0x00250198
		public int Rotation(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x06007617 RID: 30231 RVA: 0x00251FD8 File Offset: 0x002501D8
		public int RotationLength
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

		// Token: 0x06007618 RID: 30232 RVA: 0x00252003 File Offset: 0x00250203
		public Span<int> GetRotationBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007619 RID: 30233 RVA: 0x00252012 File Offset: 0x00250212
		public int[] GetRotationArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600761A RID: 30234 RVA: 0x00252029 File Offset: 0x00250229
		[NullableContext(1)]
		public int[] Position()
		{
			return this.GetPositionArray();
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x00252031 File Offset: 0x00250231
		[NullableContext(1)]
		public IEnumerable<int> PositionIter()
		{
			FishingPosition.<PositionIter>d__21 <PositionIter>d__ = new FishingPosition.<PositionIter>d__21(-2);
			<PositionIter>d__.<>3__<>4__this = this;
			return <PositionIter>d__;
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x00252046 File Offset: 0x00250246
		[NullableContext(1)]
		public int[] Rotation()
		{
			return this.GetRotationArray();
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x0025204E File Offset: 0x0025024E
		[NullableContext(1)]
		public IEnumerable<int> RotationIter()
		{
			FishingPosition.<RotationIter>d__23 <RotationIter>d__ = new FishingPosition.<RotationIter>d__23(-2);
			<RotationIter>d__.<>3__<>4__this = this;
			return <RotationIter>d__;
		}

		// Token: 0x040052BD RID: 21181
		private Table __p;
	}
}

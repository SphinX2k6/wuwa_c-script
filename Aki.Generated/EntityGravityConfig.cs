using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D18 RID: 3352
	public struct EntityGravityConfig : IFlatbufferObject
	{
		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06006F72 RID: 28530 RVA: 0x00242FB9 File Offset: 0x002411B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F73 RID: 28531 RVA: 0x00242FC6 File Offset: 0x002411C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F74 RID: 28532 RVA: 0x00242FD0 File Offset: 0x002411D0
		public static EntityGravityConfig GetRootAsEntityGravityConfig(ByteBuffer _bb)
		{
			return EntityGravityConfig.GetRootAsEntityGravityConfig(_bb, default(EntityGravityConfig));
		}

		// Token: 0x06006F75 RID: 28533 RVA: 0x00242FEC File Offset: 0x002411EC
		public static EntityGravityConfig GetRootAsEntityGravityConfig(ByteBuffer _bb, EntityGravityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F76 RID: 28534 RVA: 0x00243009 File Offset: 0x00241209
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x00243018 File Offset: 0x00241218
		public EntityGravityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06006F78 RID: 28536 RVA: 0x00243028 File Offset: 0x00241228
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

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06006F79 RID: 28537 RVA: 0x00243064 File Offset: 0x00241264
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

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06006F7A RID: 28538 RVA: 0x002430A0 File Offset: 0x002412A0
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

		// Token: 0x06006F7B RID: 28539 RVA: 0x002430DC File Offset: 0x002412DC
		public float GravityDirection(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06006F7C RID: 28540 RVA: 0x00243120 File Offset: 0x00241320
		public int GravityDirectionLength
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

		// Token: 0x06006F7D RID: 28541 RVA: 0x0024314C File Offset: 0x0024134C
		public Span<float> GetGravityDirectionBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x0024315C File Offset: 0x0024135C
		public float[] GetGravityDirectionArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x00243174 File Offset: 0x00241374
		[NullableContext(1)]
		public float[] GravityDirection()
		{
			return this.GetGravityDirectionArray();
		}

		// Token: 0x06006F80 RID: 28544 RVA: 0x0024317C File Offset: 0x0024137C
		[NullableContext(1)]
		public IEnumerable<float> GravityDirectionIter()
		{
			EntityGravityConfig.<GravityDirectionIter>d__20 <GravityDirectionIter>d__ = new EntityGravityConfig.<GravityDirectionIter>d__20(-2);
			<GravityDirectionIter>d__.<>3__<>4__this = this;
			return <GravityDirectionIter>d__;
		}

		// Token: 0x04005258 RID: 21080
		private Table __p;
	}
}

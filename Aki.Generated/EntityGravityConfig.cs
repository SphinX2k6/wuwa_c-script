using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C35 RID: 3125
	public struct EntityGravityConfig : IFlatbufferObject
	{
		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06006970 RID: 26992 RVA: 0x00223C55 File Offset: 0x00221E55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006971 RID: 26993 RVA: 0x00223C62 File Offset: 0x00221E62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006972 RID: 26994 RVA: 0x00223C6C File Offset: 0x00221E6C
		public static EntityGravityConfig GetRootAsEntityGravityConfig(ByteBuffer _bb)
		{
			return EntityGravityConfig.GetRootAsEntityGravityConfig(_bb, default(EntityGravityConfig));
		}

		// Token: 0x06006973 RID: 26995 RVA: 0x00223C88 File Offset: 0x00221E88
		public static EntityGravityConfig GetRootAsEntityGravityConfig(ByteBuffer _bb, EntityGravityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006974 RID: 26996 RVA: 0x00223CA5 File Offset: 0x00221EA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006975 RID: 26997 RVA: 0x00223CB4 File Offset: 0x00221EB4
		public EntityGravityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06006976 RID: 26998 RVA: 0x00223CC4 File Offset: 0x00221EC4
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

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06006977 RID: 26999 RVA: 0x00223D00 File Offset: 0x00221F00
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

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06006978 RID: 27000 RVA: 0x00223D3C File Offset: 0x00221F3C
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

		// Token: 0x06006979 RID: 27001 RVA: 0x00223D78 File Offset: 0x00221F78
		public float GravityDirection(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x0600697A RID: 27002 RVA: 0x00223DBC File Offset: 0x00221FBC
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

		// Token: 0x0600697B RID: 27003 RVA: 0x00223DE8 File Offset: 0x00221FE8
		public Span<float> GetGravityDirectionBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x00223DF8 File Offset: 0x00221FF8
		public float[] GetGravityDirectionArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x00223E10 File Offset: 0x00222010
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GravityDirectionIter()或GetGravityDirectionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] GravityDirection()
		{
			EntityGravityConfig entityGravityConfig = this;
			return entityGravityConfig.GetGravityDirectionArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x00223E34 File Offset: 0x00222034
		[NullableContext(1)]
		public readonly IEnumerable<float> GravityDirectionIter()
		{
			EntityGravityConfig.<GravityDirectionIter>d__20 <GravityDirectionIter>d__ = new EntityGravityConfig.<GravityDirectionIter>d__20(-2);
			<GravityDirectionIter>d__.<>3__<>4__this = this;
			return <GravityDirectionIter>d__;
		}

		// Token: 0x04004C75 RID: 19573
		private Table __p;
	}
}

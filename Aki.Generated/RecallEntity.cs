using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001086 RID: 4230
	public struct RecallEntity : IFlatbufferObject
	{
		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x0600C018 RID: 49176 RVA: 0x002F5D10 File Offset: 0x002F3F10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C019 RID: 49177 RVA: 0x002F5D1D File Offset: 0x002F3F1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C01A RID: 49178 RVA: 0x002F5D24 File Offset: 0x002F3F24
		public static RecallEntity GetRootAsRecallEntity(ByteBuffer _bb)
		{
			return RecallEntity.GetRootAsRecallEntity(_bb, default(RecallEntity));
		}

		// Token: 0x0600C01B RID: 49179 RVA: 0x002F5D40 File Offset: 0x002F3F40
		public static RecallEntity GetRootAsRecallEntity(ByteBuffer _bb, RecallEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C01C RID: 49180 RVA: 0x002F5D5D File Offset: 0x002F3F5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C01D RID: 49181 RVA: 0x002F5D6C File Offset: 0x002F3F6C
		public RecallEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x0600C01E RID: 49182 RVA: 0x002F5D7C File Offset: 0x002F3F7C
		public int RecallId
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

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x0600C01F RID: 49183 RVA: 0x002F5DB8 File Offset: 0x002F3FB8
		public int InstanceId
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

		// Token: 0x0600C020 RID: 49184 RVA: 0x002F5DF4 File Offset: 0x002F3FF4
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x0600C021 RID: 49185 RVA: 0x002F5E34 File Offset: 0x002F4034
		public int EntityIdsLength
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

		// Token: 0x0600C022 RID: 49186 RVA: 0x002F5E5F File Offset: 0x002F405F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C023 RID: 49187 RVA: 0x002F5E6E File Offset: 0x002F406E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C024 RID: 49188 RVA: 0x002F5E85 File Offset: 0x002F4085
		[NullableContext(1)]
		public int[] EntityIds()
		{
			return this.GetEntityIdsArray();
		}

		// Token: 0x0600C025 RID: 49189 RVA: 0x002F5E8D File Offset: 0x002F408D
		[NullableContext(1)]
		public IEnumerable<int> EntityIdsIter()
		{
			RecallEntity.<EntityIdsIter>d__18 <EntityIdsIter>d__ = new RecallEntity.<EntityIdsIter>d__18(-2);
			<EntityIdsIter>d__.<>3__<>4__this = this;
			return <EntityIdsIter>d__;
		}

		// Token: 0x04005659 RID: 22105
		private Table __p;
	}
}

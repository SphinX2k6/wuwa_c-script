using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001264 RID: 4708
	public struct TimePointRewardConfig : IFlatbufferObject
	{
		// Token: 0x17003DD8 RID: 15832
		// (get) Token: 0x0600EC50 RID: 60496 RVA: 0x0035965C File Offset: 0x0035785C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EC51 RID: 60497 RVA: 0x00359669 File Offset: 0x00357869
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EC52 RID: 60498 RVA: 0x00359670 File Offset: 0x00357870
		public static TimePointRewardConfig GetRootAsTimePointRewardConfig(ByteBuffer _bb)
		{
			return TimePointRewardConfig.GetRootAsTimePointRewardConfig(_bb, default(TimePointRewardConfig));
		}

		// Token: 0x0600EC53 RID: 60499 RVA: 0x0035968C File Offset: 0x0035788C
		public static TimePointRewardConfig GetRootAsTimePointRewardConfig(ByteBuffer _bb, TimePointRewardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EC54 RID: 60500 RVA: 0x003596A9 File Offset: 0x003578A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EC55 RID: 60501 RVA: 0x003596B8 File Offset: 0x003578B8
		public TimePointRewardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DD9 RID: 15833
		// (get) Token: 0x0600EC56 RID: 60502 RVA: 0x003596C8 File Offset: 0x003578C8
		public int ActivityId
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

		// Token: 0x17003DDA RID: 15834
		// (get) Token: 0x0600EC57 RID: 60503 RVA: 0x00359704 File Offset: 0x00357904
		public string UiPrefab
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EC58 RID: 60504 RVA: 0x0035973B File Offset: 0x0035793B
		public Span<byte> GetUiPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EC59 RID: 60505 RVA: 0x0035974A File Offset: 0x0035794A
		public byte[] GetUiPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040058B2 RID: 22706
		private Table __p;
	}
}

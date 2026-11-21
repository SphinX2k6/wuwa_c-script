using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C61 RID: 3169
	public struct CircumFluenceTask : IFlatbufferObject
	{
		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06005BB9 RID: 23481 RVA: 0x00216A79 File Offset: 0x00214C79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005BBA RID: 23482 RVA: 0x00216A86 File Offset: 0x00214C86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x00216A90 File Offset: 0x00214C90
		public static CircumFluenceTask GetRootAsCircumFluenceTask(ByteBuffer _bb)
		{
			return CircumFluenceTask.GetRootAsCircumFluenceTask(_bb, default(CircumFluenceTask));
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x00216AAC File Offset: 0x00214CAC
		public static CircumFluenceTask GetRootAsCircumFluenceTask(ByteBuffer _bb, CircumFluenceTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x00216AC9 File Offset: 0x00214CC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x00216AD8 File Offset: 0x00214CD8
		public CircumFluenceTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06005BBF RID: 23487 RVA: 0x00216AE8 File Offset: 0x00214CE8
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

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06005BC0 RID: 23488 RVA: 0x00216B24 File Offset: 0x00214D24
		public int TaskType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06005BC1 RID: 23489 RVA: 0x00216B60 File Offset: 0x00214D60
		public string TargetName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x00216B97 File Offset: 0x00214D97
		public Span<byte> GetTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005BC3 RID: 23491 RVA: 0x00216BA6 File Offset: 0x00214DA6
		public byte[] GetTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06005BC4 RID: 23492 RVA: 0x00216BC0 File Offset: 0x00214DC0
		public int TaskSubType
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

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06005BC5 RID: 23493 RVA: 0x00216C00 File Offset: 0x00214E00
		public int ExploreType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06005BC6 RID: 23494 RVA: 0x00216C40 File Offset: 0x00214E40
		public int TargetReward
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

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06005BC7 RID: 23495 RVA: 0x00216C80 File Offset: 0x00214E80
		public int TargetFunc
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

		// Token: 0x04005165 RID: 20837
		private Table __p;
	}
}

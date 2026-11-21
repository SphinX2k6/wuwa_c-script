using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001190 RID: 4496
	public struct SelectRolePerformance : IFlatbufferObject
	{
		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x0600D7F1 RID: 55281 RVA: 0x0032A7B4 File Offset: 0x003289B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D7F2 RID: 55282 RVA: 0x0032A7C1 File Offset: 0x003289C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D7F3 RID: 55283 RVA: 0x0032A7C8 File Offset: 0x003289C8
		public static SelectRolePerformance GetRootAsSelectRolePerformance(ByteBuffer _bb)
		{
			return SelectRolePerformance.GetRootAsSelectRolePerformance(_bb, default(SelectRolePerformance));
		}

		// Token: 0x0600D7F4 RID: 55284 RVA: 0x0032A7E4 File Offset: 0x003289E4
		public static SelectRolePerformance GetRootAsSelectRolePerformance(ByteBuffer _bb, SelectRolePerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D7F5 RID: 55285 RVA: 0x0032A801 File Offset: 0x00328A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D7F6 RID: 55286 RVA: 0x0032A810 File Offset: 0x00328A10
		public SelectRolePerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x0600D7F7 RID: 55287 RVA: 0x0032A820 File Offset: 0x00328A20
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

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x0600D7F8 RID: 55288 RVA: 0x0032A85C File Offset: 0x00328A5C
		public int HelpId
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

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x0600D7F9 RID: 55289 RVA: 0x0032A898 File Offset: 0x00328A98
		public string PrefabPath
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

		// Token: 0x0600D7FA RID: 55290 RVA: 0x0032A8CF File Offset: 0x00328ACF
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D7FB RID: 55291 RVA: 0x0032A8DE File Offset: 0x00328ADE
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040057A1 RID: 22433
		private Table __p;
	}
}

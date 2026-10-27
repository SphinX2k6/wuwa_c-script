using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001041 RID: 4161
	public struct RoleDevelopCurve : IFlatbufferObject
	{
		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0600C7E0 RID: 51168 RVA: 0x002F8F21 File Offset: 0x002F7121
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C7E1 RID: 51169 RVA: 0x002F8F2E File Offset: 0x002F712E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C7E2 RID: 51170 RVA: 0x002F8F38 File Offset: 0x002F7138
		public static RoleDevelopCurve GetRootAsRoleDevelopCurve(ByteBuffer _bb)
		{
			return RoleDevelopCurve.GetRootAsRoleDevelopCurve(_bb, default(RoleDevelopCurve));
		}

		// Token: 0x0600C7E3 RID: 51171 RVA: 0x002F8F54 File Offset: 0x002F7154
		public static RoleDevelopCurve GetRootAsRoleDevelopCurve(ByteBuffer _bb, RoleDevelopCurve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C7E4 RID: 51172 RVA: 0x002F8F71 File Offset: 0x002F7171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C7E5 RID: 51173 RVA: 0x002F8F80 File Offset: 0x002F7180
		public RoleDevelopCurve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x0600C7E6 RID: 51174 RVA: 0x002F8F90 File Offset: 0x002F7190
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

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0600C7E7 RID: 51175 RVA: 0x002F8FCC File Offset: 0x002F71CC
		public int GroupId
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

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0600C7E8 RID: 51176 RVA: 0x002F9008 File Offset: 0x002F7208
		public int TrainType
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

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0600C7E9 RID: 51177 RVA: 0x002F9044 File Offset: 0x002F7244
		public string TrainContent
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C7EA RID: 51178 RVA: 0x002F907C File Offset: 0x002F727C
		public Span<byte> GetTrainContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C7EB RID: 51179 RVA: 0x002F908C File Offset: 0x002F728C
		public byte[] GetTrainContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0600C7EC RID: 51180 RVA: 0x002F90A4 File Offset: 0x002F72A4
		public int WishConsume
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

		// Token: 0x0400513F RID: 20799
		private Table __p;
	}
}

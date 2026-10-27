using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F61 RID: 3937
	public struct QteInputActionMapping : IFlatbufferObject
	{
		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x0600B3F5 RID: 46069 RVA: 0x002CC948 File Offset: 0x002CAB48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B3F6 RID: 46070 RVA: 0x002CC955 File Offset: 0x002CAB55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B3F7 RID: 46071 RVA: 0x002CC95C File Offset: 0x002CAB5C
		public static QteInputActionMapping GetRootAsQteInputActionMapping(ByteBuffer _bb)
		{
			return QteInputActionMapping.GetRootAsQteInputActionMapping(_bb, default(QteInputActionMapping));
		}

		// Token: 0x0600B3F8 RID: 46072 RVA: 0x002CC978 File Offset: 0x002CAB78
		public static QteInputActionMapping GetRootAsQteInputActionMapping(ByteBuffer _bb, QteInputActionMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B3F9 RID: 46073 RVA: 0x002CC995 File Offset: 0x002CAB95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B3FA RID: 46074 RVA: 0x002CC9A4 File Offset: 0x002CABA4
		public QteInputActionMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x0600B3FB RID: 46075 RVA: 0x002CC9B4 File Offset: 0x002CABB4
		public int QteInputActionId
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

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x0600B3FC RID: 46076 RVA: 0x002CC9F0 File Offset: 0x002CABF0
		public string QteInputActionName
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

		// Token: 0x0600B3FD RID: 46077 RVA: 0x002CCA27 File Offset: 0x002CAC27
		public Span<byte> GetQteInputActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B3FE RID: 46078 RVA: 0x002CCA36 File Offset: 0x002CAC36
		public byte[] GetQteInputActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x0600B3FF RID: 46079 RVA: 0x002CCA50 File Offset: 0x002CAC50
		public int QteInputActionType
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

		// Token: 0x0400502F RID: 20527
		private Table __p;
	}
}

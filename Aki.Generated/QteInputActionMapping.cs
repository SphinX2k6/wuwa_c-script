using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001048 RID: 4168
	public struct QteInputActionMapping : IFlatbufferObject
	{
		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x0600BA32 RID: 47666 RVA: 0x002E95FC File Offset: 0x002E77FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BA33 RID: 47667 RVA: 0x002E9609 File Offset: 0x002E7809
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA34 RID: 47668 RVA: 0x002E9610 File Offset: 0x002E7810
		public static QteInputActionMapping GetRootAsQteInputActionMapping(ByteBuffer _bb)
		{
			return QteInputActionMapping.GetRootAsQteInputActionMapping(_bb, default(QteInputActionMapping));
		}

		// Token: 0x0600BA35 RID: 47669 RVA: 0x002E962C File Offset: 0x002E782C
		public static QteInputActionMapping GetRootAsQteInputActionMapping(ByteBuffer _bb, QteInputActionMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA36 RID: 47670 RVA: 0x002E9649 File Offset: 0x002E7849
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA37 RID: 47671 RVA: 0x002E9658 File Offset: 0x002E7858
		public QteInputActionMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x0600BA38 RID: 47672 RVA: 0x002E9668 File Offset: 0x002E7868
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

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x0600BA39 RID: 47673 RVA: 0x002E96A4 File Offset: 0x002E78A4
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

		// Token: 0x0600BA3A RID: 47674 RVA: 0x002E96DB File Offset: 0x002E78DB
		public Span<byte> GetQteInputActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BA3B RID: 47675 RVA: 0x002E96EA File Offset: 0x002E78EA
		public byte[] GetQteInputActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x0600BA3C RID: 47676 RVA: 0x002E9704 File Offset: 0x002E7904
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

		// Token: 0x04005616 RID: 22038
		private Table __p;
	}
}

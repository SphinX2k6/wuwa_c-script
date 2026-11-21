using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CBE RID: 3262
	public struct DangoMonopolyPropertyType : IFlatbufferObject
	{
		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x0600667B RID: 26235 RVA: 0x0022F615 File Offset: 0x0022D815
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x0022F622 File Offset: 0x0022D822
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x0022F62C File Offset: 0x0022D82C
		public static DangoMonopolyPropertyType GetRootAsDangoMonopolyPropertyType(ByteBuffer _bb)
		{
			return DangoMonopolyPropertyType.GetRootAsDangoMonopolyPropertyType(_bb, default(DangoMonopolyPropertyType));
		}

		// Token: 0x0600667E RID: 26238 RVA: 0x0022F648 File Offset: 0x0022D848
		public static DangoMonopolyPropertyType GetRootAsDangoMonopolyPropertyType(ByteBuffer _bb, DangoMonopolyPropertyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600667F RID: 26239 RVA: 0x0022F665 File Offset: 0x0022D865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x0022F674 File Offset: 0x0022D874
		public DangoMonopolyPropertyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06006681 RID: 26241 RVA: 0x0022F684 File Offset: 0x0022D884
		public int PropertyType
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

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06006682 RID: 26242 RVA: 0x0022F6C0 File Offset: 0x0022D8C0
		public int TriggerType
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

		// Token: 0x040051EB RID: 20971
		private Table __p;
	}
}

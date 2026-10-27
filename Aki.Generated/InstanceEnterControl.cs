using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D72 RID: 3442
	public struct InstanceEnterControl : IFlatbufferObject
	{
		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06008581 RID: 34177 RVA: 0x00264169 File Offset: 0x00262369
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008582 RID: 34178 RVA: 0x00264176 File Offset: 0x00262376
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008583 RID: 34179 RVA: 0x00264180 File Offset: 0x00262380
		public static InstanceEnterControl GetRootAsInstanceEnterControl(ByteBuffer _bb)
		{
			return InstanceEnterControl.GetRootAsInstanceEnterControl(_bb, default(InstanceEnterControl));
		}

		// Token: 0x06008584 RID: 34180 RVA: 0x0026419C File Offset: 0x0026239C
		public static InstanceEnterControl GetRootAsInstanceEnterControl(ByteBuffer _bb, InstanceEnterControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008585 RID: 34181 RVA: 0x002641B9 File Offset: 0x002623B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008586 RID: 34182 RVA: 0x002641C8 File Offset: 0x002623C8
		public InstanceEnterControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06008587 RID: 34183 RVA: 0x002641D8 File Offset: 0x002623D8
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

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06008588 RID: 34184 RVA: 0x00264214 File Offset: 0x00262414
		public int EnterCount
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

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06008589 RID: 34185 RVA: 0x00264250 File Offset: 0x00262450
		public int EnterCountConsumeType
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

		// Token: 0x04004DFA RID: 19962
		private Table __p;
	}
}

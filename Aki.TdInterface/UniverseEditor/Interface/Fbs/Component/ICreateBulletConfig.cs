using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200559E RID: 21918
	public struct ICreateBulletConfig : IFlatbufferObject
	{
		// Token: 0x17009CF2 RID: 40178
		// (get) Token: 0x06022DC3 RID: 142787 RVA: 0x004CD2D1 File Offset: 0x004CB4D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022DC4 RID: 142788 RVA: 0x004CD2DE File Offset: 0x004CB4DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022DC5 RID: 142789 RVA: 0x004CD2E8 File Offset: 0x004CB4E8
		public static ICreateBulletConfig GetRootAsICreateBulletConfig(ByteBuffer _bb)
		{
			return ICreateBulletConfig.GetRootAsICreateBulletConfig(_bb, default(ICreateBulletConfig));
		}

		// Token: 0x06022DC6 RID: 142790 RVA: 0x004CD304 File Offset: 0x004CB504
		public static ICreateBulletConfig GetRootAsICreateBulletConfig(ByteBuffer _bb, ICreateBulletConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022DC7 RID: 142791 RVA: 0x004CD321 File Offset: 0x004CB521
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022DC8 RID: 142792 RVA: 0x004CD330 File Offset: 0x004CB530
		public ICreateBulletConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CF3 RID: 40179
		// (get) Token: 0x06022DC9 RID: 142793 RVA: 0x004CD340 File Offset: 0x004CB540
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009CF4 RID: 40180
		// (get) Token: 0x06022DCA RID: 142794 RVA: 0x004CD380 File Offset: 0x004CB580
		public float Delay
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022DCB RID: 142795 RVA: 0x004CD3C0 File Offset: 0x004CB5C0
		public static Offset<ICreateBulletConfig> CreateICreateBulletConfig(FlatBufferBuilder builder, long BulletId = 0L, float Delay = 0f)
		{
			builder.StartTable(2);
			ICreateBulletConfig.AddBulletId(builder, BulletId);
			ICreateBulletConfig.AddDelay(builder, Delay);
			return ICreateBulletConfig.EndICreateBulletConfig(builder);
		}

		// Token: 0x06022DCC RID: 142796 RVA: 0x004CD3DD File Offset: 0x004CB5DD
		public static void StartICreateBulletConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022DCD RID: 142797 RVA: 0x004CD3E6 File Offset: 0x004CB5E6
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(0, bulletId, 0L);
		}

		// Token: 0x06022DCE RID: 142798 RVA: 0x004CD3F2 File Offset: 0x004CB5F2
		public static void AddDelay(FlatBufferBuilder builder, float delay)
		{
			builder.AddFloat(1, delay, 0.0);
		}

		// Token: 0x06022DCF RID: 142799 RVA: 0x004CD405 File Offset: 0x004CB605
		public static Offset<ICreateBulletConfig> EndICreateBulletConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICreateBulletConfig>(builder.EndTable());
		}

		// Token: 0x06022DD0 RID: 142800 RVA: 0x004CD414 File Offset: 0x004CB614
		public ICreateBulletConfigT UnPack()
		{
			ICreateBulletConfigT createBulletConfigT = new ICreateBulletConfigT();
			this.UnPackTo(createBulletConfigT);
			return createBulletConfigT;
		}

		// Token: 0x06022DD1 RID: 142801 RVA: 0x004CD42F File Offset: 0x004CB62F
		public void UnPackTo(ICreateBulletConfigT _o)
		{
			_o.BulletId = this.BulletId;
			_o.Delay = this.Delay;
		}

		// Token: 0x06022DD2 RID: 142802 RVA: 0x004CD44C File Offset: 0x004CB64C
		public static Offset<ICreateBulletConfig> Pack(FlatBufferBuilder builder, ICreateBulletConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICreateBulletConfig>);
			}
			return ICreateBulletConfig.CreateICreateBulletConfig(builder, _o.BulletId, _o.Delay);
		}

		// Token: 0x0400EC28 RID: 60456
		private Table __p;
	}
}

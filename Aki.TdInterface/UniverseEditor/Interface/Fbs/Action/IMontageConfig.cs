using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF1 RID: 27377
	public struct IMontageConfig : IFlatbufferObject
	{
		// Token: 0x1700CB19 RID: 51993
		// (get) Token: 0x0602FFD0 RID: 196560 RVA: 0x00686461 File Offset: 0x00684661
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FFD1 RID: 196561 RVA: 0x0068646E File Offset: 0x0068466E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FFD2 RID: 196562 RVA: 0x00686478 File Offset: 0x00684678
		public static IMontageConfig GetRootAsIMontageConfig(ByteBuffer _bb)
		{
			return IMontageConfig.GetRootAsIMontageConfig(_bb, default(IMontageConfig));
		}

		// Token: 0x0602FFD3 RID: 196563 RVA: 0x00686494 File Offset: 0x00684694
		public static IMontageConfig GetRootAsIMontageConfig(ByteBuffer _bb, IMontageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FFD4 RID: 196564 RVA: 0x006864B1 File Offset: 0x006846B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FFD5 RID: 196565 RVA: 0x006864C0 File Offset: 0x006846C0
		public IMontageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB1A RID: 51994
		// (get) Token: 0x0602FFD6 RID: 196566 RVA: 0x006864D0 File Offset: 0x006846D0
		public EMontageConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMontageConfigType.Asset;
				}
				return (EMontageConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FFD7 RID: 196567 RVA: 0x0068650C File Offset: 0x0068470C
		public static Offset<IMontageConfig> CreateIMontageConfig(FlatBufferBuilder builder, EMontageConfigType Type = EMontageConfigType.Asset)
		{
			builder.StartTable(1);
			IMontageConfig.AddType(builder, Type);
			return IMontageConfig.EndIMontageConfig(builder);
		}

		// Token: 0x0602FFD8 RID: 196568 RVA: 0x00686522 File Offset: 0x00684722
		public static void StartIMontageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FFD9 RID: 196569 RVA: 0x0068652B File Offset: 0x0068472B
		public static void AddType(FlatBufferBuilder builder, EMontageConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FFDA RID: 196570 RVA: 0x00686536 File Offset: 0x00684736
		public static Offset<IMontageConfig> EndIMontageConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMontageConfig>(builder.EndTable());
		}

		// Token: 0x0602FFDB RID: 196571 RVA: 0x00686544 File Offset: 0x00684744
		public IMontageConfigT UnPack()
		{
			IMontageConfigT montageConfigT = new IMontageConfigT();
			this.UnPackTo(montageConfigT);
			return montageConfigT;
		}

		// Token: 0x0602FFDC RID: 196572 RVA: 0x0068655F File Offset: 0x0068475F
		public void UnPackTo(IMontageConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FFDD RID: 196573 RVA: 0x00686570 File Offset: 0x00684770
		public static Offset<IMontageConfig> Pack(FlatBufferBuilder builder, IMontageConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontageConfig>);
			}
			return IMontageConfig.CreateIMontageConfig(builder, _o.Type);
		}

		// Token: 0x04011346 RID: 70470
		private Table __p;
	}
}

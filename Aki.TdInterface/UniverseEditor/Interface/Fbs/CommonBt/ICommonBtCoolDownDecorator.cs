using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EB1 RID: 24241
	public struct ICommonBtCoolDownDecorator : IFlatbufferObject
	{
		// Token: 0x1700B524 RID: 46372
		// (get) Token: 0x06029911 RID: 170257 RVA: 0x005B3D64 File Offset: 0x005B1F64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029912 RID: 170258 RVA: 0x005B3D71 File Offset: 0x005B1F71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029913 RID: 170259 RVA: 0x005B3D78 File Offset: 0x005B1F78
		public static ICommonBtCoolDownDecorator GetRootAsICommonBtCoolDownDecorator(ByteBuffer _bb)
		{
			return ICommonBtCoolDownDecorator.GetRootAsICommonBtCoolDownDecorator(_bb, default(ICommonBtCoolDownDecorator));
		}

		// Token: 0x06029914 RID: 170260 RVA: 0x005B3D94 File Offset: 0x005B1F94
		public static ICommonBtCoolDownDecorator GetRootAsICommonBtCoolDownDecorator(ByteBuffer _bb, ICommonBtCoolDownDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029915 RID: 170261 RVA: 0x005B3DB1 File Offset: 0x005B1FB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029916 RID: 170262 RVA: 0x005B3DC0 File Offset: 0x005B1FC0
		public ICommonBtCoolDownDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B525 RID: 46373
		// (get) Token: 0x06029917 RID: 170263 RVA: 0x005B3DD0 File Offset: 0x005B1FD0
		public ECommonBtDecoratorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonBtDecoratorType.Condition;
				}
				return (ECommonBtDecoratorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B526 RID: 46374
		// (get) Token: 0x06029918 RID: 170264 RVA: 0x005B3E0C File Offset: 0x005B200C
		public int CoolDown
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

		// Token: 0x06029919 RID: 170265 RVA: 0x005B3E48 File Offset: 0x005B2048
		public static Offset<ICommonBtCoolDownDecorator> CreateICommonBtCoolDownDecorator(FlatBufferBuilder builder, ECommonBtDecoratorType Type = ECommonBtDecoratorType.Condition, int CoolDown = 0)
		{
			builder.StartTable(2);
			ICommonBtCoolDownDecorator.AddCoolDown(builder, CoolDown);
			ICommonBtCoolDownDecorator.AddType(builder, Type);
			return ICommonBtCoolDownDecorator.EndICommonBtCoolDownDecorator(builder);
		}

		// Token: 0x0602991A RID: 170266 RVA: 0x005B3E65 File Offset: 0x005B2065
		public static void StartICommonBtCoolDownDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602991B RID: 170267 RVA: 0x005B3E6E File Offset: 0x005B206E
		public static void AddType(FlatBufferBuilder builder, ECommonBtDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602991C RID: 170268 RVA: 0x005B3E79 File Offset: 0x005B2079
		public static void AddCoolDown(FlatBufferBuilder builder, int coolDown)
		{
			builder.AddInt(1, coolDown, 0);
		}

		// Token: 0x0602991D RID: 170269 RVA: 0x005B3E84 File Offset: 0x005B2084
		public static Offset<ICommonBtCoolDownDecorator> EndICommonBtCoolDownDecorator(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtCoolDownDecorator>(builder.EndTable());
		}

		// Token: 0x0602991E RID: 170270 RVA: 0x005B3E94 File Offset: 0x005B2094
		public ICommonBtCoolDownDecoratorT UnPack()
		{
			ICommonBtCoolDownDecoratorT commonBtCoolDownDecoratorT = new ICommonBtCoolDownDecoratorT();
			this.UnPackTo(commonBtCoolDownDecoratorT);
			return commonBtCoolDownDecoratorT;
		}

		// Token: 0x0602991F RID: 170271 RVA: 0x005B3EAF File Offset: 0x005B20AF
		public void UnPackTo(ICommonBtCoolDownDecoratorT _o)
		{
			_o.Type = this.Type;
			_o.CoolDown = this.CoolDown;
		}

		// Token: 0x06029920 RID: 170272 RVA: 0x005B3ECC File Offset: 0x005B20CC
		public static Offset<ICommonBtCoolDownDecorator> Pack(FlatBufferBuilder builder, ICommonBtCoolDownDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtCoolDownDecorator>);
			}
			return ICommonBtCoolDownDecorator.CreateICommonBtCoolDownDecorator(builder, _o.Type, _o.CoolDown);
		}

		// Token: 0x0400F922 RID: 63778
		private Table __p;
	}
}

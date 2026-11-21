using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064F4 RID: 25844
	public struct ICommonBtCoolDownDecorator : IFlatbufferObject
	{
		// Token: 0x1700BE8F RID: 48783
		// (get) Token: 0x0602BFC5 RID: 180165 RVA: 0x005FD248 File Offset: 0x005FB448
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BFC6 RID: 180166 RVA: 0x005FD255 File Offset: 0x005FB455
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BFC7 RID: 180167 RVA: 0x005FD25C File Offset: 0x005FB45C
		public static ICommonBtCoolDownDecorator GetRootAsICommonBtCoolDownDecorator(ByteBuffer _bb)
		{
			return ICommonBtCoolDownDecorator.GetRootAsICommonBtCoolDownDecorator(_bb, default(ICommonBtCoolDownDecorator));
		}

		// Token: 0x0602BFC8 RID: 180168 RVA: 0x005FD278 File Offset: 0x005FB478
		public static ICommonBtCoolDownDecorator GetRootAsICommonBtCoolDownDecorator(ByteBuffer _bb, ICommonBtCoolDownDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BFC9 RID: 180169 RVA: 0x005FD295 File Offset: 0x005FB495
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BFCA RID: 180170 RVA: 0x005FD2A4 File Offset: 0x005FB4A4
		public ICommonBtCoolDownDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE90 RID: 48784
		// (get) Token: 0x0602BFCB RID: 180171 RVA: 0x005FD2B4 File Offset: 0x005FB4B4
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

		// Token: 0x1700BE91 RID: 48785
		// (get) Token: 0x0602BFCC RID: 180172 RVA: 0x005FD2F0 File Offset: 0x005FB4F0
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

		// Token: 0x0602BFCD RID: 180173 RVA: 0x005FD32C File Offset: 0x005FB52C
		public static Offset<ICommonBtCoolDownDecorator> CreateICommonBtCoolDownDecorator(FlatBufferBuilder builder, ECommonBtDecoratorType Type = ECommonBtDecoratorType.Condition, int CoolDown = 0)
		{
			builder.StartTable(2);
			ICommonBtCoolDownDecorator.AddCoolDown(builder, CoolDown);
			ICommonBtCoolDownDecorator.AddType(builder, Type);
			return ICommonBtCoolDownDecorator.EndICommonBtCoolDownDecorator(builder);
		}

		// Token: 0x0602BFCE RID: 180174 RVA: 0x005FD349 File Offset: 0x005FB549
		public static void StartICommonBtCoolDownDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BFCF RID: 180175 RVA: 0x005FD352 File Offset: 0x005FB552
		public static void AddType(FlatBufferBuilder builder, ECommonBtDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BFD0 RID: 180176 RVA: 0x005FD35D File Offset: 0x005FB55D
		public static void AddCoolDown(FlatBufferBuilder builder, int coolDown)
		{
			builder.AddInt(1, coolDown, 0);
		}

		// Token: 0x0602BFD1 RID: 180177 RVA: 0x005FD368 File Offset: 0x005FB568
		public static Offset<ICommonBtCoolDownDecorator> EndICommonBtCoolDownDecorator(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtCoolDownDecorator>(builder.EndTable());
		}

		// Token: 0x0602BFD2 RID: 180178 RVA: 0x005FD378 File Offset: 0x005FB578
		public ICommonBtCoolDownDecoratorT UnPack()
		{
			ICommonBtCoolDownDecoratorT commonBtCoolDownDecoratorT = new ICommonBtCoolDownDecoratorT();
			this.UnPackTo(commonBtCoolDownDecoratorT);
			return commonBtCoolDownDecoratorT;
		}

		// Token: 0x0602BFD3 RID: 180179 RVA: 0x005FD393 File Offset: 0x005FB593
		public void UnPackTo(ICommonBtCoolDownDecoratorT _o)
		{
			_o.Type = this.Type;
			_o.CoolDown = this.CoolDown;
		}

		// Token: 0x0602BFD4 RID: 180180 RVA: 0x005FD3B0 File Offset: 0x005FB5B0
		public static Offset<ICommonBtCoolDownDecorator> Pack(FlatBufferBuilder builder, ICommonBtCoolDownDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtCoolDownDecorator>);
			}
			return ICommonBtCoolDownDecorator.CreateICommonBtCoolDownDecorator(builder, _o.Type, _o.CoolDown);
		}

		// Token: 0x04010685 RID: 67205
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059FC RID: 23036
	public struct IInteractStyleBase : IFlatbufferObject
	{
		// Token: 0x1700A760 RID: 42848
		// (get) Token: 0x060259CD RID: 154061 RVA: 0x00528362 File Offset: 0x00526562
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060259CE RID: 154062 RVA: 0x0052836F File Offset: 0x0052656F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060259CF RID: 154063 RVA: 0x00528378 File Offset: 0x00526578
		public static IInteractStyleBase GetRootAsIInteractStyleBase(ByteBuffer _bb)
		{
			return IInteractStyleBase.GetRootAsIInteractStyleBase(_bb, default(IInteractStyleBase));
		}

		// Token: 0x060259D0 RID: 154064 RVA: 0x00528394 File Offset: 0x00526594
		public static IInteractStyleBase GetRootAsIInteractStyleBase(ByteBuffer _bb, IInteractStyleBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060259D1 RID: 154065 RVA: 0x005283B1 File Offset: 0x005265B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060259D2 RID: 154066 RVA: 0x005283C0 File Offset: 0x005265C0
		public IInteractStyleBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A761 RID: 42849
		// (get) Token: 0x060259D3 RID: 154067 RVA: 0x005283D0 File Offset: 0x005265D0
		public EInteractStyleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractStyleType.Panorama;
				}
				return (EInteractStyleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060259D4 RID: 154068 RVA: 0x0052840C File Offset: 0x0052660C
		public static Offset<IInteractStyleBase> CreateIInteractStyleBase(FlatBufferBuilder builder, EInteractStyleType Type = EInteractStyleType.Panorama)
		{
			builder.StartTable(1);
			IInteractStyleBase.AddType(builder, Type);
			return IInteractStyleBase.EndIInteractStyleBase(builder);
		}

		// Token: 0x060259D5 RID: 154069 RVA: 0x00528422 File Offset: 0x00526622
		public static void StartIInteractStyleBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060259D6 RID: 154070 RVA: 0x0052842B File Offset: 0x0052662B
		public static void AddType(FlatBufferBuilder builder, EInteractStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060259D7 RID: 154071 RVA: 0x00528436 File Offset: 0x00526636
		public static Offset<IInteractStyleBase> EndIInteractStyleBase(FlatBufferBuilder builder)
		{
			return new Offset<IInteractStyleBase>(builder.EndTable());
		}

		// Token: 0x060259D8 RID: 154072 RVA: 0x00528444 File Offset: 0x00526644
		public IInteractStyleBaseT UnPack()
		{
			IInteractStyleBaseT interactStyleBaseT = new IInteractStyleBaseT();
			this.UnPackTo(interactStyleBaseT);
			return interactStyleBaseT;
		}

		// Token: 0x060259D9 RID: 154073 RVA: 0x0052845F File Offset: 0x0052665F
		public void UnPackTo(IInteractStyleBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060259DA RID: 154074 RVA: 0x00528470 File Offset: 0x00526670
		public static Offset<IInteractStyleBase> Pack(FlatBufferBuilder builder, IInteractStyleBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractStyleBase>);
			}
			return IInteractStyleBase.CreateIInteractStyleBase(builder, _o.Type);
		}

		// Token: 0x0400F325 RID: 62245
		private Table __p;
	}
}

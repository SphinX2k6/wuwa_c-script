using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200688F RID: 26767
	public struct IBpActorFuncTypeBase : IFlatbufferObject
	{
		// Token: 0x1700C4B8 RID: 50360
		// (get) Token: 0x0602DC23 RID: 187427 RVA: 0x00641683 File Offset: 0x0063F883
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DC24 RID: 187428 RVA: 0x00641690 File Offset: 0x0063F890
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DC25 RID: 187429 RVA: 0x00641698 File Offset: 0x0063F898
		public static IBpActorFuncTypeBase GetRootAsIBpActorFuncTypeBase(ByteBuffer _bb)
		{
			return IBpActorFuncTypeBase.GetRootAsIBpActorFuncTypeBase(_bb, default(IBpActorFuncTypeBase));
		}

		// Token: 0x0602DC26 RID: 187430 RVA: 0x006416B4 File Offset: 0x0063F8B4
		public static IBpActorFuncTypeBase GetRootAsIBpActorFuncTypeBase(ByteBuffer _bb, IBpActorFuncTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DC27 RID: 187431 RVA: 0x006416D1 File Offset: 0x0063F8D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DC28 RID: 187432 RVA: 0x006416E0 File Offset: 0x0063F8E0
		public IBpActorFuncTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4B9 RID: 50361
		// (get) Token: 0x0602DC29 RID: 187433 RVA: 0x006416F0 File Offset: 0x0063F8F0
		public EBpActorFuncType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBpActorFuncType.CarPaintChange;
				}
				return (EBpActorFuncType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DC2A RID: 187434 RVA: 0x0064172C File Offset: 0x0063F92C
		public static Offset<IBpActorFuncTypeBase> CreateIBpActorFuncTypeBase(FlatBufferBuilder builder, EBpActorFuncType Type = EBpActorFuncType.CarPaintChange)
		{
			builder.StartTable(1);
			IBpActorFuncTypeBase.AddType(builder, Type);
			return IBpActorFuncTypeBase.EndIBpActorFuncTypeBase(builder);
		}

		// Token: 0x0602DC2B RID: 187435 RVA: 0x00641742 File Offset: 0x0063F942
		public static void StartIBpActorFuncTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DC2C RID: 187436 RVA: 0x0064174B File Offset: 0x0063F94B
		public static void AddType(FlatBufferBuilder builder, EBpActorFuncType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DC2D RID: 187437 RVA: 0x00641756 File Offset: 0x0063F956
		public static Offset<IBpActorFuncTypeBase> EndIBpActorFuncTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IBpActorFuncTypeBase>(builder.EndTable());
		}

		// Token: 0x0602DC2E RID: 187438 RVA: 0x00641764 File Offset: 0x0063F964
		public IBpActorFuncTypeBaseT UnPack()
		{
			IBpActorFuncTypeBaseT bpActorFuncTypeBaseT = new IBpActorFuncTypeBaseT();
			this.UnPackTo(bpActorFuncTypeBaseT);
			return bpActorFuncTypeBaseT;
		}

		// Token: 0x0602DC2F RID: 187439 RVA: 0x0064177F File Offset: 0x0063F97F
		public void UnPackTo(IBpActorFuncTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DC30 RID: 187440 RVA: 0x00641790 File Offset: 0x0063F990
		public static Offset<IBpActorFuncTypeBase> Pack(FlatBufferBuilder builder, IBpActorFuncTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBpActorFuncTypeBase>);
			}
			return IBpActorFuncTypeBase.CreateIBpActorFuncTypeBase(builder, _o.Type);
		}

		// Token: 0x04011573 RID: 71027
		private Table __p;
	}
}

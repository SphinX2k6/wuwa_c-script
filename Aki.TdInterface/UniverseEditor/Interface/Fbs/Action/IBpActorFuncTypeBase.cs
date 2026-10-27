using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200621E RID: 25118
	public struct IBpActorFuncTypeBase : IFlatbufferObject
	{
		// Token: 0x1700BB30 RID: 47920
		// (get) Token: 0x0602B4C2 RID: 177346 RVA: 0x005F687C File Offset: 0x005F4A7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B4C3 RID: 177347 RVA: 0x005F6889 File Offset: 0x005F4A89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B4C4 RID: 177348 RVA: 0x005F6890 File Offset: 0x005F4A90
		public static IBpActorFuncTypeBase GetRootAsIBpActorFuncTypeBase(ByteBuffer _bb)
		{
			return IBpActorFuncTypeBase.GetRootAsIBpActorFuncTypeBase(_bb, default(IBpActorFuncTypeBase));
		}

		// Token: 0x0602B4C5 RID: 177349 RVA: 0x005F68AC File Offset: 0x005F4AAC
		public static IBpActorFuncTypeBase GetRootAsIBpActorFuncTypeBase(ByteBuffer _bb, IBpActorFuncTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B4C6 RID: 177350 RVA: 0x005F68C9 File Offset: 0x005F4AC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B4C7 RID: 177351 RVA: 0x005F68D8 File Offset: 0x005F4AD8
		public IBpActorFuncTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB31 RID: 47921
		// (get) Token: 0x0602B4C8 RID: 177352 RVA: 0x005F68E8 File Offset: 0x005F4AE8
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

		// Token: 0x0602B4C9 RID: 177353 RVA: 0x005F6924 File Offset: 0x005F4B24
		public static Offset<IBpActorFuncTypeBase> CreateIBpActorFuncTypeBase(FlatBufferBuilder builder, EBpActorFuncType Type = EBpActorFuncType.CarPaintChange)
		{
			builder.StartTable(1);
			IBpActorFuncTypeBase.AddType(builder, Type);
			return IBpActorFuncTypeBase.EndIBpActorFuncTypeBase(builder);
		}

		// Token: 0x0602B4CA RID: 177354 RVA: 0x005F693A File Offset: 0x005F4B3A
		public static void StartIBpActorFuncTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B4CB RID: 177355 RVA: 0x005F6943 File Offset: 0x005F4B43
		public static void AddType(FlatBufferBuilder builder, EBpActorFuncType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B4CC RID: 177356 RVA: 0x005F694E File Offset: 0x005F4B4E
		public static Offset<IBpActorFuncTypeBase> EndIBpActorFuncTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IBpActorFuncTypeBase>(builder.EndTable());
		}

		// Token: 0x0602B4CD RID: 177357 RVA: 0x005F695C File Offset: 0x005F4B5C
		public IBpActorFuncTypeBaseT UnPack()
		{
			IBpActorFuncTypeBaseT bpActorFuncTypeBaseT = new IBpActorFuncTypeBaseT();
			this.UnPackTo(bpActorFuncTypeBaseT);
			return bpActorFuncTypeBaseT;
		}

		// Token: 0x0602B4CE RID: 177358 RVA: 0x005F6977 File Offset: 0x005F4B77
		public void UnPackTo(IBpActorFuncTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B4CF RID: 177359 RVA: 0x005F6988 File Offset: 0x005F4B88
		public static Offset<IBpActorFuncTypeBase> Pack(FlatBufferBuilder builder, IBpActorFuncTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBpActorFuncTypeBase>);
			}
			return IBpActorFuncTypeBase.CreateIBpActorFuncTypeBase(builder, _o.Type);
		}

		// Token: 0x0401075E RID: 67422
		private Table __p;
	}
}

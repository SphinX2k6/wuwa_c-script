using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A8 RID: 27048
	public struct IInteractType : IFlatbufferObject
	{
		// Token: 0x1700C8A5 RID: 51365
		// (get) Token: 0x0602F419 RID: 193561 RVA: 0x0066FD8A File Offset: 0x0066DF8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F41A RID: 193562 RVA: 0x0066FD97 File Offset: 0x0066DF97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F41B RID: 193563 RVA: 0x0066FDA0 File Offset: 0x0066DFA0
		public static IInteractType GetRootAsIInteractType(ByteBuffer _bb)
		{
			return IInteractType.GetRootAsIInteractType(_bb, default(IInteractType));
		}

		// Token: 0x0602F41C RID: 193564 RVA: 0x0066FDBC File Offset: 0x0066DFBC
		public static IInteractType GetRootAsIInteractType(ByteBuffer _bb, IInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F41D RID: 193565 RVA: 0x0066FDD9 File Offset: 0x0066DFD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F41E RID: 193566 RVA: 0x0066FDE8 File Offset: 0x0066DFE8
		public IInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8A6 RID: 51366
		// (get) Token: 0x0602F41F RID: 193567 RVA: 0x0066FDF8 File Offset: 0x0066DFF8
		public EInteractOption Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractOption.Flow;
				}
				return (EInteractOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F420 RID: 193568 RVA: 0x0066FE34 File Offset: 0x0066E034
		public static Offset<IInteractType> CreateIInteractType(FlatBufferBuilder builder, EInteractOption Type = EInteractOption.Flow)
		{
			builder.StartTable(1);
			IInteractType.AddType(builder, Type);
			return IInteractType.EndIInteractType(builder);
		}

		// Token: 0x0602F421 RID: 193569 RVA: 0x0066FE4A File Offset: 0x0066E04A
		public static void StartIInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F422 RID: 193570 RVA: 0x0066FE53 File Offset: 0x0066E053
		public static void AddType(FlatBufferBuilder builder, EInteractOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F423 RID: 193571 RVA: 0x0066FE5E File Offset: 0x0066E05E
		public static Offset<IInteractType> EndIInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IInteractType>(builder.EndTable());
		}

		// Token: 0x0602F424 RID: 193572 RVA: 0x0066FE6C File Offset: 0x0066E06C
		public IInteractTypeT UnPack()
		{
			IInteractTypeT interactTypeT = new IInteractTypeT();
			this.UnPackTo(interactTypeT);
			return interactTypeT;
		}

		// Token: 0x0602F425 RID: 193573 RVA: 0x0066FE87 File Offset: 0x0066E087
		public void UnPackTo(IInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F426 RID: 193574 RVA: 0x0066FE98 File Offset: 0x0066E098
		public static Offset<IInteractType> Pack(FlatBufferBuilder builder, IInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractType>);
			}
			return IInteractType.CreateIInteractType(builder, _o.Type);
		}

		// Token: 0x04011150 RID: 69968
		private Table __p;
	}
}

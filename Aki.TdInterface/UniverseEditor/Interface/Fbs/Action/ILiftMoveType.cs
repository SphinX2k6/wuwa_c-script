using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069FF RID: 27135
	public struct ILiftMoveType : IFlatbufferObject
	{
		// Token: 0x1700C957 RID: 51543
		// (get) Token: 0x0602F7B7 RID: 194487 RVA: 0x00677762 File Offset: 0x00675962
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F7B8 RID: 194488 RVA: 0x0067776F File Offset: 0x0067596F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F7B9 RID: 194489 RVA: 0x00677778 File Offset: 0x00675978
		public static ILiftMoveType GetRootAsILiftMoveType(ByteBuffer _bb)
		{
			return ILiftMoveType.GetRootAsILiftMoveType(_bb, default(ILiftMoveType));
		}

		// Token: 0x0602F7BA RID: 194490 RVA: 0x00677794 File Offset: 0x00675994
		public static ILiftMoveType GetRootAsILiftMoveType(ByteBuffer _bb, ILiftMoveType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F7BB RID: 194491 RVA: 0x006777B1 File Offset: 0x006759B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F7BC RID: 194492 RVA: 0x006777C0 File Offset: 0x006759C0
		public ILiftMoveType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C958 RID: 51544
		// (get) Token: 0x0602F7BD RID: 194493 RVA: 0x006777D0 File Offset: 0x006759D0
		public ELiftMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiftMoveType.Default;
				}
				return (ELiftMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F7BE RID: 194494 RVA: 0x0067780C File Offset: 0x00675A0C
		public static Offset<ILiftMoveType> CreateILiftMoveType(FlatBufferBuilder builder, ELiftMoveType Type = ELiftMoveType.Default)
		{
			builder.StartTable(1);
			ILiftMoveType.AddType(builder, Type);
			return ILiftMoveType.EndILiftMoveType(builder);
		}

		// Token: 0x0602F7BF RID: 194495 RVA: 0x00677822 File Offset: 0x00675A22
		public static void StartILiftMoveType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F7C0 RID: 194496 RVA: 0x0067782B File Offset: 0x00675A2B
		public static void AddType(FlatBufferBuilder builder, ELiftMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F7C1 RID: 194497 RVA: 0x00677836 File Offset: 0x00675A36
		public static Offset<ILiftMoveType> EndILiftMoveType(FlatBufferBuilder builder)
		{
			return new Offset<ILiftMoveType>(builder.EndTable());
		}

		// Token: 0x0602F7C2 RID: 194498 RVA: 0x00677844 File Offset: 0x00675A44
		public ILiftMoveTypeT UnPack()
		{
			ILiftMoveTypeT liftMoveTypeT = new ILiftMoveTypeT();
			this.UnPackTo(liftMoveTypeT);
			return liftMoveTypeT;
		}

		// Token: 0x0602F7C3 RID: 194499 RVA: 0x0067785F File Offset: 0x00675A5F
		public void UnPackTo(ILiftMoveTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F7C4 RID: 194500 RVA: 0x00677870 File Offset: 0x00675A70
		public static Offset<ILiftMoveType> Pack(FlatBufferBuilder builder, ILiftMoveTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftMoveType>);
			}
			return ILiftMoveType.CreateILiftMoveType(builder, _o.Type);
		}

		// Token: 0x04011200 RID: 70144
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070AF RID: 28847
	public struct ILiftMoveType : IFlatbufferObject
	{
		// Token: 0x1700D357 RID: 54103
		// (get) Token: 0x06032177 RID: 205175 RVA: 0x006C7ABA File Offset: 0x006C5CBA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032178 RID: 205176 RVA: 0x006C7AC7 File Offset: 0x006C5CC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032179 RID: 205177 RVA: 0x006C7AD0 File Offset: 0x006C5CD0
		public static ILiftMoveType GetRootAsILiftMoveType(ByteBuffer _bb)
		{
			return ILiftMoveType.GetRootAsILiftMoveType(_bb, default(ILiftMoveType));
		}

		// Token: 0x0603217A RID: 205178 RVA: 0x006C7AEC File Offset: 0x006C5CEC
		public static ILiftMoveType GetRootAsILiftMoveType(ByteBuffer _bb, ILiftMoveType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603217B RID: 205179 RVA: 0x006C7B09 File Offset: 0x006C5D09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603217C RID: 205180 RVA: 0x006C7B18 File Offset: 0x006C5D18
		public ILiftMoveType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D358 RID: 54104
		// (get) Token: 0x0603217D RID: 205181 RVA: 0x006C7B28 File Offset: 0x006C5D28
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

		// Token: 0x0603217E RID: 205182 RVA: 0x006C7B64 File Offset: 0x006C5D64
		public static Offset<ILiftMoveType> CreateILiftMoveType(FlatBufferBuilder builder, ELiftMoveType Type = ELiftMoveType.Default)
		{
			builder.StartTable(1);
			ILiftMoveType.AddType(builder, Type);
			return ILiftMoveType.EndILiftMoveType(builder);
		}

		// Token: 0x0603217F RID: 205183 RVA: 0x006C7B7A File Offset: 0x006C5D7A
		public static void StartILiftMoveType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032180 RID: 205184 RVA: 0x006C7B83 File Offset: 0x006C5D83
		public static void AddType(FlatBufferBuilder builder, ELiftMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032181 RID: 205185 RVA: 0x006C7B8E File Offset: 0x006C5D8E
		public static Offset<ILiftMoveType> EndILiftMoveType(FlatBufferBuilder builder)
		{
			return new Offset<ILiftMoveType>(builder.EndTable());
		}

		// Token: 0x06032182 RID: 205186 RVA: 0x006C7B9C File Offset: 0x006C5D9C
		public ILiftMoveTypeT UnPack()
		{
			ILiftMoveTypeT liftMoveTypeT = new ILiftMoveTypeT();
			this.UnPackTo(liftMoveTypeT);
			return liftMoveTypeT;
		}

		// Token: 0x06032183 RID: 205187 RVA: 0x006C7BB7 File Offset: 0x006C5DB7
		public void UnPackTo(ILiftMoveTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032184 RID: 205188 RVA: 0x006C7BC8 File Offset: 0x006C5DC8
		public static Offset<ILiftMoveType> Pack(FlatBufferBuilder builder, ILiftMoveTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftMoveType>);
			}
			return ILiftMoveType.CreateILiftMoveType(builder, _o.Type);
		}

		// Token: 0x0401206A RID: 73834
		private Table __p;
	}
}

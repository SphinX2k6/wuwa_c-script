using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006630 RID: 26160
	public struct IElementalBoxTargetPosTypeBase : IFlatbufferObject
	{
		// Token: 0x1700C25C RID: 49756
		// (get) Token: 0x0602D6DF RID: 186079 RVA: 0x006393B3 File Offset: 0x006375B3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D6E0 RID: 186080 RVA: 0x006393C0 File Offset: 0x006375C0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D6E1 RID: 186081 RVA: 0x006393C8 File Offset: 0x006375C8
		public static IElementalBoxTargetPosTypeBase GetRootAsIElementalBoxTargetPosTypeBase(ByteBuffer _bb)
		{
			return IElementalBoxTargetPosTypeBase.GetRootAsIElementalBoxTargetPosTypeBase(_bb, default(IElementalBoxTargetPosTypeBase));
		}

		// Token: 0x0602D6E2 RID: 186082 RVA: 0x006393E4 File Offset: 0x006375E4
		public static IElementalBoxTargetPosTypeBase GetRootAsIElementalBoxTargetPosTypeBase(ByteBuffer _bb, IElementalBoxTargetPosTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D6E3 RID: 186083 RVA: 0x00639401 File Offset: 0x00637601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D6E4 RID: 186084 RVA: 0x00639410 File Offset: 0x00637610
		public IElementalBoxTargetPosTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C25D RID: 49757
		// (get) Token: 0x0602D6E5 RID: 186085 RVA: 0x00639420 File Offset: 0x00637620
		public EElementalBoxTargetPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
				}
				return (EElementalBoxTargetPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D6E6 RID: 186086 RVA: 0x0063945C File Offset: 0x0063765C
		public static Offset<IElementalBoxTargetPosTypeBase> CreateIElementalBoxTargetPosTypeBase(FlatBufferBuilder builder, EElementalBoxTargetPosType Type = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos)
		{
			builder.StartTable(1);
			IElementalBoxTargetPosTypeBase.AddType(builder, Type);
			return IElementalBoxTargetPosTypeBase.EndIElementalBoxTargetPosTypeBase(builder);
		}

		// Token: 0x0602D6E7 RID: 186087 RVA: 0x00639472 File Offset: 0x00637672
		public static void StartIElementalBoxTargetPosTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D6E8 RID: 186088 RVA: 0x0063947B File Offset: 0x0063767B
		public static void AddType(FlatBufferBuilder builder, EElementalBoxTargetPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D6E9 RID: 186089 RVA: 0x00639486 File Offset: 0x00637686
		public static Offset<IElementalBoxTargetPosTypeBase> EndIElementalBoxTargetPosTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxTargetPosTypeBase>(builder.EndTable());
		}

		// Token: 0x0602D6EA RID: 186090 RVA: 0x00639494 File Offset: 0x00637694
		public IElementalBoxTargetPosTypeBaseT UnPack()
		{
			IElementalBoxTargetPosTypeBaseT elementalBoxTargetPosTypeBaseT = new IElementalBoxTargetPosTypeBaseT();
			this.UnPackTo(elementalBoxTargetPosTypeBaseT);
			return elementalBoxTargetPosTypeBaseT;
		}

		// Token: 0x0602D6EB RID: 186091 RVA: 0x006394AF File Offset: 0x006376AF
		public void UnPackTo(IElementalBoxTargetPosTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D6EC RID: 186092 RVA: 0x006394C0 File Offset: 0x006376C0
		public static Offset<IElementalBoxTargetPosTypeBase> Pack(FlatBufferBuilder builder, IElementalBoxTargetPosTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxTargetPosTypeBase>);
			}
			return IElementalBoxTargetPosTypeBase.CreateIElementalBoxTargetPosTypeBase(builder, _o.Type);
		}

		// Token: 0x04010CC3 RID: 68803
		private Table __p;
	}
}

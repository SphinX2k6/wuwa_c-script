using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005073 RID: 20595
	public struct IComparedAlertValueType : IFlatbufferObject
	{
		// Token: 0x1700936C RID: 37740
		// (get) Token: 0x0602034E RID: 131918 RVA: 0x00476FB6 File Offset: 0x004751B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602034F RID: 131919 RVA: 0x00476FC3 File Offset: 0x004751C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020350 RID: 131920 RVA: 0x00476FCC File Offset: 0x004751CC
		public static IComparedAlertValueType GetRootAsIComparedAlertValueType(ByteBuffer _bb)
		{
			return IComparedAlertValueType.GetRootAsIComparedAlertValueType(_bb, default(IComparedAlertValueType));
		}

		// Token: 0x06020351 RID: 131921 RVA: 0x00476FE8 File Offset: 0x004751E8
		public static IComparedAlertValueType GetRootAsIComparedAlertValueType(ByteBuffer _bb, IComparedAlertValueType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020352 RID: 131922 RVA: 0x00477005 File Offset: 0x00475205
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020353 RID: 131923 RVA: 0x00477014 File Offset: 0x00475214
		public IComparedAlertValueType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700936D RID: 37741
		// (get) Token: 0x06020354 RID: 131924 RVA: 0x00477024 File Offset: 0x00475224
		public EComparedAlertValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EComparedAlertValueType.Min;
				}
				return (EComparedAlertValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020355 RID: 131925 RVA: 0x00477060 File Offset: 0x00475260
		public static Offset<IComparedAlertValueType> CreateIComparedAlertValueType(FlatBufferBuilder builder, EComparedAlertValueType Type = EComparedAlertValueType.Min)
		{
			builder.StartTable(1);
			IComparedAlertValueType.AddType(builder, Type);
			return IComparedAlertValueType.EndIComparedAlertValueType(builder);
		}

		// Token: 0x06020356 RID: 131926 RVA: 0x00477076 File Offset: 0x00475276
		public static void StartIComparedAlertValueType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020357 RID: 131927 RVA: 0x0047707F File Offset: 0x0047527F
		public static void AddType(FlatBufferBuilder builder, EComparedAlertValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020358 RID: 131928 RVA: 0x0047708A File Offset: 0x0047528A
		public static Offset<IComparedAlertValueType> EndIComparedAlertValueType(FlatBufferBuilder builder)
		{
			return new Offset<IComparedAlertValueType>(builder.EndTable());
		}

		// Token: 0x06020359 RID: 131929 RVA: 0x00477098 File Offset: 0x00475298
		public IComparedAlertValueTypeT UnPack()
		{
			IComparedAlertValueTypeT comparedAlertValueTypeT = new IComparedAlertValueTypeT();
			this.UnPackTo(comparedAlertValueTypeT);
			return comparedAlertValueTypeT;
		}

		// Token: 0x0602035A RID: 131930 RVA: 0x004770B3 File Offset: 0x004752B3
		public void UnPackTo(IComparedAlertValueTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602035B RID: 131931 RVA: 0x004770C4 File Offset: 0x004752C4
		public static Offset<IComparedAlertValueType> Pack(FlatBufferBuilder builder, IComparedAlertValueTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IComparedAlertValueType>);
			}
			return IComparedAlertValueType.CreateIComparedAlertValueType(builder, _o.Type);
		}

		// Token: 0x0400DF5F RID: 57183
		private Table __p;
	}
}

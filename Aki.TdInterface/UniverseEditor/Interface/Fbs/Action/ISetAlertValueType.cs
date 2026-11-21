using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200775C RID: 30556
	public struct ISetAlertValueType : IFlatbufferObject
	{
		// Token: 0x1700DFFA RID: 57338
		// (get) Token: 0x06035A0F RID: 219663 RVA: 0x00730230 File Offset: 0x0072E430
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035A10 RID: 219664 RVA: 0x0073023D File Offset: 0x0072E43D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035A11 RID: 219665 RVA: 0x00730244 File Offset: 0x0072E444
		public static ISetAlertValueType GetRootAsISetAlertValueType(ByteBuffer _bb)
		{
			return ISetAlertValueType.GetRootAsISetAlertValueType(_bb, default(ISetAlertValueType));
		}

		// Token: 0x06035A12 RID: 219666 RVA: 0x00730260 File Offset: 0x0072E460
		public static ISetAlertValueType GetRootAsISetAlertValueType(ByteBuffer _bb, ISetAlertValueType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035A13 RID: 219667 RVA: 0x0073027D File Offset: 0x0072E47D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035A14 RID: 219668 RVA: 0x0073028C File Offset: 0x0072E48C
		public ISetAlertValueType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFFB RID: 57339
		// (get) Token: 0x06035A15 RID: 219669 RVA: 0x0073029C File Offset: 0x0072E49C
		public EValueChangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EValueChangeType.AddOrSub;
				}
				return (EValueChangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035A16 RID: 219670 RVA: 0x007302D8 File Offset: 0x0072E4D8
		public static Offset<ISetAlertValueType> CreateISetAlertValueType(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub)
		{
			builder.StartTable(1);
			ISetAlertValueType.AddType(builder, Type);
			return ISetAlertValueType.EndISetAlertValueType(builder);
		}

		// Token: 0x06035A17 RID: 219671 RVA: 0x007302EE File Offset: 0x0072E4EE
		public static void StartISetAlertValueType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035A18 RID: 219672 RVA: 0x007302F7 File Offset: 0x0072E4F7
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035A19 RID: 219673 RVA: 0x00730302 File Offset: 0x0072E502
		public static Offset<ISetAlertValueType> EndISetAlertValueType(FlatBufferBuilder builder)
		{
			return new Offset<ISetAlertValueType>(builder.EndTable());
		}

		// Token: 0x06035A1A RID: 219674 RVA: 0x00730310 File Offset: 0x0072E510
		public ISetAlertValueTypeT UnPack()
		{
			ISetAlertValueTypeT setAlertValueTypeT = new ISetAlertValueTypeT();
			this.UnPackTo(setAlertValueTypeT);
			return setAlertValueTypeT;
		}

		// Token: 0x06035A1B RID: 219675 RVA: 0x0073032B File Offset: 0x0072E52B
		public void UnPackTo(ISetAlertValueTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035A1C RID: 219676 RVA: 0x0073033C File Offset: 0x0072E53C
		public static Offset<ISetAlertValueType> Pack(FlatBufferBuilder builder, ISetAlertValueTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAlertValueType>);
			}
			return ISetAlertValueType.CreateISetAlertValueType(builder, _o.Type);
		}

		// Token: 0x04012975 RID: 76149
		private Table __p;
	}
}

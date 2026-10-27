using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006343 RID: 25411
	public struct ICharacterLookAtEmptyData : IFlatbufferObject
	{
		// Token: 0x1700BD9D RID: 48541
		// (get) Token: 0x0602BF46 RID: 180038 RVA: 0x0060A8EA File Offset: 0x00608AEA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BF47 RID: 180039 RVA: 0x0060A8F7 File Offset: 0x00608AF7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BF48 RID: 180040 RVA: 0x0060A900 File Offset: 0x00608B00
		public static ICharacterLookAtEmptyData GetRootAsICharacterLookAtEmptyData(ByteBuffer _bb)
		{
			return ICharacterLookAtEmptyData.GetRootAsICharacterLookAtEmptyData(_bb, default(ICharacterLookAtEmptyData));
		}

		// Token: 0x0602BF49 RID: 180041 RVA: 0x0060A91C File Offset: 0x00608B1C
		public static ICharacterLookAtEmptyData GetRootAsICharacterLookAtEmptyData(ByteBuffer _bb, ICharacterLookAtEmptyData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BF4A RID: 180042 RVA: 0x0060A939 File Offset: 0x00608B39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BF4B RID: 180043 RVA: 0x0060A948 File Offset: 0x00608B48
		public ICharacterLookAtEmptyData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD9E RID: 48542
		// (get) Token: 0x0602BF4C RID: 180044 RVA: 0x0060A958 File Offset: 0x00608B58
		public ECharacterLookAt Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECharacterLookAt.Empty;
				}
				return (ECharacterLookAt)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BF4D RID: 180045 RVA: 0x0060A994 File Offset: 0x00608B94
		public static Offset<ICharacterLookAtEmptyData> CreateICharacterLookAtEmptyData(FlatBufferBuilder builder, ECharacterLookAt Type = ECharacterLookAt.Empty)
		{
			builder.StartTable(1);
			ICharacterLookAtEmptyData.AddType(builder, Type);
			return ICharacterLookAtEmptyData.EndICharacterLookAtEmptyData(builder);
		}

		// Token: 0x0602BF4E RID: 180046 RVA: 0x0060A9AA File Offset: 0x00608BAA
		public static void StartICharacterLookAtEmptyData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BF4F RID: 180047 RVA: 0x0060A9B3 File Offset: 0x00608BB3
		public static void AddType(FlatBufferBuilder builder, ECharacterLookAt type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BF50 RID: 180048 RVA: 0x0060A9BE File Offset: 0x00608BBE
		public static Offset<ICharacterLookAtEmptyData> EndICharacterLookAtEmptyData(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAtEmptyData>(builder.EndTable());
		}

		// Token: 0x0602BF51 RID: 180049 RVA: 0x0060A9CC File Offset: 0x00608BCC
		public ICharacterLookAtEmptyDataT UnPack()
		{
			ICharacterLookAtEmptyDataT characterLookAtEmptyDataT = new ICharacterLookAtEmptyDataT();
			this.UnPackTo(characterLookAtEmptyDataT);
			return characterLookAtEmptyDataT;
		}

		// Token: 0x0602BF52 RID: 180050 RVA: 0x0060A9E7 File Offset: 0x00608BE7
		public void UnPackTo(ICharacterLookAtEmptyDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BF53 RID: 180051 RVA: 0x0060A9F8 File Offset: 0x00608BF8
		public static Offset<ICharacterLookAtEmptyData> Pack(FlatBufferBuilder builder, ICharacterLookAtEmptyDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAtEmptyData>);
			}
			return ICharacterLookAtEmptyData.CreateICharacterLookAtEmptyData(builder, _o.Type);
		}

		// Token: 0x04010910 RID: 67856
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200634F RID: 25423
	public struct ICharacterLookAtUnlockData : IFlatbufferObject
	{
		// Token: 0x1700BDAD RID: 48557
		// (get) Token: 0x0602BF96 RID: 180118 RVA: 0x0060B068 File Offset: 0x00609268
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BF97 RID: 180119 RVA: 0x0060B075 File Offset: 0x00609275
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BF98 RID: 180120 RVA: 0x0060B07C File Offset: 0x0060927C
		public static ICharacterLookAtUnlockData GetRootAsICharacterLookAtUnlockData(ByteBuffer _bb)
		{
			return ICharacterLookAtUnlockData.GetRootAsICharacterLookAtUnlockData(_bb, default(ICharacterLookAtUnlockData));
		}

		// Token: 0x0602BF99 RID: 180121 RVA: 0x0060B098 File Offset: 0x00609298
		public static ICharacterLookAtUnlockData GetRootAsICharacterLookAtUnlockData(ByteBuffer _bb, ICharacterLookAtUnlockData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BF9A RID: 180122 RVA: 0x0060B0B5 File Offset: 0x006092B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BF9B RID: 180123 RVA: 0x0060B0C4 File Offset: 0x006092C4
		public ICharacterLookAtUnlockData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDAE RID: 48558
		// (get) Token: 0x0602BF9C RID: 180124 RVA: 0x0060B0D4 File Offset: 0x006092D4
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

		// Token: 0x0602BF9D RID: 180125 RVA: 0x0060B110 File Offset: 0x00609310
		public static Offset<ICharacterLookAtUnlockData> CreateICharacterLookAtUnlockData(FlatBufferBuilder builder, ECharacterLookAt Type = ECharacterLookAt.Empty)
		{
			builder.StartTable(1);
			ICharacterLookAtUnlockData.AddType(builder, Type);
			return ICharacterLookAtUnlockData.EndICharacterLookAtUnlockData(builder);
		}

		// Token: 0x0602BF9E RID: 180126 RVA: 0x0060B126 File Offset: 0x00609326
		public static void StartICharacterLookAtUnlockData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BF9F RID: 180127 RVA: 0x0060B12F File Offset: 0x0060932F
		public static void AddType(FlatBufferBuilder builder, ECharacterLookAt type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BFA0 RID: 180128 RVA: 0x0060B13A File Offset: 0x0060933A
		public static Offset<ICharacterLookAtUnlockData> EndICharacterLookAtUnlockData(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAtUnlockData>(builder.EndTable());
		}

		// Token: 0x0602BFA1 RID: 180129 RVA: 0x0060B148 File Offset: 0x00609348
		public ICharacterLookAtUnlockDataT UnPack()
		{
			ICharacterLookAtUnlockDataT characterLookAtUnlockDataT = new ICharacterLookAtUnlockDataT();
			this.UnPackTo(characterLookAtUnlockDataT);
			return characterLookAtUnlockDataT;
		}

		// Token: 0x0602BFA2 RID: 180130 RVA: 0x0060B163 File Offset: 0x00609363
		public void UnPackTo(ICharacterLookAtUnlockDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BFA3 RID: 180131 RVA: 0x0060B174 File Offset: 0x00609374
		public static Offset<ICharacterLookAtUnlockData> Pack(FlatBufferBuilder builder, ICharacterLookAtUnlockDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAtUnlockData>);
			}
			return ICharacterLookAtUnlockData.CreateICharacterLookAtUnlockData(builder, _o.Type);
		}

		// Token: 0x0401091A RID: 67866
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C0 RID: 27072
	public struct ICharacterLookAtUnlockData : IFlatbufferObject
	{
		// Token: 0x1700C735 RID: 50997
		// (get) Token: 0x0602E700 RID: 190208 RVA: 0x006561BC File Offset: 0x006543BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E701 RID: 190209 RVA: 0x006561C9 File Offset: 0x006543C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E702 RID: 190210 RVA: 0x006561D0 File Offset: 0x006543D0
		public static ICharacterLookAtUnlockData GetRootAsICharacterLookAtUnlockData(ByteBuffer _bb)
		{
			return ICharacterLookAtUnlockData.GetRootAsICharacterLookAtUnlockData(_bb, default(ICharacterLookAtUnlockData));
		}

		// Token: 0x0602E703 RID: 190211 RVA: 0x006561EC File Offset: 0x006543EC
		public static ICharacterLookAtUnlockData GetRootAsICharacterLookAtUnlockData(ByteBuffer _bb, ICharacterLookAtUnlockData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E704 RID: 190212 RVA: 0x00656209 File Offset: 0x00654409
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E705 RID: 190213 RVA: 0x00656218 File Offset: 0x00654418
		public ICharacterLookAtUnlockData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C736 RID: 50998
		// (get) Token: 0x0602E706 RID: 190214 RVA: 0x00656228 File Offset: 0x00654428
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

		// Token: 0x0602E707 RID: 190215 RVA: 0x00656264 File Offset: 0x00654464
		public static Offset<ICharacterLookAtUnlockData> CreateICharacterLookAtUnlockData(FlatBufferBuilder builder, ECharacterLookAt Type = ECharacterLookAt.Empty)
		{
			builder.StartTable(1);
			ICharacterLookAtUnlockData.AddType(builder, Type);
			return ICharacterLookAtUnlockData.EndICharacterLookAtUnlockData(builder);
		}

		// Token: 0x0602E708 RID: 190216 RVA: 0x0065627A File Offset: 0x0065447A
		public static void StartICharacterLookAtUnlockData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E709 RID: 190217 RVA: 0x00656283 File Offset: 0x00654483
		public static void AddType(FlatBufferBuilder builder, ECharacterLookAt type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E70A RID: 190218 RVA: 0x0065628E File Offset: 0x0065448E
		public static Offset<ICharacterLookAtUnlockData> EndICharacterLookAtUnlockData(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAtUnlockData>(builder.EndTable());
		}

		// Token: 0x0602E70B RID: 190219 RVA: 0x0065629C File Offset: 0x0065449C
		public ICharacterLookAtUnlockDataT UnPack()
		{
			ICharacterLookAtUnlockDataT characterLookAtUnlockDataT = new ICharacterLookAtUnlockDataT();
			this.UnPackTo(characterLookAtUnlockDataT);
			return characterLookAtUnlockDataT;
		}

		// Token: 0x0602E70C RID: 190220 RVA: 0x006562B7 File Offset: 0x006544B7
		public void UnPackTo(ICharacterLookAtUnlockDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E70D RID: 190221 RVA: 0x006562C8 File Offset: 0x006544C8
		public static Offset<ICharacterLookAtUnlockData> Pack(FlatBufferBuilder builder, ICharacterLookAtUnlockDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAtUnlockData>);
			}
			return ICharacterLookAtUnlockData.CreateICharacterLookAtUnlockData(builder, _o.Type);
		}

		// Token: 0x0401172F RID: 71471
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E5E RID: 28254
	public struct IRemovePreloadResourceCharacterType : IFlatbufferObject
	{
		// Token: 0x1700D276 RID: 53878
		// (get) Token: 0x06031ED2 RID: 204498 RVA: 0x006C1441 File Offset: 0x006BF641
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031ED3 RID: 204499 RVA: 0x006C144E File Offset: 0x006BF64E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031ED4 RID: 204500 RVA: 0x006C1458 File Offset: 0x006BF658
		public static IRemovePreloadResourceCharacterType GetRootAsIRemovePreloadResourceCharacterType(ByteBuffer _bb)
		{
			return IRemovePreloadResourceCharacterType.GetRootAsIRemovePreloadResourceCharacterType(_bb, default(IRemovePreloadResourceCharacterType));
		}

		// Token: 0x06031ED5 RID: 204501 RVA: 0x006C1474 File Offset: 0x006BF674
		public static IRemovePreloadResourceCharacterType GetRootAsIRemovePreloadResourceCharacterType(ByteBuffer _bb, IRemovePreloadResourceCharacterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031ED6 RID: 204502 RVA: 0x006C1491 File Offset: 0x006BF691
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031ED7 RID: 204503 RVA: 0x006C14A0 File Offset: 0x006BF6A0
		public IRemovePreloadResourceCharacterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D277 RID: 53879
		// (get) Token: 0x06031ED8 RID: 204504 RVA: 0x006C14B0 File Offset: 0x006BF6B0
		public ERemovePreloadResourceObjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
				}
				return (ERemovePreloadResourceObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031ED9 RID: 204505 RVA: 0x006C14EC File Offset: 0x006BF6EC
		public static Offset<IRemovePreloadResourceCharacterType> CreateIRemovePreloadResourceCharacterType(FlatBufferBuilder builder, ERemovePreloadResourceObjectType Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter)
		{
			builder.StartTable(1);
			IRemovePreloadResourceCharacterType.AddType(builder, Type);
			return IRemovePreloadResourceCharacterType.EndIRemovePreloadResourceCharacterType(builder);
		}

		// Token: 0x06031EDA RID: 204506 RVA: 0x006C1502 File Offset: 0x006BF702
		public static void StartIRemovePreloadResourceCharacterType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031EDB RID: 204507 RVA: 0x006C150B File Offset: 0x006BF70B
		public static void AddType(FlatBufferBuilder builder, ERemovePreloadResourceObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031EDC RID: 204508 RVA: 0x006C1516 File Offset: 0x006BF716
		public static Offset<IRemovePreloadResourceCharacterType> EndIRemovePreloadResourceCharacterType(FlatBufferBuilder builder)
		{
			return new Offset<IRemovePreloadResourceCharacterType>(builder.EndTable());
		}

		// Token: 0x06031EDD RID: 204509 RVA: 0x006C1524 File Offset: 0x006BF724
		public IRemovePreloadResourceCharacterTypeT UnPack()
		{
			IRemovePreloadResourceCharacterTypeT removePreloadResourceCharacterTypeT = new IRemovePreloadResourceCharacterTypeT();
			this.UnPackTo(removePreloadResourceCharacterTypeT);
			return removePreloadResourceCharacterTypeT;
		}

		// Token: 0x06031EDE RID: 204510 RVA: 0x006C153F File Offset: 0x006BF73F
		public void UnPackTo(IRemovePreloadResourceCharacterTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031EDF RID: 204511 RVA: 0x006C1550 File Offset: 0x006BF750
		public static Offset<IRemovePreloadResourceCharacterType> Pack(FlatBufferBuilder builder, IRemovePreloadResourceCharacterTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemovePreloadResourceCharacterType>);
			}
			return IRemovePreloadResourceCharacterType.CreateIRemovePreloadResourceCharacterType(builder, _o.Type);
		}

		// Token: 0x04011842 RID: 71746
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075DF RID: 30175
	public struct IRemovePreloadResourceCharacterType : IFlatbufferObject
	{
		// Token: 0x1700DDC8 RID: 56776
		// (get) Token: 0x06034EFA RID: 216826 RVA: 0x0071CF41 File Offset: 0x0071B141
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034EFB RID: 216827 RVA: 0x0071CF4E File Offset: 0x0071B14E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034EFC RID: 216828 RVA: 0x0071CF58 File Offset: 0x0071B158
		public static IRemovePreloadResourceCharacterType GetRootAsIRemovePreloadResourceCharacterType(ByteBuffer _bb)
		{
			return IRemovePreloadResourceCharacterType.GetRootAsIRemovePreloadResourceCharacterType(_bb, default(IRemovePreloadResourceCharacterType));
		}

		// Token: 0x06034EFD RID: 216829 RVA: 0x0071CF74 File Offset: 0x0071B174
		public static IRemovePreloadResourceCharacterType GetRootAsIRemovePreloadResourceCharacterType(ByteBuffer _bb, IRemovePreloadResourceCharacterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034EFE RID: 216830 RVA: 0x0071CF91 File Offset: 0x0071B191
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034EFF RID: 216831 RVA: 0x0071CFA0 File Offset: 0x0071B1A0
		public IRemovePreloadResourceCharacterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDC9 RID: 56777
		// (get) Token: 0x06034F00 RID: 216832 RVA: 0x0071CFB0 File Offset: 0x0071B1B0
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

		// Token: 0x06034F01 RID: 216833 RVA: 0x0071CFEC File Offset: 0x0071B1EC
		public static Offset<IRemovePreloadResourceCharacterType> CreateIRemovePreloadResourceCharacterType(FlatBufferBuilder builder, ERemovePreloadResourceObjectType Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter)
		{
			builder.StartTable(1);
			IRemovePreloadResourceCharacterType.AddType(builder, Type);
			return IRemovePreloadResourceCharacterType.EndIRemovePreloadResourceCharacterType(builder);
		}

		// Token: 0x06034F02 RID: 216834 RVA: 0x0071D002 File Offset: 0x0071B202
		public static void StartIRemovePreloadResourceCharacterType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034F03 RID: 216835 RVA: 0x0071D00B File Offset: 0x0071B20B
		public static void AddType(FlatBufferBuilder builder, ERemovePreloadResourceObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034F04 RID: 216836 RVA: 0x0071D016 File Offset: 0x0071B216
		public static Offset<IRemovePreloadResourceCharacterType> EndIRemovePreloadResourceCharacterType(FlatBufferBuilder builder)
		{
			return new Offset<IRemovePreloadResourceCharacterType>(builder.EndTable());
		}

		// Token: 0x06034F05 RID: 216837 RVA: 0x0071D024 File Offset: 0x0071B224
		public IRemovePreloadResourceCharacterTypeT UnPack()
		{
			IRemovePreloadResourceCharacterTypeT removePreloadResourceCharacterTypeT = new IRemovePreloadResourceCharacterTypeT();
			this.UnPackTo(removePreloadResourceCharacterTypeT);
			return removePreloadResourceCharacterTypeT;
		}

		// Token: 0x06034F06 RID: 216838 RVA: 0x0071D03F File Offset: 0x0071B23F
		public void UnPackTo(IRemovePreloadResourceCharacterTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034F07 RID: 216839 RVA: 0x0071D050 File Offset: 0x0071B250
		public static Offset<IRemovePreloadResourceCharacterType> Pack(FlatBufferBuilder builder, IRemovePreloadResourceCharacterTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemovePreloadResourceCharacterType>);
			}
			return IRemovePreloadResourceCharacterType.CreateIRemovePreloadResourceCharacterType(builder, _o.Type);
		}

		// Token: 0x040127C4 RID: 75716
		private Table __p;
	}
}

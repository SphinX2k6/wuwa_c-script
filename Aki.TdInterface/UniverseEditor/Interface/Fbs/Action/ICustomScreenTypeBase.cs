using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006510 RID: 25872
	public struct ICustomScreenTypeBase : IFlatbufferObject
	{
		// Token: 0x1700C063 RID: 49251
		// (get) Token: 0x0602CE13 RID: 183827 RVA: 0x0062A036 File Offset: 0x00628236
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CE14 RID: 183828 RVA: 0x0062A043 File Offset: 0x00628243
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CE15 RID: 183829 RVA: 0x0062A04C File Offset: 0x0062824C
		public static ICustomScreenTypeBase GetRootAsICustomScreenTypeBase(ByteBuffer _bb)
		{
			return ICustomScreenTypeBase.GetRootAsICustomScreenTypeBase(_bb, default(ICustomScreenTypeBase));
		}

		// Token: 0x0602CE16 RID: 183830 RVA: 0x0062A068 File Offset: 0x00628268
		public static ICustomScreenTypeBase GetRootAsICustomScreenTypeBase(ByteBuffer _bb, ICustomScreenTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CE17 RID: 183831 RVA: 0x0062A085 File Offset: 0x00628285
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CE18 RID: 183832 RVA: 0x0062A094 File Offset: 0x00628294
		public ICustomScreenTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C064 RID: 49252
		// (get) Token: 0x0602CE19 RID: 183833 RVA: 0x0062A0A4 File Offset: 0x006282A4
		public ECustomScreenType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECustomScreenType.Spine;
				}
				return (ECustomScreenType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CE1A RID: 183834 RVA: 0x0062A0E0 File Offset: 0x006282E0
		public static Offset<ICustomScreenTypeBase> CreateICustomScreenTypeBase(FlatBufferBuilder builder, ECustomScreenType Type = ECustomScreenType.Spine)
		{
			builder.StartTable(1);
			ICustomScreenTypeBase.AddType(builder, Type);
			return ICustomScreenTypeBase.EndICustomScreenTypeBase(builder);
		}

		// Token: 0x0602CE1B RID: 183835 RVA: 0x0062A0F6 File Offset: 0x006282F6
		public static void StartICustomScreenTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CE1C RID: 183836 RVA: 0x0062A0FF File Offset: 0x006282FF
		public static void AddType(FlatBufferBuilder builder, ECustomScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CE1D RID: 183837 RVA: 0x0062A10A File Offset: 0x0062830A
		public static Offset<ICustomScreenTypeBase> EndICustomScreenTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenTypeBase>(builder.EndTable());
		}

		// Token: 0x0602CE1E RID: 183838 RVA: 0x0062A118 File Offset: 0x00628318
		public ICustomScreenTypeBaseT UnPack()
		{
			ICustomScreenTypeBaseT customScreenTypeBaseT = new ICustomScreenTypeBaseT();
			this.UnPackTo(customScreenTypeBaseT);
			return customScreenTypeBaseT;
		}

		// Token: 0x0602CE1F RID: 183839 RVA: 0x0062A133 File Offset: 0x00628333
		public void UnPackTo(ICustomScreenTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CE20 RID: 183840 RVA: 0x0062A144 File Offset: 0x00628344
		public static Offset<ICustomScreenTypeBase> Pack(FlatBufferBuilder builder, ICustomScreenTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenTypeBase>);
			}
			return ICustomScreenTypeBase.CreateICustomScreenTypeBase(builder, _o.Type);
		}

		// Token: 0x04010B55 RID: 68437
		private Table __p;
	}
}

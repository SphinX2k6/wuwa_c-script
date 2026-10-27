using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069BD RID: 27069
	public struct IItemGetUiConfigBase : IFlatbufferObject
	{
		// Token: 0x1700C8C7 RID: 51399
		// (get) Token: 0x0602F4C3 RID: 193731 RVA: 0x00671079 File Offset: 0x0066F279
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F4C4 RID: 193732 RVA: 0x00671086 File Offset: 0x0066F286
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F4C5 RID: 193733 RVA: 0x00671090 File Offset: 0x0066F290
		public static IItemGetUiConfigBase GetRootAsIItemGetUiConfigBase(ByteBuffer _bb)
		{
			return IItemGetUiConfigBase.GetRootAsIItemGetUiConfigBase(_bb, default(IItemGetUiConfigBase));
		}

		// Token: 0x0602F4C6 RID: 193734 RVA: 0x006710AC File Offset: 0x0066F2AC
		public static IItemGetUiConfigBase GetRootAsIItemGetUiConfigBase(ByteBuffer _bb, IItemGetUiConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F4C7 RID: 193735 RVA: 0x006710C9 File Offset: 0x0066F2C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F4C8 RID: 193736 RVA: 0x006710D8 File Offset: 0x0066F2D8
		public IItemGetUiConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8C8 RID: 51400
		// (get) Token: 0x0602F4C9 RID: 193737 RVA: 0x006710E8 File Offset: 0x0066F2E8
		public EItemGetUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EItemGetUiType.None;
				}
				return (EItemGetUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F4CA RID: 193738 RVA: 0x00671124 File Offset: 0x0066F324
		public static Offset<IItemGetUiConfigBase> CreateIItemGetUiConfigBase(FlatBufferBuilder builder, EItemGetUiType Type = EItemGetUiType.None)
		{
			builder.StartTable(1);
			IItemGetUiConfigBase.AddType(builder, Type);
			return IItemGetUiConfigBase.EndIItemGetUiConfigBase(builder);
		}

		// Token: 0x0602F4CB RID: 193739 RVA: 0x0067113A File Offset: 0x0066F33A
		public static void StartIItemGetUiConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F4CC RID: 193740 RVA: 0x00671143 File Offset: 0x0066F343
		public static void AddType(FlatBufferBuilder builder, EItemGetUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F4CD RID: 193741 RVA: 0x0067114E File Offset: 0x0066F34E
		public static Offset<IItemGetUiConfigBase> EndIItemGetUiConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IItemGetUiConfigBase>(builder.EndTable());
		}

		// Token: 0x0602F4CE RID: 193742 RVA: 0x0067115C File Offset: 0x0066F35C
		public IItemGetUiConfigBaseT UnPack()
		{
			IItemGetUiConfigBaseT itemGetUiConfigBaseT = new IItemGetUiConfigBaseT();
			this.UnPackTo(itemGetUiConfigBaseT);
			return itemGetUiConfigBaseT;
		}

		// Token: 0x0602F4CF RID: 193743 RVA: 0x00671177 File Offset: 0x0066F377
		public void UnPackTo(IItemGetUiConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F4D0 RID: 193744 RVA: 0x00671188 File Offset: 0x0066F388
		public static Offset<IItemGetUiConfigBase> Pack(FlatBufferBuilder builder, IItemGetUiConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemGetUiConfigBase>);
			}
			return IItemGetUiConfigBase.CreateIItemGetUiConfigBase(builder, _o.Type);
		}

		// Token: 0x0401116A RID: 69994
		private Table __p;
	}
}

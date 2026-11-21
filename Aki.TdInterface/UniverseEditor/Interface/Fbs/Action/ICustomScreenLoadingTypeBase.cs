using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B72 RID: 27506
	public struct ICustomScreenLoadingTypeBase : IFlatbufferObject
	{
		// Token: 0x1700C9E2 RID: 51682
		// (get) Token: 0x0602F559 RID: 193881 RVA: 0x00675BA5 File Offset: 0x00673DA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F55A RID: 193882 RVA: 0x00675BB2 File Offset: 0x00673DB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F55B RID: 193883 RVA: 0x00675BBC File Offset: 0x00673DBC
		public static ICustomScreenLoadingTypeBase GetRootAsICustomScreenLoadingTypeBase(ByteBuffer _bb)
		{
			return ICustomScreenLoadingTypeBase.GetRootAsICustomScreenLoadingTypeBase(_bb, default(ICustomScreenLoadingTypeBase));
		}

		// Token: 0x0602F55C RID: 193884 RVA: 0x00675BD8 File Offset: 0x00673DD8
		public static ICustomScreenLoadingTypeBase GetRootAsICustomScreenLoadingTypeBase(ByteBuffer _bb, ICustomScreenLoadingTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F55D RID: 193885 RVA: 0x00675BF5 File Offset: 0x00673DF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F55E RID: 193886 RVA: 0x00675C04 File Offset: 0x00673E04
		public ICustomScreenLoadingTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9E3 RID: 51683
		// (get) Token: 0x0602F55F RID: 193887 RVA: 0x00675C14 File Offset: 0x00673E14
		public ECustomScreenLoading Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECustomScreenLoading.Cyberpunk;
				}
				return (ECustomScreenLoading)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F560 RID: 193888 RVA: 0x00675C50 File Offset: 0x00673E50
		public static Offset<ICustomScreenLoadingTypeBase> CreateICustomScreenLoadingTypeBase(FlatBufferBuilder builder, ECustomScreenLoading Type = ECustomScreenLoading.Cyberpunk)
		{
			builder.StartTable(1);
			ICustomScreenLoadingTypeBase.AddType(builder, Type);
			return ICustomScreenLoadingTypeBase.EndICustomScreenLoadingTypeBase(builder);
		}

		// Token: 0x0602F561 RID: 193889 RVA: 0x00675C66 File Offset: 0x00673E66
		public static void StartICustomScreenLoadingTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F562 RID: 193890 RVA: 0x00675C6F File Offset: 0x00673E6F
		public static void AddType(FlatBufferBuilder builder, ECustomScreenLoading type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F563 RID: 193891 RVA: 0x00675C7A File Offset: 0x00673E7A
		public static Offset<ICustomScreenLoadingTypeBase> EndICustomScreenLoadingTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenLoadingTypeBase>(builder.EndTable());
		}

		// Token: 0x0602F564 RID: 193892 RVA: 0x00675C88 File Offset: 0x00673E88
		public ICustomScreenLoadingTypeBaseT UnPack()
		{
			ICustomScreenLoadingTypeBaseT customScreenLoadingTypeBaseT = new ICustomScreenLoadingTypeBaseT();
			this.UnPackTo(customScreenLoadingTypeBaseT);
			return customScreenLoadingTypeBaseT;
		}

		// Token: 0x0602F565 RID: 193893 RVA: 0x00675CA3 File Offset: 0x00673EA3
		public void UnPackTo(ICustomScreenLoadingTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F566 RID: 193894 RVA: 0x00675CB4 File Offset: 0x00673EB4
		public static Offset<ICustomScreenLoadingTypeBase> Pack(FlatBufferBuilder builder, ICustomScreenLoadingTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenLoadingTypeBase>);
			}
			return ICustomScreenLoadingTypeBase.CreateICustomScreenLoadingTypeBase(builder, _o.Type);
		}

		// Token: 0x0401195E RID: 72030
		private Table __p;
	}
}

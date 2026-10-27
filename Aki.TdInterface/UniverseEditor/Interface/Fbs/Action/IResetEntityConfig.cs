using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E7F RID: 28287
	public struct IResetEntityConfig : IFlatbufferObject
	{
		// Token: 0x1700D2AC RID: 53932
		// (get) Token: 0x06031FE9 RID: 204777 RVA: 0x006C3541 File Offset: 0x006C1741
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031FEA RID: 204778 RVA: 0x006C354E File Offset: 0x006C174E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031FEB RID: 204779 RVA: 0x006C3558 File Offset: 0x006C1758
		public static IResetEntityConfig GetRootAsIResetEntityConfig(ByteBuffer _bb)
		{
			return IResetEntityConfig.GetRootAsIResetEntityConfig(_bb, default(IResetEntityConfig));
		}

		// Token: 0x06031FEC RID: 204780 RVA: 0x006C3574 File Offset: 0x006C1774
		public static IResetEntityConfig GetRootAsIResetEntityConfig(ByteBuffer _bb, IResetEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031FED RID: 204781 RVA: 0x006C3591 File Offset: 0x006C1791
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031FEE RID: 204782 RVA: 0x006C35A0 File Offset: 0x006C17A0
		public IResetEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2AD RID: 53933
		// (get) Token: 0x06031FEF RID: 204783 RVA: 0x006C35B0 File Offset: 0x006C17B0
		public EResetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetEntityType.TeleControl;
				}
				return (EResetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031FF0 RID: 204784 RVA: 0x006C35EC File Offset: 0x006C17EC
		public static Offset<IResetEntityConfig> CreateIResetEntityConfig(FlatBufferBuilder builder, EResetEntityType Type = EResetEntityType.TeleControl)
		{
			builder.StartTable(1);
			IResetEntityConfig.AddType(builder, Type);
			return IResetEntityConfig.EndIResetEntityConfig(builder);
		}

		// Token: 0x06031FF1 RID: 204785 RVA: 0x006C3602 File Offset: 0x006C1802
		public static void StartIResetEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031FF2 RID: 204786 RVA: 0x006C360B File Offset: 0x006C180B
		public static void AddType(FlatBufferBuilder builder, EResetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031FF3 RID: 204787 RVA: 0x006C3616 File Offset: 0x006C1816
		public static Offset<IResetEntityConfig> EndIResetEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IResetEntityConfig>(builder.EndTable());
		}

		// Token: 0x06031FF4 RID: 204788 RVA: 0x006C3624 File Offset: 0x006C1824
		public IResetEntityConfigT UnPack()
		{
			IResetEntityConfigT resetEntityConfigT = new IResetEntityConfigT();
			this.UnPackTo(resetEntityConfigT);
			return resetEntityConfigT;
		}

		// Token: 0x06031FF5 RID: 204789 RVA: 0x006C363F File Offset: 0x006C183F
		public void UnPackTo(IResetEntityConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031FF6 RID: 204790 RVA: 0x006C3650 File Offset: 0x006C1850
		public static Offset<IResetEntityConfig> Pack(FlatBufferBuilder builder, IResetEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetEntityConfig>);
			}
			return IResetEntityConfig.CreateIResetEntityConfig(builder, _o.Type);
		}

		// Token: 0x0401186A RID: 71786
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200596B RID: 22891
	public struct ISpecialAnimalTypeConfig : IFlatbufferObject
	{
		// Token: 0x1700ABCF RID: 43983
		// (get) Token: 0x06026C03 RID: 158723 RVA: 0x00555D50 File Offset: 0x00553F50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026C04 RID: 158724 RVA: 0x00555D5D File Offset: 0x00553F5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026C05 RID: 158725 RVA: 0x00555D64 File Offset: 0x00553F64
		public static ISpecialAnimalTypeConfig GetRootAsISpecialAnimalTypeConfig(ByteBuffer _bb)
		{
			return ISpecialAnimalTypeConfig.GetRootAsISpecialAnimalTypeConfig(_bb, default(ISpecialAnimalTypeConfig));
		}

		// Token: 0x06026C06 RID: 158726 RVA: 0x00555D80 File Offset: 0x00553F80
		public static ISpecialAnimalTypeConfig GetRootAsISpecialAnimalTypeConfig(ByteBuffer _bb, ISpecialAnimalTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026C07 RID: 158727 RVA: 0x00555D9D File Offset: 0x00553F9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026C08 RID: 158728 RVA: 0x00555DAC File Offset: 0x00553FAC
		public ISpecialAnimalTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABD0 RID: 43984
		// (get) Token: 0x06026C09 RID: 158729 RVA: 0x00555DBC File Offset: 0x00553FBC
		public ESpecialAnimalType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialAnimalType.CollectAnimal;
				}
				return (ESpecialAnimalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026C0A RID: 158730 RVA: 0x00555DF8 File Offset: 0x00553FF8
		public static Offset<ISpecialAnimalTypeConfig> CreateISpecialAnimalTypeConfig(FlatBufferBuilder builder, ESpecialAnimalType Type = ESpecialAnimalType.CollectAnimal)
		{
			builder.StartTable(1);
			ISpecialAnimalTypeConfig.AddType(builder, Type);
			return ISpecialAnimalTypeConfig.EndISpecialAnimalTypeConfig(builder);
		}

		// Token: 0x06026C0B RID: 158731 RVA: 0x00555E0E File Offset: 0x0055400E
		public static void StartISpecialAnimalTypeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026C0C RID: 158732 RVA: 0x00555E17 File Offset: 0x00554017
		public static void AddType(FlatBufferBuilder builder, ESpecialAnimalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026C0D RID: 158733 RVA: 0x00555E22 File Offset: 0x00554022
		public static Offset<ISpecialAnimalTypeConfig> EndISpecialAnimalTypeConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpecialAnimalTypeConfig>(builder.EndTable());
		}

		// Token: 0x06026C0E RID: 158734 RVA: 0x00555E30 File Offset: 0x00554030
		public ISpecialAnimalTypeConfigT UnPack()
		{
			ISpecialAnimalTypeConfigT specialAnimalTypeConfigT = new ISpecialAnimalTypeConfigT();
			this.UnPackTo(specialAnimalTypeConfigT);
			return specialAnimalTypeConfigT;
		}

		// Token: 0x06026C0F RID: 158735 RVA: 0x00555E4B File Offset: 0x0055404B
		public void UnPackTo(ISpecialAnimalTypeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026C10 RID: 158736 RVA: 0x00555E5C File Offset: 0x0055405C
		public static Offset<ISpecialAnimalTypeConfig> Pack(FlatBufferBuilder builder, ISpecialAnimalTypeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecialAnimalTypeConfig>);
			}
			return ISpecialAnimalTypeConfig.CreateISpecialAnimalTypeConfig(builder, _o.Type);
		}

		// Token: 0x0400EF55 RID: 61269
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F78 RID: 24440
	public struct ISpecialAnimalTypeConfig : IFlatbufferObject
	{
		// Token: 0x1700B503 RID: 46339
		// (get) Token: 0x0602916D RID: 168301 RVA: 0x0059C9BC File Offset: 0x0059ABBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602916E RID: 168302 RVA: 0x0059C9C9 File Offset: 0x0059ABC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602916F RID: 168303 RVA: 0x0059C9D0 File Offset: 0x0059ABD0
		public static ISpecialAnimalTypeConfig GetRootAsISpecialAnimalTypeConfig(ByteBuffer _bb)
		{
			return ISpecialAnimalTypeConfig.GetRootAsISpecialAnimalTypeConfig(_bb, default(ISpecialAnimalTypeConfig));
		}

		// Token: 0x06029170 RID: 168304 RVA: 0x0059C9EC File Offset: 0x0059ABEC
		public static ISpecialAnimalTypeConfig GetRootAsISpecialAnimalTypeConfig(ByteBuffer _bb, ISpecialAnimalTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029171 RID: 168305 RVA: 0x0059CA09 File Offset: 0x0059AC09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029172 RID: 168306 RVA: 0x0059CA18 File Offset: 0x0059AC18
		public ISpecialAnimalTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B504 RID: 46340
		// (get) Token: 0x06029173 RID: 168307 RVA: 0x0059CA28 File Offset: 0x0059AC28
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

		// Token: 0x06029174 RID: 168308 RVA: 0x0059CA64 File Offset: 0x0059AC64
		public static Offset<ISpecialAnimalTypeConfig> CreateISpecialAnimalTypeConfig(FlatBufferBuilder builder, ESpecialAnimalType Type = ESpecialAnimalType.CollectAnimal)
		{
			builder.StartTable(1);
			ISpecialAnimalTypeConfig.AddType(builder, Type);
			return ISpecialAnimalTypeConfig.EndISpecialAnimalTypeConfig(builder);
		}

		// Token: 0x06029175 RID: 168309 RVA: 0x0059CA7A File Offset: 0x0059AC7A
		public static void StartISpecialAnimalTypeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029176 RID: 168310 RVA: 0x0059CA83 File Offset: 0x0059AC83
		public static void AddType(FlatBufferBuilder builder, ESpecialAnimalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029177 RID: 168311 RVA: 0x0059CA8E File Offset: 0x0059AC8E
		public static Offset<ISpecialAnimalTypeConfig> EndISpecialAnimalTypeConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpecialAnimalTypeConfig>(builder.EndTable());
		}

		// Token: 0x06029178 RID: 168312 RVA: 0x0059CA9C File Offset: 0x0059AC9C
		public ISpecialAnimalTypeConfigT UnPack()
		{
			ISpecialAnimalTypeConfigT specialAnimalTypeConfigT = new ISpecialAnimalTypeConfigT();
			this.UnPackTo(specialAnimalTypeConfigT);
			return specialAnimalTypeConfigT;
		}

		// Token: 0x06029179 RID: 168313 RVA: 0x0059CAB7 File Offset: 0x0059ACB7
		public void UnPackTo(ISpecialAnimalTypeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602917A RID: 168314 RVA: 0x0059CAC8 File Offset: 0x0059ACC8
		public static Offset<ISpecialAnimalTypeConfig> Pack(FlatBufferBuilder builder, ISpecialAnimalTypeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecialAnimalTypeConfig>);
			}
			return ISpecialAnimalTypeConfig.CreateISpecialAnimalTypeConfig(builder, _o.Type);
		}

		// Token: 0x0400FC4A RID: 64586
		private Table __p;
	}
}

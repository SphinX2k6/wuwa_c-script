using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FB2 RID: 20402
	public struct ICollectAnimalPartsConfig : IFlatbufferObject
	{
		// Token: 0x170093C3 RID: 37827
		// (get) Token: 0x06020793 RID: 133011 RVA: 0x00484A44 File Offset: 0x00482C44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020794 RID: 133012 RVA: 0x00484A51 File Offset: 0x00482C51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020795 RID: 133013 RVA: 0x00484A58 File Offset: 0x00482C58
		public static ICollectAnimalPartsConfig GetRootAsICollectAnimalPartsConfig(ByteBuffer _bb)
		{
			return ICollectAnimalPartsConfig.GetRootAsICollectAnimalPartsConfig(_bb, default(ICollectAnimalPartsConfig));
		}

		// Token: 0x06020796 RID: 133014 RVA: 0x00484A74 File Offset: 0x00482C74
		public static ICollectAnimalPartsConfig GetRootAsICollectAnimalPartsConfig(ByteBuffer _bb, ICollectAnimalPartsConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020797 RID: 133015 RVA: 0x00484A91 File Offset: 0x00482C91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020798 RID: 133016 RVA: 0x00484AA0 File Offset: 0x00482CA0
		public ICollectAnimalPartsConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093C4 RID: 37828
		// (get) Token: 0x06020799 RID: 133017 RVA: 0x00484AB0 File Offset: 0x00482CB0
		public ECollectAnimalPartSlot Slot
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECollectAnimalPartSlot.Slot0;
				}
				return (ECollectAnimalPartSlot)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093C5 RID: 37829
		// (get) Token: 0x0602079A RID: 133018 RVA: 0x00484AEC File Offset: 0x00482CEC
		public string Skeleton
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602079B RID: 133019 RVA: 0x00484B23 File Offset: 0x00482D23
		public Span<byte> GetSkeletonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602079C RID: 133020 RVA: 0x00484B32 File Offset: 0x00482D32
		public byte[] GetSkeletonArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170093C6 RID: 37830
		// (get) Token: 0x0602079D RID: 133021 RVA: 0x00484B40 File Offset: 0x00482D40
		public int CollectEntity
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602079E RID: 133022 RVA: 0x00484B7C File Offset: 0x00482D7C
		public static Offset<ICollectAnimalPartsConfig> CreateICollectAnimalPartsConfig(FlatBufferBuilder builder, ECollectAnimalPartSlot Slot = ECollectAnimalPartSlot.Slot0, StringOffset SkeletonOffset = default(StringOffset), int CollectEntity = 0)
		{
			builder.StartTable(3);
			ICollectAnimalPartsConfig.AddCollectEntity(builder, CollectEntity);
			ICollectAnimalPartsConfig.AddSkeleton(builder, SkeletonOffset);
			ICollectAnimalPartsConfig.AddSlot(builder, Slot);
			return ICollectAnimalPartsConfig.EndICollectAnimalPartsConfig(builder);
		}

		// Token: 0x0602079F RID: 133023 RVA: 0x00484BA0 File Offset: 0x00482DA0
		public static void StartICollectAnimalPartsConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060207A0 RID: 133024 RVA: 0x00484BA9 File Offset: 0x00482DA9
		public static void AddSlot(FlatBufferBuilder builder, ECollectAnimalPartSlot slot)
		{
			builder.AddByte(0, (byte)slot, 0);
		}

		// Token: 0x060207A1 RID: 133025 RVA: 0x00484BB4 File Offset: 0x00482DB4
		public static void AddSkeleton(FlatBufferBuilder builder, StringOffset skeletonOffset)
		{
			builder.AddOffset(1, skeletonOffset.Value, 0);
		}

		// Token: 0x060207A2 RID: 133026 RVA: 0x00484BC4 File Offset: 0x00482DC4
		public static void AddCollectEntity(FlatBufferBuilder builder, int collectEntity)
		{
			builder.AddInt(2, collectEntity, 0);
		}

		// Token: 0x060207A3 RID: 133027 RVA: 0x00484BCF File Offset: 0x00482DCF
		public static Offset<ICollectAnimalPartsConfig> EndICollectAnimalPartsConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICollectAnimalPartsConfig>(builder.EndTable());
		}

		// Token: 0x060207A4 RID: 133028 RVA: 0x00484BDC File Offset: 0x00482DDC
		public ICollectAnimalPartsConfigT UnPack()
		{
			ICollectAnimalPartsConfigT collectAnimalPartsConfigT = new ICollectAnimalPartsConfigT();
			this.UnPackTo(collectAnimalPartsConfigT);
			return collectAnimalPartsConfigT;
		}

		// Token: 0x060207A5 RID: 133029 RVA: 0x00484BF7 File Offset: 0x00482DF7
		public void UnPackTo(ICollectAnimalPartsConfigT _o)
		{
			_o.Slot = this.Slot;
			_o.Skeleton = this.Skeleton;
			_o.CollectEntity = this.CollectEntity;
		}

		// Token: 0x060207A6 RID: 133030 RVA: 0x00484C20 File Offset: 0x00482E20
		public static Offset<ICollectAnimalPartsConfig> Pack(FlatBufferBuilder builder, ICollectAnimalPartsConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICollectAnimalPartsConfig>);
			}
			StringOffset skeletonOffset = (_o.Skeleton == null) ? default(StringOffset) : builder.CreateString(_o.Skeleton);
			return ICollectAnimalPartsConfig.CreateICollectAnimalPartsConfig(builder, _o.Slot, skeletonOffset, _o.CollectEntity);
		}

		// Token: 0x0400DE8B RID: 56971
		private Table __p;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200550E RID: 21774
	public struct ICollectAnimalPartsConfig : IFlatbufferObject
	{
		// Token: 0x17009B9B RID: 39835
		// (get) Token: 0x06022687 RID: 140935 RVA: 0x004BDF28 File Offset: 0x004BC128
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022688 RID: 140936 RVA: 0x004BDF35 File Offset: 0x004BC135
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022689 RID: 140937 RVA: 0x004BDF3C File Offset: 0x004BC13C
		public static ICollectAnimalPartsConfig GetRootAsICollectAnimalPartsConfig(ByteBuffer _bb)
		{
			return ICollectAnimalPartsConfig.GetRootAsICollectAnimalPartsConfig(_bb, default(ICollectAnimalPartsConfig));
		}

		// Token: 0x0602268A RID: 140938 RVA: 0x004BDF58 File Offset: 0x004BC158
		public static ICollectAnimalPartsConfig GetRootAsICollectAnimalPartsConfig(ByteBuffer _bb, ICollectAnimalPartsConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602268B RID: 140939 RVA: 0x004BDF75 File Offset: 0x004BC175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602268C RID: 140940 RVA: 0x004BDF84 File Offset: 0x004BC184
		public ICollectAnimalPartsConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B9C RID: 39836
		// (get) Token: 0x0602268D RID: 140941 RVA: 0x004BDF94 File Offset: 0x004BC194
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

		// Token: 0x17009B9D RID: 39837
		// (get) Token: 0x0602268E RID: 140942 RVA: 0x004BDFD0 File Offset: 0x004BC1D0
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

		// Token: 0x0602268F RID: 140943 RVA: 0x004BE007 File Offset: 0x004BC207
		public Span<byte> GetSkeletonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022690 RID: 140944 RVA: 0x004BE016 File Offset: 0x004BC216
		public byte[] GetSkeletonArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009B9E RID: 39838
		// (get) Token: 0x06022691 RID: 140945 RVA: 0x004BE024 File Offset: 0x004BC224
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

		// Token: 0x06022692 RID: 140946 RVA: 0x004BE060 File Offset: 0x004BC260
		public static Offset<ICollectAnimalPartsConfig> CreateICollectAnimalPartsConfig(FlatBufferBuilder builder, ECollectAnimalPartSlot Slot = ECollectAnimalPartSlot.Slot0, StringOffset SkeletonOffset = default(StringOffset), int CollectEntity = 0)
		{
			builder.StartTable(3);
			ICollectAnimalPartsConfig.AddCollectEntity(builder, CollectEntity);
			ICollectAnimalPartsConfig.AddSkeleton(builder, SkeletonOffset);
			ICollectAnimalPartsConfig.AddSlot(builder, Slot);
			return ICollectAnimalPartsConfig.EndICollectAnimalPartsConfig(builder);
		}

		// Token: 0x06022693 RID: 140947 RVA: 0x004BE084 File Offset: 0x004BC284
		public static void StartICollectAnimalPartsConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022694 RID: 140948 RVA: 0x004BE08D File Offset: 0x004BC28D
		public static void AddSlot(FlatBufferBuilder builder, ECollectAnimalPartSlot slot)
		{
			builder.AddByte(0, (byte)slot, 0);
		}

		// Token: 0x06022695 RID: 140949 RVA: 0x004BE098 File Offset: 0x004BC298
		public static void AddSkeleton(FlatBufferBuilder builder, StringOffset skeletonOffset)
		{
			builder.AddOffset(1, skeletonOffset.Value, 0);
		}

		// Token: 0x06022696 RID: 140950 RVA: 0x004BE0A8 File Offset: 0x004BC2A8
		public static void AddCollectEntity(FlatBufferBuilder builder, int collectEntity)
		{
			builder.AddInt(2, collectEntity, 0);
		}

		// Token: 0x06022697 RID: 140951 RVA: 0x004BE0B3 File Offset: 0x004BC2B3
		public static Offset<ICollectAnimalPartsConfig> EndICollectAnimalPartsConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICollectAnimalPartsConfig>(builder.EndTable());
		}

		// Token: 0x06022698 RID: 140952 RVA: 0x004BE0C0 File Offset: 0x004BC2C0
		public ICollectAnimalPartsConfigT UnPack()
		{
			ICollectAnimalPartsConfigT collectAnimalPartsConfigT = new ICollectAnimalPartsConfigT();
			this.UnPackTo(collectAnimalPartsConfigT);
			return collectAnimalPartsConfigT;
		}

		// Token: 0x06022699 RID: 140953 RVA: 0x004BE0DB File Offset: 0x004BC2DB
		public void UnPackTo(ICollectAnimalPartsConfigT _o)
		{
			_o.Slot = this.Slot;
			_o.Skeleton = this.Skeleton;
			_o.CollectEntity = this.CollectEntity;
		}

		// Token: 0x0602269A RID: 140954 RVA: 0x004BE104 File Offset: 0x004BC304
		public static Offset<ICollectAnimalPartsConfig> Pack(FlatBufferBuilder builder, ICollectAnimalPartsConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICollectAnimalPartsConfig>);
			}
			StringOffset skeletonOffset = (_o.Skeleton == null) ? default(StringOffset) : builder.CreateString(_o.Skeleton);
			return ICollectAnimalPartsConfig.CreateICollectAnimalPartsConfig(builder, _o.Slot, skeletonOffset, _o.CollectEntity);
		}

		// Token: 0x0400EA79 RID: 60025
		private Table __p;
	}
}

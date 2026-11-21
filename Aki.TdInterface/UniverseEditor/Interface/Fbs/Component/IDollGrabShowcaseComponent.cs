using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200560A RID: 22026
	public struct IDollGrabShowcaseComponent : IFlatbufferObject
	{
		// Token: 0x17009DEF RID: 40431
		// (get) Token: 0x060231DB RID: 143835 RVA: 0x004D56C2 File Offset: 0x004D38C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060231DC RID: 143836 RVA: 0x004D56CF File Offset: 0x004D38CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060231DD RID: 143837 RVA: 0x004D56D8 File Offset: 0x004D38D8
		public static IDollGrabShowcaseComponent GetRootAsIDollGrabShowcaseComponent(ByteBuffer _bb)
		{
			return IDollGrabShowcaseComponent.GetRootAsIDollGrabShowcaseComponent(_bb, default(IDollGrabShowcaseComponent));
		}

		// Token: 0x060231DE RID: 143838 RVA: 0x004D56F4 File Offset: 0x004D38F4
		public static IDollGrabShowcaseComponent GetRootAsIDollGrabShowcaseComponent(ByteBuffer _bb, IDollGrabShowcaseComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060231DF RID: 143839 RVA: 0x004D5711 File Offset: 0x004D3911
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060231E0 RID: 143840 RVA: 0x004D5720 File Offset: 0x004D3920
		public IDollGrabShowcaseComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DF0 RID: 40432
		// (get) Token: 0x060231E1 RID: 143841 RVA: 0x004D5730 File Offset: 0x004D3930
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009DF1 RID: 40433
		// (get) Token: 0x060231E2 RID: 143842 RVA: 0x004D5770 File Offset: 0x004D3970
		public EDollGrabShowcaseBelongType BelongType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDollGrabShowcaseBelongType.LandOfXuanfang;
				}
				return (EDollGrabShowcaseBelongType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009DF2 RID: 40434
		// (get) Token: 0x060231E3 RID: 143843 RVA: 0x004D57AC File Offset: 0x004D39AC
		public int BindInfiniteModeDollGrabEntityId
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

		// Token: 0x17009DF3 RID: 40435
		// (get) Token: 0x060231E4 RID: 143844 RVA: 0x004D57E8 File Offset: 0x004D39E8
		public IDollGrabShowcaseDollCameraConfig? CameraConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IDollGrabShowcaseDollCameraConfig?(default(IDollGrabShowcaseDollCameraConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060231E5 RID: 143845 RVA: 0x004D5848 File Offset: 0x004D3A48
		public IShowcaseDeliveryReward? DeliveryRewards(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IShowcaseDeliveryReward?(default(IShowcaseDeliveryReward).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009DF4 RID: 40436
		// (get) Token: 0x060231E6 RID: 143846 RVA: 0x004D58AC File Offset: 0x004D3AAC
		public int DeliveryRewardsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009DF5 RID: 40437
		// (get) Token: 0x060231E7 RID: 143847 RVA: 0x004D58D8 File Offset: 0x004D3AD8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060231E8 RID: 143848 RVA: 0x004D5915 File Offset: 0x004D3B15
		public static Offset<IDollGrabShowcaseComponent> CreateIDollGrabShowcaseComponent(FlatBufferBuilder builder, bool Disabled = false, EDollGrabShowcaseBelongType BelongType = EDollGrabShowcaseBelongType.LandOfXuanfang, int BindInfiniteModeDollGrabEntityId = 0, Offset<IDollGrabShowcaseDollCameraConfig> CameraConfigOffset = default(Offset<IDollGrabShowcaseDollCameraConfig>), VectorOffset DeliveryRewardsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IDollGrabShowcaseComponent.AddDeliveryRewards(builder, DeliveryRewardsOffset);
			IDollGrabShowcaseComponent.AddCameraConfig(builder, CameraConfigOffset);
			IDollGrabShowcaseComponent.AddBindInfiniteModeDollGrabEntityId(builder, BindInfiniteModeDollGrabEntityId);
			IDollGrabShowcaseComponent.AddNullMask(builder, NullMask);
			IDollGrabShowcaseComponent.AddBelongType(builder, BelongType);
			IDollGrabShowcaseComponent.AddDisabled(builder, Disabled);
			return IDollGrabShowcaseComponent.EndIDollGrabShowcaseComponent(builder);
		}

		// Token: 0x060231E9 RID: 143849 RVA: 0x004D5951 File Offset: 0x004D3B51
		public static void StartIDollGrabShowcaseComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060231EA RID: 143850 RVA: 0x004D595A File Offset: 0x004D3B5A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060231EB RID: 143851 RVA: 0x004D5965 File Offset: 0x004D3B65
		public static void AddBelongType(FlatBufferBuilder builder, EDollGrabShowcaseBelongType belongType)
		{
			builder.AddByte(1, (byte)belongType, 0);
		}

		// Token: 0x060231EC RID: 143852 RVA: 0x004D5970 File Offset: 0x004D3B70
		public static void AddBindInfiniteModeDollGrabEntityId(FlatBufferBuilder builder, int bindInfiniteModeDollGrabEntityId)
		{
			builder.AddInt(2, bindInfiniteModeDollGrabEntityId, 0);
		}

		// Token: 0x060231ED RID: 143853 RVA: 0x004D597B File Offset: 0x004D3B7B
		public static void AddCameraConfig(FlatBufferBuilder builder, Offset<IDollGrabShowcaseDollCameraConfig> cameraConfigOffset)
		{
			builder.AddOffset(3, cameraConfigOffset.Value, 0);
		}

		// Token: 0x060231EE RID: 143854 RVA: 0x004D598B File Offset: 0x004D3B8B
		public static void AddDeliveryRewards(FlatBufferBuilder builder, VectorOffset deliveryRewardsOffset)
		{
			builder.AddOffset(4, deliveryRewardsOffset.Value, 0);
		}

		// Token: 0x060231EF RID: 143855 RVA: 0x004D599C File Offset: 0x004D3B9C
		public static VectorOffset CreateDeliveryRewardsVector(FlatBufferBuilder builder, Offset<IShowcaseDeliveryReward>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060231F0 RID: 143856 RVA: 0x004D59DC File Offset: 0x004D3BDC
		public static VectorOffset CreateDeliveryRewardsVectorBlock(FlatBufferBuilder builder, Offset<IShowcaseDeliveryReward>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IShowcaseDeliveryReward>>(data);
			return builder.EndVector();
		}

		// Token: 0x060231F1 RID: 143857 RVA: 0x004D59F6 File Offset: 0x004D3BF6
		public static VectorOffset CreateDeliveryRewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IShowcaseDeliveryReward>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IShowcaseDeliveryReward>>(data);
			return builder.EndVector();
		}

		// Token: 0x060231F2 RID: 143858 RVA: 0x004D5A14 File Offset: 0x004D3C14
		public static VectorOffset CreateDeliveryRewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IShowcaseDeliveryReward>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060231F3 RID: 143859 RVA: 0x004D5A2D File Offset: 0x004D3C2D
		public static void StartDeliveryRewardsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060231F4 RID: 143860 RVA: 0x004D5A38 File Offset: 0x004D3C38
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060231F5 RID: 143861 RVA: 0x004D5A43 File Offset: 0x004D3C43
		public static Offset<IDollGrabShowcaseComponent> EndIDollGrabShowcaseComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabShowcaseComponent>(builder.EndTable());
		}

		// Token: 0x060231F6 RID: 143862 RVA: 0x004D5A50 File Offset: 0x004D3C50
		public IDollGrabShowcaseComponentT UnPack()
		{
			IDollGrabShowcaseComponentT dollGrabShowcaseComponentT = new IDollGrabShowcaseComponentT();
			this.UnPackTo(dollGrabShowcaseComponentT);
			return dollGrabShowcaseComponentT;
		}

		// Token: 0x060231F7 RID: 143863 RVA: 0x004D5A6C File Offset: 0x004D3C6C
		public void UnPackTo(IDollGrabShowcaseComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.BelongType = this.BelongType;
			_o.BindInfiniteModeDollGrabEntityId = this.BindInfiniteModeDollGrabEntityId;
			_o.CameraConfig = ((this.CameraConfig != null) ? this.CameraConfig.Value.UnPack() : null);
			_o.DeliveryRewards = new List<IShowcaseDeliveryRewardT>();
			for (int i = 0; i < this.DeliveryRewardsLength; i++)
			{
				_o.DeliveryRewards.Add((this.DeliveryRewards(i) != null) ? this.DeliveryRewards(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060231F8 RID: 143864 RVA: 0x004D5B2C File Offset: 0x004D3D2C
		public static Offset<IDollGrabShowcaseComponent> Pack(FlatBufferBuilder builder, IDollGrabShowcaseComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabShowcaseComponent>);
			}
			Offset<IDollGrabShowcaseDollCameraConfig> cameraConfigOffset = (_o.CameraConfig == null) ? default(Offset<IDollGrabShowcaseDollCameraConfig>) : IDollGrabShowcaseDollCameraConfig.Pack(builder, _o.CameraConfig);
			VectorOffset deliveryRewardsOffset = default(VectorOffset);
			if (_o.DeliveryRewards != null)
			{
				Offset<IShowcaseDeliveryReward>[] array = new Offset<IShowcaseDeliveryReward>[_o.DeliveryRewards.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IShowcaseDeliveryReward.Pack(builder, _o.DeliveryRewards[i]);
				}
				deliveryRewardsOffset = IDollGrabShowcaseComponent.CreateDeliveryRewardsVector(builder, array);
			}
			return IDollGrabShowcaseComponent.CreateIDollGrabShowcaseComponent(builder, _o.Disabled, _o.BelongType, _o.BindInfiniteModeDollGrabEntityId, cameraConfigOffset, deliveryRewardsOffset, _o.NullMask);
		}

		// Token: 0x0400ECC6 RID: 60614
		private Table __p;
	}
}

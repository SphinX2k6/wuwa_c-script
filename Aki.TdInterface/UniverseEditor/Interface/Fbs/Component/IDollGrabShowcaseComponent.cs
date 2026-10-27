using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050A5 RID: 20645
	public struct IDollGrabShowcaseComponent : IFlatbufferObject
	{
		// Token: 0x17009602 RID: 38402
		// (get) Token: 0x06021287 RID: 135815 RVA: 0x0049B736 File Offset: 0x00499936
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021288 RID: 135816 RVA: 0x0049B743 File Offset: 0x00499943
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021289 RID: 135817 RVA: 0x0049B74C File Offset: 0x0049994C
		public static IDollGrabShowcaseComponent GetRootAsIDollGrabShowcaseComponent(ByteBuffer _bb)
		{
			return IDollGrabShowcaseComponent.GetRootAsIDollGrabShowcaseComponent(_bb, default(IDollGrabShowcaseComponent));
		}

		// Token: 0x0602128A RID: 135818 RVA: 0x0049B768 File Offset: 0x00499968
		public static IDollGrabShowcaseComponent GetRootAsIDollGrabShowcaseComponent(ByteBuffer _bb, IDollGrabShowcaseComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602128B RID: 135819 RVA: 0x0049B785 File Offset: 0x00499985
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602128C RID: 135820 RVA: 0x0049B794 File Offset: 0x00499994
		public IDollGrabShowcaseComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009603 RID: 38403
		// (get) Token: 0x0602128D RID: 135821 RVA: 0x0049B7A4 File Offset: 0x004999A4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009604 RID: 38404
		// (get) Token: 0x0602128E RID: 135822 RVA: 0x0049B7E4 File Offset: 0x004999E4
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

		// Token: 0x17009605 RID: 38405
		// (get) Token: 0x0602128F RID: 135823 RVA: 0x0049B820 File Offset: 0x00499A20
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

		// Token: 0x17009606 RID: 38406
		// (get) Token: 0x06021290 RID: 135824 RVA: 0x0049B85C File Offset: 0x00499A5C
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

		// Token: 0x06021291 RID: 135825 RVA: 0x0049B8BC File Offset: 0x00499ABC
		public IShowcaseDeliveryReward? DeliveryRewards(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IShowcaseDeliveryReward?(default(IShowcaseDeliveryReward).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009607 RID: 38407
		// (get) Token: 0x06021292 RID: 135826 RVA: 0x0049B920 File Offset: 0x00499B20
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

		// Token: 0x17009608 RID: 38408
		// (get) Token: 0x06021293 RID: 135827 RVA: 0x0049B94C File Offset: 0x00499B4C
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

		// Token: 0x06021294 RID: 135828 RVA: 0x0049B989 File Offset: 0x00499B89
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

		// Token: 0x06021295 RID: 135829 RVA: 0x0049B9C5 File Offset: 0x00499BC5
		public static void StartIDollGrabShowcaseComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06021296 RID: 135830 RVA: 0x0049B9CE File Offset: 0x00499BCE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021297 RID: 135831 RVA: 0x0049B9D9 File Offset: 0x00499BD9
		public static void AddBelongType(FlatBufferBuilder builder, EDollGrabShowcaseBelongType belongType)
		{
			builder.AddByte(1, (byte)belongType, 0);
		}

		// Token: 0x06021298 RID: 135832 RVA: 0x0049B9E4 File Offset: 0x00499BE4
		public static void AddBindInfiniteModeDollGrabEntityId(FlatBufferBuilder builder, int bindInfiniteModeDollGrabEntityId)
		{
			builder.AddInt(2, bindInfiniteModeDollGrabEntityId, 0);
		}

		// Token: 0x06021299 RID: 135833 RVA: 0x0049B9EF File Offset: 0x00499BEF
		public static void AddCameraConfig(FlatBufferBuilder builder, Offset<IDollGrabShowcaseDollCameraConfig> cameraConfigOffset)
		{
			builder.AddOffset(3, cameraConfigOffset.Value, 0);
		}

		// Token: 0x0602129A RID: 135834 RVA: 0x0049B9FF File Offset: 0x00499BFF
		public static void AddDeliveryRewards(FlatBufferBuilder builder, VectorOffset deliveryRewardsOffset)
		{
			builder.AddOffset(4, deliveryRewardsOffset.Value, 0);
		}

		// Token: 0x0602129B RID: 135835 RVA: 0x0049BA10 File Offset: 0x00499C10
		public static VectorOffset CreateDeliveryRewardsVector(FlatBufferBuilder builder, Offset<IShowcaseDeliveryReward>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602129C RID: 135836 RVA: 0x0049BA50 File Offset: 0x00499C50
		public static VectorOffset CreateDeliveryRewardsVectorBlock(FlatBufferBuilder builder, Offset<IShowcaseDeliveryReward>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IShowcaseDeliveryReward>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602129D RID: 135837 RVA: 0x0049BA6A File Offset: 0x00499C6A
		public static VectorOffset CreateDeliveryRewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IShowcaseDeliveryReward>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IShowcaseDeliveryReward>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602129E RID: 135838 RVA: 0x0049BA88 File Offset: 0x00499C88
		public static VectorOffset CreateDeliveryRewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IShowcaseDeliveryReward>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602129F RID: 135839 RVA: 0x0049BAA1 File Offset: 0x00499CA1
		public static void StartDeliveryRewardsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060212A0 RID: 135840 RVA: 0x0049BAAC File Offset: 0x00499CAC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060212A1 RID: 135841 RVA: 0x0049BAB7 File Offset: 0x00499CB7
		public static Offset<IDollGrabShowcaseComponent> EndIDollGrabShowcaseComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabShowcaseComponent>(builder.EndTable());
		}

		// Token: 0x060212A2 RID: 135842 RVA: 0x0049BAC4 File Offset: 0x00499CC4
		public IDollGrabShowcaseComponentT UnPack()
		{
			IDollGrabShowcaseComponentT dollGrabShowcaseComponentT = new IDollGrabShowcaseComponentT();
			this.UnPackTo(dollGrabShowcaseComponentT);
			return dollGrabShowcaseComponentT;
		}

		// Token: 0x060212A3 RID: 135843 RVA: 0x0049BAE0 File Offset: 0x00499CE0
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

		// Token: 0x060212A4 RID: 135844 RVA: 0x0049BBA0 File Offset: 0x00499DA0
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

		// Token: 0x0400E0C9 RID: 57545
		private Table __p;
	}
}

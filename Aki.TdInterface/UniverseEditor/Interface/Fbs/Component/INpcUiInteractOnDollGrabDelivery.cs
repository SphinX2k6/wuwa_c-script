using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005671 RID: 22129
	public struct INpcUiInteractOnDollGrabDelivery : IFlatbufferObject
	{
		// Token: 0x1700A41F RID: 42015
		// (get) Token: 0x06024D5D RID: 150877 RVA: 0x0051539B File Offset: 0x0051359B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024D5E RID: 150878 RVA: 0x005153A8 File Offset: 0x005135A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024D5F RID: 150879 RVA: 0x005153B0 File Offset: 0x005135B0
		public static INpcUiInteractOnDollGrabDelivery GetRootAsINpcUiInteractOnDollGrabDelivery(ByteBuffer _bb)
		{
			return INpcUiInteractOnDollGrabDelivery.GetRootAsINpcUiInteractOnDollGrabDelivery(_bb, default(INpcUiInteractOnDollGrabDelivery));
		}

		// Token: 0x06024D60 RID: 150880 RVA: 0x005153CC File Offset: 0x005135CC
		public static INpcUiInteractOnDollGrabDelivery GetRootAsINpcUiInteractOnDollGrabDelivery(ByteBuffer _bb, INpcUiInteractOnDollGrabDelivery obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024D61 RID: 150881 RVA: 0x005153E9 File Offset: 0x005135E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024D62 RID: 150882 RVA: 0x005153F8 File Offset: 0x005135F8
		public INpcUiInteractOnDollGrabDelivery __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A420 RID: 42016
		// (get) Token: 0x06024D63 RID: 150883 RVA: 0x00515408 File Offset: 0x00513608
		public ENpcUiInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcUiInteractType.HandInItem;
				}
				return (ENpcUiInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A421 RID: 42017
		// (get) Token: 0x06024D64 RID: 150884 RVA: 0x00515444 File Offset: 0x00513644
		public IOnDollGrabDeliveryPerform? OnFirstAchievementPerform
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IOnDollGrabDeliveryPerform?(default(IOnDollGrabDeliveryPerform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A422 RID: 42018
		// (get) Token: 0x06024D65 RID: 150885 RVA: 0x005154A4 File Offset: 0x005136A4
		public IOnDollGrabDeliveryPerform? OnSubsequentAchievementPerform
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IOnDollGrabDeliveryPerform?(default(IOnDollGrabDeliveryPerform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A423 RID: 42019
		// (get) Token: 0x06024D66 RID: 150886 RVA: 0x00515504 File Offset: 0x00513704
		public IOnDollGrabDeliveryPerform? OnNeverAchievementPerform
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IOnDollGrabDeliveryPerform?(default(IOnDollGrabDeliveryPerform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A424 RID: 42020
		// (get) Token: 0x06024D67 RID: 150887 RVA: 0x00515564 File Offset: 0x00513764
		public IOnDollGrabDeliveryPerform? OnAlreadyAchievementPerform
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IOnDollGrabDeliveryPerform?(default(IOnDollGrabDeliveryPerform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024D68 RID: 150888 RVA: 0x005155C2 File Offset: 0x005137C2
		public static Offset<INpcUiInteractOnDollGrabDelivery> CreateINpcUiInteractOnDollGrabDelivery(FlatBufferBuilder builder, ENpcUiInteractType Type = ENpcUiInteractType.HandInItem, Offset<IOnDollGrabDeliveryPerform> OnFirstAchievementPerformOffset = default(Offset<IOnDollGrabDeliveryPerform>), Offset<IOnDollGrabDeliveryPerform> OnSubsequentAchievementPerformOffset = default(Offset<IOnDollGrabDeliveryPerform>), Offset<IOnDollGrabDeliveryPerform> OnNeverAchievementPerformOffset = default(Offset<IOnDollGrabDeliveryPerform>), Offset<IOnDollGrabDeliveryPerform> OnAlreadyAchievementPerformOffset = default(Offset<IOnDollGrabDeliveryPerform>))
		{
			builder.StartTable(5);
			INpcUiInteractOnDollGrabDelivery.AddOnAlreadyAchievementPerform(builder, OnAlreadyAchievementPerformOffset);
			INpcUiInteractOnDollGrabDelivery.AddOnNeverAchievementPerform(builder, OnNeverAchievementPerformOffset);
			INpcUiInteractOnDollGrabDelivery.AddOnSubsequentAchievementPerform(builder, OnSubsequentAchievementPerformOffset);
			INpcUiInteractOnDollGrabDelivery.AddOnFirstAchievementPerform(builder, OnFirstAchievementPerformOffset);
			INpcUiInteractOnDollGrabDelivery.AddType(builder, Type);
			return INpcUiInteractOnDollGrabDelivery.EndINpcUiInteractOnDollGrabDelivery(builder);
		}

		// Token: 0x06024D69 RID: 150889 RVA: 0x005155F6 File Offset: 0x005137F6
		public static void StartINpcUiInteractOnDollGrabDelivery(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06024D6A RID: 150890 RVA: 0x005155FF File Offset: 0x005137FF
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024D6B RID: 150891 RVA: 0x0051560A File Offset: 0x0051380A
		public static void AddOnFirstAchievementPerform(FlatBufferBuilder builder, Offset<IOnDollGrabDeliveryPerform> onFirstAchievementPerformOffset)
		{
			builder.AddOffset(1, onFirstAchievementPerformOffset.Value, 0);
		}

		// Token: 0x06024D6C RID: 150892 RVA: 0x0051561A File Offset: 0x0051381A
		public static void AddOnSubsequentAchievementPerform(FlatBufferBuilder builder, Offset<IOnDollGrabDeliveryPerform> onSubsequentAchievementPerformOffset)
		{
			builder.AddOffset(2, onSubsequentAchievementPerformOffset.Value, 0);
		}

		// Token: 0x06024D6D RID: 150893 RVA: 0x0051562A File Offset: 0x0051382A
		public static void AddOnNeverAchievementPerform(FlatBufferBuilder builder, Offset<IOnDollGrabDeliveryPerform> onNeverAchievementPerformOffset)
		{
			builder.AddOffset(3, onNeverAchievementPerformOffset.Value, 0);
		}

		// Token: 0x06024D6E RID: 150894 RVA: 0x0051563A File Offset: 0x0051383A
		public static void AddOnAlreadyAchievementPerform(FlatBufferBuilder builder, Offset<IOnDollGrabDeliveryPerform> onAlreadyAchievementPerformOffset)
		{
			builder.AddOffset(4, onAlreadyAchievementPerformOffset.Value, 0);
		}

		// Token: 0x06024D6F RID: 150895 RVA: 0x0051564A File Offset: 0x0051384A
		public static Offset<INpcUiInteractOnDollGrabDelivery> EndINpcUiInteractOnDollGrabDelivery(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnDollGrabDelivery>(builder.EndTable());
		}

		// Token: 0x06024D70 RID: 150896 RVA: 0x00515658 File Offset: 0x00513858
		public INpcUiInteractOnDollGrabDeliveryT UnPack()
		{
			INpcUiInteractOnDollGrabDeliveryT npcUiInteractOnDollGrabDeliveryT = new INpcUiInteractOnDollGrabDeliveryT();
			this.UnPackTo(npcUiInteractOnDollGrabDeliveryT);
			return npcUiInteractOnDollGrabDeliveryT;
		}

		// Token: 0x06024D71 RID: 150897 RVA: 0x00515674 File Offset: 0x00513874
		public void UnPackTo(INpcUiInteractOnDollGrabDeliveryT _o)
		{
			_o.Type = this.Type;
			_o.OnFirstAchievementPerform = ((this.OnFirstAchievementPerform != null) ? this.OnFirstAchievementPerform.Value.UnPack() : null);
			_o.OnSubsequentAchievementPerform = ((this.OnSubsequentAchievementPerform != null) ? this.OnSubsequentAchievementPerform.Value.UnPack() : null);
			_o.OnNeverAchievementPerform = ((this.OnNeverAchievementPerform != null) ? this.OnNeverAchievementPerform.Value.UnPack() : null);
			_o.OnAlreadyAchievementPerform = ((this.OnAlreadyAchievementPerform != null) ? this.OnAlreadyAchievementPerform.Value.UnPack() : null);
		}

		// Token: 0x06024D72 RID: 150898 RVA: 0x0051574C File Offset: 0x0051394C
		public static Offset<INpcUiInteractOnDollGrabDelivery> Pack(FlatBufferBuilder builder, INpcUiInteractOnDollGrabDeliveryT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcUiInteractOnDollGrabDelivery>);
			}
			Offset<IOnDollGrabDeliveryPerform> onFirstAchievementPerformOffset = (_o.OnFirstAchievementPerform == null) ? default(Offset<IOnDollGrabDeliveryPerform>) : IOnDollGrabDeliveryPerform.Pack(builder, _o.OnFirstAchievementPerform);
			Offset<IOnDollGrabDeliveryPerform> onSubsequentAchievementPerformOffset = (_o.OnSubsequentAchievementPerform == null) ? default(Offset<IOnDollGrabDeliveryPerform>) : IOnDollGrabDeliveryPerform.Pack(builder, _o.OnSubsequentAchievementPerform);
			Offset<IOnDollGrabDeliveryPerform> onNeverAchievementPerformOffset = (_o.OnNeverAchievementPerform == null) ? default(Offset<IOnDollGrabDeliveryPerform>) : IOnDollGrabDeliveryPerform.Pack(builder, _o.OnNeverAchievementPerform);
			Offset<IOnDollGrabDeliveryPerform> onAlreadyAchievementPerformOffset = (_o.OnAlreadyAchievementPerform == null) ? default(Offset<IOnDollGrabDeliveryPerform>) : IOnDollGrabDeliveryPerform.Pack(builder, _o.OnAlreadyAchievementPerform);
			return INpcUiInteractOnDollGrabDelivery.CreateINpcUiInteractOnDollGrabDelivery(builder, _o.Type, onFirstAchievementPerformOffset, onSubsequentAchievementPerformOffset, onNeverAchievementPerformOffset, onAlreadyAchievementPerformOffset);
		}

		// Token: 0x0400EA48 RID: 59976
		private Table __p;
	}
}

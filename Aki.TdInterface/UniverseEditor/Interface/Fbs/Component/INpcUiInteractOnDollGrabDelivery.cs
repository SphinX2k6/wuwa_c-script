using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C12 RID: 23570
	public struct INpcUiInteractOnDollGrabDelivery : IFlatbufferObject
	{
		// Token: 0x1700ACAE RID: 44206
		// (get) Token: 0x06026F96 RID: 159638 RVA: 0x00555F37 File Offset: 0x00554137
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026F97 RID: 159639 RVA: 0x00555F44 File Offset: 0x00554144
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026F98 RID: 159640 RVA: 0x00555F4C File Offset: 0x0055414C
		public static INpcUiInteractOnDollGrabDelivery GetRootAsINpcUiInteractOnDollGrabDelivery(ByteBuffer _bb)
		{
			return INpcUiInteractOnDollGrabDelivery.GetRootAsINpcUiInteractOnDollGrabDelivery(_bb, default(INpcUiInteractOnDollGrabDelivery));
		}

		// Token: 0x06026F99 RID: 159641 RVA: 0x00555F68 File Offset: 0x00554168
		public static INpcUiInteractOnDollGrabDelivery GetRootAsINpcUiInteractOnDollGrabDelivery(ByteBuffer _bb, INpcUiInteractOnDollGrabDelivery obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026F9A RID: 159642 RVA: 0x00555F85 File Offset: 0x00554185
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026F9B RID: 159643 RVA: 0x00555F94 File Offset: 0x00554194
		public INpcUiInteractOnDollGrabDelivery __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACAF RID: 44207
		// (get) Token: 0x06026F9C RID: 159644 RVA: 0x00555FA4 File Offset: 0x005541A4
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

		// Token: 0x1700ACB0 RID: 44208
		// (get) Token: 0x06026F9D RID: 159645 RVA: 0x00555FE0 File Offset: 0x005541E0
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

		// Token: 0x1700ACB1 RID: 44209
		// (get) Token: 0x06026F9E RID: 159646 RVA: 0x00556040 File Offset: 0x00554240
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

		// Token: 0x1700ACB2 RID: 44210
		// (get) Token: 0x06026F9F RID: 159647 RVA: 0x005560A0 File Offset: 0x005542A0
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

		// Token: 0x1700ACB3 RID: 44211
		// (get) Token: 0x06026FA0 RID: 159648 RVA: 0x00556100 File Offset: 0x00554300
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

		// Token: 0x06026FA1 RID: 159649 RVA: 0x0055615E File Offset: 0x0055435E
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

		// Token: 0x06026FA2 RID: 159650 RVA: 0x00556192 File Offset: 0x00554392
		public static void StartINpcUiInteractOnDollGrabDelivery(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06026FA3 RID: 159651 RVA: 0x0055619B File Offset: 0x0055439B
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026FA4 RID: 159652 RVA: 0x005561A6 File Offset: 0x005543A6
		public static void AddOnFirstAchievementPerform(FlatBufferBuilder builder, Offset<IOnDollGrabDeliveryPerform> onFirstAchievementPerformOffset)
		{
			builder.AddOffset(1, onFirstAchievementPerformOffset.Value, 0);
		}

		// Token: 0x06026FA5 RID: 159653 RVA: 0x005561B6 File Offset: 0x005543B6
		public static void AddOnSubsequentAchievementPerform(FlatBufferBuilder builder, Offset<IOnDollGrabDeliveryPerform> onSubsequentAchievementPerformOffset)
		{
			builder.AddOffset(2, onSubsequentAchievementPerformOffset.Value, 0);
		}

		// Token: 0x06026FA6 RID: 159654 RVA: 0x005561C6 File Offset: 0x005543C6
		public static void AddOnNeverAchievementPerform(FlatBufferBuilder builder, Offset<IOnDollGrabDeliveryPerform> onNeverAchievementPerformOffset)
		{
			builder.AddOffset(3, onNeverAchievementPerformOffset.Value, 0);
		}

		// Token: 0x06026FA7 RID: 159655 RVA: 0x005561D6 File Offset: 0x005543D6
		public static void AddOnAlreadyAchievementPerform(FlatBufferBuilder builder, Offset<IOnDollGrabDeliveryPerform> onAlreadyAchievementPerformOffset)
		{
			builder.AddOffset(4, onAlreadyAchievementPerformOffset.Value, 0);
		}

		// Token: 0x06026FA8 RID: 159656 RVA: 0x005561E6 File Offset: 0x005543E6
		public static Offset<INpcUiInteractOnDollGrabDelivery> EndINpcUiInteractOnDollGrabDelivery(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnDollGrabDelivery>(builder.EndTable());
		}

		// Token: 0x06026FA9 RID: 159657 RVA: 0x005561F4 File Offset: 0x005543F4
		public INpcUiInteractOnDollGrabDeliveryT UnPack()
		{
			INpcUiInteractOnDollGrabDeliveryT npcUiInteractOnDollGrabDeliveryT = new INpcUiInteractOnDollGrabDeliveryT();
			this.UnPackTo(npcUiInteractOnDollGrabDeliveryT);
			return npcUiInteractOnDollGrabDeliveryT;
		}

		// Token: 0x06026FAA RID: 159658 RVA: 0x00556210 File Offset: 0x00554410
		public void UnPackTo(INpcUiInteractOnDollGrabDeliveryT _o)
		{
			_o.Type = this.Type;
			_o.OnFirstAchievementPerform = ((this.OnFirstAchievementPerform != null) ? this.OnFirstAchievementPerform.Value.UnPack() : null);
			_o.OnSubsequentAchievementPerform = ((this.OnSubsequentAchievementPerform != null) ? this.OnSubsequentAchievementPerform.Value.UnPack() : null);
			_o.OnNeverAchievementPerform = ((this.OnNeverAchievementPerform != null) ? this.OnNeverAchievementPerform.Value.UnPack() : null);
			_o.OnAlreadyAchievementPerform = ((this.OnAlreadyAchievementPerform != null) ? this.OnAlreadyAchievementPerform.Value.UnPack() : null);
		}

		// Token: 0x06026FAB RID: 159659 RVA: 0x005562E8 File Offset: 0x005544E8
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

		// Token: 0x0400F6B1 RID: 63153
		private Table __p;
	}
}

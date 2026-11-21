using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E74 RID: 24180
	public struct IRewardComponent : IFlatbufferObject
	{
		// Token: 0x1700B26B RID: 45675
		// (get) Token: 0x0602874F RID: 165711 RVA: 0x0058854F File Offset: 0x0058674F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028750 RID: 165712 RVA: 0x0058855C File Offset: 0x0058675C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028751 RID: 165713 RVA: 0x00588564 File Offset: 0x00586764
		public static IRewardComponent GetRootAsIRewardComponent(ByteBuffer _bb)
		{
			return IRewardComponent.GetRootAsIRewardComponent(_bb, default(IRewardComponent));
		}

		// Token: 0x06028752 RID: 165714 RVA: 0x00588580 File Offset: 0x00586780
		public static IRewardComponent GetRootAsIRewardComponent(ByteBuffer _bb, IRewardComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028753 RID: 165715 RVA: 0x0058859D File Offset: 0x0058679D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028754 RID: 165716 RVA: 0x005885AC File Offset: 0x005867AC
		public IRewardComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B26C RID: 45676
		// (get) Token: 0x06028755 RID: 165717 RVA: 0x005885BC File Offset: 0x005867BC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B26D RID: 45677
		// (get) Token: 0x06028756 RID: 165718 RVA: 0x005885FC File Offset: 0x005867FC
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B26E RID: 45678
		// (get) Token: 0x06028757 RID: 165719 RVA: 0x00588638 File Offset: 0x00586838
		public ERewardType RewardType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ERewardType.Nearby;
				}
				return (ERewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B26F RID: 45679
		// (get) Token: 0x06028758 RID: 165720 RVA: 0x00588674 File Offset: 0x00586874
		public EDropEvent DropOnEvent
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EDropEvent.All;
				}
				return (EDropEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B270 RID: 45680
		// (get) Token: 0x06028759 RID: 165721 RVA: 0x005886B4 File Offset: 0x005868B4
		public IRewardRefreshConfig? RefreshConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IRewardRefreshConfig?(default(IRewardRefreshConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602875A RID: 165722 RVA: 0x00588714 File Offset: 0x00586914
		public int RewardIdList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B271 RID: 45681
		// (get) Token: 0x0602875B RID: 165723 RVA: 0x00588754 File Offset: 0x00586954
		public int RewardIdListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602875C RID: 165724 RVA: 0x00588780 File Offset: 0x00586980
		public Span<int> GetRewardIdListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0602875D RID: 165725 RVA: 0x00588790 File Offset: 0x00586990
		public int[] GetRewardIdListArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x1700B272 RID: 45682
		// (get) Token: 0x0602875E RID: 165726 RVA: 0x005887A0 File Offset: 0x005869A0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602875F RID: 165727 RVA: 0x005887E0 File Offset: 0x005869E0
		public static Offset<IRewardComponent> CreateIRewardComponent(FlatBufferBuilder builder, bool Disabled = false, int RewardId = 0, ERewardType RewardType = ERewardType.Nearby, EDropEvent DropOnEvent = EDropEvent.All, Offset<IRewardRefreshConfig> RefreshConfigOffset = default(Offset<IRewardRefreshConfig>), VectorOffset RewardIdListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IRewardComponent.AddRewardIdList(builder, RewardIdListOffset);
			IRewardComponent.AddRefreshConfig(builder, RefreshConfigOffset);
			IRewardComponent.AddRewardId(builder, RewardId);
			IRewardComponent.AddNullMask(builder, NullMask);
			IRewardComponent.AddDropOnEvent(builder, DropOnEvent);
			IRewardComponent.AddRewardType(builder, RewardType);
			IRewardComponent.AddDisabled(builder, Disabled);
			return IRewardComponent.EndIRewardComponent(builder);
		}

		// Token: 0x06028760 RID: 165728 RVA: 0x0058882F File Offset: 0x00586A2F
		public static void StartIRewardComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06028761 RID: 165729 RVA: 0x00588838 File Offset: 0x00586A38
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028762 RID: 165730 RVA: 0x00588843 File Offset: 0x00586A43
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(1, rewardId, 0);
		}

		// Token: 0x06028763 RID: 165731 RVA: 0x0058884E File Offset: 0x00586A4E
		public static void AddRewardType(FlatBufferBuilder builder, ERewardType rewardType)
		{
			builder.AddByte(2, (byte)rewardType, 0);
		}

		// Token: 0x06028764 RID: 165732 RVA: 0x00588859 File Offset: 0x00586A59
		public static void AddDropOnEvent(FlatBufferBuilder builder, EDropEvent dropOnEvent)
		{
			builder.AddByte(3, (byte)dropOnEvent, 0);
		}

		// Token: 0x06028765 RID: 165733 RVA: 0x00588864 File Offset: 0x00586A64
		public static void AddRefreshConfig(FlatBufferBuilder builder, Offset<IRewardRefreshConfig> refreshConfigOffset)
		{
			builder.AddOffset(4, refreshConfigOffset.Value, 0);
		}

		// Token: 0x06028766 RID: 165734 RVA: 0x00588874 File Offset: 0x00586A74
		public static void AddRewardIdList(FlatBufferBuilder builder, VectorOffset rewardIdListOffset)
		{
			builder.AddOffset(5, rewardIdListOffset.Value, 0);
		}

		// Token: 0x06028767 RID: 165735 RVA: 0x00588884 File Offset: 0x00586A84
		public static VectorOffset CreateRewardIdListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06028768 RID: 165736 RVA: 0x005888BB File Offset: 0x00586ABB
		public static VectorOffset CreateRewardIdListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028769 RID: 165737 RVA: 0x005888D5 File Offset: 0x00586AD5
		public static VectorOffset CreateRewardIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602876A RID: 165738 RVA: 0x005888F3 File Offset: 0x00586AF3
		public static VectorOffset CreateRewardIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602876B RID: 165739 RVA: 0x0058890C File Offset: 0x00586B0C
		public static void StartRewardIdListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602876C RID: 165740 RVA: 0x00588917 File Offset: 0x00586B17
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602876D RID: 165741 RVA: 0x00588922 File Offset: 0x00586B22
		public static Offset<IRewardComponent> EndIRewardComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRewardComponent>(builder.EndTable());
		}

		// Token: 0x0602876E RID: 165742 RVA: 0x00588930 File Offset: 0x00586B30
		public IRewardComponentT UnPack()
		{
			IRewardComponentT rewardComponentT = new IRewardComponentT();
			this.UnPackTo(rewardComponentT);
			return rewardComponentT;
		}

		// Token: 0x0602876F RID: 165743 RVA: 0x0058894C File Offset: 0x00586B4C
		public void UnPackTo(IRewardComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.RewardId = this.RewardId;
			_o.RewardType = this.RewardType;
			_o.DropOnEvent = this.DropOnEvent;
			_o.RefreshConfig = ((this.RefreshConfig != null) ? this.RefreshConfig.Value.UnPack() : null);
			_o.RewardIdList = new List<int>();
			for (int i = 0; i < this.RewardIdListLength; i++)
			{
				_o.RewardIdList.Add(this.RewardIdList(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028770 RID: 165744 RVA: 0x005889F4 File Offset: 0x00586BF4
		public static Offset<IRewardComponent> Pack(FlatBufferBuilder builder, IRewardComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRewardComponent>);
			}
			Offset<IRewardRefreshConfig> refreshConfigOffset = (_o.RefreshConfig == null) ? default(Offset<IRewardRefreshConfig>) : IRewardRefreshConfig.Pack(builder, _o.RefreshConfig);
			VectorOffset rewardIdListOffset = default(VectorOffset);
			if (_o.RewardIdList != null)
			{
				int[] data = _o.RewardIdList.ToArray();
				rewardIdListOffset = IRewardComponent.CreateRewardIdListVector(builder, data);
			}
			return IRewardComponent.CreateIRewardComponent(builder, _o.Disabled, _o.RewardId, _o.RewardType, _o.DropOnEvent, refreshConfigOffset, rewardIdListOffset, _o.NullMask);
		}

		// Token: 0x0400FA97 RID: 64151
		private Table __p;
	}
}

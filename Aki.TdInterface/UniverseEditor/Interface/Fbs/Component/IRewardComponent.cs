using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005867 RID: 22631
	public struct IRewardComponent : IFlatbufferObject
	{
		// Token: 0x1700A93B RID: 43323
		// (get) Token: 0x060261ED RID: 156141 RVA: 0x00541A03 File Offset: 0x0053FC03
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060261EE RID: 156142 RVA: 0x00541A10 File Offset: 0x0053FC10
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060261EF RID: 156143 RVA: 0x00541A18 File Offset: 0x0053FC18
		public static IRewardComponent GetRootAsIRewardComponent(ByteBuffer _bb)
		{
			return IRewardComponent.GetRootAsIRewardComponent(_bb, default(IRewardComponent));
		}

		// Token: 0x060261F0 RID: 156144 RVA: 0x00541A34 File Offset: 0x0053FC34
		public static IRewardComponent GetRootAsIRewardComponent(ByteBuffer _bb, IRewardComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060261F1 RID: 156145 RVA: 0x00541A51 File Offset: 0x0053FC51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060261F2 RID: 156146 RVA: 0x00541A60 File Offset: 0x0053FC60
		public IRewardComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A93C RID: 43324
		// (get) Token: 0x060261F3 RID: 156147 RVA: 0x00541A70 File Offset: 0x0053FC70
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A93D RID: 43325
		// (get) Token: 0x060261F4 RID: 156148 RVA: 0x00541AB0 File Offset: 0x0053FCB0
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

		// Token: 0x1700A93E RID: 43326
		// (get) Token: 0x060261F5 RID: 156149 RVA: 0x00541AEC File Offset: 0x0053FCEC
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

		// Token: 0x1700A93F RID: 43327
		// (get) Token: 0x060261F6 RID: 156150 RVA: 0x00541B28 File Offset: 0x0053FD28
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

		// Token: 0x1700A940 RID: 43328
		// (get) Token: 0x060261F7 RID: 156151 RVA: 0x00541B68 File Offset: 0x0053FD68
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

		// Token: 0x060261F8 RID: 156152 RVA: 0x00541BC8 File Offset: 0x0053FDC8
		public int RewardIdList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A941 RID: 43329
		// (get) Token: 0x060261F9 RID: 156153 RVA: 0x00541C08 File Offset: 0x0053FE08
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

		// Token: 0x060261FA RID: 156154 RVA: 0x00541C34 File Offset: 0x0053FE34
		public Span<int> GetRewardIdListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060261FB RID: 156155 RVA: 0x00541C44 File Offset: 0x0053FE44
		public int[] GetRewardIdListArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x1700A942 RID: 43330
		// (get) Token: 0x060261FC RID: 156156 RVA: 0x00541C54 File Offset: 0x0053FE54
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

		// Token: 0x060261FD RID: 156157 RVA: 0x00541C94 File Offset: 0x0053FE94
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

		// Token: 0x060261FE RID: 156158 RVA: 0x00541CE3 File Offset: 0x0053FEE3
		public static void StartIRewardComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060261FF RID: 156159 RVA: 0x00541CEC File Offset: 0x0053FEEC
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026200 RID: 156160 RVA: 0x00541CF7 File Offset: 0x0053FEF7
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(1, rewardId, 0);
		}

		// Token: 0x06026201 RID: 156161 RVA: 0x00541D02 File Offset: 0x0053FF02
		public static void AddRewardType(FlatBufferBuilder builder, ERewardType rewardType)
		{
			builder.AddByte(2, (byte)rewardType, 0);
		}

		// Token: 0x06026202 RID: 156162 RVA: 0x00541D0D File Offset: 0x0053FF0D
		public static void AddDropOnEvent(FlatBufferBuilder builder, EDropEvent dropOnEvent)
		{
			builder.AddByte(3, (byte)dropOnEvent, 0);
		}

		// Token: 0x06026203 RID: 156163 RVA: 0x00541D18 File Offset: 0x0053FF18
		public static void AddRefreshConfig(FlatBufferBuilder builder, Offset<IRewardRefreshConfig> refreshConfigOffset)
		{
			builder.AddOffset(4, refreshConfigOffset.Value, 0);
		}

		// Token: 0x06026204 RID: 156164 RVA: 0x00541D28 File Offset: 0x0053FF28
		public static void AddRewardIdList(FlatBufferBuilder builder, VectorOffset rewardIdListOffset)
		{
			builder.AddOffset(5, rewardIdListOffset.Value, 0);
		}

		// Token: 0x06026205 RID: 156165 RVA: 0x00541D38 File Offset: 0x0053FF38
		public static VectorOffset CreateRewardIdListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026206 RID: 156166 RVA: 0x00541D6F File Offset: 0x0053FF6F
		public static VectorOffset CreateRewardIdListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026207 RID: 156167 RVA: 0x00541D89 File Offset: 0x0053FF89
		public static VectorOffset CreateRewardIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026208 RID: 156168 RVA: 0x00541DA7 File Offset: 0x0053FFA7
		public static VectorOffset CreateRewardIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026209 RID: 156169 RVA: 0x00541DC0 File Offset: 0x0053FFC0
		public static void StartRewardIdListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602620A RID: 156170 RVA: 0x00541DCB File Offset: 0x0053FFCB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602620B RID: 156171 RVA: 0x00541DD6 File Offset: 0x0053FFD6
		public static Offset<IRewardComponent> EndIRewardComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRewardComponent>(builder.EndTable());
		}

		// Token: 0x0602620C RID: 156172 RVA: 0x00541DE4 File Offset: 0x0053FFE4
		public IRewardComponentT UnPack()
		{
			IRewardComponentT rewardComponentT = new IRewardComponentT();
			this.UnPackTo(rewardComponentT);
			return rewardComponentT;
		}

		// Token: 0x0602620D RID: 156173 RVA: 0x00541E00 File Offset: 0x00540000
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

		// Token: 0x0602620E RID: 156174 RVA: 0x00541EA8 File Offset: 0x005400A8
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

		// Token: 0x0400EDA4 RID: 60836
		private Table __p;
	}
}

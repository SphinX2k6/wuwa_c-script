using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006835 RID: 26677
	public struct IAvgPlayRoleActionItem : IFlatbufferObject
	{
		// Token: 0x1700C41F RID: 50207
		// (get) Token: 0x0602D967 RID: 186727 RVA: 0x0063CE9F File Offset: 0x0063B09F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D968 RID: 186728 RVA: 0x0063CEAC File Offset: 0x0063B0AC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D969 RID: 186729 RVA: 0x0063CEB4 File Offset: 0x0063B0B4
		public static IAvgPlayRoleActionItem GetRootAsIAvgPlayRoleActionItem(ByteBuffer _bb)
		{
			return IAvgPlayRoleActionItem.GetRootAsIAvgPlayRoleActionItem(_bb, default(IAvgPlayRoleActionItem));
		}

		// Token: 0x0602D96A RID: 186730 RVA: 0x0063CED0 File Offset: 0x0063B0D0
		public static IAvgPlayRoleActionItem GetRootAsIAvgPlayRoleActionItem(ByteBuffer _bb, IAvgPlayRoleActionItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D96B RID: 186731 RVA: 0x0063CEED File Offset: 0x0063B0ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D96C RID: 186732 RVA: 0x0063CEFC File Offset: 0x0063B0FC
		public IAvgPlayRoleActionItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C420 RID: 50208
		// (get) Token: 0x0602D96D RID: 186733 RVA: 0x0063CF0C File Offset: 0x0063B10C
		public EAvgPlayRoleActionType ActionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAvgPlayRoleActionType.Enter;
				}
				return (EAvgPlayRoleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C421 RID: 50209
		// (get) Token: 0x0602D96E RID: 186734 RVA: 0x0063CF48 File Offset: 0x0063B148
		public int RoleId
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

		// Token: 0x1700C422 RID: 50210
		// (get) Token: 0x0602D96F RID: 186735 RVA: 0x0063CF84 File Offset: 0x0063B184
		public EAvgRolePosition PositionConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EAvgRolePosition.Center;
				}
				return (EAvgRolePosition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C423 RID: 50211
		// (get) Token: 0x0602D970 RID: 186736 RVA: 0x0063CFC0 File Offset: 0x0063B1C0
		public EAvgRoleAnimationType AnimationType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EAvgRoleAnimationType.Idle;
				}
				return (EAvgRoleAnimationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C424 RID: 50212
		// (get) Token: 0x0602D971 RID: 186737 RVA: 0x0063D000 File Offset: 0x0063B200
		public bool IsAnimationLoop
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C425 RID: 50213
		// (get) Token: 0x0602D972 RID: 186738 RVA: 0x0063D040 File Offset: 0x0063B240
		public EAvgVisualEffect VisualEffect
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return EAvgVisualEffect.Default;
				}
				return (EAvgVisualEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C426 RID: 50214
		// (get) Token: 0x0602D973 RID: 186739 RVA: 0x0063D080 File Offset: 0x0063B280
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

		// Token: 0x0602D974 RID: 186740 RVA: 0x0063D0C0 File Offset: 0x0063B2C0
		public static Offset<IAvgPlayRoleActionItem> CreateIAvgPlayRoleActionItem(FlatBufferBuilder builder, EAvgPlayRoleActionType ActionType = EAvgPlayRoleActionType.Enter, int RoleId = 0, EAvgRolePosition PositionConfig = EAvgRolePosition.Center, EAvgRoleAnimationType AnimationType = EAvgRoleAnimationType.Idle, bool IsAnimationLoop = false, EAvgVisualEffect VisualEffect = EAvgVisualEffect.Default, byte NullMask = 0)
		{
			builder.StartTable(7);
			IAvgPlayRoleActionItem.AddRoleId(builder, RoleId);
			IAvgPlayRoleActionItem.AddNullMask(builder, NullMask);
			IAvgPlayRoleActionItem.AddVisualEffect(builder, VisualEffect);
			IAvgPlayRoleActionItem.AddIsAnimationLoop(builder, IsAnimationLoop);
			IAvgPlayRoleActionItem.AddAnimationType(builder, AnimationType);
			IAvgPlayRoleActionItem.AddPositionConfig(builder, PositionConfig);
			IAvgPlayRoleActionItem.AddActionType(builder, ActionType);
			return IAvgPlayRoleActionItem.EndIAvgPlayRoleActionItem(builder);
		}

		// Token: 0x0602D975 RID: 186741 RVA: 0x0063D10F File Offset: 0x0063B30F
		public static void StartIAvgPlayRoleActionItem(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602D976 RID: 186742 RVA: 0x0063D118 File Offset: 0x0063B318
		public static void AddActionType(FlatBufferBuilder builder, EAvgPlayRoleActionType actionType)
		{
			builder.AddByte(0, (byte)actionType, 0);
		}

		// Token: 0x0602D977 RID: 186743 RVA: 0x0063D123 File Offset: 0x0063B323
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x0602D978 RID: 186744 RVA: 0x0063D12E File Offset: 0x0063B32E
		public static void AddPositionConfig(FlatBufferBuilder builder, EAvgRolePosition positionConfig)
		{
			builder.AddByte(2, (byte)positionConfig, 0);
		}

		// Token: 0x0602D979 RID: 186745 RVA: 0x0063D139 File Offset: 0x0063B339
		public static void AddAnimationType(FlatBufferBuilder builder, EAvgRoleAnimationType animationType)
		{
			builder.AddByte(3, (byte)animationType, 0);
		}

		// Token: 0x0602D97A RID: 186746 RVA: 0x0063D144 File Offset: 0x0063B344
		public static void AddIsAnimationLoop(FlatBufferBuilder builder, bool isAnimationLoop)
		{
			builder.AddBool(4, isAnimationLoop, false);
		}

		// Token: 0x0602D97B RID: 186747 RVA: 0x0063D14F File Offset: 0x0063B34F
		public static void AddVisualEffect(FlatBufferBuilder builder, EAvgVisualEffect visualEffect)
		{
			builder.AddByte(5, (byte)visualEffect, 0);
		}

		// Token: 0x0602D97C RID: 186748 RVA: 0x0063D15A File Offset: 0x0063B35A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602D97D RID: 186749 RVA: 0x0063D165 File Offset: 0x0063B365
		public static Offset<IAvgPlayRoleActionItem> EndIAvgPlayRoleActionItem(FlatBufferBuilder builder)
		{
			return new Offset<IAvgPlayRoleActionItem>(builder.EndTable());
		}

		// Token: 0x0602D97E RID: 186750 RVA: 0x0063D174 File Offset: 0x0063B374
		public IAvgPlayRoleActionItemT UnPack()
		{
			IAvgPlayRoleActionItemT avgPlayRoleActionItemT = new IAvgPlayRoleActionItemT();
			this.UnPackTo(avgPlayRoleActionItemT);
			return avgPlayRoleActionItemT;
		}

		// Token: 0x0602D97F RID: 186751 RVA: 0x0063D190 File Offset: 0x0063B390
		public void UnPackTo(IAvgPlayRoleActionItemT _o)
		{
			_o.ActionType = this.ActionType;
			_o.RoleId = this.RoleId;
			_o.PositionConfig = this.PositionConfig;
			_o.AnimationType = this.AnimationType;
			_o.IsAnimationLoop = this.IsAnimationLoop;
			_o.VisualEffect = this.VisualEffect;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D980 RID: 186752 RVA: 0x0063D1F4 File Offset: 0x0063B3F4
		public static Offset<IAvgPlayRoleActionItem> Pack(FlatBufferBuilder builder, IAvgPlayRoleActionItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAvgPlayRoleActionItem>);
			}
			return IAvgPlayRoleActionItem.CreateIAvgPlayRoleActionItem(builder, _o.ActionType, _o.RoleId, _o.PositionConfig, _o.AnimationType, _o.IsAnimationLoop, _o.VisualEffect, _o.NullMask);
		}

		// Token: 0x040114FB RID: 70907
		private Table __p;
	}
}

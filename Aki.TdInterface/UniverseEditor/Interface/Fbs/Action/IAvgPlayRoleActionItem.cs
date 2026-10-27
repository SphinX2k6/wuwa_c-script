using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061C7 RID: 25031
	public struct IAvgPlayRoleActionItem : IFlatbufferObject
	{
		// Token: 0x1700BA9C RID: 47772
		// (get) Token: 0x0602B220 RID: 176672 RVA: 0x005F242B File Offset: 0x005F062B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B221 RID: 176673 RVA: 0x005F2438 File Offset: 0x005F0638
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B222 RID: 176674 RVA: 0x005F2440 File Offset: 0x005F0640
		public static IAvgPlayRoleActionItem GetRootAsIAvgPlayRoleActionItem(ByteBuffer _bb)
		{
			return IAvgPlayRoleActionItem.GetRootAsIAvgPlayRoleActionItem(_bb, default(IAvgPlayRoleActionItem));
		}

		// Token: 0x0602B223 RID: 176675 RVA: 0x005F245C File Offset: 0x005F065C
		public static IAvgPlayRoleActionItem GetRootAsIAvgPlayRoleActionItem(ByteBuffer _bb, IAvgPlayRoleActionItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B224 RID: 176676 RVA: 0x005F2479 File Offset: 0x005F0679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B225 RID: 176677 RVA: 0x005F2488 File Offset: 0x005F0688
		public IAvgPlayRoleActionItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA9D RID: 47773
		// (get) Token: 0x0602B226 RID: 176678 RVA: 0x005F2498 File Offset: 0x005F0698
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

		// Token: 0x1700BA9E RID: 47774
		// (get) Token: 0x0602B227 RID: 176679 RVA: 0x005F24D4 File Offset: 0x005F06D4
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

		// Token: 0x1700BA9F RID: 47775
		// (get) Token: 0x0602B228 RID: 176680 RVA: 0x005F2510 File Offset: 0x005F0710
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

		// Token: 0x1700BAA0 RID: 47776
		// (get) Token: 0x0602B229 RID: 176681 RVA: 0x005F254C File Offset: 0x005F074C
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

		// Token: 0x1700BAA1 RID: 47777
		// (get) Token: 0x0602B22A RID: 176682 RVA: 0x005F258C File Offset: 0x005F078C
		public bool IsAnimationLoop
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BAA2 RID: 47778
		// (get) Token: 0x0602B22B RID: 176683 RVA: 0x005F25CC File Offset: 0x005F07CC
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

		// Token: 0x1700BAA3 RID: 47779
		// (get) Token: 0x0602B22C RID: 176684 RVA: 0x005F260C File Offset: 0x005F080C
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

		// Token: 0x0602B22D RID: 176685 RVA: 0x005F264C File Offset: 0x005F084C
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

		// Token: 0x0602B22E RID: 176686 RVA: 0x005F269B File Offset: 0x005F089B
		public static void StartIAvgPlayRoleActionItem(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602B22F RID: 176687 RVA: 0x005F26A4 File Offset: 0x005F08A4
		public static void AddActionType(FlatBufferBuilder builder, EAvgPlayRoleActionType actionType)
		{
			builder.AddByte(0, (byte)actionType, 0);
		}

		// Token: 0x0602B230 RID: 176688 RVA: 0x005F26AF File Offset: 0x005F08AF
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x0602B231 RID: 176689 RVA: 0x005F26BA File Offset: 0x005F08BA
		public static void AddPositionConfig(FlatBufferBuilder builder, EAvgRolePosition positionConfig)
		{
			builder.AddByte(2, (byte)positionConfig, 0);
		}

		// Token: 0x0602B232 RID: 176690 RVA: 0x005F26C5 File Offset: 0x005F08C5
		public static void AddAnimationType(FlatBufferBuilder builder, EAvgRoleAnimationType animationType)
		{
			builder.AddByte(3, (byte)animationType, 0);
		}

		// Token: 0x0602B233 RID: 176691 RVA: 0x005F26D0 File Offset: 0x005F08D0
		public static void AddIsAnimationLoop(FlatBufferBuilder builder, bool isAnimationLoop)
		{
			builder.AddBool(4, isAnimationLoop, false);
		}

		// Token: 0x0602B234 RID: 176692 RVA: 0x005F26DB File Offset: 0x005F08DB
		public static void AddVisualEffect(FlatBufferBuilder builder, EAvgVisualEffect visualEffect)
		{
			builder.AddByte(5, (byte)visualEffect, 0);
		}

		// Token: 0x0602B235 RID: 176693 RVA: 0x005F26E6 File Offset: 0x005F08E6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602B236 RID: 176694 RVA: 0x005F26F1 File Offset: 0x005F08F1
		public static Offset<IAvgPlayRoleActionItem> EndIAvgPlayRoleActionItem(FlatBufferBuilder builder)
		{
			return new Offset<IAvgPlayRoleActionItem>(builder.EndTable());
		}

		// Token: 0x0602B237 RID: 176695 RVA: 0x005F2700 File Offset: 0x005F0900
		public IAvgPlayRoleActionItemT UnPack()
		{
			IAvgPlayRoleActionItemT avgPlayRoleActionItemT = new IAvgPlayRoleActionItemT();
			this.UnPackTo(avgPlayRoleActionItemT);
			return avgPlayRoleActionItemT;
		}

		// Token: 0x0602B238 RID: 176696 RVA: 0x005F271C File Offset: 0x005F091C
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

		// Token: 0x0602B239 RID: 176697 RVA: 0x005F2780 File Offset: 0x005F0980
		public static Offset<IAvgPlayRoleActionItem> Pack(FlatBufferBuilder builder, IAvgPlayRoleActionItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAvgPlayRoleActionItem>);
			}
			return IAvgPlayRoleActionItem.CreateIAvgPlayRoleActionItem(builder, _o.ActionType, _o.RoleId, _o.PositionConfig, _o.AnimationType, _o.IsAnimationLoop, _o.VisualEffect, _o.NullMask);
		}

		// Token: 0x040106E9 RID: 67305
		private Table __p;
	}
}

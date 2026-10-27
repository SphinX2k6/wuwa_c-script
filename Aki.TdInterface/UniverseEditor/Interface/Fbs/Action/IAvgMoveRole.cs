using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061C1 RID: 25025
	public struct IAvgMoveRole : IFlatbufferObject
	{
		// Token: 0x1700BA8C RID: 47756
		// (get) Token: 0x0602B1E2 RID: 176610 RVA: 0x005F1C51 File Offset: 0x005EFE51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B1E3 RID: 176611 RVA: 0x005F1C5E File Offset: 0x005EFE5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B1E4 RID: 176612 RVA: 0x005F1C68 File Offset: 0x005EFE68
		public static IAvgMoveRole GetRootAsIAvgMoveRole(ByteBuffer _bb)
		{
			return IAvgMoveRole.GetRootAsIAvgMoveRole(_bb, default(IAvgMoveRole));
		}

		// Token: 0x0602B1E5 RID: 176613 RVA: 0x005F1C84 File Offset: 0x005EFE84
		public static IAvgMoveRole GetRootAsIAvgMoveRole(ByteBuffer _bb, IAvgMoveRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B1E6 RID: 176614 RVA: 0x005F1CA1 File Offset: 0x005EFEA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B1E7 RID: 176615 RVA: 0x005F1CB0 File Offset: 0x005EFEB0
		public IAvgMoveRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA8D RID: 47757
		// (get) Token: 0x0602B1E8 RID: 176616 RVA: 0x005F1CC0 File Offset: 0x005EFEC0
		public int RoleId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA8E RID: 47758
		// (get) Token: 0x0602B1E9 RID: 176617 RVA: 0x005F1CFC File Offset: 0x005EFEFC
		public EAvgRoleAnimationType AnimationType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EAvgRoleAnimationType.Idle;
				}
				return (EAvgRoleAnimationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA8F RID: 47759
		// (get) Token: 0x0602B1EA RID: 176618 RVA: 0x005F1D38 File Offset: 0x005EFF38
		public bool IsAnimationLoop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BA90 RID: 47760
		// (get) Token: 0x0602B1EB RID: 176619 RVA: 0x005F1D78 File Offset: 0x005EFF78
		public EAvgRolePosition TargetPosition
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EAvgRolePosition.Center;
				}
				return (EAvgRolePosition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA91 RID: 47761
		// (get) Token: 0x0602B1EC RID: 176620 RVA: 0x005F1DB8 File Offset: 0x005EFFB8
		public IEaseData? EaseCurve
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IEaseData?(default(IEaseData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BA92 RID: 47762
		// (get) Token: 0x0602B1ED RID: 176621 RVA: 0x005F1E18 File Offset: 0x005F0018
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

		// Token: 0x0602B1EE RID: 176622 RVA: 0x005F1E55 File Offset: 0x005F0055
		public static Offset<IAvgMoveRole> CreateIAvgMoveRole(FlatBufferBuilder builder, int RoleId = 0, EAvgRoleAnimationType AnimationType = EAvgRoleAnimationType.Idle, bool IsAnimationLoop = false, EAvgRolePosition TargetPosition = EAvgRolePosition.Center, Offset<IEaseData> EaseCurveOffset = default(Offset<IEaseData>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IAvgMoveRole.AddEaseCurve(builder, EaseCurveOffset);
			IAvgMoveRole.AddRoleId(builder, RoleId);
			IAvgMoveRole.AddNullMask(builder, NullMask);
			IAvgMoveRole.AddTargetPosition(builder, TargetPosition);
			IAvgMoveRole.AddIsAnimationLoop(builder, IsAnimationLoop);
			IAvgMoveRole.AddAnimationType(builder, AnimationType);
			return IAvgMoveRole.EndIAvgMoveRole(builder);
		}

		// Token: 0x0602B1EF RID: 176623 RVA: 0x005F1E91 File Offset: 0x005F0091
		public static void StartIAvgMoveRole(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602B1F0 RID: 176624 RVA: 0x005F1E9A File Offset: 0x005F009A
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(0, roleId, 0);
		}

		// Token: 0x0602B1F1 RID: 176625 RVA: 0x005F1EA5 File Offset: 0x005F00A5
		public static void AddAnimationType(FlatBufferBuilder builder, EAvgRoleAnimationType animationType)
		{
			builder.AddByte(1, (byte)animationType, 0);
		}

		// Token: 0x0602B1F2 RID: 176626 RVA: 0x005F1EB0 File Offset: 0x005F00B0
		public static void AddIsAnimationLoop(FlatBufferBuilder builder, bool isAnimationLoop)
		{
			builder.AddBool(2, isAnimationLoop, false);
		}

		// Token: 0x0602B1F3 RID: 176627 RVA: 0x005F1EBB File Offset: 0x005F00BB
		public static void AddTargetPosition(FlatBufferBuilder builder, EAvgRolePosition targetPosition)
		{
			builder.AddByte(3, (byte)targetPosition, 0);
		}

		// Token: 0x0602B1F4 RID: 176628 RVA: 0x005F1EC6 File Offset: 0x005F00C6
		public static void AddEaseCurve(FlatBufferBuilder builder, Offset<IEaseData> easeCurveOffset)
		{
			builder.AddOffset(4, easeCurveOffset.Value, 0);
		}

		// Token: 0x0602B1F5 RID: 176629 RVA: 0x005F1ED6 File Offset: 0x005F00D6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602B1F6 RID: 176630 RVA: 0x005F1EE1 File Offset: 0x005F00E1
		public static Offset<IAvgMoveRole> EndIAvgMoveRole(FlatBufferBuilder builder)
		{
			return new Offset<IAvgMoveRole>(builder.EndTable());
		}

		// Token: 0x0602B1F7 RID: 176631 RVA: 0x005F1EF0 File Offset: 0x005F00F0
		public IAvgMoveRoleT UnPack()
		{
			IAvgMoveRoleT avgMoveRoleT = new IAvgMoveRoleT();
			this.UnPackTo(avgMoveRoleT);
			return avgMoveRoleT;
		}

		// Token: 0x0602B1F8 RID: 176632 RVA: 0x005F1F0C File Offset: 0x005F010C
		public void UnPackTo(IAvgMoveRoleT _o)
		{
			_o.RoleId = this.RoleId;
			_o.AnimationType = this.AnimationType;
			_o.IsAnimationLoop = this.IsAnimationLoop;
			_o.TargetPosition = this.TargetPosition;
			_o.EaseCurve = ((this.EaseCurve != null) ? this.EaseCurve.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B1F9 RID: 176633 RVA: 0x005F1F84 File Offset: 0x005F0184
		public static Offset<IAvgMoveRole> Pack(FlatBufferBuilder builder, IAvgMoveRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAvgMoveRole>);
			}
			Offset<IEaseData> easeCurveOffset = (_o.EaseCurve == null) ? default(Offset<IEaseData>) : IEaseData.Pack(builder, _o.EaseCurve);
			return IAvgMoveRole.CreateIAvgMoveRole(builder, _o.RoleId, _o.AnimationType, _o.IsAnimationLoop, _o.TargetPosition, easeCurveOffset, _o.NullMask);
		}

		// Token: 0x040106E0 RID: 67296
		private Table __p;
	}
}

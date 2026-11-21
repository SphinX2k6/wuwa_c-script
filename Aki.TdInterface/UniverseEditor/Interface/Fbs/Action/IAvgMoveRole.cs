using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200682F RID: 26671
	public struct IAvgMoveRole : IFlatbufferObject
	{
		// Token: 0x1700C40F RID: 50191
		// (get) Token: 0x0602D929 RID: 186665 RVA: 0x0063C6C5 File Offset: 0x0063A8C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D92A RID: 186666 RVA: 0x0063C6D2 File Offset: 0x0063A8D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D92B RID: 186667 RVA: 0x0063C6DC File Offset: 0x0063A8DC
		public static IAvgMoveRole GetRootAsIAvgMoveRole(ByteBuffer _bb)
		{
			return IAvgMoveRole.GetRootAsIAvgMoveRole(_bb, default(IAvgMoveRole));
		}

		// Token: 0x0602D92C RID: 186668 RVA: 0x0063C6F8 File Offset: 0x0063A8F8
		public static IAvgMoveRole GetRootAsIAvgMoveRole(ByteBuffer _bb, IAvgMoveRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D92D RID: 186669 RVA: 0x0063C715 File Offset: 0x0063A915
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D92E RID: 186670 RVA: 0x0063C724 File Offset: 0x0063A924
		public IAvgMoveRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C410 RID: 50192
		// (get) Token: 0x0602D92F RID: 186671 RVA: 0x0063C734 File Offset: 0x0063A934
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

		// Token: 0x1700C411 RID: 50193
		// (get) Token: 0x0602D930 RID: 186672 RVA: 0x0063C770 File Offset: 0x0063A970
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

		// Token: 0x1700C412 RID: 50194
		// (get) Token: 0x0602D931 RID: 186673 RVA: 0x0063C7AC File Offset: 0x0063A9AC
		public bool IsAnimationLoop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C413 RID: 50195
		// (get) Token: 0x0602D932 RID: 186674 RVA: 0x0063C7EC File Offset: 0x0063A9EC
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

		// Token: 0x1700C414 RID: 50196
		// (get) Token: 0x0602D933 RID: 186675 RVA: 0x0063C82C File Offset: 0x0063AA2C
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

		// Token: 0x1700C415 RID: 50197
		// (get) Token: 0x0602D934 RID: 186676 RVA: 0x0063C88C File Offset: 0x0063AA8C
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

		// Token: 0x0602D935 RID: 186677 RVA: 0x0063C8C9 File Offset: 0x0063AAC9
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

		// Token: 0x0602D936 RID: 186678 RVA: 0x0063C905 File Offset: 0x0063AB05
		public static void StartIAvgMoveRole(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602D937 RID: 186679 RVA: 0x0063C90E File Offset: 0x0063AB0E
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(0, roleId, 0);
		}

		// Token: 0x0602D938 RID: 186680 RVA: 0x0063C919 File Offset: 0x0063AB19
		public static void AddAnimationType(FlatBufferBuilder builder, EAvgRoleAnimationType animationType)
		{
			builder.AddByte(1, (byte)animationType, 0);
		}

		// Token: 0x0602D939 RID: 186681 RVA: 0x0063C924 File Offset: 0x0063AB24
		public static void AddIsAnimationLoop(FlatBufferBuilder builder, bool isAnimationLoop)
		{
			builder.AddBool(2, isAnimationLoop, false);
		}

		// Token: 0x0602D93A RID: 186682 RVA: 0x0063C92F File Offset: 0x0063AB2F
		public static void AddTargetPosition(FlatBufferBuilder builder, EAvgRolePosition targetPosition)
		{
			builder.AddByte(3, (byte)targetPosition, 0);
		}

		// Token: 0x0602D93B RID: 186683 RVA: 0x0063C93A File Offset: 0x0063AB3A
		public static void AddEaseCurve(FlatBufferBuilder builder, Offset<IEaseData> easeCurveOffset)
		{
			builder.AddOffset(4, easeCurveOffset.Value, 0);
		}

		// Token: 0x0602D93C RID: 186684 RVA: 0x0063C94A File Offset: 0x0063AB4A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602D93D RID: 186685 RVA: 0x0063C955 File Offset: 0x0063AB55
		public static Offset<IAvgMoveRole> EndIAvgMoveRole(FlatBufferBuilder builder)
		{
			return new Offset<IAvgMoveRole>(builder.EndTable());
		}

		// Token: 0x0602D93E RID: 186686 RVA: 0x0063C964 File Offset: 0x0063AB64
		public IAvgMoveRoleT UnPack()
		{
			IAvgMoveRoleT avgMoveRoleT = new IAvgMoveRoleT();
			this.UnPackTo(avgMoveRoleT);
			return avgMoveRoleT;
		}

		// Token: 0x0602D93F RID: 186687 RVA: 0x0063C980 File Offset: 0x0063AB80
		public void UnPackTo(IAvgMoveRoleT _o)
		{
			_o.RoleId = this.RoleId;
			_o.AnimationType = this.AnimationType;
			_o.IsAnimationLoop = this.IsAnimationLoop;
			_o.TargetPosition = this.TargetPosition;
			_o.EaseCurve = ((this.EaseCurve != null) ? this.EaseCurve.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D940 RID: 186688 RVA: 0x0063C9F8 File Offset: 0x0063ABF8
		public static Offset<IAvgMoveRole> Pack(FlatBufferBuilder builder, IAvgMoveRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAvgMoveRole>);
			}
			Offset<IEaseData> easeCurveOffset = (_o.EaseCurve == null) ? default(Offset<IEaseData>) : IEaseData.Pack(builder, _o.EaseCurve);
			return IAvgMoveRole.CreateIAvgMoveRole(builder, _o.RoleId, _o.AnimationType, _o.IsAnimationLoop, _o.TargetPosition, easeCurveOffset, _o.NullMask);
		}

		// Token: 0x040114F2 RID: 70898
		private Table __p;
	}
}

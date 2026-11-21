using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EC0 RID: 20160
	public struct ICheckEntityGravityDirection : IFlatbufferObject
	{
		// Token: 0x17008FDE RID: 36830
		// (get) Token: 0x0601F445 RID: 128069 RVA: 0x0045BB6A File Offset: 0x00459D6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F446 RID: 128070 RVA: 0x0045BB77 File Offset: 0x00459D77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F447 RID: 128071 RVA: 0x0045BB80 File Offset: 0x00459D80
		public static ICheckEntityGravityDirection GetRootAsICheckEntityGravityDirection(ByteBuffer _bb)
		{
			return ICheckEntityGravityDirection.GetRootAsICheckEntityGravityDirection(_bb, default(ICheckEntityGravityDirection));
		}

		// Token: 0x0601F448 RID: 128072 RVA: 0x0045BB9C File Offset: 0x00459D9C
		public static ICheckEntityGravityDirection GetRootAsICheckEntityGravityDirection(ByteBuffer _bb, ICheckEntityGravityDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F449 RID: 128073 RVA: 0x0045BBB9 File Offset: 0x00459DB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F44A RID: 128074 RVA: 0x0045BBC8 File Offset: 0x00459DC8
		public ICheckEntityGravityDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FDF RID: 36831
		// (get) Token: 0x0601F44B RID: 128075 RVA: 0x0045BBD8 File Offset: 0x00459DD8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008FE0 RID: 36832
		// (get) Token: 0x0601F44C RID: 128076 RVA: 0x0045BC14 File Offset: 0x00459E14
		public TCheckTarget TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TCheckTarget.NONE;
				}
				return (TCheckTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F44D RID: 128077 RVA: 0x0045BC50 File Offset: 0x00459E50
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F44E RID: 128078 RVA: 0x0045BC94 File Offset: 0x00459E94
		public ICheckOnlinePlayer TargetAsICheckOnlinePlayer()
		{
			return this.Target<ICheckOnlinePlayer>().Value;
		}

		// Token: 0x0601F44F RID: 128079 RVA: 0x0045BCB0 File Offset: 0x00459EB0
		public ICheckTargetEntity TargetAsICheckTargetEntity()
		{
			return this.Target<ICheckTargetEntity>().Value;
		}

		// Token: 0x17008FE1 RID: 36833
		// (get) Token: 0x0601F450 RID: 128080 RVA: 0x0045BCCC File Offset: 0x00459ECC
		public TGravityDirection GravityDirectionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TGravityDirection.NONE;
				}
				return (TGravityDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F451 RID: 128081 RVA: 0x0045BD0C File Offset: 0x00459F0C
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F452 RID: 128082 RVA: 0x0045BD54 File Offset: 0x00459F54
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0601F453 RID: 128083 RVA: 0x0045BD70 File Offset: 0x00459F70
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0601F454 RID: 128084 RVA: 0x0045BD8C File Offset: 0x00459F8C
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0601F455 RID: 128085 RVA: 0x0045BDA8 File Offset: 0x00459FA8
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x17008FE2 RID: 36834
		// (get) Token: 0x0601F456 RID: 128086 RVA: 0x0045BDC4 File Offset: 0x00459FC4
		public bool IsNotInTargetDirection
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008FE3 RID: 36835
		// (get) Token: 0x0601F457 RID: 128087 RVA: 0x0045BE04 File Offset: 0x0045A004
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

		// Token: 0x0601F458 RID: 128088 RVA: 0x0045BE44 File Offset: 0x0045A044
		public static Offset<ICheckEntityGravityDirection> CreateICheckEntityGravityDirection(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TCheckTarget Target_type = TCheckTarget.NONE, int TargetOffset = 0, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, bool IsNotInTargetDirection = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			ICheckEntityGravityDirection.AddGravityDirection(builder, GravityDirectionOffset);
			ICheckEntityGravityDirection.AddTarget(builder, TargetOffset);
			ICheckEntityGravityDirection.AddNullMask(builder, NullMask);
			ICheckEntityGravityDirection.AddIsNotInTargetDirection(builder, IsNotInTargetDirection);
			ICheckEntityGravityDirection.AddGravityDirectionType(builder, GravityDirection_type);
			ICheckEntityGravityDirection.AddTargetType(builder, Target_type);
			ICheckEntityGravityDirection.AddType(builder, Type);
			return ICheckEntityGravityDirection.EndICheckEntityGravityDirection(builder);
		}

		// Token: 0x0601F459 RID: 128089 RVA: 0x0045BE93 File Offset: 0x0045A093
		public static void StartICheckEntityGravityDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601F45A RID: 128090 RVA: 0x0045BE9C File Offset: 0x0045A09C
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F45B RID: 128091 RVA: 0x0045BEA7 File Offset: 0x0045A0A7
		public static void AddTargetType(FlatBufferBuilder builder, TCheckTarget targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601F45C RID: 128092 RVA: 0x0045BEB2 File Offset: 0x0045A0B2
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601F45D RID: 128093 RVA: 0x0045BEBD File Offset: 0x0045A0BD
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(3, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0601F45E RID: 128094 RVA: 0x0045BEC8 File Offset: 0x0045A0C8
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(4, gravityDirectionOffset, 0);
		}

		// Token: 0x0601F45F RID: 128095 RVA: 0x0045BED3 File Offset: 0x0045A0D3
		public static void AddIsNotInTargetDirection(FlatBufferBuilder builder, bool isNotInTargetDirection)
		{
			builder.AddBool(5, isNotInTargetDirection, false);
		}

		// Token: 0x0601F460 RID: 128096 RVA: 0x0045BEDE File Offset: 0x0045A0DE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601F461 RID: 128097 RVA: 0x0045BEE9 File Offset: 0x0045A0E9
		public static Offset<ICheckEntityGravityDirection> EndICheckEntityGravityDirection(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityGravityDirection>(builder.EndTable());
		}

		// Token: 0x0601F462 RID: 128098 RVA: 0x0045BEF8 File Offset: 0x0045A0F8
		public ICheckEntityGravityDirectionT UnPack()
		{
			ICheckEntityGravityDirectionT checkEntityGravityDirectionT = new ICheckEntityGravityDirectionT();
			this.UnPackTo(checkEntityGravityDirectionT);
			return checkEntityGravityDirectionT;
		}

		// Token: 0x0601F463 RID: 128099 RVA: 0x0045BF14 File Offset: 0x0045A114
		public void UnPackTo(ICheckEntityGravityDirectionT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TCheckTargetUnion();
			_o.Target.Type = this.TargetType;
			TCheckTarget targetType = this.TargetType;
			if (targetType != TCheckTarget.ICheckOnlinePlayer)
			{
				if (targetType == TCheckTarget.ICheckTargetEntity)
				{
					_o.Target.Value = ((this.Target<ICheckTargetEntity>() != null) ? this.Target<ICheckTargetEntity>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Target.Value = ((this.Target<ICheckOnlinePlayer>() != null) ? this.Target<ICheckOnlinePlayer>().Value.UnPack() : null);
			}
			_o.GravityDirection = new TGravityDirectionUnion();
			_o.GravityDirection.Type = this.GravityDirectionType;
			switch (this.GravityDirectionType)
			{
			case TGravityDirection.IGravityDirectionByEntityGravity:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionByEntityGravity>() != null) ? this.GravityDirection<IGravityDirectionByEntityGravity>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionSelfRotation:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionSelfRotation>() != null) ? this.GravityDirection<IGravityDirectionSelfRotation>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionVectorInfo:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionVectorInfo>() != null) ? this.GravityDirection<IGravityDirectionVectorInfo>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionWorldAxis:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionWorldAxis>() != null) ? this.GravityDirection<IGravityDirectionWorldAxis>().Value.UnPack() : null);
				break;
			}
			_o.IsNotInTargetDirection = this.IsNotInTargetDirection;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F464 RID: 128100 RVA: 0x0045C104 File Offset: 0x0045A304
		public static Offset<ICheckEntityGravityDirection> Pack(FlatBufferBuilder builder, ICheckEntityGravityDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityGravityDirection>);
			}
			TCheckTarget target_type = (_o.Target == null) ? TCheckTarget.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TCheckTargetUnion.Pack(builder, _o.Target);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			return ICheckEntityGravityDirection.CreateICheckEntityGravityDirection(builder, _o.Type, target_type, targetOffset, gravityDirection_type, gravityDirectionOffset, _o.IsNotInTargetDirection, _o.NullMask);
		}

		// Token: 0x0400DD13 RID: 56595
		private Table __p;
	}
}

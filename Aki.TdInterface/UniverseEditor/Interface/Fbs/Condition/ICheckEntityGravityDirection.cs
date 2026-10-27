using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A00 RID: 18944
	public struct ICheckEntityGravityDirection : IFlatbufferObject
	{
		// Token: 0x1700890E RID: 35086
		// (get) Token: 0x0601D9D2 RID: 121298 RVA: 0x0042AEFE File Offset: 0x004290FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D9D3 RID: 121299 RVA: 0x0042AF0B File Offset: 0x0042910B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D9D4 RID: 121300 RVA: 0x0042AF14 File Offset: 0x00429114
		public static ICheckEntityGravityDirection GetRootAsICheckEntityGravityDirection(ByteBuffer _bb)
		{
			return ICheckEntityGravityDirection.GetRootAsICheckEntityGravityDirection(_bb, default(ICheckEntityGravityDirection));
		}

		// Token: 0x0601D9D5 RID: 121301 RVA: 0x0042AF30 File Offset: 0x00429130
		public static ICheckEntityGravityDirection GetRootAsICheckEntityGravityDirection(ByteBuffer _bb, ICheckEntityGravityDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D9D6 RID: 121302 RVA: 0x0042AF4D File Offset: 0x0042914D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D9D7 RID: 121303 RVA: 0x0042AF5C File Offset: 0x0042915C
		public ICheckEntityGravityDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700890F RID: 35087
		// (get) Token: 0x0601D9D8 RID: 121304 RVA: 0x0042AF6C File Offset: 0x0042916C
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

		// Token: 0x17008910 RID: 35088
		// (get) Token: 0x0601D9D9 RID: 121305 RVA: 0x0042AFA8 File Offset: 0x004291A8
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

		// Token: 0x0601D9DA RID: 121306 RVA: 0x0042AFE4 File Offset: 0x004291E4
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601D9DB RID: 121307 RVA: 0x0042B028 File Offset: 0x00429228
		public ICheckOnlinePlayer TargetAsICheckOnlinePlayer()
		{
			return this.Target<ICheckOnlinePlayer>().Value;
		}

		// Token: 0x0601D9DC RID: 121308 RVA: 0x0042B044 File Offset: 0x00429244
		public ICheckTargetEntity TargetAsICheckTargetEntity()
		{
			return this.Target<ICheckTargetEntity>().Value;
		}

		// Token: 0x17008911 RID: 35089
		// (get) Token: 0x0601D9DD RID: 121309 RVA: 0x0042B060 File Offset: 0x00429260
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

		// Token: 0x0601D9DE RID: 121310 RVA: 0x0042B0A0 File Offset: 0x004292A0
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601D9DF RID: 121311 RVA: 0x0042B0E8 File Offset: 0x004292E8
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0601D9E0 RID: 121312 RVA: 0x0042B104 File Offset: 0x00429304
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0601D9E1 RID: 121313 RVA: 0x0042B120 File Offset: 0x00429320
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0601D9E2 RID: 121314 RVA: 0x0042B13C File Offset: 0x0042933C
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x17008912 RID: 35090
		// (get) Token: 0x0601D9E3 RID: 121315 RVA: 0x0042B158 File Offset: 0x00429358
		public bool IsNotInTargetDirection
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008913 RID: 35091
		// (get) Token: 0x0601D9E4 RID: 121316 RVA: 0x0042B198 File Offset: 0x00429398
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

		// Token: 0x0601D9E5 RID: 121317 RVA: 0x0042B1D8 File Offset: 0x004293D8
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

		// Token: 0x0601D9E6 RID: 121318 RVA: 0x0042B227 File Offset: 0x00429427
		public static void StartICheckEntityGravityDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601D9E7 RID: 121319 RVA: 0x0042B230 File Offset: 0x00429430
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D9E8 RID: 121320 RVA: 0x0042B23B File Offset: 0x0042943B
		public static void AddTargetType(FlatBufferBuilder builder, TCheckTarget targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601D9E9 RID: 121321 RVA: 0x0042B246 File Offset: 0x00429446
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601D9EA RID: 121322 RVA: 0x0042B251 File Offset: 0x00429451
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(3, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0601D9EB RID: 121323 RVA: 0x0042B25C File Offset: 0x0042945C
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(4, gravityDirectionOffset, 0);
		}

		// Token: 0x0601D9EC RID: 121324 RVA: 0x0042B267 File Offset: 0x00429467
		public static void AddIsNotInTargetDirection(FlatBufferBuilder builder, bool isNotInTargetDirection)
		{
			builder.AddBool(5, isNotInTargetDirection, false);
		}

		// Token: 0x0601D9ED RID: 121325 RVA: 0x0042B272 File Offset: 0x00429472
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601D9EE RID: 121326 RVA: 0x0042B27D File Offset: 0x0042947D
		public static Offset<ICheckEntityGravityDirection> EndICheckEntityGravityDirection(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityGravityDirection>(builder.EndTable());
		}

		// Token: 0x0601D9EF RID: 121327 RVA: 0x0042B28C File Offset: 0x0042948C
		public ICheckEntityGravityDirectionT UnPack()
		{
			ICheckEntityGravityDirectionT checkEntityGravityDirectionT = new ICheckEntityGravityDirectionT();
			this.UnPackTo(checkEntityGravityDirectionT);
			return checkEntityGravityDirectionT;
		}

		// Token: 0x0601D9F0 RID: 121328 RVA: 0x0042B2A8 File Offset: 0x004294A8
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

		// Token: 0x0601D9F1 RID: 121329 RVA: 0x0042B498 File Offset: 0x00429698
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

		// Token: 0x0400D23F RID: 53823
		private Table __p;
	}
}

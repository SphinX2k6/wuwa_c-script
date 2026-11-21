using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D6A RID: 28010
	public struct IEntitySplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700CD7D RID: 52605
		// (get) Token: 0x06030530 RID: 197936 RVA: 0x006911AF File Offset: 0x0068F3AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030531 RID: 197937 RVA: 0x006911BC File Offset: 0x0068F3BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030532 RID: 197938 RVA: 0x006911C4 File Offset: 0x0068F3C4
		public static IEntitySplineMoveTarget GetRootAsIEntitySplineMoveTarget(ByteBuffer _bb)
		{
			return IEntitySplineMoveTarget.GetRootAsIEntitySplineMoveTarget(_bb, default(IEntitySplineMoveTarget));
		}

		// Token: 0x06030533 RID: 197939 RVA: 0x006911E0 File Offset: 0x0068F3E0
		public static IEntitySplineMoveTarget GetRootAsIEntitySplineMoveTarget(ByteBuffer _bb, IEntitySplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030534 RID: 197940 RVA: 0x006911FD File Offset: 0x0068F3FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030535 RID: 197941 RVA: 0x0069120C File Offset: 0x0068F40C
		public IEntitySplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD7E RID: 52606
		// (get) Token: 0x06030536 RID: 197942 RVA: 0x0069121C File Offset: 0x0068F41C
		public ESplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveTargetType.Entity;
				}
				return (ESplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD7F RID: 52607
		// (get) Token: 0x06030537 RID: 197943 RVA: 0x00691258 File Offset: 0x0068F458
		public int EntityId
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

		// Token: 0x1700CD80 RID: 52608
		// (get) Token: 0x06030538 RID: 197944 RVA: 0x00691294 File Offset: 0x0068F494
		public TMoveDriveMode MoveDriveModeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TMoveDriveMode.NONE;
				}
				return (TMoveDriveMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030539 RID: 197945 RVA: 0x006912D0 File Offset: 0x0068F4D0
		public TTable? MoveDriveMode<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603053A RID: 197946 RVA: 0x00691318 File Offset: 0x0068F518
		public IInputDrivenMoveDriveMode MoveDriveModeAsIInputDrivenMoveDriveMode()
		{
			return this.MoveDriveMode<IInputDrivenMoveDriveMode>().Value;
		}

		// Token: 0x0603053B RID: 197947 RVA: 0x00691334 File Offset: 0x0068F534
		public IPositionDrivenMoveDriveMode MoveDriveModeAsIPositionDrivenMoveDriveMode()
		{
			return this.MoveDriveMode<IPositionDrivenMoveDriveMode>().Value;
		}

		// Token: 0x0603053C RID: 197948 RVA: 0x0069134F File Offset: 0x0068F54F
		public static Offset<IEntitySplineMoveTarget> CreateIEntitySplineMoveTarget(FlatBufferBuilder builder, ESplineMoveTargetType Type = ESplineMoveTargetType.Entity, int EntityId = 0, TMoveDriveMode MoveDriveMode_type = TMoveDriveMode.NONE, int MoveDriveModeOffset = 0)
		{
			builder.StartTable(4);
			IEntitySplineMoveTarget.AddMoveDriveMode(builder, MoveDriveModeOffset);
			IEntitySplineMoveTarget.AddEntityId(builder, EntityId);
			IEntitySplineMoveTarget.AddMoveDriveModeType(builder, MoveDriveMode_type);
			IEntitySplineMoveTarget.AddType(builder, Type);
			return IEntitySplineMoveTarget.EndIEntitySplineMoveTarget(builder);
		}

		// Token: 0x0603053D RID: 197949 RVA: 0x0069137B File Offset: 0x0068F57B
		public static void StartIEntitySplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603053E RID: 197950 RVA: 0x00691384 File Offset: 0x0068F584
		public static void AddType(FlatBufferBuilder builder, ESplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603053F RID: 197951 RVA: 0x0069138F File Offset: 0x0068F58F
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06030540 RID: 197952 RVA: 0x0069139A File Offset: 0x0068F59A
		public static void AddMoveDriveModeType(FlatBufferBuilder builder, TMoveDriveMode moveDriveModeType)
		{
			builder.AddByte(2, (byte)moveDriveModeType, 0);
		}

		// Token: 0x06030541 RID: 197953 RVA: 0x006913A5 File Offset: 0x0068F5A5
		public static void AddMoveDriveMode(FlatBufferBuilder builder, int moveDriveModeOffset)
		{
			builder.AddOffset(3, moveDriveModeOffset, 0);
		}

		// Token: 0x06030542 RID: 197954 RVA: 0x006913B0 File Offset: 0x0068F5B0
		public static Offset<IEntitySplineMoveTarget> EndIEntitySplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<IEntitySplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x06030543 RID: 197955 RVA: 0x006913C0 File Offset: 0x0068F5C0
		public IEntitySplineMoveTargetT UnPack()
		{
			IEntitySplineMoveTargetT entitySplineMoveTargetT = new IEntitySplineMoveTargetT();
			this.UnPackTo(entitySplineMoveTargetT);
			return entitySplineMoveTargetT;
		}

		// Token: 0x06030544 RID: 197956 RVA: 0x006913DC File Offset: 0x0068F5DC
		public void UnPackTo(IEntitySplineMoveTargetT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.MoveDriveMode = new TMoveDriveModeUnion();
			_o.MoveDriveMode.Type = this.MoveDriveModeType;
			TMoveDriveMode moveDriveModeType = this.MoveDriveModeType;
			if (moveDriveModeType == TMoveDriveMode.IInputDrivenMoveDriveMode)
			{
				_o.MoveDriveMode.Value = ((this.MoveDriveMode<IInputDrivenMoveDriveMode>() != null) ? this.MoveDriveMode<IInputDrivenMoveDriveMode>().Value.UnPack() : null);
				return;
			}
			if (moveDriveModeType != TMoveDriveMode.IPositionDrivenMoveDriveMode)
			{
				return;
			}
			_o.MoveDriveMode.Value = ((this.MoveDriveMode<IPositionDrivenMoveDriveMode>() != null) ? this.MoveDriveMode<IPositionDrivenMoveDriveMode>().Value.UnPack() : null);
		}

		// Token: 0x06030545 RID: 197957 RVA: 0x00691498 File Offset: 0x0068F698
		public static Offset<IEntitySplineMoveTarget> Pack(FlatBufferBuilder builder, IEntitySplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntitySplineMoveTarget>);
			}
			TMoveDriveMode moveDriveMode_type = (_o.MoveDriveMode == null) ? TMoveDriveMode.NONE : _o.MoveDriveMode.Type;
			int moveDriveModeOffset = (_o.MoveDriveMode == null) ? 0 : TMoveDriveModeUnion.Pack(builder, _o.MoveDriveMode);
			return IEntitySplineMoveTarget.CreateIEntitySplineMoveTarget(builder, _o.Type, _o.EntityId, moveDriveMode_type, moveDriveModeOffset);
		}

		// Token: 0x04011BEC RID: 72684
		private Table __p;
	}
}

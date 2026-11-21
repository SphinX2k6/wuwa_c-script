using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004679 RID: 18041
	public struct ITrackType : IFlatbufferObject
	{
		// Token: 0x17007E71 RID: 32369
		// (get) Token: 0x0601A7BA RID: 108474 RVA: 0x003C525D File Offset: 0x003C345D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A7BB RID: 108475 RVA: 0x003C526A File Offset: 0x003C346A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A7BC RID: 108476 RVA: 0x003C5274 File Offset: 0x003C3474
		public static ITrackType GetRootAsITrackType(ByteBuffer _bb)
		{
			return ITrackType.GetRootAsITrackType(_bb, default(ITrackType));
		}

		// Token: 0x0601A7BD RID: 108477 RVA: 0x003C5290 File Offset: 0x003C3490
		public static ITrackType GetRootAsITrackType(ByteBuffer _bb, ITrackType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A7BE RID: 108478 RVA: 0x003C52AD File Offset: 0x003C34AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A7BF RID: 108479 RVA: 0x003C52BC File Offset: 0x003C34BC
		public ITrackType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E72 RID: 32370
		// (get) Token: 0x0601A7C0 RID: 108480 RVA: 0x003C52CC File Offset: 0x003C34CC
		public ETrackType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackType.Locations;
				}
				return (ETrackType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E73 RID: 32371
		// (get) Token: 0x0601A7C1 RID: 108481 RVA: 0x003C5308 File Offset: 0x003C3508
		public TGravityDirection GravityDirectionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TGravityDirection.NONE;
				}
				return (TGravityDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A7C2 RID: 108482 RVA: 0x003C5344 File Offset: 0x003C3544
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A7C3 RID: 108483 RVA: 0x003C5388 File Offset: 0x003C3588
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0601A7C4 RID: 108484 RVA: 0x003C53A4 File Offset: 0x003C35A4
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0601A7C5 RID: 108485 RVA: 0x003C53C0 File Offset: 0x003C35C0
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0601A7C6 RID: 108486 RVA: 0x003C53DC File Offset: 0x003C35DC
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x0601A7C7 RID: 108487 RVA: 0x003C53F7 File Offset: 0x003C35F7
		public static Offset<ITrackType> CreateITrackType(FlatBufferBuilder builder, ETrackType Type = ETrackType.Locations, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0)
		{
			builder.StartTable(3);
			ITrackType.AddGravityDirection(builder, GravityDirectionOffset);
			ITrackType.AddGravityDirectionType(builder, GravityDirection_type);
			ITrackType.AddType(builder, Type);
			return ITrackType.EndITrackType(builder);
		}

		// Token: 0x0601A7C8 RID: 108488 RVA: 0x003C541B File Offset: 0x003C361B
		public static void StartITrackType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A7C9 RID: 108489 RVA: 0x003C5424 File Offset: 0x003C3624
		public static void AddType(FlatBufferBuilder builder, ETrackType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A7CA RID: 108490 RVA: 0x003C542F File Offset: 0x003C362F
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(1, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0601A7CB RID: 108491 RVA: 0x003C543A File Offset: 0x003C363A
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(2, gravityDirectionOffset, 0);
		}

		// Token: 0x0601A7CC RID: 108492 RVA: 0x003C5445 File Offset: 0x003C3645
		public static Offset<ITrackType> EndITrackType(FlatBufferBuilder builder)
		{
			return new Offset<ITrackType>(builder.EndTable());
		}

		// Token: 0x0601A7CD RID: 108493 RVA: 0x003C5454 File Offset: 0x003C3654
		public ITrackTypeT UnPack()
		{
			ITrackTypeT trackTypeT = new ITrackTypeT();
			this.UnPackTo(trackTypeT);
			return trackTypeT;
		}

		// Token: 0x0601A7CE RID: 108494 RVA: 0x003C5470 File Offset: 0x003C3670
		public void UnPackTo(ITrackTypeT _o)
		{
			_o.Type = this.Type;
			_o.GravityDirection = new TGravityDirectionUnion();
			_o.GravityDirection.Type = this.GravityDirectionType;
			switch (this.GravityDirectionType)
			{
			case TGravityDirection.IGravityDirectionByEntityGravity:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionByEntityGravity>() != null) ? this.GravityDirection<IGravityDirectionByEntityGravity>().Value.UnPack() : null);
				return;
			case TGravityDirection.IGravityDirectionSelfRotation:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionSelfRotation>() != null) ? this.GravityDirection<IGravityDirectionSelfRotation>().Value.UnPack() : null);
				return;
			case TGravityDirection.IGravityDirectionVectorInfo:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionVectorInfo>() != null) ? this.GravityDirection<IGravityDirectionVectorInfo>().Value.UnPack() : null);
				return;
			case TGravityDirection.IGravityDirectionWorldAxis:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionWorldAxis>() != null) ? this.GravityDirection<IGravityDirectionWorldAxis>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601A7CF RID: 108495 RVA: 0x003C55A0 File Offset: 0x003C37A0
		public static Offset<ITrackType> Pack(FlatBufferBuilder builder, ITrackTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackType>);
			}
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			return ITrackType.CreateITrackType(builder, _o.Type, gravityDirection_type, gravityDirectionOffset);
		}

		// Token: 0x0400C8A4 RID: 51364
		private Table __p;
	}
}

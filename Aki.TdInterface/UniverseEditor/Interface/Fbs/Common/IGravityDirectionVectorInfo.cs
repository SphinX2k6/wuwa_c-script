using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E00 RID: 24064
	public struct IGravityDirectionVectorInfo : IFlatbufferObject
	{
		// Token: 0x1700B40C RID: 46092
		// (get) Token: 0x06029306 RID: 168710 RVA: 0x005A69BC File Offset: 0x005A4BBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029307 RID: 168711 RVA: 0x005A69C9 File Offset: 0x005A4BC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029308 RID: 168712 RVA: 0x005A69D0 File Offset: 0x005A4BD0
		public static IGravityDirectionVectorInfo GetRootAsIGravityDirectionVectorInfo(ByteBuffer _bb)
		{
			return IGravityDirectionVectorInfo.GetRootAsIGravityDirectionVectorInfo(_bb, default(IGravityDirectionVectorInfo));
		}

		// Token: 0x06029309 RID: 168713 RVA: 0x005A69EC File Offset: 0x005A4BEC
		public static IGravityDirectionVectorInfo GetRootAsIGravityDirectionVectorInfo(ByteBuffer _bb, IGravityDirectionVectorInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602930A RID: 168714 RVA: 0x005A6A09 File Offset: 0x005A4C09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602930B RID: 168715 RVA: 0x005A6A18 File Offset: 0x005A4C18
		public IGravityDirectionVectorInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B40D RID: 46093
		// (get) Token: 0x0602930C RID: 168716 RVA: 0x005A6A28 File Offset: 0x005A4C28
		public EGravityDirectionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGravityDirectionType.SelfRotation;
				}
				return (EGravityDirectionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B40E RID: 46094
		// (get) Token: 0x0602930D RID: 168717 RVA: 0x005A6A64 File Offset: 0x005A4C64
		public IVectorInfo? Direction
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602930E RID: 168718 RVA: 0x005A6AC1 File Offset: 0x005A4CC1
		public static Offset<IGravityDirectionVectorInfo> CreateIGravityDirectionVectorInfo(FlatBufferBuilder builder, EGravityDirectionType Type = EGravityDirectionType.SelfRotation, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IGravityDirectionVectorInfo.AddDirection(builder, DirectionOffset);
			IGravityDirectionVectorInfo.AddType(builder, Type);
			return IGravityDirectionVectorInfo.EndIGravityDirectionVectorInfo(builder);
		}

		// Token: 0x0602930F RID: 168719 RVA: 0x005A6ADE File Offset: 0x005A4CDE
		public static void StartIGravityDirectionVectorInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029310 RID: 168720 RVA: 0x005A6AE7 File Offset: 0x005A4CE7
		public static void AddType(FlatBufferBuilder builder, EGravityDirectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029311 RID: 168721 RVA: 0x005A6AF2 File Offset: 0x005A4CF2
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(1, directionOffset.Value, 0);
		}

		// Token: 0x06029312 RID: 168722 RVA: 0x005A6B02 File Offset: 0x005A4D02
		public static Offset<IGravityDirectionVectorInfo> EndIGravityDirectionVectorInfo(FlatBufferBuilder builder)
		{
			return new Offset<IGravityDirectionVectorInfo>(builder.EndTable());
		}

		// Token: 0x06029313 RID: 168723 RVA: 0x005A6B10 File Offset: 0x005A4D10
		public IGravityDirectionVectorInfoT UnPack()
		{
			IGravityDirectionVectorInfoT gravityDirectionVectorInfoT = new IGravityDirectionVectorInfoT();
			this.UnPackTo(gravityDirectionVectorInfoT);
			return gravityDirectionVectorInfoT;
		}

		// Token: 0x06029314 RID: 168724 RVA: 0x005A6B2C File Offset: 0x005A4D2C
		public void UnPackTo(IGravityDirectionVectorInfoT _o)
		{
			_o.Type = this.Type;
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
		}

		// Token: 0x06029315 RID: 168725 RVA: 0x005A6B74 File Offset: 0x005A4D74
		public static Offset<IGravityDirectionVectorInfo> Pack(FlatBufferBuilder builder, IGravityDirectionVectorInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityDirectionVectorInfo>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return IGravityDirectionVectorInfo.CreateIGravityDirectionVectorInfo(builder, _o.Type, directionOffset);
		}

		// Token: 0x0400F7F2 RID: 63474
		private Table __p;
	}
}

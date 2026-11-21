using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D55 RID: 23893
	public struct IPointAttachTarget : IFlatbufferObject
	{
		// Token: 0x1700AFE6 RID: 45030
		// (get) Token: 0x06027C63 RID: 162915 RVA: 0x00571222 File Offset: 0x0056F422
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027C64 RID: 162916 RVA: 0x0057122F File Offset: 0x0056F42F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027C65 RID: 162917 RVA: 0x00571238 File Offset: 0x0056F438
		public static IPointAttachTarget GetRootAsIPointAttachTarget(ByteBuffer _bb)
		{
			return IPointAttachTarget.GetRootAsIPointAttachTarget(_bb, default(IPointAttachTarget));
		}

		// Token: 0x06027C66 RID: 162918 RVA: 0x00571254 File Offset: 0x0056F454
		public static IPointAttachTarget GetRootAsIPointAttachTarget(ByteBuffer _bb, IPointAttachTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027C67 RID: 162919 RVA: 0x00571271 File Offset: 0x0056F471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027C68 RID: 162920 RVA: 0x00571280 File Offset: 0x0056F480
		public IPointAttachTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFE7 RID: 45031
		// (get) Token: 0x06027C69 RID: 162921 RVA: 0x00571290 File Offset: 0x0056F490
		public EAttachType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachType.Actor;
				}
				return (EAttachType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AFE8 RID: 45032
		// (get) Token: 0x06027C6A RID: 162922 RVA: 0x005712CC File Offset: 0x0056F4CC
		public IVectorInfo? RelativePoint
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

		// Token: 0x06027C6B RID: 162923 RVA: 0x00571329 File Offset: 0x0056F529
		public static Offset<IPointAttachTarget> CreateIPointAttachTarget(FlatBufferBuilder builder, EAttachType Type = EAttachType.Actor, Offset<IVectorInfo> RelativePointOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPointAttachTarget.AddRelativePoint(builder, RelativePointOffset);
			IPointAttachTarget.AddType(builder, Type);
			return IPointAttachTarget.EndIPointAttachTarget(builder);
		}

		// Token: 0x06027C6C RID: 162924 RVA: 0x00571346 File Offset: 0x0056F546
		public static void StartIPointAttachTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027C6D RID: 162925 RVA: 0x0057134F File Offset: 0x0056F54F
		public static void AddType(FlatBufferBuilder builder, EAttachType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027C6E RID: 162926 RVA: 0x0057135A File Offset: 0x0056F55A
		public static void AddRelativePoint(FlatBufferBuilder builder, Offset<IVectorInfo> relativePointOffset)
		{
			builder.AddOffset(1, relativePointOffset.Value, 0);
		}

		// Token: 0x06027C6F RID: 162927 RVA: 0x0057136A File Offset: 0x0056F56A
		public static Offset<IPointAttachTarget> EndIPointAttachTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPointAttachTarget>(builder.EndTable());
		}

		// Token: 0x06027C70 RID: 162928 RVA: 0x00571378 File Offset: 0x0056F578
		public IPointAttachTargetT UnPack()
		{
			IPointAttachTargetT pointAttachTargetT = new IPointAttachTargetT();
			this.UnPackTo(pointAttachTargetT);
			return pointAttachTargetT;
		}

		// Token: 0x06027C71 RID: 162929 RVA: 0x00571394 File Offset: 0x0056F594
		public void UnPackTo(IPointAttachTargetT _o)
		{
			_o.Type = this.Type;
			_o.RelativePoint = ((this.RelativePoint != null) ? this.RelativePoint.Value.UnPack() : null);
		}

		// Token: 0x06027C72 RID: 162930 RVA: 0x005713DC File Offset: 0x0056F5DC
		public static Offset<IPointAttachTarget> Pack(FlatBufferBuilder builder, IPointAttachTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPointAttachTarget>);
			}
			Offset<IVectorInfo> relativePointOffset = (_o.RelativePoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RelativePoint);
			return IPointAttachTarget.CreateIPointAttachTarget(builder, _o.Type, relativePointOffset);
		}

		// Token: 0x0400F8D8 RID: 63704
		private Table __p;
	}
}

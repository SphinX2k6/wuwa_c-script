using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E0 RID: 29408
	public struct INewSplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700D7AC RID: 55212
		// (get) Token: 0x0603347B RID: 210043 RVA: 0x006EAEF0 File Offset: 0x006E90F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603347C RID: 210044 RVA: 0x006EAEFD File Offset: 0x006E90FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603347D RID: 210045 RVA: 0x006EAF04 File Offset: 0x006E9104
		public static INewSplineMoveTarget GetRootAsINewSplineMoveTarget(ByteBuffer _bb)
		{
			return INewSplineMoveTarget.GetRootAsINewSplineMoveTarget(_bb, default(INewSplineMoveTarget));
		}

		// Token: 0x0603347E RID: 210046 RVA: 0x006EAF20 File Offset: 0x006E9120
		public static INewSplineMoveTarget GetRootAsINewSplineMoveTarget(ByteBuffer _bb, INewSplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603347F RID: 210047 RVA: 0x006EAF3D File Offset: 0x006E913D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033480 RID: 210048 RVA: 0x006EAF4C File Offset: 0x006E914C
		public INewSplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7AD RID: 55213
		// (get) Token: 0x06033481 RID: 210049 RVA: 0x006EAF5C File Offset: 0x006E915C
		public ENewSplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return (ENewSplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033482 RID: 210050 RVA: 0x006EAF98 File Offset: 0x006E9198
		public static Offset<INewSplineMoveTarget> CreateINewSplineMoveTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player)
		{
			builder.StartTable(1);
			INewSplineMoveTarget.AddType(builder, Type);
			return INewSplineMoveTarget.EndINewSplineMoveTarget(builder);
		}

		// Token: 0x06033483 RID: 210051 RVA: 0x006EAFAE File Offset: 0x006E91AE
		public static void StartINewSplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033484 RID: 210052 RVA: 0x006EAFB7 File Offset: 0x006E91B7
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033485 RID: 210053 RVA: 0x006EAFC2 File Offset: 0x006E91C2
		public static Offset<INewSplineMoveTarget> EndINewSplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<INewSplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x06033486 RID: 210054 RVA: 0x006EAFD0 File Offset: 0x006E91D0
		public INewSplineMoveTargetT UnPack()
		{
			INewSplineMoveTargetT newSplineMoveTargetT = new INewSplineMoveTargetT();
			this.UnPackTo(newSplineMoveTargetT);
			return newSplineMoveTargetT;
		}

		// Token: 0x06033487 RID: 210055 RVA: 0x006EAFEB File Offset: 0x006E91EB
		public void UnPackTo(INewSplineMoveTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033488 RID: 210056 RVA: 0x006EAFFC File Offset: 0x006E91FC
		public static Offset<INewSplineMoveTarget> Pack(FlatBufferBuilder builder, INewSplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<INewSplineMoveTarget>);
			}
			return INewSplineMoveTarget.CreateINewSplineMoveTarget(builder, _o.Type);
		}

		// Token: 0x0401238A RID: 74634
		private Table __p;
	}
}

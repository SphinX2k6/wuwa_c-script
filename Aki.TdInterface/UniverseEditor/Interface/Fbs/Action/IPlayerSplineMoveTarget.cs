using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D11 RID: 27921
	public struct IPlayerSplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700CFE7 RID: 53223
		// (get) Token: 0x060313BE RID: 201662 RVA: 0x006AD9A1 File Offset: 0x006ABBA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060313BF RID: 201663 RVA: 0x006AD9AE File Offset: 0x006ABBAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060313C0 RID: 201664 RVA: 0x006AD9B8 File Offset: 0x006ABBB8
		public static IPlayerSplineMoveTarget GetRootAsIPlayerSplineMoveTarget(ByteBuffer _bb)
		{
			return IPlayerSplineMoveTarget.GetRootAsIPlayerSplineMoveTarget(_bb, default(IPlayerSplineMoveTarget));
		}

		// Token: 0x060313C1 RID: 201665 RVA: 0x006AD9D4 File Offset: 0x006ABBD4
		public static IPlayerSplineMoveTarget GetRootAsIPlayerSplineMoveTarget(ByteBuffer _bb, IPlayerSplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060313C2 RID: 201666 RVA: 0x006AD9F1 File Offset: 0x006ABBF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060313C3 RID: 201667 RVA: 0x006ADA00 File Offset: 0x006ABC00
		public IPlayerSplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFE8 RID: 53224
		// (get) Token: 0x060313C4 RID: 201668 RVA: 0x006ADA10 File Offset: 0x006ABC10
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

		// Token: 0x060313C5 RID: 201669 RVA: 0x006ADA4C File Offset: 0x006ABC4C
		public static Offset<IPlayerSplineMoveTarget> CreateIPlayerSplineMoveTarget(FlatBufferBuilder builder, ESplineMoveTargetType Type = ESplineMoveTargetType.Entity)
		{
			builder.StartTable(1);
			IPlayerSplineMoveTarget.AddType(builder, Type);
			return IPlayerSplineMoveTarget.EndIPlayerSplineMoveTarget(builder);
		}

		// Token: 0x060313C6 RID: 201670 RVA: 0x006ADA62 File Offset: 0x006ABC62
		public static void StartIPlayerSplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060313C7 RID: 201671 RVA: 0x006ADA6B File Offset: 0x006ABC6B
		public static void AddType(FlatBufferBuilder builder, ESplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060313C8 RID: 201672 RVA: 0x006ADA76 File Offset: 0x006ABC76
		public static Offset<IPlayerSplineMoveTarget> EndIPlayerSplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerSplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x060313C9 RID: 201673 RVA: 0x006ADA84 File Offset: 0x006ABC84
		public IPlayerSplineMoveTargetT UnPack()
		{
			IPlayerSplineMoveTargetT playerSplineMoveTargetT = new IPlayerSplineMoveTargetT();
			this.UnPackTo(playerSplineMoveTargetT);
			return playerSplineMoveTargetT;
		}

		// Token: 0x060313CA RID: 201674 RVA: 0x006ADA9F File Offset: 0x006ABC9F
		public void UnPackTo(IPlayerSplineMoveTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060313CB RID: 201675 RVA: 0x006ADAB0 File Offset: 0x006ABCB0
		public static Offset<IPlayerSplineMoveTarget> Pack(FlatBufferBuilder builder, IPlayerSplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerSplineMoveTarget>);
			}
			return IPlayerSplineMoveTarget.CreateIPlayerSplineMoveTarget(builder, _o.Type);
		}

		// Token: 0x0401168C RID: 71308
		private Table __p;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007334 RID: 29492
	public struct INpcLookAtPosition : IFlatbufferObject
	{
		// Token: 0x1700D827 RID: 55335
		// (get) Token: 0x060336E6 RID: 210662 RVA: 0x006EEFD5 File Offset: 0x006ED1D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060336E7 RID: 210663 RVA: 0x006EEFE2 File Offset: 0x006ED1E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060336E8 RID: 210664 RVA: 0x006EEFEC File Offset: 0x006ED1EC
		public static INpcLookAtPosition GetRootAsINpcLookAtPosition(ByteBuffer _bb)
		{
			return INpcLookAtPosition.GetRootAsINpcLookAtPosition(_bb, default(INpcLookAtPosition));
		}

		// Token: 0x060336E9 RID: 210665 RVA: 0x006EF008 File Offset: 0x006ED208
		public static INpcLookAtPosition GetRootAsINpcLookAtPosition(ByteBuffer _bb, INpcLookAtPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060336EA RID: 210666 RVA: 0x006EF025 File Offset: 0x006ED225
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060336EB RID: 210667 RVA: 0x006EF034 File Offset: 0x006ED234
		public INpcLookAtPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D828 RID: 55336
		// (get) Token: 0x060336EC RID: 210668 RVA: 0x006EF044 File Offset: 0x006ED244
		public ECommonTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTargetType.Player;
				}
				return (ECommonTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D829 RID: 55337
		// (get) Token: 0x060336ED RID: 210669 RVA: 0x006EF080 File Offset: 0x006ED280
		public IVectorInfo? Position
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

		// Token: 0x060336EE RID: 210670 RVA: 0x006EF0DD File Offset: 0x006ED2DD
		public static Offset<INpcLookAtPosition> CreateINpcLookAtPosition(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			INpcLookAtPosition.AddPosition(builder, PositionOffset);
			INpcLookAtPosition.AddType(builder, Type);
			return INpcLookAtPosition.EndINpcLookAtPosition(builder);
		}

		// Token: 0x060336EF RID: 210671 RVA: 0x006EF0FA File Offset: 0x006ED2FA
		public static void StartINpcLookAtPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060336F0 RID: 210672 RVA: 0x006EF103 File Offset: 0x006ED303
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060336F1 RID: 210673 RVA: 0x006EF10E File Offset: 0x006ED30E
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x060336F2 RID: 210674 RVA: 0x006EF11E File Offset: 0x006ED31E
		public static Offset<INpcLookAtPosition> EndINpcLookAtPosition(FlatBufferBuilder builder)
		{
			return new Offset<INpcLookAtPosition>(builder.EndTable());
		}

		// Token: 0x060336F3 RID: 210675 RVA: 0x006EF12C File Offset: 0x006ED32C
		public INpcLookAtPositionT UnPack()
		{
			INpcLookAtPositionT npcLookAtPositionT = new INpcLookAtPositionT();
			this.UnPackTo(npcLookAtPositionT);
			return npcLookAtPositionT;
		}

		// Token: 0x060336F4 RID: 210676 RVA: 0x006EF148 File Offset: 0x006ED348
		public void UnPackTo(INpcLookAtPositionT _o)
		{
			_o.Type = this.Type;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x060336F5 RID: 210677 RVA: 0x006EF190 File Offset: 0x006ED390
		public static Offset<INpcLookAtPosition> Pack(FlatBufferBuilder builder, INpcLookAtPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcLookAtPosition>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			return INpcLookAtPosition.CreateINpcLookAtPosition(builder, _o.Type, positionOffset);
		}

		// Token: 0x040123FE RID: 74750
		private Table __p;
	}
}

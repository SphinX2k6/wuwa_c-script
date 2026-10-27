using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD0 RID: 27600
	public struct INpcLookAtPosition : IFlatbufferObject
	{
		// Token: 0x1700CD1B RID: 52507
		// (get) Token: 0x060307CA RID: 198602 RVA: 0x006956D5 File Offset: 0x006938D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060307CB RID: 198603 RVA: 0x006956E2 File Offset: 0x006938E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060307CC RID: 198604 RVA: 0x006956EC File Offset: 0x006938EC
		public static INpcLookAtPosition GetRootAsINpcLookAtPosition(ByteBuffer _bb)
		{
			return INpcLookAtPosition.GetRootAsINpcLookAtPosition(_bb, default(INpcLookAtPosition));
		}

		// Token: 0x060307CD RID: 198605 RVA: 0x00695708 File Offset: 0x00693908
		public static INpcLookAtPosition GetRootAsINpcLookAtPosition(ByteBuffer _bb, INpcLookAtPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060307CE RID: 198606 RVA: 0x00695725 File Offset: 0x00693925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060307CF RID: 198607 RVA: 0x00695734 File Offset: 0x00693934
		public INpcLookAtPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD1C RID: 52508
		// (get) Token: 0x060307D0 RID: 198608 RVA: 0x00695744 File Offset: 0x00693944
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

		// Token: 0x1700CD1D RID: 52509
		// (get) Token: 0x060307D1 RID: 198609 RVA: 0x00695780 File Offset: 0x00693980
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

		// Token: 0x060307D2 RID: 198610 RVA: 0x006957DD File Offset: 0x006939DD
		public static Offset<INpcLookAtPosition> CreateINpcLookAtPosition(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			INpcLookAtPosition.AddPosition(builder, PositionOffset);
			INpcLookAtPosition.AddType(builder, Type);
			return INpcLookAtPosition.EndINpcLookAtPosition(builder);
		}

		// Token: 0x060307D3 RID: 198611 RVA: 0x006957FA File Offset: 0x006939FA
		public static void StartINpcLookAtPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060307D4 RID: 198612 RVA: 0x00695803 File Offset: 0x00693A03
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060307D5 RID: 198613 RVA: 0x0069580E File Offset: 0x00693A0E
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x060307D6 RID: 198614 RVA: 0x0069581E File Offset: 0x00693A1E
		public static Offset<INpcLookAtPosition> EndINpcLookAtPosition(FlatBufferBuilder builder)
		{
			return new Offset<INpcLookAtPosition>(builder.EndTable());
		}

		// Token: 0x060307D7 RID: 198615 RVA: 0x0069582C File Offset: 0x00693A2C
		public INpcLookAtPositionT UnPack()
		{
			INpcLookAtPositionT npcLookAtPositionT = new INpcLookAtPositionT();
			this.UnPackTo(npcLookAtPositionT);
			return npcLookAtPositionT;
		}

		// Token: 0x060307D8 RID: 198616 RVA: 0x00695848 File Offset: 0x00693A48
		public void UnPackTo(INpcLookAtPositionT _o)
		{
			_o.Type = this.Type;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x060307D9 RID: 198617 RVA: 0x00695890 File Offset: 0x00693A90
		public static Offset<INpcLookAtPosition> Pack(FlatBufferBuilder builder, INpcLookAtPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcLookAtPosition>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			return INpcLookAtPosition.CreateINpcLookAtPosition(builder, _o.Type, positionOffset);
		}

		// Token: 0x040114AF RID: 70831
		private Table __p;
	}
}

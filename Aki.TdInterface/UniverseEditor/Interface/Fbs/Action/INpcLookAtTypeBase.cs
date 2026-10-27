using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD3 RID: 27603
	public struct INpcLookAtTypeBase : IFlatbufferObject
	{
		// Token: 0x1700CD20 RID: 52512
		// (get) Token: 0x060307E0 RID: 198624 RVA: 0x00695964 File Offset: 0x00693B64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060307E1 RID: 198625 RVA: 0x00695971 File Offset: 0x00693B71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060307E2 RID: 198626 RVA: 0x00695978 File Offset: 0x00693B78
		public static INpcLookAtTypeBase GetRootAsINpcLookAtTypeBase(ByteBuffer _bb)
		{
			return INpcLookAtTypeBase.GetRootAsINpcLookAtTypeBase(_bb, default(INpcLookAtTypeBase));
		}

		// Token: 0x060307E3 RID: 198627 RVA: 0x00695994 File Offset: 0x00693B94
		public static INpcLookAtTypeBase GetRootAsINpcLookAtTypeBase(ByteBuffer _bb, INpcLookAtTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060307E4 RID: 198628 RVA: 0x006959B1 File Offset: 0x00693BB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060307E5 RID: 198629 RVA: 0x006959C0 File Offset: 0x00693BC0
		public INpcLookAtTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD21 RID: 52513
		// (get) Token: 0x060307E6 RID: 198630 RVA: 0x006959D0 File Offset: 0x00693BD0
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

		// Token: 0x060307E7 RID: 198631 RVA: 0x00695A0C File Offset: 0x00693C0C
		public static Offset<INpcLookAtTypeBase> CreateINpcLookAtTypeBase(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player)
		{
			builder.StartTable(1);
			INpcLookAtTypeBase.AddType(builder, Type);
			return INpcLookAtTypeBase.EndINpcLookAtTypeBase(builder);
		}

		// Token: 0x060307E8 RID: 198632 RVA: 0x00695A22 File Offset: 0x00693C22
		public static void StartINpcLookAtTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060307E9 RID: 198633 RVA: 0x00695A2B File Offset: 0x00693C2B
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060307EA RID: 198634 RVA: 0x00695A36 File Offset: 0x00693C36
		public static Offset<INpcLookAtTypeBase> EndINpcLookAtTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<INpcLookAtTypeBase>(builder.EndTable());
		}

		// Token: 0x060307EB RID: 198635 RVA: 0x00695A44 File Offset: 0x00693C44
		public INpcLookAtTypeBaseT UnPack()
		{
			INpcLookAtTypeBaseT npcLookAtTypeBaseT = new INpcLookAtTypeBaseT();
			this.UnPackTo(npcLookAtTypeBaseT);
			return npcLookAtTypeBaseT;
		}

		// Token: 0x060307EC RID: 198636 RVA: 0x00695A5F File Offset: 0x00693C5F
		public void UnPackTo(INpcLookAtTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060307ED RID: 198637 RVA: 0x00695A70 File Offset: 0x00693C70
		public static Offset<INpcLookAtTypeBase> Pack(FlatBufferBuilder builder, INpcLookAtTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcLookAtTypeBase>);
			}
			return INpcLookAtTypeBase.CreateINpcLookAtTypeBase(builder, _o.Type);
		}

		// Token: 0x040114B2 RID: 70834
		private Table __p;
	}
}

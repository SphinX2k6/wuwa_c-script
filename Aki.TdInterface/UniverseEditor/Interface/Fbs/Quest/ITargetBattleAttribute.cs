using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B1 RID: 16817
	public struct ITargetBattleAttribute : IFlatbufferObject
	{
		// Token: 0x17007746 RID: 30534
		// (get) Token: 0x06018C2E RID: 101422 RVA: 0x003909EF File Offset: 0x0038EBEF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018C2F RID: 101423 RVA: 0x003909FC File Offset: 0x0038EBFC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018C30 RID: 101424 RVA: 0x00390A04 File Offset: 0x0038EC04
		public static ITargetBattleAttribute GetRootAsITargetBattleAttribute(ByteBuffer _bb)
		{
			return ITargetBattleAttribute.GetRootAsITargetBattleAttribute(_bb, default(ITargetBattleAttribute));
		}

		// Token: 0x06018C31 RID: 101425 RVA: 0x00390A20 File Offset: 0x0038EC20
		public static ITargetBattleAttribute GetRootAsITargetBattleAttribute(ByteBuffer _bb, ITargetBattleAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018C32 RID: 101426 RVA: 0x00390A3D File Offset: 0x0038EC3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018C33 RID: 101427 RVA: 0x00390A4C File Offset: 0x0038EC4C
		public ITargetBattleAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007747 RID: 30535
		// (get) Token: 0x06018C34 RID: 101428 RVA: 0x00390A5C File Offset: 0x0038EC5C
		public ETargetBattleAttribute Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetBattleAttribute.Player;
				}
				return (ETargetBattleAttribute)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018C35 RID: 101429 RVA: 0x00390A98 File Offset: 0x0038EC98
		public static Offset<ITargetBattleAttribute> CreateITargetBattleAttribute(FlatBufferBuilder builder, ETargetBattleAttribute Type = ETargetBattleAttribute.Player)
		{
			builder.StartTable(1);
			ITargetBattleAttribute.AddType(builder, Type);
			return ITargetBattleAttribute.EndITargetBattleAttribute(builder);
		}

		// Token: 0x06018C36 RID: 101430 RVA: 0x00390AAE File Offset: 0x0038ECAE
		public static void StartITargetBattleAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018C37 RID: 101431 RVA: 0x00390AB7 File Offset: 0x0038ECB7
		public static void AddType(FlatBufferBuilder builder, ETargetBattleAttribute type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018C38 RID: 101432 RVA: 0x00390AC2 File Offset: 0x0038ECC2
		public static Offset<ITargetBattleAttribute> EndITargetBattleAttribute(FlatBufferBuilder builder)
		{
			return new Offset<ITargetBattleAttribute>(builder.EndTable());
		}

		// Token: 0x06018C39 RID: 101433 RVA: 0x00390AD0 File Offset: 0x0038ECD0
		public ITargetBattleAttributeT UnPack()
		{
			ITargetBattleAttributeT targetBattleAttributeT = new ITargetBattleAttributeT();
			this.UnPackTo(targetBattleAttributeT);
			return targetBattleAttributeT;
		}

		// Token: 0x06018C3A RID: 101434 RVA: 0x00390AEB File Offset: 0x0038ECEB
		public void UnPackTo(ITargetBattleAttributeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018C3B RID: 101435 RVA: 0x00390AFC File Offset: 0x0038ECFC
		public static Offset<ITargetBattleAttribute> Pack(FlatBufferBuilder builder, ITargetBattleAttributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetBattleAttribute>);
			}
			return ITargetBattleAttribute.CreateITargetBattleAttribute(builder, _o.Type);
		}

		// Token: 0x0400BDF2 RID: 48626
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E21 RID: 24097
	public struct IRefreshConditionBase : IFlatbufferObject
	{
		// Token: 0x1700B1A1 RID: 45473
		// (get) Token: 0x060283EE RID: 164846 RVA: 0x00580E70 File Offset: 0x0057F070
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060283EF RID: 164847 RVA: 0x00580E7D File Offset: 0x0057F07D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060283F0 RID: 164848 RVA: 0x00580E84 File Offset: 0x0057F084
		public static IRefreshConditionBase GetRootAsIRefreshConditionBase(ByteBuffer _bb)
		{
			return IRefreshConditionBase.GetRootAsIRefreshConditionBase(_bb, default(IRefreshConditionBase));
		}

		// Token: 0x060283F1 RID: 164849 RVA: 0x00580EA0 File Offset: 0x0057F0A0
		public static IRefreshConditionBase GetRootAsIRefreshConditionBase(ByteBuffer _bb, IRefreshConditionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060283F2 RID: 164850 RVA: 0x00580EBD File Offset: 0x0057F0BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060283F3 RID: 164851 RVA: 0x00580ECC File Offset: 0x0057F0CC
		public IRefreshConditionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1A2 RID: 45474
		// (get) Token: 0x060283F4 RID: 164852 RVA: 0x00580EDC File Offset: 0x0057F0DC
		public ERewardDropType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERewardDropType.Death;
				}
				return (ERewardDropType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060283F5 RID: 164853 RVA: 0x00580F18 File Offset: 0x0057F118
		public static Offset<IRefreshConditionBase> CreateIRefreshConditionBase(FlatBufferBuilder builder, ERewardDropType Type = ERewardDropType.Death)
		{
			builder.StartTable(1);
			IRefreshConditionBase.AddType(builder, Type);
			return IRefreshConditionBase.EndIRefreshConditionBase(builder);
		}

		// Token: 0x060283F6 RID: 164854 RVA: 0x00580F2E File Offset: 0x0057F12E
		public static void StartIRefreshConditionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060283F7 RID: 164855 RVA: 0x00580F37 File Offset: 0x0057F137
		public static void AddType(FlatBufferBuilder builder, ERewardDropType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060283F8 RID: 164856 RVA: 0x00580F42 File Offset: 0x0057F142
		public static Offset<IRefreshConditionBase> EndIRefreshConditionBase(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshConditionBase>(builder.EndTable());
		}

		// Token: 0x060283F9 RID: 164857 RVA: 0x00580F50 File Offset: 0x0057F150
		public IRefreshConditionBaseT UnPack()
		{
			IRefreshConditionBaseT refreshConditionBaseT = new IRefreshConditionBaseT();
			this.UnPackTo(refreshConditionBaseT);
			return refreshConditionBaseT;
		}

		// Token: 0x060283FA RID: 164858 RVA: 0x00580F6B File Offset: 0x0057F16B
		public void UnPackTo(IRefreshConditionBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060283FB RID: 164859 RVA: 0x00580F7C File Offset: 0x0057F17C
		public static Offset<IRefreshConditionBase> Pack(FlatBufferBuilder builder, IRefreshConditionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshConditionBase>);
			}
			return IRefreshConditionBase.CreateIRefreshConditionBase(builder, _o.Type);
		}

		// Token: 0x0400FA0A RID: 64010
		private Table __p;
	}
}

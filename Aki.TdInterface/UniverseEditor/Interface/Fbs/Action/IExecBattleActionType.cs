using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D7C RID: 28028
	public struct IExecBattleActionType : IFlatbufferObject
	{
		// Token: 0x1700CDA1 RID: 52641
		// (get) Token: 0x060305DE RID: 198110 RVA: 0x006929D1 File Offset: 0x00690BD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060305DF RID: 198111 RVA: 0x006929DE File Offset: 0x00690BDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060305E0 RID: 198112 RVA: 0x006929E8 File Offset: 0x00690BE8
		public static IExecBattleActionType GetRootAsIExecBattleActionType(ByteBuffer _bb)
		{
			return IExecBattleActionType.GetRootAsIExecBattleActionType(_bb, default(IExecBattleActionType));
		}

		// Token: 0x060305E1 RID: 198113 RVA: 0x00692A04 File Offset: 0x00690C04
		public static IExecBattleActionType GetRootAsIExecBattleActionType(ByteBuffer _bb, IExecBattleActionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060305E2 RID: 198114 RVA: 0x00692A21 File Offset: 0x00690C21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060305E3 RID: 198115 RVA: 0x00692A30 File Offset: 0x00690C30
		public IExecBattleActionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDA2 RID: 52642
		// (get) Token: 0x060305E4 RID: 198116 RVA: 0x00692A40 File Offset: 0x00690C40
		public EExecBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return (EExecBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060305E5 RID: 198117 RVA: 0x00692A7C File Offset: 0x00690C7C
		public static Offset<IExecBattleActionType> CreateIExecBattleActionType(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags)
		{
			builder.StartTable(1);
			IExecBattleActionType.AddType(builder, Type);
			return IExecBattleActionType.EndIExecBattleActionType(builder);
		}

		// Token: 0x060305E6 RID: 198118 RVA: 0x00692A92 File Offset: 0x00690C92
		public static void StartIExecBattleActionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060305E7 RID: 198119 RVA: 0x00692A9B File Offset: 0x00690C9B
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060305E8 RID: 198120 RVA: 0x00692AA6 File Offset: 0x00690CA6
		public static Offset<IExecBattleActionType> EndIExecBattleActionType(FlatBufferBuilder builder)
		{
			return new Offset<IExecBattleActionType>(builder.EndTable());
		}

		// Token: 0x060305E9 RID: 198121 RVA: 0x00692AB4 File Offset: 0x00690CB4
		public IExecBattleActionTypeT UnPack()
		{
			IExecBattleActionTypeT execBattleActionTypeT = new IExecBattleActionTypeT();
			this.UnPackTo(execBattleActionTypeT);
			return execBattleActionTypeT;
		}

		// Token: 0x060305EA RID: 198122 RVA: 0x00692ACF File Offset: 0x00690CCF
		public void UnPackTo(IExecBattleActionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060305EB RID: 198123 RVA: 0x00692AE0 File Offset: 0x00690CE0
		public static Offset<IExecBattleActionType> Pack(FlatBufferBuilder builder, IExecBattleActionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecBattleActionType>);
			}
			return IExecBattleActionType.CreateIExecBattleActionType(builder, _o.Type);
		}

		// Token: 0x04011C01 RID: 72705
		private Table __p;
	}
}

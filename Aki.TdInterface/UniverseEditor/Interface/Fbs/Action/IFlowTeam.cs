using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA5 RID: 28325
	public struct IFlowTeam : IFlatbufferObject
	{
		// Token: 0x1700CFC5 RID: 53189
		// (get) Token: 0x06030FF8 RID: 200696 RVA: 0x006A569A File Offset: 0x006A389A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030FF9 RID: 200697 RVA: 0x006A56A7 File Offset: 0x006A38A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030FFA RID: 200698 RVA: 0x006A56B0 File Offset: 0x006A38B0
		public static IFlowTeam GetRootAsIFlowTeam(ByteBuffer _bb)
		{
			return IFlowTeam.GetRootAsIFlowTeam(_bb, default(IFlowTeam));
		}

		// Token: 0x06030FFB RID: 200699 RVA: 0x006A56CC File Offset: 0x006A38CC
		public static IFlowTeam GetRootAsIFlowTeam(ByteBuffer _bb, IFlowTeam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030FFC RID: 200700 RVA: 0x006A56E9 File Offset: 0x006A38E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030FFD RID: 200701 RVA: 0x006A56F8 File Offset: 0x006A38F8
		public IFlowTeam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFC6 RID: 53190
		// (get) Token: 0x06030FFE RID: 200702 RVA: 0x006A5708 File Offset: 0x006A3908
		public ETeamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeamType.Current;
				}
				return (ETeamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030FFF RID: 200703 RVA: 0x006A5744 File Offset: 0x006A3944
		public static Offset<IFlowTeam> CreateIFlowTeam(FlatBufferBuilder builder, ETeamType Type = ETeamType.Current)
		{
			builder.StartTable(1);
			IFlowTeam.AddType(builder, Type);
			return IFlowTeam.EndIFlowTeam(builder);
		}

		// Token: 0x06031000 RID: 200704 RVA: 0x006A575A File Offset: 0x006A395A
		public static void StartIFlowTeam(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031001 RID: 200705 RVA: 0x006A5763 File Offset: 0x006A3963
		public static void AddType(FlatBufferBuilder builder, ETeamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031002 RID: 200706 RVA: 0x006A576E File Offset: 0x006A396E
		public static Offset<IFlowTeam> EndIFlowTeam(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTeam>(builder.EndTable());
		}

		// Token: 0x06031003 RID: 200707 RVA: 0x006A577C File Offset: 0x006A397C
		public IFlowTeamT UnPack()
		{
			IFlowTeamT flowTeamT = new IFlowTeamT();
			this.UnPackTo(flowTeamT);
			return flowTeamT;
		}

		// Token: 0x06031004 RID: 200708 RVA: 0x006A5797 File Offset: 0x006A3997
		public void UnPackTo(IFlowTeamT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031005 RID: 200709 RVA: 0x006A57A8 File Offset: 0x006A39A8
		public static Offset<IFlowTeam> Pack(FlatBufferBuilder builder, IFlowTeamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowTeam>);
			}
			return IFlowTeam.CreateIFlowTeam(builder, _o.Type);
		}

		// Token: 0x04011D98 RID: 73112
		private Table __p;
	}
}

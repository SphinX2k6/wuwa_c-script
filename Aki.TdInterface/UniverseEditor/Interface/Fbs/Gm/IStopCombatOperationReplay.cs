using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B19 RID: 19225
	public struct IStopCombatOperationReplay : IFlatbufferObject
	{
		// Token: 0x170086C9 RID: 34505
		// (get) Token: 0x0601CFC6 RID: 118726 RVA: 0x00413639 File Offset: 0x00411839
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CFC7 RID: 118727 RVA: 0x00413646 File Offset: 0x00411846
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CFC8 RID: 118728 RVA: 0x00413650 File Offset: 0x00411850
		public static IStopCombatOperationReplay GetRootAsIStopCombatOperationReplay(ByteBuffer _bb)
		{
			return IStopCombatOperationReplay.GetRootAsIStopCombatOperationReplay(_bb, default(IStopCombatOperationReplay));
		}

		// Token: 0x0601CFC9 RID: 118729 RVA: 0x0041366C File Offset: 0x0041186C
		public static IStopCombatOperationReplay GetRootAsIStopCombatOperationReplay(ByteBuffer _bb, IStopCombatOperationReplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CFCA RID: 118730 RVA: 0x00413689 File Offset: 0x00411889
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CFCB RID: 118731 RVA: 0x00413698 File Offset: 0x00411898
		public IStopCombatOperationReplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086CA RID: 34506
		// (get) Token: 0x0601CFCC RID: 118732 RVA: 0x004136A8 File Offset: 0x004118A8
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CFCD RID: 118733 RVA: 0x004136E4 File Offset: 0x004118E4
		public static Offset<IStopCombatOperationReplay> CreateIStopCombatOperationReplay(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IStopCombatOperationReplay.AddType(builder, Type);
			return IStopCombatOperationReplay.EndIStopCombatOperationReplay(builder);
		}

		// Token: 0x0601CFCE RID: 118734 RVA: 0x004136FA File Offset: 0x004118FA
		public static void StartIStopCombatOperationReplay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CFCF RID: 118735 RVA: 0x00413703 File Offset: 0x00411903
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CFD0 RID: 118736 RVA: 0x0041370E File Offset: 0x0041190E
		public static Offset<IStopCombatOperationReplay> EndIStopCombatOperationReplay(FlatBufferBuilder builder)
		{
			return new Offset<IStopCombatOperationReplay>(builder.EndTable());
		}

		// Token: 0x0601CFD1 RID: 118737 RVA: 0x0041371C File Offset: 0x0041191C
		public IStopCombatOperationReplayT UnPack()
		{
			IStopCombatOperationReplayT stopCombatOperationReplayT = new IStopCombatOperationReplayT();
			this.UnPackTo(stopCombatOperationReplayT);
			return stopCombatOperationReplayT;
		}

		// Token: 0x0601CFD2 RID: 118738 RVA: 0x00413737 File Offset: 0x00411937
		public void UnPackTo(IStopCombatOperationReplayT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CFD3 RID: 118739 RVA: 0x00413748 File Offset: 0x00411948
		public static Offset<IStopCombatOperationReplay> Pack(FlatBufferBuilder builder, IStopCombatOperationReplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopCombatOperationReplay>);
			}
			return IStopCombatOperationReplay.CreateIStopCombatOperationReplay(builder, _o.Type);
		}

		// Token: 0x0400D2AA RID: 53930
		private Table __p;
	}
}

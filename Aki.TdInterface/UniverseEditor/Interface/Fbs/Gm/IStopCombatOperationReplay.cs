using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046B1 RID: 18097
	public struct IStopCombatOperationReplay : IFlatbufferObject
	{
		// Token: 0x17008088 RID: 32904
		// (get) Token: 0x0601B7F1 RID: 112625 RVA: 0x003E739D File Offset: 0x003E559D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B7F2 RID: 112626 RVA: 0x003E73AA File Offset: 0x003E55AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B7F3 RID: 112627 RVA: 0x003E73B4 File Offset: 0x003E55B4
		public static IStopCombatOperationReplay GetRootAsIStopCombatOperationReplay(ByteBuffer _bb)
		{
			return IStopCombatOperationReplay.GetRootAsIStopCombatOperationReplay(_bb, default(IStopCombatOperationReplay));
		}

		// Token: 0x0601B7F4 RID: 112628 RVA: 0x003E73D0 File Offset: 0x003E55D0
		public static IStopCombatOperationReplay GetRootAsIStopCombatOperationReplay(ByteBuffer _bb, IStopCombatOperationReplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B7F5 RID: 112629 RVA: 0x003E73ED File Offset: 0x003E55ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B7F6 RID: 112630 RVA: 0x003E73FC File Offset: 0x003E55FC
		public IStopCombatOperationReplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008089 RID: 32905
		// (get) Token: 0x0601B7F7 RID: 112631 RVA: 0x003E740C File Offset: 0x003E560C
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

		// Token: 0x0601B7F8 RID: 112632 RVA: 0x003E7448 File Offset: 0x003E5648
		public static Offset<IStopCombatOperationReplay> CreateIStopCombatOperationReplay(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IStopCombatOperationReplay.AddType(builder, Type);
			return IStopCombatOperationReplay.EndIStopCombatOperationReplay(builder);
		}

		// Token: 0x0601B7F9 RID: 112633 RVA: 0x003E745E File Offset: 0x003E565E
		public static void StartIStopCombatOperationReplay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B7FA RID: 112634 RVA: 0x003E7467 File Offset: 0x003E5667
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B7FB RID: 112635 RVA: 0x003E7472 File Offset: 0x003E5672
		public static Offset<IStopCombatOperationReplay> EndIStopCombatOperationReplay(FlatBufferBuilder builder)
		{
			return new Offset<IStopCombatOperationReplay>(builder.EndTable());
		}

		// Token: 0x0601B7FC RID: 112636 RVA: 0x003E7480 File Offset: 0x003E5680
		public IStopCombatOperationReplayT UnPack()
		{
			IStopCombatOperationReplayT stopCombatOperationReplayT = new IStopCombatOperationReplayT();
			this.UnPackTo(stopCombatOperationReplayT);
			return stopCombatOperationReplayT;
		}

		// Token: 0x0601B7FD RID: 112637 RVA: 0x003E749B File Offset: 0x003E569B
		public void UnPackTo(IStopCombatOperationReplayT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B7FE RID: 112638 RVA: 0x003E74AC File Offset: 0x003E56AC
		public static Offset<IStopCombatOperationReplay> Pack(FlatBufferBuilder builder, IStopCombatOperationReplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopCombatOperationReplay>);
			}
			return IStopCombatOperationReplay.CreateIStopCombatOperationReplay(builder, _o.Type);
		}

		// Token: 0x0400C87B RID: 51323
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B1F RID: 23327
	public struct IMonsterNpcInteractionConfig : IFlatbufferObject
	{
		// Token: 0x1700AA4E RID: 43598
		// (get) Token: 0x060265D2 RID: 157138 RVA: 0x005416FF File Offset: 0x0053F8FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060265D3 RID: 157139 RVA: 0x0054170C File Offset: 0x0053F90C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060265D4 RID: 157140 RVA: 0x00541714 File Offset: 0x0053F914
		public static IMonsterNpcInteractionConfig GetRootAsIMonsterNpcInteractionConfig(ByteBuffer _bb)
		{
			return IMonsterNpcInteractionConfig.GetRootAsIMonsterNpcInteractionConfig(_bb, default(IMonsterNpcInteractionConfig));
		}

		// Token: 0x060265D5 RID: 157141 RVA: 0x00541730 File Offset: 0x0053F930
		public static IMonsterNpcInteractionConfig GetRootAsIMonsterNpcInteractionConfig(ByteBuffer _bb, IMonsterNpcInteractionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060265D6 RID: 157142 RVA: 0x0054174D File Offset: 0x0053F94D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060265D7 RID: 157143 RVA: 0x0054175C File Offset: 0x0053F95C
		public IMonsterNpcInteractionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA4F RID: 43599
		// (get) Token: 0x060265D8 RID: 157144 RVA: 0x0054176C File Offset: 0x0053F96C
		public EMonsterNpcInteractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterNpcInteractionType.WallRun;
				}
				return (EMonsterNpcInteractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060265D9 RID: 157145 RVA: 0x005417A8 File Offset: 0x0053F9A8
		public static Offset<IMonsterNpcInteractionConfig> CreateIMonsterNpcInteractionConfig(FlatBufferBuilder builder, EMonsterNpcInteractionType Type = EMonsterNpcInteractionType.WallRun)
		{
			builder.StartTable(1);
			IMonsterNpcInteractionConfig.AddType(builder, Type);
			return IMonsterNpcInteractionConfig.EndIMonsterNpcInteractionConfig(builder);
		}

		// Token: 0x060265DA RID: 157146 RVA: 0x005417BE File Offset: 0x0053F9BE
		public static void StartIMonsterNpcInteractionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060265DB RID: 157147 RVA: 0x005417C7 File Offset: 0x0053F9C7
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060265DC RID: 157148 RVA: 0x005417D2 File Offset: 0x0053F9D2
		public static Offset<IMonsterNpcInteractionConfig> EndIMonsterNpcInteractionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractionConfig>(builder.EndTable());
		}

		// Token: 0x060265DD RID: 157149 RVA: 0x005417E0 File Offset: 0x0053F9E0
		public IMonsterNpcInteractionConfigT UnPack()
		{
			IMonsterNpcInteractionConfigT monsterNpcInteractionConfigT = new IMonsterNpcInteractionConfigT();
			this.UnPackTo(monsterNpcInteractionConfigT);
			return monsterNpcInteractionConfigT;
		}

		// Token: 0x060265DE RID: 157150 RVA: 0x005417FB File Offset: 0x0053F9FB
		public void UnPackTo(IMonsterNpcInteractionConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060265DF RID: 157151 RVA: 0x0054180C File Offset: 0x0053FA0C
		public static Offset<IMonsterNpcInteractionConfig> Pack(FlatBufferBuilder builder, IMonsterNpcInteractionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractionConfig>);
			}
			return IMonsterNpcInteractionConfig.CreateIMonsterNpcInteractionConfig(builder, _o.Type);
		}

		// Token: 0x0400F512 RID: 62738
		private Table __p;
	}
}

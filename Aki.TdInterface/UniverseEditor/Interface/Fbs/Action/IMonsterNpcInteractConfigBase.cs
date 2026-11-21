using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007219 RID: 29209
	public struct IMonsterNpcInteractConfigBase : IFlatbufferObject
	{
		// Token: 0x1700D5CE RID: 54734
		// (get) Token: 0x06032D34 RID: 208180 RVA: 0x006DD087 File Offset: 0x006DB287
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032D35 RID: 208181 RVA: 0x006DD094 File Offset: 0x006DB294
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032D36 RID: 208182 RVA: 0x006DD09C File Offset: 0x006DB29C
		public static IMonsterNpcInteractConfigBase GetRootAsIMonsterNpcInteractConfigBase(ByteBuffer _bb)
		{
			return IMonsterNpcInteractConfigBase.GetRootAsIMonsterNpcInteractConfigBase(_bb, default(IMonsterNpcInteractConfigBase));
		}

		// Token: 0x06032D37 RID: 208183 RVA: 0x006DD0B8 File Offset: 0x006DB2B8
		public static IMonsterNpcInteractConfigBase GetRootAsIMonsterNpcInteractConfigBase(ByteBuffer _bb, IMonsterNpcInteractConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032D38 RID: 208184 RVA: 0x006DD0D5 File Offset: 0x006DB2D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032D39 RID: 208185 RVA: 0x006DD0E4 File Offset: 0x006DB2E4
		public IMonsterNpcInteractConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5CF RID: 54735
		// (get) Token: 0x06032D3A RID: 208186 RVA: 0x006DD0F4 File Offset: 0x006DB2F4
		public EMonsterNpcInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterNpcInteractType.TriggerHook;
				}
				return (EMonsterNpcInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032D3B RID: 208187 RVA: 0x006DD130 File Offset: 0x006DB330
		public static Offset<IMonsterNpcInteractConfigBase> CreateIMonsterNpcInteractConfigBase(FlatBufferBuilder builder, EMonsterNpcInteractType Type = EMonsterNpcInteractType.TriggerHook)
		{
			builder.StartTable(1);
			IMonsterNpcInteractConfigBase.AddType(builder, Type);
			return IMonsterNpcInteractConfigBase.EndIMonsterNpcInteractConfigBase(builder);
		}

		// Token: 0x06032D3C RID: 208188 RVA: 0x006DD146 File Offset: 0x006DB346
		public static void StartIMonsterNpcInteractConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032D3D RID: 208189 RVA: 0x006DD14F File Offset: 0x006DB34F
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032D3E RID: 208190 RVA: 0x006DD15A File Offset: 0x006DB35A
		public static Offset<IMonsterNpcInteractConfigBase> EndIMonsterNpcInteractConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractConfigBase>(builder.EndTable());
		}

		// Token: 0x06032D3F RID: 208191 RVA: 0x006DD168 File Offset: 0x006DB368
		public IMonsterNpcInteractConfigBaseT UnPack()
		{
			IMonsterNpcInteractConfigBaseT monsterNpcInteractConfigBaseT = new IMonsterNpcInteractConfigBaseT();
			this.UnPackTo(monsterNpcInteractConfigBaseT);
			return monsterNpcInteractConfigBaseT;
		}

		// Token: 0x06032D40 RID: 208192 RVA: 0x006DD183 File Offset: 0x006DB383
		public void UnPackTo(IMonsterNpcInteractConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032D41 RID: 208193 RVA: 0x006DD194 File Offset: 0x006DB394
		public static Offset<IMonsterNpcInteractConfigBase> Pack(FlatBufferBuilder builder, IMonsterNpcInteractConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractConfigBase>);
			}
			return IMonsterNpcInteractConfigBase.CreateIMonsterNpcInteractConfigBase(builder, _o.Type);
		}

		// Token: 0x04012245 RID: 74309
		private Table __p;
	}
}

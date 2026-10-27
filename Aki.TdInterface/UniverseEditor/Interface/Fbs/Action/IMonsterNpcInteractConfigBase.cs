using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE2 RID: 27362
	public struct IMonsterNpcInteractConfigBase : IFlatbufferObject
	{
		// Token: 0x1700CAFF RID: 51967
		// (get) Token: 0x0602FF60 RID: 196448 RVA: 0x006859CF File Offset: 0x00683BCF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FF61 RID: 196449 RVA: 0x006859DC File Offset: 0x00683BDC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FF62 RID: 196450 RVA: 0x006859E4 File Offset: 0x00683BE4
		public static IMonsterNpcInteractConfigBase GetRootAsIMonsterNpcInteractConfigBase(ByteBuffer _bb)
		{
			return IMonsterNpcInteractConfigBase.GetRootAsIMonsterNpcInteractConfigBase(_bb, default(IMonsterNpcInteractConfigBase));
		}

		// Token: 0x0602FF63 RID: 196451 RVA: 0x00685A00 File Offset: 0x00683C00
		public static IMonsterNpcInteractConfigBase GetRootAsIMonsterNpcInteractConfigBase(ByteBuffer _bb, IMonsterNpcInteractConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FF64 RID: 196452 RVA: 0x00685A1D File Offset: 0x00683C1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FF65 RID: 196453 RVA: 0x00685A2C File Offset: 0x00683C2C
		public IMonsterNpcInteractConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB00 RID: 51968
		// (get) Token: 0x0602FF66 RID: 196454 RVA: 0x00685A3C File Offset: 0x00683C3C
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

		// Token: 0x0602FF67 RID: 196455 RVA: 0x00685A78 File Offset: 0x00683C78
		public static Offset<IMonsterNpcInteractConfigBase> CreateIMonsterNpcInteractConfigBase(FlatBufferBuilder builder, EMonsterNpcInteractType Type = EMonsterNpcInteractType.TriggerHook)
		{
			builder.StartTable(1);
			IMonsterNpcInteractConfigBase.AddType(builder, Type);
			return IMonsterNpcInteractConfigBase.EndIMonsterNpcInteractConfigBase(builder);
		}

		// Token: 0x0602FF68 RID: 196456 RVA: 0x00685A8E File Offset: 0x00683C8E
		public static void StartIMonsterNpcInteractConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FF69 RID: 196457 RVA: 0x00685A97 File Offset: 0x00683C97
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FF6A RID: 196458 RVA: 0x00685AA2 File Offset: 0x00683CA2
		public static Offset<IMonsterNpcInteractConfigBase> EndIMonsterNpcInteractConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractConfigBase>(builder.EndTable());
		}

		// Token: 0x0602FF6B RID: 196459 RVA: 0x00685AB0 File Offset: 0x00683CB0
		public IMonsterNpcInteractConfigBaseT UnPack()
		{
			IMonsterNpcInteractConfigBaseT monsterNpcInteractConfigBaseT = new IMonsterNpcInteractConfigBaseT();
			this.UnPackTo(monsterNpcInteractConfigBaseT);
			return monsterNpcInteractConfigBaseT;
		}

		// Token: 0x0602FF6C RID: 196460 RVA: 0x00685ACB File Offset: 0x00683CCB
		public void UnPackTo(IMonsterNpcInteractConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FF6D RID: 196461 RVA: 0x00685ADC File Offset: 0x00683CDC
		public static Offset<IMonsterNpcInteractConfigBase> Pack(FlatBufferBuilder builder, IMonsterNpcInteractConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractConfigBase>);
			}
			return IMonsterNpcInteractConfigBase.CreateIMonsterNpcInteractConfigBase(builder, _o.Type);
		}

		// Token: 0x04011332 RID: 70450
		private Table __p;
	}
}

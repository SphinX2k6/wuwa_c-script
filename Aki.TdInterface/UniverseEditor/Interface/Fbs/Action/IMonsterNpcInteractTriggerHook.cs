using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE8 RID: 27368
	public struct IMonsterNpcInteractTriggerHook : IFlatbufferObject
	{
		// Token: 0x1700CB04 RID: 51972
		// (get) Token: 0x0602FF7E RID: 196478 RVA: 0x00685C42 File Offset: 0x00683E42
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FF7F RID: 196479 RVA: 0x00685C4F File Offset: 0x00683E4F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FF80 RID: 196480 RVA: 0x00685C58 File Offset: 0x00683E58
		public static IMonsterNpcInteractTriggerHook GetRootAsIMonsterNpcInteractTriggerHook(ByteBuffer _bb)
		{
			return IMonsterNpcInteractTriggerHook.GetRootAsIMonsterNpcInteractTriggerHook(_bb, default(IMonsterNpcInteractTriggerHook));
		}

		// Token: 0x0602FF81 RID: 196481 RVA: 0x00685C74 File Offset: 0x00683E74
		public static IMonsterNpcInteractTriggerHook GetRootAsIMonsterNpcInteractTriggerHook(ByteBuffer _bb, IMonsterNpcInteractTriggerHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FF82 RID: 196482 RVA: 0x00685C91 File Offset: 0x00683E91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FF83 RID: 196483 RVA: 0x00685CA0 File Offset: 0x00683EA0
		public IMonsterNpcInteractTriggerHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB05 RID: 51973
		// (get) Token: 0x0602FF84 RID: 196484 RVA: 0x00685CB0 File Offset: 0x00683EB0
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

		// Token: 0x1700CB06 RID: 51974
		// (get) Token: 0x0602FF85 RID: 196485 RVA: 0x00685CEC File Offset: 0x00683EEC
		public int HookEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FF86 RID: 196486 RVA: 0x00685D28 File Offset: 0x00683F28
		public static Offset<IMonsterNpcInteractTriggerHook> CreateIMonsterNpcInteractTriggerHook(FlatBufferBuilder builder, EMonsterNpcInteractType Type = EMonsterNpcInteractType.TriggerHook, int HookEntityId = 0)
		{
			builder.StartTable(2);
			IMonsterNpcInteractTriggerHook.AddHookEntityId(builder, HookEntityId);
			IMonsterNpcInteractTriggerHook.AddType(builder, Type);
			return IMonsterNpcInteractTriggerHook.EndIMonsterNpcInteractTriggerHook(builder);
		}

		// Token: 0x0602FF87 RID: 196487 RVA: 0x00685D45 File Offset: 0x00683F45
		public static void StartIMonsterNpcInteractTriggerHook(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FF88 RID: 196488 RVA: 0x00685D4E File Offset: 0x00683F4E
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FF89 RID: 196489 RVA: 0x00685D59 File Offset: 0x00683F59
		public static void AddHookEntityId(FlatBufferBuilder builder, int hookEntityId)
		{
			builder.AddInt(1, hookEntityId, 0);
		}

		// Token: 0x0602FF8A RID: 196490 RVA: 0x00685D64 File Offset: 0x00683F64
		public static Offset<IMonsterNpcInteractTriggerHook> EndIMonsterNpcInteractTriggerHook(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractTriggerHook>(builder.EndTable());
		}

		// Token: 0x0602FF8B RID: 196491 RVA: 0x00685D74 File Offset: 0x00683F74
		public IMonsterNpcInteractTriggerHookT UnPack()
		{
			IMonsterNpcInteractTriggerHookT monsterNpcInteractTriggerHookT = new IMonsterNpcInteractTriggerHookT();
			this.UnPackTo(monsterNpcInteractTriggerHookT);
			return monsterNpcInteractTriggerHookT;
		}

		// Token: 0x0602FF8C RID: 196492 RVA: 0x00685D8F File Offset: 0x00683F8F
		public void UnPackTo(IMonsterNpcInteractTriggerHookT _o)
		{
			_o.Type = this.Type;
			_o.HookEntityId = this.HookEntityId;
		}

		// Token: 0x0602FF8D RID: 196493 RVA: 0x00685DAC File Offset: 0x00683FAC
		public static Offset<IMonsterNpcInteractTriggerHook> Pack(FlatBufferBuilder builder, IMonsterNpcInteractTriggerHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractTriggerHook>);
			}
			return IMonsterNpcInteractTriggerHook.CreateIMonsterNpcInteractTriggerHook(builder, _o.Type, _o.HookEntityId);
		}

		// Token: 0x0401133A RID: 70458
		private Table __p;
	}
}

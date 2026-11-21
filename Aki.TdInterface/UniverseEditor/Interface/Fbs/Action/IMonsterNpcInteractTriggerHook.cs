using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200721F RID: 29215
	public struct IMonsterNpcInteractTriggerHook : IFlatbufferObject
	{
		// Token: 0x1700D5D3 RID: 54739
		// (get) Token: 0x06032D52 RID: 208210 RVA: 0x006DD2FA File Offset: 0x006DB4FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032D53 RID: 208211 RVA: 0x006DD307 File Offset: 0x006DB507
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032D54 RID: 208212 RVA: 0x006DD310 File Offset: 0x006DB510
		public static IMonsterNpcInteractTriggerHook GetRootAsIMonsterNpcInteractTriggerHook(ByteBuffer _bb)
		{
			return IMonsterNpcInteractTriggerHook.GetRootAsIMonsterNpcInteractTriggerHook(_bb, default(IMonsterNpcInteractTriggerHook));
		}

		// Token: 0x06032D55 RID: 208213 RVA: 0x006DD32C File Offset: 0x006DB52C
		public static IMonsterNpcInteractTriggerHook GetRootAsIMonsterNpcInteractTriggerHook(ByteBuffer _bb, IMonsterNpcInteractTriggerHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032D56 RID: 208214 RVA: 0x006DD349 File Offset: 0x006DB549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032D57 RID: 208215 RVA: 0x006DD358 File Offset: 0x006DB558
		public IMonsterNpcInteractTriggerHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5D4 RID: 54740
		// (get) Token: 0x06032D58 RID: 208216 RVA: 0x006DD368 File Offset: 0x006DB568
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

		// Token: 0x1700D5D5 RID: 54741
		// (get) Token: 0x06032D59 RID: 208217 RVA: 0x006DD3A4 File Offset: 0x006DB5A4
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

		// Token: 0x06032D5A RID: 208218 RVA: 0x006DD3E0 File Offset: 0x006DB5E0
		public static Offset<IMonsterNpcInteractTriggerHook> CreateIMonsterNpcInteractTriggerHook(FlatBufferBuilder builder, EMonsterNpcInteractType Type = EMonsterNpcInteractType.TriggerHook, int HookEntityId = 0)
		{
			builder.StartTable(2);
			IMonsterNpcInteractTriggerHook.AddHookEntityId(builder, HookEntityId);
			IMonsterNpcInteractTriggerHook.AddType(builder, Type);
			return IMonsterNpcInteractTriggerHook.EndIMonsterNpcInteractTriggerHook(builder);
		}

		// Token: 0x06032D5B RID: 208219 RVA: 0x006DD3FD File Offset: 0x006DB5FD
		public static void StartIMonsterNpcInteractTriggerHook(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032D5C RID: 208220 RVA: 0x006DD406 File Offset: 0x006DB606
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032D5D RID: 208221 RVA: 0x006DD411 File Offset: 0x006DB611
		public static void AddHookEntityId(FlatBufferBuilder builder, int hookEntityId)
		{
			builder.AddInt(1, hookEntityId, 0);
		}

		// Token: 0x06032D5E RID: 208222 RVA: 0x006DD41C File Offset: 0x006DB61C
		public static Offset<IMonsterNpcInteractTriggerHook> EndIMonsterNpcInteractTriggerHook(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractTriggerHook>(builder.EndTable());
		}

		// Token: 0x06032D5F RID: 208223 RVA: 0x006DD42C File Offset: 0x006DB62C
		public IMonsterNpcInteractTriggerHookT UnPack()
		{
			IMonsterNpcInteractTriggerHookT monsterNpcInteractTriggerHookT = new IMonsterNpcInteractTriggerHookT();
			this.UnPackTo(monsterNpcInteractTriggerHookT);
			return monsterNpcInteractTriggerHookT;
		}

		// Token: 0x06032D60 RID: 208224 RVA: 0x006DD447 File Offset: 0x006DB647
		public void UnPackTo(IMonsterNpcInteractTriggerHookT _o)
		{
			_o.Type = this.Type;
			_o.HookEntityId = this.HookEntityId;
		}

		// Token: 0x06032D61 RID: 208225 RVA: 0x006DD464 File Offset: 0x006DB664
		public static Offset<IMonsterNpcInteractTriggerHook> Pack(FlatBufferBuilder builder, IMonsterNpcInteractTriggerHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractTriggerHook>);
			}
			return IMonsterNpcInteractTriggerHook.CreateIMonsterNpcInteractTriggerHook(builder, _o.Type, _o.HookEntityId);
		}

		// Token: 0x0401224D RID: 74317
		private Table __p;
	}
}

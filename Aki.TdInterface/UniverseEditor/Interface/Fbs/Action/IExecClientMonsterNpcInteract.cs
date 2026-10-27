using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200670E RID: 26382
	public struct IExecClientMonsterNpcInteract : IFlatbufferObject
	{
		// Token: 0x1700C3FB RID: 50171
		// (get) Token: 0x0602DE2D RID: 187949 RVA: 0x0064653C File Offset: 0x0064473C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DE2E RID: 187950 RVA: 0x00646549 File Offset: 0x00644749
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DE2F RID: 187951 RVA: 0x00646550 File Offset: 0x00644750
		public static IExecClientMonsterNpcInteract GetRootAsIExecClientMonsterNpcInteract(ByteBuffer _bb)
		{
			return IExecClientMonsterNpcInteract.GetRootAsIExecClientMonsterNpcInteract(_bb, default(IExecClientMonsterNpcInteract));
		}

		// Token: 0x0602DE30 RID: 187952 RVA: 0x0064656C File Offset: 0x0064476C
		public static IExecClientMonsterNpcInteract GetRootAsIExecClientMonsterNpcInteract(ByteBuffer _bb, IExecClientMonsterNpcInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DE31 RID: 187953 RVA: 0x00646589 File Offset: 0x00644789
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DE32 RID: 187954 RVA: 0x00646598 File Offset: 0x00644798
		public IExecClientMonsterNpcInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3FC RID: 50172
		// (get) Token: 0x0602DE33 RID: 187955 RVA: 0x006465A8 File Offset: 0x006447A8
		public int MonsterNpcEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C3FD RID: 50173
		// (get) Token: 0x0602DE34 RID: 187956 RVA: 0x006465E4 File Offset: 0x006447E4
		public IMonsterNpcInteractTriggerHook? Config
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMonsterNpcInteractTriggerHook?(default(IMonsterNpcInteractTriggerHook).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602DE35 RID: 187957 RVA: 0x00646641 File Offset: 0x00644841
		public static Offset<IExecClientMonsterNpcInteract> CreateIExecClientMonsterNpcInteract(FlatBufferBuilder builder, int MonsterNpcEntityId = 0, Offset<IMonsterNpcInteractTriggerHook> ConfigOffset = default(Offset<IMonsterNpcInteractTriggerHook>))
		{
			builder.StartTable(2);
			IExecClientMonsterNpcInteract.AddConfig(builder, ConfigOffset);
			IExecClientMonsterNpcInteract.AddMonsterNpcEntityId(builder, MonsterNpcEntityId);
			return IExecClientMonsterNpcInteract.EndIExecClientMonsterNpcInteract(builder);
		}

		// Token: 0x0602DE36 RID: 187958 RVA: 0x0064665E File Offset: 0x0064485E
		public static void StartIExecClientMonsterNpcInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DE37 RID: 187959 RVA: 0x00646667 File Offset: 0x00644867
		public static void AddMonsterNpcEntityId(FlatBufferBuilder builder, int monsterNpcEntityId)
		{
			builder.AddInt(0, monsterNpcEntityId, 0);
		}

		// Token: 0x0602DE38 RID: 187960 RVA: 0x00646672 File Offset: 0x00644872
		public static void AddConfig(FlatBufferBuilder builder, Offset<IMonsterNpcInteractTriggerHook> configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x0602DE39 RID: 187961 RVA: 0x00646682 File Offset: 0x00644882
		public static Offset<IExecClientMonsterNpcInteract> EndIExecClientMonsterNpcInteract(FlatBufferBuilder builder)
		{
			return new Offset<IExecClientMonsterNpcInteract>(builder.EndTable());
		}

		// Token: 0x0602DE3A RID: 187962 RVA: 0x00646690 File Offset: 0x00644890
		public IExecClientMonsterNpcInteractT UnPack()
		{
			IExecClientMonsterNpcInteractT execClientMonsterNpcInteractT = new IExecClientMonsterNpcInteractT();
			this.UnPackTo(execClientMonsterNpcInteractT);
			return execClientMonsterNpcInteractT;
		}

		// Token: 0x0602DE3B RID: 187963 RVA: 0x006466AC File Offset: 0x006448AC
		public void UnPackTo(IExecClientMonsterNpcInteractT _o)
		{
			_o.MonsterNpcEntityId = this.MonsterNpcEntityId;
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x0602DE3C RID: 187964 RVA: 0x006466F4 File Offset: 0x006448F4
		public static Offset<IExecClientMonsterNpcInteract> Pack(FlatBufferBuilder builder, IExecClientMonsterNpcInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecClientMonsterNpcInteract>);
			}
			Offset<IMonsterNpcInteractTriggerHook> configOffset = (_o.Config == null) ? default(Offset<IMonsterNpcInteractTriggerHook>) : IMonsterNpcInteractTriggerHook.Pack(builder, _o.Config);
			return IExecClientMonsterNpcInteract.CreateIExecClientMonsterNpcInteract(builder, _o.MonsterNpcEntityId, configOffset);
		}

		// Token: 0x04010DF5 RID: 69109
		private Table __p;
	}
}

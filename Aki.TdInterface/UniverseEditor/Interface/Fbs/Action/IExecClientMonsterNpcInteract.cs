using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D8E RID: 28046
	public struct IExecClientMonsterNpcInteract : IFlatbufferObject
	{
		// Token: 0x1700CDB1 RID: 52657
		// (get) Token: 0x06030673 RID: 198259 RVA: 0x00693C7E File Offset: 0x00691E7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030674 RID: 198260 RVA: 0x00693C8B File Offset: 0x00691E8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030675 RID: 198261 RVA: 0x00693C94 File Offset: 0x00691E94
		public static IExecClientMonsterNpcInteract GetRootAsIExecClientMonsterNpcInteract(ByteBuffer _bb)
		{
			return IExecClientMonsterNpcInteract.GetRootAsIExecClientMonsterNpcInteract(_bb, default(IExecClientMonsterNpcInteract));
		}

		// Token: 0x06030676 RID: 198262 RVA: 0x00693CB0 File Offset: 0x00691EB0
		public static IExecClientMonsterNpcInteract GetRootAsIExecClientMonsterNpcInteract(ByteBuffer _bb, IExecClientMonsterNpcInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030677 RID: 198263 RVA: 0x00693CCD File Offset: 0x00691ECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030678 RID: 198264 RVA: 0x00693CDC File Offset: 0x00691EDC
		public IExecClientMonsterNpcInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDB2 RID: 52658
		// (get) Token: 0x06030679 RID: 198265 RVA: 0x00693CEC File Offset: 0x00691EEC
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

		// Token: 0x1700CDB3 RID: 52659
		// (get) Token: 0x0603067A RID: 198266 RVA: 0x00693D28 File Offset: 0x00691F28
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

		// Token: 0x0603067B RID: 198267 RVA: 0x00693D85 File Offset: 0x00691F85
		public static Offset<IExecClientMonsterNpcInteract> CreateIExecClientMonsterNpcInteract(FlatBufferBuilder builder, int MonsterNpcEntityId = 0, Offset<IMonsterNpcInteractTriggerHook> ConfigOffset = default(Offset<IMonsterNpcInteractTriggerHook>))
		{
			builder.StartTable(2);
			IExecClientMonsterNpcInteract.AddConfig(builder, ConfigOffset);
			IExecClientMonsterNpcInteract.AddMonsterNpcEntityId(builder, MonsterNpcEntityId);
			return IExecClientMonsterNpcInteract.EndIExecClientMonsterNpcInteract(builder);
		}

		// Token: 0x0603067C RID: 198268 RVA: 0x00693DA2 File Offset: 0x00691FA2
		public static void StartIExecClientMonsterNpcInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603067D RID: 198269 RVA: 0x00693DAB File Offset: 0x00691FAB
		public static void AddMonsterNpcEntityId(FlatBufferBuilder builder, int monsterNpcEntityId)
		{
			builder.AddInt(0, monsterNpcEntityId, 0);
		}

		// Token: 0x0603067E RID: 198270 RVA: 0x00693DB6 File Offset: 0x00691FB6
		public static void AddConfig(FlatBufferBuilder builder, Offset<IMonsterNpcInteractTriggerHook> configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x0603067F RID: 198271 RVA: 0x00693DC6 File Offset: 0x00691FC6
		public static Offset<IExecClientMonsterNpcInteract> EndIExecClientMonsterNpcInteract(FlatBufferBuilder builder)
		{
			return new Offset<IExecClientMonsterNpcInteract>(builder.EndTable());
		}

		// Token: 0x06030680 RID: 198272 RVA: 0x00693DD4 File Offset: 0x00691FD4
		public IExecClientMonsterNpcInteractT UnPack()
		{
			IExecClientMonsterNpcInteractT execClientMonsterNpcInteractT = new IExecClientMonsterNpcInteractT();
			this.UnPackTo(execClientMonsterNpcInteractT);
			return execClientMonsterNpcInteractT;
		}

		// Token: 0x06030681 RID: 198273 RVA: 0x00693DF0 File Offset: 0x00691FF0
		public void UnPackTo(IExecClientMonsterNpcInteractT _o)
		{
			_o.MonsterNpcEntityId = this.MonsterNpcEntityId;
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x06030682 RID: 198274 RVA: 0x00693E38 File Offset: 0x00692038
		public static Offset<IExecClientMonsterNpcInteract> Pack(FlatBufferBuilder builder, IExecClientMonsterNpcInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecClientMonsterNpcInteract>);
			}
			Offset<IMonsterNpcInteractTriggerHook> configOffset = (_o.Config == null) ? default(Offset<IMonsterNpcInteractTriggerHook>) : IMonsterNpcInteractTriggerHook.Pack(builder, _o.Config);
			return IExecClientMonsterNpcInteract.CreateIExecClientMonsterNpcInteract(builder, _o.MonsterNpcEntityId, configOffset);
		}

		// Token: 0x04011C27 RID: 72743
		private Table __p;
	}
}

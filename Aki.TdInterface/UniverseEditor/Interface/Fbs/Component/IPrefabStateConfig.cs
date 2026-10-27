using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200577E RID: 22398
	public struct IPrefabStateConfig : IFlatbufferObject
	{
		// Token: 0x1700A711 RID: 42769
		// (get) Token: 0x060258B9 RID: 153785 RVA: 0x0052DF0E File Offset: 0x0052C10E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060258BA RID: 153786 RVA: 0x0052DF1B File Offset: 0x0052C11B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060258BB RID: 153787 RVA: 0x0052DF24 File Offset: 0x0052C124
		public static IPrefabStateConfig GetRootAsIPrefabStateConfig(ByteBuffer _bb)
		{
			return IPrefabStateConfig.GetRootAsIPrefabStateConfig(_bb, default(IPrefabStateConfig));
		}

		// Token: 0x060258BC RID: 153788 RVA: 0x0052DF40 File Offset: 0x0052C140
		public static IPrefabStateConfig GetRootAsIPrefabStateConfig(ByteBuffer _bb, IPrefabStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060258BD RID: 153789 RVA: 0x0052DF5D File Offset: 0x0052C15D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060258BE RID: 153790 RVA: 0x0052DF6C File Offset: 0x0052C16C
		public IPrefabStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A712 RID: 42770
		// (get) Token: 0x060258BF RID: 153791 RVA: 0x0052DF7C File Offset: 0x0052C17C
		public int LevelTag
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

		// Token: 0x1700A713 RID: 42771
		// (get) Token: 0x060258C0 RID: 153792 RVA: 0x0052DFB8 File Offset: 0x0052C1B8
		public ESceneInteractionState SceneInteractionState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ESceneInteractionState.State1;
				}
				return (ESceneInteractionState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060258C1 RID: 153793 RVA: 0x0052DFF4 File Offset: 0x0052C1F4
		public static Offset<IPrefabStateConfig> CreateIPrefabStateConfig(FlatBufferBuilder builder, int LevelTag = 0, ESceneInteractionState SceneInteractionState = ESceneInteractionState.State1)
		{
			builder.StartTable(2);
			IPrefabStateConfig.AddLevelTag(builder, LevelTag);
			IPrefabStateConfig.AddSceneInteractionState(builder, SceneInteractionState);
			return IPrefabStateConfig.EndIPrefabStateConfig(builder);
		}

		// Token: 0x060258C2 RID: 153794 RVA: 0x0052E011 File Offset: 0x0052C211
		public static void StartIPrefabStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060258C3 RID: 153795 RVA: 0x0052E01A File Offset: 0x0052C21A
		public static void AddLevelTag(FlatBufferBuilder builder, int levelTag)
		{
			builder.AddInt(0, levelTag, 0);
		}

		// Token: 0x060258C4 RID: 153796 RVA: 0x0052E025 File Offset: 0x0052C225
		public static void AddSceneInteractionState(FlatBufferBuilder builder, ESceneInteractionState sceneInteractionState)
		{
			builder.AddByte(1, (byte)sceneInteractionState, 0);
		}

		// Token: 0x060258C5 RID: 153797 RVA: 0x0052E030 File Offset: 0x0052C230
		public static Offset<IPrefabStateConfig> EndIPrefabStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPrefabStateConfig>(builder.EndTable());
		}

		// Token: 0x060258C6 RID: 153798 RVA: 0x0052E040 File Offset: 0x0052C240
		public IPrefabStateConfigT UnPack()
		{
			IPrefabStateConfigT prefabStateConfigT = new IPrefabStateConfigT();
			this.UnPackTo(prefabStateConfigT);
			return prefabStateConfigT;
		}

		// Token: 0x060258C7 RID: 153799 RVA: 0x0052E05B File Offset: 0x0052C25B
		public void UnPackTo(IPrefabStateConfigT _o)
		{
			_o.LevelTag = this.LevelTag;
			_o.SceneInteractionState = this.SceneInteractionState;
		}

		// Token: 0x060258C8 RID: 153800 RVA: 0x0052E078 File Offset: 0x0052C278
		public static Offset<IPrefabStateConfig> Pack(FlatBufferBuilder builder, IPrefabStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPrefabStateConfig>);
			}
			return IPrefabStateConfig.CreateIPrefabStateConfig(builder, _o.LevelTag, _o.SceneInteractionState);
		}

		// Token: 0x0400EC2B RID: 60459
		private Table __p;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D85 RID: 23941
	public struct IPrefabStateConfig : IFlatbufferObject
	{
		// Token: 0x1700B035 RID: 45109
		// (get) Token: 0x06027DD9 RID: 163289 RVA: 0x0057409A File Offset: 0x0057229A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027DDA RID: 163290 RVA: 0x005740A7 File Offset: 0x005722A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027DDB RID: 163291 RVA: 0x005740B0 File Offset: 0x005722B0
		public static IPrefabStateConfig GetRootAsIPrefabStateConfig(ByteBuffer _bb)
		{
			return IPrefabStateConfig.GetRootAsIPrefabStateConfig(_bb, default(IPrefabStateConfig));
		}

		// Token: 0x06027DDC RID: 163292 RVA: 0x005740CC File Offset: 0x005722CC
		public static IPrefabStateConfig GetRootAsIPrefabStateConfig(ByteBuffer _bb, IPrefabStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027DDD RID: 163293 RVA: 0x005740E9 File Offset: 0x005722E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027DDE RID: 163294 RVA: 0x005740F8 File Offset: 0x005722F8
		public IPrefabStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B036 RID: 45110
		// (get) Token: 0x06027DDF RID: 163295 RVA: 0x00574108 File Offset: 0x00572308
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

		// Token: 0x1700B037 RID: 45111
		// (get) Token: 0x06027DE0 RID: 163296 RVA: 0x00574144 File Offset: 0x00572344
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

		// Token: 0x06027DE1 RID: 163297 RVA: 0x00574180 File Offset: 0x00572380
		public static Offset<IPrefabStateConfig> CreateIPrefabStateConfig(FlatBufferBuilder builder, int LevelTag = 0, ESceneInteractionState SceneInteractionState = ESceneInteractionState.State1)
		{
			builder.StartTable(2);
			IPrefabStateConfig.AddLevelTag(builder, LevelTag);
			IPrefabStateConfig.AddSceneInteractionState(builder, SceneInteractionState);
			return IPrefabStateConfig.EndIPrefabStateConfig(builder);
		}

		// Token: 0x06027DE2 RID: 163298 RVA: 0x0057419D File Offset: 0x0057239D
		public static void StartIPrefabStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027DE3 RID: 163299 RVA: 0x005741A6 File Offset: 0x005723A6
		public static void AddLevelTag(FlatBufferBuilder builder, int levelTag)
		{
			builder.AddInt(0, levelTag, 0);
		}

		// Token: 0x06027DE4 RID: 163300 RVA: 0x005741B1 File Offset: 0x005723B1
		public static void AddSceneInteractionState(FlatBufferBuilder builder, ESceneInteractionState sceneInteractionState)
		{
			builder.AddByte(1, (byte)sceneInteractionState, 0);
		}

		// Token: 0x06027DE5 RID: 163301 RVA: 0x005741BC File Offset: 0x005723BC
		public static Offset<IPrefabStateConfig> EndIPrefabStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPrefabStateConfig>(builder.EndTable());
		}

		// Token: 0x06027DE6 RID: 163302 RVA: 0x005741CC File Offset: 0x005723CC
		public IPrefabStateConfigT UnPack()
		{
			IPrefabStateConfigT prefabStateConfigT = new IPrefabStateConfigT();
			this.UnPackTo(prefabStateConfigT);
			return prefabStateConfigT;
		}

		// Token: 0x06027DE7 RID: 163303 RVA: 0x005741E7 File Offset: 0x005723E7
		public void UnPackTo(IPrefabStateConfigT _o)
		{
			_o.LevelTag = this.LevelTag;
			_o.SceneInteractionState = this.SceneInteractionState;
		}

		// Token: 0x06027DE8 RID: 163304 RVA: 0x00574204 File Offset: 0x00572404
		public static Offset<IPrefabStateConfig> Pack(FlatBufferBuilder builder, IPrefabStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPrefabStateConfig>);
			}
			return IPrefabStateConfig.CreateIPrefabStateConfig(builder, _o.LevelTag, _o.SceneInteractionState);
		}

		// Token: 0x0400F916 RID: 63766
		private Table __p;
	}
}

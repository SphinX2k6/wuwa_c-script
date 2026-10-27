using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200577B RID: 22395
	public struct IPrefabEffectConfig : IFlatbufferObject
	{
		// Token: 0x1700A70C RID: 42764
		// (get) Token: 0x060258A3 RID: 153763 RVA: 0x0052DD10 File Offset: 0x0052BF10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060258A4 RID: 153764 RVA: 0x0052DD1D File Offset: 0x0052BF1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060258A5 RID: 153765 RVA: 0x0052DD24 File Offset: 0x0052BF24
		public static IPrefabEffectConfig GetRootAsIPrefabEffectConfig(ByteBuffer _bb)
		{
			return IPrefabEffectConfig.GetRootAsIPrefabEffectConfig(_bb, default(IPrefabEffectConfig));
		}

		// Token: 0x060258A6 RID: 153766 RVA: 0x0052DD40 File Offset: 0x0052BF40
		public static IPrefabEffectConfig GetRootAsIPrefabEffectConfig(ByteBuffer _bb, IPrefabEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060258A7 RID: 153767 RVA: 0x0052DD5D File Offset: 0x0052BF5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060258A8 RID: 153768 RVA: 0x0052DD6C File Offset: 0x0052BF6C
		public IPrefabEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A70D RID: 42765
		// (get) Token: 0x060258A9 RID: 153769 RVA: 0x0052DD7C File Offset: 0x0052BF7C
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

		// Token: 0x1700A70E RID: 42766
		// (get) Token: 0x060258AA RID: 153770 RVA: 0x0052DDB8 File Offset: 0x0052BFB8
		public ESceneInteractionEffectState SceneInteractionEffectState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ESceneInteractionEffectState.Effect0;
				}
				return (ESceneInteractionEffectState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060258AB RID: 153771 RVA: 0x0052DDF4 File Offset: 0x0052BFF4
		public static Offset<IPrefabEffectConfig> CreateIPrefabEffectConfig(FlatBufferBuilder builder, int LevelTag = 0, ESceneInteractionEffectState SceneInteractionEffectState = ESceneInteractionEffectState.Effect0)
		{
			builder.StartTable(2);
			IPrefabEffectConfig.AddLevelTag(builder, LevelTag);
			IPrefabEffectConfig.AddSceneInteractionEffectState(builder, SceneInteractionEffectState);
			return IPrefabEffectConfig.EndIPrefabEffectConfig(builder);
		}

		// Token: 0x060258AC RID: 153772 RVA: 0x0052DE11 File Offset: 0x0052C011
		public static void StartIPrefabEffectConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060258AD RID: 153773 RVA: 0x0052DE1A File Offset: 0x0052C01A
		public static void AddLevelTag(FlatBufferBuilder builder, int levelTag)
		{
			builder.AddInt(0, levelTag, 0);
		}

		// Token: 0x060258AE RID: 153774 RVA: 0x0052DE25 File Offset: 0x0052C025
		public static void AddSceneInteractionEffectState(FlatBufferBuilder builder, ESceneInteractionEffectState sceneInteractionEffectState)
		{
			builder.AddByte(1, (byte)sceneInteractionEffectState, 0);
		}

		// Token: 0x060258AF RID: 153775 RVA: 0x0052DE30 File Offset: 0x0052C030
		public static Offset<IPrefabEffectConfig> EndIPrefabEffectConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPrefabEffectConfig>(builder.EndTable());
		}

		// Token: 0x060258B0 RID: 153776 RVA: 0x0052DE40 File Offset: 0x0052C040
		public IPrefabEffectConfigT UnPack()
		{
			IPrefabEffectConfigT prefabEffectConfigT = new IPrefabEffectConfigT();
			this.UnPackTo(prefabEffectConfigT);
			return prefabEffectConfigT;
		}

		// Token: 0x060258B1 RID: 153777 RVA: 0x0052DE5B File Offset: 0x0052C05B
		public void UnPackTo(IPrefabEffectConfigT _o)
		{
			_o.LevelTag = this.LevelTag;
			_o.SceneInteractionEffectState = this.SceneInteractionEffectState;
		}

		// Token: 0x060258B2 RID: 153778 RVA: 0x0052DE78 File Offset: 0x0052C078
		public static Offset<IPrefabEffectConfig> Pack(FlatBufferBuilder builder, IPrefabEffectConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPrefabEffectConfig>);
			}
			return IPrefabEffectConfig.CreateIPrefabEffectConfig(builder, _o.LevelTag, _o.SceneInteractionEffectState);
		}

		// Token: 0x0400EC28 RID: 60456
		private Table __p;
	}
}

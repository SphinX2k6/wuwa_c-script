using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D82 RID: 23938
	public struct IPrefabEffectConfig : IFlatbufferObject
	{
		// Token: 0x1700B030 RID: 45104
		// (get) Token: 0x06027DC3 RID: 163267 RVA: 0x00573E9C File Offset: 0x0057209C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027DC4 RID: 163268 RVA: 0x00573EA9 File Offset: 0x005720A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027DC5 RID: 163269 RVA: 0x00573EB0 File Offset: 0x005720B0
		public static IPrefabEffectConfig GetRootAsIPrefabEffectConfig(ByteBuffer _bb)
		{
			return IPrefabEffectConfig.GetRootAsIPrefabEffectConfig(_bb, default(IPrefabEffectConfig));
		}

		// Token: 0x06027DC6 RID: 163270 RVA: 0x00573ECC File Offset: 0x005720CC
		public static IPrefabEffectConfig GetRootAsIPrefabEffectConfig(ByteBuffer _bb, IPrefabEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027DC7 RID: 163271 RVA: 0x00573EE9 File Offset: 0x005720E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027DC8 RID: 163272 RVA: 0x00573EF8 File Offset: 0x005720F8
		public IPrefabEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B031 RID: 45105
		// (get) Token: 0x06027DC9 RID: 163273 RVA: 0x00573F08 File Offset: 0x00572108
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

		// Token: 0x1700B032 RID: 45106
		// (get) Token: 0x06027DCA RID: 163274 RVA: 0x00573F44 File Offset: 0x00572144
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

		// Token: 0x06027DCB RID: 163275 RVA: 0x00573F80 File Offset: 0x00572180
		public static Offset<IPrefabEffectConfig> CreateIPrefabEffectConfig(FlatBufferBuilder builder, int LevelTag = 0, ESceneInteractionEffectState SceneInteractionEffectState = ESceneInteractionEffectState.Effect0)
		{
			builder.StartTable(2);
			IPrefabEffectConfig.AddLevelTag(builder, LevelTag);
			IPrefabEffectConfig.AddSceneInteractionEffectState(builder, SceneInteractionEffectState);
			return IPrefabEffectConfig.EndIPrefabEffectConfig(builder);
		}

		// Token: 0x06027DCC RID: 163276 RVA: 0x00573F9D File Offset: 0x0057219D
		public static void StartIPrefabEffectConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027DCD RID: 163277 RVA: 0x00573FA6 File Offset: 0x005721A6
		public static void AddLevelTag(FlatBufferBuilder builder, int levelTag)
		{
			builder.AddInt(0, levelTag, 0);
		}

		// Token: 0x06027DCE RID: 163278 RVA: 0x00573FB1 File Offset: 0x005721B1
		public static void AddSceneInteractionEffectState(FlatBufferBuilder builder, ESceneInteractionEffectState sceneInteractionEffectState)
		{
			builder.AddByte(1, (byte)sceneInteractionEffectState, 0);
		}

		// Token: 0x06027DCF RID: 163279 RVA: 0x00573FBC File Offset: 0x005721BC
		public static Offset<IPrefabEffectConfig> EndIPrefabEffectConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPrefabEffectConfig>(builder.EndTable());
		}

		// Token: 0x06027DD0 RID: 163280 RVA: 0x00573FCC File Offset: 0x005721CC
		public IPrefabEffectConfigT UnPack()
		{
			IPrefabEffectConfigT prefabEffectConfigT = new IPrefabEffectConfigT();
			this.UnPackTo(prefabEffectConfigT);
			return prefabEffectConfigT;
		}

		// Token: 0x06027DD1 RID: 163281 RVA: 0x00573FE7 File Offset: 0x005721E7
		public void UnPackTo(IPrefabEffectConfigT _o)
		{
			_o.LevelTag = this.LevelTag;
			_o.SceneInteractionEffectState = this.SceneInteractionEffectState;
		}

		// Token: 0x06027DD2 RID: 163282 RVA: 0x00574004 File Offset: 0x00572204
		public static Offset<IPrefabEffectConfig> Pack(FlatBufferBuilder builder, IPrefabEffectConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPrefabEffectConfig>);
			}
			return IPrefabEffectConfig.CreateIPrefabEffectConfig(builder, _o.LevelTag, _o.SceneInteractionEffectState);
		}

		// Token: 0x0400F913 RID: 63763
		private Table __p;
	}
}

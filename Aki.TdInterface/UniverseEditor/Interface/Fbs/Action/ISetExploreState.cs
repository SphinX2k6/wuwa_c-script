using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B5 RID: 30645
	public struct ISetExploreState : IFlatbufferObject
	{
		// Token: 0x1700E097 RID: 57495
		// (get) Token: 0x06035D02 RID: 220418 RVA: 0x00735796 File Offset: 0x00733996
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035D03 RID: 220419 RVA: 0x007357A3 File Offset: 0x007339A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035D04 RID: 220420 RVA: 0x007357AC File Offset: 0x007339AC
		public static ISetExploreState GetRootAsISetExploreState(ByteBuffer _bb)
		{
			return ISetExploreState.GetRootAsISetExploreState(_bb, default(ISetExploreState));
		}

		// Token: 0x06035D05 RID: 220421 RVA: 0x007357C8 File Offset: 0x007339C8
		public static ISetExploreState GetRootAsISetExploreState(ByteBuffer _bb, ISetExploreState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035D06 RID: 220422 RVA: 0x007357E5 File Offset: 0x007339E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035D07 RID: 220423 RVA: 0x007357F4 File Offset: 0x007339F4
		public ISetExploreState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E098 RID: 57496
		// (get) Token: 0x06035D08 RID: 220424 RVA: 0x00735804 File Offset: 0x00733A04
		public ITeleControlConfig? Config
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ITeleControlConfig?(default(ITeleControlConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035D09 RID: 220425 RVA: 0x00735861 File Offset: 0x00733A61
		public static Offset<ISetExploreState> CreateISetExploreState(FlatBufferBuilder builder, Offset<ITeleControlConfig> ConfigOffset = default(Offset<ITeleControlConfig>))
		{
			builder.StartTable(1);
			ISetExploreState.AddConfig(builder, ConfigOffset);
			return ISetExploreState.EndISetExploreState(builder);
		}

		// Token: 0x06035D0A RID: 220426 RVA: 0x00735877 File Offset: 0x00733A77
		public static void StartISetExploreState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035D0B RID: 220427 RVA: 0x00735880 File Offset: 0x00733A80
		public static void AddConfig(FlatBufferBuilder builder, Offset<ITeleControlConfig> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x06035D0C RID: 220428 RVA: 0x00735890 File Offset: 0x00733A90
		public static Offset<ISetExploreState> EndISetExploreState(FlatBufferBuilder builder)
		{
			return new Offset<ISetExploreState>(builder.EndTable());
		}

		// Token: 0x06035D0D RID: 220429 RVA: 0x007358A0 File Offset: 0x00733AA0
		public ISetExploreStateT UnPack()
		{
			ISetExploreStateT setExploreStateT = new ISetExploreStateT();
			this.UnPackTo(setExploreStateT);
			return setExploreStateT;
		}

		// Token: 0x06035D0E RID: 220430 RVA: 0x007358BC File Offset: 0x00733ABC
		public void UnPackTo(ISetExploreStateT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x06035D0F RID: 220431 RVA: 0x007358F8 File Offset: 0x00733AF8
		public static Offset<ISetExploreState> Pack(FlatBufferBuilder builder, ISetExploreStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetExploreState>);
			}
			Offset<ITeleControlConfig> configOffset = (_o.Config == null) ? default(Offset<ITeleControlConfig>) : ITeleControlConfig.Pack(builder, _o.Config);
			return ISetExploreState.CreateISetExploreState(builder, configOffset);
		}

		// Token: 0x040129E6 RID: 76262
		private Table __p;
	}
}

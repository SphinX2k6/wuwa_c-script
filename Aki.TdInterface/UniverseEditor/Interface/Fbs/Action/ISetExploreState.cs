using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FEC RID: 28652
	public struct ISetExploreState : IFlatbufferObject
	{
		// Token: 0x1700D4C3 RID: 54467
		// (get) Token: 0x06032A9C RID: 207516 RVA: 0x006D5B52 File Offset: 0x006D3D52
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032A9D RID: 207517 RVA: 0x006D5B5F File Offset: 0x006D3D5F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032A9E RID: 207518 RVA: 0x006D5B68 File Offset: 0x006D3D68
		public static ISetExploreState GetRootAsISetExploreState(ByteBuffer _bb)
		{
			return ISetExploreState.GetRootAsISetExploreState(_bb, default(ISetExploreState));
		}

		// Token: 0x06032A9F RID: 207519 RVA: 0x006D5B84 File Offset: 0x006D3D84
		public static ISetExploreState GetRootAsISetExploreState(ByteBuffer _bb, ISetExploreState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032AA0 RID: 207520 RVA: 0x006D5BA1 File Offset: 0x006D3DA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032AA1 RID: 207521 RVA: 0x006D5BB0 File Offset: 0x006D3DB0
		public ISetExploreState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4C4 RID: 54468
		// (get) Token: 0x06032AA2 RID: 207522 RVA: 0x006D5BC0 File Offset: 0x006D3DC0
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

		// Token: 0x06032AA3 RID: 207523 RVA: 0x006D5C1D File Offset: 0x006D3E1D
		public static Offset<ISetExploreState> CreateISetExploreState(FlatBufferBuilder builder, Offset<ITeleControlConfig> ConfigOffset = default(Offset<ITeleControlConfig>))
		{
			builder.StartTable(1);
			ISetExploreState.AddConfig(builder, ConfigOffset);
			return ISetExploreState.EndISetExploreState(builder);
		}

		// Token: 0x06032AA4 RID: 207524 RVA: 0x006D5C33 File Offset: 0x006D3E33
		public static void StartISetExploreState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032AA5 RID: 207525 RVA: 0x006D5C3C File Offset: 0x006D3E3C
		public static void AddConfig(FlatBufferBuilder builder, Offset<ITeleControlConfig> configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x06032AA6 RID: 207526 RVA: 0x006D5C4C File Offset: 0x006D3E4C
		public static Offset<ISetExploreState> EndISetExploreState(FlatBufferBuilder builder)
		{
			return new Offset<ISetExploreState>(builder.EndTable());
		}

		// Token: 0x06032AA7 RID: 207527 RVA: 0x006D5C5C File Offset: 0x006D3E5C
		public ISetExploreStateT UnPack()
		{
			ISetExploreStateT setExploreStateT = new ISetExploreStateT();
			this.UnPackTo(setExploreStateT);
			return setExploreStateT;
		}

		// Token: 0x06032AA8 RID: 207528 RVA: 0x006D5C78 File Offset: 0x006D3E78
		public void UnPackTo(ISetExploreStateT _o)
		{
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x06032AA9 RID: 207529 RVA: 0x006D5CB4 File Offset: 0x006D3EB4
		public static Offset<ISetExploreState> Pack(FlatBufferBuilder builder, ISetExploreStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetExploreState>);
			}
			Offset<ITeleControlConfig> configOffset = (_o.Config == null) ? default(Offset<ITeleControlConfig>) : ITeleControlConfig.Pack(builder, _o.Config);
			return ISetExploreState.CreateISetExploreState(builder, configOffset);
		}

		// Token: 0x04011A01 RID: 72193
		private Table __p;
	}
}

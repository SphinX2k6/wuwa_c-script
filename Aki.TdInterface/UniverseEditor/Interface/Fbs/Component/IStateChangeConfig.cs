using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A1 RID: 22945
	public struct IStateChangeConfig : IFlatbufferObject
	{
		// Token: 0x1700AC35 RID: 44085
		// (get) Token: 0x06026DE0 RID: 159200 RVA: 0x005595EF File Offset: 0x005577EF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026DE1 RID: 159201 RVA: 0x005595FC File Offset: 0x005577FC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026DE2 RID: 159202 RVA: 0x00559604 File Offset: 0x00557804
		public static IStateChangeConfig GetRootAsIStateChangeConfig(ByteBuffer _bb)
		{
			return IStateChangeConfig.GetRootAsIStateChangeConfig(_bb, default(IStateChangeConfig));
		}

		// Token: 0x06026DE3 RID: 159203 RVA: 0x00559620 File Offset: 0x00557820
		public static IStateChangeConfig GetRootAsIStateChangeConfig(ByteBuffer _bb, IStateChangeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026DE4 RID: 159204 RVA: 0x0055963D File Offset: 0x0055783D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026DE5 RID: 159205 RVA: 0x0055964C File Offset: 0x0055784C
		public IStateChangeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC36 RID: 44086
		// (get) Token: 0x06026DE6 RID: 159206 RVA: 0x0055965C File Offset: 0x0055785C
		public string RefreshState
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026DE7 RID: 159207 RVA: 0x00559693 File Offset: 0x00557893
		public Span<byte> GetRefreshStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026DE8 RID: 159208 RVA: 0x005596A2 File Offset: 0x005578A2
		public byte[] GetRefreshStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700AC37 RID: 44087
		// (get) Token: 0x06026DE9 RID: 159209 RVA: 0x005596B0 File Offset: 0x005578B0
		public string SubDestroyState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026DEA RID: 159210 RVA: 0x005596E7 File Offset: 0x005578E7
		public Span<byte> GetSubDestroyStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026DEB RID: 159211 RVA: 0x005596F6 File Offset: 0x005578F6
		public byte[] GetSubDestroyStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026DEC RID: 159212 RVA: 0x00559704 File Offset: 0x00557904
		public static Offset<IStateChangeConfig> CreateIStateChangeConfig(FlatBufferBuilder builder, StringOffset RefreshStateOffset = default(StringOffset), StringOffset SubDestroyStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IStateChangeConfig.AddSubDestroyState(builder, SubDestroyStateOffset);
			IStateChangeConfig.AddRefreshState(builder, RefreshStateOffset);
			return IStateChangeConfig.EndIStateChangeConfig(builder);
		}

		// Token: 0x06026DED RID: 159213 RVA: 0x00559721 File Offset: 0x00557921
		public static void StartIStateChangeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026DEE RID: 159214 RVA: 0x0055972A File Offset: 0x0055792A
		public static void AddRefreshState(FlatBufferBuilder builder, StringOffset refreshStateOffset)
		{
			builder.AddOffset(0, refreshStateOffset.Value, 0);
		}

		// Token: 0x06026DEF RID: 159215 RVA: 0x0055973A File Offset: 0x0055793A
		public static void AddSubDestroyState(FlatBufferBuilder builder, StringOffset subDestroyStateOffset)
		{
			builder.AddOffset(1, subDestroyStateOffset.Value, 0);
		}

		// Token: 0x06026DF0 RID: 159216 RVA: 0x0055974A File Offset: 0x0055794A
		public static Offset<IStateChangeConfig> EndIStateChangeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStateChangeConfig>(builder.EndTable());
		}

		// Token: 0x06026DF1 RID: 159217 RVA: 0x00559758 File Offset: 0x00557958
		public IStateChangeConfigT UnPack()
		{
			IStateChangeConfigT stateChangeConfigT = new IStateChangeConfigT();
			this.UnPackTo(stateChangeConfigT);
			return stateChangeConfigT;
		}

		// Token: 0x06026DF2 RID: 159218 RVA: 0x00559773 File Offset: 0x00557973
		public void UnPackTo(IStateChangeConfigT _o)
		{
			_o.RefreshState = this.RefreshState;
			_o.SubDestroyState = this.SubDestroyState;
		}

		// Token: 0x06026DF3 RID: 159219 RVA: 0x00559790 File Offset: 0x00557990
		public static Offset<IStateChangeConfig> Pack(FlatBufferBuilder builder, IStateChangeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateChangeConfig>);
			}
			StringOffset refreshStateOffset = (_o.RefreshState == null) ? default(StringOffset) : builder.CreateString(_o.RefreshState);
			StringOffset subDestroyStateOffset = (_o.SubDestroyState == null) ? default(StringOffset) : builder.CreateString(_o.SubDestroyState);
			return IStateChangeConfig.CreateIStateChangeConfig(builder, refreshStateOffset, subDestroyStateOffset);
		}

		// Token: 0x0400EFAF RID: 61359
		private Table __p;
	}
}

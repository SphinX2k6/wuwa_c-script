using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F3 RID: 29171
	public struct IStopUiScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700D89F RID: 55455
		// (get) Token: 0x06033BE0 RID: 211936 RVA: 0x006F725C File Offset: 0x006F545C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033BE1 RID: 211937 RVA: 0x006F7269 File Offset: 0x006F5469
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033BE2 RID: 211938 RVA: 0x006F7270 File Offset: 0x006F5470
		public static IStopUiScreenEffect GetRootAsIStopUiScreenEffect(ByteBuffer _bb)
		{
			return IStopUiScreenEffect.GetRootAsIStopUiScreenEffect(_bb, default(IStopUiScreenEffect));
		}

		// Token: 0x06033BE3 RID: 211939 RVA: 0x006F728C File Offset: 0x006F548C
		public static IStopUiScreenEffect GetRootAsIStopUiScreenEffect(ByteBuffer _bb, IStopUiScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033BE4 RID: 211940 RVA: 0x006F72A9 File Offset: 0x006F54A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033BE5 RID: 211941 RVA: 0x006F72B8 File Offset: 0x006F54B8
		public IStopUiScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8A0 RID: 55456
		// (get) Token: 0x06033BE6 RID: 211942 RVA: 0x006F72C8 File Offset: 0x006F54C8
		public string EffectDaPath
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

		// Token: 0x06033BE7 RID: 211943 RVA: 0x006F72FF File Offset: 0x006F54FF
		public Span<byte> GetEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06033BE8 RID: 211944 RVA: 0x006F730E File Offset: 0x006F550E
		public byte[] GetEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06033BE9 RID: 211945 RVA: 0x006F731C File Offset: 0x006F551C
		public static Offset<IStopUiScreenEffect> CreateIStopUiScreenEffect(FlatBufferBuilder builder, StringOffset EffectDaPathOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IStopUiScreenEffect.AddEffectDaPath(builder, EffectDaPathOffset);
			return IStopUiScreenEffect.EndIStopUiScreenEffect(builder);
		}

		// Token: 0x06033BEA RID: 211946 RVA: 0x006F7332 File Offset: 0x006F5532
		public static void StartIStopUiScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033BEB RID: 211947 RVA: 0x006F733B File Offset: 0x006F553B
		public static void AddEffectDaPath(FlatBufferBuilder builder, StringOffset effectDaPathOffset)
		{
			builder.AddOffset(0, effectDaPathOffset.Value, 0);
		}

		// Token: 0x06033BEC RID: 211948 RVA: 0x006F734B File Offset: 0x006F554B
		public static Offset<IStopUiScreenEffect> EndIStopUiScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IStopUiScreenEffect>(builder.EndTable());
		}

		// Token: 0x06033BED RID: 211949 RVA: 0x006F7358 File Offset: 0x006F5558
		public IStopUiScreenEffectT UnPack()
		{
			IStopUiScreenEffectT stopUiScreenEffectT = new IStopUiScreenEffectT();
			this.UnPackTo(stopUiScreenEffectT);
			return stopUiScreenEffectT;
		}

		// Token: 0x06033BEE RID: 211950 RVA: 0x006F7373 File Offset: 0x006F5573
		public void UnPackTo(IStopUiScreenEffectT _o)
		{
			_o.EffectDaPath = this.EffectDaPath;
		}

		// Token: 0x06033BEF RID: 211951 RVA: 0x006F7384 File Offset: 0x006F5584
		public static Offset<IStopUiScreenEffect> Pack(FlatBufferBuilder builder, IStopUiScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopUiScreenEffect>);
			}
			StringOffset effectDaPathOffset = (_o.EffectDaPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectDaPath);
			return IStopUiScreenEffect.CreateIStopUiScreenEffect(builder, effectDaPathOffset);
		}

		// Token: 0x04011CD7 RID: 72919
		private Table __p;
	}
}

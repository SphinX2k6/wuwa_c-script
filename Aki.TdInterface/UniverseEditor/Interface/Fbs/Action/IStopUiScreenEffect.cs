using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079C8 RID: 31176
	public struct IStopUiScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700E498 RID: 58520
		// (get) Token: 0x06036EE2 RID: 224994 RVA: 0x007585BC File Offset: 0x007567BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036EE3 RID: 224995 RVA: 0x007585C9 File Offset: 0x007567C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036EE4 RID: 224996 RVA: 0x007585D0 File Offset: 0x007567D0
		public static IStopUiScreenEffect GetRootAsIStopUiScreenEffect(ByteBuffer _bb)
		{
			return IStopUiScreenEffect.GetRootAsIStopUiScreenEffect(_bb, default(IStopUiScreenEffect));
		}

		// Token: 0x06036EE5 RID: 224997 RVA: 0x007585EC File Offset: 0x007567EC
		public static IStopUiScreenEffect GetRootAsIStopUiScreenEffect(ByteBuffer _bb, IStopUiScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036EE6 RID: 224998 RVA: 0x00758609 File Offset: 0x00756809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036EE7 RID: 224999 RVA: 0x00758618 File Offset: 0x00756818
		public IStopUiScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E499 RID: 58521
		// (get) Token: 0x06036EE8 RID: 225000 RVA: 0x00758628 File Offset: 0x00756828
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

		// Token: 0x06036EE9 RID: 225001 RVA: 0x0075865F File Offset: 0x0075685F
		public Span<byte> GetEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06036EEA RID: 225002 RVA: 0x0075866E File Offset: 0x0075686E
		public byte[] GetEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06036EEB RID: 225003 RVA: 0x0075867C File Offset: 0x0075687C
		public static Offset<IStopUiScreenEffect> CreateIStopUiScreenEffect(FlatBufferBuilder builder, StringOffset EffectDaPathOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IStopUiScreenEffect.AddEffectDaPath(builder, EffectDaPathOffset);
			return IStopUiScreenEffect.EndIStopUiScreenEffect(builder);
		}

		// Token: 0x06036EEC RID: 225004 RVA: 0x00758692 File Offset: 0x00756892
		public static void StartIStopUiScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036EED RID: 225005 RVA: 0x0075869B File Offset: 0x0075689B
		public static void AddEffectDaPath(FlatBufferBuilder builder, StringOffset effectDaPathOffset)
		{
			builder.AddOffset(0, effectDaPathOffset.Value, 0);
		}

		// Token: 0x06036EEE RID: 225006 RVA: 0x007586AB File Offset: 0x007568AB
		public static Offset<IStopUiScreenEffect> EndIStopUiScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IStopUiScreenEffect>(builder.EndTable());
		}

		// Token: 0x06036EEF RID: 225007 RVA: 0x007586B8 File Offset: 0x007568B8
		public IStopUiScreenEffectT UnPack()
		{
			IStopUiScreenEffectT stopUiScreenEffectT = new IStopUiScreenEffectT();
			this.UnPackTo(stopUiScreenEffectT);
			return stopUiScreenEffectT;
		}

		// Token: 0x06036EF0 RID: 225008 RVA: 0x007586D3 File Offset: 0x007568D3
		public void UnPackTo(IStopUiScreenEffectT _o)
		{
			_o.EffectDaPath = this.EffectDaPath;
		}

		// Token: 0x06036EF1 RID: 225009 RVA: 0x007586E4 File Offset: 0x007568E4
		public static Offset<IStopUiScreenEffect> Pack(FlatBufferBuilder builder, IStopUiScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopUiScreenEffect>);
			}
			StringOffset effectDaPathOffset = (_o.EffectDaPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectDaPath);
			return IStopUiScreenEffect.CreateIStopUiScreenEffect(builder, effectDaPathOffset);
		}

		// Token: 0x04012CD9 RID: 77017
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200769F RID: 30367
	public struct IScaleMapData : IFlatbufferObject
	{
		// Token: 0x1700DECB RID: 57035
		// (get) Token: 0x0603544B RID: 218187 RVA: 0x00725B58 File Offset: 0x00723D58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603544C RID: 218188 RVA: 0x00725B65 File Offset: 0x00723D65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603544D RID: 218189 RVA: 0x00725B6C File Offset: 0x00723D6C
		public static IScaleMapData GetRootAsIScaleMapData(ByteBuffer _bb)
		{
			return IScaleMapData.GetRootAsIScaleMapData(_bb, default(IScaleMapData));
		}

		// Token: 0x0603544E RID: 218190 RVA: 0x00725B88 File Offset: 0x00723D88
		public static IScaleMapData GetRootAsIScaleMapData(ByteBuffer _bb, IScaleMapData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603544F RID: 218191 RVA: 0x00725BA5 File Offset: 0x00723DA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035450 RID: 218192 RVA: 0x00725BB4 File Offset: 0x00723DB4
		public IScaleMapData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DECC RID: 57036
		// (get) Token: 0x06035451 RID: 218193 RVA: 0x00725BC4 File Offset: 0x00723DC4
		public string Key
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

		// Token: 0x06035452 RID: 218194 RVA: 0x00725BFB File Offset: 0x00723DFB
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06035453 RID: 218195 RVA: 0x00725C0A File Offset: 0x00723E0A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DECD RID: 57037
		// (get) Token: 0x06035454 RID: 218196 RVA: 0x00725C18 File Offset: 0x00723E18
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035455 RID: 218197 RVA: 0x00725C58 File Offset: 0x00723E58
		public static Offset<IScaleMapData> CreateIScaleMapData(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), float Scale = 0f)
		{
			builder.StartTable(2);
			IScaleMapData.AddScale(builder, Scale);
			IScaleMapData.AddKey(builder, KeyOffset);
			return IScaleMapData.EndIScaleMapData(builder);
		}

		// Token: 0x06035456 RID: 218198 RVA: 0x00725C75 File Offset: 0x00723E75
		public static void StartIScaleMapData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035457 RID: 218199 RVA: 0x00725C7E File Offset: 0x00723E7E
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x06035458 RID: 218200 RVA: 0x00725C8E File Offset: 0x00723E8E
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(1, scale, 0.0);
		}

		// Token: 0x06035459 RID: 218201 RVA: 0x00725CA1 File Offset: 0x00723EA1
		public static Offset<IScaleMapData> EndIScaleMapData(FlatBufferBuilder builder)
		{
			return new Offset<IScaleMapData>(builder.EndTable());
		}

		// Token: 0x0603545A RID: 218202 RVA: 0x00725CB0 File Offset: 0x00723EB0
		public IScaleMapDataT UnPack()
		{
			IScaleMapDataT scaleMapDataT = new IScaleMapDataT();
			this.UnPackTo(scaleMapDataT);
			return scaleMapDataT;
		}

		// Token: 0x0603545B RID: 218203 RVA: 0x00725CCB File Offset: 0x00723ECB
		public void UnPackTo(IScaleMapDataT _o)
		{
			_o.Key = this.Key;
			_o.Scale = this.Scale;
		}

		// Token: 0x0603545C RID: 218204 RVA: 0x00725CE8 File Offset: 0x00723EE8
		public static Offset<IScaleMapData> Pack(FlatBufferBuilder builder, IScaleMapDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScaleMapData>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IScaleMapData.CreateIScaleMapData(builder, keyOffset, _o.Scale);
		}

		// Token: 0x0401288B RID: 75915
		private Table __p;
	}
}

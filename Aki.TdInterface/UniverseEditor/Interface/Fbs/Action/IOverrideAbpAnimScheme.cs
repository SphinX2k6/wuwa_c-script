using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B5 RID: 29621
	public struct IOverrideAbpAnimScheme : IFlatbufferObject
	{
		// Token: 0x1700D99C RID: 55708
		// (get) Token: 0x06033CE8 RID: 212200 RVA: 0x006FCF68 File Offset: 0x006FB168
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033CE9 RID: 212201 RVA: 0x006FCF75 File Offset: 0x006FB175
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033CEA RID: 212202 RVA: 0x006FCF7C File Offset: 0x006FB17C
		public static IOverrideAbpAnimScheme GetRootAsIOverrideAbpAnimScheme(ByteBuffer _bb)
		{
			return IOverrideAbpAnimScheme.GetRootAsIOverrideAbpAnimScheme(_bb, default(IOverrideAbpAnimScheme));
		}

		// Token: 0x06033CEB RID: 212203 RVA: 0x006FCF98 File Offset: 0x006FB198
		public static IOverrideAbpAnimScheme GetRootAsIOverrideAbpAnimScheme(ByteBuffer _bb, IOverrideAbpAnimScheme obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033CEC RID: 212204 RVA: 0x006FCFB5 File Offset: 0x006FB1B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033CED RID: 212205 RVA: 0x006FCFC4 File Offset: 0x006FB1C4
		public IOverrideAbpAnimScheme __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06033CEE RID: 212206 RVA: 0x006FCFD4 File Offset: 0x006FB1D4
		public IOverrideAbpAnimSchemeConfig? OverrideConfigs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IOverrideAbpAnimSchemeConfig?(default(IOverrideAbpAnimSchemeConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D99D RID: 55709
		// (get) Token: 0x06033CEF RID: 212207 RVA: 0x006FD034 File Offset: 0x006FB234
		public int OverrideConfigsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06033CF0 RID: 212208 RVA: 0x006FD05F File Offset: 0x006FB25F
		public static Offset<IOverrideAbpAnimScheme> CreateIOverrideAbpAnimScheme(FlatBufferBuilder builder, VectorOffset OverrideConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IOverrideAbpAnimScheme.AddOverrideConfigs(builder, OverrideConfigsOffset);
			return IOverrideAbpAnimScheme.EndIOverrideAbpAnimScheme(builder);
		}

		// Token: 0x06033CF1 RID: 212209 RVA: 0x006FD075 File Offset: 0x006FB275
		public static void StartIOverrideAbpAnimScheme(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033CF2 RID: 212210 RVA: 0x006FD07E File Offset: 0x006FB27E
		public static void AddOverrideConfigs(FlatBufferBuilder builder, VectorOffset overrideConfigsOffset)
		{
			builder.AddOffset(0, overrideConfigsOffset.Value, 0);
		}

		// Token: 0x06033CF3 RID: 212211 RVA: 0x006FD090 File Offset: 0x006FB290
		public static VectorOffset CreateOverrideConfigsVector(FlatBufferBuilder builder, Offset<IOverrideAbpAnimSchemeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033CF4 RID: 212212 RVA: 0x006FD0D0 File Offset: 0x006FB2D0
		public static VectorOffset CreateOverrideConfigsVectorBlock(FlatBufferBuilder builder, Offset<IOverrideAbpAnimSchemeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IOverrideAbpAnimSchemeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033CF5 RID: 212213 RVA: 0x006FD0EA File Offset: 0x006FB2EA
		public static VectorOffset CreateOverrideConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IOverrideAbpAnimSchemeConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IOverrideAbpAnimSchemeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033CF6 RID: 212214 RVA: 0x006FD108 File Offset: 0x006FB308
		public static VectorOffset CreateOverrideConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IOverrideAbpAnimSchemeConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033CF7 RID: 212215 RVA: 0x006FD121 File Offset: 0x006FB321
		public static void StartOverrideConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033CF8 RID: 212216 RVA: 0x006FD12C File Offset: 0x006FB32C
		public static Offset<IOverrideAbpAnimScheme> EndIOverrideAbpAnimScheme(FlatBufferBuilder builder)
		{
			return new Offset<IOverrideAbpAnimScheme>(builder.EndTable());
		}

		// Token: 0x06033CF9 RID: 212217 RVA: 0x006FD13C File Offset: 0x006FB33C
		public IOverrideAbpAnimSchemeT UnPack()
		{
			IOverrideAbpAnimSchemeT overrideAbpAnimSchemeT = new IOverrideAbpAnimSchemeT();
			this.UnPackTo(overrideAbpAnimSchemeT);
			return overrideAbpAnimSchemeT;
		}

		// Token: 0x06033CFA RID: 212218 RVA: 0x006FD158 File Offset: 0x006FB358
		public void UnPackTo(IOverrideAbpAnimSchemeT _o)
		{
			_o.OverrideConfigs = new List<IOverrideAbpAnimSchemeConfigT>();
			for (int i = 0; i < this.OverrideConfigsLength; i++)
			{
				_o.OverrideConfigs.Add((this.OverrideConfigs(i) != null) ? this.OverrideConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06033CFB RID: 212219 RVA: 0x006FD1B8 File Offset: 0x006FB3B8
		public static Offset<IOverrideAbpAnimScheme> Pack(FlatBufferBuilder builder, IOverrideAbpAnimSchemeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOverrideAbpAnimScheme>);
			}
			VectorOffset overrideConfigsOffset = default(VectorOffset);
			if (_o.OverrideConfigs != null)
			{
				Offset<IOverrideAbpAnimSchemeConfig>[] array = new Offset<IOverrideAbpAnimSchemeConfig>[_o.OverrideConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IOverrideAbpAnimSchemeConfig.Pack(builder, _o.OverrideConfigs[i]);
				}
				overrideConfigsOffset = IOverrideAbpAnimScheme.CreateOverrideConfigsVector(builder, array);
			}
			return IOverrideAbpAnimScheme.CreateIOverrideAbpAnimScheme(builder, overrideConfigsOffset);
		}

		// Token: 0x040124E7 RID: 74983
		private Table __p;
	}
}

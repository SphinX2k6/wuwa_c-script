using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C4E RID: 27726
	public struct IOverrideAbpAnimScheme : IFlatbufferObject
	{
		// Token: 0x1700CE81 RID: 52865
		// (get) Token: 0x06030D8D RID: 200077 RVA: 0x006A2A68 File Offset: 0x006A0C68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030D8E RID: 200078 RVA: 0x006A2A75 File Offset: 0x006A0C75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030D8F RID: 200079 RVA: 0x006A2A7C File Offset: 0x006A0C7C
		public static IOverrideAbpAnimScheme GetRootAsIOverrideAbpAnimScheme(ByteBuffer _bb)
		{
			return IOverrideAbpAnimScheme.GetRootAsIOverrideAbpAnimScheme(_bb, default(IOverrideAbpAnimScheme));
		}

		// Token: 0x06030D90 RID: 200080 RVA: 0x006A2A98 File Offset: 0x006A0C98
		public static IOverrideAbpAnimScheme GetRootAsIOverrideAbpAnimScheme(ByteBuffer _bb, IOverrideAbpAnimScheme obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030D91 RID: 200081 RVA: 0x006A2AB5 File Offset: 0x006A0CB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030D92 RID: 200082 RVA: 0x006A2AC4 File Offset: 0x006A0CC4
		public IOverrideAbpAnimScheme __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06030D93 RID: 200083 RVA: 0x006A2AD4 File Offset: 0x006A0CD4
		public IOverrideAbpAnimSchemeConfig? OverrideConfigs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IOverrideAbpAnimSchemeConfig?(default(IOverrideAbpAnimSchemeConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CE82 RID: 52866
		// (get) Token: 0x06030D94 RID: 200084 RVA: 0x006A2B34 File Offset: 0x006A0D34
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

		// Token: 0x06030D95 RID: 200085 RVA: 0x006A2B5F File Offset: 0x006A0D5F
		public static Offset<IOverrideAbpAnimScheme> CreateIOverrideAbpAnimScheme(FlatBufferBuilder builder, VectorOffset OverrideConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IOverrideAbpAnimScheme.AddOverrideConfigs(builder, OverrideConfigsOffset);
			return IOverrideAbpAnimScheme.EndIOverrideAbpAnimScheme(builder);
		}

		// Token: 0x06030D96 RID: 200086 RVA: 0x006A2B75 File Offset: 0x006A0D75
		public static void StartIOverrideAbpAnimScheme(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030D97 RID: 200087 RVA: 0x006A2B7E File Offset: 0x006A0D7E
		public static void AddOverrideConfigs(FlatBufferBuilder builder, VectorOffset overrideConfigsOffset)
		{
			builder.AddOffset(0, overrideConfigsOffset.Value, 0);
		}

		// Token: 0x06030D98 RID: 200088 RVA: 0x006A2B90 File Offset: 0x006A0D90
		public static VectorOffset CreateOverrideConfigsVector(FlatBufferBuilder builder, Offset<IOverrideAbpAnimSchemeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030D99 RID: 200089 RVA: 0x006A2BD0 File Offset: 0x006A0DD0
		public static VectorOffset CreateOverrideConfigsVectorBlock(FlatBufferBuilder builder, Offset<IOverrideAbpAnimSchemeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IOverrideAbpAnimSchemeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030D9A RID: 200090 RVA: 0x006A2BEA File Offset: 0x006A0DEA
		public static VectorOffset CreateOverrideConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IOverrideAbpAnimSchemeConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IOverrideAbpAnimSchemeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030D9B RID: 200091 RVA: 0x006A2C08 File Offset: 0x006A0E08
		public static VectorOffset CreateOverrideConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IOverrideAbpAnimSchemeConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030D9C RID: 200092 RVA: 0x006A2C21 File Offset: 0x006A0E21
		public static void StartOverrideConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030D9D RID: 200093 RVA: 0x006A2C2C File Offset: 0x006A0E2C
		public static Offset<IOverrideAbpAnimScheme> EndIOverrideAbpAnimScheme(FlatBufferBuilder builder)
		{
			return new Offset<IOverrideAbpAnimScheme>(builder.EndTable());
		}

		// Token: 0x06030D9E RID: 200094 RVA: 0x006A2C3C File Offset: 0x006A0E3C
		public IOverrideAbpAnimSchemeT UnPack()
		{
			IOverrideAbpAnimSchemeT overrideAbpAnimSchemeT = new IOverrideAbpAnimSchemeT();
			this.UnPackTo(overrideAbpAnimSchemeT);
			return overrideAbpAnimSchemeT;
		}

		// Token: 0x06030D9F RID: 200095 RVA: 0x006A2C58 File Offset: 0x006A0E58
		public void UnPackTo(IOverrideAbpAnimSchemeT _o)
		{
			_o.OverrideConfigs = new List<IOverrideAbpAnimSchemeConfigT>();
			for (int i = 0; i < this.OverrideConfigsLength; i++)
			{
				_o.OverrideConfigs.Add((this.OverrideConfigs(i) != null) ? this.OverrideConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06030DA0 RID: 200096 RVA: 0x006A2CB8 File Offset: 0x006A0EB8
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

		// Token: 0x0401158F RID: 71055
		private Table __p;
	}
}

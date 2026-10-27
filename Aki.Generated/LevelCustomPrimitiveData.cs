using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DBF RID: 3519
	public struct LevelCustomPrimitiveData : IFlatbufferObject
	{
		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x06008D20 RID: 36128 RVA: 0x00275B49 File Offset: 0x00273D49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D21 RID: 36129 RVA: 0x00275B56 File Offset: 0x00273D56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D22 RID: 36130 RVA: 0x00275B60 File Offset: 0x00273D60
		public static LevelCustomPrimitiveData GetRootAsLevelCustomPrimitiveData(ByteBuffer _bb)
		{
			return LevelCustomPrimitiveData.GetRootAsLevelCustomPrimitiveData(_bb, default(LevelCustomPrimitiveData));
		}

		// Token: 0x06008D23 RID: 36131 RVA: 0x00275B7C File Offset: 0x00273D7C
		public static LevelCustomPrimitiveData GetRootAsLevelCustomPrimitiveData(ByteBuffer _bb, LevelCustomPrimitiveData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D24 RID: 36132 RVA: 0x00275B99 File Offset: 0x00273D99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D25 RID: 36133 RVA: 0x00275BA8 File Offset: 0x00273DA8
		public LevelCustomPrimitiveData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06008D26 RID: 36134 RVA: 0x00275BB8 File Offset: 0x00273DB8
		public int PbDataId
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

		// Token: 0x06008D27 RID: 36135 RVA: 0x00275BF4 File Offset: 0x00273DF4
		public float CustomPrimitiveDataIndex0(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06008D28 RID: 36136 RVA: 0x00275C38 File Offset: 0x00273E38
		public int CustomPrimitiveDataIndex0Length
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008D29 RID: 36137 RVA: 0x00275C63 File Offset: 0x00273E63
		public Span<float> GetCustomPrimitiveDataIndex0Bytes()
		{
			return this.__p.__vector_as_span<float>(6, 4);
		}

		// Token: 0x06008D2A RID: 36138 RVA: 0x00275C72 File Offset: 0x00273E72
		public float[] GetCustomPrimitiveDataIndex0Array()
		{
			return this.__p.__vector_as_array<float>(6) ?? Array.Empty<float>();
		}

		// Token: 0x06008D2B RID: 36139 RVA: 0x00275C8C File Offset: 0x00273E8C
		public float CustomPrimitiveDataIndex1(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06008D2C RID: 36140 RVA: 0x00275CD0 File Offset: 0x00273ED0
		public int CustomPrimitiveDataIndex1Length
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008D2D RID: 36141 RVA: 0x00275CFB File Offset: 0x00273EFB
		public Span<float> GetCustomPrimitiveDataIndex1Bytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x06008D2E RID: 36142 RVA: 0x00275D0A File Offset: 0x00273F0A
		public float[] GetCustomPrimitiveDataIndex1Array()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x06008D2F RID: 36143 RVA: 0x00275D24 File Offset: 0x00273F24
		public float CustomPrimitiveDataIndex2(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x06008D30 RID: 36144 RVA: 0x00275D68 File Offset: 0x00273F68
		public int CustomPrimitiveDataIndex2Length
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008D31 RID: 36145 RVA: 0x00275D94 File Offset: 0x00273F94
		public Span<float> GetCustomPrimitiveDataIndex2Bytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x06008D32 RID: 36146 RVA: 0x00275DA4 File Offset: 0x00273FA4
		public float[] GetCustomPrimitiveDataIndex2Array()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x06008D33 RID: 36147 RVA: 0x00275DBC File Offset: 0x00273FBC
		public float CustomPrimitiveDataIndex3(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x06008D34 RID: 36148 RVA: 0x00275E00 File Offset: 0x00274000
		public int CustomPrimitiveDataIndex3Length
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008D35 RID: 36149 RVA: 0x00275E2C File Offset: 0x0027402C
		public Span<float> GetCustomPrimitiveDataIndex3Bytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x06008D36 RID: 36150 RVA: 0x00275E3C File Offset: 0x0027403C
		public float[] GetCustomPrimitiveDataIndex3Array()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x06008D37 RID: 36151 RVA: 0x00275E54 File Offset: 0x00274054
		public float CustomPrimitiveDataIndex4(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x06008D38 RID: 36152 RVA: 0x00275E98 File Offset: 0x00274098
		public int CustomPrimitiveDataIndex4Length
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008D39 RID: 36153 RVA: 0x00275EC4 File Offset: 0x002740C4
		public Span<float> GetCustomPrimitiveDataIndex4Bytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x06008D3A RID: 36154 RVA: 0x00275ED4 File Offset: 0x002740D4
		public float[] GetCustomPrimitiveDataIndex4Array()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x06008D3B RID: 36155 RVA: 0x00275EEC File Offset: 0x002740EC
		public float CustomPrimitiveDataIndex5(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x06008D3C RID: 36156 RVA: 0x00275F30 File Offset: 0x00274130
		public int CustomPrimitiveDataIndex5Length
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008D3D RID: 36157 RVA: 0x00275F5C File Offset: 0x0027415C
		public Span<float> GetCustomPrimitiveDataIndex5Bytes()
		{
			return this.__p.__vector_as_span<float>(16, 4);
		}

		// Token: 0x06008D3E RID: 36158 RVA: 0x00275F6C File Offset: 0x0027416C
		public float[] GetCustomPrimitiveDataIndex5Array()
		{
			return this.__p.__vector_as_array<float>(16) ?? Array.Empty<float>();
		}

		// Token: 0x06008D3F RID: 36159 RVA: 0x00275F84 File Offset: 0x00274184
		public float CustomPrimitiveDataIndex6(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x06008D40 RID: 36160 RVA: 0x00275FC8 File Offset: 0x002741C8
		public int CustomPrimitiveDataIndex6Length
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008D41 RID: 36161 RVA: 0x00275FF4 File Offset: 0x002741F4
		public Span<float> GetCustomPrimitiveDataIndex6Bytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x06008D42 RID: 36162 RVA: 0x00276004 File Offset: 0x00274204
		public float[] GetCustomPrimitiveDataIndex6Array()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x06008D43 RID: 36163 RVA: 0x0027601C File Offset: 0x0027421C
		public float CustomPrimitiveDataIndex7(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x06008D44 RID: 36164 RVA: 0x00276060 File Offset: 0x00274260
		public int CustomPrimitiveDataIndex7Length
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008D45 RID: 36165 RVA: 0x0027608C File Offset: 0x0027428C
		public Span<float> GetCustomPrimitiveDataIndex7Bytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x06008D46 RID: 36166 RVA: 0x0027609C File Offset: 0x0027429C
		public float[] GetCustomPrimitiveDataIndex7Array()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x06008D47 RID: 36167 RVA: 0x002760B4 File Offset: 0x002742B4
		public float CustomPrimitiveDataIndex8(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06008D48 RID: 36168 RVA: 0x002760F8 File Offset: 0x002742F8
		public int CustomPrimitiveDataIndex8Length
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008D49 RID: 36169 RVA: 0x00276124 File Offset: 0x00274324
		public Span<float> GetCustomPrimitiveDataIndex8Bytes()
		{
			return this.__p.__vector_as_span<float>(22, 4);
		}

		// Token: 0x06008D4A RID: 36170 RVA: 0x00276134 File Offset: 0x00274334
		public float[] GetCustomPrimitiveDataIndex8Array()
		{
			return this.__p.__vector_as_array<float>(22) ?? Array.Empty<float>();
		}

		// Token: 0x06008D4B RID: 36171 RVA: 0x0027614C File Offset: 0x0027434C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomPrimitiveDataIndex0Iter()或GetCustomPrimitiveDataIndex0Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CustomPrimitiveDataIndex0()
		{
			LevelCustomPrimitiveData levelCustomPrimitiveData = this;
			return levelCustomPrimitiveData.GetCustomPrimitiveDataIndex0Array() ?? Array.Empty<float>();
		}

		// Token: 0x06008D4C RID: 36172 RVA: 0x00276170 File Offset: 0x00274370
		[NullableContext(1)]
		public readonly IEnumerable<float> CustomPrimitiveDataIndex0Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex0Iter>d__56 <CustomPrimitiveDataIndex0Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex0Iter>d__56(-2);
			<CustomPrimitiveDataIndex0Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex0Iter>d__;
		}

		// Token: 0x06008D4D RID: 36173 RVA: 0x00276188 File Offset: 0x00274388
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomPrimitiveDataIndex1Iter()或GetCustomPrimitiveDataIndex1Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CustomPrimitiveDataIndex1()
		{
			LevelCustomPrimitiveData levelCustomPrimitiveData = this;
			return levelCustomPrimitiveData.GetCustomPrimitiveDataIndex1Array() ?? Array.Empty<float>();
		}

		// Token: 0x06008D4E RID: 36174 RVA: 0x002761AC File Offset: 0x002743AC
		[NullableContext(1)]
		public readonly IEnumerable<float> CustomPrimitiveDataIndex1Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex1Iter>d__58 <CustomPrimitiveDataIndex1Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex1Iter>d__58(-2);
			<CustomPrimitiveDataIndex1Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex1Iter>d__;
		}

		// Token: 0x06008D4F RID: 36175 RVA: 0x002761C4 File Offset: 0x002743C4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomPrimitiveDataIndex2Iter()或GetCustomPrimitiveDataIndex2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CustomPrimitiveDataIndex2()
		{
			LevelCustomPrimitiveData levelCustomPrimitiveData = this;
			return levelCustomPrimitiveData.GetCustomPrimitiveDataIndex2Array() ?? Array.Empty<float>();
		}

		// Token: 0x06008D50 RID: 36176 RVA: 0x002761E8 File Offset: 0x002743E8
		[NullableContext(1)]
		public readonly IEnumerable<float> CustomPrimitiveDataIndex2Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex2Iter>d__60 <CustomPrimitiveDataIndex2Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex2Iter>d__60(-2);
			<CustomPrimitiveDataIndex2Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex2Iter>d__;
		}

		// Token: 0x06008D51 RID: 36177 RVA: 0x00276200 File Offset: 0x00274400
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomPrimitiveDataIndex3Iter()或GetCustomPrimitiveDataIndex3Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CustomPrimitiveDataIndex3()
		{
			LevelCustomPrimitiveData levelCustomPrimitiveData = this;
			return levelCustomPrimitiveData.GetCustomPrimitiveDataIndex3Array() ?? Array.Empty<float>();
		}

		// Token: 0x06008D52 RID: 36178 RVA: 0x00276224 File Offset: 0x00274424
		[NullableContext(1)]
		public readonly IEnumerable<float> CustomPrimitiveDataIndex3Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex3Iter>d__62 <CustomPrimitiveDataIndex3Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex3Iter>d__62(-2);
			<CustomPrimitiveDataIndex3Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex3Iter>d__;
		}

		// Token: 0x06008D53 RID: 36179 RVA: 0x0027623C File Offset: 0x0027443C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomPrimitiveDataIndex4Iter()或GetCustomPrimitiveDataIndex4Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CustomPrimitiveDataIndex4()
		{
			LevelCustomPrimitiveData levelCustomPrimitiveData = this;
			return levelCustomPrimitiveData.GetCustomPrimitiveDataIndex4Array() ?? Array.Empty<float>();
		}

		// Token: 0x06008D54 RID: 36180 RVA: 0x00276260 File Offset: 0x00274460
		[NullableContext(1)]
		public readonly IEnumerable<float> CustomPrimitiveDataIndex4Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex4Iter>d__64 <CustomPrimitiveDataIndex4Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex4Iter>d__64(-2);
			<CustomPrimitiveDataIndex4Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex4Iter>d__;
		}

		// Token: 0x06008D55 RID: 36181 RVA: 0x00276278 File Offset: 0x00274478
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomPrimitiveDataIndex5Iter()或GetCustomPrimitiveDataIndex5Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CustomPrimitiveDataIndex5()
		{
			LevelCustomPrimitiveData levelCustomPrimitiveData = this;
			return levelCustomPrimitiveData.GetCustomPrimitiveDataIndex5Array() ?? Array.Empty<float>();
		}

		// Token: 0x06008D56 RID: 36182 RVA: 0x0027629C File Offset: 0x0027449C
		[NullableContext(1)]
		public readonly IEnumerable<float> CustomPrimitiveDataIndex5Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex5Iter>d__66 <CustomPrimitiveDataIndex5Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex5Iter>d__66(-2);
			<CustomPrimitiveDataIndex5Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex5Iter>d__;
		}

		// Token: 0x06008D57 RID: 36183 RVA: 0x002762B4 File Offset: 0x002744B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomPrimitiveDataIndex6Iter()或GetCustomPrimitiveDataIndex6Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CustomPrimitiveDataIndex6()
		{
			LevelCustomPrimitiveData levelCustomPrimitiveData = this;
			return levelCustomPrimitiveData.GetCustomPrimitiveDataIndex6Array() ?? Array.Empty<float>();
		}

		// Token: 0x06008D58 RID: 36184 RVA: 0x002762D8 File Offset: 0x002744D8
		[NullableContext(1)]
		public readonly IEnumerable<float> CustomPrimitiveDataIndex6Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex6Iter>d__68 <CustomPrimitiveDataIndex6Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex6Iter>d__68(-2);
			<CustomPrimitiveDataIndex6Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex6Iter>d__;
		}

		// Token: 0x06008D59 RID: 36185 RVA: 0x002762F0 File Offset: 0x002744F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomPrimitiveDataIndex7Iter()或GetCustomPrimitiveDataIndex7Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CustomPrimitiveDataIndex7()
		{
			LevelCustomPrimitiveData levelCustomPrimitiveData = this;
			return levelCustomPrimitiveData.GetCustomPrimitiveDataIndex7Array() ?? Array.Empty<float>();
		}

		// Token: 0x06008D5A RID: 36186 RVA: 0x00276314 File Offset: 0x00274514
		[NullableContext(1)]
		public readonly IEnumerable<float> CustomPrimitiveDataIndex7Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex7Iter>d__70 <CustomPrimitiveDataIndex7Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex7Iter>d__70(-2);
			<CustomPrimitiveDataIndex7Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex7Iter>d__;
		}

		// Token: 0x06008D5B RID: 36187 RVA: 0x0027632C File Offset: 0x0027452C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomPrimitiveDataIndex8Iter()或GetCustomPrimitiveDataIndex8Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CustomPrimitiveDataIndex8()
		{
			LevelCustomPrimitiveData levelCustomPrimitiveData = this;
			return levelCustomPrimitiveData.GetCustomPrimitiveDataIndex8Array() ?? Array.Empty<float>();
		}

		// Token: 0x06008D5C RID: 36188 RVA: 0x00276350 File Offset: 0x00274550
		[NullableContext(1)]
		public readonly IEnumerable<float> CustomPrimitiveDataIndex8Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex8Iter>d__72 <CustomPrimitiveDataIndex8Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex8Iter>d__72(-2);
			<CustomPrimitiveDataIndex8Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex8Iter>d__;
		}

		// Token: 0x04004E55 RID: 20053
		private Table __p;
	}
}

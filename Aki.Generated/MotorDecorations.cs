using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F19 RID: 3865
	public struct MotorDecorations : IFlatbufferObject
	{
		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x06009D39 RID: 40249 RVA: 0x002A9AA0 File Offset: 0x002A7CA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009D3A RID: 40250 RVA: 0x002A9AAD File Offset: 0x002A7CAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009D3B RID: 40251 RVA: 0x002A9AB4 File Offset: 0x002A7CB4
		public static MotorDecorations GetRootAsMotorDecorations(ByteBuffer _bb)
		{
			return MotorDecorations.GetRootAsMotorDecorations(_bb, default(MotorDecorations));
		}

		// Token: 0x06009D3C RID: 40252 RVA: 0x002A9AD0 File Offset: 0x002A7CD0
		public static MotorDecorations GetRootAsMotorDecorations(ByteBuffer _bb, MotorDecorations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009D3D RID: 40253 RVA: 0x002A9AED File Offset: 0x002A7CED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009D3E RID: 40254 RVA: 0x002A9AFC File Offset: 0x002A7CFC
		public MotorDecorations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x06009D3F RID: 40255 RVA: 0x002A9B0C File Offset: 0x002A7D0C
		public int Id
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

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x06009D40 RID: 40256 RVA: 0x002A9B48 File Offset: 0x002A7D48
		public int GroupId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x06009D41 RID: 40257 RVA: 0x002A9B84 File Offset: 0x002A7D84
		public int PartId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x06009D42 RID: 40258 RVA: 0x002A9BC0 File Offset: 0x002A7DC0
		public bool FreeFlag
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x06009D43 RID: 40259 RVA: 0x002A9C00 File Offset: 0x002A7E00
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x06009D44 RID: 40260 RVA: 0x002A9C40 File Offset: 0x002A7E40
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x06009D45 RID: 40261 RVA: 0x002A9C80 File Offset: 0x002A7E80
		public int ModelId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x06009D46 RID: 40262 RVA: 0x002A9CC0 File Offset: 0x002A7EC0
		public string DecorationsIconPath
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D47 RID: 40263 RVA: 0x002A9CF8 File Offset: 0x002A7EF8
		public Span<byte> GetDecorationsIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009D48 RID: 40264 RVA: 0x002A9D08 File Offset: 0x002A7F08
		public byte[] GetDecorationsIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x06009D49 RID: 40265 RVA: 0x002A9D20 File Offset: 0x002A7F20
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D4A RID: 40266 RVA: 0x002A9D58 File Offset: 0x002A7F58
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009D4B RID: 40267 RVA: 0x002A9D68 File Offset: 0x002A7F68
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x06009D4C RID: 40268 RVA: 0x002A9D80 File Offset: 0x002A7F80
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D4D RID: 40269 RVA: 0x002A9DB8 File Offset: 0x002A7FB8
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009D4E RID: 40270 RVA: 0x002A9DC8 File Offset: 0x002A7FC8
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x06009D4F RID: 40271 RVA: 0x002A9DE0 File Offset: 0x002A7FE0
		public string IconSmall
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D50 RID: 40272 RVA: 0x002A9E18 File Offset: 0x002A8018
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009D51 RID: 40273 RVA: 0x002A9E28 File Offset: 0x002A8028
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x06009D52 RID: 40274 RVA: 0x002A9E40 File Offset: 0x002A8040
		public string Title
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D53 RID: 40275 RVA: 0x002A9E78 File Offset: 0x002A8078
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009D54 RID: 40276 RVA: 0x002A9E88 File Offset: 0x002A8088
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x06009D55 RID: 40277 RVA: 0x002A9EA0 File Offset: 0x002A80A0
		public string SubTitle
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D56 RID: 40278 RVA: 0x002A9ED8 File Offset: 0x002A80D8
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009D57 RID: 40279 RVA: 0x002A9EE8 File Offset: 0x002A80E8
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x06009D58 RID: 40280 RVA: 0x002A9F00 File Offset: 0x002A8100
		public string TypeDescription
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D59 RID: 40281 RVA: 0x002A9F38 File Offset: 0x002A8138
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06009D5A RID: 40282 RVA: 0x002A9F48 File Offset: 0x002A8148
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x06009D5B RID: 40283 RVA: 0x002A9F60 File Offset: 0x002A8160
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D5C RID: 40284 RVA: 0x002A9F98 File Offset: 0x002A8198
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06009D5D RID: 40285 RVA: 0x002A9FA8 File Offset: 0x002A81A8
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x06009D5E RID: 40286 RVA: 0x002A9FC0 File Offset: 0x002A81C0
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x06009D5F RID: 40287 RVA: 0x002AA000 File Offset: 0x002A8200
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009D60 RID: 40288 RVA: 0x002AA02C File Offset: 0x002A822C
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06009D61 RID: 40289 RVA: 0x002AA03C File Offset: 0x002A823C
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x06009D62 RID: 40290 RVA: 0x002AA054 File Offset: 0x002A8254
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x06009D63 RID: 40291 RVA: 0x002AA094 File Offset: 0x002A8294
		public string ObtainedShowDescription
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D64 RID: 40292 RVA: 0x002AA0CC File Offset: 0x002A82CC
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06009D65 RID: 40293 RVA: 0x002AA0DC File Offset: 0x002A82DC
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x06009D66 RID: 40294 RVA: 0x002AA0F4 File Offset: 0x002A82F4
		public float Scale(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x06009D67 RID: 40295 RVA: 0x002AA138 File Offset: 0x002A8338
		public int ScaleLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009D68 RID: 40296 RVA: 0x002AA164 File Offset: 0x002A8364
		public Span<float> GetScaleBytes()
		{
			return this.__p.__vector_as_span<float>(40, 4);
		}

		// Token: 0x06009D69 RID: 40297 RVA: 0x002AA174 File Offset: 0x002A8374
		public float[] GetScaleArray()
		{
			return this.__p.__vector_as_array<float>(40) ?? Array.Empty<float>();
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x06009D6A RID: 40298 RVA: 0x002AA18C File Offset: 0x002A838C
		public string SocketName
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D6B RID: 40299 RVA: 0x002AA1C4 File Offset: 0x002A83C4
		public Span<byte> GetSocketNameBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06009D6C RID: 40300 RVA: 0x002AA1D4 File Offset: 0x002A83D4
		public byte[] GetSocketNameArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x06009D6D RID: 40301 RVA: 0x002AA1EC File Offset: 0x002A83EC
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x06009D6E RID: 40302 RVA: 0x002AA1F4 File Offset: 0x002A83F4
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			MotorDecorations.<ItemAccessIter>d__75 <ItemAccessIter>d__ = new MotorDecorations.<ItemAccessIter>d__75(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x06009D6F RID: 40303 RVA: 0x002AA209 File Offset: 0x002A8409
		[NullableContext(1)]
		public float[] Scale()
		{
			return this.GetScaleArray();
		}

		// Token: 0x06009D70 RID: 40304 RVA: 0x002AA211 File Offset: 0x002A8411
		[NullableContext(1)]
		public IEnumerable<float> ScaleIter()
		{
			MotorDecorations.<ScaleIter>d__77 <ScaleIter>d__ = new MotorDecorations.<ScaleIter>d__77(-2);
			<ScaleIter>d__.<>3__<>4__this = this;
			return <ScaleIter>d__;
		}

		// Token: 0x040054BF RID: 21695
		private Table __p;
	}
}

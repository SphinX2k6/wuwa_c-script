using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A6 RID: 21670
	public struct IJigsawCompletedConfig : IFlatbufferObject
	{
		// Token: 0x17009F8A RID: 40842
		// (get) Token: 0x06023AAA RID: 146090 RVA: 0x004EE324 File Offset: 0x004EC524
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023AAB RID: 146091 RVA: 0x004EE331 File Offset: 0x004EC531
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023AAC RID: 146092 RVA: 0x004EE338 File Offset: 0x004EC538
		public static IJigsawCompletedConfig GetRootAsIJigsawCompletedConfig(ByteBuffer _bb)
		{
			return IJigsawCompletedConfig.GetRootAsIJigsawCompletedConfig(_bb, default(IJigsawCompletedConfig));
		}

		// Token: 0x06023AAD RID: 146093 RVA: 0x004EE354 File Offset: 0x004EC554
		public static IJigsawCompletedConfig GetRootAsIJigsawCompletedConfig(ByteBuffer _bb, IJigsawCompletedConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023AAE RID: 146094 RVA: 0x004EE371 File Offset: 0x004EC571
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023AAF RID: 146095 RVA: 0x004EE380 File Offset: 0x004EC580
		public IJigsawCompletedConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F8B RID: 40843
		// (get) Token: 0x06023AB0 RID: 146096 RVA: 0x004EE390 File Offset: 0x004EC590
		public bool IsSilentPiece
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F8C RID: 40844
		// (get) Token: 0x06023AB1 RID: 146097 RVA: 0x004EE3D0 File Offset: 0x004EC5D0
		public bool IsSilentFoundation
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F8D RID: 40845
		// (get) Token: 0x06023AB2 RID: 146098 RVA: 0x004EE410 File Offset: 0x004EC610
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023AB3 RID: 146099 RVA: 0x004EE44C File Offset: 0x004EC64C
		public static Offset<IJigsawCompletedConfig> CreateIJigsawCompletedConfig(FlatBufferBuilder builder, bool IsSilentPiece = false, bool IsSilentFoundation = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IJigsawCompletedConfig.AddNullMask(builder, NullMask);
			IJigsawCompletedConfig.AddIsSilentFoundation(builder, IsSilentFoundation);
			IJigsawCompletedConfig.AddIsSilentPiece(builder, IsSilentPiece);
			return IJigsawCompletedConfig.EndIJigsawCompletedConfig(builder);
		}

		// Token: 0x06023AB4 RID: 146100 RVA: 0x004EE470 File Offset: 0x004EC670
		public static void StartIJigsawCompletedConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023AB5 RID: 146101 RVA: 0x004EE479 File Offset: 0x004EC679
		public static void AddIsSilentPiece(FlatBufferBuilder builder, bool isSilentPiece)
		{
			builder.AddBool(0, isSilentPiece, false);
		}

		// Token: 0x06023AB6 RID: 146102 RVA: 0x004EE484 File Offset: 0x004EC684
		public static void AddIsSilentFoundation(FlatBufferBuilder builder, bool isSilentFoundation)
		{
			builder.AddBool(1, isSilentFoundation, false);
		}

		// Token: 0x06023AB7 RID: 146103 RVA: 0x004EE48F File Offset: 0x004EC68F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06023AB8 RID: 146104 RVA: 0x004EE49A File Offset: 0x004EC69A
		public static Offset<IJigsawCompletedConfig> EndIJigsawCompletedConfig(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawCompletedConfig>(builder.EndTable());
		}

		// Token: 0x06023AB9 RID: 146105 RVA: 0x004EE4A8 File Offset: 0x004EC6A8
		public IJigsawCompletedConfigT UnPack()
		{
			IJigsawCompletedConfigT jigsawCompletedConfigT = new IJigsawCompletedConfigT();
			this.UnPackTo(jigsawCompletedConfigT);
			return jigsawCompletedConfigT;
		}

		// Token: 0x06023ABA RID: 146106 RVA: 0x004EE4C3 File Offset: 0x004EC6C3
		public void UnPackTo(IJigsawCompletedConfigT _o)
		{
			_o.IsSilentPiece = this.IsSilentPiece;
			_o.IsSilentFoundation = this.IsSilentFoundation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023ABB RID: 146107 RVA: 0x004EE4EC File Offset: 0x004EC6EC
		public static Offset<IJigsawCompletedConfig> Pack(FlatBufferBuilder builder, IJigsawCompletedConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJigsawCompletedConfig>);
			}
			return IJigsawCompletedConfig.CreateIJigsawCompletedConfig(builder, _o.IsSilentPiece, _o.IsSilentFoundation, _o.NullMask);
		}

		// Token: 0x0400E747 RID: 59207
		private Table __p;
	}
}

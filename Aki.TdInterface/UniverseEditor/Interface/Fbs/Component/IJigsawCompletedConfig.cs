using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A2C RID: 23084
	public struct IJigsawCompletedConfig : IFlatbufferObject
	{
		// Token: 0x1700A7C4 RID: 42948
		// (get) Token: 0x06025B62 RID: 154466 RVA: 0x0052B398 File Offset: 0x00529598
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025B63 RID: 154467 RVA: 0x0052B3A5 File Offset: 0x005295A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025B64 RID: 154468 RVA: 0x0052B3AC File Offset: 0x005295AC
		public static IJigsawCompletedConfig GetRootAsIJigsawCompletedConfig(ByteBuffer _bb)
		{
			return IJigsawCompletedConfig.GetRootAsIJigsawCompletedConfig(_bb, default(IJigsawCompletedConfig));
		}

		// Token: 0x06025B65 RID: 154469 RVA: 0x0052B3C8 File Offset: 0x005295C8
		public static IJigsawCompletedConfig GetRootAsIJigsawCompletedConfig(ByteBuffer _bb, IJigsawCompletedConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025B66 RID: 154470 RVA: 0x0052B3E5 File Offset: 0x005295E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025B67 RID: 154471 RVA: 0x0052B3F4 File Offset: 0x005295F4
		public IJigsawCompletedConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7C5 RID: 42949
		// (get) Token: 0x06025B68 RID: 154472 RVA: 0x0052B404 File Offset: 0x00529604
		public bool IsSilentPiece
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A7C6 RID: 42950
		// (get) Token: 0x06025B69 RID: 154473 RVA: 0x0052B444 File Offset: 0x00529644
		public bool IsSilentFoundation
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A7C7 RID: 42951
		// (get) Token: 0x06025B6A RID: 154474 RVA: 0x0052B484 File Offset: 0x00529684
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

		// Token: 0x06025B6B RID: 154475 RVA: 0x0052B4C0 File Offset: 0x005296C0
		public static Offset<IJigsawCompletedConfig> CreateIJigsawCompletedConfig(FlatBufferBuilder builder, bool IsSilentPiece = false, bool IsSilentFoundation = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IJigsawCompletedConfig.AddNullMask(builder, NullMask);
			IJigsawCompletedConfig.AddIsSilentFoundation(builder, IsSilentFoundation);
			IJigsawCompletedConfig.AddIsSilentPiece(builder, IsSilentPiece);
			return IJigsawCompletedConfig.EndIJigsawCompletedConfig(builder);
		}

		// Token: 0x06025B6C RID: 154476 RVA: 0x0052B4E4 File Offset: 0x005296E4
		public static void StartIJigsawCompletedConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025B6D RID: 154477 RVA: 0x0052B4ED File Offset: 0x005296ED
		public static void AddIsSilentPiece(FlatBufferBuilder builder, bool isSilentPiece)
		{
			builder.AddBool(0, isSilentPiece, false);
		}

		// Token: 0x06025B6E RID: 154478 RVA: 0x0052B4F8 File Offset: 0x005296F8
		public static void AddIsSilentFoundation(FlatBufferBuilder builder, bool isSilentFoundation)
		{
			builder.AddBool(1, isSilentFoundation, false);
		}

		// Token: 0x06025B6F RID: 154479 RVA: 0x0052B503 File Offset: 0x00529703
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06025B70 RID: 154480 RVA: 0x0052B50E File Offset: 0x0052970E
		public static Offset<IJigsawCompletedConfig> EndIJigsawCompletedConfig(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawCompletedConfig>(builder.EndTable());
		}

		// Token: 0x06025B71 RID: 154481 RVA: 0x0052B51C File Offset: 0x0052971C
		public IJigsawCompletedConfigT UnPack()
		{
			IJigsawCompletedConfigT jigsawCompletedConfigT = new IJigsawCompletedConfigT();
			this.UnPackTo(jigsawCompletedConfigT);
			return jigsawCompletedConfigT;
		}

		// Token: 0x06025B72 RID: 154482 RVA: 0x0052B537 File Offset: 0x00529737
		public void UnPackTo(IJigsawCompletedConfigT _o)
		{
			_o.IsSilentPiece = this.IsSilentPiece;
			_o.IsSilentFoundation = this.IsSilentFoundation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025B73 RID: 154483 RVA: 0x0052B560 File Offset: 0x00529760
		public static Offset<IJigsawCompletedConfig> Pack(FlatBufferBuilder builder, IJigsawCompletedConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJigsawCompletedConfig>);
			}
			return IJigsawCompletedConfig.CreateIJigsawCompletedConfig(builder, _o.IsSilentPiece, _o.IsSilentFoundation, _o.NullMask);
		}

		// Token: 0x0400F378 RID: 62328
		private Table __p;
	}
}

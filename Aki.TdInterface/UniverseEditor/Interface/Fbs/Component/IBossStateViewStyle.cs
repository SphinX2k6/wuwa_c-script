using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F1C RID: 20252
	public struct IBossStateViewStyle : IFlatbufferObject
	{
		// Token: 0x170091E3 RID: 37347
		// (get) Token: 0x0602007C RID: 131196 RVA: 0x00475159 File Offset: 0x00473359
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602007D RID: 131197 RVA: 0x00475166 File Offset: 0x00473366
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602007E RID: 131198 RVA: 0x00475170 File Offset: 0x00473370
		public static IBossStateViewStyle GetRootAsIBossStateViewStyle(ByteBuffer _bb)
		{
			return IBossStateViewStyle.GetRootAsIBossStateViewStyle(_bb, default(IBossStateViewStyle));
		}

		// Token: 0x0602007F RID: 131199 RVA: 0x0047518C File Offset: 0x0047338C
		public static IBossStateViewStyle GetRootAsIBossStateViewStyle(ByteBuffer _bb, IBossStateViewStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020080 RID: 131200 RVA: 0x004751A9 File Offset: 0x004733A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020081 RID: 131201 RVA: 0x004751B8 File Offset: 0x004733B8
		public IBossStateViewStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091E4 RID: 37348
		// (get) Token: 0x06020082 RID: 131202 RVA: 0x004751C8 File Offset: 0x004733C8
		public EBossStateViewStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBossStateViewStyle.DoubleView;
				}
				return (EBossStateViewStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020083 RID: 131203 RVA: 0x00475204 File Offset: 0x00473404
		public static Offset<IBossStateViewStyle> CreateIBossStateViewStyle(FlatBufferBuilder builder, EBossStateViewStyle Type = EBossStateViewStyle.DoubleView)
		{
			builder.StartTable(1);
			IBossStateViewStyle.AddType(builder, Type);
			return IBossStateViewStyle.EndIBossStateViewStyle(builder);
		}

		// Token: 0x06020084 RID: 131204 RVA: 0x0047521A File Offset: 0x0047341A
		public static void StartIBossStateViewStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020085 RID: 131205 RVA: 0x00475223 File Offset: 0x00473423
		public static void AddType(FlatBufferBuilder builder, EBossStateViewStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020086 RID: 131206 RVA: 0x0047522E File Offset: 0x0047342E
		public static Offset<IBossStateViewStyle> EndIBossStateViewStyle(FlatBufferBuilder builder)
		{
			return new Offset<IBossStateViewStyle>(builder.EndTable());
		}

		// Token: 0x06020087 RID: 131207 RVA: 0x0047523C File Offset: 0x0047343C
		public IBossStateViewStyleT UnPack()
		{
			IBossStateViewStyleT bossStateViewStyleT = new IBossStateViewStyleT();
			this.UnPackTo(bossStateViewStyleT);
			return bossStateViewStyleT;
		}

		// Token: 0x06020088 RID: 131208 RVA: 0x00475257 File Offset: 0x00473457
		public void UnPackTo(IBossStateViewStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020089 RID: 131209 RVA: 0x00475268 File Offset: 0x00473468
		public static Offset<IBossStateViewStyle> Pack(FlatBufferBuilder builder, IBossStateViewStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBossStateViewStyle>);
			}
			return IBossStateViewStyle.CreateIBossStateViewStyle(builder, _o.Type);
		}

		// Token: 0x0400DD71 RID: 56689
		private Table __p;
	}
}

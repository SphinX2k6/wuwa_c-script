using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070DC RID: 28892
	public struct ILimitPlayerUI : IFlatbufferObject
	{
		// Token: 0x1700D39A RID: 54170
		// (get) Token: 0x060322C6 RID: 205510 RVA: 0x006C9C76 File Offset: 0x006C7E76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060322C7 RID: 205511 RVA: 0x006C9C83 File Offset: 0x006C7E83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060322C8 RID: 205512 RVA: 0x006C9C8C File Offset: 0x006C7E8C
		public static ILimitPlayerUI GetRootAsILimitPlayerUI(ByteBuffer _bb)
		{
			return ILimitPlayerUI.GetRootAsILimitPlayerUI(_bb, default(ILimitPlayerUI));
		}

		// Token: 0x060322C9 RID: 205513 RVA: 0x006C9CA8 File Offset: 0x006C7EA8
		public static ILimitPlayerUI GetRootAsILimitPlayerUI(ByteBuffer _bb, ILimitPlayerUI obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060322CA RID: 205514 RVA: 0x006C9CC5 File Offset: 0x006C7EC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060322CB RID: 205515 RVA: 0x006C9CD4 File Offset: 0x006C7ED4
		public ILimitPlayerUI __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D39B RID: 54171
		// (get) Token: 0x060322CC RID: 205516 RVA: 0x006C9CE4 File Offset: 0x006C7EE4
		public ELimitPlayOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return (ELimitPlayOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060322CD RID: 205517 RVA: 0x006C9D20 File Offset: 0x006C7F20
		public static Offset<ILimitPlayerUI> CreateILimitPlayerUI(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera)
		{
			builder.StartTable(1);
			ILimitPlayerUI.AddType(builder, Type);
			return ILimitPlayerUI.EndILimitPlayerUI(builder);
		}

		// Token: 0x060322CE RID: 205518 RVA: 0x006C9D36 File Offset: 0x006C7F36
		public static void StartILimitPlayerUI(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060322CF RID: 205519 RVA: 0x006C9D3F File Offset: 0x006C7F3F
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060322D0 RID: 205520 RVA: 0x006C9D4A File Offset: 0x006C7F4A
		public static Offset<ILimitPlayerUI> EndILimitPlayerUI(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerUI>(builder.EndTable());
		}

		// Token: 0x060322D1 RID: 205521 RVA: 0x006C9D58 File Offset: 0x006C7F58
		public ILimitPlayerUIT UnPack()
		{
			ILimitPlayerUIT limitPlayerUIT = new ILimitPlayerUIT();
			this.UnPackTo(limitPlayerUIT);
			return limitPlayerUIT;
		}

		// Token: 0x060322D2 RID: 205522 RVA: 0x006C9D73 File Offset: 0x006C7F73
		public void UnPackTo(ILimitPlayerUIT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060322D3 RID: 205523 RVA: 0x006C9D84 File Offset: 0x006C7F84
		public static Offset<ILimitPlayerUI> Pack(FlatBufferBuilder builder, ILimitPlayerUIT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerUI>);
			}
			return ILimitPlayerUI.CreateILimitPlayerUI(builder, _o.Type);
		}

		// Token: 0x040120A5 RID: 73893
		private Table __p;
	}
}

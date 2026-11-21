using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E0E RID: 3598
	public struct HiddenBossWindow : IFlatbufferObject
	{
		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06008486 RID: 33926 RVA: 0x002726A1 File Offset: 0x002708A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008487 RID: 33927 RVA: 0x002726AE File Offset: 0x002708AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008488 RID: 33928 RVA: 0x002726B8 File Offset: 0x002708B8
		public static HiddenBossWindow GetRootAsHiddenBossWindow(ByteBuffer _bb)
		{
			return HiddenBossWindow.GetRootAsHiddenBossWindow(_bb, default(HiddenBossWindow));
		}

		// Token: 0x06008489 RID: 33929 RVA: 0x002726D4 File Offset: 0x002708D4
		public static HiddenBossWindow GetRootAsHiddenBossWindow(ByteBuffer _bb, HiddenBossWindow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600848A RID: 33930 RVA: 0x002726F1 File Offset: 0x002708F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600848B RID: 33931 RVA: 0x00272700 File Offset: 0x00270900
		public HiddenBossWindow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x0600848C RID: 33932 RVA: 0x00272710 File Offset: 0x00270910
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

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x0600848D RID: 33933 RVA: 0x0027274C File Offset: 0x0027094C
		public string BossName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600848E RID: 33934 RVA: 0x00272783 File Offset: 0x00270983
		public Span<byte> GetBossNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600848F RID: 33935 RVA: 0x00272792 File Offset: 0x00270992
		public byte[] GetBossNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06008490 RID: 33936 RVA: 0x002727AC File Offset: 0x002709AC
		public int MarkId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06008491 RID: 33937 RVA: 0x002727E8 File Offset: 0x002709E8
		public string IconRefPath
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008492 RID: 33938 RVA: 0x00272820 File Offset: 0x00270A20
		public Span<byte> GetIconRefPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008493 RID: 33939 RVA: 0x00272830 File Offset: 0x00270A30
		public byte[] GetIconRefPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005386 RID: 21382
		private Table __p;
	}
}

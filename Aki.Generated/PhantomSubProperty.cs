using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FDF RID: 4063
	public struct PhantomSubProperty : IFlatbufferObject
	{
		// Token: 0x170027CF RID: 10191
		// (get) Token: 0x0600B093 RID: 45203 RVA: 0x002D45B7 File Offset: 0x002D27B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B094 RID: 45204 RVA: 0x002D45C4 File Offset: 0x002D27C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B095 RID: 45205 RVA: 0x002D45CC File Offset: 0x002D27CC
		public static PhantomSubProperty GetRootAsPhantomSubProperty(ByteBuffer _bb)
		{
			return PhantomSubProperty.GetRootAsPhantomSubProperty(_bb, default(PhantomSubProperty));
		}

		// Token: 0x0600B096 RID: 45206 RVA: 0x002D45E8 File Offset: 0x002D27E8
		public static PhantomSubProperty GetRootAsPhantomSubProperty(ByteBuffer _bb, PhantomSubProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B097 RID: 45207 RVA: 0x002D4605 File Offset: 0x002D2805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B098 RID: 45208 RVA: 0x002D4614 File Offset: 0x002D2814
		public PhantomSubProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027D0 RID: 10192
		// (get) Token: 0x0600B099 RID: 45209 RVA: 0x002D4624 File Offset: 0x002D2824
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

		// Token: 0x170027D1 RID: 10193
		// (get) Token: 0x0600B09A RID: 45210 RVA: 0x002D4660 File Offset: 0x002D2860
		public int PropId
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

		// Token: 0x170027D2 RID: 10194
		// (get) Token: 0x0600B09B RID: 45211 RVA: 0x002D469C File Offset: 0x002D289C
		public int AddType
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

		// Token: 0x170027D3 RID: 10195
		// (get) Token: 0x0600B09C RID: 45212 RVA: 0x002D46D8 File Offset: 0x002D28D8
		public int SubStandardProperty
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040055A6 RID: 21926
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CB0 RID: 31920
	public struct IUniversalTone : IFlatbufferObject
	{
		// Token: 0x1700EEFC RID: 61180
		// (get) Token: 0x06039951 RID: 235857 RVA: 0x007C544A File Offset: 0x007C364A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039952 RID: 235858 RVA: 0x007C5457 File Offset: 0x007C3657
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039953 RID: 235859 RVA: 0x007C5460 File Offset: 0x007C3660
		public static IUniversalTone GetRootAsIUniversalTone(ByteBuffer _bb)
		{
			return IUniversalTone.GetRootAsIUniversalTone(_bb, default(IUniversalTone));
		}

		// Token: 0x06039954 RID: 235860 RVA: 0x007C547C File Offset: 0x007C367C
		public static IUniversalTone GetRootAsIUniversalTone(ByteBuffer _bb, IUniversalTone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039955 RID: 235861 RVA: 0x007C5499 File Offset: 0x007C3699
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039956 RID: 235862 RVA: 0x007C54A8 File Offset: 0x007C36A8
		public IUniversalTone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EEFD RID: 61181
		// (get) Token: 0x06039957 RID: 235863 RVA: 0x007C54B8 File Offset: 0x007C36B8
		public int UniversalToneId
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

		// Token: 0x1700EEFE RID: 61182
		// (get) Token: 0x06039958 RID: 235864 RVA: 0x007C54F4 File Offset: 0x007C36F4
		public int TimberId
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

		// Token: 0x1700EEFF RID: 61183
		// (get) Token: 0x06039959 RID: 235865 RVA: 0x007C5530 File Offset: 0x007C3730
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

		// Token: 0x0603995A RID: 235866 RVA: 0x007C556C File Offset: 0x007C376C
		public static Offset<IUniversalTone> CreateIUniversalTone(FlatBufferBuilder builder, int UniversalToneId = 0, int TimberId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IUniversalTone.AddTimberId(builder, TimberId);
			IUniversalTone.AddUniversalToneId(builder, UniversalToneId);
			IUniversalTone.AddNullMask(builder, NullMask);
			return IUniversalTone.EndIUniversalTone(builder);
		}

		// Token: 0x0603995B RID: 235867 RVA: 0x007C5590 File Offset: 0x007C3790
		public static void StartIUniversalTone(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603995C RID: 235868 RVA: 0x007C5599 File Offset: 0x007C3799
		public static void AddUniversalToneId(FlatBufferBuilder builder, int universalToneId)
		{
			builder.AddInt(0, universalToneId, 0);
		}

		// Token: 0x0603995D RID: 235869 RVA: 0x007C55A4 File Offset: 0x007C37A4
		public static void AddTimberId(FlatBufferBuilder builder, int timberId)
		{
			builder.AddInt(1, timberId, 0);
		}

		// Token: 0x0603995E RID: 235870 RVA: 0x007C55AF File Offset: 0x007C37AF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603995F RID: 235871 RVA: 0x007C55BA File Offset: 0x007C37BA
		public static Offset<IUniversalTone> EndIUniversalTone(FlatBufferBuilder builder)
		{
			return new Offset<IUniversalTone>(builder.EndTable());
		}

		// Token: 0x06039960 RID: 235872 RVA: 0x007C55C8 File Offset: 0x007C37C8
		public IUniversalToneT UnPack()
		{
			IUniversalToneT universalToneT = new IUniversalToneT();
			this.UnPackTo(universalToneT);
			return universalToneT;
		}

		// Token: 0x06039961 RID: 235873 RVA: 0x007C55E3 File Offset: 0x007C37E3
		public void UnPackTo(IUniversalToneT _o)
		{
			_o.UniversalToneId = this.UniversalToneId;
			_o.TimberId = this.TimberId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039962 RID: 235874 RVA: 0x007C560C File Offset: 0x007C380C
		public static Offset<IUniversalTone> Pack(FlatBufferBuilder builder, IUniversalToneT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUniversalTone>);
			}
			return IUniversalTone.CreateIUniversalTone(builder, _o.UniversalToneId, _o.TimberId, _o.NullMask);
		}

		// Token: 0x040133B4 RID: 78772
		private Table __p;
	}
}

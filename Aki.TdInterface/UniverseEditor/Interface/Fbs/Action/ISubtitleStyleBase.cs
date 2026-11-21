using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079F8 RID: 31224
	public struct ISubtitleStyleBase : IFlatbufferObject
	{
		// Token: 0x1700E4E0 RID: 58592
		// (get) Token: 0x06037052 RID: 225362 RVA: 0x0075AD81 File Offset: 0x00758F81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037053 RID: 225363 RVA: 0x0075AD8E File Offset: 0x00758F8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037054 RID: 225364 RVA: 0x0075AD98 File Offset: 0x00758F98
		public static ISubtitleStyleBase GetRootAsISubtitleStyleBase(ByteBuffer _bb)
		{
			return ISubtitleStyleBase.GetRootAsISubtitleStyleBase(_bb, default(ISubtitleStyleBase));
		}

		// Token: 0x06037055 RID: 225365 RVA: 0x0075ADB4 File Offset: 0x00758FB4
		public static ISubtitleStyleBase GetRootAsISubtitleStyleBase(ByteBuffer _bb, ISubtitleStyleBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037056 RID: 225366 RVA: 0x0075ADD1 File Offset: 0x00758FD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037057 RID: 225367 RVA: 0x0075ADE0 File Offset: 0x00758FE0
		public ISubtitleStyleBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4E1 RID: 58593
		// (get) Token: 0x06037058 RID: 225368 RVA: 0x0075ADF0 File Offset: 0x00758FF0
		public ESubtitleStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESubtitleStyle.LevelA;
				}
				return (ESubtitleStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06037059 RID: 225369 RVA: 0x0075AE2C File Offset: 0x0075902C
		public static Offset<ISubtitleStyleBase> CreateISubtitleStyleBase(FlatBufferBuilder builder, ESubtitleStyle Type = ESubtitleStyle.LevelA)
		{
			builder.StartTable(1);
			ISubtitleStyleBase.AddType(builder, Type);
			return ISubtitleStyleBase.EndISubtitleStyleBase(builder);
		}

		// Token: 0x0603705A RID: 225370 RVA: 0x0075AE42 File Offset: 0x00759042
		public static void StartISubtitleStyleBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603705B RID: 225371 RVA: 0x0075AE4B File Offset: 0x0075904B
		public static void AddType(FlatBufferBuilder builder, ESubtitleStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603705C RID: 225372 RVA: 0x0075AE56 File Offset: 0x00759056
		public static Offset<ISubtitleStyleBase> EndISubtitleStyleBase(FlatBufferBuilder builder)
		{
			return new Offset<ISubtitleStyleBase>(builder.EndTable());
		}

		// Token: 0x0603705D RID: 225373 RVA: 0x0075AE64 File Offset: 0x00759064
		public ISubtitleStyleBaseT UnPack()
		{
			ISubtitleStyleBaseT subtitleStyleBaseT = new ISubtitleStyleBaseT();
			this.UnPackTo(subtitleStyleBaseT);
			return subtitleStyleBaseT;
		}

		// Token: 0x0603705E RID: 225374 RVA: 0x0075AE7F File Offset: 0x0075907F
		public void UnPackTo(ISubtitleStyleBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603705F RID: 225375 RVA: 0x0075AE90 File Offset: 0x00759090
		public static Offset<ISubtitleStyleBase> Pack(FlatBufferBuilder builder, ISubtitleStyleBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubtitleStyleBase>);
			}
			return ISubtitleStyleBase.CreateISubtitleStyleBase(builder, _o.Type);
		}

		// Token: 0x04012D15 RID: 77077
		private Table __p;
	}
}

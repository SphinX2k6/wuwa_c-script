using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075FB RID: 30203
	public struct IWaitMovieModeBorderAnimFinished : IFlatbufferObject
	{
		// Token: 0x1700E572 RID: 58738
		// (get) Token: 0x0603704A RID: 225354 RVA: 0x00777063 File Offset: 0x00775263
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603704B RID: 225355 RVA: 0x00777070 File Offset: 0x00775270
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603704C RID: 225356 RVA: 0x00777078 File Offset: 0x00775278
		public static IWaitMovieModeBorderAnimFinished GetRootAsIWaitMovieModeBorderAnimFinished(ByteBuffer _bb)
		{
			return IWaitMovieModeBorderAnimFinished.GetRootAsIWaitMovieModeBorderAnimFinished(_bb, default(IWaitMovieModeBorderAnimFinished));
		}

		// Token: 0x0603704D RID: 225357 RVA: 0x00777094 File Offset: 0x00775294
		public static IWaitMovieModeBorderAnimFinished GetRootAsIWaitMovieModeBorderAnimFinished(ByteBuffer _bb, IWaitMovieModeBorderAnimFinished obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603704E RID: 225358 RVA: 0x007770B1 File Offset: 0x007752B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603704F RID: 225359 RVA: 0x007770C0 File Offset: 0x007752C0
		public IWaitMovieModeBorderAnimFinished __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E573 RID: 58739
		// (get) Token: 0x06037050 RID: 225360 RVA: 0x007770D0 File Offset: 0x007752D0
		public EEnterMovieModeDurationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnterMovieModeDurationType.BorderAnimFinished;
				}
				return (EEnterMovieModeDurationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06037051 RID: 225361 RVA: 0x0077710C File Offset: 0x0077530C
		public static Offset<IWaitMovieModeBorderAnimFinished> CreateIWaitMovieModeBorderAnimFinished(FlatBufferBuilder builder, EEnterMovieModeDurationType Type = EEnterMovieModeDurationType.BorderAnimFinished)
		{
			builder.StartTable(1);
			IWaitMovieModeBorderAnimFinished.AddType(builder, Type);
			return IWaitMovieModeBorderAnimFinished.EndIWaitMovieModeBorderAnimFinished(builder);
		}

		// Token: 0x06037052 RID: 225362 RVA: 0x00777122 File Offset: 0x00775322
		public static void StartIWaitMovieModeBorderAnimFinished(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06037053 RID: 225363 RVA: 0x0077712B File Offset: 0x0077532B
		public static void AddType(FlatBufferBuilder builder, EEnterMovieModeDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037054 RID: 225364 RVA: 0x00777136 File Offset: 0x00775336
		public static Offset<IWaitMovieModeBorderAnimFinished> EndIWaitMovieModeBorderAnimFinished(FlatBufferBuilder builder)
		{
			return new Offset<IWaitMovieModeBorderAnimFinished>(builder.EndTable());
		}

		// Token: 0x06037055 RID: 225365 RVA: 0x00777144 File Offset: 0x00775344
		public IWaitMovieModeBorderAnimFinishedT UnPack()
		{
			IWaitMovieModeBorderAnimFinishedT waitMovieModeBorderAnimFinishedT = new IWaitMovieModeBorderAnimFinishedT();
			this.UnPackTo(waitMovieModeBorderAnimFinishedT);
			return waitMovieModeBorderAnimFinishedT;
		}

		// Token: 0x06037056 RID: 225366 RVA: 0x0077715F File Offset: 0x0077535F
		public void UnPackTo(IWaitMovieModeBorderAnimFinishedT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06037057 RID: 225367 RVA: 0x00777170 File Offset: 0x00775370
		public static Offset<IWaitMovieModeBorderAnimFinished> Pack(FlatBufferBuilder builder, IWaitMovieModeBorderAnimFinishedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaitMovieModeBorderAnimFinished>);
			}
			return IWaitMovieModeBorderAnimFinished.CreateIWaitMovieModeBorderAnimFinished(builder, _o.Type);
		}

		// Token: 0x0401256E RID: 75118
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E09 RID: 32265
	public struct IWaitMovieModeBorderAnimFinished : IFlatbufferObject
	{
		// Token: 0x1700F1B0 RID: 61872
		// (get) Token: 0x0603A4EF RID: 238831 RVA: 0x007DB15F File Offset: 0x007D935F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A4F0 RID: 238832 RVA: 0x007DB16C File Offset: 0x007D936C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A4F1 RID: 238833 RVA: 0x007DB174 File Offset: 0x007D9374
		public static IWaitMovieModeBorderAnimFinished GetRootAsIWaitMovieModeBorderAnimFinished(ByteBuffer _bb)
		{
			return IWaitMovieModeBorderAnimFinished.GetRootAsIWaitMovieModeBorderAnimFinished(_bb, default(IWaitMovieModeBorderAnimFinished));
		}

		// Token: 0x0603A4F2 RID: 238834 RVA: 0x007DB190 File Offset: 0x007D9390
		public static IWaitMovieModeBorderAnimFinished GetRootAsIWaitMovieModeBorderAnimFinished(ByteBuffer _bb, IWaitMovieModeBorderAnimFinished obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A4F3 RID: 238835 RVA: 0x007DB1AD File Offset: 0x007D93AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A4F4 RID: 238836 RVA: 0x007DB1BC File Offset: 0x007D93BC
		public IWaitMovieModeBorderAnimFinished __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1B1 RID: 61873
		// (get) Token: 0x0603A4F5 RID: 238837 RVA: 0x007DB1CC File Offset: 0x007D93CC
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

		// Token: 0x0603A4F6 RID: 238838 RVA: 0x007DB208 File Offset: 0x007D9408
		public static Offset<IWaitMovieModeBorderAnimFinished> CreateIWaitMovieModeBorderAnimFinished(FlatBufferBuilder builder, EEnterMovieModeDurationType Type = EEnterMovieModeDurationType.BorderAnimFinished)
		{
			builder.StartTable(1);
			IWaitMovieModeBorderAnimFinished.AddType(builder, Type);
			return IWaitMovieModeBorderAnimFinished.EndIWaitMovieModeBorderAnimFinished(builder);
		}

		// Token: 0x0603A4F7 RID: 238839 RVA: 0x007DB21E File Offset: 0x007D941E
		public static void StartIWaitMovieModeBorderAnimFinished(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A4F8 RID: 238840 RVA: 0x007DB227 File Offset: 0x007D9427
		public static void AddType(FlatBufferBuilder builder, EEnterMovieModeDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A4F9 RID: 238841 RVA: 0x007DB232 File Offset: 0x007D9432
		public static Offset<IWaitMovieModeBorderAnimFinished> EndIWaitMovieModeBorderAnimFinished(FlatBufferBuilder builder)
		{
			return new Offset<IWaitMovieModeBorderAnimFinished>(builder.EndTable());
		}

		// Token: 0x0603A4FA RID: 238842 RVA: 0x007DB240 File Offset: 0x007D9440
		public IWaitMovieModeBorderAnimFinishedT UnPack()
		{
			IWaitMovieModeBorderAnimFinishedT waitMovieModeBorderAnimFinishedT = new IWaitMovieModeBorderAnimFinishedT();
			this.UnPackTo(waitMovieModeBorderAnimFinishedT);
			return waitMovieModeBorderAnimFinishedT;
		}

		// Token: 0x0603A4FB RID: 238843 RVA: 0x007DB25B File Offset: 0x007D945B
		public void UnPackTo(IWaitMovieModeBorderAnimFinishedT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A4FC RID: 238844 RVA: 0x007DB26C File Offset: 0x007D946C
		public static Offset<IWaitMovieModeBorderAnimFinished> Pack(FlatBufferBuilder builder, IWaitMovieModeBorderAnimFinishedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaitMovieModeBorderAnimFinished>);
			}
			return IWaitMovieModeBorderAnimFinished.CreateIWaitMovieModeBorderAnimFinished(builder, _o.Type);
		}

		// Token: 0x040135B8 RID: 79288
		private Table __p;
	}
}

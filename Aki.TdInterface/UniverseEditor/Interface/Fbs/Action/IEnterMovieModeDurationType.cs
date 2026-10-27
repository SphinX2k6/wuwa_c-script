using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066B7 RID: 26295
	public struct IEnterMovieModeDurationType : IFlatbufferObject
	{
		// Token: 0x1700C362 RID: 50018
		// (get) Token: 0x0602DB58 RID: 187224 RVA: 0x00641099 File Offset: 0x0063F299
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DB59 RID: 187225 RVA: 0x006410A6 File Offset: 0x0063F2A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DB5A RID: 187226 RVA: 0x006410B0 File Offset: 0x0063F2B0
		public static IEnterMovieModeDurationType GetRootAsIEnterMovieModeDurationType(ByteBuffer _bb)
		{
			return IEnterMovieModeDurationType.GetRootAsIEnterMovieModeDurationType(_bb, default(IEnterMovieModeDurationType));
		}

		// Token: 0x0602DB5B RID: 187227 RVA: 0x006410CC File Offset: 0x0063F2CC
		public static IEnterMovieModeDurationType GetRootAsIEnterMovieModeDurationType(ByteBuffer _bb, IEnterMovieModeDurationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DB5C RID: 187228 RVA: 0x006410E9 File Offset: 0x0063F2E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DB5D RID: 187229 RVA: 0x006410F8 File Offset: 0x0063F2F8
		public IEnterMovieModeDurationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C363 RID: 50019
		// (get) Token: 0x0602DB5E RID: 187230 RVA: 0x00641108 File Offset: 0x0063F308
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

		// Token: 0x0602DB5F RID: 187231 RVA: 0x00641144 File Offset: 0x0063F344
		public static Offset<IEnterMovieModeDurationType> CreateIEnterMovieModeDurationType(FlatBufferBuilder builder, EEnterMovieModeDurationType Type = EEnterMovieModeDurationType.BorderAnimFinished)
		{
			builder.StartTable(1);
			IEnterMovieModeDurationType.AddType(builder, Type);
			return IEnterMovieModeDurationType.EndIEnterMovieModeDurationType(builder);
		}

		// Token: 0x0602DB60 RID: 187232 RVA: 0x0064115A File Offset: 0x0063F35A
		public static void StartIEnterMovieModeDurationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DB61 RID: 187233 RVA: 0x00641163 File Offset: 0x0063F363
		public static void AddType(FlatBufferBuilder builder, EEnterMovieModeDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DB62 RID: 187234 RVA: 0x0064116E File Offset: 0x0063F36E
		public static Offset<IEnterMovieModeDurationType> EndIEnterMovieModeDurationType(FlatBufferBuilder builder)
		{
			return new Offset<IEnterMovieModeDurationType>(builder.EndTable());
		}

		// Token: 0x0602DB63 RID: 187235 RVA: 0x0064117C File Offset: 0x0063F37C
		public IEnterMovieModeDurationTypeT UnPack()
		{
			IEnterMovieModeDurationTypeT enterMovieModeDurationTypeT = new IEnterMovieModeDurationTypeT();
			this.UnPackTo(enterMovieModeDurationTypeT);
			return enterMovieModeDurationTypeT;
		}

		// Token: 0x0602DB64 RID: 187236 RVA: 0x00641197 File Offset: 0x0063F397
		public void UnPackTo(IEnterMovieModeDurationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DB65 RID: 187237 RVA: 0x006411A8 File Offset: 0x0063F3A8
		public static Offset<IEnterMovieModeDurationType> Pack(FlatBufferBuilder builder, IEnterMovieModeDurationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterMovieModeDurationType>);
			}
			return IEnterMovieModeDurationType.CreateIEnterMovieModeDurationType(builder, _o.Type);
		}

		// Token: 0x04010D78 RID: 68984
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D31 RID: 27953
	public struct IEnterMovieModeDurationType : IFlatbufferObject
	{
		// Token: 0x1700CD13 RID: 52499
		// (get) Token: 0x06030375 RID: 197493 RVA: 0x0068E34D File Offset: 0x0068C54D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030376 RID: 197494 RVA: 0x0068E35A File Offset: 0x0068C55A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030377 RID: 197495 RVA: 0x0068E364 File Offset: 0x0068C564
		public static IEnterMovieModeDurationType GetRootAsIEnterMovieModeDurationType(ByteBuffer _bb)
		{
			return IEnterMovieModeDurationType.GetRootAsIEnterMovieModeDurationType(_bb, default(IEnterMovieModeDurationType));
		}

		// Token: 0x06030378 RID: 197496 RVA: 0x0068E380 File Offset: 0x0068C580
		public static IEnterMovieModeDurationType GetRootAsIEnterMovieModeDurationType(ByteBuffer _bb, IEnterMovieModeDurationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030379 RID: 197497 RVA: 0x0068E39D File Offset: 0x0068C59D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603037A RID: 197498 RVA: 0x0068E3AC File Offset: 0x0068C5AC
		public IEnterMovieModeDurationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD14 RID: 52500
		// (get) Token: 0x0603037B RID: 197499 RVA: 0x0068E3BC File Offset: 0x0068C5BC
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

		// Token: 0x0603037C RID: 197500 RVA: 0x0068E3F8 File Offset: 0x0068C5F8
		public static Offset<IEnterMovieModeDurationType> CreateIEnterMovieModeDurationType(FlatBufferBuilder builder, EEnterMovieModeDurationType Type = EEnterMovieModeDurationType.BorderAnimFinished)
		{
			builder.StartTable(1);
			IEnterMovieModeDurationType.AddType(builder, Type);
			return IEnterMovieModeDurationType.EndIEnterMovieModeDurationType(builder);
		}

		// Token: 0x0603037D RID: 197501 RVA: 0x0068E40E File Offset: 0x0068C60E
		public static void StartIEnterMovieModeDurationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603037E RID: 197502 RVA: 0x0068E417 File Offset: 0x0068C617
		public static void AddType(FlatBufferBuilder builder, EEnterMovieModeDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603037F RID: 197503 RVA: 0x0068E422 File Offset: 0x0068C622
		public static Offset<IEnterMovieModeDurationType> EndIEnterMovieModeDurationType(FlatBufferBuilder builder)
		{
			return new Offset<IEnterMovieModeDurationType>(builder.EndTable());
		}

		// Token: 0x06030380 RID: 197504 RVA: 0x0068E430 File Offset: 0x0068C630
		public IEnterMovieModeDurationTypeT UnPack()
		{
			IEnterMovieModeDurationTypeT enterMovieModeDurationTypeT = new IEnterMovieModeDurationTypeT();
			this.UnPackTo(enterMovieModeDurationTypeT);
			return enterMovieModeDurationTypeT;
		}

		// Token: 0x06030381 RID: 197505 RVA: 0x0068E44B File Offset: 0x0068C64B
		public void UnPackTo(IEnterMovieModeDurationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030382 RID: 197506 RVA: 0x0068E45C File Offset: 0x0068C65C
		public static Offset<IEnterMovieModeDurationType> Pack(FlatBufferBuilder builder, IEnterMovieModeDurationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterMovieModeDurationType>);
			}
			return IEnterMovieModeDurationType.CreateIEnterMovieModeDurationType(builder, _o.Type);
		}

		// Token: 0x04011B9E RID: 72606
		private Table __p;
	}
}

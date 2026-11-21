using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FCB RID: 28619
	public struct IHonamiStoryActivateSafeEvacuation : IFlatbufferObject
	{
		// Token: 0x1700D1A5 RID: 53669
		// (get) Token: 0x0603194A RID: 203082 RVA: 0x006B7F27 File Offset: 0x006B6127
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603194B RID: 203083 RVA: 0x006B7F34 File Offset: 0x006B6134
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603194C RID: 203084 RVA: 0x006B7F3C File Offset: 0x006B613C
		public static IHonamiStoryActivateSafeEvacuation GetRootAsIHonamiStoryActivateSafeEvacuation(ByteBuffer _bb)
		{
			return IHonamiStoryActivateSafeEvacuation.GetRootAsIHonamiStoryActivateSafeEvacuation(_bb, default(IHonamiStoryActivateSafeEvacuation));
		}

		// Token: 0x0603194D RID: 203085 RVA: 0x006B7F58 File Offset: 0x006B6158
		public static IHonamiStoryActivateSafeEvacuation GetRootAsIHonamiStoryActivateSafeEvacuation(ByteBuffer _bb, IHonamiStoryActivateSafeEvacuation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603194E RID: 203086 RVA: 0x006B7F75 File Offset: 0x006B6175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603194F RID: 203087 RVA: 0x006B7F84 File Offset: 0x006B6184
		public IHonamiStoryActivateSafeEvacuation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06031950 RID: 203088 RVA: 0x006B7F94 File Offset: 0x006B6194
		public static void StartIHonamiStoryActivateSafeEvacuation(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06031951 RID: 203089 RVA: 0x006B7F9D File Offset: 0x006B619D
		public static Offset<IHonamiStoryActivateSafeEvacuation> EndIHonamiStoryActivateSafeEvacuation(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryActivateSafeEvacuation>(builder.EndTable());
		}

		// Token: 0x06031952 RID: 203090 RVA: 0x006B7FAC File Offset: 0x006B61AC
		public IHonamiStoryActivateSafeEvacuationT UnPack()
		{
			IHonamiStoryActivateSafeEvacuationT honamiStoryActivateSafeEvacuationT = new IHonamiStoryActivateSafeEvacuationT();
			this.UnPackTo(honamiStoryActivateSafeEvacuationT);
			return honamiStoryActivateSafeEvacuationT;
		}

		// Token: 0x06031953 RID: 203091 RVA: 0x006B7FC7 File Offset: 0x006B61C7
		public void UnPackTo(IHonamiStoryActivateSafeEvacuationT _o)
		{
		}

		// Token: 0x06031954 RID: 203092 RVA: 0x006B7FCC File Offset: 0x006B61CC
		public static Offset<IHonamiStoryActivateSafeEvacuation> Pack(FlatBufferBuilder builder, IHonamiStoryActivateSafeEvacuationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryActivateSafeEvacuation>);
			}
			IHonamiStoryActivateSafeEvacuation.StartIHonamiStoryActivateSafeEvacuation(builder);
			return IHonamiStoryActivateSafeEvacuation.EndIHonamiStoryActivateSafeEvacuation(builder);
		}

		// Token: 0x04011F01 RID: 73473
		private Table __p;
	}
}

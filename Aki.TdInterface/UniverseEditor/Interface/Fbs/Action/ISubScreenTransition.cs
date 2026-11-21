using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079F5 RID: 31221
	public struct ISubScreenTransition : IFlatbufferObject
	{
		// Token: 0x1700E4DB RID: 58587
		// (get) Token: 0x0603703A RID: 225338 RVA: 0x0075AB3E File Offset: 0x00758D3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603703B RID: 225339 RVA: 0x0075AB4B File Offset: 0x00758D4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603703C RID: 225340 RVA: 0x0075AB54 File Offset: 0x00758D54
		public static ISubScreenTransition GetRootAsISubScreenTransition(ByteBuffer _bb)
		{
			return ISubScreenTransition.GetRootAsISubScreenTransition(_bb, default(ISubScreenTransition));
		}

		// Token: 0x0603703D RID: 225341 RVA: 0x0075AB70 File Offset: 0x00758D70
		public static ISubScreenTransition GetRootAsISubScreenTransition(ByteBuffer _bb, ISubScreenTransition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603703E RID: 225342 RVA: 0x0075AB8D File Offset: 0x00758D8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603703F RID: 225343 RVA: 0x0075AB9C File Offset: 0x00758D9C
		public ISubScreenTransition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4DC RID: 58588
		// (get) Token: 0x06037040 RID: 225344 RVA: 0x0075ABAC File Offset: 0x00758DAC
		public float TransitionDuration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E4DD RID: 58589
		// (get) Token: 0x06037041 RID: 225345 RVA: 0x0075ABEC File Offset: 0x00758DEC
		public string TransitionCurve
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

		// Token: 0x06037042 RID: 225346 RVA: 0x0075AC23 File Offset: 0x00758E23
		public Span<byte> GetTransitionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06037043 RID: 225347 RVA: 0x0075AC32 File Offset: 0x00758E32
		public byte[] GetTransitionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06037044 RID: 225348 RVA: 0x0075AC40 File Offset: 0x00758E40
		public static Offset<ISubScreenTransition> CreateISubScreenTransition(FlatBufferBuilder builder, float TransitionDuration = 0f, StringOffset TransitionCurveOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISubScreenTransition.AddTransitionCurve(builder, TransitionCurveOffset);
			ISubScreenTransition.AddTransitionDuration(builder, TransitionDuration);
			return ISubScreenTransition.EndISubScreenTransition(builder);
		}

		// Token: 0x06037045 RID: 225349 RVA: 0x0075AC5D File Offset: 0x00758E5D
		public static void StartISubScreenTransition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06037046 RID: 225350 RVA: 0x0075AC66 File Offset: 0x00758E66
		public static void AddTransitionDuration(FlatBufferBuilder builder, float transitionDuration)
		{
			builder.AddFloat(0, transitionDuration, 0.0);
		}

		// Token: 0x06037047 RID: 225351 RVA: 0x0075AC79 File Offset: 0x00758E79
		public static void AddTransitionCurve(FlatBufferBuilder builder, StringOffset transitionCurveOffset)
		{
			builder.AddOffset(1, transitionCurveOffset.Value, 0);
		}

		// Token: 0x06037048 RID: 225352 RVA: 0x0075AC89 File Offset: 0x00758E89
		public static Offset<ISubScreenTransition> EndISubScreenTransition(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenTransition>(builder.EndTable());
		}

		// Token: 0x06037049 RID: 225353 RVA: 0x0075AC98 File Offset: 0x00758E98
		public ISubScreenTransitionT UnPack()
		{
			ISubScreenTransitionT subScreenTransitionT = new ISubScreenTransitionT();
			this.UnPackTo(subScreenTransitionT);
			return subScreenTransitionT;
		}

		// Token: 0x0603704A RID: 225354 RVA: 0x0075ACB3 File Offset: 0x00758EB3
		public void UnPackTo(ISubScreenTransitionT _o)
		{
			_o.TransitionDuration = this.TransitionDuration;
			_o.TransitionCurve = this.TransitionCurve;
		}

		// Token: 0x0603704B RID: 225355 RVA: 0x0075ACD0 File Offset: 0x00758ED0
		public static Offset<ISubScreenTransition> Pack(FlatBufferBuilder builder, ISubScreenTransitionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenTransition>);
			}
			StringOffset transitionCurveOffset = (_o.TransitionCurve == null) ? default(StringOffset) : builder.CreateString(_o.TransitionCurve);
			return ISubScreenTransition.CreateISubScreenTransition(builder, _o.TransitionDuration, transitionCurveOffset);
		}

		// Token: 0x04012D12 RID: 77074
		private Table __p;
	}
}

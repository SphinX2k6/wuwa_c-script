using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007220 RID: 29216
	public struct ISubScreenTransition : IFlatbufferObject
	{
		// Token: 0x1700D8E2 RID: 55522
		// (get) Token: 0x06033D38 RID: 212280 RVA: 0x006F97DE File Offset: 0x006F79DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033D39 RID: 212281 RVA: 0x006F97EB File Offset: 0x006F79EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033D3A RID: 212282 RVA: 0x006F97F4 File Offset: 0x006F79F4
		public static ISubScreenTransition GetRootAsISubScreenTransition(ByteBuffer _bb)
		{
			return ISubScreenTransition.GetRootAsISubScreenTransition(_bb, default(ISubScreenTransition));
		}

		// Token: 0x06033D3B RID: 212283 RVA: 0x006F9810 File Offset: 0x006F7A10
		public static ISubScreenTransition GetRootAsISubScreenTransition(ByteBuffer _bb, ISubScreenTransition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033D3C RID: 212284 RVA: 0x006F982D File Offset: 0x006F7A2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033D3D RID: 212285 RVA: 0x006F983C File Offset: 0x006F7A3C
		public ISubScreenTransition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8E3 RID: 55523
		// (get) Token: 0x06033D3E RID: 212286 RVA: 0x006F984C File Offset: 0x006F7A4C
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

		// Token: 0x1700D8E4 RID: 55524
		// (get) Token: 0x06033D3F RID: 212287 RVA: 0x006F988C File Offset: 0x006F7A8C
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

		// Token: 0x06033D40 RID: 212288 RVA: 0x006F98C3 File Offset: 0x006F7AC3
		public Span<byte> GetTransitionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033D41 RID: 212289 RVA: 0x006F98D2 File Offset: 0x006F7AD2
		public byte[] GetTransitionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06033D42 RID: 212290 RVA: 0x006F98E0 File Offset: 0x006F7AE0
		public static Offset<ISubScreenTransition> CreateISubScreenTransition(FlatBufferBuilder builder, float TransitionDuration = 0f, StringOffset TransitionCurveOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISubScreenTransition.AddTransitionCurve(builder, TransitionCurveOffset);
			ISubScreenTransition.AddTransitionDuration(builder, TransitionDuration);
			return ISubScreenTransition.EndISubScreenTransition(builder);
		}

		// Token: 0x06033D43 RID: 212291 RVA: 0x006F98FD File Offset: 0x006F7AFD
		public static void StartISubScreenTransition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033D44 RID: 212292 RVA: 0x006F9906 File Offset: 0x006F7B06
		public static void AddTransitionDuration(FlatBufferBuilder builder, float transitionDuration)
		{
			builder.AddFloat(0, transitionDuration, 0.0);
		}

		// Token: 0x06033D45 RID: 212293 RVA: 0x006F9919 File Offset: 0x006F7B19
		public static void AddTransitionCurve(FlatBufferBuilder builder, StringOffset transitionCurveOffset)
		{
			builder.AddOffset(1, transitionCurveOffset.Value, 0);
		}

		// Token: 0x06033D46 RID: 212294 RVA: 0x006F9929 File Offset: 0x006F7B29
		public static Offset<ISubScreenTransition> EndISubScreenTransition(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenTransition>(builder.EndTable());
		}

		// Token: 0x06033D47 RID: 212295 RVA: 0x006F9938 File Offset: 0x006F7B38
		public ISubScreenTransitionT UnPack()
		{
			ISubScreenTransitionT subScreenTransitionT = new ISubScreenTransitionT();
			this.UnPackTo(subScreenTransitionT);
			return subScreenTransitionT;
		}

		// Token: 0x06033D48 RID: 212296 RVA: 0x006F9953 File Offset: 0x006F7B53
		public void UnPackTo(ISubScreenTransitionT _o)
		{
			_o.TransitionDuration = this.TransitionDuration;
			_o.TransitionCurve = this.TransitionCurve;
		}

		// Token: 0x06033D49 RID: 212297 RVA: 0x006F9970 File Offset: 0x006F7B70
		public static Offset<ISubScreenTransition> Pack(FlatBufferBuilder builder, ISubScreenTransitionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenTransition>);
			}
			StringOffset transitionCurveOffset = (_o.TransitionCurve == null) ? default(StringOffset) : builder.CreateString(_o.TransitionCurve);
			return ISubScreenTransition.CreateISubScreenTransition(builder, _o.TransitionDuration, transitionCurveOffset);
		}

		// Token: 0x04011D10 RID: 72976
		private Table __p;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B58 RID: 23384
	public struct IMotorHookEndDir : IFlatbufferObject
	{
		// Token: 0x1700AABB RID: 43707
		// (get) Token: 0x060267BC RID: 157628 RVA: 0x0054535B File Offset: 0x0054355B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060267BD RID: 157629 RVA: 0x00545368 File Offset: 0x00543568
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060267BE RID: 157630 RVA: 0x00545370 File Offset: 0x00543570
		public static IMotorHookEndDir GetRootAsIMotorHookEndDir(ByteBuffer _bb)
		{
			return IMotorHookEndDir.GetRootAsIMotorHookEndDir(_bb, default(IMotorHookEndDir));
		}

		// Token: 0x060267BF RID: 157631 RVA: 0x0054538C File Offset: 0x0054358C
		public static IMotorHookEndDir GetRootAsIMotorHookEndDir(ByteBuffer _bb, IMotorHookEndDir obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060267C0 RID: 157632 RVA: 0x005453A9 File Offset: 0x005435A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060267C1 RID: 157633 RVA: 0x005453B8 File Offset: 0x005435B8
		public IMotorHookEndDir __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AABC RID: 43708
		// (get) Token: 0x060267C2 RID: 157634 RVA: 0x005453C8 File Offset: 0x005435C8
		public IVectorInfo? EndRot
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AABD RID: 43709
		// (get) Token: 0x060267C3 RID: 157635 RVA: 0x00545428 File Offset: 0x00543628
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

		// Token: 0x060267C4 RID: 157636 RVA: 0x0054545F File Offset: 0x0054365F
		public Span<byte> GetTransitionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060267C5 RID: 157637 RVA: 0x0054546E File Offset: 0x0054366E
		public byte[] GetTransitionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060267C6 RID: 157638 RVA: 0x0054547C File Offset: 0x0054367C
		public static Offset<IMotorHookEndDir> CreateIMotorHookEndDir(FlatBufferBuilder builder, Offset<IVectorInfo> EndRotOffset = default(Offset<IVectorInfo>), StringOffset TransitionCurveOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMotorHookEndDir.AddTransitionCurve(builder, TransitionCurveOffset);
			IMotorHookEndDir.AddEndRot(builder, EndRotOffset);
			return IMotorHookEndDir.EndIMotorHookEndDir(builder);
		}

		// Token: 0x060267C7 RID: 157639 RVA: 0x00545499 File Offset: 0x00543699
		public static void StartIMotorHookEndDir(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060267C8 RID: 157640 RVA: 0x005454A2 File Offset: 0x005436A2
		public static void AddEndRot(FlatBufferBuilder builder, Offset<IVectorInfo> endRotOffset)
		{
			builder.AddOffset(0, endRotOffset.Value, 0);
		}

		// Token: 0x060267C9 RID: 157641 RVA: 0x005454B2 File Offset: 0x005436B2
		public static void AddTransitionCurve(FlatBufferBuilder builder, StringOffset transitionCurveOffset)
		{
			builder.AddOffset(1, transitionCurveOffset.Value, 0);
		}

		// Token: 0x060267CA RID: 157642 RVA: 0x005454C2 File Offset: 0x005436C2
		public static Offset<IMotorHookEndDir> EndIMotorHookEndDir(FlatBufferBuilder builder)
		{
			return new Offset<IMotorHookEndDir>(builder.EndTable());
		}

		// Token: 0x060267CB RID: 157643 RVA: 0x005454D0 File Offset: 0x005436D0
		public IMotorHookEndDirT UnPack()
		{
			IMotorHookEndDirT motorHookEndDirT = new IMotorHookEndDirT();
			this.UnPackTo(motorHookEndDirT);
			return motorHookEndDirT;
		}

		// Token: 0x060267CC RID: 157644 RVA: 0x005454EC File Offset: 0x005436EC
		public void UnPackTo(IMotorHookEndDirT _o)
		{
			_o.EndRot = ((this.EndRot != null) ? this.EndRot.Value.UnPack() : null);
			_o.TransitionCurve = this.TransitionCurve;
		}

		// Token: 0x060267CD RID: 157645 RVA: 0x00545534 File Offset: 0x00543734
		public static Offset<IMotorHookEndDir> Pack(FlatBufferBuilder builder, IMotorHookEndDirT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorHookEndDir>);
			}
			Offset<IVectorInfo> endRotOffset = (_o.EndRot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.EndRot);
			StringOffset transitionCurveOffset = (_o.TransitionCurve == null) ? default(StringOffset) : builder.CreateString(_o.TransitionCurve);
			return IMotorHookEndDir.CreateIMotorHookEndDir(builder, endRotOffset, transitionCurveOffset);
		}

		// Token: 0x0400F563 RID: 62819
		private Table __p;
	}
}

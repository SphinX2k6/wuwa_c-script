using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055BA RID: 21946
	public struct IMotorHookEndDir : IFlatbufferObject
	{
		// Token: 0x1700A233 RID: 41523
		// (get) Token: 0x060245AF RID: 148911 RVA: 0x00504DE3 File Offset: 0x00502FE3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060245B0 RID: 148912 RVA: 0x00504DF0 File Offset: 0x00502FF0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060245B1 RID: 148913 RVA: 0x00504DF8 File Offset: 0x00502FF8
		public static IMotorHookEndDir GetRootAsIMotorHookEndDir(ByteBuffer _bb)
		{
			return IMotorHookEndDir.GetRootAsIMotorHookEndDir(_bb, default(IMotorHookEndDir));
		}

		// Token: 0x060245B2 RID: 148914 RVA: 0x00504E14 File Offset: 0x00503014
		public static IMotorHookEndDir GetRootAsIMotorHookEndDir(ByteBuffer _bb, IMotorHookEndDir obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060245B3 RID: 148915 RVA: 0x00504E31 File Offset: 0x00503031
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060245B4 RID: 148916 RVA: 0x00504E40 File Offset: 0x00503040
		public IMotorHookEndDir __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A234 RID: 41524
		// (get) Token: 0x060245B5 RID: 148917 RVA: 0x00504E50 File Offset: 0x00503050
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

		// Token: 0x1700A235 RID: 41525
		// (get) Token: 0x060245B6 RID: 148918 RVA: 0x00504EB0 File Offset: 0x005030B0
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

		// Token: 0x060245B7 RID: 148919 RVA: 0x00504EE7 File Offset: 0x005030E7
		public Span<byte> GetTransitionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060245B8 RID: 148920 RVA: 0x00504EF6 File Offset: 0x005030F6
		public byte[] GetTransitionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060245B9 RID: 148921 RVA: 0x00504F04 File Offset: 0x00503104
		public static Offset<IMotorHookEndDir> CreateIMotorHookEndDir(FlatBufferBuilder builder, Offset<IVectorInfo> EndRotOffset = default(Offset<IVectorInfo>), StringOffset TransitionCurveOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMotorHookEndDir.AddTransitionCurve(builder, TransitionCurveOffset);
			IMotorHookEndDir.AddEndRot(builder, EndRotOffset);
			return IMotorHookEndDir.EndIMotorHookEndDir(builder);
		}

		// Token: 0x060245BA RID: 148922 RVA: 0x00504F21 File Offset: 0x00503121
		public static void StartIMotorHookEndDir(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060245BB RID: 148923 RVA: 0x00504F2A File Offset: 0x0050312A
		public static void AddEndRot(FlatBufferBuilder builder, Offset<IVectorInfo> endRotOffset)
		{
			builder.AddOffset(0, endRotOffset.Value, 0);
		}

		// Token: 0x060245BC RID: 148924 RVA: 0x00504F3A File Offset: 0x0050313A
		public static void AddTransitionCurve(FlatBufferBuilder builder, StringOffset transitionCurveOffset)
		{
			builder.AddOffset(1, transitionCurveOffset.Value, 0);
		}

		// Token: 0x060245BD RID: 148925 RVA: 0x00504F4A File Offset: 0x0050314A
		public static Offset<IMotorHookEndDir> EndIMotorHookEndDir(FlatBufferBuilder builder)
		{
			return new Offset<IMotorHookEndDir>(builder.EndTable());
		}

		// Token: 0x060245BE RID: 148926 RVA: 0x00504F58 File Offset: 0x00503158
		public IMotorHookEndDirT UnPack()
		{
			IMotorHookEndDirT motorHookEndDirT = new IMotorHookEndDirT();
			this.UnPackTo(motorHookEndDirT);
			return motorHookEndDirT;
		}

		// Token: 0x060245BF RID: 148927 RVA: 0x00504F74 File Offset: 0x00503174
		public void UnPackTo(IMotorHookEndDirT _o)
		{
			_o.EndRot = ((this.EndRot != null) ? this.EndRot.Value.UnPack() : null);
			_o.TransitionCurve = this.TransitionCurve;
		}

		// Token: 0x060245C0 RID: 148928 RVA: 0x00504FBC File Offset: 0x005031BC
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

		// Token: 0x0400E901 RID: 59649
		private Table __p;
	}
}

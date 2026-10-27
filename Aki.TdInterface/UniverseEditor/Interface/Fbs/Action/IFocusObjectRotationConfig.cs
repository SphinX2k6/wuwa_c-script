using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200683D RID: 26685
	public struct IFocusObjectRotationConfig : IFlatbufferObject
	{
		// Token: 0x1700C63E RID: 50750
		// (get) Token: 0x0602E86D RID: 190573 RVA: 0x006593F3 File Offset: 0x006575F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E86E RID: 190574 RVA: 0x00659400 File Offset: 0x00657600
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E86F RID: 190575 RVA: 0x00659408 File Offset: 0x00657608
		public static IFocusObjectRotationConfig GetRootAsIFocusObjectRotationConfig(ByteBuffer _bb)
		{
			return IFocusObjectRotationConfig.GetRootAsIFocusObjectRotationConfig(_bb, default(IFocusObjectRotationConfig));
		}

		// Token: 0x0602E870 RID: 190576 RVA: 0x00659424 File Offset: 0x00657624
		public static IFocusObjectRotationConfig GetRootAsIFocusObjectRotationConfig(ByteBuffer _bb, IFocusObjectRotationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E871 RID: 190577 RVA: 0x00659441 File Offset: 0x00657641
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E872 RID: 190578 RVA: 0x00659450 File Offset: 0x00657650
		public IFocusObjectRotationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C63F RID: 50751
		// (get) Token: 0x0602E873 RID: 190579 RVA: 0x00659460 File Offset: 0x00657660
		public IVectorInfo? TargetRotation
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

		// Token: 0x1700C640 RID: 50752
		// (get) Token: 0x0602E874 RID: 190580 RVA: 0x006594C0 File Offset: 0x006576C0
		public string SpeedCurve
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

		// Token: 0x0602E875 RID: 190581 RVA: 0x006594F7 File Offset: 0x006576F7
		public Span<byte> GetSpeedCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E876 RID: 190582 RVA: 0x00659506 File Offset: 0x00657706
		public byte[] GetSpeedCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E877 RID: 190583 RVA: 0x00659514 File Offset: 0x00657714
		public static Offset<IFocusObjectRotationConfig> CreateIFocusObjectRotationConfig(FlatBufferBuilder builder, Offset<IVectorInfo> TargetRotationOffset = default(Offset<IVectorInfo>), StringOffset SpeedCurveOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFocusObjectRotationConfig.AddSpeedCurve(builder, SpeedCurveOffset);
			IFocusObjectRotationConfig.AddTargetRotation(builder, TargetRotationOffset);
			return IFocusObjectRotationConfig.EndIFocusObjectRotationConfig(builder);
		}

		// Token: 0x0602E878 RID: 190584 RVA: 0x00659531 File Offset: 0x00657731
		public static void StartIFocusObjectRotationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E879 RID: 190585 RVA: 0x0065953A File Offset: 0x0065773A
		public static void AddTargetRotation(FlatBufferBuilder builder, Offset<IVectorInfo> targetRotationOffset)
		{
			builder.AddOffset(0, targetRotationOffset.Value, 0);
		}

		// Token: 0x0602E87A RID: 190586 RVA: 0x0065954A File Offset: 0x0065774A
		public static void AddSpeedCurve(FlatBufferBuilder builder, StringOffset speedCurveOffset)
		{
			builder.AddOffset(1, speedCurveOffset.Value, 0);
		}

		// Token: 0x0602E87B RID: 190587 RVA: 0x0065955A File Offset: 0x0065775A
		public static Offset<IFocusObjectRotationConfig> EndIFocusObjectRotationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFocusObjectRotationConfig>(builder.EndTable());
		}

		// Token: 0x0602E87C RID: 190588 RVA: 0x00659568 File Offset: 0x00657768
		public IFocusObjectRotationConfigT UnPack()
		{
			IFocusObjectRotationConfigT focusObjectRotationConfigT = new IFocusObjectRotationConfigT();
			this.UnPackTo(focusObjectRotationConfigT);
			return focusObjectRotationConfigT;
		}

		// Token: 0x0602E87D RID: 190589 RVA: 0x00659584 File Offset: 0x00657784
		public void UnPackTo(IFocusObjectRotationConfigT _o)
		{
			_o.TargetRotation = ((this.TargetRotation != null) ? this.TargetRotation.Value.UnPack() : null);
			_o.SpeedCurve = this.SpeedCurve;
		}

		// Token: 0x0602E87E RID: 190590 RVA: 0x006595CC File Offset: 0x006577CC
		public static Offset<IFocusObjectRotationConfig> Pack(FlatBufferBuilder builder, IFocusObjectRotationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFocusObjectRotationConfig>);
			}
			Offset<IVectorInfo> targetRotationOffset = (_o.TargetRotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TargetRotation);
			StringOffset speedCurveOffset = (_o.SpeedCurve == null) ? default(StringOffset) : builder.CreateString(_o.SpeedCurve);
			return IFocusObjectRotationConfig.CreateIFocusObjectRotationConfig(builder, targetRotationOffset, speedCurveOffset);
		}

		// Token: 0x04010F86 RID: 69510
		private Table __p;
	}
}

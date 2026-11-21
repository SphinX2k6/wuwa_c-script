using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC3 RID: 28355
	public struct IFocusObjectRotationConfig : IFlatbufferObject
	{
		// Token: 0x1700D002 RID: 53250
		// (get) Token: 0x060310F5 RID: 200949 RVA: 0x006A7333 File Offset: 0x006A5533
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060310F6 RID: 200950 RVA: 0x006A7340 File Offset: 0x006A5540
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060310F7 RID: 200951 RVA: 0x006A7348 File Offset: 0x006A5548
		public static IFocusObjectRotationConfig GetRootAsIFocusObjectRotationConfig(ByteBuffer _bb)
		{
			return IFocusObjectRotationConfig.GetRootAsIFocusObjectRotationConfig(_bb, default(IFocusObjectRotationConfig));
		}

		// Token: 0x060310F8 RID: 200952 RVA: 0x006A7364 File Offset: 0x006A5564
		public static IFocusObjectRotationConfig GetRootAsIFocusObjectRotationConfig(ByteBuffer _bb, IFocusObjectRotationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060310F9 RID: 200953 RVA: 0x006A7381 File Offset: 0x006A5581
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060310FA RID: 200954 RVA: 0x006A7390 File Offset: 0x006A5590
		public IFocusObjectRotationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D003 RID: 53251
		// (get) Token: 0x060310FB RID: 200955 RVA: 0x006A73A0 File Offset: 0x006A55A0
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

		// Token: 0x1700D004 RID: 53252
		// (get) Token: 0x060310FC RID: 200956 RVA: 0x006A7400 File Offset: 0x006A5600
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

		// Token: 0x060310FD RID: 200957 RVA: 0x006A7437 File Offset: 0x006A5637
		public Span<byte> GetSpeedCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060310FE RID: 200958 RVA: 0x006A7446 File Offset: 0x006A5646
		public byte[] GetSpeedCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060310FF RID: 200959 RVA: 0x006A7454 File Offset: 0x006A5654
		public static Offset<IFocusObjectRotationConfig> CreateIFocusObjectRotationConfig(FlatBufferBuilder builder, Offset<IVectorInfo> TargetRotationOffset = default(Offset<IVectorInfo>), StringOffset SpeedCurveOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFocusObjectRotationConfig.AddSpeedCurve(builder, SpeedCurveOffset);
			IFocusObjectRotationConfig.AddTargetRotation(builder, TargetRotationOffset);
			return IFocusObjectRotationConfig.EndIFocusObjectRotationConfig(builder);
		}

		// Token: 0x06031100 RID: 200960 RVA: 0x006A7471 File Offset: 0x006A5671
		public static void StartIFocusObjectRotationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031101 RID: 200961 RVA: 0x006A747A File Offset: 0x006A567A
		public static void AddTargetRotation(FlatBufferBuilder builder, Offset<IVectorInfo> targetRotationOffset)
		{
			builder.AddOffset(0, targetRotationOffset.Value, 0);
		}

		// Token: 0x06031102 RID: 200962 RVA: 0x006A748A File Offset: 0x006A568A
		public static void AddSpeedCurve(FlatBufferBuilder builder, StringOffset speedCurveOffset)
		{
			builder.AddOffset(1, speedCurveOffset.Value, 0);
		}

		// Token: 0x06031103 RID: 200963 RVA: 0x006A749A File Offset: 0x006A569A
		public static Offset<IFocusObjectRotationConfig> EndIFocusObjectRotationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFocusObjectRotationConfig>(builder.EndTable());
		}

		// Token: 0x06031104 RID: 200964 RVA: 0x006A74A8 File Offset: 0x006A56A8
		public IFocusObjectRotationConfigT UnPack()
		{
			IFocusObjectRotationConfigT focusObjectRotationConfigT = new IFocusObjectRotationConfigT();
			this.UnPackTo(focusObjectRotationConfigT);
			return focusObjectRotationConfigT;
		}

		// Token: 0x06031105 RID: 200965 RVA: 0x006A74C4 File Offset: 0x006A56C4
		public void UnPackTo(IFocusObjectRotationConfigT _o)
		{
			_o.TargetRotation = ((this.TargetRotation != null) ? this.TargetRotation.Value.UnPack() : null);
			_o.SpeedCurve = this.SpeedCurve;
		}

		// Token: 0x06031106 RID: 200966 RVA: 0x006A750C File Offset: 0x006A570C
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

		// Token: 0x04011DC0 RID: 73152
		private Table __p;
	}
}

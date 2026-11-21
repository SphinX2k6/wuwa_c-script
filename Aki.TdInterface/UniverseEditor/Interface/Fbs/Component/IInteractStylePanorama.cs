using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A05 RID: 23045
	public struct IInteractStylePanorama : IFlatbufferObject
	{
		// Token: 0x1700A76E RID: 42862
		// (get) Token: 0x06025A0F RID: 154127 RVA: 0x00528ADC File Offset: 0x00526CDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025A10 RID: 154128 RVA: 0x00528AE9 File Offset: 0x00526CE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025A11 RID: 154129 RVA: 0x00528AF0 File Offset: 0x00526CF0
		public static IInteractStylePanorama GetRootAsIInteractStylePanorama(ByteBuffer _bb)
		{
			return IInteractStylePanorama.GetRootAsIInteractStylePanorama(_bb, default(IInteractStylePanorama));
		}

		// Token: 0x06025A12 RID: 154130 RVA: 0x00528B0C File Offset: 0x00526D0C
		public static IInteractStylePanorama GetRootAsIInteractStylePanorama(ByteBuffer _bb, IInteractStylePanorama obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025A13 RID: 154131 RVA: 0x00528B29 File Offset: 0x00526D29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025A14 RID: 154132 RVA: 0x00528B38 File Offset: 0x00526D38
		public IInteractStylePanorama __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A76F RID: 42863
		// (get) Token: 0x06025A15 RID: 154133 RVA: 0x00528B48 File Offset: 0x00526D48
		public EInteractStyleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractStyleType.Panorama;
				}
				return (EInteractStyleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A770 RID: 42864
		// (get) Token: 0x06025A16 RID: 154134 RVA: 0x00528B84 File Offset: 0x00526D84
		public IVectorInfo? TargetPos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A771 RID: 42865
		// (get) Token: 0x06025A17 RID: 154135 RVA: 0x00528BE4 File Offset: 0x00526DE4
		public int TriggerRange
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A772 RID: 42866
		// (get) Token: 0x06025A18 RID: 154136 RVA: 0x00528C20 File Offset: 0x00526E20
		public int TriggerAngle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A773 RID: 42867
		// (get) Token: 0x06025A19 RID: 154137 RVA: 0x00528C60 File Offset: 0x00526E60
		public int ProtectRange
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A774 RID: 42868
		// (get) Token: 0x06025A1A RID: 154138 RVA: 0x00528CA0 File Offset: 0x00526EA0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025A1B RID: 154139 RVA: 0x00528CDD File Offset: 0x00526EDD
		public static Offset<IInteractStylePanorama> CreateIInteractStylePanorama(FlatBufferBuilder builder, EInteractStyleType Type = EInteractStyleType.Panorama, Offset<IVectorInfo> TargetPosOffset = default(Offset<IVectorInfo>), int TriggerRange = 0, int TriggerAngle = 0, int ProtectRange = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IInteractStylePanorama.AddProtectRange(builder, ProtectRange);
			IInteractStylePanorama.AddTriggerAngle(builder, TriggerAngle);
			IInteractStylePanorama.AddTriggerRange(builder, TriggerRange);
			IInteractStylePanorama.AddTargetPos(builder, TargetPosOffset);
			IInteractStylePanorama.AddNullMask(builder, NullMask);
			IInteractStylePanorama.AddType(builder, Type);
			return IInteractStylePanorama.EndIInteractStylePanorama(builder);
		}

		// Token: 0x06025A1C RID: 154140 RVA: 0x00528D19 File Offset: 0x00526F19
		public static void StartIInteractStylePanorama(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06025A1D RID: 154141 RVA: 0x00528D22 File Offset: 0x00526F22
		public static void AddType(FlatBufferBuilder builder, EInteractStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025A1E RID: 154142 RVA: 0x00528D2D File Offset: 0x00526F2D
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IVectorInfo> targetPosOffset)
		{
			builder.AddOffset(1, targetPosOffset.Value, 0);
		}

		// Token: 0x06025A1F RID: 154143 RVA: 0x00528D3D File Offset: 0x00526F3D
		public static void AddTriggerRange(FlatBufferBuilder builder, int triggerRange)
		{
			builder.AddInt(2, triggerRange, 0);
		}

		// Token: 0x06025A20 RID: 154144 RVA: 0x00528D48 File Offset: 0x00526F48
		public static void AddTriggerAngle(FlatBufferBuilder builder, int triggerAngle)
		{
			builder.AddInt(3, triggerAngle, 0);
		}

		// Token: 0x06025A21 RID: 154145 RVA: 0x00528D53 File Offset: 0x00526F53
		public static void AddProtectRange(FlatBufferBuilder builder, int protectRange)
		{
			builder.AddInt(4, protectRange, 0);
		}

		// Token: 0x06025A22 RID: 154146 RVA: 0x00528D5E File Offset: 0x00526F5E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06025A23 RID: 154147 RVA: 0x00528D69 File Offset: 0x00526F69
		public static Offset<IInteractStylePanorama> EndIInteractStylePanorama(FlatBufferBuilder builder)
		{
			return new Offset<IInteractStylePanorama>(builder.EndTable());
		}

		// Token: 0x06025A24 RID: 154148 RVA: 0x00528D78 File Offset: 0x00526F78
		public IInteractStylePanoramaT UnPack()
		{
			IInteractStylePanoramaT interactStylePanoramaT = new IInteractStylePanoramaT();
			this.UnPackTo(interactStylePanoramaT);
			return interactStylePanoramaT;
		}

		// Token: 0x06025A25 RID: 154149 RVA: 0x00528D94 File Offset: 0x00526F94
		public void UnPackTo(IInteractStylePanoramaT _o)
		{
			_o.Type = this.Type;
			_o.TargetPos = ((this.TargetPos != null) ? this.TargetPos.Value.UnPack() : null);
			_o.TriggerRange = this.TriggerRange;
			_o.TriggerAngle = this.TriggerAngle;
			_o.ProtectRange = this.ProtectRange;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025A26 RID: 154150 RVA: 0x00528E0C File Offset: 0x0052700C
		public static Offset<IInteractStylePanorama> Pack(FlatBufferBuilder builder, IInteractStylePanoramaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractStylePanorama>);
			}
			Offset<IVectorInfo> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TargetPos);
			return IInteractStylePanorama.CreateIInteractStylePanorama(builder, _o.Type, targetPosOffset, _o.TriggerRange, _o.TriggerAngle, _o.ProtectRange, _o.NullMask);
		}

		// Token: 0x0400F333 RID: 62259
		private Table __p;
	}
}

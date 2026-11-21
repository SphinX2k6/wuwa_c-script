using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067CF RID: 26575
	public struct IAdjustPlayerCameraGravity : IFlatbufferObject
	{
		// Token: 0x1700C309 RID: 49929
		// (get) Token: 0x0602D55D RID: 185693 RVA: 0x0063517D File Offset: 0x0063337D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D55E RID: 185694 RVA: 0x0063518A File Offset: 0x0063338A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D55F RID: 185695 RVA: 0x00635194 File Offset: 0x00633394
		public static IAdjustPlayerCameraGravity GetRootAsIAdjustPlayerCameraGravity(ByteBuffer _bb)
		{
			return IAdjustPlayerCameraGravity.GetRootAsIAdjustPlayerCameraGravity(_bb, default(IAdjustPlayerCameraGravity));
		}

		// Token: 0x0602D560 RID: 185696 RVA: 0x006351B0 File Offset: 0x006333B0
		public static IAdjustPlayerCameraGravity GetRootAsIAdjustPlayerCameraGravity(ByteBuffer _bb, IAdjustPlayerCameraGravity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D561 RID: 185697 RVA: 0x006351CD File Offset: 0x006333CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D562 RID: 185698 RVA: 0x006351DC File Offset: 0x006333DC
		public IAdjustPlayerCameraGravity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C30A RID: 49930
		// (get) Token: 0x0602D563 RID: 185699 RVA: 0x006351EC File Offset: 0x006333EC
		public TGravityDirection GravityDirectionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TGravityDirection.NONE;
				}
				return (TGravityDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D564 RID: 185700 RVA: 0x00635228 File Offset: 0x00633428
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D565 RID: 185701 RVA: 0x0063526C File Offset: 0x0063346C
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602D566 RID: 185702 RVA: 0x00635288 File Offset: 0x00633488
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602D567 RID: 185703 RVA: 0x006352A4 File Offset: 0x006334A4
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602D568 RID: 185704 RVA: 0x006352C0 File Offset: 0x006334C0
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700C30B RID: 49931
		// (get) Token: 0x0602D569 RID: 185705 RVA: 0x006352DC File Offset: 0x006334DC
		public float LerpTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C30C RID: 49932
		// (get) Token: 0x0602D56A RID: 185706 RVA: 0x0063531C File Offset: 0x0063351C
		public string LerpCurve
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D56B RID: 185707 RVA: 0x00635354 File Offset: 0x00633554
		public Span<byte> GetLerpCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602D56C RID: 185708 RVA: 0x00635364 File Offset: 0x00633564
		public byte[] GetLerpCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0602D56D RID: 185709 RVA: 0x00635373 File Offset: 0x00633573
		public static Offset<IAdjustPlayerCameraGravity> CreateIAdjustPlayerCameraGravity(FlatBufferBuilder builder, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, float LerpTime = 0f, StringOffset LerpCurveOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IAdjustPlayerCameraGravity.AddLerpCurve(builder, LerpCurveOffset);
			IAdjustPlayerCameraGravity.AddLerpTime(builder, LerpTime);
			IAdjustPlayerCameraGravity.AddGravityDirection(builder, GravityDirectionOffset);
			IAdjustPlayerCameraGravity.AddGravityDirectionType(builder, GravityDirection_type);
			return IAdjustPlayerCameraGravity.EndIAdjustPlayerCameraGravity(builder);
		}

		// Token: 0x0602D56E RID: 185710 RVA: 0x0063539F File Offset: 0x0063359F
		public static void StartIAdjustPlayerCameraGravity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602D56F RID: 185711 RVA: 0x006353A8 File Offset: 0x006335A8
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(0, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602D570 RID: 185712 RVA: 0x006353B3 File Offset: 0x006335B3
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(1, gravityDirectionOffset, 0);
		}

		// Token: 0x0602D571 RID: 185713 RVA: 0x006353BE File Offset: 0x006335BE
		public static void AddLerpTime(FlatBufferBuilder builder, float lerpTime)
		{
			builder.AddFloat(2, lerpTime, 0.0);
		}

		// Token: 0x0602D572 RID: 185714 RVA: 0x006353D1 File Offset: 0x006335D1
		public static void AddLerpCurve(FlatBufferBuilder builder, StringOffset lerpCurveOffset)
		{
			builder.AddOffset(3, lerpCurveOffset.Value, 0);
		}

		// Token: 0x0602D573 RID: 185715 RVA: 0x006353E1 File Offset: 0x006335E1
		public static Offset<IAdjustPlayerCameraGravity> EndIAdjustPlayerCameraGravity(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustPlayerCameraGravity>(builder.EndTable());
		}

		// Token: 0x0602D574 RID: 185716 RVA: 0x006353F0 File Offset: 0x006335F0
		public IAdjustPlayerCameraGravityT UnPack()
		{
			IAdjustPlayerCameraGravityT adjustPlayerCameraGravityT = new IAdjustPlayerCameraGravityT();
			this.UnPackTo(adjustPlayerCameraGravityT);
			return adjustPlayerCameraGravityT;
		}

		// Token: 0x0602D575 RID: 185717 RVA: 0x0063540C File Offset: 0x0063360C
		public void UnPackTo(IAdjustPlayerCameraGravityT _o)
		{
			_o.GravityDirection = new TGravityDirectionUnion();
			_o.GravityDirection.Type = this.GravityDirectionType;
			switch (this.GravityDirectionType)
			{
			case TGravityDirection.IGravityDirectionByEntityGravity:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionByEntityGravity>() != null) ? this.GravityDirection<IGravityDirectionByEntityGravity>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionSelfRotation:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionSelfRotation>() != null) ? this.GravityDirection<IGravityDirectionSelfRotation>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionVectorInfo:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionVectorInfo>() != null) ? this.GravityDirection<IGravityDirectionVectorInfo>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionWorldAxis:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionWorldAxis>() != null) ? this.GravityDirection<IGravityDirectionWorldAxis>().Value.UnPack() : null);
				break;
			}
			_o.LerpTime = this.LerpTime;
			_o.LerpCurve = this.LerpCurve;
		}

		// Token: 0x0602D576 RID: 185718 RVA: 0x00635554 File Offset: 0x00633754
		public static Offset<IAdjustPlayerCameraGravity> Pack(FlatBufferBuilder builder, IAdjustPlayerCameraGravityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustPlayerCameraGravity>);
			}
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			StringOffset lerpCurveOffset = (_o.LerpCurve == null) ? default(StringOffset) : builder.CreateString(_o.LerpCurve);
			return IAdjustPlayerCameraGravity.CreateIAdjustPlayerCameraGravity(builder, gravityDirection_type, gravityDirectionOffset, _o.LerpTime, lerpCurveOffset);
		}

		// Token: 0x04011437 RID: 70711
		private Table __p;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200616A RID: 24938
	public struct IAdjustPlayerCameraGravity : IFlatbufferObject
	{
		// Token: 0x1700B999 RID: 47513
		// (get) Token: 0x0602AE64 RID: 175716 RVA: 0x005EAFA1 File Offset: 0x005E91A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AE65 RID: 175717 RVA: 0x005EAFAE File Offset: 0x005E91AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AE66 RID: 175718 RVA: 0x005EAFB8 File Offset: 0x005E91B8
		public static IAdjustPlayerCameraGravity GetRootAsIAdjustPlayerCameraGravity(ByteBuffer _bb)
		{
			return IAdjustPlayerCameraGravity.GetRootAsIAdjustPlayerCameraGravity(_bb, default(IAdjustPlayerCameraGravity));
		}

		// Token: 0x0602AE67 RID: 175719 RVA: 0x005EAFD4 File Offset: 0x005E91D4
		public static IAdjustPlayerCameraGravity GetRootAsIAdjustPlayerCameraGravity(ByteBuffer _bb, IAdjustPlayerCameraGravity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AE68 RID: 175720 RVA: 0x005EAFF1 File Offset: 0x005E91F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AE69 RID: 175721 RVA: 0x005EB000 File Offset: 0x005E9200
		public IAdjustPlayerCameraGravity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B99A RID: 47514
		// (get) Token: 0x0602AE6A RID: 175722 RVA: 0x005EB010 File Offset: 0x005E9210
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

		// Token: 0x0602AE6B RID: 175723 RVA: 0x005EB04C File Offset: 0x005E924C
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602AE6C RID: 175724 RVA: 0x005EB090 File Offset: 0x005E9290
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602AE6D RID: 175725 RVA: 0x005EB0AC File Offset: 0x005E92AC
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602AE6E RID: 175726 RVA: 0x005EB0C8 File Offset: 0x005E92C8
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602AE6F RID: 175727 RVA: 0x005EB0E4 File Offset: 0x005E92E4
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700B99B RID: 47515
		// (get) Token: 0x0602AE70 RID: 175728 RVA: 0x005EB100 File Offset: 0x005E9300
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

		// Token: 0x1700B99C RID: 47516
		// (get) Token: 0x0602AE71 RID: 175729 RVA: 0x005EB140 File Offset: 0x005E9340
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

		// Token: 0x0602AE72 RID: 175730 RVA: 0x005EB178 File Offset: 0x005E9378
		public Span<byte> GetLerpCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602AE73 RID: 175731 RVA: 0x005EB188 File Offset: 0x005E9388
		public byte[] GetLerpCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0602AE74 RID: 175732 RVA: 0x005EB197 File Offset: 0x005E9397
		public static Offset<IAdjustPlayerCameraGravity> CreateIAdjustPlayerCameraGravity(FlatBufferBuilder builder, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, float LerpTime = 0f, StringOffset LerpCurveOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IAdjustPlayerCameraGravity.AddLerpCurve(builder, LerpCurveOffset);
			IAdjustPlayerCameraGravity.AddLerpTime(builder, LerpTime);
			IAdjustPlayerCameraGravity.AddGravityDirection(builder, GravityDirectionOffset);
			IAdjustPlayerCameraGravity.AddGravityDirectionType(builder, GravityDirection_type);
			return IAdjustPlayerCameraGravity.EndIAdjustPlayerCameraGravity(builder);
		}

		// Token: 0x0602AE75 RID: 175733 RVA: 0x005EB1C3 File Offset: 0x005E93C3
		public static void StartIAdjustPlayerCameraGravity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602AE76 RID: 175734 RVA: 0x005EB1CC File Offset: 0x005E93CC
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(0, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602AE77 RID: 175735 RVA: 0x005EB1D7 File Offset: 0x005E93D7
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(1, gravityDirectionOffset, 0);
		}

		// Token: 0x0602AE78 RID: 175736 RVA: 0x005EB1E2 File Offset: 0x005E93E2
		public static void AddLerpTime(FlatBufferBuilder builder, float lerpTime)
		{
			builder.AddFloat(2, lerpTime, 0.0);
		}

		// Token: 0x0602AE79 RID: 175737 RVA: 0x005EB1F5 File Offset: 0x005E93F5
		public static void AddLerpCurve(FlatBufferBuilder builder, StringOffset lerpCurveOffset)
		{
			builder.AddOffset(3, lerpCurveOffset.Value, 0);
		}

		// Token: 0x0602AE7A RID: 175738 RVA: 0x005EB205 File Offset: 0x005E9405
		public static Offset<IAdjustPlayerCameraGravity> EndIAdjustPlayerCameraGravity(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustPlayerCameraGravity>(builder.EndTable());
		}

		// Token: 0x0602AE7B RID: 175739 RVA: 0x005EB214 File Offset: 0x005E9414
		public IAdjustPlayerCameraGravityT UnPack()
		{
			IAdjustPlayerCameraGravityT adjustPlayerCameraGravityT = new IAdjustPlayerCameraGravityT();
			this.UnPackTo(adjustPlayerCameraGravityT);
			return adjustPlayerCameraGravityT;
		}

		// Token: 0x0602AE7C RID: 175740 RVA: 0x005EB230 File Offset: 0x005E9430
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

		// Token: 0x0602AE7D RID: 175741 RVA: 0x005EB378 File Offset: 0x005E9578
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

		// Token: 0x04010630 RID: 67120
		private Table __p;
	}
}

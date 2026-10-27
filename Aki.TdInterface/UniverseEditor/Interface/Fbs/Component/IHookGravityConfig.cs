using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053BF RID: 21439
	public struct IHookGravityConfig : IFlatbufferObject
	{
		// Token: 0x17009D91 RID: 40337
		// (get) Token: 0x06023220 RID: 143904 RVA: 0x004DCF6A File Offset: 0x004DB16A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023221 RID: 143905 RVA: 0x004DCF77 File Offset: 0x004DB177
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023222 RID: 143906 RVA: 0x004DCF80 File Offset: 0x004DB180
		public static IHookGravityConfig GetRootAsIHookGravityConfig(ByteBuffer _bb)
		{
			return IHookGravityConfig.GetRootAsIHookGravityConfig(_bb, default(IHookGravityConfig));
		}

		// Token: 0x06023223 RID: 143907 RVA: 0x004DCF9C File Offset: 0x004DB19C
		public static IHookGravityConfig GetRootAsIHookGravityConfig(ByteBuffer _bb, IHookGravityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023224 RID: 143908 RVA: 0x004DCFB9 File Offset: 0x004DB1B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023225 RID: 143909 RVA: 0x004DCFC8 File Offset: 0x004DB1C8
		public IHookGravityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D92 RID: 40338
		// (get) Token: 0x06023226 RID: 143910 RVA: 0x004DCFD8 File Offset: 0x004DB1D8
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

		// Token: 0x06023227 RID: 143911 RVA: 0x004DD014 File Offset: 0x004DB214
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023228 RID: 143912 RVA: 0x004DD058 File Offset: 0x004DB258
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x06023229 RID: 143913 RVA: 0x004DD074 File Offset: 0x004DB274
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602322A RID: 143914 RVA: 0x004DD090 File Offset: 0x004DB290
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602322B RID: 143915 RVA: 0x004DD0AC File Offset: 0x004DB2AC
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x17009D93 RID: 40339
		// (get) Token: 0x0602322C RID: 143916 RVA: 0x004DD0C8 File Offset: 0x004DB2C8
		public int SafePointId
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

		// Token: 0x17009D94 RID: 40340
		// (get) Token: 0x0602322D RID: 143917 RVA: 0x004DD104 File Offset: 0x004DB304
		public int CameraLookAtPointId
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

		// Token: 0x17009D95 RID: 40341
		// (get) Token: 0x0602322E RID: 143918 RVA: 0x004DD144 File Offset: 0x004DB344
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602322F RID: 143919 RVA: 0x004DD181 File Offset: 0x004DB381
		public static Offset<IHookGravityConfig> CreateIHookGravityConfig(FlatBufferBuilder builder, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, int SafePointId = 0, int CameraLookAtPointId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IHookGravityConfig.AddCameraLookAtPointId(builder, CameraLookAtPointId);
			IHookGravityConfig.AddSafePointId(builder, SafePointId);
			IHookGravityConfig.AddGravityDirection(builder, GravityDirectionOffset);
			IHookGravityConfig.AddNullMask(builder, NullMask);
			IHookGravityConfig.AddGravityDirectionType(builder, GravityDirection_type);
			return IHookGravityConfig.EndIHookGravityConfig(builder);
		}

		// Token: 0x06023230 RID: 143920 RVA: 0x004DD1B5 File Offset: 0x004DB3B5
		public static void StartIHookGravityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06023231 RID: 143921 RVA: 0x004DD1BE File Offset: 0x004DB3BE
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(0, (byte)gravityDirectionType, 0);
		}

		// Token: 0x06023232 RID: 143922 RVA: 0x004DD1C9 File Offset: 0x004DB3C9
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(1, gravityDirectionOffset, 0);
		}

		// Token: 0x06023233 RID: 143923 RVA: 0x004DD1D4 File Offset: 0x004DB3D4
		public static void AddSafePointId(FlatBufferBuilder builder, int safePointId)
		{
			builder.AddInt(2, safePointId, 0);
		}

		// Token: 0x06023234 RID: 143924 RVA: 0x004DD1DF File Offset: 0x004DB3DF
		public static void AddCameraLookAtPointId(FlatBufferBuilder builder, int cameraLookAtPointId)
		{
			builder.AddInt(3, cameraLookAtPointId, 0);
		}

		// Token: 0x06023235 RID: 143925 RVA: 0x004DD1EA File Offset: 0x004DB3EA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06023236 RID: 143926 RVA: 0x004DD1F5 File Offset: 0x004DB3F5
		public static Offset<IHookGravityConfig> EndIHookGravityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IHookGravityConfig>(builder.EndTable());
		}

		// Token: 0x06023237 RID: 143927 RVA: 0x004DD204 File Offset: 0x004DB404
		public IHookGravityConfigT UnPack()
		{
			IHookGravityConfigT hookGravityConfigT = new IHookGravityConfigT();
			this.UnPackTo(hookGravityConfigT);
			return hookGravityConfigT;
		}

		// Token: 0x06023238 RID: 143928 RVA: 0x004DD220 File Offset: 0x004DB420
		public void UnPackTo(IHookGravityConfigT _o)
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
			_o.SafePointId = this.SafePointId;
			_o.CameraLookAtPointId = this.CameraLookAtPointId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023239 RID: 143929 RVA: 0x004DD374 File Offset: 0x004DB574
		public static Offset<IHookGravityConfig> Pack(FlatBufferBuilder builder, IHookGravityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookGravityConfig>);
			}
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			return IHookGravityConfig.CreateIHookGravityConfig(builder, gravityDirection_type, gravityDirectionOffset, _o.SafePointId, _o.CameraLookAtPointId, _o.NullMask);
		}

		// Token: 0x0400E5C1 RID: 58817
		private Table __p;
	}
}

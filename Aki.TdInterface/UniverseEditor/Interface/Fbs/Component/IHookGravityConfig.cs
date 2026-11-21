using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005945 RID: 22853
	public struct IHookGravityConfig : IFlatbufferObject
	{
		// Token: 0x1700A5C9 RID: 42441
		// (get) Token: 0x060252D4 RID: 152276 RVA: 0x00519E3E File Offset: 0x0051803E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060252D5 RID: 152277 RVA: 0x00519E4B File Offset: 0x0051804B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060252D6 RID: 152278 RVA: 0x00519E54 File Offset: 0x00518054
		public static IHookGravityConfig GetRootAsIHookGravityConfig(ByteBuffer _bb)
		{
			return IHookGravityConfig.GetRootAsIHookGravityConfig(_bb, default(IHookGravityConfig));
		}

		// Token: 0x060252D7 RID: 152279 RVA: 0x00519E70 File Offset: 0x00518070
		public static IHookGravityConfig GetRootAsIHookGravityConfig(ByteBuffer _bb, IHookGravityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060252D8 RID: 152280 RVA: 0x00519E8D File Offset: 0x0051808D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060252D9 RID: 152281 RVA: 0x00519E9C File Offset: 0x0051809C
		public IHookGravityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5CA RID: 42442
		// (get) Token: 0x060252DA RID: 152282 RVA: 0x00519EAC File Offset: 0x005180AC
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

		// Token: 0x060252DB RID: 152283 RVA: 0x00519EE8 File Offset: 0x005180E8
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060252DC RID: 152284 RVA: 0x00519F2C File Offset: 0x0051812C
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x060252DD RID: 152285 RVA: 0x00519F48 File Offset: 0x00518148
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x060252DE RID: 152286 RVA: 0x00519F64 File Offset: 0x00518164
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x060252DF RID: 152287 RVA: 0x00519F80 File Offset: 0x00518180
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700A5CB RID: 42443
		// (get) Token: 0x060252E0 RID: 152288 RVA: 0x00519F9C File Offset: 0x0051819C
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

		// Token: 0x1700A5CC RID: 42444
		// (get) Token: 0x060252E1 RID: 152289 RVA: 0x00519FD8 File Offset: 0x005181D8
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

		// Token: 0x1700A5CD RID: 42445
		// (get) Token: 0x060252E2 RID: 152290 RVA: 0x0051A018 File Offset: 0x00518218
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

		// Token: 0x060252E3 RID: 152291 RVA: 0x0051A055 File Offset: 0x00518255
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

		// Token: 0x060252E4 RID: 152292 RVA: 0x0051A089 File Offset: 0x00518289
		public static void StartIHookGravityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060252E5 RID: 152293 RVA: 0x0051A092 File Offset: 0x00518292
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(0, (byte)gravityDirectionType, 0);
		}

		// Token: 0x060252E6 RID: 152294 RVA: 0x0051A09D File Offset: 0x0051829D
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(1, gravityDirectionOffset, 0);
		}

		// Token: 0x060252E7 RID: 152295 RVA: 0x0051A0A8 File Offset: 0x005182A8
		public static void AddSafePointId(FlatBufferBuilder builder, int safePointId)
		{
			builder.AddInt(2, safePointId, 0);
		}

		// Token: 0x060252E8 RID: 152296 RVA: 0x0051A0B3 File Offset: 0x005182B3
		public static void AddCameraLookAtPointId(FlatBufferBuilder builder, int cameraLookAtPointId)
		{
			builder.AddInt(3, cameraLookAtPointId, 0);
		}

		// Token: 0x060252E9 RID: 152297 RVA: 0x0051A0BE File Offset: 0x005182BE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060252EA RID: 152298 RVA: 0x0051A0C9 File Offset: 0x005182C9
		public static Offset<IHookGravityConfig> EndIHookGravityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IHookGravityConfig>(builder.EndTable());
		}

		// Token: 0x060252EB RID: 152299 RVA: 0x0051A0D8 File Offset: 0x005182D8
		public IHookGravityConfigT UnPack()
		{
			IHookGravityConfigT hookGravityConfigT = new IHookGravityConfigT();
			this.UnPackTo(hookGravityConfigT);
			return hookGravityConfigT;
		}

		// Token: 0x060252EC RID: 152300 RVA: 0x0051A0F4 File Offset: 0x005182F4
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

		// Token: 0x060252ED RID: 152301 RVA: 0x0051A248 File Offset: 0x00518448
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

		// Token: 0x0400F1F1 RID: 61937
		private Table __p;
	}
}

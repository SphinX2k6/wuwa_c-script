using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E8E RID: 28302
	public struct IResetPlayerCameraFocus : IFlatbufferObject
	{
		// Token: 0x1700D2BC RID: 53948
		// (get) Token: 0x0603204B RID: 204875 RVA: 0x006C3EBA File Offset: 0x006C20BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603204C RID: 204876 RVA: 0x006C3EC7 File Offset: 0x006C20C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603204D RID: 204877 RVA: 0x006C3ED0 File Offset: 0x006C20D0
		public static IResetPlayerCameraFocus GetRootAsIResetPlayerCameraFocus(ByteBuffer _bb)
		{
			return IResetPlayerCameraFocus.GetRootAsIResetPlayerCameraFocus(_bb, default(IResetPlayerCameraFocus));
		}

		// Token: 0x0603204E RID: 204878 RVA: 0x006C3EEC File Offset: 0x006C20EC
		public static IResetPlayerCameraFocus GetRootAsIResetPlayerCameraFocus(ByteBuffer _bb, IResetPlayerCameraFocus obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603204F RID: 204879 RVA: 0x006C3F09 File Offset: 0x006C2109
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032050 RID: 204880 RVA: 0x006C3F18 File Offset: 0x006C2118
		public IResetPlayerCameraFocus __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2BD RID: 53949
		// (get) Token: 0x06032051 RID: 204881 RVA: 0x006C3F28 File Offset: 0x006C2128
		public TResetPlayerFocusType ResetTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TResetPlayerFocusType.NONE;
				}
				return (TResetPlayerFocusType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032052 RID: 204882 RVA: 0x006C3F64 File Offset: 0x006C2164
		public TTable? ResetType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032053 RID: 204883 RVA: 0x006C3FA8 File Offset: 0x006C21A8
		public IResetPlayerFocusToDefaultDirection ResetTypeAsIResetPlayerFocusToDefaultDirection()
		{
			return this.ResetType<IResetPlayerFocusToDefaultDirection>().Value;
		}

		// Token: 0x06032054 RID: 204884 RVA: 0x006C3FC4 File Offset: 0x006C21C4
		public IResetPlayerFocusToFixedDirection ResetTypeAsIResetPlayerFocusToFixedDirection()
		{
			return this.ResetType<IResetPlayerFocusToFixedDirection>().Value;
		}

		// Token: 0x1700D2BE RID: 53950
		// (get) Token: 0x06032055 RID: 204885 RVA: 0x006C3FE0 File Offset: 0x006C21E0
		public float FadeInTime
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

		// Token: 0x1700D2BF RID: 53951
		// (get) Token: 0x06032056 RID: 204886 RVA: 0x006C4020 File Offset: 0x006C2220
		public bool CannotInterrupt
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D2C0 RID: 53952
		// (get) Token: 0x06032057 RID: 204887 RVA: 0x006C4060 File Offset: 0x006C2260
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D2C1 RID: 53953
		// (get) Token: 0x06032058 RID: 204888 RVA: 0x006C40A4 File Offset: 0x006C22A4
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

		// Token: 0x06032059 RID: 204889 RVA: 0x006C40E1 File Offset: 0x006C22E1
		public static Offset<IResetPlayerCameraFocus> CreateIResetPlayerCameraFocus(FlatBufferBuilder builder, TResetPlayerFocusType ResetType_type = TResetPlayerFocusType.NONE, int ResetTypeOffset = 0, float FadeInTime = 0f, bool CannotInterrupt = false, float Duration = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IResetPlayerCameraFocus.AddDuration(builder, Duration);
			IResetPlayerCameraFocus.AddFadeInTime(builder, FadeInTime);
			IResetPlayerCameraFocus.AddResetType(builder, ResetTypeOffset);
			IResetPlayerCameraFocus.AddNullMask(builder, NullMask);
			IResetPlayerCameraFocus.AddCannotInterrupt(builder, CannotInterrupt);
			IResetPlayerCameraFocus.AddResetTypeType(builder, ResetType_type);
			return IResetPlayerCameraFocus.EndIResetPlayerCameraFocus(builder);
		}

		// Token: 0x0603205A RID: 204890 RVA: 0x006C411D File Offset: 0x006C231D
		public static void StartIResetPlayerCameraFocus(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0603205B RID: 204891 RVA: 0x006C4126 File Offset: 0x006C2326
		public static void AddResetTypeType(FlatBufferBuilder builder, TResetPlayerFocusType resetTypeType)
		{
			builder.AddByte(0, (byte)resetTypeType, 0);
		}

		// Token: 0x0603205C RID: 204892 RVA: 0x006C4131 File Offset: 0x006C2331
		public static void AddResetType(FlatBufferBuilder builder, int resetTypeOffset)
		{
			builder.AddOffset(1, resetTypeOffset, 0);
		}

		// Token: 0x0603205D RID: 204893 RVA: 0x006C413C File Offset: 0x006C233C
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0603205E RID: 204894 RVA: 0x006C414F File Offset: 0x006C234F
		public static void AddCannotInterrupt(FlatBufferBuilder builder, bool cannotInterrupt)
		{
			builder.AddBool(3, cannotInterrupt, false);
		}

		// Token: 0x0603205F RID: 204895 RVA: 0x006C415A File Offset: 0x006C235A
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(4, duration, 0.0);
		}

		// Token: 0x06032060 RID: 204896 RVA: 0x006C416D File Offset: 0x006C236D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06032061 RID: 204897 RVA: 0x006C4178 File Offset: 0x006C2378
		public static Offset<IResetPlayerCameraFocus> EndIResetPlayerCameraFocus(FlatBufferBuilder builder)
		{
			return new Offset<IResetPlayerCameraFocus>(builder.EndTable());
		}

		// Token: 0x06032062 RID: 204898 RVA: 0x006C4188 File Offset: 0x006C2388
		public IResetPlayerCameraFocusT UnPack()
		{
			IResetPlayerCameraFocusT resetPlayerCameraFocusT = new IResetPlayerCameraFocusT();
			this.UnPackTo(resetPlayerCameraFocusT);
			return resetPlayerCameraFocusT;
		}

		// Token: 0x06032063 RID: 204899 RVA: 0x006C41A4 File Offset: 0x006C23A4
		public void UnPackTo(IResetPlayerCameraFocusT _o)
		{
			_o.ResetType = new TResetPlayerFocusTypeUnion();
			_o.ResetType.Type = this.ResetTypeType;
			TResetPlayerFocusType resetTypeType = this.ResetTypeType;
			if (resetTypeType != TResetPlayerFocusType.IResetPlayerFocusToDefaultDirection)
			{
				if (resetTypeType == TResetPlayerFocusType.IResetPlayerFocusToFixedDirection)
				{
					_o.ResetType.Value = ((this.ResetType<IResetPlayerFocusToFixedDirection>() != null) ? this.ResetType<IResetPlayerFocusToFixedDirection>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.ResetType.Value = ((this.ResetType<IResetPlayerFocusToDefaultDirection>() != null) ? this.ResetType<IResetPlayerFocusToDefaultDirection>().Value.UnPack() : null);
			}
			_o.FadeInTime = this.FadeInTime;
			_o.CannotInterrupt = this.CannotInterrupt;
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032064 RID: 204900 RVA: 0x006C427C File Offset: 0x006C247C
		public static Offset<IResetPlayerCameraFocus> Pack(FlatBufferBuilder builder, IResetPlayerCameraFocusT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPlayerCameraFocus>);
			}
			TResetPlayerFocusType resetType_type = (_o.ResetType == null) ? TResetPlayerFocusType.NONE : _o.ResetType.Type;
			int resetTypeOffset = (_o.ResetType == null) ? 0 : TResetPlayerFocusTypeUnion.Pack(builder, _o.ResetType);
			return IResetPlayerCameraFocus.CreateIResetPlayerCameraFocus(builder, resetType_type, resetTypeOffset, _o.FadeInTime, _o.CannotInterrupt, _o.Duration, _o.NullMask);
		}

		// Token: 0x0401187A RID: 71802
		private Table __p;
	}
}

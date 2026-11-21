using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007612 RID: 30226
	public struct IResetPlayerCameraFocus : IFlatbufferObject
	{
		// Token: 0x1700DE13 RID: 56851
		// (get) Token: 0x0603508B RID: 217227 RVA: 0x0071FBEE File Offset: 0x0071DDEE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603508C RID: 217228 RVA: 0x0071FBFB File Offset: 0x0071DDFB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603508D RID: 217229 RVA: 0x0071FC04 File Offset: 0x0071DE04
		public static IResetPlayerCameraFocus GetRootAsIResetPlayerCameraFocus(ByteBuffer _bb)
		{
			return IResetPlayerCameraFocus.GetRootAsIResetPlayerCameraFocus(_bb, default(IResetPlayerCameraFocus));
		}

		// Token: 0x0603508E RID: 217230 RVA: 0x0071FC20 File Offset: 0x0071DE20
		public static IResetPlayerCameraFocus GetRootAsIResetPlayerCameraFocus(ByteBuffer _bb, IResetPlayerCameraFocus obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603508F RID: 217231 RVA: 0x0071FC3D File Offset: 0x0071DE3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035090 RID: 217232 RVA: 0x0071FC4C File Offset: 0x0071DE4C
		public IResetPlayerCameraFocus __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE14 RID: 56852
		// (get) Token: 0x06035091 RID: 217233 RVA: 0x0071FC5C File Offset: 0x0071DE5C
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

		// Token: 0x06035092 RID: 217234 RVA: 0x0071FC98 File Offset: 0x0071DE98
		public TTable? ResetType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035093 RID: 217235 RVA: 0x0071FCDC File Offset: 0x0071DEDC
		public IResetPlayerFocusToDefaultDirection ResetTypeAsIResetPlayerFocusToDefaultDirection()
		{
			return this.ResetType<IResetPlayerFocusToDefaultDirection>().Value;
		}

		// Token: 0x06035094 RID: 217236 RVA: 0x0071FCF8 File Offset: 0x0071DEF8
		public IResetPlayerFocusToFixedDirection ResetTypeAsIResetPlayerFocusToFixedDirection()
		{
			return this.ResetType<IResetPlayerFocusToFixedDirection>().Value;
		}

		// Token: 0x1700DE15 RID: 56853
		// (get) Token: 0x06035095 RID: 217237 RVA: 0x0071FD14 File Offset: 0x0071DF14
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

		// Token: 0x1700DE16 RID: 56854
		// (get) Token: 0x06035096 RID: 217238 RVA: 0x0071FD54 File Offset: 0x0071DF54
		public bool CannotInterrupt
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DE17 RID: 56855
		// (get) Token: 0x06035097 RID: 217239 RVA: 0x0071FD94 File Offset: 0x0071DF94
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

		// Token: 0x1700DE18 RID: 56856
		// (get) Token: 0x06035098 RID: 217240 RVA: 0x0071FDD8 File Offset: 0x0071DFD8
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

		// Token: 0x06035099 RID: 217241 RVA: 0x0071FE15 File Offset: 0x0071E015
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

		// Token: 0x0603509A RID: 217242 RVA: 0x0071FE51 File Offset: 0x0071E051
		public static void StartIResetPlayerCameraFocus(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0603509B RID: 217243 RVA: 0x0071FE5A File Offset: 0x0071E05A
		public static void AddResetTypeType(FlatBufferBuilder builder, TResetPlayerFocusType resetTypeType)
		{
			builder.AddByte(0, (byte)resetTypeType, 0);
		}

		// Token: 0x0603509C RID: 217244 RVA: 0x0071FE65 File Offset: 0x0071E065
		public static void AddResetType(FlatBufferBuilder builder, int resetTypeOffset)
		{
			builder.AddOffset(1, resetTypeOffset, 0);
		}

		// Token: 0x0603509D RID: 217245 RVA: 0x0071FE70 File Offset: 0x0071E070
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0603509E RID: 217246 RVA: 0x0071FE83 File Offset: 0x0071E083
		public static void AddCannotInterrupt(FlatBufferBuilder builder, bool cannotInterrupt)
		{
			builder.AddBool(3, cannotInterrupt, false);
		}

		// Token: 0x0603509F RID: 217247 RVA: 0x0071FE8E File Offset: 0x0071E08E
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(4, duration, 0.0);
		}

		// Token: 0x060350A0 RID: 217248 RVA: 0x0071FEA1 File Offset: 0x0071E0A1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060350A1 RID: 217249 RVA: 0x0071FEAC File Offset: 0x0071E0AC
		public static Offset<IResetPlayerCameraFocus> EndIResetPlayerCameraFocus(FlatBufferBuilder builder)
		{
			return new Offset<IResetPlayerCameraFocus>(builder.EndTable());
		}

		// Token: 0x060350A2 RID: 217250 RVA: 0x0071FEBC File Offset: 0x0071E0BC
		public IResetPlayerCameraFocusT UnPack()
		{
			IResetPlayerCameraFocusT resetPlayerCameraFocusT = new IResetPlayerCameraFocusT();
			this.UnPackTo(resetPlayerCameraFocusT);
			return resetPlayerCameraFocusT;
		}

		// Token: 0x060350A3 RID: 217251 RVA: 0x0071FED8 File Offset: 0x0071E0D8
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

		// Token: 0x060350A4 RID: 217252 RVA: 0x0071FFB0 File Offset: 0x0071E1B0
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

		// Token: 0x040127FF RID: 75775
		private Table __p;
	}
}

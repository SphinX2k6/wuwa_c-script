using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF6 RID: 23286
	public struct ITurntableControlType : IFlatbufferObject
	{
		// Token: 0x1700AFAC RID: 44972
		// (get) Token: 0x06027C0A RID: 162826 RVA: 0x00577D9C File Offset: 0x00575F9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027C0B RID: 162827 RVA: 0x00577DA9 File Offset: 0x00575FA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027C0C RID: 162828 RVA: 0x00577DB0 File Offset: 0x00575FB0
		public static ITurntableControlType GetRootAsITurntableControlType(ByteBuffer _bb)
		{
			return ITurntableControlType.GetRootAsITurntableControlType(_bb, default(ITurntableControlType));
		}

		// Token: 0x06027C0D RID: 162829 RVA: 0x00577DCC File Offset: 0x00575FCC
		public static ITurntableControlType GetRootAsITurntableControlType(ByteBuffer _bb, ITurntableControlType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027C0E RID: 162830 RVA: 0x00577DE9 File Offset: 0x00575FE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027C0F RID: 162831 RVA: 0x00577DF8 File Offset: 0x00575FF8
		public ITurntableControlType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFAD RID: 44973
		// (get) Token: 0x06027C10 RID: 162832 RVA: 0x00577E08 File Offset: 0x00576008
		public EControllerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EControllerType.FreeAngle;
				}
				return (EControllerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AFAE RID: 44974
		// (get) Token: 0x06027C11 RID: 162833 RVA: 0x00577E44 File Offset: 0x00576044
		public int RotationSpeed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027C12 RID: 162834 RVA: 0x00577E80 File Offset: 0x00576080
		public static Offset<ITurntableControlType> CreateITurntableControlType(FlatBufferBuilder builder, EControllerType Type = EControllerType.FreeAngle, int RotationSpeed = 0)
		{
			builder.StartTable(2);
			ITurntableControlType.AddRotationSpeed(builder, RotationSpeed);
			ITurntableControlType.AddType(builder, Type);
			return ITurntableControlType.EndITurntableControlType(builder);
		}

		// Token: 0x06027C13 RID: 162835 RVA: 0x00577E9D File Offset: 0x0057609D
		public static void StartITurntableControlType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027C14 RID: 162836 RVA: 0x00577EA6 File Offset: 0x005760A6
		public static void AddType(FlatBufferBuilder builder, EControllerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027C15 RID: 162837 RVA: 0x00577EB1 File Offset: 0x005760B1
		public static void AddRotationSpeed(FlatBufferBuilder builder, int rotationSpeed)
		{
			builder.AddInt(1, rotationSpeed, 0);
		}

		// Token: 0x06027C16 RID: 162838 RVA: 0x00577EBC File Offset: 0x005760BC
		public static Offset<ITurntableControlType> EndITurntableControlType(FlatBufferBuilder builder)
		{
			return new Offset<ITurntableControlType>(builder.EndTable());
		}

		// Token: 0x06027C17 RID: 162839 RVA: 0x00577ECC File Offset: 0x005760CC
		public ITurntableControlTypeT UnPack()
		{
			ITurntableControlTypeT turntableControlTypeT = new ITurntableControlTypeT();
			this.UnPackTo(turntableControlTypeT);
			return turntableControlTypeT;
		}

		// Token: 0x06027C18 RID: 162840 RVA: 0x00577EE7 File Offset: 0x005760E7
		public void UnPackTo(ITurntableControlTypeT _o)
		{
			_o.Type = this.Type;
			_o.RotationSpeed = this.RotationSpeed;
		}

		// Token: 0x06027C19 RID: 162841 RVA: 0x00577F04 File Offset: 0x00576104
		public static Offset<ITurntableControlType> Pack(FlatBufferBuilder builder, ITurntableControlTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITurntableControlType>);
			}
			return ITurntableControlType.CreateITurntableControlType(builder, _o.Type, _o.RotationSpeed);
		}

		// Token: 0x0400F1F1 RID: 61937
		private Table __p;
	}
}

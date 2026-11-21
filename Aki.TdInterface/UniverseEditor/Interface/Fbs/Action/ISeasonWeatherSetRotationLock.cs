using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007711 RID: 30481
	public struct ISeasonWeatherSetRotationLock : IFlatbufferObject
	{
		// Token: 0x1700DF8B RID: 57227
		// (get) Token: 0x060357B3 RID: 219059 RVA: 0x0072BBC4 File Offset: 0x00729DC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060357B4 RID: 219060 RVA: 0x0072BBD1 File Offset: 0x00729DD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060357B5 RID: 219061 RVA: 0x0072BBD8 File Offset: 0x00729DD8
		public static ISeasonWeatherSetRotationLock GetRootAsISeasonWeatherSetRotationLock(ByteBuffer _bb)
		{
			return ISeasonWeatherSetRotationLock.GetRootAsISeasonWeatherSetRotationLock(_bb, default(ISeasonWeatherSetRotationLock));
		}

		// Token: 0x060357B6 RID: 219062 RVA: 0x0072BBF4 File Offset: 0x00729DF4
		public static ISeasonWeatherSetRotationLock GetRootAsISeasonWeatherSetRotationLock(ByteBuffer _bb, ISeasonWeatherSetRotationLock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060357B7 RID: 219063 RVA: 0x0072BC11 File Offset: 0x00729E11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060357B8 RID: 219064 RVA: 0x0072BC20 File Offset: 0x00729E20
		public ISeasonWeatherSetRotationLock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF8C RID: 57228
		// (get) Token: 0x060357B9 RID: 219065 RVA: 0x0072BC30 File Offset: 0x00729E30
		public bool IsLocked
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060357BA RID: 219066 RVA: 0x0072BC6F File Offset: 0x00729E6F
		public static Offset<ISeasonWeatherSetRotationLock> CreateISeasonWeatherSetRotationLock(FlatBufferBuilder builder, bool IsLocked = false)
		{
			builder.StartTable(1);
			ISeasonWeatherSetRotationLock.AddIsLocked(builder, IsLocked);
			return ISeasonWeatherSetRotationLock.EndISeasonWeatherSetRotationLock(builder);
		}

		// Token: 0x060357BB RID: 219067 RVA: 0x0072BC85 File Offset: 0x00729E85
		public static void StartISeasonWeatherSetRotationLock(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060357BC RID: 219068 RVA: 0x0072BC8E File Offset: 0x00729E8E
		public static void AddIsLocked(FlatBufferBuilder builder, bool isLocked)
		{
			builder.AddBool(0, isLocked, false);
		}

		// Token: 0x060357BD RID: 219069 RVA: 0x0072BC99 File Offset: 0x00729E99
		public static Offset<ISeasonWeatherSetRotationLock> EndISeasonWeatherSetRotationLock(FlatBufferBuilder builder)
		{
			return new Offset<ISeasonWeatherSetRotationLock>(builder.EndTable());
		}

		// Token: 0x060357BE RID: 219070 RVA: 0x0072BCA8 File Offset: 0x00729EA8
		public ISeasonWeatherSetRotationLockT UnPack()
		{
			ISeasonWeatherSetRotationLockT seasonWeatherSetRotationLockT = new ISeasonWeatherSetRotationLockT();
			this.UnPackTo(seasonWeatherSetRotationLockT);
			return seasonWeatherSetRotationLockT;
		}

		// Token: 0x060357BF RID: 219071 RVA: 0x0072BCC3 File Offset: 0x00729EC3
		public void UnPackTo(ISeasonWeatherSetRotationLockT _o)
		{
			_o.IsLocked = this.IsLocked;
		}

		// Token: 0x060357C0 RID: 219072 RVA: 0x0072BCD4 File Offset: 0x00729ED4
		public static Offset<ISeasonWeatherSetRotationLock> Pack(FlatBufferBuilder builder, ISeasonWeatherSetRotationLockT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISeasonWeatherSetRotationLock>);
			}
			return ISeasonWeatherSetRotationLock.CreateISeasonWeatherSetRotationLock(builder, _o.IsLocked);
		}

		// Token: 0x0401292B RID: 76075
		private Table __p;
	}
}

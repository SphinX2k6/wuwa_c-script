using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007025 RID: 28709
	public struct ISetMotorSpeedType : IFlatbufferObject
	{
		// Token: 0x1700D537 RID: 54583
		// (get) Token: 0x06032C99 RID: 208025 RVA: 0x006DA036 File Offset: 0x006D8236
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032C9A RID: 208026 RVA: 0x006DA043 File Offset: 0x006D8243
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032C9B RID: 208027 RVA: 0x006DA04C File Offset: 0x006D824C
		public static ISetMotorSpeedType GetRootAsISetMotorSpeedType(ByteBuffer _bb)
		{
			return ISetMotorSpeedType.GetRootAsISetMotorSpeedType(_bb, default(ISetMotorSpeedType));
		}

		// Token: 0x06032C9C RID: 208028 RVA: 0x006DA068 File Offset: 0x006D8268
		public static ISetMotorSpeedType GetRootAsISetMotorSpeedType(ByteBuffer _bb, ISetMotorSpeedType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032C9D RID: 208029 RVA: 0x006DA085 File Offset: 0x006D8285
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032C9E RID: 208030 RVA: 0x006DA094 File Offset: 0x006D8294
		public ISetMotorSpeedType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D538 RID: 54584
		// (get) Token: 0x06032C9F RID: 208031 RVA: 0x006DA0A4 File Offset: 0x006D82A4
		public EMotorSpeedType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorSpeedType.TargetSpeed;
				}
				return (EMotorSpeedType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032CA0 RID: 208032 RVA: 0x006DA0E0 File Offset: 0x006D82E0
		public static Offset<ISetMotorSpeedType> CreateISetMotorSpeedType(FlatBufferBuilder builder, EMotorSpeedType Type = EMotorSpeedType.TargetSpeed)
		{
			builder.StartTable(1);
			ISetMotorSpeedType.AddType(builder, Type);
			return ISetMotorSpeedType.EndISetMotorSpeedType(builder);
		}

		// Token: 0x06032CA1 RID: 208033 RVA: 0x006DA0F6 File Offset: 0x006D82F6
		public static void StartISetMotorSpeedType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032CA2 RID: 208034 RVA: 0x006DA0FF File Offset: 0x006D82FF
		public static void AddType(FlatBufferBuilder builder, EMotorSpeedType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032CA3 RID: 208035 RVA: 0x006DA10A File Offset: 0x006D830A
		public static Offset<ISetMotorSpeedType> EndISetMotorSpeedType(FlatBufferBuilder builder)
		{
			return new Offset<ISetMotorSpeedType>(builder.EndTable());
		}

		// Token: 0x06032CA4 RID: 208036 RVA: 0x006DA118 File Offset: 0x006D8318
		public ISetMotorSpeedTypeT UnPack()
		{
			ISetMotorSpeedTypeT setMotorSpeedTypeT = new ISetMotorSpeedTypeT();
			this.UnPackTo(setMotorSpeedTypeT);
			return setMotorSpeedTypeT;
		}

		// Token: 0x06032CA5 RID: 208037 RVA: 0x006DA133 File Offset: 0x006D8333
		public void UnPackTo(ISetMotorSpeedTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032CA6 RID: 208038 RVA: 0x006DA144 File Offset: 0x006D8344
		public static Offset<ISetMotorSpeedType> Pack(FlatBufferBuilder builder, ISetMotorSpeedTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetMotorSpeedType>);
			}
			return ISetMotorSpeedType.CreateISetMotorSpeedType(builder, _o.Type);
		}

		// Token: 0x04011A53 RID: 72275
		private Table __p;
	}
}

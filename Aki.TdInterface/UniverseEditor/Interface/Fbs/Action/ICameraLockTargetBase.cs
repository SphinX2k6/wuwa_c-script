using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F5 RID: 26869
	public struct ICameraLockTargetBase : IFlatbufferObject
	{
		// Token: 0x1700C5A0 RID: 50592
		// (get) Token: 0x0602E030 RID: 188464 RVA: 0x00649E44 File Offset: 0x00648044
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E031 RID: 188465 RVA: 0x00649E51 File Offset: 0x00648051
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E032 RID: 188466 RVA: 0x00649E58 File Offset: 0x00648058
		public static ICameraLockTargetBase GetRootAsICameraLockTargetBase(ByteBuffer _bb)
		{
			return ICameraLockTargetBase.GetRootAsICameraLockTargetBase(_bb, default(ICameraLockTargetBase));
		}

		// Token: 0x0602E033 RID: 188467 RVA: 0x00649E74 File Offset: 0x00648074
		public static ICameraLockTargetBase GetRootAsICameraLockTargetBase(ByteBuffer _bb, ICameraLockTargetBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E034 RID: 188468 RVA: 0x00649E91 File Offset: 0x00648091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E035 RID: 188469 RVA: 0x00649EA0 File Offset: 0x006480A0
		public ICameraLockTargetBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5A1 RID: 50593
		// (get) Token: 0x0602E036 RID: 188470 RVA: 0x00649EB0 File Offset: 0x006480B0
		public ECameraLockTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECameraLockTargetType.TargetPosition;
				}
				return (ECameraLockTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E037 RID: 188471 RVA: 0x00649EEC File Offset: 0x006480EC
		public static Offset<ICameraLockTargetBase> CreateICameraLockTargetBase(FlatBufferBuilder builder, ECameraLockTargetType Type = ECameraLockTargetType.TargetPosition)
		{
			builder.StartTable(1);
			ICameraLockTargetBase.AddType(builder, Type);
			return ICameraLockTargetBase.EndICameraLockTargetBase(builder);
		}

		// Token: 0x0602E038 RID: 188472 RVA: 0x00649F02 File Offset: 0x00648102
		public static void StartICameraLockTargetBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E039 RID: 188473 RVA: 0x00649F0B File Offset: 0x0064810B
		public static void AddType(FlatBufferBuilder builder, ECameraLockTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E03A RID: 188474 RVA: 0x00649F16 File Offset: 0x00648116
		public static Offset<ICameraLockTargetBase> EndICameraLockTargetBase(FlatBufferBuilder builder)
		{
			return new Offset<ICameraLockTargetBase>(builder.EndTable());
		}

		// Token: 0x0602E03B RID: 188475 RVA: 0x00649F24 File Offset: 0x00648124
		public ICameraLockTargetBaseT UnPack()
		{
			ICameraLockTargetBaseT cameraLockTargetBaseT = new ICameraLockTargetBaseT();
			this.UnPackTo(cameraLockTargetBaseT);
			return cameraLockTargetBaseT;
		}

		// Token: 0x0602E03C RID: 188476 RVA: 0x00649F3F File Offset: 0x0064813F
		public void UnPackTo(ICameraLockTargetBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E03D RID: 188477 RVA: 0x00649F50 File Offset: 0x00648150
		public static Offset<ICameraLockTargetBase> Pack(FlatBufferBuilder builder, ICameraLockTargetBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraLockTargetBase>);
			}
			return ICameraLockTargetBase.CreateICameraLockTargetBase(builder, _o.Type);
		}

		// Token: 0x0401160B RID: 71179
		private Table __p;
	}
}

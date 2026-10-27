using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006284 RID: 25220
	public struct ICameraLockTargetBase : IFlatbufferObject
	{
		// Token: 0x1700BC18 RID: 48152
		// (get) Token: 0x0602B8CF RID: 178383 RVA: 0x005FF03C File Offset: 0x005FD23C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B8D0 RID: 178384 RVA: 0x005FF049 File Offset: 0x005FD249
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B8D1 RID: 178385 RVA: 0x005FF050 File Offset: 0x005FD250
		public static ICameraLockTargetBase GetRootAsICameraLockTargetBase(ByteBuffer _bb)
		{
			return ICameraLockTargetBase.GetRootAsICameraLockTargetBase(_bb, default(ICameraLockTargetBase));
		}

		// Token: 0x0602B8D2 RID: 178386 RVA: 0x005FF06C File Offset: 0x005FD26C
		public static ICameraLockTargetBase GetRootAsICameraLockTargetBase(ByteBuffer _bb, ICameraLockTargetBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B8D3 RID: 178387 RVA: 0x005FF089 File Offset: 0x005FD289
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B8D4 RID: 178388 RVA: 0x005FF098 File Offset: 0x005FD298
		public ICameraLockTargetBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC19 RID: 48153
		// (get) Token: 0x0602B8D5 RID: 178389 RVA: 0x005FF0A8 File Offset: 0x005FD2A8
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

		// Token: 0x0602B8D6 RID: 178390 RVA: 0x005FF0E4 File Offset: 0x005FD2E4
		public static Offset<ICameraLockTargetBase> CreateICameraLockTargetBase(FlatBufferBuilder builder, ECameraLockTargetType Type = ECameraLockTargetType.TargetPosition)
		{
			builder.StartTable(1);
			ICameraLockTargetBase.AddType(builder, Type);
			return ICameraLockTargetBase.EndICameraLockTargetBase(builder);
		}

		// Token: 0x0602B8D7 RID: 178391 RVA: 0x005FF0FA File Offset: 0x005FD2FA
		public static void StartICameraLockTargetBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B8D8 RID: 178392 RVA: 0x005FF103 File Offset: 0x005FD303
		public static void AddType(FlatBufferBuilder builder, ECameraLockTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B8D9 RID: 178393 RVA: 0x005FF10E File Offset: 0x005FD30E
		public static Offset<ICameraLockTargetBase> EndICameraLockTargetBase(FlatBufferBuilder builder)
		{
			return new Offset<ICameraLockTargetBase>(builder.EndTable());
		}

		// Token: 0x0602B8DA RID: 178394 RVA: 0x005FF11C File Offset: 0x005FD31C
		public ICameraLockTargetBaseT UnPack()
		{
			ICameraLockTargetBaseT cameraLockTargetBaseT = new ICameraLockTargetBaseT();
			this.UnPackTo(cameraLockTargetBaseT);
			return cameraLockTargetBaseT;
		}

		// Token: 0x0602B8DB RID: 178395 RVA: 0x005FF137 File Offset: 0x005FD337
		public void UnPackTo(ICameraLockTargetBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B8DC RID: 178396 RVA: 0x005FF148 File Offset: 0x005FD348
		public static Offset<ICameraLockTargetBase> Pack(FlatBufferBuilder builder, ICameraLockTargetBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraLockTargetBase>);
			}
			return ICameraLockTargetBase.CreateICameraLockTargetBase(builder, _o.Type);
		}

		// Token: 0x040107F6 RID: 67574
		private Table __p;
	}
}

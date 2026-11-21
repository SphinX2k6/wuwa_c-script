using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B30 RID: 27440
	public struct IConstantCameraShake : IFlatbufferObject
	{
		// Token: 0x1700C985 RID: 51589
		// (get) Token: 0x0602F370 RID: 193392 RVA: 0x006729F3 File Offset: 0x00670BF3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F371 RID: 193393 RVA: 0x00672A00 File Offset: 0x00670C00
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F372 RID: 193394 RVA: 0x00672A08 File Offset: 0x00670C08
		public static IConstantCameraShake GetRootAsIConstantCameraShake(ByteBuffer _bb)
		{
			return IConstantCameraShake.GetRootAsIConstantCameraShake(_bb, default(IConstantCameraShake));
		}

		// Token: 0x0602F373 RID: 193395 RVA: 0x00672A24 File Offset: 0x00670C24
		public static IConstantCameraShake GetRootAsIConstantCameraShake(ByteBuffer _bb, IConstantCameraShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F374 RID: 193396 RVA: 0x00672A41 File Offset: 0x00670C41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F375 RID: 193397 RVA: 0x00672A50 File Offset: 0x00670C50
		public IConstantCameraShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C986 RID: 51590
		// (get) Token: 0x0602F376 RID: 193398 RVA: 0x00672A60 File Offset: 0x00670C60
		public ECameraShakeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECameraShakeType.Constant;
				}
				return (ECameraShakeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F377 RID: 193399 RVA: 0x00672A9C File Offset: 0x00670C9C
		public static Offset<IConstantCameraShake> CreateIConstantCameraShake(FlatBufferBuilder builder, ECameraShakeType Type = ECameraShakeType.Constant)
		{
			builder.StartTable(1);
			IConstantCameraShake.AddType(builder, Type);
			return IConstantCameraShake.EndIConstantCameraShake(builder);
		}

		// Token: 0x0602F378 RID: 193400 RVA: 0x00672AB2 File Offset: 0x00670CB2
		public static void StartIConstantCameraShake(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F379 RID: 193401 RVA: 0x00672ABB File Offset: 0x00670CBB
		public static void AddType(FlatBufferBuilder builder, ECameraShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F37A RID: 193402 RVA: 0x00672AC6 File Offset: 0x00670CC6
		public static Offset<IConstantCameraShake> EndIConstantCameraShake(FlatBufferBuilder builder)
		{
			return new Offset<IConstantCameraShake>(builder.EndTable());
		}

		// Token: 0x0602F37B RID: 193403 RVA: 0x00672AD4 File Offset: 0x00670CD4
		public IConstantCameraShakeT UnPack()
		{
			IConstantCameraShakeT constantCameraShakeT = new IConstantCameraShakeT();
			this.UnPackTo(constantCameraShakeT);
			return constantCameraShakeT;
		}

		// Token: 0x0602F37C RID: 193404 RVA: 0x00672AEF File Offset: 0x00670CEF
		public void UnPackTo(IConstantCameraShakeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F37D RID: 193405 RVA: 0x00672B00 File Offset: 0x00670D00
		public static Offset<IConstantCameraShake> Pack(FlatBufferBuilder builder, IConstantCameraShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConstantCameraShake>);
			}
			return IConstantCameraShake.CreateIConstantCameraShake(builder, _o.Type);
		}

		// Token: 0x04011910 RID: 71952
		private Table __p;
	}
}

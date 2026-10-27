using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065D9 RID: 26073
	public struct IDisableCameraOperation : IFlatbufferObject
	{
		// Token: 0x1700C181 RID: 49537
		// (get) Token: 0x0602D386 RID: 185222 RVA: 0x00632B7B File Offset: 0x00630D7B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D387 RID: 185223 RVA: 0x00632B88 File Offset: 0x00630D88
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D388 RID: 185224 RVA: 0x00632B90 File Offset: 0x00630D90
		public static IDisableCameraOperation GetRootAsIDisableCameraOperation(ByteBuffer _bb)
		{
			return IDisableCameraOperation.GetRootAsIDisableCameraOperation(_bb, default(IDisableCameraOperation));
		}

		// Token: 0x0602D389 RID: 185225 RVA: 0x00632BAC File Offset: 0x00630DAC
		public static IDisableCameraOperation GetRootAsIDisableCameraOperation(ByteBuffer _bb, IDisableCameraOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D38A RID: 185226 RVA: 0x00632BC9 File Offset: 0x00630DC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D38B RID: 185227 RVA: 0x00632BD8 File Offset: 0x00630DD8
		public IDisableCameraOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C182 RID: 49538
		// (get) Token: 0x0602D38C RID: 185228 RVA: 0x00632BE8 File Offset: 0x00630DE8
		public ECameraOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECameraOperationType.Enable;
				}
				return (ECameraOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D38D RID: 185229 RVA: 0x00632C24 File Offset: 0x00630E24
		public static Offset<IDisableCameraOperation> CreateIDisableCameraOperation(FlatBufferBuilder builder, ECameraOperationType Type = ECameraOperationType.Enable)
		{
			builder.StartTable(1);
			IDisableCameraOperation.AddType(builder, Type);
			return IDisableCameraOperation.EndIDisableCameraOperation(builder);
		}

		// Token: 0x0602D38E RID: 185230 RVA: 0x00632C3A File Offset: 0x00630E3A
		public static void StartIDisableCameraOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D38F RID: 185231 RVA: 0x00632C43 File Offset: 0x00630E43
		public static void AddType(FlatBufferBuilder builder, ECameraOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D390 RID: 185232 RVA: 0x00632C4E File Offset: 0x00630E4E
		public static Offset<IDisableCameraOperation> EndIDisableCameraOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableCameraOperation>(builder.EndTable());
		}

		// Token: 0x0602D391 RID: 185233 RVA: 0x00632C5C File Offset: 0x00630E5C
		public IDisableCameraOperationT UnPack()
		{
			IDisableCameraOperationT disableCameraOperationT = new IDisableCameraOperationT();
			this.UnPackTo(disableCameraOperationT);
			return disableCameraOperationT;
		}

		// Token: 0x0602D392 RID: 185234 RVA: 0x00632C77 File Offset: 0x00630E77
		public void UnPackTo(IDisableCameraOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D393 RID: 185235 RVA: 0x00632C88 File Offset: 0x00630E88
		public static Offset<IDisableCameraOperation> Pack(FlatBufferBuilder builder, IDisableCameraOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableCameraOperation>);
			}
			return IDisableCameraOperation.CreateIDisableCameraOperation(builder, _o.Type);
		}

		// Token: 0x04010C3D RID: 68669
		private Table __p;
	}
}

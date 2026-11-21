using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E75 RID: 20085
	public struct ICheckDangoCultivationProgressType : IFlatbufferObject
	{
		// Token: 0x17008F3F RID: 36671
		// (get) Token: 0x0601F1BD RID: 127421 RVA: 0x0045732C File Offset: 0x0045552C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F1BE RID: 127422 RVA: 0x00457339 File Offset: 0x00455539
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F1BF RID: 127423 RVA: 0x00457340 File Offset: 0x00455540
		public static ICheckDangoCultivationProgressType GetRootAsICheckDangoCultivationProgressType(ByteBuffer _bb)
		{
			return ICheckDangoCultivationProgressType.GetRootAsICheckDangoCultivationProgressType(_bb, default(ICheckDangoCultivationProgressType));
		}

		// Token: 0x0601F1C0 RID: 127424 RVA: 0x0045735C File Offset: 0x0045555C
		public static ICheckDangoCultivationProgressType GetRootAsICheckDangoCultivationProgressType(ByteBuffer _bb, ICheckDangoCultivationProgressType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F1C1 RID: 127425 RVA: 0x00457379 File Offset: 0x00455579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F1C2 RID: 127426 RVA: 0x00457388 File Offset: 0x00455588
		public ICheckDangoCultivationProgressType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F40 RID: 36672
		// (get) Token: 0x0601F1C3 RID: 127427 RVA: 0x00457398 File Offset: 0x00455598
		public ECheckDangoCultivationProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckDangoCultivationProgressType.CountDangoOverTargetLevel;
				}
				return (ECheckDangoCultivationProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F1C4 RID: 127428 RVA: 0x004573D4 File Offset: 0x004555D4
		public static Offset<ICheckDangoCultivationProgressType> CreateICheckDangoCultivationProgressType(FlatBufferBuilder builder, ECheckDangoCultivationProgressType Type = ECheckDangoCultivationProgressType.CountDangoOverTargetLevel)
		{
			builder.StartTable(1);
			ICheckDangoCultivationProgressType.AddType(builder, Type);
			return ICheckDangoCultivationProgressType.EndICheckDangoCultivationProgressType(builder);
		}

		// Token: 0x0601F1C5 RID: 127429 RVA: 0x004573EA File Offset: 0x004555EA
		public static void StartICheckDangoCultivationProgressType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F1C6 RID: 127430 RVA: 0x004573F3 File Offset: 0x004555F3
		public static void AddType(FlatBufferBuilder builder, ECheckDangoCultivationProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F1C7 RID: 127431 RVA: 0x004573FE File Offset: 0x004555FE
		public static Offset<ICheckDangoCultivationProgressType> EndICheckDangoCultivationProgressType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDangoCultivationProgressType>(builder.EndTable());
		}

		// Token: 0x0601F1C8 RID: 127432 RVA: 0x0045740C File Offset: 0x0045560C
		public ICheckDangoCultivationProgressTypeT UnPack()
		{
			ICheckDangoCultivationProgressTypeT checkDangoCultivationProgressTypeT = new ICheckDangoCultivationProgressTypeT();
			this.UnPackTo(checkDangoCultivationProgressTypeT);
			return checkDangoCultivationProgressTypeT;
		}

		// Token: 0x0601F1C9 RID: 127433 RVA: 0x00457427 File Offset: 0x00455627
		public void UnPackTo(ICheckDangoCultivationProgressTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F1CA RID: 127434 RVA: 0x00457438 File Offset: 0x00455638
		public static Offset<ICheckDangoCultivationProgressType> Pack(FlatBufferBuilder builder, ICheckDangoCultivationProgressTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDangoCultivationProgressType>);
			}
			return ICheckDangoCultivationProgressType.CreateICheckDangoCultivationProgressType(builder, _o.Type);
		}

		// Token: 0x0400DCAD RID: 56493
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006367 RID: 25447
	public struct ICheckFlowLookAtTarget : IFlatbufferObject
	{
		// Token: 0x1700BDD9 RID: 48601
		// (get) Token: 0x0602C05F RID: 180319 RVA: 0x0060C95D File Offset: 0x0060AB5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C060 RID: 180320 RVA: 0x0060C96A File Offset: 0x0060AB6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C061 RID: 180321 RVA: 0x0060C974 File Offset: 0x0060AB74
		public static ICheckFlowLookAtTarget GetRootAsICheckFlowLookAtTarget(ByteBuffer _bb)
		{
			return ICheckFlowLookAtTarget.GetRootAsICheckFlowLookAtTarget(_bb, default(ICheckFlowLookAtTarget));
		}

		// Token: 0x0602C062 RID: 180322 RVA: 0x0060C990 File Offset: 0x0060AB90
		public static ICheckFlowLookAtTarget GetRootAsICheckFlowLookAtTarget(ByteBuffer _bb, ICheckFlowLookAtTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C063 RID: 180323 RVA: 0x0060C9AD File Offset: 0x0060ABAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C064 RID: 180324 RVA: 0x0060C9BC File Offset: 0x0060ABBC
		public ICheckFlowLookAtTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDDA RID: 48602
		// (get) Token: 0x0602C065 RID: 180325 RVA: 0x0060C9CC File Offset: 0x0060ABCC
		public ECheckFlowLookAtTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckFlowLookAtTargetType.Entity;
				}
				return (ECheckFlowLookAtTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C066 RID: 180326 RVA: 0x0060CA08 File Offset: 0x0060AC08
		public static Offset<ICheckFlowLookAtTarget> CreateICheckFlowLookAtTarget(FlatBufferBuilder builder, ECheckFlowLookAtTargetType Type = ECheckFlowLookAtTargetType.Entity)
		{
			builder.StartTable(1);
			ICheckFlowLookAtTarget.AddType(builder, Type);
			return ICheckFlowLookAtTarget.EndICheckFlowLookAtTarget(builder);
		}

		// Token: 0x0602C067 RID: 180327 RVA: 0x0060CA1E File Offset: 0x0060AC1E
		public static void StartICheckFlowLookAtTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C068 RID: 180328 RVA: 0x0060CA27 File Offset: 0x0060AC27
		public static void AddType(FlatBufferBuilder builder, ECheckFlowLookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C069 RID: 180329 RVA: 0x0060CA32 File Offset: 0x0060AC32
		public static Offset<ICheckFlowLookAtTarget> EndICheckFlowLookAtTarget(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFlowLookAtTarget>(builder.EndTable());
		}

		// Token: 0x0602C06A RID: 180330 RVA: 0x0060CA40 File Offset: 0x0060AC40
		public ICheckFlowLookAtTargetT UnPack()
		{
			ICheckFlowLookAtTargetT checkFlowLookAtTargetT = new ICheckFlowLookAtTargetT();
			this.UnPackTo(checkFlowLookAtTargetT);
			return checkFlowLookAtTargetT;
		}

		// Token: 0x0602C06B RID: 180331 RVA: 0x0060CA5B File Offset: 0x0060AC5B
		public void UnPackTo(ICheckFlowLookAtTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C06C RID: 180332 RVA: 0x0060CA6C File Offset: 0x0060AC6C
		public static Offset<ICheckFlowLookAtTarget> Pack(FlatBufferBuilder builder, ICheckFlowLookAtTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFlowLookAtTarget>);
			}
			return ICheckFlowLookAtTarget.CreateICheckFlowLookAtTarget(builder, _o.Type);
		}

		// Token: 0x04010934 RID: 67892
		private Table __p;
	}
}

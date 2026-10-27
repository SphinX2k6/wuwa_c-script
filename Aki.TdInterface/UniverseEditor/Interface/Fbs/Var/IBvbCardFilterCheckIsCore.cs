using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A36 RID: 14902
	public struct IBvbCardFilterCheckIsCore : IFlatbufferObject
	{
		// Token: 0x1700661D RID: 26141
		// (get) Token: 0x0601429E RID: 82590 RVA: 0x002F2C86 File Offset: 0x002F0E86
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601429F RID: 82591 RVA: 0x002F2C93 File Offset: 0x002F0E93
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060142A0 RID: 82592 RVA: 0x002F2C9C File Offset: 0x002F0E9C
		public static IBvbCardFilterCheckIsCore GetRootAsIBvbCardFilterCheckIsCore(ByteBuffer _bb)
		{
			return IBvbCardFilterCheckIsCore.GetRootAsIBvbCardFilterCheckIsCore(_bb, default(IBvbCardFilterCheckIsCore));
		}

		// Token: 0x060142A1 RID: 82593 RVA: 0x002F2CB8 File Offset: 0x002F0EB8
		public static IBvbCardFilterCheckIsCore GetRootAsIBvbCardFilterCheckIsCore(ByteBuffer _bb, IBvbCardFilterCheckIsCore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060142A2 RID: 82594 RVA: 0x002F2CD5 File Offset: 0x002F0ED5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060142A3 RID: 82595 RVA: 0x002F2CE4 File Offset: 0x002F0EE4
		public IBvbCardFilterCheckIsCore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700661E RID: 26142
		// (get) Token: 0x060142A4 RID: 82596 RVA: 0x002F2CF4 File Offset: 0x002F0EF4
		public EBvbCardFilterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbCardFilterType.CompareCost;
				}
				return (EBvbCardFilterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700661F RID: 26143
		// (get) Token: 0x060142A5 RID: 82597 RVA: 0x002F2D30 File Offset: 0x002F0F30
		public bool IsCore
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060142A6 RID: 82598 RVA: 0x002F2D6F File Offset: 0x002F0F6F
		public static Offset<IBvbCardFilterCheckIsCore> CreateIBvbCardFilterCheckIsCore(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, bool IsCore = false)
		{
			builder.StartTable(2);
			IBvbCardFilterCheckIsCore.AddIsCore(builder, IsCore);
			IBvbCardFilterCheckIsCore.AddType(builder, Type);
			return IBvbCardFilterCheckIsCore.EndIBvbCardFilterCheckIsCore(builder);
		}

		// Token: 0x060142A7 RID: 82599 RVA: 0x002F2D8C File Offset: 0x002F0F8C
		public static void StartIBvbCardFilterCheckIsCore(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060142A8 RID: 82600 RVA: 0x002F2D95 File Offset: 0x002F0F95
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060142A9 RID: 82601 RVA: 0x002F2DA0 File Offset: 0x002F0FA0
		public static void AddIsCore(FlatBufferBuilder builder, bool isCore)
		{
			builder.AddBool(1, isCore, false);
		}

		// Token: 0x060142AA RID: 82602 RVA: 0x002F2DAB File Offset: 0x002F0FAB
		public static Offset<IBvbCardFilterCheckIsCore> EndIBvbCardFilterCheckIsCore(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCheckIsCore>(builder.EndTable());
		}

		// Token: 0x060142AB RID: 82603 RVA: 0x002F2DB8 File Offset: 0x002F0FB8
		public IBvbCardFilterCheckIsCoreT UnPack()
		{
			IBvbCardFilterCheckIsCoreT bvbCardFilterCheckIsCoreT = new IBvbCardFilterCheckIsCoreT();
			this.UnPackTo(bvbCardFilterCheckIsCoreT);
			return bvbCardFilterCheckIsCoreT;
		}

		// Token: 0x060142AC RID: 82604 RVA: 0x002F2DD3 File Offset: 0x002F0FD3
		public void UnPackTo(IBvbCardFilterCheckIsCoreT _o)
		{
			_o.Type = this.Type;
			_o.IsCore = this.IsCore;
		}

		// Token: 0x060142AD RID: 82605 RVA: 0x002F2DF0 File Offset: 0x002F0FF0
		public static Offset<IBvbCardFilterCheckIsCore> Pack(FlatBufferBuilder builder, IBvbCardFilterCheckIsCoreT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterCheckIsCore>);
			}
			return IBvbCardFilterCheckIsCore.CreateIBvbCardFilterCheckIsCore(builder, _o.Type, _o.IsCore);
		}

		// Token: 0x0400AEB5 RID: 44725
		private Table __p;
	}
}

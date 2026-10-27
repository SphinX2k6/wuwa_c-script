using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063E5 RID: 25573
	public struct IClientSetPlayerOperationRestriction : IFlatbufferObject
	{
		// Token: 0x1700BE81 RID: 48769
		// (get) Token: 0x0602C3E3 RID: 181219 RVA: 0x00612BAD File Offset: 0x00610DAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C3E4 RID: 181220 RVA: 0x00612BBA File Offset: 0x00610DBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C3E5 RID: 181221 RVA: 0x00612BC4 File Offset: 0x00610DC4
		public static IClientSetPlayerOperationRestriction GetRootAsIClientSetPlayerOperationRestriction(ByteBuffer _bb)
		{
			return IClientSetPlayerOperationRestriction.GetRootAsIClientSetPlayerOperationRestriction(_bb, default(IClientSetPlayerOperationRestriction));
		}

		// Token: 0x0602C3E6 RID: 181222 RVA: 0x00612BE0 File Offset: 0x00610DE0
		public static IClientSetPlayerOperationRestriction GetRootAsIClientSetPlayerOperationRestriction(ByteBuffer _bb, IClientSetPlayerOperationRestriction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C3E7 RID: 181223 RVA: 0x00612BFD File Offset: 0x00610DFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C3E8 RID: 181224 RVA: 0x00612C0C File Offset: 0x00610E0C
		public IClientSetPlayerOperationRestriction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE82 RID: 48770
		// (get) Token: 0x0602C3E9 RID: 181225 RVA: 0x00612C1C File Offset: 0x00610E1C
		public EPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerOperationType.EnableAll;
				}
				return (EPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C3EA RID: 181226 RVA: 0x00612C58 File Offset: 0x00610E58
		public static Offset<IClientSetPlayerOperationRestriction> CreateIClientSetPlayerOperationRestriction(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll)
		{
			builder.StartTable(1);
			IClientSetPlayerOperationRestriction.AddType(builder, Type);
			return IClientSetPlayerOperationRestriction.EndIClientSetPlayerOperationRestriction(builder);
		}

		// Token: 0x0602C3EB RID: 181227 RVA: 0x00612C6E File Offset: 0x00610E6E
		public static void StartIClientSetPlayerOperationRestriction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C3EC RID: 181228 RVA: 0x00612C77 File Offset: 0x00610E77
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C3ED RID: 181229 RVA: 0x00612C82 File Offset: 0x00610E82
		public static Offset<IClientSetPlayerOperationRestriction> EndIClientSetPlayerOperationRestriction(FlatBufferBuilder builder)
		{
			return new Offset<IClientSetPlayerOperationRestriction>(builder.EndTable());
		}

		// Token: 0x0602C3EE RID: 181230 RVA: 0x00612C90 File Offset: 0x00610E90
		public IClientSetPlayerOperationRestrictionT UnPack()
		{
			IClientSetPlayerOperationRestrictionT clientSetPlayerOperationRestrictionT = new IClientSetPlayerOperationRestrictionT();
			this.UnPackTo(clientSetPlayerOperationRestrictionT);
			return clientSetPlayerOperationRestrictionT;
		}

		// Token: 0x0602C3EF RID: 181231 RVA: 0x00612CAB File Offset: 0x00610EAB
		public void UnPackTo(IClientSetPlayerOperationRestrictionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C3F0 RID: 181232 RVA: 0x00612CBC File Offset: 0x00610EBC
		public static Offset<IClientSetPlayerOperationRestriction> Pack(FlatBufferBuilder builder, IClientSetPlayerOperationRestrictionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientSetPlayerOperationRestriction>);
			}
			return IClientSetPlayerOperationRestriction.CreateIClientSetPlayerOperationRestriction(builder, _o.Type);
		}

		// Token: 0x040109C7 RID: 68039
		private Table __p;
	}
}

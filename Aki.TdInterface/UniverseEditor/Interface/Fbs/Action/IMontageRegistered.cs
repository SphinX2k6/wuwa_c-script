using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B03 RID: 27395
	public struct IMontageRegistered : IFlatbufferObject
	{
		// Token: 0x1700CB64 RID: 52068
		// (get) Token: 0x060300B8 RID: 196792 RVA: 0x006882FF File Offset: 0x006864FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060300B9 RID: 196793 RVA: 0x0068830C File Offset: 0x0068650C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060300BA RID: 196794 RVA: 0x00688314 File Offset: 0x00686514
		public static IMontageRegistered GetRootAsIMontageRegistered(ByteBuffer _bb)
		{
			return IMontageRegistered.GetRootAsIMontageRegistered(_bb, default(IMontageRegistered));
		}

		// Token: 0x060300BB RID: 196795 RVA: 0x00688330 File Offset: 0x00686530
		public static IMontageRegistered GetRootAsIMontageRegistered(ByteBuffer _bb, IMontageRegistered obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060300BC RID: 196796 RVA: 0x0068834D File Offset: 0x0068654D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060300BD RID: 196797 RVA: 0x0068835C File Offset: 0x0068655C
		public IMontageRegistered __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB65 RID: 52069
		// (get) Token: 0x060300BE RID: 196798 RVA: 0x0068836C File Offset: 0x0068656C
		public EMontageConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMontageConfigType.Asset;
				}
				return (EMontageConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB66 RID: 52070
		// (get) Token: 0x060300BF RID: 196799 RVA: 0x006883A8 File Offset: 0x006865A8
		public IMontageId? MontageId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060300C0 RID: 196800 RVA: 0x00688405 File Offset: 0x00686605
		public static Offset<IMontageRegistered> CreateIMontageRegistered(FlatBufferBuilder builder, EMontageConfigType Type = EMontageConfigType.Asset, Offset<IMontageId> MontageIdOffset = default(Offset<IMontageId>))
		{
			builder.StartTable(2);
			IMontageRegistered.AddMontageId(builder, MontageIdOffset);
			IMontageRegistered.AddType(builder, Type);
			return IMontageRegistered.EndIMontageRegistered(builder);
		}

		// Token: 0x060300C1 RID: 196801 RVA: 0x00688422 File Offset: 0x00686622
		public static void StartIMontageRegistered(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060300C2 RID: 196802 RVA: 0x0068842B File Offset: 0x0068662B
		public static void AddType(FlatBufferBuilder builder, EMontageConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060300C3 RID: 196803 RVA: 0x00688436 File Offset: 0x00686636
		public static void AddMontageId(FlatBufferBuilder builder, Offset<IMontageId> montageIdOffset)
		{
			builder.AddOffset(1, montageIdOffset.Value, 0);
		}

		// Token: 0x060300C4 RID: 196804 RVA: 0x00688446 File Offset: 0x00686646
		public static Offset<IMontageRegistered> EndIMontageRegistered(FlatBufferBuilder builder)
		{
			return new Offset<IMontageRegistered>(builder.EndTable());
		}

		// Token: 0x060300C5 RID: 196805 RVA: 0x00688454 File Offset: 0x00686654
		public IMontageRegisteredT UnPack()
		{
			IMontageRegisteredT montageRegisteredT = new IMontageRegisteredT();
			this.UnPackTo(montageRegisteredT);
			return montageRegisteredT;
		}

		// Token: 0x060300C6 RID: 196806 RVA: 0x00688470 File Offset: 0x00686670
		public void UnPackTo(IMontageRegisteredT _o)
		{
			_o.Type = this.Type;
			_o.MontageId = ((this.MontageId != null) ? this.MontageId.Value.UnPack() : null);
		}

		// Token: 0x060300C7 RID: 196807 RVA: 0x006884B8 File Offset: 0x006866B8
		public static Offset<IMontageRegistered> Pack(FlatBufferBuilder builder, IMontageRegisteredT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontageRegistered>);
			}
			Offset<IMontageId> montageIdOffset = (_o.MontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.MontageId);
			return IMontageRegistered.CreateIMontageRegistered(builder, _o.Type, montageIdOffset);
		}

		// Token: 0x04011374 RID: 70516
		private Table __p;
	}
}

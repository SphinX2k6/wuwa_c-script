using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063BE RID: 25534
	public struct IClientFollowShooterLeisureInteract : IFlatbufferObject
	{
		// Token: 0x1700BE46 RID: 48710
		// (get) Token: 0x0602C2AF RID: 180911 RVA: 0x006108C4 File Offset: 0x0060EAC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C2B0 RID: 180912 RVA: 0x006108D1 File Offset: 0x0060EAD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C2B1 RID: 180913 RVA: 0x006108D8 File Offset: 0x0060EAD8
		public static IClientFollowShooterLeisureInteract GetRootAsIClientFollowShooterLeisureInteract(ByteBuffer _bb)
		{
			return IClientFollowShooterLeisureInteract.GetRootAsIClientFollowShooterLeisureInteract(_bb, default(IClientFollowShooterLeisureInteract));
		}

		// Token: 0x0602C2B2 RID: 180914 RVA: 0x006108F4 File Offset: 0x0060EAF4
		public static IClientFollowShooterLeisureInteract GetRootAsIClientFollowShooterLeisureInteract(ByteBuffer _bb, IClientFollowShooterLeisureInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C2B3 RID: 180915 RVA: 0x00610911 File Offset: 0x0060EB11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C2B4 RID: 180916 RVA: 0x00610920 File Offset: 0x0060EB20
		public IClientFollowShooterLeisureInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE47 RID: 48711
		// (get) Token: 0x0602C2B5 RID: 180917 RVA: 0x00610930 File Offset: 0x0060EB30
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BE48 RID: 48712
		// (get) Token: 0x0602C2B6 RID: 180918 RVA: 0x0061096C File Offset: 0x0060EB6C
		public TClientFollowShooterLeisureType InteractTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TClientFollowShooterLeisureType.NONE;
				}
				return (TClientFollowShooterLeisureType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C2B7 RID: 180919 RVA: 0x006109A8 File Offset: 0x0060EBA8
		public TTable? InteractType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C2B8 RID: 180920 RVA: 0x006109EC File Offset: 0x0060EBEC
		public IClientFollowShooterPlayAnimation InteractTypeAsIClientFollowShooterPlayAnimation()
		{
			return this.InteractType<IClientFollowShooterPlayAnimation>().Value;
		}

		// Token: 0x0602C2B9 RID: 180921 RVA: 0x00610A08 File Offset: 0x0060EC08
		public IClientFollowShooterResetToPlayer InteractTypeAsIClientFollowShooterResetToPlayer()
		{
			return this.InteractType<IClientFollowShooterResetToPlayer>().Value;
		}

		// Token: 0x0602C2BA RID: 180922 RVA: 0x00610A23 File Offset: 0x0060EC23
		public static Offset<IClientFollowShooterLeisureInteract> CreateIClientFollowShooterLeisureInteract(FlatBufferBuilder builder, int Id = 0, TClientFollowShooterLeisureType InteractType_type = TClientFollowShooterLeisureType.NONE, int InteractTypeOffset = 0)
		{
			builder.StartTable(3);
			IClientFollowShooterLeisureInteract.AddInteractType(builder, InteractTypeOffset);
			IClientFollowShooterLeisureInteract.AddId(builder, Id);
			IClientFollowShooterLeisureInteract.AddInteractTypeType(builder, InteractType_type);
			return IClientFollowShooterLeisureInteract.EndIClientFollowShooterLeisureInteract(builder);
		}

		// Token: 0x0602C2BB RID: 180923 RVA: 0x00610A47 File Offset: 0x0060EC47
		public static void StartIClientFollowShooterLeisureInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C2BC RID: 180924 RVA: 0x00610A50 File Offset: 0x0060EC50
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602C2BD RID: 180925 RVA: 0x00610A5B File Offset: 0x0060EC5B
		public static void AddInteractTypeType(FlatBufferBuilder builder, TClientFollowShooterLeisureType interactTypeType)
		{
			builder.AddByte(1, (byte)interactTypeType, 0);
		}

		// Token: 0x0602C2BE RID: 180926 RVA: 0x00610A66 File Offset: 0x0060EC66
		public static void AddInteractType(FlatBufferBuilder builder, int interactTypeOffset)
		{
			builder.AddOffset(2, interactTypeOffset, 0);
		}

		// Token: 0x0602C2BF RID: 180927 RVA: 0x00610A71 File Offset: 0x0060EC71
		public static Offset<IClientFollowShooterLeisureInteract> EndIClientFollowShooterLeisureInteract(FlatBufferBuilder builder)
		{
			return new Offset<IClientFollowShooterLeisureInteract>(builder.EndTable());
		}

		// Token: 0x0602C2C0 RID: 180928 RVA: 0x00610A80 File Offset: 0x0060EC80
		public IClientFollowShooterLeisureInteractT UnPack()
		{
			IClientFollowShooterLeisureInteractT clientFollowShooterLeisureInteractT = new IClientFollowShooterLeisureInteractT();
			this.UnPackTo(clientFollowShooterLeisureInteractT);
			return clientFollowShooterLeisureInteractT;
		}

		// Token: 0x0602C2C1 RID: 180929 RVA: 0x00610A9C File Offset: 0x0060EC9C
		public void UnPackTo(IClientFollowShooterLeisureInteractT _o)
		{
			_o.Id = this.Id;
			_o.InteractType = new TClientFollowShooterLeisureTypeUnion();
			_o.InteractType.Type = this.InteractTypeType;
			TClientFollowShooterLeisureType interactTypeType = this.InteractTypeType;
			if (interactTypeType == TClientFollowShooterLeisureType.IClientFollowShooterPlayAnimation)
			{
				_o.InteractType.Value = ((this.InteractType<IClientFollowShooterPlayAnimation>() != null) ? this.InteractType<IClientFollowShooterPlayAnimation>().Value.UnPack() : null);
				return;
			}
			if (interactTypeType != TClientFollowShooterLeisureType.IClientFollowShooterResetToPlayer)
			{
				return;
			}
			_o.InteractType.Value = ((this.InteractType<IClientFollowShooterResetToPlayer>() != null) ? this.InteractType<IClientFollowShooterResetToPlayer>().Value.UnPack() : null);
		}

		// Token: 0x0602C2C2 RID: 180930 RVA: 0x00610B4C File Offset: 0x0060ED4C
		public static Offset<IClientFollowShooterLeisureInteract> Pack(FlatBufferBuilder builder, IClientFollowShooterLeisureInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientFollowShooterLeisureInteract>);
			}
			TClientFollowShooterLeisureType interactType_type = (_o.InteractType == null) ? TClientFollowShooterLeisureType.NONE : _o.InteractType.Type;
			int interactTypeOffset = (_o.InteractType == null) ? 0 : TClientFollowShooterLeisureTypeUnion.Pack(builder, _o.InteractType);
			return IClientFollowShooterLeisureInteract.CreateIClientFollowShooterLeisureInteract(builder, _o.Id, interactType_type, interactTypeOffset);
		}

		// Token: 0x04010998 RID: 67992
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A38 RID: 27192
	public struct IClientFollowShooterLeisureInteract : IFlatbufferObject
	{
		// Token: 0x1700C7D2 RID: 51154
		// (get) Token: 0x0602EA41 RID: 191041 RVA: 0x0065BD6A File Offset: 0x00659F6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EA42 RID: 191042 RVA: 0x0065BD77 File Offset: 0x00659F77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EA43 RID: 191043 RVA: 0x0065BD80 File Offset: 0x00659F80
		public static IClientFollowShooterLeisureInteract GetRootAsIClientFollowShooterLeisureInteract(ByteBuffer _bb)
		{
			return IClientFollowShooterLeisureInteract.GetRootAsIClientFollowShooterLeisureInteract(_bb, default(IClientFollowShooterLeisureInteract));
		}

		// Token: 0x0602EA44 RID: 191044 RVA: 0x0065BD9C File Offset: 0x00659F9C
		public static IClientFollowShooterLeisureInteract GetRootAsIClientFollowShooterLeisureInteract(ByteBuffer _bb, IClientFollowShooterLeisureInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EA45 RID: 191045 RVA: 0x0065BDB9 File Offset: 0x00659FB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EA46 RID: 191046 RVA: 0x0065BDC8 File Offset: 0x00659FC8
		public IClientFollowShooterLeisureInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7D3 RID: 51155
		// (get) Token: 0x0602EA47 RID: 191047 RVA: 0x0065BDD8 File Offset: 0x00659FD8
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

		// Token: 0x1700C7D4 RID: 51156
		// (get) Token: 0x0602EA48 RID: 191048 RVA: 0x0065BE14 File Offset: 0x0065A014
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

		// Token: 0x0602EA49 RID: 191049 RVA: 0x0065BE50 File Offset: 0x0065A050
		public TTable? InteractType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EA4A RID: 191050 RVA: 0x0065BE94 File Offset: 0x0065A094
		public IClientFollowShooterPlayAnimation InteractTypeAsIClientFollowShooterPlayAnimation()
		{
			return this.InteractType<IClientFollowShooterPlayAnimation>().Value;
		}

		// Token: 0x0602EA4B RID: 191051 RVA: 0x0065BEB0 File Offset: 0x0065A0B0
		public IClientFollowShooterPlaySkill InteractTypeAsIClientFollowShooterPlaySkill()
		{
			return this.InteractType<IClientFollowShooterPlaySkill>().Value;
		}

		// Token: 0x0602EA4C RID: 191052 RVA: 0x0065BECC File Offset: 0x0065A0CC
		public IClientFollowShooterResetToPlayer InteractTypeAsIClientFollowShooterResetToPlayer()
		{
			return this.InteractType<IClientFollowShooterResetToPlayer>().Value;
		}

		// Token: 0x0602EA4D RID: 191053 RVA: 0x0065BEE7 File Offset: 0x0065A0E7
		public static Offset<IClientFollowShooterLeisureInteract> CreateIClientFollowShooterLeisureInteract(FlatBufferBuilder builder, int Id = 0, TClientFollowShooterLeisureType InteractType_type = TClientFollowShooterLeisureType.NONE, int InteractTypeOffset = 0)
		{
			builder.StartTable(3);
			IClientFollowShooterLeisureInteract.AddInteractType(builder, InteractTypeOffset);
			IClientFollowShooterLeisureInteract.AddId(builder, Id);
			IClientFollowShooterLeisureInteract.AddInteractTypeType(builder, InteractType_type);
			return IClientFollowShooterLeisureInteract.EndIClientFollowShooterLeisureInteract(builder);
		}

		// Token: 0x0602EA4E RID: 191054 RVA: 0x0065BF0B File Offset: 0x0065A10B
		public static void StartIClientFollowShooterLeisureInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EA4F RID: 191055 RVA: 0x0065BF14 File Offset: 0x0065A114
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602EA50 RID: 191056 RVA: 0x0065BF1F File Offset: 0x0065A11F
		public static void AddInteractTypeType(FlatBufferBuilder builder, TClientFollowShooterLeisureType interactTypeType)
		{
			builder.AddByte(1, (byte)interactTypeType, 0);
		}

		// Token: 0x0602EA51 RID: 191057 RVA: 0x0065BF2A File Offset: 0x0065A12A
		public static void AddInteractType(FlatBufferBuilder builder, int interactTypeOffset)
		{
			builder.AddOffset(2, interactTypeOffset, 0);
		}

		// Token: 0x0602EA52 RID: 191058 RVA: 0x0065BF35 File Offset: 0x0065A135
		public static Offset<IClientFollowShooterLeisureInteract> EndIClientFollowShooterLeisureInteract(FlatBufferBuilder builder)
		{
			return new Offset<IClientFollowShooterLeisureInteract>(builder.EndTable());
		}

		// Token: 0x0602EA53 RID: 191059 RVA: 0x0065BF44 File Offset: 0x0065A144
		public IClientFollowShooterLeisureInteractT UnPack()
		{
			IClientFollowShooterLeisureInteractT clientFollowShooterLeisureInteractT = new IClientFollowShooterLeisureInteractT();
			this.UnPackTo(clientFollowShooterLeisureInteractT);
			return clientFollowShooterLeisureInteractT;
		}

		// Token: 0x0602EA54 RID: 191060 RVA: 0x0065BF60 File Offset: 0x0065A160
		public void UnPackTo(IClientFollowShooterLeisureInteractT _o)
		{
			_o.Id = this.Id;
			_o.InteractType = new TClientFollowShooterLeisureTypeUnion();
			_o.InteractType.Type = this.InteractTypeType;
			switch (this.InteractTypeType)
			{
			case TClientFollowShooterLeisureType.IClientFollowShooterPlayAnimation:
				_o.InteractType.Value = ((this.InteractType<IClientFollowShooterPlayAnimation>() != null) ? this.InteractType<IClientFollowShooterPlayAnimation>().Value.UnPack() : null);
				return;
			case TClientFollowShooterLeisureType.IClientFollowShooterPlaySkill:
				_o.InteractType.Value = ((this.InteractType<IClientFollowShooterPlaySkill>() != null) ? this.InteractType<IClientFollowShooterPlaySkill>().Value.UnPack() : null);
				return;
			case TClientFollowShooterLeisureType.IClientFollowShooterResetToPlayer:
				_o.InteractType.Value = ((this.InteractType<IClientFollowShooterResetToPlayer>() != null) ? this.InteractType<IClientFollowShooterResetToPlayer>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602EA55 RID: 191061 RVA: 0x0065C054 File Offset: 0x0065A254
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

		// Token: 0x040117B5 RID: 71605
		private Table __p;
	}
}

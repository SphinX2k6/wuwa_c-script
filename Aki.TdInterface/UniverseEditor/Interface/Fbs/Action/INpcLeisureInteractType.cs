using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007325 RID: 29477
	public struct INpcLeisureInteractType : IFlatbufferObject
	{
		// Token: 0x1700D80B RID: 55307
		// (get) Token: 0x0603366B RID: 210539 RVA: 0x006EE24D File Offset: 0x006EC44D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603366C RID: 210540 RVA: 0x006EE25A File Offset: 0x006EC45A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603366D RID: 210541 RVA: 0x006EE264 File Offset: 0x006EC464
		public static INpcLeisureInteractType GetRootAsINpcLeisureInteractType(ByteBuffer _bb)
		{
			return INpcLeisureInteractType.GetRootAsINpcLeisureInteractType(_bb, default(INpcLeisureInteractType));
		}

		// Token: 0x0603366E RID: 210542 RVA: 0x006EE280 File Offset: 0x006EC480
		public static INpcLeisureInteractType GetRootAsINpcLeisureInteractType(ByteBuffer _bb, INpcLeisureInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603366F RID: 210543 RVA: 0x006EE29D File Offset: 0x006EC49D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033670 RID: 210544 RVA: 0x006EE2AC File Offset: 0x006EC4AC
		public INpcLeisureInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D80C RID: 55308
		// (get) Token: 0x06033671 RID: 210545 RVA: 0x006EE2BC File Offset: 0x006EC4BC
		public ENpcLeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcLeisureInteract.SitDown;
				}
				return (ENpcLeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D80D RID: 55309
		// (get) Token: 0x06033672 RID: 210546 RVA: 0x006EE2F8 File Offset: 0x006EC4F8
		public bool KeepState
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D80E RID: 55310
		// (get) Token: 0x06033673 RID: 210547 RVA: 0x006EE338 File Offset: 0x006EC538
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033674 RID: 210548 RVA: 0x006EE374 File Offset: 0x006EC574
		public static Offset<INpcLeisureInteractType> CreateINpcLeisureInteractType(FlatBufferBuilder builder, ENpcLeisureInteract Type = ENpcLeisureInteract.SitDown, bool KeepState = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			INpcLeisureInteractType.AddNullMask(builder, NullMask);
			INpcLeisureInteractType.AddKeepState(builder, KeepState);
			INpcLeisureInteractType.AddType(builder, Type);
			return INpcLeisureInteractType.EndINpcLeisureInteractType(builder);
		}

		// Token: 0x06033675 RID: 210549 RVA: 0x006EE398 File Offset: 0x006EC598
		public static void StartINpcLeisureInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033676 RID: 210550 RVA: 0x006EE3A1 File Offset: 0x006EC5A1
		public static void AddType(FlatBufferBuilder builder, ENpcLeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033677 RID: 210551 RVA: 0x006EE3AC File Offset: 0x006EC5AC
		public static void AddKeepState(FlatBufferBuilder builder, bool keepState)
		{
			builder.AddBool(1, keepState, false);
		}

		// Token: 0x06033678 RID: 210552 RVA: 0x006EE3B7 File Offset: 0x006EC5B7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06033679 RID: 210553 RVA: 0x006EE3C2 File Offset: 0x006EC5C2
		public static Offset<INpcLeisureInteractType> EndINpcLeisureInteractType(FlatBufferBuilder builder)
		{
			return new Offset<INpcLeisureInteractType>(builder.EndTable());
		}

		// Token: 0x0603367A RID: 210554 RVA: 0x006EE3D0 File Offset: 0x006EC5D0
		public INpcLeisureInteractTypeT UnPack()
		{
			INpcLeisureInteractTypeT npcLeisureInteractTypeT = new INpcLeisureInteractTypeT();
			this.UnPackTo(npcLeisureInteractTypeT);
			return npcLeisureInteractTypeT;
		}

		// Token: 0x0603367B RID: 210555 RVA: 0x006EE3EB File Offset: 0x006EC5EB
		public void UnPackTo(INpcLeisureInteractTypeT _o)
		{
			_o.Type = this.Type;
			_o.KeepState = this.KeepState;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603367C RID: 210556 RVA: 0x006EE414 File Offset: 0x006EC614
		public static Offset<INpcLeisureInteractType> Pack(FlatBufferBuilder builder, INpcLeisureInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcLeisureInteractType>);
			}
			return INpcLeisureInteractType.CreateINpcLeisureInteractType(builder, _o.Type, _o.KeepState, _o.NullMask);
		}

		// Token: 0x040123E6 RID: 74726
		private Table __p;
	}
}

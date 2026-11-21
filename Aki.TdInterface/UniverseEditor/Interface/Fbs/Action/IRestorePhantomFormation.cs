using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200763C RID: 30268
	public struct IRestorePhantomFormation : IFlatbufferObject
	{
		// Token: 0x1700DE51 RID: 56913
		// (get) Token: 0x060351C4 RID: 217540 RVA: 0x00721CCA File Offset: 0x0071FECA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060351C5 RID: 217541 RVA: 0x00721CD7 File Offset: 0x0071FED7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060351C6 RID: 217542 RVA: 0x00721CE0 File Offset: 0x0071FEE0
		public static IRestorePhantomFormation GetRootAsIRestorePhantomFormation(ByteBuffer _bb)
		{
			return IRestorePhantomFormation.GetRootAsIRestorePhantomFormation(_bb, default(IRestorePhantomFormation));
		}

		// Token: 0x060351C7 RID: 217543 RVA: 0x00721CFC File Offset: 0x0071FEFC
		public static IRestorePhantomFormation GetRootAsIRestorePhantomFormation(ByteBuffer _bb, IRestorePhantomFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060351C8 RID: 217544 RVA: 0x00721D19 File Offset: 0x0071FF19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060351C9 RID: 217545 RVA: 0x00721D28 File Offset: 0x0071FF28
		public IRestorePhantomFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE52 RID: 56914
		// (get) Token: 0x060351CA RID: 217546 RVA: 0x00721D38 File Offset: 0x0071FF38
		public int TeleportEntityId
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

		// Token: 0x1700DE53 RID: 56915
		// (get) Token: 0x060351CB RID: 217547 RVA: 0x00721D74 File Offset: 0x0071FF74
		public bool RetainPhantom
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DE54 RID: 56916
		// (get) Token: 0x060351CC RID: 217548 RVA: 0x00721DB4 File Offset: 0x0071FFB4
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

		// Token: 0x060351CD RID: 217549 RVA: 0x00721DF0 File Offset: 0x0071FFF0
		public static Offset<IRestorePhantomFormation> CreateIRestorePhantomFormation(FlatBufferBuilder builder, int TeleportEntityId = 0, bool RetainPhantom = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IRestorePhantomFormation.AddTeleportEntityId(builder, TeleportEntityId);
			IRestorePhantomFormation.AddNullMask(builder, NullMask);
			IRestorePhantomFormation.AddRetainPhantom(builder, RetainPhantom);
			return IRestorePhantomFormation.EndIRestorePhantomFormation(builder);
		}

		// Token: 0x060351CE RID: 217550 RVA: 0x00721E14 File Offset: 0x00720014
		public static void StartIRestorePhantomFormation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060351CF RID: 217551 RVA: 0x00721E1D File Offset: 0x0072001D
		public static void AddTeleportEntityId(FlatBufferBuilder builder, int teleportEntityId)
		{
			builder.AddInt(0, teleportEntityId, 0);
		}

		// Token: 0x060351D0 RID: 217552 RVA: 0x00721E28 File Offset: 0x00720028
		public static void AddRetainPhantom(FlatBufferBuilder builder, bool retainPhantom)
		{
			builder.AddBool(1, retainPhantom, false);
		}

		// Token: 0x060351D1 RID: 217553 RVA: 0x00721E33 File Offset: 0x00720033
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060351D2 RID: 217554 RVA: 0x00721E3E File Offset: 0x0072003E
		public static Offset<IRestorePhantomFormation> EndIRestorePhantomFormation(FlatBufferBuilder builder)
		{
			return new Offset<IRestorePhantomFormation>(builder.EndTable());
		}

		// Token: 0x060351D3 RID: 217555 RVA: 0x00721E4C File Offset: 0x0072004C
		public IRestorePhantomFormationT UnPack()
		{
			IRestorePhantomFormationT restorePhantomFormationT = new IRestorePhantomFormationT();
			this.UnPackTo(restorePhantomFormationT);
			return restorePhantomFormationT;
		}

		// Token: 0x060351D4 RID: 217556 RVA: 0x00721E67 File Offset: 0x00720067
		public void UnPackTo(IRestorePhantomFormationT _o)
		{
			_o.TeleportEntityId = this.TeleportEntityId;
			_o.RetainPhantom = this.RetainPhantom;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060351D5 RID: 217557 RVA: 0x00721E90 File Offset: 0x00720090
		public static Offset<IRestorePhantomFormation> Pack(FlatBufferBuilder builder, IRestorePhantomFormationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRestorePhantomFormation>);
			}
			return IRestorePhantomFormation.CreateIRestorePhantomFormation(builder, _o.TeleportEntityId, _o.RetainPhantom, _o.NullMask);
		}

		// Token: 0x04012830 RID: 75824
		private Table __p;
	}
}

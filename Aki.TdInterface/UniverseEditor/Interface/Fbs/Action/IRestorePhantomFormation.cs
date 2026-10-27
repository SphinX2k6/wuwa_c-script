using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB8 RID: 28344
	public struct IRestorePhantomFormation : IFlatbufferObject
	{
		// Token: 0x1700D2FA RID: 54010
		// (get) Token: 0x06032184 RID: 205188 RVA: 0x006C5F96 File Offset: 0x006C4196
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032185 RID: 205189 RVA: 0x006C5FA3 File Offset: 0x006C41A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032186 RID: 205190 RVA: 0x006C5FAC File Offset: 0x006C41AC
		public static IRestorePhantomFormation GetRootAsIRestorePhantomFormation(ByteBuffer _bb)
		{
			return IRestorePhantomFormation.GetRootAsIRestorePhantomFormation(_bb, default(IRestorePhantomFormation));
		}

		// Token: 0x06032187 RID: 205191 RVA: 0x006C5FC8 File Offset: 0x006C41C8
		public static IRestorePhantomFormation GetRootAsIRestorePhantomFormation(ByteBuffer _bb, IRestorePhantomFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032188 RID: 205192 RVA: 0x006C5FE5 File Offset: 0x006C41E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032189 RID: 205193 RVA: 0x006C5FF4 File Offset: 0x006C41F4
		public IRestorePhantomFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2FB RID: 54011
		// (get) Token: 0x0603218A RID: 205194 RVA: 0x006C6004 File Offset: 0x006C4204
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

		// Token: 0x1700D2FC RID: 54012
		// (get) Token: 0x0603218B RID: 205195 RVA: 0x006C6040 File Offset: 0x006C4240
		public bool RetainPhantom
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D2FD RID: 54013
		// (get) Token: 0x0603218C RID: 205196 RVA: 0x006C6080 File Offset: 0x006C4280
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

		// Token: 0x0603218D RID: 205197 RVA: 0x006C60BC File Offset: 0x006C42BC
		public static Offset<IRestorePhantomFormation> CreateIRestorePhantomFormation(FlatBufferBuilder builder, int TeleportEntityId = 0, bool RetainPhantom = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IRestorePhantomFormation.AddTeleportEntityId(builder, TeleportEntityId);
			IRestorePhantomFormation.AddNullMask(builder, NullMask);
			IRestorePhantomFormation.AddRetainPhantom(builder, RetainPhantom);
			return IRestorePhantomFormation.EndIRestorePhantomFormation(builder);
		}

		// Token: 0x0603218E RID: 205198 RVA: 0x006C60E0 File Offset: 0x006C42E0
		public static void StartIRestorePhantomFormation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603218F RID: 205199 RVA: 0x006C60E9 File Offset: 0x006C42E9
		public static void AddTeleportEntityId(FlatBufferBuilder builder, int teleportEntityId)
		{
			builder.AddInt(0, teleportEntityId, 0);
		}

		// Token: 0x06032190 RID: 205200 RVA: 0x006C60F4 File Offset: 0x006C42F4
		public static void AddRetainPhantom(FlatBufferBuilder builder, bool retainPhantom)
		{
			builder.AddBool(1, retainPhantom, false);
		}

		// Token: 0x06032191 RID: 205201 RVA: 0x006C60FF File Offset: 0x006C42FF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06032192 RID: 205202 RVA: 0x006C610A File Offset: 0x006C430A
		public static Offset<IRestorePhantomFormation> EndIRestorePhantomFormation(FlatBufferBuilder builder)
		{
			return new Offset<IRestorePhantomFormation>(builder.EndTable());
		}

		// Token: 0x06032193 RID: 205203 RVA: 0x006C6118 File Offset: 0x006C4318
		public IRestorePhantomFormationT UnPack()
		{
			IRestorePhantomFormationT restorePhantomFormationT = new IRestorePhantomFormationT();
			this.UnPackTo(restorePhantomFormationT);
			return restorePhantomFormationT;
		}

		// Token: 0x06032194 RID: 205204 RVA: 0x006C6133 File Offset: 0x006C4333
		public void UnPackTo(IRestorePhantomFormationT _o)
		{
			_o.TeleportEntityId = this.TeleportEntityId;
			_o.RetainPhantom = this.RetainPhantom;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032195 RID: 205205 RVA: 0x006C615C File Offset: 0x006C435C
		public static Offset<IRestorePhantomFormation> Pack(FlatBufferBuilder builder, IRestorePhantomFormationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRestorePhantomFormation>);
			}
			return IRestorePhantomFormation.CreateIRestorePhantomFormation(builder, _o.TeleportEntityId, _o.RetainPhantom, _o.NullMask);
		}

		// Token: 0x040118AB RID: 71851
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200724A RID: 29258
	public struct ISwingGetUp : IFlatbufferObject
	{
		// Token: 0x1700D918 RID: 55576
		// (get) Token: 0x06033E4C RID: 212556 RVA: 0x006FB12E File Offset: 0x006F932E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033E4D RID: 212557 RVA: 0x006FB13B File Offset: 0x006F933B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033E4E RID: 212558 RVA: 0x006FB144 File Offset: 0x006F9344
		public static ISwingGetUp GetRootAsISwingGetUp(ByteBuffer _bb)
		{
			return ISwingGetUp.GetRootAsISwingGetUp(_bb, default(ISwingGetUp));
		}

		// Token: 0x06033E4F RID: 212559 RVA: 0x006FB160 File Offset: 0x006F9360
		public static ISwingGetUp GetRootAsISwingGetUp(ByteBuffer _bb, ISwingGetUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033E50 RID: 212560 RVA: 0x006FB17D File Offset: 0x006F937D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033E51 RID: 212561 RVA: 0x006FB18C File Offset: 0x006F938C
		public ISwingGetUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D919 RID: 55577
		// (get) Token: 0x06033E52 RID: 212562 RVA: 0x006FB19C File Offset: 0x006F939C
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033E53 RID: 212563 RVA: 0x006FB1D8 File Offset: 0x006F93D8
		public static Offset<ISwingGetUp> CreateISwingGetUp(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ISwingGetUp.AddType(builder, Type);
			return ISwingGetUp.EndISwingGetUp(builder);
		}

		// Token: 0x06033E54 RID: 212564 RVA: 0x006FB1EE File Offset: 0x006F93EE
		public static void StartISwingGetUp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033E55 RID: 212565 RVA: 0x006FB1F7 File Offset: 0x006F93F7
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033E56 RID: 212566 RVA: 0x006FB202 File Offset: 0x006F9402
		public static Offset<ISwingGetUp> EndISwingGetUp(FlatBufferBuilder builder)
		{
			return new Offset<ISwingGetUp>(builder.EndTable());
		}

		// Token: 0x06033E57 RID: 212567 RVA: 0x006FB210 File Offset: 0x006F9410
		public ISwingGetUpT UnPack()
		{
			ISwingGetUpT swingGetUpT = new ISwingGetUpT();
			this.UnPackTo(swingGetUpT);
			return swingGetUpT;
		}

		// Token: 0x06033E58 RID: 212568 RVA: 0x006FB22B File Offset: 0x006F942B
		public void UnPackTo(ISwingGetUpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033E59 RID: 212569 RVA: 0x006FB23C File Offset: 0x006F943C
		public static Offset<ISwingGetUp> Pack(FlatBufferBuilder builder, ISwingGetUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwingGetUp>);
			}
			return ISwingGetUp.CreateISwingGetUp(builder, _o.Type);
		}

		// Token: 0x04011D3C RID: 73020
		private Table __p;
	}
}

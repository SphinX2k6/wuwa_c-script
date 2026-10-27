using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E4 RID: 27108
	public struct ILeisureInteractType : IFlatbufferObject
	{
		// Token: 0x1700C922 RID: 51490
		// (get) Token: 0x0602F669 RID: 194153 RVA: 0x00674FE4 File Offset: 0x006731E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F66A RID: 194154 RVA: 0x00674FF1 File Offset: 0x006731F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F66B RID: 194155 RVA: 0x00674FF8 File Offset: 0x006731F8
		public static ILeisureInteractType GetRootAsILeisureInteractType(ByteBuffer _bb)
		{
			return ILeisureInteractType.GetRootAsILeisureInteractType(_bb, default(ILeisureInteractType));
		}

		// Token: 0x0602F66C RID: 194156 RVA: 0x00675014 File Offset: 0x00673214
		public static ILeisureInteractType GetRootAsILeisureInteractType(ByteBuffer _bb, ILeisureInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F66D RID: 194157 RVA: 0x00675031 File Offset: 0x00673231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F66E RID: 194158 RVA: 0x00675040 File Offset: 0x00673240
		public ILeisureInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C923 RID: 51491
		// (get) Token: 0x0602F66F RID: 194159 RVA: 0x00675050 File Offset: 0x00673250
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

		// Token: 0x0602F670 RID: 194160 RVA: 0x0067508C File Offset: 0x0067328C
		public static Offset<ILeisureInteractType> CreateILeisureInteractType(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ILeisureInteractType.AddType(builder, Type);
			return ILeisureInteractType.EndILeisureInteractType(builder);
		}

		// Token: 0x0602F671 RID: 194161 RVA: 0x006750A2 File Offset: 0x006732A2
		public static void StartILeisureInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F672 RID: 194162 RVA: 0x006750AB File Offset: 0x006732AB
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F673 RID: 194163 RVA: 0x006750B6 File Offset: 0x006732B6
		public static Offset<ILeisureInteractType> EndILeisureInteractType(FlatBufferBuilder builder)
		{
			return new Offset<ILeisureInteractType>(builder.EndTable());
		}

		// Token: 0x0602F674 RID: 194164 RVA: 0x006750C4 File Offset: 0x006732C4
		public ILeisureInteractTypeT UnPack()
		{
			ILeisureInteractTypeT leisureInteractTypeT = new ILeisureInteractTypeT();
			this.UnPackTo(leisureInteractTypeT);
			return leisureInteractTypeT;
		}

		// Token: 0x0602F675 RID: 194165 RVA: 0x006750DF File Offset: 0x006732DF
		public void UnPackTo(ILeisureInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F676 RID: 194166 RVA: 0x006750F0 File Offset: 0x006732F0
		public static Offset<ILeisureInteractType> Pack(FlatBufferBuilder builder, ILeisureInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILeisureInteractType>);
			}
			return ILeisureInteractType.CreateILeisureInteractType(builder, _o.Type);
		}

		// Token: 0x040111A2 RID: 70050
		private Table __p;
	}
}

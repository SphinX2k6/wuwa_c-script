using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006861 RID: 26721
	public struct IFoxPutDown : IFlatbufferObject
	{
		// Token: 0x1700C67D RID: 50813
		// (get) Token: 0x0602E987 RID: 190855 RVA: 0x0065B13C File Offset: 0x0065933C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E988 RID: 190856 RVA: 0x0065B149 File Offset: 0x00659349
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E989 RID: 190857 RVA: 0x0065B150 File Offset: 0x00659350
		public static IFoxPutDown GetRootAsIFoxPutDown(ByteBuffer _bb)
		{
			return IFoxPutDown.GetRootAsIFoxPutDown(_bb, default(IFoxPutDown));
		}

		// Token: 0x0602E98A RID: 190858 RVA: 0x0065B16C File Offset: 0x0065936C
		public static IFoxPutDown GetRootAsIFoxPutDown(ByteBuffer _bb, IFoxPutDown obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E98B RID: 190859 RVA: 0x0065B189 File Offset: 0x00659389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E98C RID: 190860 RVA: 0x0065B198 File Offset: 0x00659398
		public IFoxPutDown __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C67E RID: 50814
		// (get) Token: 0x0602E98D RID: 190861 RVA: 0x0065B1A8 File Offset: 0x006593A8
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

		// Token: 0x0602E98E RID: 190862 RVA: 0x0065B1E4 File Offset: 0x006593E4
		public static Offset<IFoxPutDown> CreateIFoxPutDown(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IFoxPutDown.AddType(builder, Type);
			return IFoxPutDown.EndIFoxPutDown(builder);
		}

		// Token: 0x0602E98F RID: 190863 RVA: 0x0065B1FA File Offset: 0x006593FA
		public static void StartIFoxPutDown(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E990 RID: 190864 RVA: 0x0065B203 File Offset: 0x00659403
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E991 RID: 190865 RVA: 0x0065B20E File Offset: 0x0065940E
		public static Offset<IFoxPutDown> EndIFoxPutDown(FlatBufferBuilder builder)
		{
			return new Offset<IFoxPutDown>(builder.EndTable());
		}

		// Token: 0x0602E992 RID: 190866 RVA: 0x0065B21C File Offset: 0x0065941C
		public IFoxPutDownT UnPack()
		{
			IFoxPutDownT foxPutDownT = new IFoxPutDownT();
			this.UnPackTo(foxPutDownT);
			return foxPutDownT;
		}

		// Token: 0x0602E993 RID: 190867 RVA: 0x0065B237 File Offset: 0x00659437
		public void UnPackTo(IFoxPutDownT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E994 RID: 190868 RVA: 0x0065B248 File Offset: 0x00659448
		public static Offset<IFoxPutDown> Pack(FlatBufferBuilder builder, IFoxPutDownT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxPutDown>);
			}
			return IFoxPutDown.CreateIFoxPutDown(builder, _o.Type);
		}

		// Token: 0x04010FB1 RID: 69553
		private Table __p;
	}
}

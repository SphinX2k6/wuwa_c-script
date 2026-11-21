using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF6 RID: 28406
	public struct IFoxPutDown : IFlatbufferObject
	{
		// Token: 0x1700D051 RID: 53329
		// (get) Token: 0x0603126D RID: 201325 RVA: 0x006A99A8 File Offset: 0x006A7BA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603126E RID: 201326 RVA: 0x006A99B5 File Offset: 0x006A7BB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603126F RID: 201327 RVA: 0x006A99BC File Offset: 0x006A7BBC
		public static IFoxPutDown GetRootAsIFoxPutDown(ByteBuffer _bb)
		{
			return IFoxPutDown.GetRootAsIFoxPutDown(_bb, default(IFoxPutDown));
		}

		// Token: 0x06031270 RID: 201328 RVA: 0x006A99D8 File Offset: 0x006A7BD8
		public static IFoxPutDown GetRootAsIFoxPutDown(ByteBuffer _bb, IFoxPutDown obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031271 RID: 201329 RVA: 0x006A99F5 File Offset: 0x006A7BF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031272 RID: 201330 RVA: 0x006A9A04 File Offset: 0x006A7C04
		public IFoxPutDown __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D052 RID: 53330
		// (get) Token: 0x06031273 RID: 201331 RVA: 0x006A9A14 File Offset: 0x006A7C14
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

		// Token: 0x06031274 RID: 201332 RVA: 0x006A9A50 File Offset: 0x006A7C50
		public static Offset<IFoxPutDown> CreateIFoxPutDown(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IFoxPutDown.AddType(builder, Type);
			return IFoxPutDown.EndIFoxPutDown(builder);
		}

		// Token: 0x06031275 RID: 201333 RVA: 0x006A9A66 File Offset: 0x006A7C66
		public static void StartIFoxPutDown(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031276 RID: 201334 RVA: 0x006A9A6F File Offset: 0x006A7C6F
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031277 RID: 201335 RVA: 0x006A9A7A File Offset: 0x006A7C7A
		public static Offset<IFoxPutDown> EndIFoxPutDown(FlatBufferBuilder builder)
		{
			return new Offset<IFoxPutDown>(builder.EndTable());
		}

		// Token: 0x06031278 RID: 201336 RVA: 0x006A9A88 File Offset: 0x006A7C88
		public IFoxPutDownT UnPack()
		{
			IFoxPutDownT foxPutDownT = new IFoxPutDownT();
			this.UnPackTo(foxPutDownT);
			return foxPutDownT;
		}

		// Token: 0x06031279 RID: 201337 RVA: 0x006A9AA3 File Offset: 0x006A7CA3
		public void UnPackTo(IFoxPutDownT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603127A RID: 201338 RVA: 0x006A9AB4 File Offset: 0x006A7CB4
		public static Offset<IFoxPutDown> Pack(FlatBufferBuilder builder, IFoxPutDownT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxPutDown>);
			}
			return IFoxPutDown.CreateIFoxPutDown(builder, _o.Type);
		}

		// Token: 0x04011DFB RID: 73211
		private Table __p;
	}
}

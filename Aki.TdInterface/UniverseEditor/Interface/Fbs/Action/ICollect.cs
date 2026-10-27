using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200644B RID: 25675
	public struct ICollect : IFlatbufferObject
	{
		// Token: 0x1700BF22 RID: 48930
		// (get) Token: 0x0602C6F4 RID: 182004 RVA: 0x006186A5 File Offset: 0x006168A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C6F5 RID: 182005 RVA: 0x006186B2 File Offset: 0x006168B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C6F6 RID: 182006 RVA: 0x006186BC File Offset: 0x006168BC
		public static ICollect GetRootAsICollect(ByteBuffer _bb)
		{
			return ICollect.GetRootAsICollect(_bb, default(ICollect));
		}

		// Token: 0x0602C6F7 RID: 182007 RVA: 0x006186D8 File Offset: 0x006168D8
		public static ICollect GetRootAsICollect(ByteBuffer _bb, ICollect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C6F8 RID: 182008 RVA: 0x006186F5 File Offset: 0x006168F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C6F9 RID: 182009 RVA: 0x00618704 File Offset: 0x00616904
		public ICollect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF23 RID: 48931
		// (get) Token: 0x0602C6FA RID: 182010 RVA: 0x00618714 File Offset: 0x00616914
		public int TargetEntity
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

		// Token: 0x1700BF24 RID: 48932
		// (get) Token: 0x0602C6FB RID: 182011 RVA: 0x00618750 File Offset: 0x00616950
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C6FC RID: 182012 RVA: 0x0061878C File Offset: 0x0061698C
		public static Offset<ICollect> CreateICollect(FlatBufferBuilder builder, int TargetEntity = 0, byte NullMask = 0)
		{
			builder.StartTable(2);
			ICollect.AddTargetEntity(builder, TargetEntity);
			ICollect.AddNullMask(builder, NullMask);
			return ICollect.EndICollect(builder);
		}

		// Token: 0x0602C6FD RID: 182013 RVA: 0x006187A9 File Offset: 0x006169A9
		public static void StartICollect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C6FE RID: 182014 RVA: 0x006187B2 File Offset: 0x006169B2
		public static void AddTargetEntity(FlatBufferBuilder builder, int targetEntity)
		{
			builder.AddInt(0, targetEntity, 0);
		}

		// Token: 0x0602C6FF RID: 182015 RVA: 0x006187BD File Offset: 0x006169BD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602C700 RID: 182016 RVA: 0x006187C8 File Offset: 0x006169C8
		public static Offset<ICollect> EndICollect(FlatBufferBuilder builder)
		{
			return new Offset<ICollect>(builder.EndTable());
		}

		// Token: 0x0602C701 RID: 182017 RVA: 0x006187D8 File Offset: 0x006169D8
		public ICollectT UnPack()
		{
			ICollectT collectT = new ICollectT();
			this.UnPackTo(collectT);
			return collectT;
		}

		// Token: 0x0602C702 RID: 182018 RVA: 0x006187F3 File Offset: 0x006169F3
		public void UnPackTo(ICollectT _o)
		{
			_o.TargetEntity = this.TargetEntity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C703 RID: 182019 RVA: 0x00618810 File Offset: 0x00616A10
		public static Offset<ICollect> Pack(FlatBufferBuilder builder, ICollectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICollect>);
			}
			return ICollect.CreateICollect(builder, _o.TargetEntity, _o.NullMask);
		}

		// Token: 0x04010A49 RID: 68169
		private Table __p;
	}
}

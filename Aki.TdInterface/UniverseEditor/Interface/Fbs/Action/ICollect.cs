using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB9 RID: 27321
	public struct ICollect : IFlatbufferObject
	{
		// Token: 0x1700C8A9 RID: 51369
		// (get) Token: 0x0602EE57 RID: 192087 RVA: 0x006639E5 File Offset: 0x00661BE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EE58 RID: 192088 RVA: 0x006639F2 File Offset: 0x00661BF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EE59 RID: 192089 RVA: 0x006639FC File Offset: 0x00661BFC
		public static ICollect GetRootAsICollect(ByteBuffer _bb)
		{
			return ICollect.GetRootAsICollect(_bb, default(ICollect));
		}

		// Token: 0x0602EE5A RID: 192090 RVA: 0x00663A18 File Offset: 0x00661C18
		public static ICollect GetRootAsICollect(ByteBuffer _bb, ICollect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EE5B RID: 192091 RVA: 0x00663A35 File Offset: 0x00661C35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EE5C RID: 192092 RVA: 0x00663A44 File Offset: 0x00661C44
		public ICollect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8AA RID: 51370
		// (get) Token: 0x0602EE5D RID: 192093 RVA: 0x00663A54 File Offset: 0x00661C54
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

		// Token: 0x1700C8AB RID: 51371
		// (get) Token: 0x0602EE5E RID: 192094 RVA: 0x00663A90 File Offset: 0x00661C90
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

		// Token: 0x0602EE5F RID: 192095 RVA: 0x00663ACC File Offset: 0x00661CCC
		public static Offset<ICollect> CreateICollect(FlatBufferBuilder builder, int TargetEntity = 0, byte NullMask = 0)
		{
			builder.StartTable(2);
			ICollect.AddTargetEntity(builder, TargetEntity);
			ICollect.AddNullMask(builder, NullMask);
			return ICollect.EndICollect(builder);
		}

		// Token: 0x0602EE60 RID: 192096 RVA: 0x00663AE9 File Offset: 0x00661CE9
		public static void StartICollect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EE61 RID: 192097 RVA: 0x00663AF2 File Offset: 0x00661CF2
		public static void AddTargetEntity(FlatBufferBuilder builder, int targetEntity)
		{
			builder.AddInt(0, targetEntity, 0);
		}

		// Token: 0x0602EE62 RID: 192098 RVA: 0x00663AFD File Offset: 0x00661CFD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602EE63 RID: 192099 RVA: 0x00663B08 File Offset: 0x00661D08
		public static Offset<ICollect> EndICollect(FlatBufferBuilder builder)
		{
			return new Offset<ICollect>(builder.EndTable());
		}

		// Token: 0x0602EE64 RID: 192100 RVA: 0x00663B18 File Offset: 0x00661D18
		public ICollectT UnPack()
		{
			ICollectT collectT = new ICollectT();
			this.UnPackTo(collectT);
			return collectT;
		}

		// Token: 0x0602EE65 RID: 192101 RVA: 0x00663B33 File Offset: 0x00661D33
		public void UnPackTo(ICollectT _o)
		{
			_o.TargetEntity = this.TargetEntity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602EE66 RID: 192102 RVA: 0x00663B50 File Offset: 0x00661D50
		public static Offset<ICollect> Pack(FlatBufferBuilder builder, ICollectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICollect>);
			}
			return ICollect.CreateICollect(builder, _o.TargetEntity, _o.NullMask);
		}

		// Token: 0x0401185C RID: 71772
		private Table __p;
	}
}

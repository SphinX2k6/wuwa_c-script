using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007609 RID: 30217
	public struct IResetEntityPos : IFlatbufferObject
	{
		// Token: 0x1700DE08 RID: 56840
		// (get) Token: 0x06035049 RID: 217161 RVA: 0x0071F538 File Offset: 0x0071D738
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603504A RID: 217162 RVA: 0x0071F545 File Offset: 0x0071D745
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603504B RID: 217163 RVA: 0x0071F54C File Offset: 0x0071D74C
		public static IResetEntityPos GetRootAsIResetEntityPos(ByteBuffer _bb)
		{
			return IResetEntityPos.GetRootAsIResetEntityPos(_bb, default(IResetEntityPos));
		}

		// Token: 0x0603504C RID: 217164 RVA: 0x0071F568 File Offset: 0x0071D768
		public static IResetEntityPos GetRootAsIResetEntityPos(ByteBuffer _bb, IResetEntityPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603504D RID: 217165 RVA: 0x0071F585 File Offset: 0x0071D785
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603504E RID: 217166 RVA: 0x0071F594 File Offset: 0x0071D794
		public IResetEntityPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE09 RID: 56841
		// (get) Token: 0x0603504F RID: 217167 RVA: 0x0071F5A4 File Offset: 0x0071D7A4
		public int EntityId
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

		// Token: 0x06035050 RID: 217168 RVA: 0x0071F5E0 File Offset: 0x0071D7E0
		public static Offset<IResetEntityPos> CreateIResetEntityPos(FlatBufferBuilder builder, int EntityId = 0)
		{
			builder.StartTable(1);
			IResetEntityPos.AddEntityId(builder, EntityId);
			return IResetEntityPos.EndIResetEntityPos(builder);
		}

		// Token: 0x06035051 RID: 217169 RVA: 0x0071F5F6 File Offset: 0x0071D7F6
		public static void StartIResetEntityPos(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035052 RID: 217170 RVA: 0x0071F5FF File Offset: 0x0071D7FF
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06035053 RID: 217171 RVA: 0x0071F60A File Offset: 0x0071D80A
		public static Offset<IResetEntityPos> EndIResetEntityPos(FlatBufferBuilder builder)
		{
			return new Offset<IResetEntityPos>(builder.EndTable());
		}

		// Token: 0x06035054 RID: 217172 RVA: 0x0071F618 File Offset: 0x0071D818
		public IResetEntityPosT UnPack()
		{
			IResetEntityPosT resetEntityPosT = new IResetEntityPosT();
			this.UnPackTo(resetEntityPosT);
			return resetEntityPosT;
		}

		// Token: 0x06035055 RID: 217173 RVA: 0x0071F633 File Offset: 0x0071D833
		public void UnPackTo(IResetEntityPosT _o)
		{
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06035056 RID: 217174 RVA: 0x0071F644 File Offset: 0x0071D844
		public static Offset<IResetEntityPos> Pack(FlatBufferBuilder builder, IResetEntityPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetEntityPos>);
			}
			return IResetEntityPos.CreateIResetEntityPos(builder, _o.EntityId);
		}

		// Token: 0x040127F8 RID: 75768
		private Table __p;
	}
}

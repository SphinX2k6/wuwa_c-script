using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C49 RID: 19529
	public struct IInstEntityData : IFlatbufferObject
	{
		// Token: 0x17008A8B RID: 35467
		// (get) Token: 0x0601DF2B RID: 122667 RVA: 0x00433018 File Offset: 0x00431218
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DF2C RID: 122668 RVA: 0x00433025 File Offset: 0x00431225
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DF2D RID: 122669 RVA: 0x0043302C File Offset: 0x0043122C
		public static IInstEntityData GetRootAsIInstEntityData(ByteBuffer _bb)
		{
			return IInstEntityData.GetRootAsIInstEntityData(_bb, default(IInstEntityData));
		}

		// Token: 0x0601DF2E RID: 122670 RVA: 0x00433048 File Offset: 0x00431248
		public static IInstEntityData GetRootAsIInstEntityData(ByteBuffer _bb, IInstEntityData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DF2F RID: 122671 RVA: 0x00433065 File Offset: 0x00431265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DF30 RID: 122672 RVA: 0x00433074 File Offset: 0x00431274
		public IInstEntityData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A8C RID: 35468
		// (get) Token: 0x0601DF31 RID: 122673 RVA: 0x00433084 File Offset: 0x00431284
		public int InstId
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

		// Token: 0x17008A8D RID: 35469
		// (get) Token: 0x0601DF32 RID: 122674 RVA: 0x004330C0 File Offset: 0x004312C0
		public int EntityConfigId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DF33 RID: 122675 RVA: 0x004330FC File Offset: 0x004312FC
		public static Offset<IInstEntityData> CreateIInstEntityData(FlatBufferBuilder builder, int InstId = 0, int EntityConfigId = 0)
		{
			builder.StartTable(2);
			IInstEntityData.AddEntityConfigId(builder, EntityConfigId);
			IInstEntityData.AddInstId(builder, InstId);
			return IInstEntityData.EndIInstEntityData(builder);
		}

		// Token: 0x0601DF34 RID: 122676 RVA: 0x00433119 File Offset: 0x00431319
		public static void StartIInstEntityData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DF35 RID: 122677 RVA: 0x00433122 File Offset: 0x00431322
		public static void AddInstId(FlatBufferBuilder builder, int instId)
		{
			builder.AddInt(0, instId, 0);
		}

		// Token: 0x0601DF36 RID: 122678 RVA: 0x0043312D File Offset: 0x0043132D
		public static void AddEntityConfigId(FlatBufferBuilder builder, int entityConfigId)
		{
			builder.AddInt(1, entityConfigId, 0);
		}

		// Token: 0x0601DF37 RID: 122679 RVA: 0x00433138 File Offset: 0x00431338
		public static Offset<IInstEntityData> EndIInstEntityData(FlatBufferBuilder builder)
		{
			return new Offset<IInstEntityData>(builder.EndTable());
		}

		// Token: 0x0601DF38 RID: 122680 RVA: 0x00433148 File Offset: 0x00431348
		public IInstEntityDataT UnPack()
		{
			IInstEntityDataT instEntityDataT = new IInstEntityDataT();
			this.UnPackTo(instEntityDataT);
			return instEntityDataT;
		}

		// Token: 0x0601DF39 RID: 122681 RVA: 0x00433163 File Offset: 0x00431363
		public void UnPackTo(IInstEntityDataT _o)
		{
			_o.InstId = this.InstId;
			_o.EntityConfigId = this.EntityConfigId;
		}

		// Token: 0x0601DF3A RID: 122682 RVA: 0x00433180 File Offset: 0x00431380
		public static Offset<IInstEntityData> Pack(FlatBufferBuilder builder, IInstEntityDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInstEntityData>);
			}
			return IInstEntityData.CreateIInstEntityData(builder, _o.InstId, _o.EntityConfigId);
		}

		// Token: 0x0400D6B3 RID: 54963
		private Table __p;
	}
}

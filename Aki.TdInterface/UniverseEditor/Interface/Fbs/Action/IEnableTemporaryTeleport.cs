using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D13 RID: 27923
	public struct IEnableTemporaryTeleport : IFlatbufferObject
	{
		// Token: 0x1700CCE2 RID: 52450
		// (get) Token: 0x06030286 RID: 197254 RVA: 0x0068C8FD File Offset: 0x0068AAFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030287 RID: 197255 RVA: 0x0068C90A File Offset: 0x0068AB0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030288 RID: 197256 RVA: 0x0068C914 File Offset: 0x0068AB14
		public static IEnableTemporaryTeleport GetRootAsIEnableTemporaryTeleport(ByteBuffer _bb)
		{
			return IEnableTemporaryTeleport.GetRootAsIEnableTemporaryTeleport(_bb, default(IEnableTemporaryTeleport));
		}

		// Token: 0x06030289 RID: 197257 RVA: 0x0068C930 File Offset: 0x0068AB30
		public static IEnableTemporaryTeleport GetRootAsIEnableTemporaryTeleport(ByteBuffer _bb, IEnableTemporaryTeleport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603028A RID: 197258 RVA: 0x0068C94D File Offset: 0x0068AB4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603028B RID: 197259 RVA: 0x0068C95C File Offset: 0x0068AB5C
		public IEnableTemporaryTeleport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCE3 RID: 52451
		// (get) Token: 0x0603028C RID: 197260 RVA: 0x0068C96C File Offset: 0x0068AB6C
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCE4 RID: 52452
		// (get) Token: 0x0603028D RID: 197261 RVA: 0x0068C9AC File Offset: 0x0068ABAC
		public int RangeEntity
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

		// Token: 0x0603028E RID: 197262 RVA: 0x0068C9E8 File Offset: 0x0068ABE8
		public static Offset<IEnableTemporaryTeleport> CreateIEnableTemporaryTeleport(FlatBufferBuilder builder, bool Enable = false, int RangeEntity = 0)
		{
			builder.StartTable(2);
			IEnableTemporaryTeleport.AddRangeEntity(builder, RangeEntity);
			IEnableTemporaryTeleport.AddEnable(builder, Enable);
			return IEnableTemporaryTeleport.EndIEnableTemporaryTeleport(builder);
		}

		// Token: 0x0603028F RID: 197263 RVA: 0x0068CA05 File Offset: 0x0068AC05
		public static void StartIEnableTemporaryTeleport(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030290 RID: 197264 RVA: 0x0068CA0E File Offset: 0x0068AC0E
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(0, enable, false);
		}

		// Token: 0x06030291 RID: 197265 RVA: 0x0068CA19 File Offset: 0x0068AC19
		public static void AddRangeEntity(FlatBufferBuilder builder, int rangeEntity)
		{
			builder.AddInt(1, rangeEntity, 0);
		}

		// Token: 0x06030292 RID: 197266 RVA: 0x0068CA24 File Offset: 0x0068AC24
		public static Offset<IEnableTemporaryTeleport> EndIEnableTemporaryTeleport(FlatBufferBuilder builder)
		{
			return new Offset<IEnableTemporaryTeleport>(builder.EndTable());
		}

		// Token: 0x06030293 RID: 197267 RVA: 0x0068CA34 File Offset: 0x0068AC34
		public IEnableTemporaryTeleportT UnPack()
		{
			IEnableTemporaryTeleportT enableTemporaryTeleportT = new IEnableTemporaryTeleportT();
			this.UnPackTo(enableTemporaryTeleportT);
			return enableTemporaryTeleportT;
		}

		// Token: 0x06030294 RID: 197268 RVA: 0x0068CA4F File Offset: 0x0068AC4F
		public void UnPackTo(IEnableTemporaryTeleportT _o)
		{
			_o.Enable = this.Enable;
			_o.RangeEntity = this.RangeEntity;
		}

		// Token: 0x06030295 RID: 197269 RVA: 0x0068CA6C File Offset: 0x0068AC6C
		public static Offset<IEnableTemporaryTeleport> Pack(FlatBufferBuilder builder, IEnableTemporaryTeleportT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableTemporaryTeleport>);
			}
			return IEnableTemporaryTeleport.CreateIEnableTemporaryTeleport(builder, _o.Enable, _o.RangeEntity);
		}

		// Token: 0x04011B7A RID: 72570
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A6A RID: 31338
	public struct ITalkBackgroundClean : IFlatbufferObject
	{
		// Token: 0x1700E589 RID: 58761
		// (get) Token: 0x060373A9 RID: 226217 RVA: 0x007605BD File Offset: 0x0075E7BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060373AA RID: 226218 RVA: 0x007605CA File Offset: 0x0075E7CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060373AB RID: 226219 RVA: 0x007605D4 File Offset: 0x0075E7D4
		public static ITalkBackgroundClean GetRootAsITalkBackgroundClean(ByteBuffer _bb)
		{
			return ITalkBackgroundClean.GetRootAsITalkBackgroundClean(_bb, default(ITalkBackgroundClean));
		}

		// Token: 0x060373AC RID: 226220 RVA: 0x007605F0 File Offset: 0x0075E7F0
		public static ITalkBackgroundClean GetRootAsITalkBackgroundClean(ByteBuffer _bb, ITalkBackgroundClean obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060373AD RID: 226221 RVA: 0x0076060D File Offset: 0x0075E80D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060373AE RID: 226222 RVA: 0x0076061C File Offset: 0x0075E81C
		public ITalkBackgroundClean __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E58A RID: 58762
		// (get) Token: 0x060373AF RID: 226223 RVA: 0x0076062C File Offset: 0x0075E82C
		public ETalkBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkBackgroundType.Clean;
				}
				return (ETalkBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060373B0 RID: 226224 RVA: 0x00760668 File Offset: 0x0075E868
		public static Offset<ITalkBackgroundClean> CreateITalkBackgroundClean(FlatBufferBuilder builder, ETalkBackgroundType Type = ETalkBackgroundType.Clean)
		{
			builder.StartTable(1);
			ITalkBackgroundClean.AddType(builder, Type);
			return ITalkBackgroundClean.EndITalkBackgroundClean(builder);
		}

		// Token: 0x060373B1 RID: 226225 RVA: 0x0076067E File Offset: 0x0075E87E
		public static void StartITalkBackgroundClean(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060373B2 RID: 226226 RVA: 0x00760687 File Offset: 0x0075E887
		public static void AddType(FlatBufferBuilder builder, ETalkBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060373B3 RID: 226227 RVA: 0x00760692 File Offset: 0x0075E892
		public static Offset<ITalkBackgroundClean> EndITalkBackgroundClean(FlatBufferBuilder builder)
		{
			return new Offset<ITalkBackgroundClean>(builder.EndTable());
		}

		// Token: 0x060373B4 RID: 226228 RVA: 0x007606A0 File Offset: 0x0075E8A0
		public ITalkBackgroundCleanT UnPack()
		{
			ITalkBackgroundCleanT talkBackgroundCleanT = new ITalkBackgroundCleanT();
			this.UnPackTo(talkBackgroundCleanT);
			return talkBackgroundCleanT;
		}

		// Token: 0x060373B5 RID: 226229 RVA: 0x007606BB File Offset: 0x0075E8BB
		public void UnPackTo(ITalkBackgroundCleanT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060373B6 RID: 226230 RVA: 0x007606CC File Offset: 0x0075E8CC
		public static Offset<ITalkBackgroundClean> Pack(FlatBufferBuilder builder, ITalkBackgroundCleanT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkBackgroundClean>);
			}
			return ITalkBackgroundClean.CreateITalkBackgroundClean(builder, _o.Type);
		}

		// Token: 0x04012DA3 RID: 77219
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C25 RID: 19493
	public struct IEntityOwnerInfo : IFlatbufferObject
	{
		// Token: 0x17008A2E RID: 35374
		// (get) Token: 0x0601DD8A RID: 122250 RVA: 0x0042F998 File Offset: 0x0042DB98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DD8B RID: 122251 RVA: 0x0042F9A5 File Offset: 0x0042DBA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DD8C RID: 122252 RVA: 0x0042F9AC File Offset: 0x0042DBAC
		public static IEntityOwnerInfo GetRootAsIEntityOwnerInfo(ByteBuffer _bb)
		{
			return IEntityOwnerInfo.GetRootAsIEntityOwnerInfo(_bb, default(IEntityOwnerInfo));
		}

		// Token: 0x0601DD8D RID: 122253 RVA: 0x0042F9C8 File Offset: 0x0042DBC8
		public static IEntityOwnerInfo GetRootAsIEntityOwnerInfo(ByteBuffer _bb, IEntityOwnerInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DD8E RID: 122254 RVA: 0x0042F9E5 File Offset: 0x0042DBE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DD8F RID: 122255 RVA: 0x0042F9F4 File Offset: 0x0042DBF4
		public IEntityOwnerInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A2F RID: 35375
		// (get) Token: 0x0601DD90 RID: 122256 RVA: 0x0042FA04 File Offset: 0x0042DC04
		public EEntityOwnerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityOwnerType.Quest;
				}
				return (EEntityOwnerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DD91 RID: 122257 RVA: 0x0042FA40 File Offset: 0x0042DC40
		public static Offset<IEntityOwnerInfo> CreateIEntityOwnerInfo(FlatBufferBuilder builder, EEntityOwnerType Type = EEntityOwnerType.Quest)
		{
			builder.StartTable(1);
			IEntityOwnerInfo.AddType(builder, Type);
			return IEntityOwnerInfo.EndIEntityOwnerInfo(builder);
		}

		// Token: 0x0601DD92 RID: 122258 RVA: 0x0042FA56 File Offset: 0x0042DC56
		public static void StartIEntityOwnerInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DD93 RID: 122259 RVA: 0x0042FA5F File Offset: 0x0042DC5F
		public static void AddType(FlatBufferBuilder builder, EEntityOwnerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DD94 RID: 122260 RVA: 0x0042FA6A File Offset: 0x0042DC6A
		public static Offset<IEntityOwnerInfo> EndIEntityOwnerInfo(FlatBufferBuilder builder)
		{
			return new Offset<IEntityOwnerInfo>(builder.EndTable());
		}

		// Token: 0x0601DD95 RID: 122261 RVA: 0x0042FA78 File Offset: 0x0042DC78
		public IEntityOwnerInfoT UnPack()
		{
			IEntityOwnerInfoT entityOwnerInfoT = new IEntityOwnerInfoT();
			this.UnPackTo(entityOwnerInfoT);
			return entityOwnerInfoT;
		}

		// Token: 0x0601DD96 RID: 122262 RVA: 0x0042FA93 File Offset: 0x0042DC93
		public void UnPackTo(IEntityOwnerInfoT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601DD97 RID: 122263 RVA: 0x0042FAA4 File Offset: 0x0042DCA4
		public static Offset<IEntityOwnerInfo> Pack(FlatBufferBuilder builder, IEntityOwnerInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityOwnerInfo>);
			}
			return IEntityOwnerInfo.CreateIEntityOwnerInfo(builder, _o.Type);
		}

		// Token: 0x0400D678 RID: 54904
		private Table __p;
	}
}

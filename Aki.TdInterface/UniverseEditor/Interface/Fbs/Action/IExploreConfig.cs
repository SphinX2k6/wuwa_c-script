using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200673E RID: 26430
	public struct IExploreConfig : IFlatbufferObject
	{
		// Token: 0x1700C43E RID: 50238
		// (get) Token: 0x0602DF8F RID: 188303 RVA: 0x006489A0 File Offset: 0x00646BA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DF90 RID: 188304 RVA: 0x006489AD File Offset: 0x00646BAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DF91 RID: 188305 RVA: 0x006489B4 File Offset: 0x00646BB4
		public static IExploreConfig GetRootAsIExploreConfig(ByteBuffer _bb)
		{
			return IExploreConfig.GetRootAsIExploreConfig(_bb, default(IExploreConfig));
		}

		// Token: 0x0602DF92 RID: 188306 RVA: 0x006489D0 File Offset: 0x00646BD0
		public static IExploreConfig GetRootAsIExploreConfig(ByteBuffer _bb, IExploreConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DF93 RID: 188307 RVA: 0x006489ED File Offset: 0x00646BED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DF94 RID: 188308 RVA: 0x006489FC File Offset: 0x00646BFC
		public IExploreConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C43F RID: 50239
		// (get) Token: 0x0602DF95 RID: 188309 RVA: 0x00648A0C File Offset: 0x00646C0C
		public EExploreStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreStateType.TeleControl;
				}
				return (EExploreStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DF96 RID: 188310 RVA: 0x00648A48 File Offset: 0x00646C48
		public static Offset<IExploreConfig> CreateIExploreConfig(FlatBufferBuilder builder, EExploreStateType Type = EExploreStateType.TeleControl)
		{
			builder.StartTable(1);
			IExploreConfig.AddType(builder, Type);
			return IExploreConfig.EndIExploreConfig(builder);
		}

		// Token: 0x0602DF97 RID: 188311 RVA: 0x00648A5E File Offset: 0x00646C5E
		public static void StartIExploreConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DF98 RID: 188312 RVA: 0x00648A67 File Offset: 0x00646C67
		public static void AddType(FlatBufferBuilder builder, EExploreStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DF99 RID: 188313 RVA: 0x00648A72 File Offset: 0x00646C72
		public static Offset<IExploreConfig> EndIExploreConfig(FlatBufferBuilder builder)
		{
			return new Offset<IExploreConfig>(builder.EndTable());
		}

		// Token: 0x0602DF9A RID: 188314 RVA: 0x00648A80 File Offset: 0x00646C80
		public IExploreConfigT UnPack()
		{
			IExploreConfigT exploreConfigT = new IExploreConfigT();
			this.UnPackTo(exploreConfigT);
			return exploreConfigT;
		}

		// Token: 0x0602DF9B RID: 188315 RVA: 0x00648A9B File Offset: 0x00646C9B
		public void UnPackTo(IExploreConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DF9C RID: 188316 RVA: 0x00648AAC File Offset: 0x00646CAC
		public static Offset<IExploreConfig> Pack(FlatBufferBuilder builder, IExploreConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreConfig>);
			}
			return IExploreConfig.CreateIExploreConfig(builder, _o.Type);
		}

		// Token: 0x04010E26 RID: 69158
		private Table __p;
	}
}

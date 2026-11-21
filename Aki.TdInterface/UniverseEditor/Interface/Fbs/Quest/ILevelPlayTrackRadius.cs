using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004343 RID: 17219
	public struct ILevelPlayTrackRadius : IFlatbufferObject
	{
		// Token: 0x170075D8 RID: 30168
		// (get) Token: 0x060183C3 RID: 99267 RVA: 0x00374487 File Offset: 0x00372687
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060183C4 RID: 99268 RVA: 0x00374494 File Offset: 0x00372694
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060183C5 RID: 99269 RVA: 0x0037449C File Offset: 0x0037269C
		public static ILevelPlayTrackRadius GetRootAsILevelPlayTrackRadius(ByteBuffer _bb)
		{
			return ILevelPlayTrackRadius.GetRootAsILevelPlayTrackRadius(_bb, default(ILevelPlayTrackRadius));
		}

		// Token: 0x060183C6 RID: 99270 RVA: 0x003744B8 File Offset: 0x003726B8
		public static ILevelPlayTrackRadius GetRootAsILevelPlayTrackRadius(ByteBuffer _bb, ILevelPlayTrackRadius obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060183C7 RID: 99271 RVA: 0x003744D5 File Offset: 0x003726D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060183C8 RID: 99272 RVA: 0x003744E4 File Offset: 0x003726E4
		public ILevelPlayTrackRadius __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075D9 RID: 30169
		// (get) Token: 0x060183C9 RID: 99273 RVA: 0x003744F4 File Offset: 0x003726F4
		public int TrackRadius
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

		// Token: 0x060183CA RID: 99274 RVA: 0x00374530 File Offset: 0x00372730
		public static Offset<ILevelPlayTrackRadius> CreateILevelPlayTrackRadius(FlatBufferBuilder builder, int TrackRadius = 0)
		{
			builder.StartTable(1);
			ILevelPlayTrackRadius.AddTrackRadius(builder, TrackRadius);
			return ILevelPlayTrackRadius.EndILevelPlayTrackRadius(builder);
		}

		// Token: 0x060183CB RID: 99275 RVA: 0x00374546 File Offset: 0x00372746
		public static void StartILevelPlayTrackRadius(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060183CC RID: 99276 RVA: 0x0037454F File Offset: 0x0037274F
		public static void AddTrackRadius(FlatBufferBuilder builder, int trackRadius)
		{
			builder.AddInt(0, trackRadius, 0);
		}

		// Token: 0x060183CD RID: 99277 RVA: 0x0037455A File Offset: 0x0037275A
		public static Offset<ILevelPlayTrackRadius> EndILevelPlayTrackRadius(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayTrackRadius>(builder.EndTable());
		}

		// Token: 0x060183CE RID: 99278 RVA: 0x00374568 File Offset: 0x00372768
		public ILevelPlayTrackRadiusT UnPack()
		{
			ILevelPlayTrackRadiusT levelPlayTrackRadiusT = new ILevelPlayTrackRadiusT();
			this.UnPackTo(levelPlayTrackRadiusT);
			return levelPlayTrackRadiusT;
		}

		// Token: 0x060183CF RID: 99279 RVA: 0x00374583 File Offset: 0x00372783
		public void UnPackTo(ILevelPlayTrackRadiusT _o)
		{
			_o.TrackRadius = this.TrackRadius;
		}

		// Token: 0x060183D0 RID: 99280 RVA: 0x00374594 File Offset: 0x00372794
		public static Offset<ILevelPlayTrackRadius> Pack(FlatBufferBuilder builder, ILevelPlayTrackRadiusT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayTrackRadius>);
			}
			return ILevelPlayTrackRadius.CreateILevelPlayTrackRadius(builder, _o.TrackRadius);
		}

		// Token: 0x0400C2C0 RID: 49856
		private Table __p;
	}
}

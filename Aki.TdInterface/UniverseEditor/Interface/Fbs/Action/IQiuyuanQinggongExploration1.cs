using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE0 RID: 28128
	public struct IQiuyuanQinggongExploration1 : IFlatbufferObject
	{
		// Token: 0x1700D1AE RID: 53678
		// (get) Token: 0x06031AEF RID: 203503 RVA: 0x006BA9F5 File Offset: 0x006B8BF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031AF0 RID: 203504 RVA: 0x006BAA02 File Offset: 0x006B8C02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031AF1 RID: 203505 RVA: 0x006BAA0C File Offset: 0x006B8C0C
		public static IQiuyuanQinggongExploration1 GetRootAsIQiuyuanQinggongExploration1(ByteBuffer _bb)
		{
			return IQiuyuanQinggongExploration1.GetRootAsIQiuyuanQinggongExploration1(_bb, default(IQiuyuanQinggongExploration1));
		}

		// Token: 0x06031AF2 RID: 203506 RVA: 0x006BAA28 File Offset: 0x006B8C28
		public static IQiuyuanQinggongExploration1 GetRootAsIQiuyuanQinggongExploration1(ByteBuffer _bb, IQiuyuanQinggongExploration1 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031AF3 RID: 203507 RVA: 0x006BAA45 File Offset: 0x006B8C45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031AF4 RID: 203508 RVA: 0x006BAA54 File Offset: 0x006B8C54
		public IQiuyuanQinggongExploration1 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1AF RID: 53679
		// (get) Token: 0x06031AF5 RID: 203509 RVA: 0x006BAA64 File Offset: 0x006B8C64
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

		// Token: 0x06031AF6 RID: 203510 RVA: 0x006BAAA0 File Offset: 0x006B8CA0
		public static Offset<IQiuyuanQinggongExploration1> CreateIQiuyuanQinggongExploration1(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongExploration1.AddType(builder, Type);
			return IQiuyuanQinggongExploration1.EndIQiuyuanQinggongExploration1(builder);
		}

		// Token: 0x06031AF7 RID: 203511 RVA: 0x006BAAB6 File Offset: 0x006B8CB6
		public static void StartIQiuyuanQinggongExploration1(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031AF8 RID: 203512 RVA: 0x006BAABF File Offset: 0x006B8CBF
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031AF9 RID: 203513 RVA: 0x006BAACA File Offset: 0x006B8CCA
		public static Offset<IQiuyuanQinggongExploration1> EndIQiuyuanQinggongExploration1(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongExploration1>(builder.EndTable());
		}

		// Token: 0x06031AFA RID: 203514 RVA: 0x006BAAD8 File Offset: 0x006B8CD8
		public IQiuyuanQinggongExploration1T UnPack()
		{
			IQiuyuanQinggongExploration1T qiuyuanQinggongExploration1T = new IQiuyuanQinggongExploration1T();
			this.UnPackTo(qiuyuanQinggongExploration1T);
			return qiuyuanQinggongExploration1T;
		}

		// Token: 0x06031AFB RID: 203515 RVA: 0x006BAAF3 File Offset: 0x006B8CF3
		public void UnPackTo(IQiuyuanQinggongExploration1T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031AFC RID: 203516 RVA: 0x006BAB04 File Offset: 0x006B8D04
		public static Offset<IQiuyuanQinggongExploration1> Pack(FlatBufferBuilder builder, IQiuyuanQinggongExploration1T _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongExploration1>);
			}
			return IQiuyuanQinggongExploration1.CreateIQiuyuanQinggongExploration1(builder, _o.Type);
		}

		// Token: 0x040117C0 RID: 71616
		private Table __p;
	}
}

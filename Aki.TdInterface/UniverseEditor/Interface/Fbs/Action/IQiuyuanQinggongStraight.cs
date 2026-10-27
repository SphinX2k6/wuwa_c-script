using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DEF RID: 28143
	public struct IQiuyuanQinggongStraight : IFlatbufferObject
	{
		// Token: 0x1700D1BD RID: 53693
		// (get) Token: 0x06031B49 RID: 203593 RVA: 0x006BB14D File Offset: 0x006B934D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B4A RID: 203594 RVA: 0x006BB15A File Offset: 0x006B935A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B4B RID: 203595 RVA: 0x006BB164 File Offset: 0x006B9364
		public static IQiuyuanQinggongStraight GetRootAsIQiuyuanQinggongStraight(ByteBuffer _bb)
		{
			return IQiuyuanQinggongStraight.GetRootAsIQiuyuanQinggongStraight(_bb, default(IQiuyuanQinggongStraight));
		}

		// Token: 0x06031B4C RID: 203596 RVA: 0x006BB180 File Offset: 0x006B9380
		public static IQiuyuanQinggongStraight GetRootAsIQiuyuanQinggongStraight(ByteBuffer _bb, IQiuyuanQinggongStraight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B4D RID: 203597 RVA: 0x006BB19D File Offset: 0x006B939D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B4E RID: 203598 RVA: 0x006BB1AC File Offset: 0x006B93AC
		public IQiuyuanQinggongStraight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1BE RID: 53694
		// (get) Token: 0x06031B4F RID: 203599 RVA: 0x006BB1BC File Offset: 0x006B93BC
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

		// Token: 0x06031B50 RID: 203600 RVA: 0x006BB1F8 File Offset: 0x006B93F8
		public static Offset<IQiuyuanQinggongStraight> CreateIQiuyuanQinggongStraight(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongStraight.AddType(builder, Type);
			return IQiuyuanQinggongStraight.EndIQiuyuanQinggongStraight(builder);
		}

		// Token: 0x06031B51 RID: 203601 RVA: 0x006BB20E File Offset: 0x006B940E
		public static void StartIQiuyuanQinggongStraight(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031B52 RID: 203602 RVA: 0x006BB217 File Offset: 0x006B9417
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031B53 RID: 203603 RVA: 0x006BB222 File Offset: 0x006B9422
		public static Offset<IQiuyuanQinggongStraight> EndIQiuyuanQinggongStraight(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongStraight>(builder.EndTable());
		}

		// Token: 0x06031B54 RID: 203604 RVA: 0x006BB230 File Offset: 0x006B9430
		public IQiuyuanQinggongStraightT UnPack()
		{
			IQiuyuanQinggongStraightT qiuyuanQinggongStraightT = new IQiuyuanQinggongStraightT();
			this.UnPackTo(qiuyuanQinggongStraightT);
			return qiuyuanQinggongStraightT;
		}

		// Token: 0x06031B55 RID: 203605 RVA: 0x006BB24B File Offset: 0x006B944B
		public void UnPackTo(IQiuyuanQinggongStraightT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031B56 RID: 203606 RVA: 0x006BB25C File Offset: 0x006B945C
		public static Offset<IQiuyuanQinggongStraight> Pack(FlatBufferBuilder builder, IQiuyuanQinggongStraightT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongStraight>);
			}
			return IQiuyuanQinggongStraight.CreateIQiuyuanQinggongStraight(builder, _o.Type);
		}

		// Token: 0x040117CA RID: 71626
		private Table __p;
	}
}

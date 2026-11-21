using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200755B RID: 30043
	public struct IQiuyuanQinggongExploration1 : IFlatbufferObject
	{
		// Token: 0x1700DCF6 RID: 56566
		// (get) Token: 0x06034AEB RID: 215787 RVA: 0x007160DD File Offset: 0x007142DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034AEC RID: 215788 RVA: 0x007160EA File Offset: 0x007142EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034AED RID: 215789 RVA: 0x007160F4 File Offset: 0x007142F4
		public static IQiuyuanQinggongExploration1 GetRootAsIQiuyuanQinggongExploration1(ByteBuffer _bb)
		{
			return IQiuyuanQinggongExploration1.GetRootAsIQiuyuanQinggongExploration1(_bb, default(IQiuyuanQinggongExploration1));
		}

		// Token: 0x06034AEE RID: 215790 RVA: 0x00716110 File Offset: 0x00714310
		public static IQiuyuanQinggongExploration1 GetRootAsIQiuyuanQinggongExploration1(ByteBuffer _bb, IQiuyuanQinggongExploration1 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034AEF RID: 215791 RVA: 0x0071612D File Offset: 0x0071432D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034AF0 RID: 215792 RVA: 0x0071613C File Offset: 0x0071433C
		public IQiuyuanQinggongExploration1 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCF7 RID: 56567
		// (get) Token: 0x06034AF1 RID: 215793 RVA: 0x0071614C File Offset: 0x0071434C
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

		// Token: 0x06034AF2 RID: 215794 RVA: 0x00716188 File Offset: 0x00714388
		public static Offset<IQiuyuanQinggongExploration1> CreateIQiuyuanQinggongExploration1(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongExploration1.AddType(builder, Type);
			return IQiuyuanQinggongExploration1.EndIQiuyuanQinggongExploration1(builder);
		}

		// Token: 0x06034AF3 RID: 215795 RVA: 0x0071619E File Offset: 0x0071439E
		public static void StartIQiuyuanQinggongExploration1(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034AF4 RID: 215796 RVA: 0x007161A7 File Offset: 0x007143A7
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034AF5 RID: 215797 RVA: 0x007161B2 File Offset: 0x007143B2
		public static Offset<IQiuyuanQinggongExploration1> EndIQiuyuanQinggongExploration1(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongExploration1>(builder.EndTable());
		}

		// Token: 0x06034AF6 RID: 215798 RVA: 0x007161C0 File Offset: 0x007143C0
		public IQiuyuanQinggongExploration1T UnPack()
		{
			IQiuyuanQinggongExploration1T qiuyuanQinggongExploration1T = new IQiuyuanQinggongExploration1T();
			this.UnPackTo(qiuyuanQinggongExploration1T);
			return qiuyuanQinggongExploration1T;
		}

		// Token: 0x06034AF7 RID: 215799 RVA: 0x007161DB File Offset: 0x007143DB
		public void UnPackTo(IQiuyuanQinggongExploration1T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034AF8 RID: 215800 RVA: 0x007161EC File Offset: 0x007143EC
		public static Offset<IQiuyuanQinggongExploration1> Pack(FlatBufferBuilder builder, IQiuyuanQinggongExploration1T _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongExploration1>);
			}
			return IQiuyuanQinggongExploration1.CreateIQiuyuanQinggongExploration1(builder, _o.Type);
		}

		// Token: 0x0401273C RID: 75580
		private Table __p;
	}
}

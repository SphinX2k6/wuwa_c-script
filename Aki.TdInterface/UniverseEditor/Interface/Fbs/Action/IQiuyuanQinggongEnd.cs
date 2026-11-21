using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007558 RID: 30040
	public struct IQiuyuanQinggongEnd : IFlatbufferObject
	{
		// Token: 0x1700DCF3 RID: 56563
		// (get) Token: 0x06034AD9 RID: 215769 RVA: 0x00715F65 File Offset: 0x00714165
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034ADA RID: 215770 RVA: 0x00715F72 File Offset: 0x00714172
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034ADB RID: 215771 RVA: 0x00715F7C File Offset: 0x0071417C
		public static IQiuyuanQinggongEnd GetRootAsIQiuyuanQinggongEnd(ByteBuffer _bb)
		{
			return IQiuyuanQinggongEnd.GetRootAsIQiuyuanQinggongEnd(_bb, default(IQiuyuanQinggongEnd));
		}

		// Token: 0x06034ADC RID: 215772 RVA: 0x00715F98 File Offset: 0x00714198
		public static IQiuyuanQinggongEnd GetRootAsIQiuyuanQinggongEnd(ByteBuffer _bb, IQiuyuanQinggongEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034ADD RID: 215773 RVA: 0x00715FB5 File Offset: 0x007141B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034ADE RID: 215774 RVA: 0x00715FC4 File Offset: 0x007141C4
		public IQiuyuanQinggongEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCF4 RID: 56564
		// (get) Token: 0x06034ADF RID: 215775 RVA: 0x00715FD4 File Offset: 0x007141D4
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

		// Token: 0x06034AE0 RID: 215776 RVA: 0x00716010 File Offset: 0x00714210
		public static Offset<IQiuyuanQinggongEnd> CreateIQiuyuanQinggongEnd(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongEnd.AddType(builder, Type);
			return IQiuyuanQinggongEnd.EndIQiuyuanQinggongEnd(builder);
		}

		// Token: 0x06034AE1 RID: 215777 RVA: 0x00716026 File Offset: 0x00714226
		public static void StartIQiuyuanQinggongEnd(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034AE2 RID: 215778 RVA: 0x0071602F File Offset: 0x0071422F
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034AE3 RID: 215779 RVA: 0x0071603A File Offset: 0x0071423A
		public static Offset<IQiuyuanQinggongEnd> EndIQiuyuanQinggongEnd(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongEnd>(builder.EndTable());
		}

		// Token: 0x06034AE4 RID: 215780 RVA: 0x00716048 File Offset: 0x00714248
		public IQiuyuanQinggongEndT UnPack()
		{
			IQiuyuanQinggongEndT qiuyuanQinggongEndT = new IQiuyuanQinggongEndT();
			this.UnPackTo(qiuyuanQinggongEndT);
			return qiuyuanQinggongEndT;
		}

		// Token: 0x06034AE5 RID: 215781 RVA: 0x00716063 File Offset: 0x00714263
		public void UnPackTo(IQiuyuanQinggongEndT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034AE6 RID: 215782 RVA: 0x00716074 File Offset: 0x00714274
		public static Offset<IQiuyuanQinggongEnd> Pack(FlatBufferBuilder builder, IQiuyuanQinggongEndT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongEnd>);
			}
			return IQiuyuanQinggongEnd.CreateIQiuyuanQinggongEnd(builder, _o.Type);
		}

		// Token: 0x0401273A RID: 75578
		private Table __p;
	}
}

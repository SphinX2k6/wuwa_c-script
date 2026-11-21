using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200755E RID: 30046
	public struct IQiuyuanQinggongExploration2 : IFlatbufferObject
	{
		// Token: 0x1700DCF9 RID: 56569
		// (get) Token: 0x06034AFD RID: 215805 RVA: 0x00716255 File Offset: 0x00714455
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034AFE RID: 215806 RVA: 0x00716262 File Offset: 0x00714462
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034AFF RID: 215807 RVA: 0x0071626C File Offset: 0x0071446C
		public static IQiuyuanQinggongExploration2 GetRootAsIQiuyuanQinggongExploration2(ByteBuffer _bb)
		{
			return IQiuyuanQinggongExploration2.GetRootAsIQiuyuanQinggongExploration2(_bb, default(IQiuyuanQinggongExploration2));
		}

		// Token: 0x06034B00 RID: 215808 RVA: 0x00716288 File Offset: 0x00714488
		public static IQiuyuanQinggongExploration2 GetRootAsIQiuyuanQinggongExploration2(ByteBuffer _bb, IQiuyuanQinggongExploration2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034B01 RID: 215809 RVA: 0x007162A5 File Offset: 0x007144A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034B02 RID: 215810 RVA: 0x007162B4 File Offset: 0x007144B4
		public IQiuyuanQinggongExploration2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCFA RID: 56570
		// (get) Token: 0x06034B03 RID: 215811 RVA: 0x007162C4 File Offset: 0x007144C4
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

		// Token: 0x06034B04 RID: 215812 RVA: 0x00716300 File Offset: 0x00714500
		public static Offset<IQiuyuanQinggongExploration2> CreateIQiuyuanQinggongExploration2(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongExploration2.AddType(builder, Type);
			return IQiuyuanQinggongExploration2.EndIQiuyuanQinggongExploration2(builder);
		}

		// Token: 0x06034B05 RID: 215813 RVA: 0x00716316 File Offset: 0x00714516
		public static void StartIQiuyuanQinggongExploration2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034B06 RID: 215814 RVA: 0x0071631F File Offset: 0x0071451F
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034B07 RID: 215815 RVA: 0x0071632A File Offset: 0x0071452A
		public static Offset<IQiuyuanQinggongExploration2> EndIQiuyuanQinggongExploration2(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongExploration2>(builder.EndTable());
		}

		// Token: 0x06034B08 RID: 215816 RVA: 0x00716338 File Offset: 0x00714538
		public IQiuyuanQinggongExploration2T UnPack()
		{
			IQiuyuanQinggongExploration2T qiuyuanQinggongExploration2T = new IQiuyuanQinggongExploration2T();
			this.UnPackTo(qiuyuanQinggongExploration2T);
			return qiuyuanQinggongExploration2T;
		}

		// Token: 0x06034B09 RID: 215817 RVA: 0x00716353 File Offset: 0x00714553
		public void UnPackTo(IQiuyuanQinggongExploration2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034B0A RID: 215818 RVA: 0x00716364 File Offset: 0x00714564
		public static Offset<IQiuyuanQinggongExploration2> Pack(FlatBufferBuilder builder, IQiuyuanQinggongExploration2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongExploration2>);
			}
			return IQiuyuanQinggongExploration2.CreateIQiuyuanQinggongExploration2(builder, _o.Type);
		}

		// Token: 0x0401273E RID: 75582
		private Table __p;
	}
}

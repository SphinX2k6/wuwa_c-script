using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007564 RID: 30052
	public struct IQiuyuanQinggongExploration4 : IFlatbufferObject
	{
		// Token: 0x1700DCFF RID: 56575
		// (get) Token: 0x06034B21 RID: 215841 RVA: 0x00716545 File Offset: 0x00714745
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034B22 RID: 215842 RVA: 0x00716552 File Offset: 0x00714752
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034B23 RID: 215843 RVA: 0x0071655C File Offset: 0x0071475C
		public static IQiuyuanQinggongExploration4 GetRootAsIQiuyuanQinggongExploration4(ByteBuffer _bb)
		{
			return IQiuyuanQinggongExploration4.GetRootAsIQiuyuanQinggongExploration4(_bb, default(IQiuyuanQinggongExploration4));
		}

		// Token: 0x06034B24 RID: 215844 RVA: 0x00716578 File Offset: 0x00714778
		public static IQiuyuanQinggongExploration4 GetRootAsIQiuyuanQinggongExploration4(ByteBuffer _bb, IQiuyuanQinggongExploration4 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034B25 RID: 215845 RVA: 0x00716595 File Offset: 0x00714795
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034B26 RID: 215846 RVA: 0x007165A4 File Offset: 0x007147A4
		public IQiuyuanQinggongExploration4 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD00 RID: 56576
		// (get) Token: 0x06034B27 RID: 215847 RVA: 0x007165B4 File Offset: 0x007147B4
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

		// Token: 0x06034B28 RID: 215848 RVA: 0x007165F0 File Offset: 0x007147F0
		public static Offset<IQiuyuanQinggongExploration4> CreateIQiuyuanQinggongExploration4(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongExploration4.AddType(builder, Type);
			return IQiuyuanQinggongExploration4.EndIQiuyuanQinggongExploration4(builder);
		}

		// Token: 0x06034B29 RID: 215849 RVA: 0x00716606 File Offset: 0x00714806
		public static void StartIQiuyuanQinggongExploration4(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034B2A RID: 215850 RVA: 0x0071660F File Offset: 0x0071480F
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034B2B RID: 215851 RVA: 0x0071661A File Offset: 0x0071481A
		public static Offset<IQiuyuanQinggongExploration4> EndIQiuyuanQinggongExploration4(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongExploration4>(builder.EndTable());
		}

		// Token: 0x06034B2C RID: 215852 RVA: 0x00716628 File Offset: 0x00714828
		public IQiuyuanQinggongExploration4T UnPack()
		{
			IQiuyuanQinggongExploration4T qiuyuanQinggongExploration4T = new IQiuyuanQinggongExploration4T();
			this.UnPackTo(qiuyuanQinggongExploration4T);
			return qiuyuanQinggongExploration4T;
		}

		// Token: 0x06034B2D RID: 215853 RVA: 0x00716643 File Offset: 0x00714843
		public void UnPackTo(IQiuyuanQinggongExploration4T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034B2E RID: 215854 RVA: 0x00716654 File Offset: 0x00714854
		public static Offset<IQiuyuanQinggongExploration4> Pack(FlatBufferBuilder builder, IQiuyuanQinggongExploration4T _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongExploration4>);
			}
			return IQiuyuanQinggongExploration4.CreateIQiuyuanQinggongExploration4(builder, _o.Type);
		}

		// Token: 0x04012742 RID: 75586
		private Table __p;
	}
}

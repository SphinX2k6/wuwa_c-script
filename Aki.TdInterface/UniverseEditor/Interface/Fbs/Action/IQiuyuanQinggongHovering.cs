using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007567 RID: 30055
	public struct IQiuyuanQinggongHovering : IFlatbufferObject
	{
		// Token: 0x1700DD02 RID: 56578
		// (get) Token: 0x06034B33 RID: 215859 RVA: 0x007166BD File Offset: 0x007148BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034B34 RID: 215860 RVA: 0x007166CA File Offset: 0x007148CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034B35 RID: 215861 RVA: 0x007166D4 File Offset: 0x007148D4
		public static IQiuyuanQinggongHovering GetRootAsIQiuyuanQinggongHovering(ByteBuffer _bb)
		{
			return IQiuyuanQinggongHovering.GetRootAsIQiuyuanQinggongHovering(_bb, default(IQiuyuanQinggongHovering));
		}

		// Token: 0x06034B36 RID: 215862 RVA: 0x007166F0 File Offset: 0x007148F0
		public static IQiuyuanQinggongHovering GetRootAsIQiuyuanQinggongHovering(ByteBuffer _bb, IQiuyuanQinggongHovering obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034B37 RID: 215863 RVA: 0x0071670D File Offset: 0x0071490D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034B38 RID: 215864 RVA: 0x0071671C File Offset: 0x0071491C
		public IQiuyuanQinggongHovering __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD03 RID: 56579
		// (get) Token: 0x06034B39 RID: 215865 RVA: 0x0071672C File Offset: 0x0071492C
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

		// Token: 0x06034B3A RID: 215866 RVA: 0x00716768 File Offset: 0x00714968
		public static Offset<IQiuyuanQinggongHovering> CreateIQiuyuanQinggongHovering(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongHovering.AddType(builder, Type);
			return IQiuyuanQinggongHovering.EndIQiuyuanQinggongHovering(builder);
		}

		// Token: 0x06034B3B RID: 215867 RVA: 0x0071677E File Offset: 0x0071497E
		public static void StartIQiuyuanQinggongHovering(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034B3C RID: 215868 RVA: 0x00716787 File Offset: 0x00714987
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034B3D RID: 215869 RVA: 0x00716792 File Offset: 0x00714992
		public static Offset<IQiuyuanQinggongHovering> EndIQiuyuanQinggongHovering(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongHovering>(builder.EndTable());
		}

		// Token: 0x06034B3E RID: 215870 RVA: 0x007167A0 File Offset: 0x007149A0
		public IQiuyuanQinggongHoveringT UnPack()
		{
			IQiuyuanQinggongHoveringT qiuyuanQinggongHoveringT = new IQiuyuanQinggongHoveringT();
			this.UnPackTo(qiuyuanQinggongHoveringT);
			return qiuyuanQinggongHoveringT;
		}

		// Token: 0x06034B3F RID: 215871 RVA: 0x007167BB File Offset: 0x007149BB
		public void UnPackTo(IQiuyuanQinggongHoveringT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034B40 RID: 215872 RVA: 0x007167CC File Offset: 0x007149CC
		public static Offset<IQiuyuanQinggongHovering> Pack(FlatBufferBuilder builder, IQiuyuanQinggongHoveringT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongHovering>);
			}
			return IQiuyuanQinggongHovering.CreateIQiuyuanQinggongHovering(builder, _o.Type);
		}

		// Token: 0x04012744 RID: 75588
		private Table __p;
	}
}

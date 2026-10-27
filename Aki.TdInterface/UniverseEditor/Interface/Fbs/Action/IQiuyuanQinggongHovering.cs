using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DEC RID: 28140
	public struct IQiuyuanQinggongHovering : IFlatbufferObject
	{
		// Token: 0x1700D1BA RID: 53690
		// (get) Token: 0x06031B37 RID: 203575 RVA: 0x006BAFD5 File Offset: 0x006B91D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B38 RID: 203576 RVA: 0x006BAFE2 File Offset: 0x006B91E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B39 RID: 203577 RVA: 0x006BAFEC File Offset: 0x006B91EC
		public static IQiuyuanQinggongHovering GetRootAsIQiuyuanQinggongHovering(ByteBuffer _bb)
		{
			return IQiuyuanQinggongHovering.GetRootAsIQiuyuanQinggongHovering(_bb, default(IQiuyuanQinggongHovering));
		}

		// Token: 0x06031B3A RID: 203578 RVA: 0x006BB008 File Offset: 0x006B9208
		public static IQiuyuanQinggongHovering GetRootAsIQiuyuanQinggongHovering(ByteBuffer _bb, IQiuyuanQinggongHovering obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B3B RID: 203579 RVA: 0x006BB025 File Offset: 0x006B9225
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B3C RID: 203580 RVA: 0x006BB034 File Offset: 0x006B9234
		public IQiuyuanQinggongHovering __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1BB RID: 53691
		// (get) Token: 0x06031B3D RID: 203581 RVA: 0x006BB044 File Offset: 0x006B9244
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

		// Token: 0x06031B3E RID: 203582 RVA: 0x006BB080 File Offset: 0x006B9280
		public static Offset<IQiuyuanQinggongHovering> CreateIQiuyuanQinggongHovering(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongHovering.AddType(builder, Type);
			return IQiuyuanQinggongHovering.EndIQiuyuanQinggongHovering(builder);
		}

		// Token: 0x06031B3F RID: 203583 RVA: 0x006BB096 File Offset: 0x006B9296
		public static void StartIQiuyuanQinggongHovering(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031B40 RID: 203584 RVA: 0x006BB09F File Offset: 0x006B929F
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031B41 RID: 203585 RVA: 0x006BB0AA File Offset: 0x006B92AA
		public static Offset<IQiuyuanQinggongHovering> EndIQiuyuanQinggongHovering(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongHovering>(builder.EndTable());
		}

		// Token: 0x06031B42 RID: 203586 RVA: 0x006BB0B8 File Offset: 0x006B92B8
		public IQiuyuanQinggongHoveringT UnPack()
		{
			IQiuyuanQinggongHoveringT qiuyuanQinggongHoveringT = new IQiuyuanQinggongHoveringT();
			this.UnPackTo(qiuyuanQinggongHoveringT);
			return qiuyuanQinggongHoveringT;
		}

		// Token: 0x06031B43 RID: 203587 RVA: 0x006BB0D3 File Offset: 0x006B92D3
		public void UnPackTo(IQiuyuanQinggongHoveringT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031B44 RID: 203588 RVA: 0x006BB0E4 File Offset: 0x006B92E4
		public static Offset<IQiuyuanQinggongHovering> Pack(FlatBufferBuilder builder, IQiuyuanQinggongHoveringT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongHovering>);
			}
			return IQiuyuanQinggongHovering.CreateIQiuyuanQinggongHovering(builder, _o.Type);
		}

		// Token: 0x040117C8 RID: 71624
		private Table __p;
	}
}

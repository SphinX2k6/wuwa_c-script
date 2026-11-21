using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200756A RID: 30058
	public struct IQiuyuanQinggongStraight : IFlatbufferObject
	{
		// Token: 0x1700DD05 RID: 56581
		// (get) Token: 0x06034B45 RID: 215877 RVA: 0x00716835 File Offset: 0x00714A35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034B46 RID: 215878 RVA: 0x00716842 File Offset: 0x00714A42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034B47 RID: 215879 RVA: 0x0071684C File Offset: 0x00714A4C
		public static IQiuyuanQinggongStraight GetRootAsIQiuyuanQinggongStraight(ByteBuffer _bb)
		{
			return IQiuyuanQinggongStraight.GetRootAsIQiuyuanQinggongStraight(_bb, default(IQiuyuanQinggongStraight));
		}

		// Token: 0x06034B48 RID: 215880 RVA: 0x00716868 File Offset: 0x00714A68
		public static IQiuyuanQinggongStraight GetRootAsIQiuyuanQinggongStraight(ByteBuffer _bb, IQiuyuanQinggongStraight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034B49 RID: 215881 RVA: 0x00716885 File Offset: 0x00714A85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034B4A RID: 215882 RVA: 0x00716894 File Offset: 0x00714A94
		public IQiuyuanQinggongStraight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD06 RID: 56582
		// (get) Token: 0x06034B4B RID: 215883 RVA: 0x007168A4 File Offset: 0x00714AA4
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

		// Token: 0x06034B4C RID: 215884 RVA: 0x007168E0 File Offset: 0x00714AE0
		public static Offset<IQiuyuanQinggongStraight> CreateIQiuyuanQinggongStraight(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongStraight.AddType(builder, Type);
			return IQiuyuanQinggongStraight.EndIQiuyuanQinggongStraight(builder);
		}

		// Token: 0x06034B4D RID: 215885 RVA: 0x007168F6 File Offset: 0x00714AF6
		public static void StartIQiuyuanQinggongStraight(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034B4E RID: 215886 RVA: 0x007168FF File Offset: 0x00714AFF
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034B4F RID: 215887 RVA: 0x0071690A File Offset: 0x00714B0A
		public static Offset<IQiuyuanQinggongStraight> EndIQiuyuanQinggongStraight(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongStraight>(builder.EndTable());
		}

		// Token: 0x06034B50 RID: 215888 RVA: 0x00716918 File Offset: 0x00714B18
		public IQiuyuanQinggongStraightT UnPack()
		{
			IQiuyuanQinggongStraightT qiuyuanQinggongStraightT = new IQiuyuanQinggongStraightT();
			this.UnPackTo(qiuyuanQinggongStraightT);
			return qiuyuanQinggongStraightT;
		}

		// Token: 0x06034B51 RID: 215889 RVA: 0x00716933 File Offset: 0x00714B33
		public void UnPackTo(IQiuyuanQinggongStraightT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034B52 RID: 215890 RVA: 0x00716944 File Offset: 0x00714B44
		public static Offset<IQiuyuanQinggongStraight> Pack(FlatBufferBuilder builder, IQiuyuanQinggongStraightT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongStraight>);
			}
			return IQiuyuanQinggongStraight.CreateIQiuyuanQinggongStraight(builder, _o.Type);
		}

		// Token: 0x04012746 RID: 75590
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007561 RID: 30049
	public struct IQiuyuanQinggongExploration3 : IFlatbufferObject
	{
		// Token: 0x1700DCFC RID: 56572
		// (get) Token: 0x06034B0F RID: 215823 RVA: 0x007163CD File Offset: 0x007145CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034B10 RID: 215824 RVA: 0x007163DA File Offset: 0x007145DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034B11 RID: 215825 RVA: 0x007163E4 File Offset: 0x007145E4
		public static IQiuyuanQinggongExploration3 GetRootAsIQiuyuanQinggongExploration3(ByteBuffer _bb)
		{
			return IQiuyuanQinggongExploration3.GetRootAsIQiuyuanQinggongExploration3(_bb, default(IQiuyuanQinggongExploration3));
		}

		// Token: 0x06034B12 RID: 215826 RVA: 0x00716400 File Offset: 0x00714600
		public static IQiuyuanQinggongExploration3 GetRootAsIQiuyuanQinggongExploration3(ByteBuffer _bb, IQiuyuanQinggongExploration3 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034B13 RID: 215827 RVA: 0x0071641D File Offset: 0x0071461D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034B14 RID: 215828 RVA: 0x0071642C File Offset: 0x0071462C
		public IQiuyuanQinggongExploration3 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCFD RID: 56573
		// (get) Token: 0x06034B15 RID: 215829 RVA: 0x0071643C File Offset: 0x0071463C
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

		// Token: 0x06034B16 RID: 215830 RVA: 0x00716478 File Offset: 0x00714678
		public static Offset<IQiuyuanQinggongExploration3> CreateIQiuyuanQinggongExploration3(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongExploration3.AddType(builder, Type);
			return IQiuyuanQinggongExploration3.EndIQiuyuanQinggongExploration3(builder);
		}

		// Token: 0x06034B17 RID: 215831 RVA: 0x0071648E File Offset: 0x0071468E
		public static void StartIQiuyuanQinggongExploration3(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034B18 RID: 215832 RVA: 0x00716497 File Offset: 0x00714697
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034B19 RID: 215833 RVA: 0x007164A2 File Offset: 0x007146A2
		public static Offset<IQiuyuanQinggongExploration3> EndIQiuyuanQinggongExploration3(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongExploration3>(builder.EndTable());
		}

		// Token: 0x06034B1A RID: 215834 RVA: 0x007164B0 File Offset: 0x007146B0
		public IQiuyuanQinggongExploration3T UnPack()
		{
			IQiuyuanQinggongExploration3T qiuyuanQinggongExploration3T = new IQiuyuanQinggongExploration3T();
			this.UnPackTo(qiuyuanQinggongExploration3T);
			return qiuyuanQinggongExploration3T;
		}

		// Token: 0x06034B1B RID: 215835 RVA: 0x007164CB File Offset: 0x007146CB
		public void UnPackTo(IQiuyuanQinggongExploration3T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034B1C RID: 215836 RVA: 0x007164DC File Offset: 0x007146DC
		public static Offset<IQiuyuanQinggongExploration3> Pack(FlatBufferBuilder builder, IQiuyuanQinggongExploration3T _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongExploration3>);
			}
			return IQiuyuanQinggongExploration3.CreateIQiuyuanQinggongExploration3(builder, _o.Type);
		}

		// Token: 0x04012740 RID: 75584
		private Table __p;
	}
}

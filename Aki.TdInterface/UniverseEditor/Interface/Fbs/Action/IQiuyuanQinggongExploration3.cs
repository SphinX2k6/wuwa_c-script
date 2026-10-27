using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE6 RID: 28134
	public struct IQiuyuanQinggongExploration3 : IFlatbufferObject
	{
		// Token: 0x1700D1B4 RID: 53684
		// (get) Token: 0x06031B13 RID: 203539 RVA: 0x006BACE5 File Offset: 0x006B8EE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B14 RID: 203540 RVA: 0x006BACF2 File Offset: 0x006B8EF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B15 RID: 203541 RVA: 0x006BACFC File Offset: 0x006B8EFC
		public static IQiuyuanQinggongExploration3 GetRootAsIQiuyuanQinggongExploration3(ByteBuffer _bb)
		{
			return IQiuyuanQinggongExploration3.GetRootAsIQiuyuanQinggongExploration3(_bb, default(IQiuyuanQinggongExploration3));
		}

		// Token: 0x06031B16 RID: 203542 RVA: 0x006BAD18 File Offset: 0x006B8F18
		public static IQiuyuanQinggongExploration3 GetRootAsIQiuyuanQinggongExploration3(ByteBuffer _bb, IQiuyuanQinggongExploration3 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B17 RID: 203543 RVA: 0x006BAD35 File Offset: 0x006B8F35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B18 RID: 203544 RVA: 0x006BAD44 File Offset: 0x006B8F44
		public IQiuyuanQinggongExploration3 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1B5 RID: 53685
		// (get) Token: 0x06031B19 RID: 203545 RVA: 0x006BAD54 File Offset: 0x006B8F54
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

		// Token: 0x06031B1A RID: 203546 RVA: 0x006BAD90 File Offset: 0x006B8F90
		public static Offset<IQiuyuanQinggongExploration3> CreateIQiuyuanQinggongExploration3(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongExploration3.AddType(builder, Type);
			return IQiuyuanQinggongExploration3.EndIQiuyuanQinggongExploration3(builder);
		}

		// Token: 0x06031B1B RID: 203547 RVA: 0x006BADA6 File Offset: 0x006B8FA6
		public static void StartIQiuyuanQinggongExploration3(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031B1C RID: 203548 RVA: 0x006BADAF File Offset: 0x006B8FAF
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031B1D RID: 203549 RVA: 0x006BADBA File Offset: 0x006B8FBA
		public static Offset<IQiuyuanQinggongExploration3> EndIQiuyuanQinggongExploration3(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongExploration3>(builder.EndTable());
		}

		// Token: 0x06031B1E RID: 203550 RVA: 0x006BADC8 File Offset: 0x006B8FC8
		public IQiuyuanQinggongExploration3T UnPack()
		{
			IQiuyuanQinggongExploration3T qiuyuanQinggongExploration3T = new IQiuyuanQinggongExploration3T();
			this.UnPackTo(qiuyuanQinggongExploration3T);
			return qiuyuanQinggongExploration3T;
		}

		// Token: 0x06031B1F RID: 203551 RVA: 0x006BADE3 File Offset: 0x006B8FE3
		public void UnPackTo(IQiuyuanQinggongExploration3T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031B20 RID: 203552 RVA: 0x006BADF4 File Offset: 0x006B8FF4
		public static Offset<IQiuyuanQinggongExploration3> Pack(FlatBufferBuilder builder, IQiuyuanQinggongExploration3T _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongExploration3>);
			}
			return IQiuyuanQinggongExploration3.CreateIQiuyuanQinggongExploration3(builder, _o.Type);
		}

		// Token: 0x040117C4 RID: 71620
		private Table __p;
	}
}

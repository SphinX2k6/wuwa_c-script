using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C57 RID: 27735
	public struct IOverrideLookAtType : IFlatbufferObject
	{
		// Token: 0x1700CE94 RID: 52884
		// (get) Token: 0x06030DE7 RID: 200167 RVA: 0x006A3588 File Offset: 0x006A1788
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030DE8 RID: 200168 RVA: 0x006A3595 File Offset: 0x006A1795
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030DE9 RID: 200169 RVA: 0x006A359C File Offset: 0x006A179C
		public static IOverrideLookAtType GetRootAsIOverrideLookAtType(ByteBuffer _bb)
		{
			return IOverrideLookAtType.GetRootAsIOverrideLookAtType(_bb, default(IOverrideLookAtType));
		}

		// Token: 0x06030DEA RID: 200170 RVA: 0x006A35B8 File Offset: 0x006A17B8
		public static IOverrideLookAtType GetRootAsIOverrideLookAtType(ByteBuffer _bb, IOverrideLookAtType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030DEB RID: 200171 RVA: 0x006A35D5 File Offset: 0x006A17D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030DEC RID: 200172 RVA: 0x006A35E4 File Offset: 0x006A17E4
		public IOverrideLookAtType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE95 RID: 52885
		// (get) Token: 0x06030DED RID: 200173 RVA: 0x006A35F4 File Offset: 0x006A17F4
		public EOverrideLookAtType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOverrideLookAtType.CheckFlowLookAt;
				}
				return (EOverrideLookAtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030DEE RID: 200174 RVA: 0x006A3630 File Offset: 0x006A1830
		public static Offset<IOverrideLookAtType> CreateIOverrideLookAtType(FlatBufferBuilder builder, EOverrideLookAtType Type = EOverrideLookAtType.CheckFlowLookAt)
		{
			builder.StartTable(1);
			IOverrideLookAtType.AddType(builder, Type);
			return IOverrideLookAtType.EndIOverrideLookAtType(builder);
		}

		// Token: 0x06030DEF RID: 200175 RVA: 0x006A3646 File Offset: 0x006A1846
		public static void StartIOverrideLookAtType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030DF0 RID: 200176 RVA: 0x006A364F File Offset: 0x006A184F
		public static void AddType(FlatBufferBuilder builder, EOverrideLookAtType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030DF1 RID: 200177 RVA: 0x006A365A File Offset: 0x006A185A
		public static Offset<IOverrideLookAtType> EndIOverrideLookAtType(FlatBufferBuilder builder)
		{
			return new Offset<IOverrideLookAtType>(builder.EndTable());
		}

		// Token: 0x06030DF2 RID: 200178 RVA: 0x006A3668 File Offset: 0x006A1868
		public IOverrideLookAtTypeT UnPack()
		{
			IOverrideLookAtTypeT overrideLookAtTypeT = new IOverrideLookAtTypeT();
			this.UnPackTo(overrideLookAtTypeT);
			return overrideLookAtTypeT;
		}

		// Token: 0x06030DF3 RID: 200179 RVA: 0x006A3683 File Offset: 0x006A1883
		public void UnPackTo(IOverrideLookAtTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030DF4 RID: 200180 RVA: 0x006A3694 File Offset: 0x006A1894
		public static Offset<IOverrideLookAtType> Pack(FlatBufferBuilder builder, IOverrideLookAtTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOverrideLookAtType>);
			}
			return IOverrideLookAtType.CreateIOverrideLookAtType(builder, _o.Type);
		}

		// Token: 0x0401159A RID: 71066
		private Table __p;
	}
}

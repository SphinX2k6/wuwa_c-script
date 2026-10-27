using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B3B RID: 15163
	public struct PrefabValue : IFlatbufferObject
	{
		// Token: 0x1700680A RID: 26634
		// (get) Token: 0x06014B93 RID: 84883 RVA: 0x003036F0 File Offset: 0x003018F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014B94 RID: 84884 RVA: 0x003036FD File Offset: 0x003018FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014B95 RID: 84885 RVA: 0x00303704 File Offset: 0x00301904
		public static PrefabValue GetRootAsPrefabValue(ByteBuffer _bb)
		{
			return PrefabValue.GetRootAsPrefabValue(_bb, default(PrefabValue));
		}

		// Token: 0x06014B96 RID: 84886 RVA: 0x00303720 File Offset: 0x00301920
		public static PrefabValue GetRootAsPrefabValue(ByteBuffer _bb, PrefabValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014B97 RID: 84887 RVA: 0x0030373D File Offset: 0x0030193D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014B98 RID: 84888 RVA: 0x0030374C File Offset: 0x0030194C
		public PrefabValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700680B RID: 26635
		// (get) Token: 0x06014B99 RID: 84889 RVA: 0x0030375C File Offset: 0x0030195C
		public int Value
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014B9A RID: 84890 RVA: 0x00303798 File Offset: 0x00301998
		public static Offset<PrefabValue> CreatePrefabValue(FlatBufferBuilder builder, int value = 0)
		{
			builder.StartTable(1);
			PrefabValue.AddValue(builder, value);
			return PrefabValue.EndPrefabValue(builder);
		}

		// Token: 0x06014B9B RID: 84891 RVA: 0x003037AE File Offset: 0x003019AE
		public static void StartPrefabValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014B9C RID: 84892 RVA: 0x003037B7 File Offset: 0x003019B7
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(0, value, 0);
		}

		// Token: 0x06014B9D RID: 84893 RVA: 0x003037C2 File Offset: 0x003019C2
		public static Offset<PrefabValue> EndPrefabValue(FlatBufferBuilder builder)
		{
			return new Offset<PrefabValue>(builder.EndTable());
		}

		// Token: 0x06014B9E RID: 84894 RVA: 0x003037D0 File Offset: 0x003019D0
		public PrefabValueT UnPack()
		{
			PrefabValueT prefabValueT = new PrefabValueT();
			this.UnPackTo(prefabValueT);
			return prefabValueT;
		}

		// Token: 0x06014B9F RID: 84895 RVA: 0x003037EB File Offset: 0x003019EB
		public void UnPackTo(PrefabValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x06014BA0 RID: 84896 RVA: 0x003037FC File Offset: 0x003019FC
		public static Offset<PrefabValue> Pack(FlatBufferBuilder builder, PrefabValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<PrefabValue>);
			}
			return PrefabValue.CreatePrefabValue(builder, _o.Value);
		}

		// Token: 0x0400B01F RID: 45087
		private Table __p;
	}
}

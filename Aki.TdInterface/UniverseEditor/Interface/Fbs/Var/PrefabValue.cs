using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F3D RID: 16189
	public struct PrefabValue : IFlatbufferObject
	{
		// Token: 0x17006DA5 RID: 28069
		// (get) Token: 0x0601603D RID: 90173 RVA: 0x00329980 File Offset: 0x00327B80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601603E RID: 90174 RVA: 0x0032998D File Offset: 0x00327B8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601603F RID: 90175 RVA: 0x00329994 File Offset: 0x00327B94
		public static PrefabValue GetRootAsPrefabValue(ByteBuffer _bb)
		{
			return PrefabValue.GetRootAsPrefabValue(_bb, default(PrefabValue));
		}

		// Token: 0x06016040 RID: 90176 RVA: 0x003299B0 File Offset: 0x00327BB0
		public static PrefabValue GetRootAsPrefabValue(ByteBuffer _bb, PrefabValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016041 RID: 90177 RVA: 0x003299CD File Offset: 0x00327BCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016042 RID: 90178 RVA: 0x003299DC File Offset: 0x00327BDC
		public PrefabValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DA6 RID: 28070
		// (get) Token: 0x06016043 RID: 90179 RVA: 0x003299EC File Offset: 0x00327BEC
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

		// Token: 0x06016044 RID: 90180 RVA: 0x00329A28 File Offset: 0x00327C28
		public static Offset<PrefabValue> CreatePrefabValue(FlatBufferBuilder builder, int value = 0)
		{
			builder.StartTable(1);
			PrefabValue.AddValue(builder, value);
			return PrefabValue.EndPrefabValue(builder);
		}

		// Token: 0x06016045 RID: 90181 RVA: 0x00329A3E File Offset: 0x00327C3E
		public static void StartPrefabValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016046 RID: 90182 RVA: 0x00329A47 File Offset: 0x00327C47
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(0, value, 0);
		}

		// Token: 0x06016047 RID: 90183 RVA: 0x00329A52 File Offset: 0x00327C52
		public static Offset<PrefabValue> EndPrefabValue(FlatBufferBuilder builder)
		{
			return new Offset<PrefabValue>(builder.EndTable());
		}

		// Token: 0x06016048 RID: 90184 RVA: 0x00329A60 File Offset: 0x00327C60
		public PrefabValueT UnPack()
		{
			PrefabValueT prefabValueT = new PrefabValueT();
			this.UnPackTo(prefabValueT);
			return prefabValueT;
		}

		// Token: 0x06016049 RID: 90185 RVA: 0x00329A7B File Offset: 0x00327C7B
		public void UnPackTo(PrefabValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x0601604A RID: 90186 RVA: 0x00329A8C File Offset: 0x00327C8C
		public static Offset<PrefabValue> Pack(FlatBufferBuilder builder, PrefabValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<PrefabValue>);
			}
			return PrefabValue.CreatePrefabValue(builder, _o.Value);
		}

		// Token: 0x0400B98C RID: 47500
		private Table __p;
	}
}

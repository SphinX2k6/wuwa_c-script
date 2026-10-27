using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A06 RID: 14854
	public struct FloatValue : IFlatbufferObject
	{
		// Token: 0x170065CB RID: 26059
		// (get) Token: 0x06014109 RID: 82185 RVA: 0x002F0315 File Offset: 0x002EE515
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601410A RID: 82186 RVA: 0x002F0322 File Offset: 0x002EE522
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601410B RID: 82187 RVA: 0x002F032C File Offset: 0x002EE52C
		public static FloatValue GetRootAsFloatValue(ByteBuffer _bb)
		{
			return FloatValue.GetRootAsFloatValue(_bb, default(FloatValue));
		}

		// Token: 0x0601410C RID: 82188 RVA: 0x002F0348 File Offset: 0x002EE548
		public static FloatValue GetRootAsFloatValue(ByteBuffer _bb, FloatValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601410D RID: 82189 RVA: 0x002F0365 File Offset: 0x002EE565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601410E RID: 82190 RVA: 0x002F0374 File Offset: 0x002EE574
		public FloatValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170065CC RID: 26060
		// (get) Token: 0x0601410F RID: 82191 RVA: 0x002F0384 File Offset: 0x002EE584
		public float Value
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014110 RID: 82192 RVA: 0x002F03C4 File Offset: 0x002EE5C4
		public static Offset<FloatValue> CreateFloatValue(FlatBufferBuilder builder, float value = 0f)
		{
			builder.StartTable(1);
			FloatValue.AddValue(builder, value);
			return FloatValue.EndFloatValue(builder);
		}

		// Token: 0x06014111 RID: 82193 RVA: 0x002F03DA File Offset: 0x002EE5DA
		public static void StartFloatValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014112 RID: 82194 RVA: 0x002F03E3 File Offset: 0x002EE5E3
		public static void AddValue(FlatBufferBuilder builder, float value)
		{
			builder.AddFloat(0, value, 0.0);
		}

		// Token: 0x06014113 RID: 82195 RVA: 0x002F03F6 File Offset: 0x002EE5F6
		public static Offset<FloatValue> EndFloatValue(FlatBufferBuilder builder)
		{
			return new Offset<FloatValue>(builder.EndTable());
		}

		// Token: 0x06014114 RID: 82196 RVA: 0x002F0404 File Offset: 0x002EE604
		public FloatValueT UnPack()
		{
			FloatValueT floatValueT = new FloatValueT();
			this.UnPackTo(floatValueT);
			return floatValueT;
		}

		// Token: 0x06014115 RID: 82197 RVA: 0x002F041F File Offset: 0x002EE61F
		public void UnPackTo(FloatValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x06014116 RID: 82198 RVA: 0x002F0430 File Offset: 0x002EE630
		public static Offset<FloatValue> Pack(FlatBufferBuilder builder, FloatValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<FloatValue>);
			}
			return FloatValue.CreateFloatValue(builder, _o.Value);
		}

		// Token: 0x0400AE6F RID: 44655
		private Table __p;
	}
}

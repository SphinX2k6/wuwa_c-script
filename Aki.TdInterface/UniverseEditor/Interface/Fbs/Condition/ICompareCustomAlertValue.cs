using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B89 RID: 19337
	public struct ICompareCustomAlertValue : IFlatbufferObject
	{
		// Token: 0x17008C57 RID: 35927
		// (get) Token: 0x0601E7AA RID: 124842 RVA: 0x0044455C File Offset: 0x0044275C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E7AB RID: 124843 RVA: 0x00444569 File Offset: 0x00442769
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E7AC RID: 124844 RVA: 0x00444570 File Offset: 0x00442770
		public static ICompareCustomAlertValue GetRootAsICompareCustomAlertValue(ByteBuffer _bb)
		{
			return ICompareCustomAlertValue.GetRootAsICompareCustomAlertValue(_bb, default(ICompareCustomAlertValue));
		}

		// Token: 0x0601E7AD RID: 124845 RVA: 0x0044458C File Offset: 0x0044278C
		public static ICompareCustomAlertValue GetRootAsICompareCustomAlertValue(ByteBuffer _bb, ICompareCustomAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E7AE RID: 124846 RVA: 0x004445A9 File Offset: 0x004427A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E7AF RID: 124847 RVA: 0x004445B8 File Offset: 0x004427B8
		public ICompareCustomAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C58 RID: 35928
		// (get) Token: 0x0601E7B0 RID: 124848 RVA: 0x004445C8 File Offset: 0x004427C8
		public EComparedAlertValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EComparedAlertValueType.Min;
				}
				return (EComparedAlertValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C59 RID: 35929
		// (get) Token: 0x0601E7B1 RID: 124849 RVA: 0x00444604 File Offset: 0x00442804
		public float CompareValue
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E7B2 RID: 124850 RVA: 0x00444644 File Offset: 0x00442844
		public static Offset<ICompareCustomAlertValue> CreateICompareCustomAlertValue(FlatBufferBuilder builder, EComparedAlertValueType Type = EComparedAlertValueType.Min, float CompareValue = 0f)
		{
			builder.StartTable(2);
			ICompareCustomAlertValue.AddCompareValue(builder, CompareValue);
			ICompareCustomAlertValue.AddType(builder, Type);
			return ICompareCustomAlertValue.EndICompareCustomAlertValue(builder);
		}

		// Token: 0x0601E7B3 RID: 124851 RVA: 0x00444661 File Offset: 0x00442861
		public static void StartICompareCustomAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E7B4 RID: 124852 RVA: 0x0044466A File Offset: 0x0044286A
		public static void AddType(FlatBufferBuilder builder, EComparedAlertValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E7B5 RID: 124853 RVA: 0x00444675 File Offset: 0x00442875
		public static void AddCompareValue(FlatBufferBuilder builder, float compareValue)
		{
			builder.AddFloat(1, compareValue, 0.0);
		}

		// Token: 0x0601E7B6 RID: 124854 RVA: 0x00444688 File Offset: 0x00442888
		public static Offset<ICompareCustomAlertValue> EndICompareCustomAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<ICompareCustomAlertValue>(builder.EndTable());
		}

		// Token: 0x0601E7B7 RID: 124855 RVA: 0x00444698 File Offset: 0x00442898
		public ICompareCustomAlertValueT UnPack()
		{
			ICompareCustomAlertValueT compareCustomAlertValueT = new ICompareCustomAlertValueT();
			this.UnPackTo(compareCustomAlertValueT);
			return compareCustomAlertValueT;
		}

		// Token: 0x0601E7B8 RID: 124856 RVA: 0x004446B3 File Offset: 0x004428B3
		public void UnPackTo(ICompareCustomAlertValueT _o)
		{
			_o.Type = this.Type;
			_o.CompareValue = this.CompareValue;
		}

		// Token: 0x0601E7B9 RID: 124857 RVA: 0x004446D0 File Offset: 0x004428D0
		public static Offset<ICompareCustomAlertValue> Pack(FlatBufferBuilder builder, ICompareCustomAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareCustomAlertValue>);
			}
			return ICompareCustomAlertValue.CreateICompareCustomAlertValue(builder, _o.Type, _o.CompareValue);
		}

		// Token: 0x0400D45C RID: 54364
		private Table __p;
	}
}

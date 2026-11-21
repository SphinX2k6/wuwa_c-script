using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005070 RID: 20592
	public struct ICompareCustomAlertValue : IFlatbufferObject
	{
		// Token: 0x17009367 RID: 37735
		// (get) Token: 0x06020338 RID: 131896 RVA: 0x00476DA8 File Offset: 0x00474FA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020339 RID: 131897 RVA: 0x00476DB5 File Offset: 0x00474FB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602033A RID: 131898 RVA: 0x00476DBC File Offset: 0x00474FBC
		public static ICompareCustomAlertValue GetRootAsICompareCustomAlertValue(ByteBuffer _bb)
		{
			return ICompareCustomAlertValue.GetRootAsICompareCustomAlertValue(_bb, default(ICompareCustomAlertValue));
		}

		// Token: 0x0602033B RID: 131899 RVA: 0x00476DD8 File Offset: 0x00474FD8
		public static ICompareCustomAlertValue GetRootAsICompareCustomAlertValue(ByteBuffer _bb, ICompareCustomAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602033C RID: 131900 RVA: 0x00476DF5 File Offset: 0x00474FF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602033D RID: 131901 RVA: 0x00476E04 File Offset: 0x00475004
		public ICompareCustomAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009368 RID: 37736
		// (get) Token: 0x0602033E RID: 131902 RVA: 0x00476E14 File Offset: 0x00475014
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

		// Token: 0x17009369 RID: 37737
		// (get) Token: 0x0602033F RID: 131903 RVA: 0x00476E50 File Offset: 0x00475050
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

		// Token: 0x06020340 RID: 131904 RVA: 0x00476E90 File Offset: 0x00475090
		public static Offset<ICompareCustomAlertValue> CreateICompareCustomAlertValue(FlatBufferBuilder builder, EComparedAlertValueType Type = EComparedAlertValueType.Min, float CompareValue = 0f)
		{
			builder.StartTable(2);
			ICompareCustomAlertValue.AddCompareValue(builder, CompareValue);
			ICompareCustomAlertValue.AddType(builder, Type);
			return ICompareCustomAlertValue.EndICompareCustomAlertValue(builder);
		}

		// Token: 0x06020341 RID: 131905 RVA: 0x00476EAD File Offset: 0x004750AD
		public static void StartICompareCustomAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020342 RID: 131906 RVA: 0x00476EB6 File Offset: 0x004750B6
		public static void AddType(FlatBufferBuilder builder, EComparedAlertValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020343 RID: 131907 RVA: 0x00476EC1 File Offset: 0x004750C1
		public static void AddCompareValue(FlatBufferBuilder builder, float compareValue)
		{
			builder.AddFloat(1, compareValue, 0.0);
		}

		// Token: 0x06020344 RID: 131908 RVA: 0x00476ED4 File Offset: 0x004750D4
		public static Offset<ICompareCustomAlertValue> EndICompareCustomAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<ICompareCustomAlertValue>(builder.EndTable());
		}

		// Token: 0x06020345 RID: 131909 RVA: 0x00476EE4 File Offset: 0x004750E4
		public ICompareCustomAlertValueT UnPack()
		{
			ICompareCustomAlertValueT compareCustomAlertValueT = new ICompareCustomAlertValueT();
			this.UnPackTo(compareCustomAlertValueT);
			return compareCustomAlertValueT;
		}

		// Token: 0x06020346 RID: 131910 RVA: 0x00476EFF File Offset: 0x004750FF
		public void UnPackTo(ICompareCustomAlertValueT _o)
		{
			_o.Type = this.Type;
			_o.CompareValue = this.CompareValue;
		}

		// Token: 0x06020347 RID: 131911 RVA: 0x00476F1C File Offset: 0x0047511C
		public static Offset<ICompareCustomAlertValue> Pack(FlatBufferBuilder builder, ICompareCustomAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareCustomAlertValue>);
			}
			return ICompareCustomAlertValue.CreateICompareCustomAlertValue(builder, _o.Type, _o.CompareValue);
		}

		// Token: 0x0400DF5C RID: 57180
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200509D RID: 20637
	public struct ICompareMaxAlertValue : IFlatbufferObject
	{
		// Token: 0x170093CF RID: 37839
		// (get) Token: 0x060204C0 RID: 132288 RVA: 0x00479520 File Offset: 0x00477720
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060204C1 RID: 132289 RVA: 0x0047952D File Offset: 0x0047772D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060204C2 RID: 132290 RVA: 0x00479534 File Offset: 0x00477734
		public static ICompareMaxAlertValue GetRootAsICompareMaxAlertValue(ByteBuffer _bb)
		{
			return ICompareMaxAlertValue.GetRootAsICompareMaxAlertValue(_bb, default(ICompareMaxAlertValue));
		}

		// Token: 0x060204C3 RID: 132291 RVA: 0x00479550 File Offset: 0x00477750
		public static ICompareMaxAlertValue GetRootAsICompareMaxAlertValue(ByteBuffer _bb, ICompareMaxAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060204C4 RID: 132292 RVA: 0x0047956D File Offset: 0x0047776D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060204C5 RID: 132293 RVA: 0x0047957C File Offset: 0x0047777C
		public ICompareMaxAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093D0 RID: 37840
		// (get) Token: 0x060204C6 RID: 132294 RVA: 0x0047958C File Offset: 0x0047778C
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

		// Token: 0x060204C7 RID: 132295 RVA: 0x004795C8 File Offset: 0x004777C8
		public static Offset<ICompareMaxAlertValue> CreateICompareMaxAlertValue(FlatBufferBuilder builder, EComparedAlertValueType Type = EComparedAlertValueType.Min)
		{
			builder.StartTable(1);
			ICompareMaxAlertValue.AddType(builder, Type);
			return ICompareMaxAlertValue.EndICompareMaxAlertValue(builder);
		}

		// Token: 0x060204C8 RID: 132296 RVA: 0x004795DE File Offset: 0x004777DE
		public static void StartICompareMaxAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060204C9 RID: 132297 RVA: 0x004795E7 File Offset: 0x004777E7
		public static void AddType(FlatBufferBuilder builder, EComparedAlertValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060204CA RID: 132298 RVA: 0x004795F2 File Offset: 0x004777F2
		public static Offset<ICompareMaxAlertValue> EndICompareMaxAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<ICompareMaxAlertValue>(builder.EndTable());
		}

		// Token: 0x060204CB RID: 132299 RVA: 0x00479600 File Offset: 0x00477800
		public ICompareMaxAlertValueT UnPack()
		{
			ICompareMaxAlertValueT compareMaxAlertValueT = new ICompareMaxAlertValueT();
			this.UnPackTo(compareMaxAlertValueT);
			return compareMaxAlertValueT;
		}

		// Token: 0x060204CC RID: 132300 RVA: 0x0047961B File Offset: 0x0047781B
		public void UnPackTo(ICompareMaxAlertValueT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060204CD RID: 132301 RVA: 0x0047962C File Offset: 0x0047782C
		public static Offset<ICompareMaxAlertValue> Pack(FlatBufferBuilder builder, ICompareMaxAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareMaxAlertValue>);
			}
			return ICompareMaxAlertValue.CreateICompareMaxAlertValue(builder, _o.Type);
		}

		// Token: 0x0400DF9E RID: 57246
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051B4 RID: 20916
	public struct ISaveConfigEnterMethod : IFlatbufferObject
	{
		// Token: 0x170095CA RID: 38346
		// (get) Token: 0x06020ECB RID: 134859 RVA: 0x0048DDFE File Offset: 0x0048BFFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020ECC RID: 134860 RVA: 0x0048DE0B File Offset: 0x0048C00B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020ECD RID: 134861 RVA: 0x0048DE14 File Offset: 0x0048C014
		public static ISaveConfigEnterMethod GetRootAsISaveConfigEnterMethod(ByteBuffer _bb)
		{
			return ISaveConfigEnterMethod.GetRootAsISaveConfigEnterMethod(_bb, default(ISaveConfigEnterMethod));
		}

		// Token: 0x06020ECE RID: 134862 RVA: 0x0048DE30 File Offset: 0x0048C030
		public static ISaveConfigEnterMethod GetRootAsISaveConfigEnterMethod(ByteBuffer _bb, ISaveConfigEnterMethod obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020ECF RID: 134863 RVA: 0x0048DE4D File Offset: 0x0048C04D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020ED0 RID: 134864 RVA: 0x0048DE5C File Offset: 0x0048C05C
		public ISaveConfigEnterMethod __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095CB RID: 38347
		// (get) Token: 0x06020ED1 RID: 134865 RVA: 0x0048DE6C File Offset: 0x0048C06C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170095CC RID: 38348
		// (get) Token: 0x06020ED2 RID: 134866 RVA: 0x0048DEA8 File Offset: 0x0048C0A8
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170095CD RID: 38349
		// (get) Token: 0x06020ED3 RID: 134867 RVA: 0x0048DEE4 File Offset: 0x0048C0E4
		public ESaveConfigEnterMethod EnterMethod
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ESaveConfigEnterMethod.FirstTime;
				}
				return (ESaveConfigEnterMethod)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020ED4 RID: 134868 RVA: 0x0048DF20 File Offset: 0x0048C120
		public static Offset<ISaveConfigEnterMethod> CreateISaveConfigEnterMethod(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, ESaveConfigEnterMethod EnterMethod = ESaveConfigEnterMethod.FirstTime)
		{
			builder.StartTable(3);
			ISaveConfigEnterMethod.AddEnterMethod(builder, EnterMethod);
			ISaveConfigEnterMethod.AddCompare(builder, Compare);
			ISaveConfigEnterMethod.AddType(builder, Type);
			return ISaveConfigEnterMethod.EndISaveConfigEnterMethod(builder);
		}

		// Token: 0x06020ED5 RID: 134869 RVA: 0x0048DF44 File Offset: 0x0048C144
		public static void StartISaveConfigEnterMethod(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020ED6 RID: 134870 RVA: 0x0048DF4D File Offset: 0x0048C14D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020ED7 RID: 134871 RVA: 0x0048DF58 File Offset: 0x0048C158
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06020ED8 RID: 134872 RVA: 0x0048DF63 File Offset: 0x0048C163
		public static void AddEnterMethod(FlatBufferBuilder builder, ESaveConfigEnterMethod enterMethod)
		{
			builder.AddByte(2, (byte)enterMethod, 0);
		}

		// Token: 0x06020ED9 RID: 134873 RVA: 0x0048DF6E File Offset: 0x0048C16E
		public static Offset<ISaveConfigEnterMethod> EndISaveConfigEnterMethod(FlatBufferBuilder builder)
		{
			return new Offset<ISaveConfigEnterMethod>(builder.EndTable());
		}

		// Token: 0x06020EDA RID: 134874 RVA: 0x0048DF7C File Offset: 0x0048C17C
		public ISaveConfigEnterMethodT UnPack()
		{
			ISaveConfigEnterMethodT saveConfigEnterMethodT = new ISaveConfigEnterMethodT();
			this.UnPackTo(saveConfigEnterMethodT);
			return saveConfigEnterMethodT;
		}

		// Token: 0x06020EDB RID: 134875 RVA: 0x0048DF97 File Offset: 0x0048C197
		public void UnPackTo(ISaveConfigEnterMethodT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.EnterMethod = this.EnterMethod;
		}

		// Token: 0x06020EDC RID: 134876 RVA: 0x0048DFC0 File Offset: 0x0048C1C0
		public static Offset<ISaveConfigEnterMethod> Pack(FlatBufferBuilder builder, ISaveConfigEnterMethodT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISaveConfigEnterMethod>);
			}
			return ISaveConfigEnterMethod.CreateISaveConfigEnterMethod(builder, _o.Type, _o.Compare, _o.EnterMethod);
		}

		// Token: 0x0400E1A7 RID: 57767
		private Table __p;
	}
}

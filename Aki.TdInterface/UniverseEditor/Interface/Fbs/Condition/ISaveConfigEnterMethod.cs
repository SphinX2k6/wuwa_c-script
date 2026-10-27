using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CBB RID: 19643
	public struct ISaveConfigEnterMethod : IFlatbufferObject
	{
		// Token: 0x17008E9C RID: 36508
		// (get) Token: 0x0601F2A9 RID: 127657 RVA: 0x0045A2AE File Offset: 0x004584AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F2AA RID: 127658 RVA: 0x0045A2BB File Offset: 0x004584BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F2AB RID: 127659 RVA: 0x0045A2C4 File Offset: 0x004584C4
		public static ISaveConfigEnterMethod GetRootAsISaveConfigEnterMethod(ByteBuffer _bb)
		{
			return ISaveConfigEnterMethod.GetRootAsISaveConfigEnterMethod(_bb, default(ISaveConfigEnterMethod));
		}

		// Token: 0x0601F2AC RID: 127660 RVA: 0x0045A2E0 File Offset: 0x004584E0
		public static ISaveConfigEnterMethod GetRootAsISaveConfigEnterMethod(ByteBuffer _bb, ISaveConfigEnterMethod obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F2AD RID: 127661 RVA: 0x0045A2FD File Offset: 0x004584FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F2AE RID: 127662 RVA: 0x0045A30C File Offset: 0x0045850C
		public ISaveConfigEnterMethod __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E9D RID: 36509
		// (get) Token: 0x0601F2AF RID: 127663 RVA: 0x0045A31C File Offset: 0x0045851C
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

		// Token: 0x17008E9E RID: 36510
		// (get) Token: 0x0601F2B0 RID: 127664 RVA: 0x0045A358 File Offset: 0x00458558
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

		// Token: 0x17008E9F RID: 36511
		// (get) Token: 0x0601F2B1 RID: 127665 RVA: 0x0045A394 File Offset: 0x00458594
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

		// Token: 0x0601F2B2 RID: 127666 RVA: 0x0045A3D0 File Offset: 0x004585D0
		public static Offset<ISaveConfigEnterMethod> CreateISaveConfigEnterMethod(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, ESaveConfigEnterMethod EnterMethod = ESaveConfigEnterMethod.FirstTime)
		{
			builder.StartTable(3);
			ISaveConfigEnterMethod.AddEnterMethod(builder, EnterMethod);
			ISaveConfigEnterMethod.AddCompare(builder, Compare);
			ISaveConfigEnterMethod.AddType(builder, Type);
			return ISaveConfigEnterMethod.EndISaveConfigEnterMethod(builder);
		}

		// Token: 0x0601F2B3 RID: 127667 RVA: 0x0045A3F4 File Offset: 0x004585F4
		public static void StartISaveConfigEnterMethod(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F2B4 RID: 127668 RVA: 0x0045A3FD File Offset: 0x004585FD
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F2B5 RID: 127669 RVA: 0x0045A408 File Offset: 0x00458608
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601F2B6 RID: 127670 RVA: 0x0045A413 File Offset: 0x00458613
		public static void AddEnterMethod(FlatBufferBuilder builder, ESaveConfigEnterMethod enterMethod)
		{
			builder.AddByte(2, (byte)enterMethod, 0);
		}

		// Token: 0x0601F2B7 RID: 127671 RVA: 0x0045A41E File Offset: 0x0045861E
		public static Offset<ISaveConfigEnterMethod> EndISaveConfigEnterMethod(FlatBufferBuilder builder)
		{
			return new Offset<ISaveConfigEnterMethod>(builder.EndTable());
		}

		// Token: 0x0601F2B8 RID: 127672 RVA: 0x0045A42C File Offset: 0x0045862C
		public ISaveConfigEnterMethodT UnPack()
		{
			ISaveConfigEnterMethodT saveConfigEnterMethodT = new ISaveConfigEnterMethodT();
			this.UnPackTo(saveConfigEnterMethodT);
			return saveConfigEnterMethodT;
		}

		// Token: 0x0601F2B9 RID: 127673 RVA: 0x0045A447 File Offset: 0x00458647
		public void UnPackTo(ISaveConfigEnterMethodT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.EnterMethod = this.EnterMethod;
		}

		// Token: 0x0601F2BA RID: 127674 RVA: 0x0045A470 File Offset: 0x00458670
		public static Offset<ISaveConfigEnterMethod> Pack(FlatBufferBuilder builder, ISaveConfigEnterMethodT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISaveConfigEnterMethod>);
			}
			return ISaveConfigEnterMethod.CreateISaveConfigEnterMethod(builder, _o.Type, _o.Compare, _o.EnterMethod);
		}

		// Token: 0x0400D680 RID: 54912
		private Table __p;
	}
}

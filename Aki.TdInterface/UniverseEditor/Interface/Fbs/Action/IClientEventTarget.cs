using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A1D RID: 27165
	public struct IClientEventTarget : IFlatbufferObject
	{
		// Token: 0x1700C7B6 RID: 51126
		// (get) Token: 0x0602E9A1 RID: 190881 RVA: 0x0065AD6F File Offset: 0x00658F6F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E9A2 RID: 190882 RVA: 0x0065AD7C File Offset: 0x00658F7C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E9A3 RID: 190883 RVA: 0x0065AD84 File Offset: 0x00658F84
		public static IClientEventTarget GetRootAsIClientEventTarget(ByteBuffer _bb)
		{
			return IClientEventTarget.GetRootAsIClientEventTarget(_bb, default(IClientEventTarget));
		}

		// Token: 0x0602E9A4 RID: 190884 RVA: 0x0065ADA0 File Offset: 0x00658FA0
		public static IClientEventTarget GetRootAsIClientEventTarget(ByteBuffer _bb, IClientEventTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E9A5 RID: 190885 RVA: 0x0065ADBD File Offset: 0x00658FBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E9A6 RID: 190886 RVA: 0x0065ADCC File Offset: 0x00658FCC
		public IClientEventTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7B7 RID: 51127
		// (get) Token: 0x0602E9A7 RID: 190887 RVA: 0x0065ADDC File Offset: 0x00658FDC
		public EClientEventTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventTarget.Self;
				}
				return (EClientEventTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E9A8 RID: 190888 RVA: 0x0065AE18 File Offset: 0x00659018
		public static Offset<IClientEventTarget> CreateIClientEventTarget(FlatBufferBuilder builder, EClientEventTarget Type = EClientEventTarget.Self)
		{
			builder.StartTable(1);
			IClientEventTarget.AddType(builder, Type);
			return IClientEventTarget.EndIClientEventTarget(builder);
		}

		// Token: 0x0602E9A9 RID: 190889 RVA: 0x0065AE2E File Offset: 0x0065902E
		public static void StartIClientEventTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E9AA RID: 190890 RVA: 0x0065AE37 File Offset: 0x00659037
		public static void AddType(FlatBufferBuilder builder, EClientEventTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E9AB RID: 190891 RVA: 0x0065AE42 File Offset: 0x00659042
		public static Offset<IClientEventTarget> EndIClientEventTarget(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventTarget>(builder.EndTable());
		}

		// Token: 0x0602E9AC RID: 190892 RVA: 0x0065AE50 File Offset: 0x00659050
		public IClientEventTargetT UnPack()
		{
			IClientEventTargetT clientEventTargetT = new IClientEventTargetT();
			this.UnPackTo(clientEventTargetT);
			return clientEventTargetT;
		}

		// Token: 0x0602E9AD RID: 190893 RVA: 0x0065AE6B File Offset: 0x0065906B
		public void UnPackTo(IClientEventTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E9AE RID: 190894 RVA: 0x0065AE7C File Offset: 0x0065907C
		public static Offset<IClientEventTarget> Pack(FlatBufferBuilder builder, IClientEventTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventTarget>);
			}
			return IClientEventTarget.CreateIClientEventTarget(builder, _o.Type);
		}

		// Token: 0x04011793 RID: 71571
		private Table __p;
	}
}

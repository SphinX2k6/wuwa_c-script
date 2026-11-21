using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007953 RID: 31059
	public struct ISplineMoveDriveMode : IFlatbufferObject
	{
		// Token: 0x1700E3CC RID: 58316
		// (get) Token: 0x06036B2E RID: 224046 RVA: 0x00751A2C File Offset: 0x0074FC2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036B2F RID: 224047 RVA: 0x00751A39 File Offset: 0x0074FC39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036B30 RID: 224048 RVA: 0x00751A40 File Offset: 0x0074FC40
		public static ISplineMoveDriveMode GetRootAsISplineMoveDriveMode(ByteBuffer _bb)
		{
			return ISplineMoveDriveMode.GetRootAsISplineMoveDriveMode(_bb, default(ISplineMoveDriveMode));
		}

		// Token: 0x06036B31 RID: 224049 RVA: 0x00751A5C File Offset: 0x0074FC5C
		public static ISplineMoveDriveMode GetRootAsISplineMoveDriveMode(ByteBuffer _bb, ISplineMoveDriveMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036B32 RID: 224050 RVA: 0x00751A79 File Offset: 0x0074FC79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036B33 RID: 224051 RVA: 0x00751A88 File Offset: 0x0074FC88
		public ISplineMoveDriveMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3CD RID: 58317
		// (get) Token: 0x06036B34 RID: 224052 RVA: 0x00751A98 File Offset: 0x0074FC98
		public ESplineMoveDriveMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveDriveMode.InputDriven;
				}
				return (ESplineMoveDriveMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036B35 RID: 224053 RVA: 0x00751AD4 File Offset: 0x0074FCD4
		public static Offset<ISplineMoveDriveMode> CreateISplineMoveDriveMode(FlatBufferBuilder builder, ESplineMoveDriveMode Type = ESplineMoveDriveMode.InputDriven)
		{
			builder.StartTable(1);
			ISplineMoveDriveMode.AddType(builder, Type);
			return ISplineMoveDriveMode.EndISplineMoveDriveMode(builder);
		}

		// Token: 0x06036B36 RID: 224054 RVA: 0x00751AEA File Offset: 0x0074FCEA
		public static void StartISplineMoveDriveMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036B37 RID: 224055 RVA: 0x00751AF3 File Offset: 0x0074FCF3
		public static void AddType(FlatBufferBuilder builder, ESplineMoveDriveMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036B38 RID: 224056 RVA: 0x00751AFE File Offset: 0x0074FCFE
		public static Offset<ISplineMoveDriveMode> EndISplineMoveDriveMode(FlatBufferBuilder builder)
		{
			return new Offset<ISplineMoveDriveMode>(builder.EndTable());
		}

		// Token: 0x06036B39 RID: 224057 RVA: 0x00751B0C File Offset: 0x0074FD0C
		public ISplineMoveDriveModeT UnPack()
		{
			ISplineMoveDriveModeT splineMoveDriveModeT = new ISplineMoveDriveModeT();
			this.UnPackTo(splineMoveDriveModeT);
			return splineMoveDriveModeT;
		}

		// Token: 0x06036B3A RID: 224058 RVA: 0x00751B27 File Offset: 0x0074FD27
		public void UnPackTo(ISplineMoveDriveModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036B3B RID: 224059 RVA: 0x00751B38 File Offset: 0x0074FD38
		public static Offset<ISplineMoveDriveMode> Pack(FlatBufferBuilder builder, ISplineMoveDriveModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineMoveDriveMode>);
			}
			return ISplineMoveDriveMode.CreateISplineMoveDriveMode(builder, _o.Type);
		}

		// Token: 0x04012C28 RID: 76840
		private Table __p;
	}
}

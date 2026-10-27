using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007184 RID: 29060
	public struct ISplineMoveDriveMode : IFlatbufferObject
	{
		// Token: 0x1700D7DA RID: 55258
		// (get) Token: 0x06033854 RID: 211028 RVA: 0x006F0A9C File Offset: 0x006EEC9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033855 RID: 211029 RVA: 0x006F0AA9 File Offset: 0x006EECA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033856 RID: 211030 RVA: 0x006F0AB0 File Offset: 0x006EECB0
		public static ISplineMoveDriveMode GetRootAsISplineMoveDriveMode(ByteBuffer _bb)
		{
			return ISplineMoveDriveMode.GetRootAsISplineMoveDriveMode(_bb, default(ISplineMoveDriveMode));
		}

		// Token: 0x06033857 RID: 211031 RVA: 0x006F0ACC File Offset: 0x006EECCC
		public static ISplineMoveDriveMode GetRootAsISplineMoveDriveMode(ByteBuffer _bb, ISplineMoveDriveMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033858 RID: 211032 RVA: 0x006F0AE9 File Offset: 0x006EECE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033859 RID: 211033 RVA: 0x006F0AF8 File Offset: 0x006EECF8
		public ISplineMoveDriveMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7DB RID: 55259
		// (get) Token: 0x0603385A RID: 211034 RVA: 0x006F0B08 File Offset: 0x006EED08
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

		// Token: 0x0603385B RID: 211035 RVA: 0x006F0B44 File Offset: 0x006EED44
		public static Offset<ISplineMoveDriveMode> CreateISplineMoveDriveMode(FlatBufferBuilder builder, ESplineMoveDriveMode Type = ESplineMoveDriveMode.InputDriven)
		{
			builder.StartTable(1);
			ISplineMoveDriveMode.AddType(builder, Type);
			return ISplineMoveDriveMode.EndISplineMoveDriveMode(builder);
		}

		// Token: 0x0603385C RID: 211036 RVA: 0x006F0B5A File Offset: 0x006EED5A
		public static void StartISplineMoveDriveMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603385D RID: 211037 RVA: 0x006F0B63 File Offset: 0x006EED63
		public static void AddType(FlatBufferBuilder builder, ESplineMoveDriveMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603385E RID: 211038 RVA: 0x006F0B6E File Offset: 0x006EED6E
		public static Offset<ISplineMoveDriveMode> EndISplineMoveDriveMode(FlatBufferBuilder builder)
		{
			return new Offset<ISplineMoveDriveMode>(builder.EndTable());
		}

		// Token: 0x0603385F RID: 211039 RVA: 0x006F0B7C File Offset: 0x006EED7C
		public ISplineMoveDriveModeT UnPack()
		{
			ISplineMoveDriveModeT splineMoveDriveModeT = new ISplineMoveDriveModeT();
			this.UnPackTo(splineMoveDriveModeT);
			return splineMoveDriveModeT;
		}

		// Token: 0x06033860 RID: 211040 RVA: 0x006F0B97 File Offset: 0x006EED97
		public void UnPackTo(ISplineMoveDriveModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033861 RID: 211041 RVA: 0x006F0BA8 File Offset: 0x006EEDA8
		public static Offset<ISplineMoveDriveMode> Pack(FlatBufferBuilder builder, ISplineMoveDriveModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineMoveDriveMode>);
			}
			return ISplineMoveDriveMode.CreateISplineMoveDriveMode(builder, _o.Type);
		}

		// Token: 0x04011C32 RID: 72754
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F0 RID: 23024
	public struct IInteractScreenDetectShapeBase : IFlatbufferObject
	{
		// Token: 0x1700A751 RID: 42833
		// (get) Token: 0x06025983 RID: 153987 RVA: 0x00527CC0 File Offset: 0x00525EC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025984 RID: 153988 RVA: 0x00527CCD File Offset: 0x00525ECD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025985 RID: 153989 RVA: 0x00527CD4 File Offset: 0x00525ED4
		public static IInteractScreenDetectShapeBase GetRootAsIInteractScreenDetectShapeBase(ByteBuffer _bb)
		{
			return IInteractScreenDetectShapeBase.GetRootAsIInteractScreenDetectShapeBase(_bb, default(IInteractScreenDetectShapeBase));
		}

		// Token: 0x06025986 RID: 153990 RVA: 0x00527CF0 File Offset: 0x00525EF0
		public static IInteractScreenDetectShapeBase GetRootAsIInteractScreenDetectShapeBase(ByteBuffer _bb, IInteractScreenDetectShapeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025987 RID: 153991 RVA: 0x00527D0D File Offset: 0x00525F0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025988 RID: 153992 RVA: 0x00527D1C File Offset: 0x00525F1C
		public IInteractScreenDetectShapeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A752 RID: 42834
		// (get) Token: 0x06025989 RID: 153993 RVA: 0x00527D2C File Offset: 0x00525F2C
		public EInteractScreenDetectShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractScreenDetectShape.Circle;
				}
				return (EInteractScreenDetectShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602598A RID: 153994 RVA: 0x00527D68 File Offset: 0x00525F68
		public static Offset<IInteractScreenDetectShapeBase> CreateIInteractScreenDetectShapeBase(FlatBufferBuilder builder, EInteractScreenDetectShape Type = EInteractScreenDetectShape.Circle)
		{
			builder.StartTable(1);
			IInteractScreenDetectShapeBase.AddType(builder, Type);
			return IInteractScreenDetectShapeBase.EndIInteractScreenDetectShapeBase(builder);
		}

		// Token: 0x0602598B RID: 153995 RVA: 0x00527D7E File Offset: 0x00525F7E
		public static void StartIInteractScreenDetectShapeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602598C RID: 153996 RVA: 0x00527D87 File Offset: 0x00525F87
		public static void AddType(FlatBufferBuilder builder, EInteractScreenDetectShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602598D RID: 153997 RVA: 0x00527D92 File Offset: 0x00525F92
		public static Offset<IInteractScreenDetectShapeBase> EndIInteractScreenDetectShapeBase(FlatBufferBuilder builder)
		{
			return new Offset<IInteractScreenDetectShapeBase>(builder.EndTable());
		}

		// Token: 0x0602598E RID: 153998 RVA: 0x00527DA0 File Offset: 0x00525FA0
		public IInteractScreenDetectShapeBaseT UnPack()
		{
			IInteractScreenDetectShapeBaseT interactScreenDetectShapeBaseT = new IInteractScreenDetectShapeBaseT();
			this.UnPackTo(interactScreenDetectShapeBaseT);
			return interactScreenDetectShapeBaseT;
		}

		// Token: 0x0602598F RID: 153999 RVA: 0x00527DBB File Offset: 0x00525FBB
		public void UnPackTo(IInteractScreenDetectShapeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025990 RID: 154000 RVA: 0x00527DCC File Offset: 0x00525FCC
		public static Offset<IInteractScreenDetectShapeBase> Pack(FlatBufferBuilder builder, IInteractScreenDetectShapeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractScreenDetectShapeBase>);
			}
			return IInteractScreenDetectShapeBase.CreateIInteractScreenDetectShapeBase(builder, _o.Type);
		}

		// Token: 0x0400F317 RID: 62231
		private Table __p;
	}
}

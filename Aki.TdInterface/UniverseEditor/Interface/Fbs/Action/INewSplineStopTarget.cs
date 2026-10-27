using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA0 RID: 27552
	public struct INewSplineStopTarget : IFlatbufferObject
	{
		// Token: 0x1700CCCA RID: 52426
		// (get) Token: 0x06030643 RID: 198211 RVA: 0x00692B04 File Offset: 0x00690D04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030644 RID: 198212 RVA: 0x00692B11 File Offset: 0x00690D11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030645 RID: 198213 RVA: 0x00692B18 File Offset: 0x00690D18
		public static INewSplineStopTarget GetRootAsINewSplineStopTarget(ByteBuffer _bb)
		{
			return INewSplineStopTarget.GetRootAsINewSplineStopTarget(_bb, default(INewSplineStopTarget));
		}

		// Token: 0x06030646 RID: 198214 RVA: 0x00692B34 File Offset: 0x00690D34
		public static INewSplineStopTarget GetRootAsINewSplineStopTarget(ByteBuffer _bb, INewSplineStopTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030647 RID: 198215 RVA: 0x00692B51 File Offset: 0x00690D51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030648 RID: 198216 RVA: 0x00692B60 File Offset: 0x00690D60
		public INewSplineStopTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCCB RID: 52427
		// (get) Token: 0x06030649 RID: 198217 RVA: 0x00692B70 File Offset: 0x00690D70
		public ENewSplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return (ENewSplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603064A RID: 198218 RVA: 0x00692BAC File Offset: 0x00690DAC
		public static Offset<INewSplineStopTarget> CreateINewSplineStopTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player)
		{
			builder.StartTable(1);
			INewSplineStopTarget.AddType(builder, Type);
			return INewSplineStopTarget.EndINewSplineStopTarget(builder);
		}

		// Token: 0x0603064B RID: 198219 RVA: 0x00692BC2 File Offset: 0x00690DC2
		public static void StartINewSplineStopTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603064C RID: 198220 RVA: 0x00692BCB File Offset: 0x00690DCB
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603064D RID: 198221 RVA: 0x00692BD6 File Offset: 0x00690DD6
		public static Offset<INewSplineStopTarget> EndINewSplineStopTarget(FlatBufferBuilder builder)
		{
			return new Offset<INewSplineStopTarget>(builder.EndTable());
		}

		// Token: 0x0603064E RID: 198222 RVA: 0x00692BE4 File Offset: 0x00690DE4
		public INewSplineStopTargetT UnPack()
		{
			INewSplineStopTargetT newSplineStopTargetT = new INewSplineStopTargetT();
			this.UnPackTo(newSplineStopTargetT);
			return newSplineStopTargetT;
		}

		// Token: 0x0603064F RID: 198223 RVA: 0x00692BFF File Offset: 0x00690DFF
		public void UnPackTo(INewSplineStopTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030650 RID: 198224 RVA: 0x00692C10 File Offset: 0x00690E10
		public static Offset<INewSplineStopTarget> Pack(FlatBufferBuilder builder, INewSplineStopTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<INewSplineStopTarget>);
			}
			return INewSplineStopTarget.CreateINewSplineStopTarget(builder, _o.Type);
		}

		// Token: 0x0401146B RID: 70763
		private Table __p;
	}
}

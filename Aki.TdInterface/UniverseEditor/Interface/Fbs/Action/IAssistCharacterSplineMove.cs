using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061A3 RID: 24995
	public struct IAssistCharacterSplineMove : IFlatbufferObject
	{
		// Token: 0x1700BA4D RID: 47693
		// (get) Token: 0x0602B0D2 RID: 176338 RVA: 0x005F001B File Offset: 0x005EE21B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B0D3 RID: 176339 RVA: 0x005F0028 File Offset: 0x005EE228
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B0D4 RID: 176340 RVA: 0x005F0030 File Offset: 0x005EE230
		public static IAssistCharacterSplineMove GetRootAsIAssistCharacterSplineMove(ByteBuffer _bb)
		{
			return IAssistCharacterSplineMove.GetRootAsIAssistCharacterSplineMove(_bb, default(IAssistCharacterSplineMove));
		}

		// Token: 0x0602B0D5 RID: 176341 RVA: 0x005F004C File Offset: 0x005EE24C
		public static IAssistCharacterSplineMove GetRootAsIAssistCharacterSplineMove(ByteBuffer _bb, IAssistCharacterSplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B0D6 RID: 176342 RVA: 0x005F0069 File Offset: 0x005EE269
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B0D7 RID: 176343 RVA: 0x005F0078 File Offset: 0x005EE278
		public IAssistCharacterSplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA4E RID: 47694
		// (get) Token: 0x0602B0D8 RID: 176344 RVA: 0x005F0088 File Offset: 0x005EE288
		public EAssistCharacterMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAssistCharacterMoveType.Navigation;
				}
				return (EAssistCharacterMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA4F RID: 47695
		// (get) Token: 0x0602B0D9 RID: 176345 RVA: 0x005F00C4 File Offset: 0x005EE2C4
		public int SplineId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B0DA RID: 176346 RVA: 0x005F0100 File Offset: 0x005EE300
		public static Offset<IAssistCharacterSplineMove> CreateIAssistCharacterSplineMove(FlatBufferBuilder builder, EAssistCharacterMoveType Type = EAssistCharacterMoveType.Navigation, int SplineId = 0)
		{
			builder.StartTable(2);
			IAssistCharacterSplineMove.AddSplineId(builder, SplineId);
			IAssistCharacterSplineMove.AddType(builder, Type);
			return IAssistCharacterSplineMove.EndIAssistCharacterSplineMove(builder);
		}

		// Token: 0x0602B0DB RID: 176347 RVA: 0x005F011D File Offset: 0x005EE31D
		public static void StartIAssistCharacterSplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B0DC RID: 176348 RVA: 0x005F0126 File Offset: 0x005EE326
		public static void AddType(FlatBufferBuilder builder, EAssistCharacterMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B0DD RID: 176349 RVA: 0x005F0131 File Offset: 0x005EE331
		public static void AddSplineId(FlatBufferBuilder builder, int splineId)
		{
			builder.AddInt(1, splineId, 0);
		}

		// Token: 0x0602B0DE RID: 176350 RVA: 0x005F013C File Offset: 0x005EE33C
		public static Offset<IAssistCharacterSplineMove> EndIAssistCharacterSplineMove(FlatBufferBuilder builder)
		{
			return new Offset<IAssistCharacterSplineMove>(builder.EndTable());
		}

		// Token: 0x0602B0DF RID: 176351 RVA: 0x005F014C File Offset: 0x005EE34C
		public IAssistCharacterSplineMoveT UnPack()
		{
			IAssistCharacterSplineMoveT assistCharacterSplineMoveT = new IAssistCharacterSplineMoveT();
			this.UnPackTo(assistCharacterSplineMoveT);
			return assistCharacterSplineMoveT;
		}

		// Token: 0x0602B0E0 RID: 176352 RVA: 0x005F0167 File Offset: 0x005EE367
		public void UnPackTo(IAssistCharacterSplineMoveT _o)
		{
			_o.Type = this.Type;
			_o.SplineId = this.SplineId;
		}

		// Token: 0x0602B0E1 RID: 176353 RVA: 0x005F0184 File Offset: 0x005EE384
		public static Offset<IAssistCharacterSplineMove> Pack(FlatBufferBuilder builder, IAssistCharacterSplineMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAssistCharacterSplineMove>);
			}
			return IAssistCharacterSplineMove.CreateIAssistCharacterSplineMove(builder, _o.Type, _o.SplineId);
		}

		// Token: 0x040106B7 RID: 67255
		private Table __p;
	}
}

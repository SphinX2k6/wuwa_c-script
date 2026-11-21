using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005025 RID: 20517
	public struct ICheckSystemFunction : IFlatbufferObject
	{
		// Token: 0x170092CF RID: 37583
		// (get) Token: 0x06020093 RID: 131219 RVA: 0x00471C66 File Offset: 0x0046FE66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020094 RID: 131220 RVA: 0x00471C73 File Offset: 0x0046FE73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020095 RID: 131221 RVA: 0x00471C7C File Offset: 0x0046FE7C
		public static ICheckSystemFunction GetRootAsICheckSystemFunction(ByteBuffer _bb)
		{
			return ICheckSystemFunction.GetRootAsICheckSystemFunction(_bb, default(ICheckSystemFunction));
		}

		// Token: 0x06020096 RID: 131222 RVA: 0x00471C98 File Offset: 0x0046FE98
		public static ICheckSystemFunction GetRootAsICheckSystemFunction(ByteBuffer _bb, ICheckSystemFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020097 RID: 131223 RVA: 0x00471CB5 File Offset: 0x0046FEB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020098 RID: 131224 RVA: 0x00471CC4 File Offset: 0x0046FEC4
		public ICheckSystemFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092D0 RID: 37584
		// (get) Token: 0x06020099 RID: 131225 RVA: 0x00471CD4 File Offset: 0x0046FED4
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

		// Token: 0x170092D1 RID: 37585
		// (get) Token: 0x0602009A RID: 131226 RVA: 0x00471D10 File Offset: 0x0046FF10
		public int SystemId
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

		// Token: 0x170092D2 RID: 37586
		// (get) Token: 0x0602009B RID: 131227 RVA: 0x00471D4C File Offset: 0x0046FF4C
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602009C RID: 131228 RVA: 0x00471D88 File Offset: 0x0046FF88
		public static Offset<ICheckSystemFunction> CreateICheckSystemFunction(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int SystemId = 0, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(3);
			ICheckSystemFunction.AddSystemId(builder, SystemId);
			ICheckSystemFunction.AddCompare(builder, Compare);
			ICheckSystemFunction.AddType(builder, Type);
			return ICheckSystemFunction.EndICheckSystemFunction(builder);
		}

		// Token: 0x0602009D RID: 131229 RVA: 0x00471DAC File Offset: 0x0046FFAC
		public static void StartICheckSystemFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602009E RID: 131230 RVA: 0x00471DB5 File Offset: 0x0046FFB5
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602009F RID: 131231 RVA: 0x00471DC0 File Offset: 0x0046FFC0
		public static void AddSystemId(FlatBufferBuilder builder, int systemId)
		{
			builder.AddInt(1, systemId, 0);
		}

		// Token: 0x060200A0 RID: 131232 RVA: 0x00471DCB File Offset: 0x0046FFCB
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x060200A1 RID: 131233 RVA: 0x00471DD6 File Offset: 0x0046FFD6
		public static Offset<ICheckSystemFunction> EndICheckSystemFunction(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSystemFunction>(builder.EndTable());
		}

		// Token: 0x060200A2 RID: 131234 RVA: 0x00471DE4 File Offset: 0x0046FFE4
		public ICheckSystemFunctionT UnPack()
		{
			ICheckSystemFunctionT checkSystemFunctionT = new ICheckSystemFunctionT();
			this.UnPackTo(checkSystemFunctionT);
			return checkSystemFunctionT;
		}

		// Token: 0x060200A3 RID: 131235 RVA: 0x00471DFF File Offset: 0x0046FFFF
		public void UnPackTo(ICheckSystemFunctionT _o)
		{
			_o.Type = this.Type;
			_o.SystemId = this.SystemId;
			_o.Compare = this.Compare;
		}

		// Token: 0x060200A4 RID: 131236 RVA: 0x00471E28 File Offset: 0x00470028
		public static Offset<ICheckSystemFunction> Pack(FlatBufferBuilder builder, ICheckSystemFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSystemFunction>);
			}
			return ICheckSystemFunction.CreateICheckSystemFunction(builder, _o.Type, _o.SystemId, _o.Compare);
		}

		// Token: 0x0400DEE5 RID: 57061
		private Table __p;
	}
}

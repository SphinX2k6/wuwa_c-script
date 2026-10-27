using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F2 RID: 21490
	public struct IIndependentSystemRewardType : IFlatbufferObject
	{
		// Token: 0x17009E29 RID: 40489
		// (get) Token: 0x060234A9 RID: 144553 RVA: 0x004E2DFB File Offset: 0x004E0FFB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060234AA RID: 144554 RVA: 0x004E2E08 File Offset: 0x004E1008
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060234AB RID: 144555 RVA: 0x004E2E10 File Offset: 0x004E1010
		public static IIndependentSystemRewardType GetRootAsIIndependentSystemRewardType(ByteBuffer _bb)
		{
			return IIndependentSystemRewardType.GetRootAsIIndependentSystemRewardType(_bb, default(IIndependentSystemRewardType));
		}

		// Token: 0x060234AC RID: 144556 RVA: 0x004E2E2C File Offset: 0x004E102C
		public static IIndependentSystemRewardType GetRootAsIIndependentSystemRewardType(ByteBuffer _bb, IIndependentSystemRewardType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060234AD RID: 144557 RVA: 0x004E2E49 File Offset: 0x004E1049
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060234AE RID: 144558 RVA: 0x004E2E58 File Offset: 0x004E1058
		public IIndependentSystemRewardType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E2A RID: 40490
		// (get) Token: 0x060234AF RID: 144559 RVA: 0x004E2E68 File Offset: 0x004E1068
		public EIndependentSystemRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EIndependentSystemRewardType.DarkTide;
				}
				return (EIndependentSystemRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060234B0 RID: 144560 RVA: 0x004E2EA4 File Offset: 0x004E10A4
		public static Offset<IIndependentSystemRewardType> CreateIIndependentSystemRewardType(FlatBufferBuilder builder, EIndependentSystemRewardType Type = EIndependentSystemRewardType.DarkTide)
		{
			builder.StartTable(1);
			IIndependentSystemRewardType.AddType(builder, Type);
			return IIndependentSystemRewardType.EndIIndependentSystemRewardType(builder);
		}

		// Token: 0x060234B1 RID: 144561 RVA: 0x004E2EBA File Offset: 0x004E10BA
		public static void StartIIndependentSystemRewardType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060234B2 RID: 144562 RVA: 0x004E2EC3 File Offset: 0x004E10C3
		public static void AddType(FlatBufferBuilder builder, EIndependentSystemRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060234B3 RID: 144563 RVA: 0x004E2ECE File Offset: 0x004E10CE
		public static Offset<IIndependentSystemRewardType> EndIIndependentSystemRewardType(FlatBufferBuilder builder)
		{
			return new Offset<IIndependentSystemRewardType>(builder.EndTable());
		}

		// Token: 0x060234B4 RID: 144564 RVA: 0x004E2EDC File Offset: 0x004E10DC
		public IIndependentSystemRewardTypeT UnPack()
		{
			IIndependentSystemRewardTypeT independentSystemRewardTypeT = new IIndependentSystemRewardTypeT();
			this.UnPackTo(independentSystemRewardTypeT);
			return independentSystemRewardTypeT;
		}

		// Token: 0x060234B5 RID: 144565 RVA: 0x004E2EF7 File Offset: 0x004E10F7
		public void UnPackTo(IIndependentSystemRewardTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060234B6 RID: 144566 RVA: 0x004E2F08 File Offset: 0x004E1108
		public static Offset<IIndependentSystemRewardType> Pack(FlatBufferBuilder builder, IIndependentSystemRewardTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIndependentSystemRewardType>);
			}
			return IIndependentSystemRewardType.CreateIIndependentSystemRewardType(builder, _o.Type);
		}

		// Token: 0x0400E633 RID: 58931
		private Table __p;
	}
}

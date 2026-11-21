using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006946 RID: 26950
	public struct IChangeElementalBoxStatePlayerTarget : IFlatbufferObject
	{
		// Token: 0x1700C667 RID: 50791
		// (get) Token: 0x0602E328 RID: 189224 RVA: 0x0064F958 File Offset: 0x0064DB58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E329 RID: 189225 RVA: 0x0064F965 File Offset: 0x0064DB65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E32A RID: 189226 RVA: 0x0064F96C File Offset: 0x0064DB6C
		public static IChangeElementalBoxStatePlayerTarget GetRootAsIChangeElementalBoxStatePlayerTarget(ByteBuffer _bb)
		{
			return IChangeElementalBoxStatePlayerTarget.GetRootAsIChangeElementalBoxStatePlayerTarget(_bb, default(IChangeElementalBoxStatePlayerTarget));
		}

		// Token: 0x0602E32B RID: 189227 RVA: 0x0064F988 File Offset: 0x0064DB88
		public static IChangeElementalBoxStatePlayerTarget GetRootAsIChangeElementalBoxStatePlayerTarget(ByteBuffer _bb, IChangeElementalBoxStatePlayerTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E32C RID: 189228 RVA: 0x0064F9A5 File Offset: 0x0064DBA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E32D RID: 189229 RVA: 0x0064F9B4 File Offset: 0x0064DBB4
		public IChangeElementalBoxStatePlayerTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C668 RID: 50792
		// (get) Token: 0x0602E32E RID: 189230 RVA: 0x0064F9C4 File Offset: 0x0064DBC4
		public EChangeElementalBoxStateTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeElementalBoxStateTargetType.Player;
				}
				return (EChangeElementalBoxStateTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E32F RID: 189231 RVA: 0x0064FA00 File Offset: 0x0064DC00
		public static Offset<IChangeElementalBoxStatePlayerTarget> CreateIChangeElementalBoxStatePlayerTarget(FlatBufferBuilder builder, EChangeElementalBoxStateTargetType Type = EChangeElementalBoxStateTargetType.Player)
		{
			builder.StartTable(1);
			IChangeElementalBoxStatePlayerTarget.AddType(builder, Type);
			return IChangeElementalBoxStatePlayerTarget.EndIChangeElementalBoxStatePlayerTarget(builder);
		}

		// Token: 0x0602E330 RID: 189232 RVA: 0x0064FA16 File Offset: 0x0064DC16
		public static void StartIChangeElementalBoxStatePlayerTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E331 RID: 189233 RVA: 0x0064FA1F File Offset: 0x0064DC1F
		public static void AddType(FlatBufferBuilder builder, EChangeElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E332 RID: 189234 RVA: 0x0064FA2A File Offset: 0x0064DC2A
		public static Offset<IChangeElementalBoxStatePlayerTarget> EndIChangeElementalBoxStatePlayerTarget(FlatBufferBuilder builder)
		{
			return new Offset<IChangeElementalBoxStatePlayerTarget>(builder.EndTable());
		}

		// Token: 0x0602E333 RID: 189235 RVA: 0x0064FA38 File Offset: 0x0064DC38
		public IChangeElementalBoxStatePlayerTargetT UnPack()
		{
			IChangeElementalBoxStatePlayerTargetT changeElementalBoxStatePlayerTargetT = new IChangeElementalBoxStatePlayerTargetT();
			this.UnPackTo(changeElementalBoxStatePlayerTargetT);
			return changeElementalBoxStatePlayerTargetT;
		}

		// Token: 0x0602E334 RID: 189236 RVA: 0x0064FA53 File Offset: 0x0064DC53
		public void UnPackTo(IChangeElementalBoxStatePlayerTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E335 RID: 189237 RVA: 0x0064FA64 File Offset: 0x0064DC64
		public static Offset<IChangeElementalBoxStatePlayerTarget> Pack(FlatBufferBuilder builder, IChangeElementalBoxStatePlayerTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeElementalBoxStatePlayerTarget>);
			}
			return IChangeElementalBoxStatePlayerTarget.CreateIChangeElementalBoxStatePlayerTarget(builder, _o.Type);
		}

		// Token: 0x04011693 RID: 71315
		private Table __p;
	}
}

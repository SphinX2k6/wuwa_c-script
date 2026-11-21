using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004190 RID: 16784
	public struct ICheckTrapDefenseEventBase : IFlatbufferObject
	{
		// Token: 0x170071BB RID: 29115
		// (get) Token: 0x060171D1 RID: 94673 RVA: 0x0034B495 File Offset: 0x00349695
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060171D2 RID: 94674 RVA: 0x0034B4A2 File Offset: 0x003496A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060171D3 RID: 94675 RVA: 0x0034B4AC File Offset: 0x003496AC
		public static ICheckTrapDefenseEventBase GetRootAsICheckTrapDefenseEventBase(ByteBuffer _bb)
		{
			return ICheckTrapDefenseEventBase.GetRootAsICheckTrapDefenseEventBase(_bb, default(ICheckTrapDefenseEventBase));
		}

		// Token: 0x060171D4 RID: 94676 RVA: 0x0034B4C8 File Offset: 0x003496C8
		public static ICheckTrapDefenseEventBase GetRootAsICheckTrapDefenseEventBase(ByteBuffer _bb, ICheckTrapDefenseEventBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060171D5 RID: 94677 RVA: 0x0034B4E5 File Offset: 0x003496E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060171D6 RID: 94678 RVA: 0x0034B4F4 File Offset: 0x003496F4
		public ICheckTrapDefenseEventBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071BC RID: 29116
		// (get) Token: 0x060171D7 RID: 94679 RVA: 0x0034B504 File Offset: 0x00349704
		public ECheckTrapDefenseEvent Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckTrapDefenseEvent.MonsterKilled;
				}
				return (ECheckTrapDefenseEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060171D8 RID: 94680 RVA: 0x0034B540 File Offset: 0x00349740
		public static Offset<ICheckTrapDefenseEventBase> CreateICheckTrapDefenseEventBase(FlatBufferBuilder builder, ECheckTrapDefenseEvent Type = ECheckTrapDefenseEvent.MonsterKilled)
		{
			builder.StartTable(1);
			ICheckTrapDefenseEventBase.AddType(builder, Type);
			return ICheckTrapDefenseEventBase.EndICheckTrapDefenseEventBase(builder);
		}

		// Token: 0x060171D9 RID: 94681 RVA: 0x0034B556 File Offset: 0x00349756
		public static void StartICheckTrapDefenseEventBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060171DA RID: 94682 RVA: 0x0034B55F File Offset: 0x0034975F
		public static void AddType(FlatBufferBuilder builder, ECheckTrapDefenseEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060171DB RID: 94683 RVA: 0x0034B56A File Offset: 0x0034976A
		public static Offset<ICheckTrapDefenseEventBase> EndICheckTrapDefenseEventBase(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTrapDefenseEventBase>(builder.EndTable());
		}

		// Token: 0x060171DC RID: 94684 RVA: 0x0034B578 File Offset: 0x00349778
		public ICheckTrapDefenseEventBaseT UnPack()
		{
			ICheckTrapDefenseEventBaseT checkTrapDefenseEventBaseT = new ICheckTrapDefenseEventBaseT();
			this.UnPackTo(checkTrapDefenseEventBaseT);
			return checkTrapDefenseEventBaseT;
		}

		// Token: 0x060171DD RID: 94685 RVA: 0x0034B593 File Offset: 0x00349793
		public void UnPackTo(ICheckTrapDefenseEventBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060171DE RID: 94686 RVA: 0x0034B5A4 File Offset: 0x003497A4
		public static Offset<ICheckTrapDefenseEventBase> Pack(FlatBufferBuilder builder, ICheckTrapDefenseEventBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTrapDefenseEventBase>);
			}
			return ICheckTrapDefenseEventBase.CreateICheckTrapDefenseEventBase(builder, _o.Type);
		}

		// Token: 0x0400C00E RID: 49166
		private Table __p;
	}
}

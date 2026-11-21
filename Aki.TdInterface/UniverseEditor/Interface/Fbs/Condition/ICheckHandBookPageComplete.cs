using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F08 RID: 20232
	public struct ICheckHandBookPageComplete : IFlatbufferObject
	{
		// Token: 0x17009079 RID: 36985
		// (get) Token: 0x0601F6DF RID: 128735 RVA: 0x004608C2 File Offset: 0x0045EAC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F6E0 RID: 128736 RVA: 0x004608CF File Offset: 0x0045EACF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F6E1 RID: 128737 RVA: 0x004608D8 File Offset: 0x0045EAD8
		public static ICheckHandBookPageComplete GetRootAsICheckHandBookPageComplete(ByteBuffer _bb)
		{
			return ICheckHandBookPageComplete.GetRootAsICheckHandBookPageComplete(_bb, default(ICheckHandBookPageComplete));
		}

		// Token: 0x0601F6E2 RID: 128738 RVA: 0x004608F4 File Offset: 0x0045EAF4
		public static ICheckHandBookPageComplete GetRootAsICheckHandBookPageComplete(ByteBuffer _bb, ICheckHandBookPageComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F6E3 RID: 128739 RVA: 0x00460911 File Offset: 0x0045EB11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F6E4 RID: 128740 RVA: 0x00460920 File Offset: 0x0045EB20
		public ICheckHandBookPageComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700907A RID: 36986
		// (get) Token: 0x0601F6E5 RID: 128741 RVA: 0x00460930 File Offset: 0x0045EB30
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700907B RID: 36987
		// (get) Token: 0x0601F6E6 RID: 128742 RVA: 0x0046096C File Offset: 0x0045EB6C
		public int Id
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

		// Token: 0x1700907C RID: 36988
		// (get) Token: 0x0601F6E7 RID: 128743 RVA: 0x004609A8 File Offset: 0x0045EBA8
		public bool IsComplete
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F6E8 RID: 128744 RVA: 0x004609E7 File Offset: 0x0045EBE7
		public static Offset<ICheckHandBookPageComplete> CreateICheckHandBookPageComplete(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int Id = 0, bool IsComplete = false)
		{
			builder.StartTable(3);
			ICheckHandBookPageComplete.AddId(builder, Id);
			ICheckHandBookPageComplete.AddIsComplete(builder, IsComplete);
			ICheckHandBookPageComplete.AddType(builder, Type);
			return ICheckHandBookPageComplete.EndICheckHandBookPageComplete(builder);
		}

		// Token: 0x0601F6E9 RID: 128745 RVA: 0x00460A0B File Offset: 0x0045EC0B
		public static void StartICheckHandBookPageComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F6EA RID: 128746 RVA: 0x00460A14 File Offset: 0x0045EC14
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F6EB RID: 128747 RVA: 0x00460A1F File Offset: 0x0045EC1F
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601F6EC RID: 128748 RVA: 0x00460A2A File Offset: 0x0045EC2A
		public static void AddIsComplete(FlatBufferBuilder builder, bool isComplete)
		{
			builder.AddBool(2, isComplete, false);
		}

		// Token: 0x0601F6ED RID: 128749 RVA: 0x00460A35 File Offset: 0x0045EC35
		public static Offset<ICheckHandBookPageComplete> EndICheckHandBookPageComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHandBookPageComplete>(builder.EndTable());
		}

		// Token: 0x0601F6EE RID: 128750 RVA: 0x00460A44 File Offset: 0x0045EC44
		public ICheckHandBookPageCompleteT UnPack()
		{
			ICheckHandBookPageCompleteT checkHandBookPageCompleteT = new ICheckHandBookPageCompleteT();
			this.UnPackTo(checkHandBookPageCompleteT);
			return checkHandBookPageCompleteT;
		}

		// Token: 0x0601F6EF RID: 128751 RVA: 0x00460A5F File Offset: 0x0045EC5F
		public void UnPackTo(ICheckHandBookPageCompleteT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.IsComplete = this.IsComplete;
		}

		// Token: 0x0601F6F0 RID: 128752 RVA: 0x00460A88 File Offset: 0x0045EC88
		public static Offset<ICheckHandBookPageComplete> Pack(FlatBufferBuilder builder, ICheckHandBookPageCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHandBookPageComplete>);
			}
			return ICheckHandBookPageComplete.CreateICheckHandBookPageComplete(builder, _o.Type, _o.Id, _o.IsComplete);
		}

		// Token: 0x0400DD72 RID: 56690
		private Table __p;
	}
}

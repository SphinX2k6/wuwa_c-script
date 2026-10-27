using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x020048FF RID: 18687
	public struct ILoopTeleportClientLogicItemBase : IFlatbufferObject
	{
		// Token: 0x17008785 RID: 34693
		// (get) Token: 0x0601D366 RID: 119654 RVA: 0x0041F368 File Offset: 0x0041D568
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D367 RID: 119655 RVA: 0x0041F375 File Offset: 0x0041D575
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D368 RID: 119656 RVA: 0x0041F37C File Offset: 0x0041D57C
		public static ILoopTeleportClientLogicItemBase GetRootAsILoopTeleportClientLogicItemBase(ByteBuffer _bb)
		{
			return ILoopTeleportClientLogicItemBase.GetRootAsILoopTeleportClientLogicItemBase(_bb, default(ILoopTeleportClientLogicItemBase));
		}

		// Token: 0x0601D369 RID: 119657 RVA: 0x0041F398 File Offset: 0x0041D598
		public static ILoopTeleportClientLogicItemBase GetRootAsILoopTeleportClientLogicItemBase(ByteBuffer _bb, ILoopTeleportClientLogicItemBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D36A RID: 119658 RVA: 0x0041F3B5 File Offset: 0x0041D5B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D36B RID: 119659 RVA: 0x0041F3C4 File Offset: 0x0041D5C4
		public ILoopTeleportClientLogicItemBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008786 RID: 34694
		// (get) Token: 0x0601D36C RID: 119660 RVA: 0x0041F3D4 File Offset: 0x0041D5D4
		public ELoopTeleportClientLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELoopTeleportClientLogicType.PlayEffect;
				}
				return (ELoopTeleportClientLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D36D RID: 119661 RVA: 0x0041F410 File Offset: 0x0041D610
		public static Offset<ILoopTeleportClientLogicItemBase> CreateILoopTeleportClientLogicItemBase(FlatBufferBuilder builder, ELoopTeleportClientLogicType Type = ELoopTeleportClientLogicType.PlayEffect)
		{
			builder.StartTable(1);
			ILoopTeleportClientLogicItemBase.AddType(builder, Type);
			return ILoopTeleportClientLogicItemBase.EndILoopTeleportClientLogicItemBase(builder);
		}

		// Token: 0x0601D36E RID: 119662 RVA: 0x0041F426 File Offset: 0x0041D626
		public static void StartILoopTeleportClientLogicItemBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D36F RID: 119663 RVA: 0x0041F42F File Offset: 0x0041D62F
		public static void AddType(FlatBufferBuilder builder, ELoopTeleportClientLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D370 RID: 119664 RVA: 0x0041F43A File Offset: 0x0041D63A
		public static Offset<ILoopTeleportClientLogicItemBase> EndILoopTeleportClientLogicItemBase(FlatBufferBuilder builder)
		{
			return new Offset<ILoopTeleportClientLogicItemBase>(builder.EndTable());
		}

		// Token: 0x0601D371 RID: 119665 RVA: 0x0041F448 File Offset: 0x0041D648
		public ILoopTeleportClientLogicItemBaseT UnPack()
		{
			ILoopTeleportClientLogicItemBaseT loopTeleportClientLogicItemBaseT = new ILoopTeleportClientLogicItemBaseT();
			this.UnPackTo(loopTeleportClientLogicItemBaseT);
			return loopTeleportClientLogicItemBaseT;
		}

		// Token: 0x0601D372 RID: 119666 RVA: 0x0041F463 File Offset: 0x0041D663
		public void UnPackTo(ILoopTeleportClientLogicItemBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601D373 RID: 119667 RVA: 0x0041F474 File Offset: 0x0041D674
		public static Offset<ILoopTeleportClientLogicItemBase> Pack(FlatBufferBuilder builder, ILoopTeleportClientLogicItemBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILoopTeleportClientLogicItemBase>);
			}
			return ILoopTeleportClientLogicItemBase.CreateILoopTeleportClientLogicItemBase(builder, _o.Type);
		}

		// Token: 0x0400CF6D RID: 53101
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065D3 RID: 26067
	public struct IDisableAllPlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700C16F RID: 49519
		// (get) Token: 0x0602D34A RID: 185162 RVA: 0x006324B5 File Offset: 0x006306B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D34B RID: 185163 RVA: 0x006324C2 File Offset: 0x006306C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D34C RID: 185164 RVA: 0x006324CC File Offset: 0x006306CC
		public static IDisableAllPlayerOperation GetRootAsIDisableAllPlayerOperation(ByteBuffer _bb)
		{
			return IDisableAllPlayerOperation.GetRootAsIDisableAllPlayerOperation(_bb, default(IDisableAllPlayerOperation));
		}

		// Token: 0x0602D34D RID: 185165 RVA: 0x006324E8 File Offset: 0x006306E8
		public static IDisableAllPlayerOperation GetRootAsIDisableAllPlayerOperation(ByteBuffer _bb, IDisableAllPlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D34E RID: 185166 RVA: 0x00632505 File Offset: 0x00630705
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D34F RID: 185167 RVA: 0x00632514 File Offset: 0x00630714
		public IDisableAllPlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C170 RID: 49520
		// (get) Token: 0x0602D350 RID: 185168 RVA: 0x00632524 File Offset: 0x00630724
		public EPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerOperationType.EnableAll;
				}
				return (EPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C171 RID: 49521
		// (get) Token: 0x0602D351 RID: 185169 RVA: 0x00632560 File Offset: 0x00630760
		public EDisplayModeInPlayerOp DisplayMode
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDisplayModeInPlayerOp.ShowUi;
				}
				return (EDisplayModeInPlayerOp)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C172 RID: 49522
		// (get) Token: 0x0602D352 RID: 185170 RVA: 0x0063259C File Offset: 0x0063079C
		public bool IsUiFadeEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C173 RID: 49523
		// (get) Token: 0x0602D353 RID: 185171 RVA: 0x006325DC File Offset: 0x006307DC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D354 RID: 185172 RVA: 0x00632619 File Offset: 0x00630819
		public static Offset<IDisableAllPlayerOperation> CreateIDisableAllPlayerOperation(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll, EDisplayModeInPlayerOp DisplayMode = EDisplayModeInPlayerOp.ShowUi, bool IsUiFadeEffect = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDisableAllPlayerOperation.AddNullMask(builder, NullMask);
			IDisableAllPlayerOperation.AddIsUiFadeEffect(builder, IsUiFadeEffect);
			IDisableAllPlayerOperation.AddDisplayMode(builder, DisplayMode);
			IDisableAllPlayerOperation.AddType(builder, Type);
			return IDisableAllPlayerOperation.EndIDisableAllPlayerOperation(builder);
		}

		// Token: 0x0602D355 RID: 185173 RVA: 0x00632645 File Offset: 0x00630845
		public static void StartIDisableAllPlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602D356 RID: 185174 RVA: 0x0063264E File Offset: 0x0063084E
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D357 RID: 185175 RVA: 0x00632659 File Offset: 0x00630859
		public static void AddDisplayMode(FlatBufferBuilder builder, EDisplayModeInPlayerOp displayMode)
		{
			builder.AddByte(1, (byte)displayMode, 0);
		}

		// Token: 0x0602D358 RID: 185176 RVA: 0x00632664 File Offset: 0x00630864
		public static void AddIsUiFadeEffect(FlatBufferBuilder builder, bool isUiFadeEffect)
		{
			builder.AddBool(2, isUiFadeEffect, false);
		}

		// Token: 0x0602D359 RID: 185177 RVA: 0x0063266F File Offset: 0x0063086F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602D35A RID: 185178 RVA: 0x0063267A File Offset: 0x0063087A
		public static Offset<IDisableAllPlayerOperation> EndIDisableAllPlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableAllPlayerOperation>(builder.EndTable());
		}

		// Token: 0x0602D35B RID: 185179 RVA: 0x00632688 File Offset: 0x00630888
		public IDisableAllPlayerOperationT UnPack()
		{
			IDisableAllPlayerOperationT disableAllPlayerOperationT = new IDisableAllPlayerOperationT();
			this.UnPackTo(disableAllPlayerOperationT);
			return disableAllPlayerOperationT;
		}

		// Token: 0x0602D35C RID: 185180 RVA: 0x006326A3 File Offset: 0x006308A3
		public void UnPackTo(IDisableAllPlayerOperationT _o)
		{
			_o.Type = this.Type;
			_o.DisplayMode = this.DisplayMode;
			_o.IsUiFadeEffect = this.IsUiFadeEffect;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D35D RID: 185181 RVA: 0x006326D8 File Offset: 0x006308D8
		public static Offset<IDisableAllPlayerOperation> Pack(FlatBufferBuilder builder, IDisableAllPlayerOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableAllPlayerOperation>);
			}
			return IDisableAllPlayerOperation.CreateIDisableAllPlayerOperation(builder, _o.Type, _o.DisplayMode, _o.IsUiFadeEffect, _o.NullMask);
		}

		// Token: 0x04010C33 RID: 68659
		private Table __p;
	}
}

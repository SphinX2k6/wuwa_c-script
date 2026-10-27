using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B8F RID: 15247
	public struct ICheckpointDisplay : IFlatbufferObject
	{
		// Token: 0x1700687F RID: 26751
		// (get) Token: 0x06014E22 RID: 85538 RVA: 0x00307E6E File Offset: 0x0030606E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014E23 RID: 85539 RVA: 0x00307E7B File Offset: 0x0030607B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014E24 RID: 85540 RVA: 0x00307E84 File Offset: 0x00306084
		public static ICheckpointDisplay GetRootAsICheckpointDisplay(ByteBuffer _bb)
		{
			return ICheckpointDisplay.GetRootAsICheckpointDisplay(_bb, default(ICheckpointDisplay));
		}

		// Token: 0x06014E25 RID: 85541 RVA: 0x00307EA0 File Offset: 0x003060A0
		public static ICheckpointDisplay GetRootAsICheckpointDisplay(ByteBuffer _bb, ICheckpointDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014E26 RID: 85542 RVA: 0x00307EBD File Offset: 0x003060BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014E27 RID: 85543 RVA: 0x00307ECC File Offset: 0x003060CC
		public ICheckpointDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006880 RID: 26752
		// (get) Token: 0x06014E28 RID: 85544 RVA: 0x00307EDC File Offset: 0x003060DC
		public ECheckpointDisplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckpointDisplayType.Role;
				}
				return (ECheckpointDisplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014E29 RID: 85545 RVA: 0x00307F18 File Offset: 0x00306118
		public static Offset<ICheckpointDisplay> CreateICheckpointDisplay(FlatBufferBuilder builder, ECheckpointDisplayType Type = ECheckpointDisplayType.Role)
		{
			builder.StartTable(1);
			ICheckpointDisplay.AddType(builder, Type);
			return ICheckpointDisplay.EndICheckpointDisplay(builder);
		}

		// Token: 0x06014E2A RID: 85546 RVA: 0x00307F2E File Offset: 0x0030612E
		public static void StartICheckpointDisplay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014E2B RID: 85547 RVA: 0x00307F37 File Offset: 0x00306137
		public static void AddType(FlatBufferBuilder builder, ECheckpointDisplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014E2C RID: 85548 RVA: 0x00307F42 File Offset: 0x00306142
		public static Offset<ICheckpointDisplay> EndICheckpointDisplay(FlatBufferBuilder builder)
		{
			return new Offset<ICheckpointDisplay>(builder.EndTable());
		}

		// Token: 0x06014E2D RID: 85549 RVA: 0x00307F50 File Offset: 0x00306150
		public ICheckpointDisplayT UnPack()
		{
			ICheckpointDisplayT checkpointDisplayT = new ICheckpointDisplayT();
			this.UnPackTo(checkpointDisplayT);
			return checkpointDisplayT;
		}

		// Token: 0x06014E2E RID: 85550 RVA: 0x00307F6B File Offset: 0x0030616B
		public void UnPackTo(ICheckpointDisplayT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014E2F RID: 85551 RVA: 0x00307F7C File Offset: 0x0030617C
		public static Offset<ICheckpointDisplay> Pack(FlatBufferBuilder builder, ICheckpointDisplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckpointDisplay>);
			}
			return ICheckpointDisplay.CreateICheckpointDisplay(builder, _o.Type);
		}

		// Token: 0x0400B0F7 RID: 45303
		private Table __p;
	}
}

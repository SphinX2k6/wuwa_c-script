using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003F97 RID: 16279
	public struct ICheckpointDisplay : IFlatbufferObject
	{
		// Token: 0x17006E1E RID: 28190
		// (get) Token: 0x060162EC RID: 90860 RVA: 0x0032E406 File Offset: 0x0032C606
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060162ED RID: 90861 RVA: 0x0032E413 File Offset: 0x0032C613
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060162EE RID: 90862 RVA: 0x0032E41C File Offset: 0x0032C61C
		public static ICheckpointDisplay GetRootAsICheckpointDisplay(ByteBuffer _bb)
		{
			return ICheckpointDisplay.GetRootAsICheckpointDisplay(_bb, default(ICheckpointDisplay));
		}

		// Token: 0x060162EF RID: 90863 RVA: 0x0032E438 File Offset: 0x0032C638
		public static ICheckpointDisplay GetRootAsICheckpointDisplay(ByteBuffer _bb, ICheckpointDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060162F0 RID: 90864 RVA: 0x0032E455 File Offset: 0x0032C655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060162F1 RID: 90865 RVA: 0x0032E464 File Offset: 0x0032C664
		public ICheckpointDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E1F RID: 28191
		// (get) Token: 0x060162F2 RID: 90866 RVA: 0x0032E474 File Offset: 0x0032C674
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

		// Token: 0x060162F3 RID: 90867 RVA: 0x0032E4B0 File Offset: 0x0032C6B0
		public static Offset<ICheckpointDisplay> CreateICheckpointDisplay(FlatBufferBuilder builder, ECheckpointDisplayType Type = ECheckpointDisplayType.Role)
		{
			builder.StartTable(1);
			ICheckpointDisplay.AddType(builder, Type);
			return ICheckpointDisplay.EndICheckpointDisplay(builder);
		}

		// Token: 0x060162F4 RID: 90868 RVA: 0x0032E4C6 File Offset: 0x0032C6C6
		public static void StartICheckpointDisplay(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060162F5 RID: 90869 RVA: 0x0032E4CF File Offset: 0x0032C6CF
		public static void AddType(FlatBufferBuilder builder, ECheckpointDisplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060162F6 RID: 90870 RVA: 0x0032E4DA File Offset: 0x0032C6DA
		public static Offset<ICheckpointDisplay> EndICheckpointDisplay(FlatBufferBuilder builder)
		{
			return new Offset<ICheckpointDisplay>(builder.EndTable());
		}

		// Token: 0x060162F7 RID: 90871 RVA: 0x0032E4E8 File Offset: 0x0032C6E8
		public ICheckpointDisplayT UnPack()
		{
			ICheckpointDisplayT checkpointDisplayT = new ICheckpointDisplayT();
			this.UnPackTo(checkpointDisplayT);
			return checkpointDisplayT;
		}

		// Token: 0x060162F8 RID: 90872 RVA: 0x0032E503 File Offset: 0x0032C703
		public void UnPackTo(ICheckpointDisplayT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060162F9 RID: 90873 RVA: 0x0032E514 File Offset: 0x0032C714
		public static Offset<ICheckpointDisplay> Pack(FlatBufferBuilder builder, ICheckpointDisplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckpointDisplay>);
			}
			return ICheckpointDisplay.CreateICheckpointDisplay(builder, _o.Type);
		}

		// Token: 0x0400BA74 RID: 47732
		private Table __p;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D61 RID: 3425
	[NetMessage(EMessageId.PinballSpawnFirstFinishNotify)]
	public sealed class PinballSpawnFirstFinishNotify : IMessage<PinballSpawnFirstFinishNotify>, IMessage, IEquatable<PinballSpawnFirstFinishNotify>, IDeepCloneable<PinballSpawnFirstFinishNotify>, IBufferMessage
	{
		// Token: 0x06012794 RID: 75668 RVA: 0x002B222C File Offset: 0x002B042C
		[NullableContext(1)]
		public static PinballSpawnFirstFinishNotify Create()
		{
			return new PinballSpawnFirstFinishNotify();
		}

		// Token: 0x17003D3F RID: 15679
		// (get) Token: 0x06012795 RID: 75669 RVA: 0x002B2233 File Offset: 0x002B0433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D40 RID: 15680
		// (get) Token: 0x06012796 RID: 75670 RVA: 0x002B2236 File Offset: 0x002B0436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballSpawnFirstFinishNotify.Descriptor;
			}
		}

		// Token: 0x06012797 RID: 75671 RVA: 0x002B223D File Offset: 0x002B043D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSpawnFirstFinishNotify()
		{
		}

		// Token: 0x06012798 RID: 75672 RVA: 0x002B2245 File Offset: 0x002B0445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSpawnFirstFinishNotify(PinballSpawnFirstFinishNotify other) : this()
		{
			this.waveId_ = other.waveId_;
			this.spawnId_ = other.spawnId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012799 RID: 75673 RVA: 0x002B2276 File Offset: 0x002B0476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSpawnFirstFinishNotify Clone()
		{
			return new PinballSpawnFirstFinishNotify(this);
		}

		// Token: 0x17003D41 RID: 15681
		// (get) Token: 0x0601279A RID: 75674 RVA: 0x002B227E File Offset: 0x002B047E
		// (set) Token: 0x0601279B RID: 75675 RVA: 0x002B2286 File Offset: 0x002B0486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveId
		{
			get
			{
				return this.waveId_;
			}
			set
			{
				this.waveId_ = value;
			}
		}

		// Token: 0x17003D42 RID: 15682
		// (get) Token: 0x0601279C RID: 75676 RVA: 0x002B228F File Offset: 0x002B048F
		// (set) Token: 0x0601279D RID: 75677 RVA: 0x002B2297 File Offset: 0x002B0497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpawnId
		{
			get
			{
				return this.spawnId_;
			}
			set
			{
				this.spawnId_ = value;
			}
		}

		// Token: 0x0601279E RID: 75678 RVA: 0x002B22A0 File Offset: 0x002B04A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballSpawnFirstFinishNotify);
		}

		// Token: 0x0601279F RID: 75679 RVA: 0x002B22AE File Offset: 0x002B04AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballSpawnFirstFinishNotify other)
		{
			return other != null && (other == this || (this.WaveId == other.WaveId && this.SpawnId == other.SpawnId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060127A0 RID: 75680 RVA: 0x002B22EC File Offset: 0x002B04EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WaveId != 0)
			{
				num ^= this.WaveId.GetHashCode();
			}
			if (this.SpawnId != 0)
			{
				num ^= this.SpawnId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060127A1 RID: 75681 RVA: 0x002B2344 File Offset: 0x002B0544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060127A2 RID: 75682 RVA: 0x002B2351 File Offset: 0x002B0551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060127A3 RID: 75683 RVA: 0x002B235C File Offset: 0x002B055C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WaveId);
			}
			if (this.SpawnId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SpawnId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060127A4 RID: 75684 RVA: 0x002B23B8 File Offset: 0x002B05B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WaveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveId);
			}
			if (this.SpawnId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpawnId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060127A5 RID: 75685 RVA: 0x002B2410 File Offset: 0x002B0610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballSpawnFirstFinishNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WaveId != 0)
			{
				this.WaveId = other.WaveId;
			}
			if (other.SpawnId != 0)
			{
				this.SpawnId = other.SpawnId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060127A6 RID: 75686 RVA: 0x002B2460 File Offset: 0x002B0660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060127A7 RID: 75687 RVA: 0x002B246C File Offset: 0x002B066C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 24U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SpawnId = input.ReadInt32();
					}
				}
				else
				{
					this.WaveId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040072EF RID: 29423
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072F0 RID: 29424
		public const int WaveIdFieldNumber = 3;

		// Token: 0x040072F1 RID: 29425
		private int waveId_;

		// Token: 0x040072F2 RID: 29426
		public const int SpawnIdFieldNumber = 13;

		// Token: 0x040072F3 RID: 29427
		private int spawnId_;
	}
}

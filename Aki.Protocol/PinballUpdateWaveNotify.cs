using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D5A RID: 3418
	[NetMessage(EMessageId.PinballUpdateWaveNotify)]
	public sealed class PinballUpdateWaveNotify : IMessage<PinballUpdateWaveNotify>, IMessage, IEquatable<PinballUpdateWaveNotify>, IDeepCloneable<PinballUpdateWaveNotify>, IBufferMessage
	{
		// Token: 0x06012744 RID: 75588 RVA: 0x002B1C92 File Offset: 0x002AFE92
		[NullableContext(1)]
		public static PinballUpdateWaveNotify Create()
		{
			return new PinballUpdateWaveNotify();
		}

		// Token: 0x17003D2A RID: 15658
		// (get) Token: 0x06012745 RID: 75589 RVA: 0x002B1C99 File Offset: 0x002AFE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D2B RID: 15659
		// (get) Token: 0x06012746 RID: 75590 RVA: 0x002B1C9C File Offset: 0x002AFE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballUpdateWaveNotify.Descriptor;
			}
		}

		// Token: 0x06012747 RID: 75591 RVA: 0x002B1CA3 File Offset: 0x002AFEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateWaveNotify()
		{
		}

		// Token: 0x06012748 RID: 75592 RVA: 0x002B1CAB File Offset: 0x002AFEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateWaveNotify(PinballUpdateWaveNotify other) : this()
		{
			this.waveId_ = other.waveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012749 RID: 75593 RVA: 0x002B1CD0 File Offset: 0x002AFED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateWaveNotify Clone()
		{
			return new PinballUpdateWaveNotify(this);
		}

		// Token: 0x17003D2C RID: 15660
		// (get) Token: 0x0601274A RID: 75594 RVA: 0x002B1CD8 File Offset: 0x002AFED8
		// (set) Token: 0x0601274B RID: 75595 RVA: 0x002B1CE0 File Offset: 0x002AFEE0
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

		// Token: 0x0601274C RID: 75596 RVA: 0x002B1CE9 File Offset: 0x002AFEE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballUpdateWaveNotify);
		}

		// Token: 0x0601274D RID: 75597 RVA: 0x002B1CF7 File Offset: 0x002AFEF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballUpdateWaveNotify other)
		{
			return other != null && (other == this || (this.WaveId == other.WaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601274E RID: 75598 RVA: 0x002B1D28 File Offset: 0x002AFF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WaveId != 0)
			{
				num ^= this.WaveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601274F RID: 75599 RVA: 0x002B1D67 File Offset: 0x002AFF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012750 RID: 75600 RVA: 0x002B1D74 File Offset: 0x002AFF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012751 RID: 75601 RVA: 0x002B1D7D File Offset: 0x002AFF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.WaveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012752 RID: 75602 RVA: 0x002B1DB0 File Offset: 0x002AFFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WaveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012753 RID: 75603 RVA: 0x002B1DEE File Offset: 0x002AFFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballUpdateWaveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WaveId != 0)
			{
				this.WaveId = other.WaveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012754 RID: 75604 RVA: 0x002B1E1F File Offset: 0x002B001F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012755 RID: 75605 RVA: 0x002B1E28 File Offset: 0x002B0028
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WaveId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007328 RID: 29480
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007329 RID: 29481
		public const int WaveIdFieldNumber = 8;

		// Token: 0x0400732A RID: 29482
		private int waveId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200092E RID: 2350
	[NetMessage(EMessageId.LivenessCountUpdateNotify)]
	public sealed class LivenessCountUpdateNotify : IMessage<LivenessCountUpdateNotify>, IMessage, IEquatable<LivenessCountUpdateNotify>, IDeepCloneable<LivenessCountUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600CF39 RID: 53049 RVA: 0x001E8437 File Offset: 0x001E6637
		[NullableContext(1)]
		public static LivenessCountUpdateNotify Create()
		{
			return new LivenessCountUpdateNotify();
		}

		// Token: 0x170029DE RID: 10718
		// (get) Token: 0x0600CF3A RID: 53050 RVA: 0x001E843E File Offset: 0x001E663E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029DF RID: 10719
		// (get) Token: 0x0600CF3B RID: 53051 RVA: 0x001E8441 File Offset: 0x001E6641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessCountUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600CF3C RID: 53052 RVA: 0x001E8448 File Offset: 0x001E6648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessCountUpdateNotify()
		{
		}

		// Token: 0x0600CF3D RID: 53053 RVA: 0x001E8450 File Offset: 0x001E6650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessCountUpdateNotify(LivenessCountUpdateNotify other) : this()
		{
			this.livenessCount_ = other.livenessCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF3E RID: 53054 RVA: 0x001E8475 File Offset: 0x001E6675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessCountUpdateNotify Clone()
		{
			return new LivenessCountUpdateNotify(this);
		}

		// Token: 0x170029E0 RID: 10720
		// (get) Token: 0x0600CF3F RID: 53055 RVA: 0x001E847D File Offset: 0x001E667D
		// (set) Token: 0x0600CF40 RID: 53056 RVA: 0x001E8485 File Offset: 0x001E6685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LivenessCount
		{
			get
			{
				return this.livenessCount_;
			}
			set
			{
				this.livenessCount_ = value;
			}
		}

		// Token: 0x0600CF41 RID: 53057 RVA: 0x001E848E File Offset: 0x001E668E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessCountUpdateNotify);
		}

		// Token: 0x0600CF42 RID: 53058 RVA: 0x001E849C File Offset: 0x001E669C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessCountUpdateNotify other)
		{
			return other != null && (other == this || (this.LivenessCount == other.LivenessCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF43 RID: 53059 RVA: 0x001E84CC File Offset: 0x001E66CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LivenessCount != 0)
			{
				num ^= this.LivenessCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CF44 RID: 53060 RVA: 0x001E850B File Offset: 0x001E670B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF45 RID: 53061 RVA: 0x001E8518 File Offset: 0x001E6718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF46 RID: 53062 RVA: 0x001E8521 File Offset: 0x001E6721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LivenessCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LivenessCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF47 RID: 53063 RVA: 0x001E8554 File Offset: 0x001E6754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LivenessCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LivenessCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CF48 RID: 53064 RVA: 0x001E8592 File Offset: 0x001E6792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessCountUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LivenessCount != 0)
			{
				this.LivenessCount = other.LivenessCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF49 RID: 53065 RVA: 0x001E85C3 File Offset: 0x001E67C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF4A RID: 53066 RVA: 0x001E85CC File Offset: 0x001E67CC
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LivenessCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005778 RID: 22392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005779 RID: 22393
		public const int LivenessCountFieldNumber = 1;

		// Token: 0x0400577A RID: 22394
		private int livenessCount_;
	}
}

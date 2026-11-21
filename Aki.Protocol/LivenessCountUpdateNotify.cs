using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200091D RID: 2333
	[NetMessage(EMessageId.LivenessCountUpdateNotify)]
	public sealed class LivenessCountUpdateNotify : IMessage<LivenessCountUpdateNotify>, IMessage, IEquatable<LivenessCountUpdateNotify>, IDeepCloneable<LivenessCountUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600CE1D RID: 52765 RVA: 0x001E6163 File Offset: 0x001E4363
		[NullableContext(1)]
		public static LivenessCountUpdateNotify Create()
		{
			return new LivenessCountUpdateNotify();
		}

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x0600CE1E RID: 52766 RVA: 0x001E616A File Offset: 0x001E436A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x0600CE1F RID: 52767 RVA: 0x001E616D File Offset: 0x001E436D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessCountUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600CE20 RID: 52768 RVA: 0x001E6174 File Offset: 0x001E4374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessCountUpdateNotify()
		{
		}

		// Token: 0x0600CE21 RID: 52769 RVA: 0x001E617C File Offset: 0x001E437C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessCountUpdateNotify(LivenessCountUpdateNotify other) : this()
		{
			this.livenessCount_ = other.livenessCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE22 RID: 52770 RVA: 0x001E61A1 File Offset: 0x001E43A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessCountUpdateNotify Clone()
		{
			return new LivenessCountUpdateNotify(this);
		}

		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x0600CE23 RID: 52771 RVA: 0x001E61A9 File Offset: 0x001E43A9
		// (set) Token: 0x0600CE24 RID: 52772 RVA: 0x001E61B1 File Offset: 0x001E43B1
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

		// Token: 0x0600CE25 RID: 52773 RVA: 0x001E61BA File Offset: 0x001E43BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessCountUpdateNotify);
		}

		// Token: 0x0600CE26 RID: 52774 RVA: 0x001E61C8 File Offset: 0x001E43C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessCountUpdateNotify other)
		{
			return other != null && (other == this || (this.LivenessCount == other.LivenessCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE27 RID: 52775 RVA: 0x001E61F8 File Offset: 0x001E43F8
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

		// Token: 0x0600CE28 RID: 52776 RVA: 0x001E6237 File Offset: 0x001E4437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE29 RID: 52777 RVA: 0x001E6244 File Offset: 0x001E4444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE2A RID: 52778 RVA: 0x001E624D File Offset: 0x001E444D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LivenessCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.LivenessCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE2B RID: 52779 RVA: 0x001E6280 File Offset: 0x001E4480
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

		// Token: 0x0600CE2C RID: 52780 RVA: 0x001E62BE File Offset: 0x001E44BE
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

		// Token: 0x0600CE2D RID: 52781 RVA: 0x001E62EF File Offset: 0x001E44EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE2E RID: 52782 RVA: 0x001E62F8 File Offset: 0x001E44F8
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LivenessCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400577F RID: 22399
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005780 RID: 22400
		public const int LivenessCountFieldNumber = 7;

		// Token: 0x04005781 RID: 22401
		private int livenessCount_;
	}
}

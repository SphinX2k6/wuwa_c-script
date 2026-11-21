using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200155B RID: 5467
	[NetMessage(EMessageId.VisionTriggerNotify)]
	public sealed class VisionTriggerNotify : IMessage<VisionTriggerNotify>, IMessage, IEquatable<VisionTriggerNotify>, IDeepCloneable<VisionTriggerNotify>, IBufferMessage
	{
		// Token: 0x0601CF54 RID: 118612 RVA: 0x00432202 File Offset: 0x00430402
		[NullableContext(1)]
		public static VisionTriggerNotify Create()
		{
			return new VisionTriggerNotify();
		}

		// Token: 0x170061FE RID: 25086
		// (get) Token: 0x0601CF55 RID: 118613 RVA: 0x00432209 File Offset: 0x00430409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061FF RID: 25087
		// (get) Token: 0x0601CF56 RID: 118614 RVA: 0x0043220C File Offset: 0x0043040C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionTriggerNotify.Descriptor;
			}
		}

		// Token: 0x0601CF57 RID: 118615 RVA: 0x00432213 File Offset: 0x00430413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerNotify()
		{
		}

		// Token: 0x0601CF58 RID: 118616 RVA: 0x0043221B File Offset: 0x0043041B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerNotify(VisionTriggerNotify other) : this()
		{
			this.numberId_ = other.numberId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CF59 RID: 118617 RVA: 0x00432240 File Offset: 0x00430440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerNotify Clone()
		{
			return new VisionTriggerNotify(this);
		}

		// Token: 0x17006200 RID: 25088
		// (get) Token: 0x0601CF5A RID: 118618 RVA: 0x00432248 File Offset: 0x00430448
		// (set) Token: 0x0601CF5B RID: 118619 RVA: 0x00432250 File Offset: 0x00430450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NumberId
		{
			get
			{
				return this.numberId_;
			}
			set
			{
				this.numberId_ = value;
			}
		}

		// Token: 0x0601CF5C RID: 118620 RVA: 0x00432259 File Offset: 0x00430459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionTriggerNotify);
		}

		// Token: 0x0601CF5D RID: 118621 RVA: 0x00432267 File Offset: 0x00430467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionTriggerNotify other)
		{
			return other != null && (other == this || (this.NumberId == other.NumberId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CF5E RID: 118622 RVA: 0x00432298 File Offset: 0x00430498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NumberId != 0)
			{
				num ^= this.NumberId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CF5F RID: 118623 RVA: 0x004322D7 File Offset: 0x004304D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CF60 RID: 118624 RVA: 0x004322E4 File Offset: 0x004304E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CF61 RID: 118625 RVA: 0x004322ED File Offset: 0x004304ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NumberId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.NumberId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CF62 RID: 118626 RVA: 0x00432320 File Offset: 0x00430520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NumberId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NumberId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CF63 RID: 118627 RVA: 0x0043235E File Offset: 0x0043055E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VisionTriggerNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NumberId != 0)
			{
				this.NumberId = other.NumberId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CF64 RID: 118628 RVA: 0x0043238F File Offset: 0x0043058F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF65 RID: 118629 RVA: 0x00432398 File Offset: 0x00430598
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NumberId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A67A RID: 42618
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A67B RID: 42619
		public const int NumberIdFieldNumber = 6;

		// Token: 0x0400A67C RID: 42620
		private int numberId_;
	}
}

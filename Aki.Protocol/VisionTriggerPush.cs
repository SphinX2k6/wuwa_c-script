using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200155C RID: 5468
	[NetMessage(EMessageId.VisionTriggerPush)]
	public sealed class VisionTriggerPush : IMessage<VisionTriggerPush>, IMessage, IEquatable<VisionTriggerPush>, IDeepCloneable<VisionTriggerPush>, IBufferMessage
	{
		// Token: 0x0601CF66 RID: 118630 RVA: 0x004323DD File Offset: 0x004305DD
		[NullableContext(1)]
		public static VisionTriggerPush Create()
		{
			return new VisionTriggerPush();
		}

		// Token: 0x17006201 RID: 25089
		// (get) Token: 0x0601CF67 RID: 118631 RVA: 0x004323E4 File Offset: 0x004305E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006202 RID: 25090
		// (get) Token: 0x0601CF68 RID: 118632 RVA: 0x004323E7 File Offset: 0x004305E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionTriggerPush.Descriptor;
			}
		}

		// Token: 0x0601CF69 RID: 118633 RVA: 0x004323EE File Offset: 0x004305EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerPush()
		{
		}

		// Token: 0x0601CF6A RID: 118634 RVA: 0x004323F6 File Offset: 0x004305F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerPush(VisionTriggerPush other) : this()
		{
			this.numberId_ = other.numberId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CF6B RID: 118635 RVA: 0x0043241B File Offset: 0x0043061B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerPush Clone()
		{
			return new VisionTriggerPush(this);
		}

		// Token: 0x17006203 RID: 25091
		// (get) Token: 0x0601CF6C RID: 118636 RVA: 0x00432423 File Offset: 0x00430623
		// (set) Token: 0x0601CF6D RID: 118637 RVA: 0x0043242B File Offset: 0x0043062B
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

		// Token: 0x0601CF6E RID: 118638 RVA: 0x00432434 File Offset: 0x00430634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionTriggerPush);
		}

		// Token: 0x0601CF6F RID: 118639 RVA: 0x00432442 File Offset: 0x00430642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionTriggerPush other)
		{
			return other != null && (other == this || (this.NumberId == other.NumberId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CF70 RID: 118640 RVA: 0x00432470 File Offset: 0x00430670
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

		// Token: 0x0601CF71 RID: 118641 RVA: 0x004324AF File Offset: 0x004306AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CF72 RID: 118642 RVA: 0x004324BC File Offset: 0x004306BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CF73 RID: 118643 RVA: 0x004324C5 File Offset: 0x004306C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NumberId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.NumberId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CF74 RID: 118644 RVA: 0x004324F8 File Offset: 0x004306F8
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

		// Token: 0x0601CF75 RID: 118645 RVA: 0x00432536 File Offset: 0x00430736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VisionTriggerPush other)
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

		// Token: 0x0601CF76 RID: 118646 RVA: 0x00432567 File Offset: 0x00430767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF77 RID: 118647 RVA: 0x00432570 File Offset: 0x00430770
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NumberId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A67D RID: 42621
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A67E RID: 42622
		public const int NumberIdFieldNumber = 10;

		// Token: 0x0400A67F RID: 42623
		private int numberId_;
	}
}

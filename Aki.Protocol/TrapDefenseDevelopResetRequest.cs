using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001494 RID: 5268
	[NetMessage(EMessageId.TrapDefenseDevelopResetRequest)]
	public sealed class TrapDefenseDevelopResetRequest : IMessage<TrapDefenseDevelopResetRequest>, IMessage, IEquatable<TrapDefenseDevelopResetRequest>, IDeepCloneable<TrapDefenseDevelopResetRequest>, IBufferMessage
	{
		// Token: 0x0601BF86 RID: 114566 RVA: 0x00410442 File Offset: 0x0040E642
		[NullableContext(1)]
		public static TrapDefenseDevelopResetRequest Create()
		{
			return new TrapDefenseDevelopResetRequest();
		}

		// Token: 0x17005EB5 RID: 24245
		// (get) Token: 0x0601BF87 RID: 114567 RVA: 0x00410449 File Offset: 0x0040E649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EB6 RID: 24246
		// (get) Token: 0x0601BF88 RID: 114568 RVA: 0x0041044C File Offset: 0x0040E64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseDevelopResetRequest.Descriptor;
			}
		}

		// Token: 0x0601BF89 RID: 114569 RVA: 0x00410453 File Offset: 0x0040E653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopResetRequest()
		{
		}

		// Token: 0x0601BF8A RID: 114570 RVA: 0x0041045B File Offset: 0x0040E65B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopResetRequest(TrapDefenseDevelopResetRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF8B RID: 114571 RVA: 0x00410480 File Offset: 0x0040E680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopResetRequest Clone()
		{
			return new TrapDefenseDevelopResetRequest(this);
		}

		// Token: 0x17005EB7 RID: 24247
		// (get) Token: 0x0601BF8C RID: 114572 RVA: 0x00410488 File Offset: 0x0040E688
		// (set) Token: 0x0601BF8D RID: 114573 RVA: 0x00410490 File Offset: 0x0040E690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x0601BF8E RID: 114574 RVA: 0x00410499 File Offset: 0x0040E699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseDevelopResetRequest);
		}

		// Token: 0x0601BF8F RID: 114575 RVA: 0x004104A7 File Offset: 0x0040E6A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseDevelopResetRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF90 RID: 114576 RVA: 0x004104D8 File Offset: 0x0040E6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BF91 RID: 114577 RVA: 0x00410517 File Offset: 0x0040E717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF92 RID: 114578 RVA: 0x00410524 File Offset: 0x0040E724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF93 RID: 114579 RVA: 0x0041052D File Offset: 0x0040E72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF94 RID: 114580 RVA: 0x00410560 File Offset: 0x0040E760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BF95 RID: 114581 RVA: 0x0041059E File Offset: 0x0040E79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseDevelopResetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF96 RID: 114582 RVA: 0x004105CF File Offset: 0x0040E7CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF97 RID: 114583 RVA: 0x004105D8 File Offset: 0x0040E7D8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A221 RID: 41505
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A222 RID: 41506
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x0400A223 RID: 41507
		private int activityId_;
	}
}

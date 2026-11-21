using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200038F RID: 911
	[NetMessage(EMessageId.DangoMonopolyGridRewardRequest)]
	public sealed class DangoMonopolyGridRewardRequest : IMessage<DangoMonopolyGridRewardRequest>, IMessage, IEquatable<DangoMonopolyGridRewardRequest>, IDeepCloneable<DangoMonopolyGridRewardRequest>, IBufferMessage
	{
		// Token: 0x06005A48 RID: 23112 RVA: 0x000DC1D4 File Offset: 0x000DA3D4
		[NullableContext(1)]
		public static DangoMonopolyGridRewardRequest Create()
		{
			return new DangoMonopolyGridRewardRequest();
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06005A49 RID: 23113 RVA: 0x000DC1DB File Offset: 0x000DA3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06005A4A RID: 23114 RVA: 0x000DC1DE File Offset: 0x000DA3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyGridRewardRequest.Descriptor;
			}
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x000DC1E5 File Offset: 0x000DA3E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyGridRewardRequest()
		{
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x000DC1ED File Offset: 0x000DA3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyGridRewardRequest(DangoMonopolyGridRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x000DC212 File Offset: 0x000DA412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyGridRewardRequest Clone()
		{
			return new DangoMonopolyGridRewardRequest(this);
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06005A4E RID: 23118 RVA: 0x000DC21A File Offset: 0x000DA41A
		// (set) Token: 0x06005A4F RID: 23119 RVA: 0x000DC222 File Offset: 0x000DA422
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

		// Token: 0x06005A50 RID: 23120 RVA: 0x000DC22B File Offset: 0x000DA42B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyGridRewardRequest);
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x000DC239 File Offset: 0x000DA439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyGridRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x000DC268 File Offset: 0x000DA468
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

		// Token: 0x06005A53 RID: 23123 RVA: 0x000DC2A7 File Offset: 0x000DA4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x000DC2B4 File Offset: 0x000DA4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A55 RID: 23125 RVA: 0x000DC2BD File Offset: 0x000DA4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x000DC2F0 File Offset: 0x000DA4F0
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

		// Token: 0x06005A57 RID: 23127 RVA: 0x000DC32E File Offset: 0x000DA52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyGridRewardRequest other)
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

		// Token: 0x06005A58 RID: 23128 RVA: 0x000DC35F File Offset: 0x000DA55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x000DC368 File Offset: 0x000DA568
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040035FD RID: 13821
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035FE RID: 13822
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x040035FF RID: 13823
		private int activityId_;
	}
}

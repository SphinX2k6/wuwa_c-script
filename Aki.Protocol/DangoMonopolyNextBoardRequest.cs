using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000391 RID: 913
	[NetMessage(EMessageId.DangoMonopolyNextBoardRequest)]
	public sealed class DangoMonopolyNextBoardRequest : IMessage<DangoMonopolyNextBoardRequest>, IMessage, IEquatable<DangoMonopolyNextBoardRequest>, IDeepCloneable<DangoMonopolyNextBoardRequest>, IBufferMessage
	{
		// Token: 0x06005A6E RID: 23150 RVA: 0x000DC640 File Offset: 0x000DA840
		[NullableContext(1)]
		public static DangoMonopolyNextBoardRequest Create()
		{
			return new DangoMonopolyNextBoardRequest();
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06005A6F RID: 23151 RVA: 0x000DC647 File Offset: 0x000DA847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06005A70 RID: 23152 RVA: 0x000DC64A File Offset: 0x000DA84A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyNextBoardRequest.Descriptor;
			}
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x000DC651 File Offset: 0x000DA851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyNextBoardRequest()
		{
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x000DC659 File Offset: 0x000DA859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyNextBoardRequest(DangoMonopolyNextBoardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x000DC67E File Offset: 0x000DA87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyNextBoardRequest Clone()
		{
			return new DangoMonopolyNextBoardRequest(this);
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06005A74 RID: 23156 RVA: 0x000DC686 File Offset: 0x000DA886
		// (set) Token: 0x06005A75 RID: 23157 RVA: 0x000DC68E File Offset: 0x000DA88E
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

		// Token: 0x06005A76 RID: 23158 RVA: 0x000DC697 File Offset: 0x000DA897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyNextBoardRequest);
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x000DC6A5 File Offset: 0x000DA8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyNextBoardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x000DC6D4 File Offset: 0x000DA8D4
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

		// Token: 0x06005A79 RID: 23161 RVA: 0x000DC713 File Offset: 0x000DA913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x000DC720 File Offset: 0x000DA920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x000DC729 File Offset: 0x000DA929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A7C RID: 23164 RVA: 0x000DC75C File Offset: 0x000DA95C
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

		// Token: 0x06005A7D RID: 23165 RVA: 0x000DC79A File Offset: 0x000DA99A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyNextBoardRequest other)
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

		// Token: 0x06005A7E RID: 23166 RVA: 0x000DC7CB File Offset: 0x000DA9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A7F RID: 23167 RVA: 0x000DC7D4 File Offset: 0x000DA9D4
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003605 RID: 13829
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003606 RID: 13830
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04003607 RID: 13831
		private int activityId_;
	}
}

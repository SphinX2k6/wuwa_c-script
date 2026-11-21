using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006AB RID: 1707
	[NetMessage(EMessageId.GetAdventureRewardRequest)]
	public sealed class GetAdventureRewardRequest : IMessage<GetAdventureRewardRequest>, IMessage, IEquatable<GetAdventureRewardRequest>, IDeepCloneable<GetAdventureRewardRequest>, IBufferMessage
	{
		// Token: 0x06009CC9 RID: 40137 RVA: 0x0017D4F1 File Offset: 0x0017B6F1
		[NullableContext(1)]
		public static GetAdventureRewardRequest Create()
		{
			return new GetAdventureRewardRequest();
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x06009CCA RID: 40138 RVA: 0x0017D4F8 File Offset: 0x0017B6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x06009CCB RID: 40139 RVA: 0x0017D4FB File Offset: 0x0017B6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAdventureRewardRequest.Descriptor;
			}
		}

		// Token: 0x06009CCC RID: 40140 RVA: 0x0017D502 File Offset: 0x0017B702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAdventureRewardRequest()
		{
		}

		// Token: 0x06009CCD RID: 40141 RVA: 0x0017D50A File Offset: 0x0017B70A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAdventureRewardRequest(GetAdventureRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CCE RID: 40142 RVA: 0x0017D52F File Offset: 0x0017B72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAdventureRewardRequest Clone()
		{
			return new GetAdventureRewardRequest(this);
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x06009CCF RID: 40143 RVA: 0x0017D537 File Offset: 0x0017B737
		// (set) Token: 0x06009CD0 RID: 40144 RVA: 0x0017D53F File Offset: 0x0017B73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06009CD1 RID: 40145 RVA: 0x0017D548 File Offset: 0x0017B748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAdventureRewardRequest);
		}

		// Token: 0x06009CD2 RID: 40146 RVA: 0x0017D556 File Offset: 0x0017B756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAdventureRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CD3 RID: 40147 RVA: 0x0017D584 File Offset: 0x0017B784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009CD4 RID: 40148 RVA: 0x0017D5C3 File Offset: 0x0017B7C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009CD5 RID: 40149 RVA: 0x0017D5D0 File Offset: 0x0017B7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CD6 RID: 40150 RVA: 0x0017D5D9 File Offset: 0x0017B7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CD7 RID: 40151 RVA: 0x0017D60C File Offset: 0x0017B80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009CD8 RID: 40152 RVA: 0x0017D64A File Offset: 0x0017B84A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAdventureRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009CD9 RID: 40153 RVA: 0x0017D67B File Offset: 0x0017B87B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CDA RID: 40154 RVA: 0x0017D684 File Offset: 0x0017B884
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A1A RID: 18970
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A1B RID: 18971
		public const int IdFieldNumber = 8;

		// Token: 0x04004A1C RID: 18972
		private int id_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D2 RID: 2002
	[NetMessage(EMessageId.InfluenceRewardRequest)]
	public sealed class InfluenceRewardRequest : IMessage<InfluenceRewardRequest>, IMessage, IEquatable<InfluenceRewardRequest>, IDeepCloneable<InfluenceRewardRequest>, IBufferMessage
	{
		// Token: 0x0600B3F0 RID: 46064 RVA: 0x001AE719 File Offset: 0x001AC919
		[NullableContext(1)]
		public static InfluenceRewardRequest Create()
		{
			return new InfluenceRewardRequest();
		}

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x0600B3F1 RID: 46065 RVA: 0x001AE720 File Offset: 0x001AC920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x0600B3F2 RID: 46066 RVA: 0x001AE723 File Offset: 0x001AC923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfluenceRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600B3F3 RID: 46067 RVA: 0x001AE72A File Offset: 0x001AC92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceRewardRequest()
		{
		}

		// Token: 0x0600B3F4 RID: 46068 RVA: 0x001AE732 File Offset: 0x001AC932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceRewardRequest(InfluenceRewardRequest other) : this()
		{
			this.influenceId_ = other.influenceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3F5 RID: 46069 RVA: 0x001AE757 File Offset: 0x001AC957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceRewardRequest Clone()
		{
			return new InfluenceRewardRequest(this);
		}

		// Token: 0x17002450 RID: 9296
		// (get) Token: 0x0600B3F6 RID: 46070 RVA: 0x001AE75F File Offset: 0x001AC95F
		// (set) Token: 0x0600B3F7 RID: 46071 RVA: 0x001AE767 File Offset: 0x001AC967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InfluenceId
		{
			get
			{
				return this.influenceId_;
			}
			set
			{
				this.influenceId_ = value;
			}
		}

		// Token: 0x0600B3F8 RID: 46072 RVA: 0x001AE770 File Offset: 0x001AC970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfluenceRewardRequest);
		}

		// Token: 0x0600B3F9 RID: 46073 RVA: 0x001AE77E File Offset: 0x001AC97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfluenceRewardRequest other)
		{
			return other != null && (other == this || (this.InfluenceId == other.InfluenceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B3FA RID: 46074 RVA: 0x001AE7AC File Offset: 0x001AC9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InfluenceId != 0)
			{
				num ^= this.InfluenceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B3FB RID: 46075 RVA: 0x001AE7EB File Offset: 0x001AC9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B3FC RID: 46076 RVA: 0x001AE7F8 File Offset: 0x001AC9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3FD RID: 46077 RVA: 0x001AE801 File Offset: 0x001ACA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InfluenceId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.InfluenceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3FE RID: 46078 RVA: 0x001AE834 File Offset: 0x001ACA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InfluenceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InfluenceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B3FF RID: 46079 RVA: 0x001AE872 File Offset: 0x001ACA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfluenceRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InfluenceId != 0)
			{
				this.InfluenceId = other.InfluenceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B400 RID: 46080 RVA: 0x001AE8A3 File Offset: 0x001ACAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B401 RID: 46081 RVA: 0x001AE8AC File Offset: 0x001ACAAC
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
					this.InfluenceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400502D RID: 20525
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400502E RID: 20526
		public const int InfluenceIdFieldNumber = 10;

		// Token: 0x0400502F RID: 20527
		private int influenceId_;
	}
}

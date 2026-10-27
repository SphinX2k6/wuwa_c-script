using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000932 RID: 2354
	[NetMessage(EMessageId.LivenessResponse)]
	public sealed class LivenessResponse : IMessage<LivenessResponse>, IMessage, IEquatable<LivenessResponse>, IDeepCloneable<LivenessResponse>, IBufferMessage
	{
		// Token: 0x0600CF86 RID: 53126 RVA: 0x001E8E12 File Offset: 0x001E7012
		[NullableContext(1)]
		public static LivenessResponse Create()
		{
			return new LivenessResponse();
		}

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x0600CF87 RID: 53127 RVA: 0x001E8E19 File Offset: 0x001E7019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x0600CF88 RID: 53128 RVA: 0x001E8E1C File Offset: 0x001E701C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessResponse.Descriptor;
			}
		}

		// Token: 0x0600CF89 RID: 53129 RVA: 0x001E8E23 File Offset: 0x001E7023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessResponse()
		{
		}

		// Token: 0x0600CF8A RID: 53130 RVA: 0x001E8E2B File Offset: 0x001E702B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessResponse(LivenessResponse other) : this()
		{
			this.livenessInfo_ = ((other.livenessInfo_ != null) ? other.livenessInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF8B RID: 53131 RVA: 0x001E8E60 File Offset: 0x001E7060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessResponse Clone()
		{
			return new LivenessResponse(this);
		}

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x0600CF8C RID: 53132 RVA: 0x001E8E68 File Offset: 0x001E7068
		// (set) Token: 0x0600CF8D RID: 53133 RVA: 0x001E8E70 File Offset: 0x001E7070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessInfo LivenessInfo
		{
			get
			{
				return this.livenessInfo_;
			}
			set
			{
				this.livenessInfo_ = value;
			}
		}

		// Token: 0x0600CF8E RID: 53134 RVA: 0x001E8E79 File Offset: 0x001E7079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessResponse);
		}

		// Token: 0x0600CF8F RID: 53135 RVA: 0x001E8E87 File Offset: 0x001E7087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessResponse other)
		{
			return other != null && (other == this || (object.Equals(this.LivenessInfo, other.LivenessInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF90 RID: 53136 RVA: 0x001E8EBC File Offset: 0x001E70BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.livenessInfo_ != null)
			{
				num ^= this.LivenessInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CF91 RID: 53137 RVA: 0x001E8EF8 File Offset: 0x001E70F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF92 RID: 53138 RVA: 0x001E8F05 File Offset: 0x001E7105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF93 RID: 53139 RVA: 0x001E8F0E File Offset: 0x001E710E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.livenessInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.LivenessInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF94 RID: 53140 RVA: 0x001E8F40 File Offset: 0x001E7140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.livenessInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LivenessInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CF95 RID: 53141 RVA: 0x001E8F80 File Offset: 0x001E7180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.livenessInfo_ != null)
			{
				if (this.livenessInfo_ == null)
				{
					this.LivenessInfo = new LivenessInfo();
				}
				this.LivenessInfo.MergeFrom(other.LivenessInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF96 RID: 53142 RVA: 0x001E8FD4 File Offset: 0x001E71D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF97 RID: 53143 RVA: 0x001E8FE0 File Offset: 0x001E71E0
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.livenessInfo_ == null)
					{
						this.LivenessInfo = new LivenessInfo();
					}
					input.ReadMessage(this.LivenessInfo);
				}
			}
		}

		// Token: 0x0400578C RID: 22412
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400578D RID: 22413
		public const int LivenessInfoFieldNumber = 6;

		// Token: 0x0400578E RID: 22414
		private LivenessInfo livenessInfo_;
	}
}

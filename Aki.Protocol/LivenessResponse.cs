using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000921 RID: 2337
	[NetMessage(EMessageId.LivenessResponse)]
	public sealed class LivenessResponse : IMessage<LivenessResponse>, IMessage, IEquatable<LivenessResponse>, IDeepCloneable<LivenessResponse>, IBufferMessage
	{
		// Token: 0x0600CE6A RID: 52842 RVA: 0x001E6B3E File Offset: 0x001E4D3E
		[NullableContext(1)]
		public static LivenessResponse Create()
		{
			return new LivenessResponse();
		}

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x0600CE6B RID: 52843 RVA: 0x001E6B45 File Offset: 0x001E4D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x0600CE6C RID: 52844 RVA: 0x001E6B48 File Offset: 0x001E4D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessResponse.Descriptor;
			}
		}

		// Token: 0x0600CE6D RID: 52845 RVA: 0x001E6B4F File Offset: 0x001E4D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessResponse()
		{
		}

		// Token: 0x0600CE6E RID: 52846 RVA: 0x001E6B57 File Offset: 0x001E4D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessResponse(LivenessResponse other) : this()
		{
			this.livenessInfo_ = ((other.livenessInfo_ != null) ? other.livenessInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE6F RID: 52847 RVA: 0x001E6B8C File Offset: 0x001E4D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessResponse Clone()
		{
			return new LivenessResponse(this);
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x0600CE70 RID: 52848 RVA: 0x001E6B94 File Offset: 0x001E4D94
		// (set) Token: 0x0600CE71 RID: 52849 RVA: 0x001E6B9C File Offset: 0x001E4D9C
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

		// Token: 0x0600CE72 RID: 52850 RVA: 0x001E6BA5 File Offset: 0x001E4DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessResponse);
		}

		// Token: 0x0600CE73 RID: 52851 RVA: 0x001E6BB3 File Offset: 0x001E4DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessResponse other)
		{
			return other != null && (other == this || (object.Equals(this.LivenessInfo, other.LivenessInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE74 RID: 52852 RVA: 0x001E6BE8 File Offset: 0x001E4DE8
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

		// Token: 0x0600CE75 RID: 52853 RVA: 0x001E6C24 File Offset: 0x001E4E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE76 RID: 52854 RVA: 0x001E6C31 File Offset: 0x001E4E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE77 RID: 52855 RVA: 0x001E6C3A File Offset: 0x001E4E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.livenessInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.LivenessInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE78 RID: 52856 RVA: 0x001E6C6C File Offset: 0x001E4E6C
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

		// Token: 0x0600CE79 RID: 52857 RVA: 0x001E6CAC File Offset: 0x001E4EAC
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

		// Token: 0x0600CE7A RID: 52858 RVA: 0x001E6D00 File Offset: 0x001E4F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE7B RID: 52859 RVA: 0x001E6D0C File Offset: 0x001E4F0C
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
				if (num != 10U)
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

		// Token: 0x04005793 RID: 22419
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005794 RID: 22420
		public const int LivenessInfoFieldNumber = 1;

		// Token: 0x04005795 RID: 22421
		private LivenessInfo livenessInfo_;
	}
}

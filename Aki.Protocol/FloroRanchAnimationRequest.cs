using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A8 RID: 1448
	[NetMessage(EMessageId.FloroRanchAnimationRequest)]
	public sealed class FloroRanchAnimationRequest : IMessage<FloroRanchAnimationRequest>, IMessage, IEquatable<FloroRanchAnimationRequest>, IDeepCloneable<FloroRanchAnimationRequest>, IBufferMessage
	{
		// Token: 0x060085E3 RID: 34275 RVA: 0x00141D93 File Offset: 0x0013FF93
		[NullableContext(1)]
		public static FloroRanchAnimationRequest Create()
		{
			return new FloroRanchAnimationRequest();
		}

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x060085E4 RID: 34276 RVA: 0x00141D9A File Offset: 0x0013FF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x060085E5 RID: 34277 RVA: 0x00141D9D File Offset: 0x0013FF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchAnimationRequest.Descriptor;
			}
		}

		// Token: 0x060085E6 RID: 34278 RVA: 0x00141DA4 File Offset: 0x0013FFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchAnimationRequest()
		{
		}

		// Token: 0x060085E7 RID: 34279 RVA: 0x00141DAC File Offset: 0x0013FFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchAnimationRequest(FloroRanchAnimationRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085E8 RID: 34280 RVA: 0x00141DD1 File Offset: 0x0013FFD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchAnimationRequest Clone()
		{
			return new FloroRanchAnimationRequest(this);
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x060085E9 RID: 34281 RVA: 0x00141DD9 File Offset: 0x0013FFD9
		// (set) Token: 0x060085EA RID: 34282 RVA: 0x00141DE1 File Offset: 0x0013FFE1
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

		// Token: 0x060085EB RID: 34283 RVA: 0x00141DEA File Offset: 0x0013FFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchAnimationRequest);
		}

		// Token: 0x060085EC RID: 34284 RVA: 0x00141DF8 File Offset: 0x0013FFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchAnimationRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060085ED RID: 34285 RVA: 0x00141E28 File Offset: 0x00140028
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

		// Token: 0x060085EE RID: 34286 RVA: 0x00141E67 File Offset: 0x00140067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060085EF RID: 34287 RVA: 0x00141E74 File Offset: 0x00140074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085F0 RID: 34288 RVA: 0x00141E7D File Offset: 0x0014007D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060085F1 RID: 34289 RVA: 0x00141EB0 File Offset: 0x001400B0
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

		// Token: 0x060085F2 RID: 34290 RVA: 0x00141EEE File Offset: 0x001400EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchAnimationRequest other)
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

		// Token: 0x060085F3 RID: 34291 RVA: 0x00141F1F File Offset: 0x0014011F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085F4 RID: 34292 RVA: 0x00141F28 File Offset: 0x00140128
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004221 RID: 16929
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004222 RID: 16930
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04004223 RID: 16931
		private int activityId_;
	}
}

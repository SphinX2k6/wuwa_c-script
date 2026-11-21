using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000757 RID: 1879
	[NetMessage(EMessageId.HonamiStoryBagOperateRequest)]
	public sealed class HonamiStoryBagOperateRequest : IMessage<HonamiStoryBagOperateRequest>, IMessage, IEquatable<HonamiStoryBagOperateRequest>, IDeepCloneable<HonamiStoryBagOperateRequest>, IBufferMessage
	{
		// Token: 0x0600AA6C RID: 43628 RVA: 0x0019A81E File Offset: 0x00198A1E
		[NullableContext(1)]
		public static HonamiStoryBagOperateRequest Create()
		{
			return new HonamiStoryBagOperateRequest();
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x0600AA6D RID: 43629 RVA: 0x0019A825 File Offset: 0x00198A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x0600AA6E RID: 43630 RVA: 0x0019A828 File Offset: 0x00198A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagOperateRequest.Descriptor;
			}
		}

		// Token: 0x0600AA6F RID: 43631 RVA: 0x0019A82F File Offset: 0x00198A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagOperateRequest()
		{
		}

		// Token: 0x0600AA70 RID: 43632 RVA: 0x0019A842 File Offset: 0x00198A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagOperateRequest(HonamiStoryBagOperateRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.honamiStoryBagUpdateContext_ = other.honamiStoryBagUpdateContext_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA71 RID: 43633 RVA: 0x0019A878 File Offset: 0x00198A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagOperateRequest Clone()
		{
			return new HonamiStoryBagOperateRequest(this);
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x0600AA72 RID: 43634 RVA: 0x0019A880 File Offset: 0x00198A80
		// (set) Token: 0x0600AA73 RID: 43635 RVA: 0x0019A888 File Offset: 0x00198A88
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

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x0600AA74 RID: 43636 RVA: 0x0019A891 File Offset: 0x00198A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryBagUpdateContext> HonamiStoryBagUpdateContext
		{
			get
			{
				return this.honamiStoryBagUpdateContext_;
			}
		}

		// Token: 0x0600AA75 RID: 43637 RVA: 0x0019A899 File Offset: 0x00198A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagOperateRequest);
		}

		// Token: 0x0600AA76 RID: 43638 RVA: 0x0019A8A8 File Offset: 0x00198AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagOperateRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.honamiStoryBagUpdateContext_.Equals(other.honamiStoryBagUpdateContext_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA77 RID: 43639 RVA: 0x0019A8F8 File Offset: 0x00198AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.honamiStoryBagUpdateContext_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA78 RID: 43640 RVA: 0x0019A945 File Offset: 0x00198B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA79 RID: 43641 RVA: 0x0019A952 File Offset: 0x00198B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA7A RID: 43642 RVA: 0x0019A95C File Offset: 0x00198B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			this.honamiStoryBagUpdateContext_.WriteTo(ref output, HonamiStoryBagOperateRequest._repeated_honamiStoryBagUpdateContext_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA7B RID: 43643 RVA: 0x0019A9AC File Offset: 0x00198BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.honamiStoryBagUpdateContext_.CalculateSize(HonamiStoryBagOperateRequest._repeated_honamiStoryBagUpdateContext_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA7C RID: 43644 RVA: 0x0019AA00 File Offset: 0x00198C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryBagOperateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.honamiStoryBagUpdateContext_.Add(other.honamiStoryBagUpdateContext_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA7D RID: 43645 RVA: 0x0019AA4D File Offset: 0x00198C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA7E RID: 43646 RVA: 0x0019AA58 File Offset: 0x00198C58
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
				if (num != 24U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.honamiStoryBagUpdateContext_.AddEntriesFrom(ref input, HonamiStoryBagOperateRequest._repeated_honamiStoryBagUpdateContext_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004DE5 RID: 19941
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DE6 RID: 19942
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04004DE7 RID: 19943
		private int activityId_;

		// Token: 0x04004DE8 RID: 19944
		public const int HonamiStoryBagUpdateContextFieldNumber = 7;

		// Token: 0x04004DE9 RID: 19945
		private static readonly FieldCodec<HonamiStoryBagUpdateContext> _repeated_honamiStoryBagUpdateContext_codec = FieldCodec.ForMessage<HonamiStoryBagUpdateContext>(58U, Aki.Protocol.HonamiStoryBagUpdateContext.Parser);

		// Token: 0x04004DEA RID: 19946
		private readonly RepeatedField<HonamiStoryBagUpdateContext> honamiStoryBagUpdateContext_ = new RepeatedField<HonamiStoryBagUpdateContext>();
	}
}

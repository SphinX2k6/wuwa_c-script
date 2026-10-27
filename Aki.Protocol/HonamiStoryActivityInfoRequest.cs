using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200075F RID: 1887
	[NetMessage(EMessageId.HonamiStoryActivityInfoRequest)]
	public sealed class HonamiStoryActivityInfoRequest : IMessage<HonamiStoryActivityInfoRequest>, IMessage, IEquatable<HonamiStoryActivityInfoRequest>, IDeepCloneable<HonamiStoryActivityInfoRequest>, IBufferMessage
	{
		// Token: 0x0600AAD7 RID: 43735 RVA: 0x0019B582 File Offset: 0x00199782
		[NullableContext(1)]
		public static HonamiStoryActivityInfoRequest Create()
		{
			return new HonamiStoryActivityInfoRequest();
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x0600AAD8 RID: 43736 RVA: 0x0019B589 File Offset: 0x00199789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x0600AAD9 RID: 43737 RVA: 0x0019B58C File Offset: 0x0019978C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryActivityInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600AADA RID: 43738 RVA: 0x0019B593 File Offset: 0x00199793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfoRequest()
		{
		}

		// Token: 0x0600AADB RID: 43739 RVA: 0x0019B59B File Offset: 0x0019979B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfoRequest(HonamiStoryActivityInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AADC RID: 43740 RVA: 0x0019B5C0 File Offset: 0x001997C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfoRequest Clone()
		{
			return new HonamiStoryActivityInfoRequest(this);
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x0600AADD RID: 43741 RVA: 0x0019B5C8 File Offset: 0x001997C8
		// (set) Token: 0x0600AADE RID: 43742 RVA: 0x0019B5D0 File Offset: 0x001997D0
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

		// Token: 0x0600AADF RID: 43743 RVA: 0x0019B5D9 File Offset: 0x001997D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryActivityInfoRequest);
		}

		// Token: 0x0600AAE0 RID: 43744 RVA: 0x0019B5E7 File Offset: 0x001997E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryActivityInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AAE1 RID: 43745 RVA: 0x0019B618 File Offset: 0x00199818
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

		// Token: 0x0600AAE2 RID: 43746 RVA: 0x0019B657 File Offset: 0x00199857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AAE3 RID: 43747 RVA: 0x0019B664 File Offset: 0x00199864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AAE4 RID: 43748 RVA: 0x0019B66D File Offset: 0x0019986D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AAE5 RID: 43749 RVA: 0x0019B6A0 File Offset: 0x001998A0
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

		// Token: 0x0600AAE6 RID: 43750 RVA: 0x0019B6DE File Offset: 0x001998DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryActivityInfoRequest other)
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

		// Token: 0x0600AAE7 RID: 43751 RVA: 0x0019B70F File Offset: 0x0019990F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AAE8 RID: 43752 RVA: 0x0019B718 File Offset: 0x00199918
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004DB1 RID: 19889
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DB2 RID: 19890
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04004DB3 RID: 19891
		private int activityId_;
	}
}

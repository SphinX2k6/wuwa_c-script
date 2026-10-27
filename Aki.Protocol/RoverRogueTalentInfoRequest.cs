using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200112B RID: 4395
	[NetMessage(EMessageId.RoverRogueTalentInfoRequest)]
	public sealed class RoverRogueTalentInfoRequest : IMessage<RoverRogueTalentInfoRequest>, IMessage, IEquatable<RoverRogueTalentInfoRequest>, IDeepCloneable<RoverRogueTalentInfoRequest>, IBufferMessage
	{
		// Token: 0x06017728 RID: 96040 RVA: 0x00368153 File Offset: 0x00366353
		[NullableContext(1)]
		public static RoverRogueTalentInfoRequest Create()
		{
			return new RoverRogueTalentInfoRequest();
		}

		// Token: 0x17004EB7 RID: 20151
		// (get) Token: 0x06017729 RID: 96041 RVA: 0x0036815A File Offset: 0x0036635A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EB8 RID: 20152
		// (get) Token: 0x0601772A RID: 96042 RVA: 0x0036815D File Offset: 0x0036635D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTalentInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601772B RID: 96043 RVA: 0x00368164 File Offset: 0x00366364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentInfoRequest()
		{
		}

		// Token: 0x0601772C RID: 96044 RVA: 0x0036816C File Offset: 0x0036636C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentInfoRequest(RoverRogueTalentInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601772D RID: 96045 RVA: 0x00368191 File Offset: 0x00366391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentInfoRequest Clone()
		{
			return new RoverRogueTalentInfoRequest(this);
		}

		// Token: 0x17004EB9 RID: 20153
		// (get) Token: 0x0601772E RID: 96046 RVA: 0x00368199 File Offset: 0x00366399
		// (set) Token: 0x0601772F RID: 96047 RVA: 0x003681A1 File Offset: 0x003663A1
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

		// Token: 0x06017730 RID: 96048 RVA: 0x003681AA File Offset: 0x003663AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTalentInfoRequest);
		}

		// Token: 0x06017731 RID: 96049 RVA: 0x003681B8 File Offset: 0x003663B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTalentInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017732 RID: 96050 RVA: 0x003681E8 File Offset: 0x003663E8
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

		// Token: 0x06017733 RID: 96051 RVA: 0x00368227 File Offset: 0x00366427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017734 RID: 96052 RVA: 0x00368234 File Offset: 0x00366434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017735 RID: 96053 RVA: 0x0036823D File Offset: 0x0036643D
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

		// Token: 0x06017736 RID: 96054 RVA: 0x00368270 File Offset: 0x00366470
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

		// Token: 0x06017737 RID: 96055 RVA: 0x003682AE File Offset: 0x003664AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueTalentInfoRequest other)
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

		// Token: 0x06017738 RID: 96056 RVA: 0x003682DF File Offset: 0x003664DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017739 RID: 96057 RVA: 0x003682E8 File Offset: 0x003664E8
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

		// Token: 0x04008B78 RID: 35704
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B79 RID: 35705
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x04008B7A RID: 35706
		private int activityId_;
	}
}

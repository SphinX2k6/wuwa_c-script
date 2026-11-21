using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001151 RID: 4433
	[NetMessage(EMessageId.RoverRogueRefreshGainRequest)]
	public sealed class RoverRogueRefreshGainRequest : IMessage<RoverRogueRefreshGainRequest>, IMessage, IEquatable<RoverRogueRefreshGainRequest>, IDeepCloneable<RoverRogueRefreshGainRequest>, IBufferMessage
	{
		// Token: 0x06017AF1 RID: 97009 RVA: 0x00372559 File Offset: 0x00370759
		[NullableContext(1)]
		public static RoverRogueRefreshGainRequest Create()
		{
			return new RoverRogueRefreshGainRequest();
		}

		// Token: 0x17004FAB RID: 20395
		// (get) Token: 0x06017AF2 RID: 97010 RVA: 0x00372560 File Offset: 0x00370760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FAC RID: 20396
		// (get) Token: 0x06017AF3 RID: 97011 RVA: 0x00372563 File Offset: 0x00370763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueRefreshGainRequest.Descriptor;
			}
		}

		// Token: 0x06017AF4 RID: 97012 RVA: 0x0037256A File Offset: 0x0037076A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRefreshGainRequest()
		{
		}

		// Token: 0x06017AF5 RID: 97013 RVA: 0x00372572 File Offset: 0x00370772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRefreshGainRequest(RoverRogueRefreshGainRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017AF6 RID: 97014 RVA: 0x00372597 File Offset: 0x00370797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRefreshGainRequest Clone()
		{
			return new RoverRogueRefreshGainRequest(this);
		}

		// Token: 0x17004FAD RID: 20397
		// (get) Token: 0x06017AF7 RID: 97015 RVA: 0x0037259F File Offset: 0x0037079F
		// (set) Token: 0x06017AF8 RID: 97016 RVA: 0x003725A7 File Offset: 0x003707A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BindId
		{
			get
			{
				return this.bindId_;
			}
			set
			{
				this.bindId_ = value;
			}
		}

		// Token: 0x06017AF9 RID: 97017 RVA: 0x003725B0 File Offset: 0x003707B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueRefreshGainRequest);
		}

		// Token: 0x06017AFA RID: 97018 RVA: 0x003725BE File Offset: 0x003707BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueRefreshGainRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017AFB RID: 97019 RVA: 0x003725EC File Offset: 0x003707EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BindId != 0)
			{
				num ^= this.BindId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017AFC RID: 97020 RVA: 0x0037262B File Offset: 0x0037082B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017AFD RID: 97021 RVA: 0x00372638 File Offset: 0x00370838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017AFE RID: 97022 RVA: 0x00372641 File Offset: 0x00370841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BindId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.BindId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017AFF RID: 97023 RVA: 0x00372674 File Offset: 0x00370874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BindId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BindId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017B00 RID: 97024 RVA: 0x003726B2 File Offset: 0x003708B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueRefreshGainRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BindId != 0)
			{
				this.BindId = other.BindId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017B01 RID: 97025 RVA: 0x003726E3 File Offset: 0x003708E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B02 RID: 97026 RVA: 0x003726EC File Offset: 0x003708EC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BindId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008D4D RID: 36173
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D4E RID: 36174
		public const int BindIdFieldNumber = 13;

		// Token: 0x04008D4F RID: 36175
		private int bindId_;
	}
}

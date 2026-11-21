using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001131 RID: 4401
	[NetMessage(EMessageId.RoverRogueChooseDataResultRequest)]
	public sealed class RoverRogueChooseDataResultRequest : IMessage<RoverRogueChooseDataResultRequest>, IMessage, IEquatable<RoverRogueChooseDataResultRequest>, IDeepCloneable<RoverRogueChooseDataResultRequest>, IBufferMessage
	{
		// Token: 0x06017834 RID: 96308 RVA: 0x0036BC50 File Offset: 0x00369E50
		[NullableContext(1)]
		public static RoverRogueChooseDataResultRequest Create()
		{
			return new RoverRogueChooseDataResultRequest();
		}

		// Token: 0x17004F07 RID: 20231
		// (get) Token: 0x06017835 RID: 96309 RVA: 0x0036BC57 File Offset: 0x00369E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F08 RID: 20232
		// (get) Token: 0x06017836 RID: 96310 RVA: 0x0036BC5A File Offset: 0x00369E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueChooseDataResultRequest.Descriptor;
			}
		}

		// Token: 0x06017837 RID: 96311 RVA: 0x0036BC61 File Offset: 0x00369E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataResultRequest()
		{
		}

		// Token: 0x06017838 RID: 96312 RVA: 0x0036BC69 File Offset: 0x00369E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataResultRequest(RoverRogueChooseDataResultRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017839 RID: 96313 RVA: 0x0036BC9A File Offset: 0x00369E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataResultRequest Clone()
		{
			return new RoverRogueChooseDataResultRequest(this);
		}

		// Token: 0x17004F09 RID: 20233
		// (get) Token: 0x0601783A RID: 96314 RVA: 0x0036BCA2 File Offset: 0x00369EA2
		// (set) Token: 0x0601783B RID: 96315 RVA: 0x0036BCAA File Offset: 0x00369EAA
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

		// Token: 0x17004F0A RID: 20234
		// (get) Token: 0x0601783C RID: 96316 RVA: 0x0036BCB3 File Offset: 0x00369EB3
		// (set) Token: 0x0601783D RID: 96317 RVA: 0x0036BCBB File Offset: 0x00369EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x0601783E RID: 96318 RVA: 0x0036BCC4 File Offset: 0x00369EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueChooseDataResultRequest);
		}

		// Token: 0x0601783F RID: 96319 RVA: 0x0036BCD2 File Offset: 0x00369ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueChooseDataResultRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017840 RID: 96320 RVA: 0x0036BD10 File Offset: 0x00369F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BindId != 0)
			{
				num ^= this.BindId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017841 RID: 96321 RVA: 0x0036BD68 File Offset: 0x00369F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017842 RID: 96322 RVA: 0x0036BD75 File Offset: 0x00369F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017843 RID: 96323 RVA: 0x0036BD80 File Offset: 0x00369F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BindId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BindId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017844 RID: 96324 RVA: 0x0036BDDC File Offset: 0x00369FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BindId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BindId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017845 RID: 96325 RVA: 0x0036BE34 File Offset: 0x0036A034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueChooseDataResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BindId != 0)
			{
				this.BindId = other.BindId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017846 RID: 96326 RVA: 0x0036BE84 File Offset: 0x0036A084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017847 RID: 96327 RVA: 0x0036BE90 File Offset: 0x0036A090
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
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.BindId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008C57 RID: 35927
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C58 RID: 35928
		public const int BindIdFieldNumber = 2;

		// Token: 0x04008C59 RID: 35929
		private int bindId_;

		// Token: 0x04008C5A RID: 35930
		public const int IncIdFieldNumber = 7;

		// Token: 0x04008C5B RID: 35931
		private int incId_;
	}
}

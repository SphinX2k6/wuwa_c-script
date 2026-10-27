using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F7 RID: 4343
	[NetMessage(EMessageId.RoverRogueChooseDataResultRequest)]
	public sealed class RoverRogueChooseDataResultRequest : IMessage<RoverRogueChooseDataResultRequest>, IMessage, IEquatable<RoverRogueChooseDataResultRequest>, IDeepCloneable<RoverRogueChooseDataResultRequest>, IBufferMessage
	{
		// Token: 0x06017293 RID: 94867 RVA: 0x0035C8F8 File Offset: 0x0035AAF8
		[NullableContext(1)]
		public static RoverRogueChooseDataResultRequest Create()
		{
			return new RoverRogueChooseDataResultRequest();
		}

		// Token: 0x17004D9B RID: 19867
		// (get) Token: 0x06017294 RID: 94868 RVA: 0x0035C8FF File Offset: 0x0035AAFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D9C RID: 19868
		// (get) Token: 0x06017295 RID: 94869 RVA: 0x0035C902 File Offset: 0x0035AB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueChooseDataResultRequest.Descriptor;
			}
		}

		// Token: 0x06017296 RID: 94870 RVA: 0x0035C909 File Offset: 0x0035AB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataResultRequest()
		{
		}

		// Token: 0x06017297 RID: 94871 RVA: 0x0035C911 File Offset: 0x0035AB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataResultRequest(RoverRogueChooseDataResultRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017298 RID: 94872 RVA: 0x0035C942 File Offset: 0x0035AB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataResultRequest Clone()
		{
			return new RoverRogueChooseDataResultRequest(this);
		}

		// Token: 0x17004D9D RID: 19869
		// (get) Token: 0x06017299 RID: 94873 RVA: 0x0035C94A File Offset: 0x0035AB4A
		// (set) Token: 0x0601729A RID: 94874 RVA: 0x0035C952 File Offset: 0x0035AB52
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

		// Token: 0x17004D9E RID: 19870
		// (get) Token: 0x0601729B RID: 94875 RVA: 0x0035C95B File Offset: 0x0035AB5B
		// (set) Token: 0x0601729C RID: 94876 RVA: 0x0035C963 File Offset: 0x0035AB63
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

		// Token: 0x0601729D RID: 94877 RVA: 0x0035C96C File Offset: 0x0035AB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueChooseDataResultRequest);
		}

		// Token: 0x0601729E RID: 94878 RVA: 0x0035C97A File Offset: 0x0035AB7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueChooseDataResultRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601729F RID: 94879 RVA: 0x0035C9B8 File Offset: 0x0035ABB8
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

		// Token: 0x060172A0 RID: 94880 RVA: 0x0035CA10 File Offset: 0x0035AC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060172A1 RID: 94881 RVA: 0x0035CA1D File Offset: 0x0035AC1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060172A2 RID: 94882 RVA: 0x0035CA28 File Offset: 0x0035AC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BindId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.BindId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060172A3 RID: 94883 RVA: 0x0035CA84 File Offset: 0x0035AC84
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

		// Token: 0x060172A4 RID: 94884 RVA: 0x0035CADC File Offset: 0x0035ACDC
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

		// Token: 0x060172A5 RID: 94885 RVA: 0x0035CB2C File Offset: 0x0035AD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060172A6 RID: 94886 RVA: 0x0035CB38 File Offset: 0x0035AD38
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
				if (num != 96U)
				{
					if (num != 104U)
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

		// Token: 0x040089C4 RID: 35268
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089C5 RID: 35269
		public const int BindIdFieldNumber = 12;

		// Token: 0x040089C6 RID: 35270
		private int bindId_;

		// Token: 0x040089C7 RID: 35271
		public const int IncIdFieldNumber = 13;

		// Token: 0x040089C8 RID: 35272
		private int incId_;
	}
}

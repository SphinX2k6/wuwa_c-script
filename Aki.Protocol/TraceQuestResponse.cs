using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200144A RID: 5194
	[NetMessage(EMessageId.TraceQuestResponse)]
	public sealed class TraceQuestResponse : IMessage<TraceQuestResponse>, IMessage, IEquatable<TraceQuestResponse>, IDeepCloneable<TraceQuestResponse>, IBufferMessage
	{
		// Token: 0x0601B976 RID: 113014 RVA: 0x00402613 File Offset: 0x00400813
		[NullableContext(1)]
		public static TraceQuestResponse Create()
		{
			return new TraceQuestResponse();
		}

		// Token: 0x17005D65 RID: 23909
		// (get) Token: 0x0601B977 RID: 113015 RVA: 0x0040261A File Offset: 0x0040081A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D66 RID: 23910
		// (get) Token: 0x0601B978 RID: 113016 RVA: 0x0040261D File Offset: 0x0040081D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceQuestResponse.Descriptor;
			}
		}

		// Token: 0x0601B979 RID: 113017 RVA: 0x00402624 File Offset: 0x00400824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestResponse()
		{
		}

		// Token: 0x0601B97A RID: 113018 RVA: 0x0040262C File Offset: 0x0040082C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestResponse(TraceQuestResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B97B RID: 113019 RVA: 0x00402651 File Offset: 0x00400851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestResponse Clone()
		{
			return new TraceQuestResponse(this);
		}

		// Token: 0x17005D67 RID: 23911
		// (get) Token: 0x0601B97C RID: 113020 RVA: 0x00402659 File Offset: 0x00400859
		// (set) Token: 0x0601B97D RID: 113021 RVA: 0x00402661 File Offset: 0x00400861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0601B97E RID: 113022 RVA: 0x0040266A File Offset: 0x0040086A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceQuestResponse);
		}

		// Token: 0x0601B97F RID: 113023 RVA: 0x00402678 File Offset: 0x00400878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceQuestResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B980 RID: 113024 RVA: 0x004026A8 File Offset: 0x004008A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B981 RID: 113025 RVA: 0x004026ED File Offset: 0x004008ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B982 RID: 113026 RVA: 0x004026FA File Offset: 0x004008FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B983 RID: 113027 RVA: 0x00402703 File Offset: 0x00400903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B984 RID: 113028 RVA: 0x00402738 File Offset: 0x00400938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B985 RID: 113029 RVA: 0x00402776 File Offset: 0x00400976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceQuestResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B986 RID: 113030 RVA: 0x004027A7 File Offset: 0x004009A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B987 RID: 113031 RVA: 0x004027B0 File Offset: 0x004009B0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A067 RID: 41063
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A068 RID: 41064
		public const int ErrorIdFieldNumber = 14;

		// Token: 0x0400A069 RID: 41065
		private ErrorCode errorId_;
	}
}

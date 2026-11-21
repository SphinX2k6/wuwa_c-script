using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E97 RID: 3735
	[NetMessage(EMessageId.RecallExploreSkillRouletteSetResponse)]
	public sealed class RecallExploreSkillRouletteSetResponse : IMessage<RecallExploreSkillRouletteSetResponse>, IMessage, IEquatable<RecallExploreSkillRouletteSetResponse>, IDeepCloneable<RecallExploreSkillRouletteSetResponse>, IBufferMessage
	{
		// Token: 0x06014133 RID: 82227 RVA: 0x002EC861 File Offset: 0x002EAA61
		[NullableContext(1)]
		public static RecallExploreSkillRouletteSetResponse Create()
		{
			return new RecallExploreSkillRouletteSetResponse();
		}

		// Token: 0x170042CA RID: 17098
		// (get) Token: 0x06014134 RID: 82228 RVA: 0x002EC868 File Offset: 0x002EAA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042CB RID: 17099
		// (get) Token: 0x06014135 RID: 82229 RVA: 0x002EC86B File Offset: 0x002EAA6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallExploreSkillRouletteSetResponse.Descriptor;
			}
		}

		// Token: 0x06014136 RID: 82230 RVA: 0x002EC872 File Offset: 0x002EAA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteSetResponse()
		{
		}

		// Token: 0x06014137 RID: 82231 RVA: 0x002EC87A File Offset: 0x002EAA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteSetResponse(RecallExploreSkillRouletteSetResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014138 RID: 82232 RVA: 0x002EC89F File Offset: 0x002EAA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteSetResponse Clone()
		{
			return new RecallExploreSkillRouletteSetResponse(this);
		}

		// Token: 0x170042CC RID: 17100
		// (get) Token: 0x06014139 RID: 82233 RVA: 0x002EC8A7 File Offset: 0x002EAAA7
		// (set) Token: 0x0601413A RID: 82234 RVA: 0x002EC8AF File Offset: 0x002EAAAF
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

		// Token: 0x0601413B RID: 82235 RVA: 0x002EC8B8 File Offset: 0x002EAAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallExploreSkillRouletteSetResponse);
		}

		// Token: 0x0601413C RID: 82236 RVA: 0x002EC8C6 File Offset: 0x002EAAC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallExploreSkillRouletteSetResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601413D RID: 82237 RVA: 0x002EC8F4 File Offset: 0x002EAAF4
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

		// Token: 0x0601413E RID: 82238 RVA: 0x002EC939 File Offset: 0x002EAB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601413F RID: 82239 RVA: 0x002EC946 File Offset: 0x002EAB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014140 RID: 82240 RVA: 0x002EC94F File Offset: 0x002EAB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014141 RID: 82241 RVA: 0x002EC984 File Offset: 0x002EAB84
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

		// Token: 0x06014142 RID: 82242 RVA: 0x002EC9C2 File Offset: 0x002EABC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallExploreSkillRouletteSetResponse other)
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

		// Token: 0x06014143 RID: 82243 RVA: 0x002EC9F3 File Offset: 0x002EABF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014144 RID: 82244 RVA: 0x002EC9FC File Offset: 0x002EABFC
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007ACE RID: 31438
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007ACF RID: 31439
		public const int ErrorIdFieldNumber = 5;

		// Token: 0x04007AD0 RID: 31440
		private ErrorCode errorId_;
	}
}

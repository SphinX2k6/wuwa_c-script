using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FCB RID: 4043
	[NetMessage(EMessageId.RoguelikeWriteCatLevelPlayRewardResponse)]
	public sealed class RoguelikeWriteCatLevelPlayRewardResponse : IMessage<RoguelikeWriteCatLevelPlayRewardResponse>, IMessage, IEquatable<RoguelikeWriteCatLevelPlayRewardResponse>, IDeepCloneable<RoguelikeWriteCatLevelPlayRewardResponse>, IBufferMessage
	{
		// Token: 0x060159CE RID: 88526 RVA: 0x0032315C File Offset: 0x0032135C
		[NullableContext(1)]
		public static RoguelikeWriteCatLevelPlayRewardResponse Create()
		{
			return new RoguelikeWriteCatLevelPlayRewardResponse();
		}

		// Token: 0x17004813 RID: 18451
		// (get) Token: 0x060159CF RID: 88527 RVA: 0x00323163 File Offset: 0x00321363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004814 RID: 18452
		// (get) Token: 0x060159D0 RID: 88528 RVA: 0x00323166 File Offset: 0x00321366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeWriteCatLevelPlayRewardResponse.Descriptor;
			}
		}

		// Token: 0x060159D1 RID: 88529 RVA: 0x0032316D File Offset: 0x0032136D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatLevelPlayRewardResponse()
		{
		}

		// Token: 0x060159D2 RID: 88530 RVA: 0x00323175 File Offset: 0x00321375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatLevelPlayRewardResponse(RoguelikeWriteCatLevelPlayRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060159D3 RID: 88531 RVA: 0x0032319A File Offset: 0x0032139A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatLevelPlayRewardResponse Clone()
		{
			return new RoguelikeWriteCatLevelPlayRewardResponse(this);
		}

		// Token: 0x17004815 RID: 18453
		// (get) Token: 0x060159D4 RID: 88532 RVA: 0x003231A2 File Offset: 0x003213A2
		// (set) Token: 0x060159D5 RID: 88533 RVA: 0x003231AA File Offset: 0x003213AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060159D6 RID: 88534 RVA: 0x003231B3 File Offset: 0x003213B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeWriteCatLevelPlayRewardResponse);
		}

		// Token: 0x060159D7 RID: 88535 RVA: 0x003231C1 File Offset: 0x003213C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeWriteCatLevelPlayRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060159D8 RID: 88536 RVA: 0x003231F0 File Offset: 0x003213F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060159D9 RID: 88537 RVA: 0x00323235 File Offset: 0x00321435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060159DA RID: 88538 RVA: 0x00323242 File Offset: 0x00321442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060159DB RID: 88539 RVA: 0x0032324B File Offset: 0x0032144B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060159DC RID: 88540 RVA: 0x00323280 File Offset: 0x00321480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060159DD RID: 88541 RVA: 0x003232BE File Offset: 0x003214BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeWriteCatLevelPlayRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060159DE RID: 88542 RVA: 0x003232EF File Offset: 0x003214EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060159DF RID: 88543 RVA: 0x003232F8 File Offset: 0x003214F8
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040081CF RID: 33231
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081D0 RID: 33232
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040081D1 RID: 33233
		private ErrorCode errorCode_;
	}
}

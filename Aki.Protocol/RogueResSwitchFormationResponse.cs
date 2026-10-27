using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001009 RID: 4105
	[NetMessage(EMessageId.RogueResSwitchFormationResponse)]
	public sealed class RogueResSwitchFormationResponse : IMessage<RogueResSwitchFormationResponse>, IMessage, IEquatable<RogueResSwitchFormationResponse>, IDeepCloneable<RogueResSwitchFormationResponse>, IBufferMessage
	{
		// Token: 0x06015F43 RID: 89923 RVA: 0x003314C1 File Offset: 0x0032F6C1
		[NullableContext(1)]
		public static RogueResSwitchFormationResponse Create()
		{
			return new RogueResSwitchFormationResponse();
		}

		// Token: 0x17004964 RID: 18788
		// (get) Token: 0x06015F44 RID: 89924 RVA: 0x003314C8 File Offset: 0x0032F6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004965 RID: 18789
		// (get) Token: 0x06015F45 RID: 89925 RVA: 0x003314CB File Offset: 0x0032F6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResSwitchFormationResponse.Descriptor;
			}
		}

		// Token: 0x06015F46 RID: 89926 RVA: 0x003314D2 File Offset: 0x0032F6D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSwitchFormationResponse()
		{
		}

		// Token: 0x06015F47 RID: 89927 RVA: 0x003314DA File Offset: 0x0032F6DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSwitchFormationResponse(RogueResSwitchFormationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015F48 RID: 89928 RVA: 0x003314FF File Offset: 0x0032F6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSwitchFormationResponse Clone()
		{
			return new RogueResSwitchFormationResponse(this);
		}

		// Token: 0x17004966 RID: 18790
		// (get) Token: 0x06015F49 RID: 89929 RVA: 0x00331507 File Offset: 0x0032F707
		// (set) Token: 0x06015F4A RID: 89930 RVA: 0x0033150F File Offset: 0x0032F70F
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

		// Token: 0x06015F4B RID: 89931 RVA: 0x00331518 File Offset: 0x0032F718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResSwitchFormationResponse);
		}

		// Token: 0x06015F4C RID: 89932 RVA: 0x00331526 File Offset: 0x0032F726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResSwitchFormationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F4D RID: 89933 RVA: 0x00331554 File Offset: 0x0032F754
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

		// Token: 0x06015F4E RID: 89934 RVA: 0x00331599 File Offset: 0x0032F799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F4F RID: 89935 RVA: 0x003315A6 File Offset: 0x0032F7A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F50 RID: 89936 RVA: 0x003315AF File Offset: 0x0032F7AF
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

		// Token: 0x06015F51 RID: 89937 RVA: 0x003315E4 File Offset: 0x0032F7E4
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

		// Token: 0x06015F52 RID: 89938 RVA: 0x00331622 File Offset: 0x0032F822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResSwitchFormationResponse other)
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

		// Token: 0x06015F53 RID: 89939 RVA: 0x00331653 File Offset: 0x0032F853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F54 RID: 89940 RVA: 0x0033165C File Offset: 0x0032F85C
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

		// Token: 0x040083C8 RID: 33736
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083C9 RID: 33737
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040083CA RID: 33738
		private ErrorCode errorCode_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B10 RID: 2832
	[NetMessage(EMessageId.NewbieFetchScoreRewardResponse)]
	public sealed class NewbieFetchScoreRewardResponse : IMessage<NewbieFetchScoreRewardResponse>, IMessage, IEquatable<NewbieFetchScoreRewardResponse>, IDeepCloneable<NewbieFetchScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F5FA RID: 62970 RVA: 0x0023E0C8 File Offset: 0x0023C2C8
		[NullableContext(1)]
		public static NewbieFetchScoreRewardResponse Create()
		{
			return new NewbieFetchScoreRewardResponse();
		}

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x0600F5FB RID: 62971 RVA: 0x0023E0CF File Offset: 0x0023C2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x0600F5FC RID: 62972 RVA: 0x0023E0D2 File Offset: 0x0023C2D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieFetchScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F5FD RID: 62973 RVA: 0x0023E0D9 File Offset: 0x0023C2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieFetchScoreRewardResponse()
		{
		}

		// Token: 0x0600F5FE RID: 62974 RVA: 0x0023E0E1 File Offset: 0x0023C2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieFetchScoreRewardResponse(NewbieFetchScoreRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F5FF RID: 62975 RVA: 0x0023E106 File Offset: 0x0023C306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieFetchScoreRewardResponse Clone()
		{
			return new NewbieFetchScoreRewardResponse(this);
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0600F600 RID: 62976 RVA: 0x0023E10E File Offset: 0x0023C30E
		// (set) Token: 0x0600F601 RID: 62977 RVA: 0x0023E116 File Offset: 0x0023C316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0600F602 RID: 62978 RVA: 0x0023E11F File Offset: 0x0023C31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieFetchScoreRewardResponse);
		}

		// Token: 0x0600F603 RID: 62979 RVA: 0x0023E12D File Offset: 0x0023C32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieFetchScoreRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F604 RID: 62980 RVA: 0x0023E15C File Offset: 0x0023C35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F605 RID: 62981 RVA: 0x0023E1A1 File Offset: 0x0023C3A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F606 RID: 62982 RVA: 0x0023E1AE File Offset: 0x0023C3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F607 RID: 62983 RVA: 0x0023E1B7 File Offset: 0x0023C3B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F608 RID: 62984 RVA: 0x0023E1EC File Offset: 0x0023C3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F609 RID: 62985 RVA: 0x0023E22A File Offset: 0x0023C42A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieFetchScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F60A RID: 62986 RVA: 0x0023E25B File Offset: 0x0023C45B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F60B RID: 62987 RVA: 0x0023E264 File Offset: 0x0023C464
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040062D5 RID: 25301
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062D6 RID: 25302
		public const int CodeFieldNumber = 6;

		// Token: 0x040062D7 RID: 25303
		private ErrorCode code_;
	}
}

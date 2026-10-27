using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200132F RID: 4911
	[NetMessage(EMessageId.TeamParkourRewardResponse)]
	public sealed class TeamParkourRewardResponse : IMessage<TeamParkourRewardResponse>, IMessage, IEquatable<TeamParkourRewardResponse>, IDeepCloneable<TeamParkourRewardResponse>, IBufferMessage
	{
		// Token: 0x0601A181 RID: 106881 RVA: 0x003CA574 File Offset: 0x003C8774
		[NullableContext(1)]
		public static TeamParkourRewardResponse Create()
		{
			return new TeamParkourRewardResponse();
		}

		// Token: 0x17005802 RID: 22530
		// (get) Token: 0x0601A182 RID: 106882 RVA: 0x003CA57B File Offset: 0x003C877B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005803 RID: 22531
		// (get) Token: 0x0601A183 RID: 106883 RVA: 0x003CA57E File Offset: 0x003C877E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamParkourRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601A184 RID: 106884 RVA: 0x003CA585 File Offset: 0x003C8785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourRewardResponse()
		{
		}

		// Token: 0x0601A185 RID: 106885 RVA: 0x003CA58D File Offset: 0x003C878D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourRewardResponse(TeamParkourRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A186 RID: 106886 RVA: 0x003CA5B2 File Offset: 0x003C87B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourRewardResponse Clone()
		{
			return new TeamParkourRewardResponse(this);
		}

		// Token: 0x17005804 RID: 22532
		// (get) Token: 0x0601A187 RID: 106887 RVA: 0x003CA5BA File Offset: 0x003C87BA
		// (set) Token: 0x0601A188 RID: 106888 RVA: 0x003CA5C2 File Offset: 0x003C87C2
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

		// Token: 0x0601A189 RID: 106889 RVA: 0x003CA5CB File Offset: 0x003C87CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamParkourRewardResponse);
		}

		// Token: 0x0601A18A RID: 106890 RVA: 0x003CA5D9 File Offset: 0x003C87D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamParkourRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A18B RID: 106891 RVA: 0x003CA608 File Offset: 0x003C8808
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

		// Token: 0x0601A18C RID: 106892 RVA: 0x003CA64D File Offset: 0x003C884D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A18D RID: 106893 RVA: 0x003CA65A File Offset: 0x003C885A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A18E RID: 106894 RVA: 0x003CA663 File Offset: 0x003C8863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A18F RID: 106895 RVA: 0x003CA698 File Offset: 0x003C8898
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

		// Token: 0x0601A190 RID: 106896 RVA: 0x003CA6D6 File Offset: 0x003C88D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamParkourRewardResponse other)
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

		// Token: 0x0601A191 RID: 106897 RVA: 0x003CA707 File Offset: 0x003C8907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A192 RID: 106898 RVA: 0x003CA710 File Offset: 0x003C8910
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009857 RID: 38999
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009858 RID: 39000
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04009859 RID: 39001
		private ErrorCode errorCode_;
	}
}

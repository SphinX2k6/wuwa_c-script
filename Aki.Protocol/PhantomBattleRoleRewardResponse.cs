using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CAB RID: 3243
	[NetMessage(EMessageId.PhantomBattleRoleRewardResponse)]
	public sealed class PhantomBattleRoleRewardResponse : IMessage<PhantomBattleRoleRewardResponse>, IMessage, IEquatable<PhantomBattleRoleRewardResponse>, IDeepCloneable<PhantomBattleRoleRewardResponse>, IBufferMessage
	{
		// Token: 0x06011925 RID: 71973 RVA: 0x00292E61 File Offset: 0x00291061
		[NullableContext(1)]
		public static PhantomBattleRoleRewardResponse Create()
		{
			return new PhantomBattleRoleRewardResponse();
		}

		// Token: 0x17003A38 RID: 14904
		// (get) Token: 0x06011926 RID: 71974 RVA: 0x00292E68 File Offset: 0x00291068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A39 RID: 14905
		// (get) Token: 0x06011927 RID: 71975 RVA: 0x00292E6B File Offset: 0x0029106B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoleRewardResponse.Descriptor;
			}
		}

		// Token: 0x06011928 RID: 71976 RVA: 0x00292E72 File Offset: 0x00291072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleRewardResponse()
		{
		}

		// Token: 0x06011929 RID: 71977 RVA: 0x00292E7A File Offset: 0x0029107A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleRewardResponse(PhantomBattleRoleRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601192A RID: 71978 RVA: 0x00292E9F File Offset: 0x0029109F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleRewardResponse Clone()
		{
			return new PhantomBattleRoleRewardResponse(this);
		}

		// Token: 0x17003A3A RID: 14906
		// (get) Token: 0x0601192B RID: 71979 RVA: 0x00292EA7 File Offset: 0x002910A7
		// (set) Token: 0x0601192C RID: 71980 RVA: 0x00292EAF File Offset: 0x002910AF
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

		// Token: 0x0601192D RID: 71981 RVA: 0x00292EB8 File Offset: 0x002910B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoleRewardResponse);
		}

		// Token: 0x0601192E RID: 71982 RVA: 0x00292EC6 File Offset: 0x002910C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoleRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601192F RID: 71983 RVA: 0x00292EF4 File Offset: 0x002910F4
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

		// Token: 0x06011930 RID: 71984 RVA: 0x00292F39 File Offset: 0x00291139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011931 RID: 71985 RVA: 0x00292F46 File Offset: 0x00291146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011932 RID: 71986 RVA: 0x00292F4F File Offset: 0x0029114F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011933 RID: 71987 RVA: 0x00292F84 File Offset: 0x00291184
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

		// Token: 0x06011934 RID: 71988 RVA: 0x00292FC2 File Offset: 0x002911C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoleRewardResponse other)
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

		// Token: 0x06011935 RID: 71989 RVA: 0x00292FF3 File Offset: 0x002911F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011936 RID: 71990 RVA: 0x00292FFC File Offset: 0x002911FC
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006EBD RID: 28349
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EBE RID: 28350
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04006EBF RID: 28351
		private ErrorCode errorCode_;
	}
}

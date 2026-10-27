using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000180 RID: 384
	[NetMessage(EMessageId.BattleStateChangeResponse)]
	public sealed class BattleStateChangeResponse : IMessage<BattleStateChangeResponse>, IMessage, IEquatable<BattleStateChangeResponse>, IDeepCloneable<BattleStateChangeResponse>, IBufferMessage
	{
		// Token: 0x06002E85 RID: 11909 RVA: 0x00077BB0 File Offset: 0x00075DB0
		[NullableContext(1)]
		public static BattleStateChangeResponse Create()
		{
			return new BattleStateChangeResponse();
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x00077BB7 File Offset: 0x00075DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06002E87 RID: 11911 RVA: 0x00077BBA File Offset: 0x00075DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleStateChangeResponse.Descriptor;
			}
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x00077BC1 File Offset: 0x00075DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeResponse()
		{
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00077BC9 File Offset: 0x00075DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeResponse(BattleStateChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x00077BEE File Offset: 0x00075DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeResponse Clone()
		{
			return new BattleStateChangeResponse(this);
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06002E8B RID: 11915 RVA: 0x00077BF6 File Offset: 0x00075DF6
		// (set) Token: 0x06002E8C RID: 11916 RVA: 0x00077BFE File Offset: 0x00075DFE
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

		// Token: 0x06002E8D RID: 11917 RVA: 0x00077C07 File Offset: 0x00075E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleStateChangeResponse);
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x00077C15 File Offset: 0x00075E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleStateChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x00077C44 File Offset: 0x00075E44
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

		// Token: 0x06002E90 RID: 11920 RVA: 0x00077C89 File Offset: 0x00075E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00077C96 File Offset: 0x00075E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00077C9F File Offset: 0x00075E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00077CD4 File Offset: 0x00075ED4
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

		// Token: 0x06002E94 RID: 11924 RVA: 0x00077D12 File Offset: 0x00075F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleStateChangeResponse other)
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

		// Token: 0x06002E95 RID: 11925 RVA: 0x00077D43 File Offset: 0x00075F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00077D4C File Offset: 0x00075F4C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400287A RID: 10362
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400287B RID: 10363
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400287C RID: 10364
		private ErrorCode errorCode_;
	}
}

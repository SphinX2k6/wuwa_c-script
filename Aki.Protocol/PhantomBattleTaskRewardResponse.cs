using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB2 RID: 3250
	[NetMessage(EMessageId.PhantomBattleTaskRewardResponse)]
	public sealed class PhantomBattleTaskRewardResponse : IMessage<PhantomBattleTaskRewardResponse>, IMessage, IEquatable<PhantomBattleTaskRewardResponse>, IDeepCloneable<PhantomBattleTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060119FB RID: 72187 RVA: 0x00295125 File Offset: 0x00293325
		[NullableContext(1)]
		public static PhantomBattleTaskRewardResponse Create()
		{
			return new PhantomBattleTaskRewardResponse();
		}

		// Token: 0x17003A63 RID: 14947
		// (get) Token: 0x060119FC RID: 72188 RVA: 0x0029512C File Offset: 0x0029332C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A64 RID: 14948
		// (get) Token: 0x060119FD RID: 72189 RVA: 0x0029512F File Offset: 0x0029332F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060119FE RID: 72190 RVA: 0x00295136 File Offset: 0x00293336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskRewardResponse()
		{
		}

		// Token: 0x060119FF RID: 72191 RVA: 0x0029513E File Offset: 0x0029333E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskRewardResponse(PhantomBattleTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011A00 RID: 72192 RVA: 0x00295163 File Offset: 0x00293363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskRewardResponse Clone()
		{
			return new PhantomBattleTaskRewardResponse(this);
		}

		// Token: 0x17003A65 RID: 14949
		// (get) Token: 0x06011A01 RID: 72193 RVA: 0x0029516B File Offset: 0x0029336B
		// (set) Token: 0x06011A02 RID: 72194 RVA: 0x00295173 File Offset: 0x00293373
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

		// Token: 0x06011A03 RID: 72195 RVA: 0x0029517C File Offset: 0x0029337C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleTaskRewardResponse);
		}

		// Token: 0x06011A04 RID: 72196 RVA: 0x0029518A File Offset: 0x0029338A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A05 RID: 72197 RVA: 0x002951B8 File Offset: 0x002933B8
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

		// Token: 0x06011A06 RID: 72198 RVA: 0x002951FD File Offset: 0x002933FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A07 RID: 72199 RVA: 0x0029520A File Offset: 0x0029340A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A08 RID: 72200 RVA: 0x00295213 File Offset: 0x00293413
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

		// Token: 0x06011A09 RID: 72201 RVA: 0x00295248 File Offset: 0x00293448
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

		// Token: 0x06011A0A RID: 72202 RVA: 0x00295286 File Offset: 0x00293486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleTaskRewardResponse other)
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

		// Token: 0x06011A0B RID: 72203 RVA: 0x002952B7 File Offset: 0x002934B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A0C RID: 72204 RVA: 0x002952C0 File Offset: 0x002934C0
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

		// Token: 0x04006F5B RID: 28507
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F5C RID: 28508
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04006F5D RID: 28509
		private ErrorCode errorCode_;
	}
}

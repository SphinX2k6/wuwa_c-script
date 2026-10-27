using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D0 RID: 4560
	[NetMessage(EMessageId.SetFanNumberOfTurnsResponse)]
	public sealed class SetFanNumberOfTurnsResponse : IMessage<SetFanNumberOfTurnsResponse>, IMessage, IEquatable<SetFanNumberOfTurnsResponse>, IDeepCloneable<SetFanNumberOfTurnsResponse>, IBufferMessage
	{
		// Token: 0x06018524 RID: 99620 RVA: 0x00389FA3 File Offset: 0x003881A3
		[NullableContext(1)]
		public static SetFanNumberOfTurnsResponse Create()
		{
			return new SetFanNumberOfTurnsResponse();
		}

		// Token: 0x170051E9 RID: 20969
		// (get) Token: 0x06018525 RID: 99621 RVA: 0x00389FAA File Offset: 0x003881AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051EA RID: 20970
		// (get) Token: 0x06018526 RID: 99622 RVA: 0x00389FAD File Offset: 0x003881AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFanNumberOfTurnsResponse.Descriptor;
			}
		}

		// Token: 0x06018527 RID: 99623 RVA: 0x00389FB4 File Offset: 0x003881B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanNumberOfTurnsResponse()
		{
		}

		// Token: 0x06018528 RID: 99624 RVA: 0x00389FBC File Offset: 0x003881BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanNumberOfTurnsResponse(SetFanNumberOfTurnsResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018529 RID: 99625 RVA: 0x00389FE1 File Offset: 0x003881E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanNumberOfTurnsResponse Clone()
		{
			return new SetFanNumberOfTurnsResponse(this);
		}

		// Token: 0x170051EB RID: 20971
		// (get) Token: 0x0601852A RID: 99626 RVA: 0x00389FE9 File Offset: 0x003881E9
		// (set) Token: 0x0601852B RID: 99627 RVA: 0x00389FF1 File Offset: 0x003881F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0601852C RID: 99628 RVA: 0x00389FFA File Offset: 0x003881FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFanNumberOfTurnsResponse);
		}

		// Token: 0x0601852D RID: 99629 RVA: 0x0038A008 File Offset: 0x00388208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFanNumberOfTurnsResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601852E RID: 99630 RVA: 0x0038A038 File Offset: 0x00388238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601852F RID: 99631 RVA: 0x0038A07D File Offset: 0x0038827D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018530 RID: 99632 RVA: 0x0038A08A File Offset: 0x0038828A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018531 RID: 99633 RVA: 0x0038A093 File Offset: 0x00388293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018532 RID: 99634 RVA: 0x0038A0C8 File Offset: 0x003882C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018533 RID: 99635 RVA: 0x0038A106 File Offset: 0x00388306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFanNumberOfTurnsResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018534 RID: 99636 RVA: 0x0038A137 File Offset: 0x00388337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018535 RID: 99637 RVA: 0x0038A140 File Offset: 0x00388340
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009004 RID: 36868
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009005 RID: 36869
		public const int ErrCodeFieldNumber = 10;

		// Token: 0x04009006 RID: 36870
		private ErrorCode errCode_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001124 RID: 4388
	[NetMessage(EMessageId.RollBlockToggleHintResponse)]
	public sealed class RollBlockToggleHintResponse : IMessage<RollBlockToggleHintResponse>, IMessage, IEquatable<RollBlockToggleHintResponse>, IDeepCloneable<RollBlockToggleHintResponse>, IBufferMessage
	{
		// Token: 0x06017718 RID: 96024 RVA: 0x00368E9C File Offset: 0x0036709C
		[NullableContext(1)]
		public static RollBlockToggleHintResponse Create()
		{
			return new RollBlockToggleHintResponse();
		}

		// Token: 0x17004EC2 RID: 20162
		// (get) Token: 0x06017719 RID: 96025 RVA: 0x00368EA3 File Offset: 0x003670A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EC3 RID: 20163
		// (get) Token: 0x0601771A RID: 96026 RVA: 0x00368EA6 File Offset: 0x003670A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockToggleHintResponse.Descriptor;
			}
		}

		// Token: 0x0601771B RID: 96027 RVA: 0x00368EAD File Offset: 0x003670AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockToggleHintResponse()
		{
		}

		// Token: 0x0601771C RID: 96028 RVA: 0x00368EB5 File Offset: 0x003670B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockToggleHintResponse(RollBlockToggleHintResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601771D RID: 96029 RVA: 0x00368EDA File Offset: 0x003670DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockToggleHintResponse Clone()
		{
			return new RollBlockToggleHintResponse(this);
		}

		// Token: 0x17004EC4 RID: 20164
		// (get) Token: 0x0601771E RID: 96030 RVA: 0x00368EE2 File Offset: 0x003670E2
		// (set) Token: 0x0601771F RID: 96031 RVA: 0x00368EEA File Offset: 0x003670EA
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

		// Token: 0x06017720 RID: 96032 RVA: 0x00368EF3 File Offset: 0x003670F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockToggleHintResponse);
		}

		// Token: 0x06017721 RID: 96033 RVA: 0x00368F01 File Offset: 0x00367101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockToggleHintResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017722 RID: 96034 RVA: 0x00368F30 File Offset: 0x00367130
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

		// Token: 0x06017723 RID: 96035 RVA: 0x00368F75 File Offset: 0x00367175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017724 RID: 96036 RVA: 0x00368F82 File Offset: 0x00367182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017725 RID: 96037 RVA: 0x00368F8B File Offset: 0x0036718B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017726 RID: 96038 RVA: 0x00368FBC File Offset: 0x003671BC
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

		// Token: 0x06017727 RID: 96039 RVA: 0x00368FFA File Offset: 0x003671FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockToggleHintResponse other)
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

		// Token: 0x06017728 RID: 96040 RVA: 0x0036902B File Offset: 0x0036722B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017729 RID: 96041 RVA: 0x00369034 File Offset: 0x00367234
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008BE6 RID: 35814
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BE7 RID: 35815
		public const int CodeFieldNumber = 1;

		// Token: 0x04008BE8 RID: 35816
		private ErrorCode code_;
	}
}

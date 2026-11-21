using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200061F RID: 1567
	[NetMessage(EMessageId.FormationSwitchCurrentResponse)]
	public sealed class FormationSwitchCurrentResponse : IMessage<FormationSwitchCurrentResponse>, IMessage, IEquatable<FormationSwitchCurrentResponse>, IDeepCloneable<FormationSwitchCurrentResponse>, IBufferMessage
	{
		// Token: 0x060090F4 RID: 37108 RVA: 0x0015F515 File Offset: 0x0015D715
		[NullableContext(1)]
		public static FormationSwitchCurrentResponse Create()
		{
			return new FormationSwitchCurrentResponse();
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x060090F5 RID: 37109 RVA: 0x0015F51C File Offset: 0x0015D71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x060090F6 RID: 37110 RVA: 0x0015F51F File Offset: 0x0015D71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationSwitchCurrentResponse.Descriptor;
			}
		}

		// Token: 0x060090F7 RID: 37111 RVA: 0x0015F526 File Offset: 0x0015D726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchCurrentResponse()
		{
		}

		// Token: 0x060090F8 RID: 37112 RVA: 0x0015F52E File Offset: 0x0015D72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchCurrentResponse(FormationSwitchCurrentResponse other) : this()
		{
			this.currentId_ = other.currentId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060090F9 RID: 37113 RVA: 0x0015F55F File Offset: 0x0015D75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchCurrentResponse Clone()
		{
			return new FormationSwitchCurrentResponse(this);
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x060090FA RID: 37114 RVA: 0x0015F567 File Offset: 0x0015D767
		// (set) Token: 0x060090FB RID: 37115 RVA: 0x0015F56F File Offset: 0x0015D76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentId
		{
			get
			{
				return this.currentId_;
			}
			set
			{
				this.currentId_ = value;
			}
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x060090FC RID: 37116 RVA: 0x0015F578 File Offset: 0x0015D778
		// (set) Token: 0x060090FD RID: 37117 RVA: 0x0015F580 File Offset: 0x0015D780
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

		// Token: 0x060090FE RID: 37118 RVA: 0x0015F589 File Offset: 0x0015D789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationSwitchCurrentResponse);
		}

		// Token: 0x060090FF RID: 37119 RVA: 0x0015F597 File Offset: 0x0015D797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationSwitchCurrentResponse other)
		{
			return other != null && (other == this || (this.CurrentId == other.CurrentId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009100 RID: 37120 RVA: 0x0015F5D8 File Offset: 0x0015D7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurrentId != 0)
			{
				num ^= this.CurrentId.GetHashCode();
			}
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

		// Token: 0x06009101 RID: 37121 RVA: 0x0015F636 File Offset: 0x0015D836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009102 RID: 37122 RVA: 0x0015F643 File Offset: 0x0015D843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009103 RID: 37123 RVA: 0x0015F64C File Offset: 0x0015D84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CurrentId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CurrentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x0015F6A8 File Offset: 0x0015D8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurrentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentId);
			}
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

		// Token: 0x06009105 RID: 37125 RVA: 0x0015F700 File Offset: 0x0015D900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationSwitchCurrentResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurrentId != 0)
			{
				this.CurrentId = other.CurrentId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x0015F750 File Offset: 0x0015D950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009107 RID: 37127 RVA: 0x0015F75C File Offset: 0x0015D95C
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurrentId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004686 RID: 18054
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004687 RID: 18055
		public const int CurrentIdFieldNumber = 14;

		// Token: 0x04004688 RID: 18056
		private int currentId_;

		// Token: 0x04004689 RID: 18057
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400468A RID: 18058
		private ErrorCode errorCode_;
	}
}

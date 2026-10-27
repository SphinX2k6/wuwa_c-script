using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200146E RID: 5230
	[NetMessage(EMessageId.TriggerExitSkillResponse)]
	public sealed class TriggerExitSkillResponse : IMessage<TriggerExitSkillResponse>, IMessage, IEquatable<TriggerExitSkillResponse>, IDeepCloneable<TriggerExitSkillResponse>, IBufferMessage
	{
		// Token: 0x0601BB05 RID: 113413 RVA: 0x00401DD0 File Offset: 0x003FFFD0
		[NullableContext(1)]
		public static TriggerExitSkillResponse Create()
		{
			return new TriggerExitSkillResponse();
		}

		// Token: 0x17005D60 RID: 23904
		// (get) Token: 0x0601BB06 RID: 113414 RVA: 0x00401DD7 File Offset: 0x003FFFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D61 RID: 23905
		// (get) Token: 0x0601BB07 RID: 113415 RVA: 0x00401DDA File Offset: 0x003FFFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TriggerExitSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601BB08 RID: 113416 RVA: 0x00401DE1 File Offset: 0x003FFFE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillResponse()
		{
		}

		// Token: 0x0601BB09 RID: 113417 RVA: 0x00401DE9 File Offset: 0x003FFFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillResponse(TriggerExitSkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB0A RID: 113418 RVA: 0x00401E0E File Offset: 0x0040000E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillResponse Clone()
		{
			return new TriggerExitSkillResponse(this);
		}

		// Token: 0x17005D62 RID: 23906
		// (get) Token: 0x0601BB0B RID: 113419 RVA: 0x00401E16 File Offset: 0x00400016
		// (set) Token: 0x0601BB0C RID: 113420 RVA: 0x00401E1E File Offset: 0x0040001E
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

		// Token: 0x0601BB0D RID: 113421 RVA: 0x00401E27 File Offset: 0x00400027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TriggerExitSkillResponse);
		}

		// Token: 0x0601BB0E RID: 113422 RVA: 0x00401E35 File Offset: 0x00400035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TriggerExitSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB0F RID: 113423 RVA: 0x00401E64 File Offset: 0x00400064
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

		// Token: 0x0601BB10 RID: 113424 RVA: 0x00401EA9 File Offset: 0x004000A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB11 RID: 113425 RVA: 0x00401EB6 File Offset: 0x004000B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB12 RID: 113426 RVA: 0x00401EBF File Offset: 0x004000BF
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

		// Token: 0x0601BB13 RID: 113427 RVA: 0x00401EF4 File Offset: 0x004000F4
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

		// Token: 0x0601BB14 RID: 113428 RVA: 0x00401F32 File Offset: 0x00400132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TriggerExitSkillResponse other)
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

		// Token: 0x0601BB15 RID: 113429 RVA: 0x00401F63 File Offset: 0x00400163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB16 RID: 113430 RVA: 0x00401F6C File Offset: 0x0040016C
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

		// Token: 0x04009F86 RID: 40838
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F87 RID: 40839
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04009F88 RID: 40840
		private ErrorCode errorCode_;
	}
}

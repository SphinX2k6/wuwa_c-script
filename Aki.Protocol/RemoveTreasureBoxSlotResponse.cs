using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F01 RID: 3841
	[NetMessage(EMessageId.RemoveTreasureBoxSlotResponse)]
	public sealed class RemoveTreasureBoxSlotResponse : IMessage<RemoveTreasureBoxSlotResponse>, IMessage, IEquatable<RemoveTreasureBoxSlotResponse>, IDeepCloneable<RemoveTreasureBoxSlotResponse>, IBufferMessage
	{
		// Token: 0x06014983 RID: 84355 RVA: 0x002FDFF5 File Offset: 0x002FC1F5
		[NullableContext(1)]
		public static RemoveTreasureBoxSlotResponse Create()
		{
			return new RemoveTreasureBoxSlotResponse();
		}

		// Token: 0x1700447B RID: 17531
		// (get) Token: 0x06014984 RID: 84356 RVA: 0x002FDFFC File Offset: 0x002FC1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700447C RID: 17532
		// (get) Token: 0x06014985 RID: 84357 RVA: 0x002FDFFF File Offset: 0x002FC1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveTreasureBoxSlotResponse.Descriptor;
			}
		}

		// Token: 0x06014986 RID: 84358 RVA: 0x002FE006 File Offset: 0x002FC206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTreasureBoxSlotResponse()
		{
		}

		// Token: 0x06014987 RID: 84359 RVA: 0x002FE00E File Offset: 0x002FC20E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTreasureBoxSlotResponse(RemoveTreasureBoxSlotResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014988 RID: 84360 RVA: 0x002FE033 File Offset: 0x002FC233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTreasureBoxSlotResponse Clone()
		{
			return new RemoveTreasureBoxSlotResponse(this);
		}

		// Token: 0x1700447D RID: 17533
		// (get) Token: 0x06014989 RID: 84361 RVA: 0x002FE03B File Offset: 0x002FC23B
		// (set) Token: 0x0601498A RID: 84362 RVA: 0x002FE043 File Offset: 0x002FC243
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

		// Token: 0x0601498B RID: 84363 RVA: 0x002FE04C File Offset: 0x002FC24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveTreasureBoxSlotResponse);
		}

		// Token: 0x0601498C RID: 84364 RVA: 0x002FE05A File Offset: 0x002FC25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveTreasureBoxSlotResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601498D RID: 84365 RVA: 0x002FE088 File Offset: 0x002FC288
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

		// Token: 0x0601498E RID: 84366 RVA: 0x002FE0CD File Offset: 0x002FC2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601498F RID: 84367 RVA: 0x002FE0DA File Offset: 0x002FC2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014990 RID: 84368 RVA: 0x002FE0E3 File Offset: 0x002FC2E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014991 RID: 84369 RVA: 0x002FE118 File Offset: 0x002FC318
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

		// Token: 0x06014992 RID: 84370 RVA: 0x002FE156 File Offset: 0x002FC356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveTreasureBoxSlotResponse other)
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

		// Token: 0x06014993 RID: 84371 RVA: 0x002FE187 File Offset: 0x002FC387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014994 RID: 84372 RVA: 0x002FE190 File Offset: 0x002FC390
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D13 RID: 32019
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D14 RID: 32020
		public const int CodeFieldNumber = 11;

		// Token: 0x04007D15 RID: 32021
		private ErrorCode code_;
	}
}

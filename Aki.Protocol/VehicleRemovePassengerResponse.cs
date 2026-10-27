using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D6 RID: 5334
	[NetMessage(EMessageId.VehicleRemovePassengerResponse)]
	public sealed class VehicleRemovePassengerResponse : IMessage<VehicleRemovePassengerResponse>, IMessage, IEquatable<VehicleRemovePassengerResponse>, IDeepCloneable<VehicleRemovePassengerResponse>, IBufferMessage
	{
		// Token: 0x0601C341 RID: 115521 RVA: 0x004135C5 File Offset: 0x004117C5
		[NullableContext(1)]
		public static VehicleRemovePassengerResponse Create()
		{
			return new VehicleRemovePassengerResponse();
		}

		// Token: 0x17005F11 RID: 24337
		// (get) Token: 0x0601C342 RID: 115522 RVA: 0x004135CC File Offset: 0x004117CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F12 RID: 24338
		// (get) Token: 0x0601C343 RID: 115523 RVA: 0x004135CF File Offset: 0x004117CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleRemovePassengerResponse.Descriptor;
			}
		}

		// Token: 0x0601C344 RID: 115524 RVA: 0x004135D6 File Offset: 0x004117D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRemovePassengerResponse()
		{
		}

		// Token: 0x0601C345 RID: 115525 RVA: 0x004135DE File Offset: 0x004117DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRemovePassengerResponse(VehicleRemovePassengerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C346 RID: 115526 RVA: 0x00413603 File Offset: 0x00411803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRemovePassengerResponse Clone()
		{
			return new VehicleRemovePassengerResponse(this);
		}

		// Token: 0x17005F13 RID: 24339
		// (get) Token: 0x0601C347 RID: 115527 RVA: 0x0041360B File Offset: 0x0041180B
		// (set) Token: 0x0601C348 RID: 115528 RVA: 0x00413613 File Offset: 0x00411813
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

		// Token: 0x0601C349 RID: 115529 RVA: 0x0041361C File Offset: 0x0041181C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleRemovePassengerResponse);
		}

		// Token: 0x0601C34A RID: 115530 RVA: 0x0041362A File Offset: 0x0041182A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleRemovePassengerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C34B RID: 115531 RVA: 0x00413658 File Offset: 0x00411858
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

		// Token: 0x0601C34C RID: 115532 RVA: 0x0041369D File Offset: 0x0041189D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C34D RID: 115533 RVA: 0x004136AA File Offset: 0x004118AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C34E RID: 115534 RVA: 0x004136B3 File Offset: 0x004118B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C34F RID: 115535 RVA: 0x004136E8 File Offset: 0x004118E8
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

		// Token: 0x0601C350 RID: 115536 RVA: 0x00413726 File Offset: 0x00411926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleRemovePassengerResponse other)
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

		// Token: 0x0601C351 RID: 115537 RVA: 0x00413757 File Offset: 0x00411957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C352 RID: 115538 RVA: 0x00413760 File Offset: 0x00411960
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A1B5 RID: 41397
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1B6 RID: 41398
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400A1B7 RID: 41399
		private ErrorCode errorCode_;
	}
}

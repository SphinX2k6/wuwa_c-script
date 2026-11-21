using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001540 RID: 5440
	[NetMessage(EMessageId.VehicleChangePassengerResponse)]
	public sealed class VehicleChangePassengerResponse : IMessage<VehicleChangePassengerResponse>, IMessage, IEquatable<VehicleChangePassengerResponse>, IDeepCloneable<VehicleChangePassengerResponse>, IBufferMessage
	{
		// Token: 0x0601CD22 RID: 118050 RVA: 0x0042D530 File Offset: 0x0042B730
		[NullableContext(1)]
		public static VehicleChangePassengerResponse Create()
		{
			return new VehicleChangePassengerResponse();
		}

		// Token: 0x17006187 RID: 24967
		// (get) Token: 0x0601CD23 RID: 118051 RVA: 0x0042D537 File Offset: 0x0042B737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006188 RID: 24968
		// (get) Token: 0x0601CD24 RID: 118052 RVA: 0x0042D53A File Offset: 0x0042B73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleChangePassengerResponse.Descriptor;
			}
		}

		// Token: 0x0601CD25 RID: 118053 RVA: 0x0042D541 File Offset: 0x0042B741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleChangePassengerResponse()
		{
		}

		// Token: 0x0601CD26 RID: 118054 RVA: 0x0042D549 File Offset: 0x0042B749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleChangePassengerResponse(VehicleChangePassengerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CD27 RID: 118055 RVA: 0x0042D56E File Offset: 0x0042B76E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleChangePassengerResponse Clone()
		{
			return new VehicleChangePassengerResponse(this);
		}

		// Token: 0x17006189 RID: 24969
		// (get) Token: 0x0601CD28 RID: 118056 RVA: 0x0042D576 File Offset: 0x0042B776
		// (set) Token: 0x0601CD29 RID: 118057 RVA: 0x0042D57E File Offset: 0x0042B77E
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

		// Token: 0x0601CD2A RID: 118058 RVA: 0x0042D587 File Offset: 0x0042B787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleChangePassengerResponse);
		}

		// Token: 0x0601CD2B RID: 118059 RVA: 0x0042D595 File Offset: 0x0042B795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleChangePassengerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD2C RID: 118060 RVA: 0x0042D5C4 File Offset: 0x0042B7C4
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

		// Token: 0x0601CD2D RID: 118061 RVA: 0x0042D609 File Offset: 0x0042B809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CD2E RID: 118062 RVA: 0x0042D616 File Offset: 0x0042B816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CD2F RID: 118063 RVA: 0x0042D61F File Offset: 0x0042B81F
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

		// Token: 0x0601CD30 RID: 118064 RVA: 0x0042D654 File Offset: 0x0042B854
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

		// Token: 0x0601CD31 RID: 118065 RVA: 0x0042D692 File Offset: 0x0042B892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleChangePassengerResponse other)
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

		// Token: 0x0601CD32 RID: 118066 RVA: 0x0042D6C3 File Offset: 0x0042B8C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CD33 RID: 118067 RVA: 0x0042D6CC File Offset: 0x0042B8CC
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

		// Token: 0x0400A5DC RID: 42460
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5DD RID: 42461
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400A5DE RID: 42462
		private ErrorCode errorCode_;
	}
}

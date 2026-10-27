using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014CA RID: 5322
	[NetMessage(EMessageId.VehicleChangePassengerResponse)]
	public sealed class VehicleChangePassengerResponse : IMessage<VehicleChangePassengerResponse>, IMessage, IEquatable<VehicleChangePassengerResponse>, IDeepCloneable<VehicleChangePassengerResponse>, IBufferMessage
	{
		// Token: 0x0601C25B RID: 115291 RVA: 0x00411A74 File Offset: 0x0040FC74
		[NullableContext(1)]
		public static VehicleChangePassengerResponse Create()
		{
			return new VehicleChangePassengerResponse();
		}

		// Token: 0x17005EE6 RID: 24294
		// (get) Token: 0x0601C25C RID: 115292 RVA: 0x00411A7B File Offset: 0x0040FC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EE7 RID: 24295
		// (get) Token: 0x0601C25D RID: 115293 RVA: 0x00411A7E File Offset: 0x0040FC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleChangePassengerResponse.Descriptor;
			}
		}

		// Token: 0x0601C25E RID: 115294 RVA: 0x00411A85 File Offset: 0x0040FC85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleChangePassengerResponse()
		{
		}

		// Token: 0x0601C25F RID: 115295 RVA: 0x00411A8D File Offset: 0x0040FC8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleChangePassengerResponse(VehicleChangePassengerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C260 RID: 115296 RVA: 0x00411AB2 File Offset: 0x0040FCB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleChangePassengerResponse Clone()
		{
			return new VehicleChangePassengerResponse(this);
		}

		// Token: 0x17005EE8 RID: 24296
		// (get) Token: 0x0601C261 RID: 115297 RVA: 0x00411ABA File Offset: 0x0040FCBA
		// (set) Token: 0x0601C262 RID: 115298 RVA: 0x00411AC2 File Offset: 0x0040FCC2
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

		// Token: 0x0601C263 RID: 115299 RVA: 0x00411ACB File Offset: 0x0040FCCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleChangePassengerResponse);
		}

		// Token: 0x0601C264 RID: 115300 RVA: 0x00411AD9 File Offset: 0x0040FCD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleChangePassengerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C265 RID: 115301 RVA: 0x00411B08 File Offset: 0x0040FD08
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

		// Token: 0x0601C266 RID: 115302 RVA: 0x00411B4D File Offset: 0x0040FD4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C267 RID: 115303 RVA: 0x00411B5A File Offset: 0x0040FD5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C268 RID: 115304 RVA: 0x00411B63 File Offset: 0x0040FD63
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

		// Token: 0x0601C269 RID: 115305 RVA: 0x00411B98 File Offset: 0x0040FD98
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

		// Token: 0x0601C26A RID: 115306 RVA: 0x00411BD6 File Offset: 0x0040FDD6
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

		// Token: 0x0601C26B RID: 115307 RVA: 0x00411C07 File Offset: 0x0040FE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C26C RID: 115308 RVA: 0x00411C10 File Offset: 0x0040FE10
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

		// Token: 0x0400A183 RID: 41347
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A184 RID: 41348
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400A185 RID: 41349
		private ErrorCode errorCode_;
	}
}

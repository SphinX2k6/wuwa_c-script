using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014CE RID: 5326
	[NetMessage(EMessageId.VehicleFinishResponse)]
	public sealed class VehicleFinishResponse : IMessage<VehicleFinishResponse>, IMessage, IEquatable<VehicleFinishResponse>, IDeepCloneable<VehicleFinishResponse>, IBufferMessage
	{
		// Token: 0x0601C2A5 RID: 115365 RVA: 0x004122A1 File Offset: 0x004104A1
		[NullableContext(1)]
		public static VehicleFinishResponse Create()
		{
			return new VehicleFinishResponse();
		}

		// Token: 0x17005EF3 RID: 24307
		// (get) Token: 0x0601C2A6 RID: 115366 RVA: 0x004122A8 File Offset: 0x004104A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EF4 RID: 24308
		// (get) Token: 0x0601C2A7 RID: 115367 RVA: 0x004122AB File Offset: 0x004104AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleFinishResponse.Descriptor;
			}
		}

		// Token: 0x0601C2A8 RID: 115368 RVA: 0x004122B2 File Offset: 0x004104B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleFinishResponse()
		{
		}

		// Token: 0x0601C2A9 RID: 115369 RVA: 0x004122BA File Offset: 0x004104BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleFinishResponse(VehicleFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C2AA RID: 115370 RVA: 0x004122DF File Offset: 0x004104DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleFinishResponse Clone()
		{
			return new VehicleFinishResponse(this);
		}

		// Token: 0x17005EF5 RID: 24309
		// (get) Token: 0x0601C2AB RID: 115371 RVA: 0x004122E7 File Offset: 0x004104E7
		// (set) Token: 0x0601C2AC RID: 115372 RVA: 0x004122EF File Offset: 0x004104EF
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

		// Token: 0x0601C2AD RID: 115373 RVA: 0x004122F8 File Offset: 0x004104F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleFinishResponse);
		}

		// Token: 0x0601C2AE RID: 115374 RVA: 0x00412306 File Offset: 0x00410506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C2AF RID: 115375 RVA: 0x00412334 File Offset: 0x00410534
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

		// Token: 0x0601C2B0 RID: 115376 RVA: 0x00412379 File Offset: 0x00410579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C2B1 RID: 115377 RVA: 0x00412386 File Offset: 0x00410586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C2B2 RID: 115378 RVA: 0x0041238F File Offset: 0x0041058F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C2B3 RID: 115379 RVA: 0x004123C4 File Offset: 0x004105C4
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

		// Token: 0x0601C2B4 RID: 115380 RVA: 0x00412402 File Offset: 0x00410602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleFinishResponse other)
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

		// Token: 0x0601C2B5 RID: 115381 RVA: 0x00412433 File Offset: 0x00410633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C2B6 RID: 115382 RVA: 0x0041243C File Offset: 0x0041063C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A191 RID: 41361
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A192 RID: 41362
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400A193 RID: 41363
		private ErrorCode errorCode_;
	}
}

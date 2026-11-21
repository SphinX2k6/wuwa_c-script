using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200154A RID: 5450
	[NetMessage(EMessageId.VehiclePlatformGetOnResponse)]
	public sealed class VehiclePlatformGetOnResponse : IMessage<VehiclePlatformGetOnResponse>, IMessage, IEquatable<VehiclePlatformGetOnResponse>, IDeepCloneable<VehiclePlatformGetOnResponse>, IBufferMessage
	{
		// Token: 0x0601CDE4 RID: 118244 RVA: 0x0042ECC8 File Offset: 0x0042CEC8
		[NullableContext(1)]
		public static VehiclePlatformGetOnResponse Create()
		{
			return new VehiclePlatformGetOnResponse();
		}

		// Token: 0x170061AC RID: 25004
		// (get) Token: 0x0601CDE5 RID: 118245 RVA: 0x0042ECCF File Offset: 0x0042CECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061AD RID: 25005
		// (get) Token: 0x0601CDE6 RID: 118246 RVA: 0x0042ECD2 File Offset: 0x0042CED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehiclePlatformGetOnResponse.Descriptor;
			}
		}

		// Token: 0x0601CDE7 RID: 118247 RVA: 0x0042ECD9 File Offset: 0x0042CED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePlatformGetOnResponse()
		{
		}

		// Token: 0x0601CDE8 RID: 118248 RVA: 0x0042ECE1 File Offset: 0x0042CEE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePlatformGetOnResponse(VehiclePlatformGetOnResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CDE9 RID: 118249 RVA: 0x0042ED06 File Offset: 0x0042CF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePlatformGetOnResponse Clone()
		{
			return new VehiclePlatformGetOnResponse(this);
		}

		// Token: 0x170061AE RID: 25006
		// (get) Token: 0x0601CDEA RID: 118250 RVA: 0x0042ED0E File Offset: 0x0042CF0E
		// (set) Token: 0x0601CDEB RID: 118251 RVA: 0x0042ED16 File Offset: 0x0042CF16
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

		// Token: 0x0601CDEC RID: 118252 RVA: 0x0042ED1F File Offset: 0x0042CF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehiclePlatformGetOnResponse);
		}

		// Token: 0x0601CDED RID: 118253 RVA: 0x0042ED2D File Offset: 0x0042CF2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehiclePlatformGetOnResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CDEE RID: 118254 RVA: 0x0042ED5C File Offset: 0x0042CF5C
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

		// Token: 0x0601CDEF RID: 118255 RVA: 0x0042EDA1 File Offset: 0x0042CFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CDF0 RID: 118256 RVA: 0x0042EDAE File Offset: 0x0042CFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CDF1 RID: 118257 RVA: 0x0042EDB7 File Offset: 0x0042CFB7
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

		// Token: 0x0601CDF2 RID: 118258 RVA: 0x0042EDEC File Offset: 0x0042CFEC
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

		// Token: 0x0601CDF3 RID: 118259 RVA: 0x0042EE2A File Offset: 0x0042D02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehiclePlatformGetOnResponse other)
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

		// Token: 0x0601CDF4 RID: 118260 RVA: 0x0042EE5B File Offset: 0x0042D05B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CDF5 RID: 118261 RVA: 0x0042EE64 File Offset: 0x0042D064
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

		// Token: 0x0400A608 RID: 42504
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A609 RID: 42505
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400A60A RID: 42506
		private ErrorCode errorCode_;
	}
}

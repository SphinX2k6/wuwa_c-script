using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A4 RID: 2468
	[NetMessage(EMessageId.MapTravelSoarRewardResponse)]
	public sealed class MapTravelSoarRewardResponse : IMessage<MapTravelSoarRewardResponse>, IMessage, IEquatable<MapTravelSoarRewardResponse>, IDeepCloneable<MapTravelSoarRewardResponse>, IBufferMessage
	{
		// Token: 0x0600D8B3 RID: 55475 RVA: 0x001FD6B1 File Offset: 0x001FB8B1
		[NullableContext(1)]
		public static MapTravelSoarRewardResponse Create()
		{
			return new MapTravelSoarRewardResponse();
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x0600D8B4 RID: 55476 RVA: 0x001FD6B8 File Offset: 0x001FB8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x0600D8B5 RID: 55477 RVA: 0x001FD6BB File Offset: 0x001FB8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelSoarRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600D8B6 RID: 55478 RVA: 0x001FD6C2 File Offset: 0x001FB8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelSoarRewardResponse()
		{
		}

		// Token: 0x0600D8B7 RID: 55479 RVA: 0x001FD6CA File Offset: 0x001FB8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelSoarRewardResponse(MapTravelSoarRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8B8 RID: 55480 RVA: 0x001FD6EF File Offset: 0x001FB8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelSoarRewardResponse Clone()
		{
			return new MapTravelSoarRewardResponse(this);
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x0600D8B9 RID: 55481 RVA: 0x001FD6F7 File Offset: 0x001FB8F7
		// (set) Token: 0x0600D8BA RID: 55482 RVA: 0x001FD6FF File Offset: 0x001FB8FF
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

		// Token: 0x0600D8BB RID: 55483 RVA: 0x001FD708 File Offset: 0x001FB908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelSoarRewardResponse);
		}

		// Token: 0x0600D8BC RID: 55484 RVA: 0x001FD716 File Offset: 0x001FB916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelSoarRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D8BD RID: 55485 RVA: 0x001FD744 File Offset: 0x001FB944
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

		// Token: 0x0600D8BE RID: 55486 RVA: 0x001FD789 File Offset: 0x001FB989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D8BF RID: 55487 RVA: 0x001FD796 File Offset: 0x001FB996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8C0 RID: 55488 RVA: 0x001FD79F File Offset: 0x001FB99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D8C1 RID: 55489 RVA: 0x001FD7D4 File Offset: 0x001FB9D4
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

		// Token: 0x0600D8C2 RID: 55490 RVA: 0x001FD812 File Offset: 0x001FBA12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTravelSoarRewardResponse other)
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

		// Token: 0x0600D8C3 RID: 55491 RVA: 0x001FD843 File Offset: 0x001FBA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8C4 RID: 55492 RVA: 0x001FD84C File Offset: 0x001FBA4C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005A3B RID: 23099
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A3C RID: 23100
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04005A3D RID: 23101
		private ErrorCode errorCode_;
	}
}

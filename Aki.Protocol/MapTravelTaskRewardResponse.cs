using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A6 RID: 2470
	[NetMessage(EMessageId.MapTravelTaskRewardResponse)]
	public sealed class MapTravelTaskRewardResponse : IMessage<MapTravelTaskRewardResponse>, IMessage, IEquatable<MapTravelTaskRewardResponse>, IDeepCloneable<MapTravelTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600D8D7 RID: 55511 RVA: 0x001FDA68 File Offset: 0x001FBC68
		[NullableContext(1)]
		public static MapTravelTaskRewardResponse Create()
		{
			return new MapTravelTaskRewardResponse();
		}

		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x0600D8D8 RID: 55512 RVA: 0x001FDA6F File Offset: 0x001FBC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x0600D8D9 RID: 55513 RVA: 0x001FDA72 File Offset: 0x001FBC72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600D8DA RID: 55514 RVA: 0x001FDA79 File Offset: 0x001FBC79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelTaskRewardResponse()
		{
		}

		// Token: 0x0600D8DB RID: 55515 RVA: 0x001FDA81 File Offset: 0x001FBC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelTaskRewardResponse(MapTravelTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8DC RID: 55516 RVA: 0x001FDAA6 File Offset: 0x001FBCA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelTaskRewardResponse Clone()
		{
			return new MapTravelTaskRewardResponse(this);
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x0600D8DD RID: 55517 RVA: 0x001FDAAE File Offset: 0x001FBCAE
		// (set) Token: 0x0600D8DE RID: 55518 RVA: 0x001FDAB6 File Offset: 0x001FBCB6
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

		// Token: 0x0600D8DF RID: 55519 RVA: 0x001FDABF File Offset: 0x001FBCBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelTaskRewardResponse);
		}

		// Token: 0x0600D8E0 RID: 55520 RVA: 0x001FDACD File Offset: 0x001FBCCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D8E1 RID: 55521 RVA: 0x001FDAFC File Offset: 0x001FBCFC
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

		// Token: 0x0600D8E2 RID: 55522 RVA: 0x001FDB41 File Offset: 0x001FBD41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D8E3 RID: 55523 RVA: 0x001FDB4E File Offset: 0x001FBD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8E4 RID: 55524 RVA: 0x001FDB57 File Offset: 0x001FBD57
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

		// Token: 0x0600D8E5 RID: 55525 RVA: 0x001FDB8C File Offset: 0x001FBD8C
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

		// Token: 0x0600D8E6 RID: 55526 RVA: 0x001FDBCA File Offset: 0x001FBDCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTravelTaskRewardResponse other)
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

		// Token: 0x0600D8E7 RID: 55527 RVA: 0x001FDBFB File Offset: 0x001FBDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8E8 RID: 55528 RVA: 0x001FDC04 File Offset: 0x001FBE04
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

		// Token: 0x04005A41 RID: 23105
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A42 RID: 23106
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005A43 RID: 23107
		private ErrorCode errorCode_;
	}
}

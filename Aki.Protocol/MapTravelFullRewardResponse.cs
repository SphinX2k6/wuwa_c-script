using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200099F RID: 2463
	[NetMessage(EMessageId.MapTravelFullRewardResponse)]
	public sealed class MapTravelFullRewardResponse : IMessage<MapTravelFullRewardResponse>, IMessage, IEquatable<MapTravelFullRewardResponse>, IDeepCloneable<MapTravelFullRewardResponse>, IBufferMessage
	{
		// Token: 0x0600D84F RID: 55375 RVA: 0x001FCA42 File Offset: 0x001FAC42
		[NullableContext(1)]
		public static MapTravelFullRewardResponse Create()
		{
			return new MapTravelFullRewardResponse();
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x0600D850 RID: 55376 RVA: 0x001FCA49 File Offset: 0x001FAC49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x0600D851 RID: 55377 RVA: 0x001FCA4C File Offset: 0x001FAC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelFullRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600D852 RID: 55378 RVA: 0x001FCA53 File Offset: 0x001FAC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelFullRewardResponse()
		{
		}

		// Token: 0x0600D853 RID: 55379 RVA: 0x001FCA5B File Offset: 0x001FAC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelFullRewardResponse(MapTravelFullRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D854 RID: 55380 RVA: 0x001FCA80 File Offset: 0x001FAC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelFullRewardResponse Clone()
		{
			return new MapTravelFullRewardResponse(this);
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x0600D855 RID: 55381 RVA: 0x001FCA88 File Offset: 0x001FAC88
		// (set) Token: 0x0600D856 RID: 55382 RVA: 0x001FCA90 File Offset: 0x001FAC90
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

		// Token: 0x0600D857 RID: 55383 RVA: 0x001FCA99 File Offset: 0x001FAC99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelFullRewardResponse);
		}

		// Token: 0x0600D858 RID: 55384 RVA: 0x001FCAA7 File Offset: 0x001FACA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelFullRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D859 RID: 55385 RVA: 0x001FCAD8 File Offset: 0x001FACD8
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

		// Token: 0x0600D85A RID: 55386 RVA: 0x001FCB1D File Offset: 0x001FAD1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D85B RID: 55387 RVA: 0x001FCB2A File Offset: 0x001FAD2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D85C RID: 55388 RVA: 0x001FCB33 File Offset: 0x001FAD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D85D RID: 55389 RVA: 0x001FCB68 File Offset: 0x001FAD68
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

		// Token: 0x0600D85E RID: 55390 RVA: 0x001FCBA6 File Offset: 0x001FADA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTravelFullRewardResponse other)
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

		// Token: 0x0600D85F RID: 55391 RVA: 0x001FCBD7 File Offset: 0x001FADD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D860 RID: 55392 RVA: 0x001FCBE0 File Offset: 0x001FADE0
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005A2A RID: 23082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A2B RID: 23083
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005A2C RID: 23084
		private ErrorCode errorCode_;
	}
}

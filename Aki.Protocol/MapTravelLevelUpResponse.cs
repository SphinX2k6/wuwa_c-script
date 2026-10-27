using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A2 RID: 2466
	[NetMessage(EMessageId.MapTravelLevelUpResponse)]
	public sealed class MapTravelLevelUpResponse : IMessage<MapTravelLevelUpResponse>, IMessage, IEquatable<MapTravelLevelUpResponse>, IDeepCloneable<MapTravelLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0600D88F RID: 55439 RVA: 0x001FD2F6 File Offset: 0x001FB4F6
		[NullableContext(1)]
		public static MapTravelLevelUpResponse Create()
		{
			return new MapTravelLevelUpResponse();
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x0600D890 RID: 55440 RVA: 0x001FD2FD File Offset: 0x001FB4FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x0600D891 RID: 55441 RVA: 0x001FD300 File Offset: 0x001FB500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0600D892 RID: 55442 RVA: 0x001FD307 File Offset: 0x001FB507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelLevelUpResponse()
		{
		}

		// Token: 0x0600D893 RID: 55443 RVA: 0x001FD30F File Offset: 0x001FB50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelLevelUpResponse(MapTravelLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D894 RID: 55444 RVA: 0x001FD334 File Offset: 0x001FB534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelLevelUpResponse Clone()
		{
			return new MapTravelLevelUpResponse(this);
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x0600D895 RID: 55445 RVA: 0x001FD33C File Offset: 0x001FB53C
		// (set) Token: 0x0600D896 RID: 55446 RVA: 0x001FD344 File Offset: 0x001FB544
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

		// Token: 0x0600D897 RID: 55447 RVA: 0x001FD34D File Offset: 0x001FB54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelLevelUpResponse);
		}

		// Token: 0x0600D898 RID: 55448 RVA: 0x001FD35B File Offset: 0x001FB55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D899 RID: 55449 RVA: 0x001FD38C File Offset: 0x001FB58C
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

		// Token: 0x0600D89A RID: 55450 RVA: 0x001FD3D1 File Offset: 0x001FB5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D89B RID: 55451 RVA: 0x001FD3DE File Offset: 0x001FB5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D89C RID: 55452 RVA: 0x001FD3E7 File Offset: 0x001FB5E7
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

		// Token: 0x0600D89D RID: 55453 RVA: 0x001FD41C File Offset: 0x001FB61C
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

		// Token: 0x0600D89E RID: 55454 RVA: 0x001FD45A File Offset: 0x001FB65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTravelLevelUpResponse other)
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

		// Token: 0x0600D89F RID: 55455 RVA: 0x001FD48B File Offset: 0x001FB68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8A0 RID: 55456 RVA: 0x001FD494 File Offset: 0x001FB694
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

		// Token: 0x04005A35 RID: 23093
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A36 RID: 23094
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04005A37 RID: 23095
		private ErrorCode errorCode_;
	}
}

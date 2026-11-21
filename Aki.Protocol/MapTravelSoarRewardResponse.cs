using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000993 RID: 2451
	[NetMessage(EMessageId.MapTravelSoarRewardResponse)]
	public sealed class MapTravelSoarRewardResponse : IMessage<MapTravelSoarRewardResponse>, IMessage, IEquatable<MapTravelSoarRewardResponse>, IDeepCloneable<MapTravelSoarRewardResponse>, IBufferMessage
	{
		// Token: 0x0600D799 RID: 55193 RVA: 0x001FB4BD File Offset: 0x001F96BD
		[NullableContext(1)]
		public static MapTravelSoarRewardResponse Create()
		{
			return new MapTravelSoarRewardResponse();
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x0600D79A RID: 55194 RVA: 0x001FB4C4 File Offset: 0x001F96C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x0600D79B RID: 55195 RVA: 0x001FB4C7 File Offset: 0x001F96C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelSoarRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600D79C RID: 55196 RVA: 0x001FB4CE File Offset: 0x001F96CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelSoarRewardResponse()
		{
		}

		// Token: 0x0600D79D RID: 55197 RVA: 0x001FB4D6 File Offset: 0x001F96D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelSoarRewardResponse(MapTravelSoarRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D79E RID: 55198 RVA: 0x001FB4FB File Offset: 0x001F96FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelSoarRewardResponse Clone()
		{
			return new MapTravelSoarRewardResponse(this);
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x0600D79F RID: 55199 RVA: 0x001FB503 File Offset: 0x001F9703
		// (set) Token: 0x0600D7A0 RID: 55200 RVA: 0x001FB50B File Offset: 0x001F970B
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

		// Token: 0x0600D7A1 RID: 55201 RVA: 0x001FB514 File Offset: 0x001F9714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelSoarRewardResponse);
		}

		// Token: 0x0600D7A2 RID: 55202 RVA: 0x001FB522 File Offset: 0x001F9722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelSoarRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D7A3 RID: 55203 RVA: 0x001FB550 File Offset: 0x001F9750
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

		// Token: 0x0600D7A4 RID: 55204 RVA: 0x001FB595 File Offset: 0x001F9795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D7A5 RID: 55205 RVA: 0x001FB5A2 File Offset: 0x001F97A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7A6 RID: 55206 RVA: 0x001FB5AB File Offset: 0x001F97AB
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

		// Token: 0x0600D7A7 RID: 55207 RVA: 0x001FB5E0 File Offset: 0x001F97E0
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

		// Token: 0x0600D7A8 RID: 55208 RVA: 0x001FB61E File Offset: 0x001F981E
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

		// Token: 0x0600D7A9 RID: 55209 RVA: 0x001FB64F File Offset: 0x001F984F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7AA RID: 55210 RVA: 0x001FB658 File Offset: 0x001F9858
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

		// Token: 0x04005A44 RID: 23108
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A45 RID: 23109
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04005A46 RID: 23110
		private ErrorCode errorCode_;
	}
}

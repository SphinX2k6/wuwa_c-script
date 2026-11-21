using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000991 RID: 2449
	[NetMessage(EMessageId.MapTravelLevelUpResponse)]
	public sealed class MapTravelLevelUpResponse : IMessage<MapTravelLevelUpResponse>, IMessage, IEquatable<MapTravelLevelUpResponse>, IDeepCloneable<MapTravelLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0600D775 RID: 55157 RVA: 0x001FB102 File Offset: 0x001F9302
		[NullableContext(1)]
		public static MapTravelLevelUpResponse Create()
		{
			return new MapTravelLevelUpResponse();
		}

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x0600D776 RID: 55158 RVA: 0x001FB109 File Offset: 0x001F9309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x0600D777 RID: 55159 RVA: 0x001FB10C File Offset: 0x001F930C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0600D778 RID: 55160 RVA: 0x001FB113 File Offset: 0x001F9313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelLevelUpResponse()
		{
		}

		// Token: 0x0600D779 RID: 55161 RVA: 0x001FB11B File Offset: 0x001F931B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelLevelUpResponse(MapTravelLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D77A RID: 55162 RVA: 0x001FB140 File Offset: 0x001F9340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelLevelUpResponse Clone()
		{
			return new MapTravelLevelUpResponse(this);
		}

		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x0600D77B RID: 55163 RVA: 0x001FB148 File Offset: 0x001F9348
		// (set) Token: 0x0600D77C RID: 55164 RVA: 0x001FB150 File Offset: 0x001F9350
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

		// Token: 0x0600D77D RID: 55165 RVA: 0x001FB159 File Offset: 0x001F9359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelLevelUpResponse);
		}

		// Token: 0x0600D77E RID: 55166 RVA: 0x001FB167 File Offset: 0x001F9367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D77F RID: 55167 RVA: 0x001FB198 File Offset: 0x001F9398
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

		// Token: 0x0600D780 RID: 55168 RVA: 0x001FB1DD File Offset: 0x001F93DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D781 RID: 55169 RVA: 0x001FB1EA File Offset: 0x001F93EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D782 RID: 55170 RVA: 0x001FB1F3 File Offset: 0x001F93F3
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

		// Token: 0x0600D783 RID: 55171 RVA: 0x001FB228 File Offset: 0x001F9428
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

		// Token: 0x0600D784 RID: 55172 RVA: 0x001FB266 File Offset: 0x001F9466
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

		// Token: 0x0600D785 RID: 55173 RVA: 0x001FB297 File Offset: 0x001F9497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D786 RID: 55174 RVA: 0x001FB2A0 File Offset: 0x001F94A0
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

		// Token: 0x04005A3E RID: 23102
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A3F RID: 23103
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04005A40 RID: 23104
		private ErrorCode errorCode_;
	}
}

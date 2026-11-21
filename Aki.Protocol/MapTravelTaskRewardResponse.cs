using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000995 RID: 2453
	[NetMessage(EMessageId.MapTravelTaskRewardResponse)]
	public sealed class MapTravelTaskRewardResponse : IMessage<MapTravelTaskRewardResponse>, IMessage, IEquatable<MapTravelTaskRewardResponse>, IDeepCloneable<MapTravelTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600D7BD RID: 55229 RVA: 0x001FB874 File Offset: 0x001F9A74
		[NullableContext(1)]
		public static MapTravelTaskRewardResponse Create()
		{
			return new MapTravelTaskRewardResponse();
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x0600D7BE RID: 55230 RVA: 0x001FB87B File Offset: 0x001F9A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x0600D7BF RID: 55231 RVA: 0x001FB87E File Offset: 0x001F9A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600D7C0 RID: 55232 RVA: 0x001FB885 File Offset: 0x001F9A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelTaskRewardResponse()
		{
		}

		// Token: 0x0600D7C1 RID: 55233 RVA: 0x001FB88D File Offset: 0x001F9A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelTaskRewardResponse(MapTravelTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7C2 RID: 55234 RVA: 0x001FB8B2 File Offset: 0x001F9AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelTaskRewardResponse Clone()
		{
			return new MapTravelTaskRewardResponse(this);
		}

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x0600D7C3 RID: 55235 RVA: 0x001FB8BA File Offset: 0x001F9ABA
		// (set) Token: 0x0600D7C4 RID: 55236 RVA: 0x001FB8C2 File Offset: 0x001F9AC2
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

		// Token: 0x0600D7C5 RID: 55237 RVA: 0x001FB8CB File Offset: 0x001F9ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelTaskRewardResponse);
		}

		// Token: 0x0600D7C6 RID: 55238 RVA: 0x001FB8D9 File Offset: 0x001F9AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D7C7 RID: 55239 RVA: 0x001FB908 File Offset: 0x001F9B08
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

		// Token: 0x0600D7C8 RID: 55240 RVA: 0x001FB94D File Offset: 0x001F9B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D7C9 RID: 55241 RVA: 0x001FB95A File Offset: 0x001F9B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7CA RID: 55242 RVA: 0x001FB963 File Offset: 0x001F9B63
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

		// Token: 0x0600D7CB RID: 55243 RVA: 0x001FB998 File Offset: 0x001F9B98
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

		// Token: 0x0600D7CC RID: 55244 RVA: 0x001FB9D6 File Offset: 0x001F9BD6
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

		// Token: 0x0600D7CD RID: 55245 RVA: 0x001FBA07 File Offset: 0x001F9C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7CE RID: 55246 RVA: 0x001FBA10 File Offset: 0x001F9C10
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

		// Token: 0x04005A4A RID: 23114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A4B RID: 23115
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04005A4C RID: 23116
		private ErrorCode errorCode_;
	}
}

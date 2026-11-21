using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013EF RID: 5103
	[NetMessage(EMessageId.TimePointActivityRewardResponse)]
	public sealed class TimePointActivityRewardResponse : IMessage<TimePointActivityRewardResponse>, IMessage, IEquatable<TimePointActivityRewardResponse>, IDeepCloneable<TimePointActivityRewardResponse>, IBufferMessage
	{
		// Token: 0x0601B23C RID: 111164 RVA: 0x003F321D File Offset: 0x003F141D
		[NullableContext(1)]
		public static TimePointActivityRewardResponse Create()
		{
			return new TimePointActivityRewardResponse();
		}

		// Token: 0x17005BE4 RID: 23524
		// (get) Token: 0x0601B23D RID: 111165 RVA: 0x003F3224 File Offset: 0x003F1424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BE5 RID: 23525
		// (get) Token: 0x0601B23E RID: 111166 RVA: 0x003F3227 File Offset: 0x003F1427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimePointActivityRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601B23F RID: 111167 RVA: 0x003F322E File Offset: 0x003F142E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityRewardResponse()
		{
		}

		// Token: 0x0601B240 RID: 111168 RVA: 0x003F3236 File Offset: 0x003F1436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityRewardResponse(TimePointActivityRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B241 RID: 111169 RVA: 0x003F325B File Offset: 0x003F145B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityRewardResponse Clone()
		{
			return new TimePointActivityRewardResponse(this);
		}

		// Token: 0x17005BE6 RID: 23526
		// (get) Token: 0x0601B242 RID: 111170 RVA: 0x003F3263 File Offset: 0x003F1463
		// (set) Token: 0x0601B243 RID: 111171 RVA: 0x003F326B File Offset: 0x003F146B
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

		// Token: 0x0601B244 RID: 111172 RVA: 0x003F3274 File Offset: 0x003F1474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimePointActivityRewardResponse);
		}

		// Token: 0x0601B245 RID: 111173 RVA: 0x003F3282 File Offset: 0x003F1482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimePointActivityRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B246 RID: 111174 RVA: 0x003F32B0 File Offset: 0x003F14B0
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

		// Token: 0x0601B247 RID: 111175 RVA: 0x003F32F5 File Offset: 0x003F14F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B248 RID: 111176 RVA: 0x003F3302 File Offset: 0x003F1502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B249 RID: 111177 RVA: 0x003F330B File Offset: 0x003F150B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B24A RID: 111178 RVA: 0x003F3340 File Offset: 0x003F1540
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

		// Token: 0x0601B24B RID: 111179 RVA: 0x003F337E File Offset: 0x003F157E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimePointActivityRewardResponse other)
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

		// Token: 0x0601B24C RID: 111180 RVA: 0x003F33AF File Offset: 0x003F15AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B24D RID: 111181 RVA: 0x003F33B8 File Offset: 0x003F15B8
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009E60 RID: 40544
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E61 RID: 40545
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04009E62 RID: 40546
		private ErrorCode errorCode_;
	}
}

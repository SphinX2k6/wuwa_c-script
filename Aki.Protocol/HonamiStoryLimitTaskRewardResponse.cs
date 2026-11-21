using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000776 RID: 1910
	[NetMessage(EMessageId.HonamiStoryLimitTaskRewardResponse)]
	public sealed class HonamiStoryLimitTaskRewardResponse : IMessage<HonamiStoryLimitTaskRewardResponse>, IMessage, IEquatable<HonamiStoryLimitTaskRewardResponse>, IDeepCloneable<HonamiStoryLimitTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600ACF7 RID: 44279 RVA: 0x001A0302 File Offset: 0x0019E502
		[NullableContext(1)]
		public static HonamiStoryLimitTaskRewardResponse Create()
		{
			return new HonamiStoryLimitTaskRewardResponse();
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x0600ACF8 RID: 44280 RVA: 0x001A0309 File Offset: 0x0019E509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x0600ACF9 RID: 44281 RVA: 0x001A030C File Offset: 0x0019E50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLimitTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600ACFA RID: 44282 RVA: 0x001A0313 File Offset: 0x0019E513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskRewardResponse()
		{
		}

		// Token: 0x0600ACFB RID: 44283 RVA: 0x001A031B File Offset: 0x0019E51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskRewardResponse(HonamiStoryLimitTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACFC RID: 44284 RVA: 0x001A0340 File Offset: 0x0019E540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskRewardResponse Clone()
		{
			return new HonamiStoryLimitTaskRewardResponse(this);
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x0600ACFD RID: 44285 RVA: 0x001A0348 File Offset: 0x0019E548
		// (set) Token: 0x0600ACFE RID: 44286 RVA: 0x001A0350 File Offset: 0x0019E550
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

		// Token: 0x0600ACFF RID: 44287 RVA: 0x001A0359 File Offset: 0x0019E559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLimitTaskRewardResponse);
		}

		// Token: 0x0600AD00 RID: 44288 RVA: 0x001A0367 File Offset: 0x0019E567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLimitTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD01 RID: 44289 RVA: 0x001A0398 File Offset: 0x0019E598
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

		// Token: 0x0600AD02 RID: 44290 RVA: 0x001A03DD File Offset: 0x0019E5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD03 RID: 44291 RVA: 0x001A03EA File Offset: 0x0019E5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD04 RID: 44292 RVA: 0x001A03F3 File Offset: 0x0019E5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD05 RID: 44293 RVA: 0x001A0428 File Offset: 0x0019E628
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

		// Token: 0x0600AD06 RID: 44294 RVA: 0x001A0466 File Offset: 0x0019E666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLimitTaskRewardResponse other)
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

		// Token: 0x0600AD07 RID: 44295 RVA: 0x001A0497 File Offset: 0x0019E697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD08 RID: 44296 RVA: 0x001A04A0 File Offset: 0x0019E6A0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004EAB RID: 20139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EAC RID: 20140
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004EAD RID: 20141
		private ErrorCode errorCode_;
	}
}

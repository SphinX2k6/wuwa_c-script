using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200077B RID: 1915
	[NetMessage(EMessageId.HonamiStoryInstLeaveResponse)]
	public sealed class HonamiStoryInstLeaveResponse : IMessage<HonamiStoryInstLeaveResponse>, IMessage, IEquatable<HonamiStoryInstLeaveResponse>, IDeepCloneable<HonamiStoryInstLeaveResponse>, IBufferMessage
	{
		// Token: 0x0600AD0A RID: 44298 RVA: 0x0019FF12 File Offset: 0x0019E112
		[NullableContext(1)]
		public static HonamiStoryInstLeaveResponse Create()
		{
			return new HonamiStoryInstLeaveResponse();
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x0600AD0B RID: 44299 RVA: 0x0019FF19 File Offset: 0x0019E119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x0600AD0C RID: 44300 RVA: 0x0019FF1C File Offset: 0x0019E11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryInstLeaveResponse.Descriptor;
			}
		}

		// Token: 0x0600AD0D RID: 44301 RVA: 0x0019FF23 File Offset: 0x0019E123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstLeaveResponse()
		{
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x0019FF2B File Offset: 0x0019E12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstLeaveResponse(HonamiStoryInstLeaveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD0F RID: 44303 RVA: 0x0019FF50 File Offset: 0x0019E150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstLeaveResponse Clone()
		{
			return new HonamiStoryInstLeaveResponse(this);
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x0600AD10 RID: 44304 RVA: 0x0019FF58 File Offset: 0x0019E158
		// (set) Token: 0x0600AD11 RID: 44305 RVA: 0x0019FF60 File Offset: 0x0019E160
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

		// Token: 0x0600AD12 RID: 44306 RVA: 0x0019FF69 File Offset: 0x0019E169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryInstLeaveResponse);
		}

		// Token: 0x0600AD13 RID: 44307 RVA: 0x0019FF77 File Offset: 0x0019E177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryInstLeaveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD14 RID: 44308 RVA: 0x0019FFA8 File Offset: 0x0019E1A8
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

		// Token: 0x0600AD15 RID: 44309 RVA: 0x0019FFED File Offset: 0x0019E1ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD16 RID: 44310 RVA: 0x0019FFFA File Offset: 0x0019E1FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD17 RID: 44311 RVA: 0x001A0003 File Offset: 0x0019E203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD18 RID: 44312 RVA: 0x001A0038 File Offset: 0x0019E238
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

		// Token: 0x0600AD19 RID: 44313 RVA: 0x001A0076 File Offset: 0x0019E276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryInstLeaveResponse other)
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

		// Token: 0x0600AD1A RID: 44314 RVA: 0x001A00A7 File Offset: 0x0019E2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD1B RID: 44315 RVA: 0x001A00B0 File Offset: 0x0019E2B0
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004E4C RID: 20044
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E4D RID: 20045
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04004E4E RID: 20046
		private ErrorCode errorCode_;
	}
}

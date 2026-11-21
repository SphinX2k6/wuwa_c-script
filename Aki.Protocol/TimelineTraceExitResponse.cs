using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E5 RID: 5093
	[NetMessage(EMessageId.TimelineTraceExitResponse)]
	public sealed class TimelineTraceExitResponse : IMessage<TimelineTraceExitResponse>, IMessage, IEquatable<TimelineTraceExitResponse>, IDeepCloneable<TimelineTraceExitResponse>, IBufferMessage
	{
		// Token: 0x0601B175 RID: 110965 RVA: 0x003F18D1 File Offset: 0x003EFAD1
		[NullableContext(1)]
		public static TimelineTraceExitResponse Create()
		{
			return new TimelineTraceExitResponse();
		}

		// Token: 0x17005BBC RID: 23484
		// (get) Token: 0x0601B176 RID: 110966 RVA: 0x003F18D8 File Offset: 0x003EFAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BBD RID: 23485
		// (get) Token: 0x0601B177 RID: 110967 RVA: 0x003F18DB File Offset: 0x003EFADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTraceExitResponse.Descriptor;
			}
		}

		// Token: 0x0601B178 RID: 110968 RVA: 0x003F18E2 File Offset: 0x003EFAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceExitResponse()
		{
		}

		// Token: 0x0601B179 RID: 110969 RVA: 0x003F18EA File Offset: 0x003EFAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceExitResponse(TimelineTraceExitResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B17A RID: 110970 RVA: 0x003F190F File Offset: 0x003EFB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceExitResponse Clone()
		{
			return new TimelineTraceExitResponse(this);
		}

		// Token: 0x17005BBE RID: 23486
		// (get) Token: 0x0601B17B RID: 110971 RVA: 0x003F1917 File Offset: 0x003EFB17
		// (set) Token: 0x0601B17C RID: 110972 RVA: 0x003F191F File Offset: 0x003EFB1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0601B17D RID: 110973 RVA: 0x003F1928 File Offset: 0x003EFB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTraceExitResponse);
		}

		// Token: 0x0601B17E RID: 110974 RVA: 0x003F1936 File Offset: 0x003EFB36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTraceExitResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B17F RID: 110975 RVA: 0x003F1964 File Offset: 0x003EFB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B180 RID: 110976 RVA: 0x003F19A9 File Offset: 0x003EFBA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B181 RID: 110977 RVA: 0x003F19B6 File Offset: 0x003EFBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B182 RID: 110978 RVA: 0x003F19BF File Offset: 0x003EFBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B183 RID: 110979 RVA: 0x003F19F4 File Offset: 0x003EFBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B184 RID: 110980 RVA: 0x003F1A32 File Offset: 0x003EFC32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimelineTraceExitResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B185 RID: 110981 RVA: 0x003F1A63 File Offset: 0x003EFC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B186 RID: 110982 RVA: 0x003F1A6C File Offset: 0x003EFC6C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009E2B RID: 40491
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E2C RID: 40492
		public const int CodeFieldNumber = 6;

		// Token: 0x04009E2D RID: 40493
		private ErrorCode code_;
	}
}

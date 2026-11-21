using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000767 RID: 1895
	[NetMessage(EMessageId.HonamiStoryInstLeaveResponse)]
	public sealed class HonamiStoryInstLeaveResponse : IMessage<HonamiStoryInstLeaveResponse>, IMessage, IEquatable<HonamiStoryInstLeaveResponse>, IDeepCloneable<HonamiStoryInstLeaveResponse>, IBufferMessage
	{
		// Token: 0x0600ABB4 RID: 43956 RVA: 0x0019D4EA File Offset: 0x0019B6EA
		[NullableContext(1)]
		public static HonamiStoryInstLeaveResponse Create()
		{
			return new HonamiStoryInstLeaveResponse();
		}

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x0600ABB5 RID: 43957 RVA: 0x0019D4F1 File Offset: 0x0019B6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x0600ABB6 RID: 43958 RVA: 0x0019D4F4 File Offset: 0x0019B6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryInstLeaveResponse.Descriptor;
			}
		}

		// Token: 0x0600ABB7 RID: 43959 RVA: 0x0019D4FB File Offset: 0x0019B6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstLeaveResponse()
		{
		}

		// Token: 0x0600ABB8 RID: 43960 RVA: 0x0019D503 File Offset: 0x0019B703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstLeaveResponse(HonamiStoryInstLeaveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABB9 RID: 43961 RVA: 0x0019D528 File Offset: 0x0019B728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstLeaveResponse Clone()
		{
			return new HonamiStoryInstLeaveResponse(this);
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x0600ABBA RID: 43962 RVA: 0x0019D530 File Offset: 0x0019B730
		// (set) Token: 0x0600ABBB RID: 43963 RVA: 0x0019D538 File Offset: 0x0019B738
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

		// Token: 0x0600ABBC RID: 43964 RVA: 0x0019D541 File Offset: 0x0019B741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryInstLeaveResponse);
		}

		// Token: 0x0600ABBD RID: 43965 RVA: 0x0019D54F File Offset: 0x0019B74F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryInstLeaveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ABBE RID: 43966 RVA: 0x0019D580 File Offset: 0x0019B780
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

		// Token: 0x0600ABBF RID: 43967 RVA: 0x0019D5C5 File Offset: 0x0019B7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x0019D5D2 File Offset: 0x0019B7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABC1 RID: 43969 RVA: 0x0019D5DB File Offset: 0x0019B7DB
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

		// Token: 0x0600ABC2 RID: 43970 RVA: 0x0019D610 File Offset: 0x0019B810
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

		// Token: 0x0600ABC3 RID: 43971 RVA: 0x0019D64E File Offset: 0x0019B84E
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

		// Token: 0x0600ABC4 RID: 43972 RVA: 0x0019D67F File Offset: 0x0019B87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABC5 RID: 43973 RVA: 0x0019D688 File Offset: 0x0019B888
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

		// Token: 0x04004E45 RID: 20037
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E46 RID: 20038
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004E47 RID: 20039
		private ErrorCode errorCode_;
	}
}

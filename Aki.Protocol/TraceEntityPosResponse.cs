using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001444 RID: 5188
	[NetMessage(EMessageId.TraceEntityPosResponse)]
	public sealed class TraceEntityPosResponse : IMessage<TraceEntityPosResponse>, IMessage, IEquatable<TraceEntityPosResponse>, IDeepCloneable<TraceEntityPosResponse>, IBufferMessage
	{
		// Token: 0x0601B904 RID: 112900 RVA: 0x00401878 File Offset: 0x003FFA78
		[NullableContext(1)]
		public static TraceEntityPosResponse Create()
		{
			return new TraceEntityPosResponse();
		}

		// Token: 0x17005D50 RID: 23888
		// (get) Token: 0x0601B905 RID: 112901 RVA: 0x0040187F File Offset: 0x003FFA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D51 RID: 23889
		// (get) Token: 0x0601B906 RID: 112902 RVA: 0x00401882 File Offset: 0x003FFA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceEntityPosResponse.Descriptor;
			}
		}

		// Token: 0x0601B907 RID: 112903 RVA: 0x00401889 File Offset: 0x003FFA89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceEntityPosResponse()
		{
		}

		// Token: 0x0601B908 RID: 112904 RVA: 0x00401894 File Offset: 0x003FFA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceEntityPosResponse(TraceEntityPosResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B909 RID: 112905 RVA: 0x004018E0 File Offset: 0x003FFAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceEntityPosResponse Clone()
		{
			return new TraceEntityPosResponse(this);
		}

		// Token: 0x17005D52 RID: 23890
		// (get) Token: 0x0601B90A RID: 112906 RVA: 0x004018E8 File Offset: 0x003FFAE8
		// (set) Token: 0x0601B90B RID: 112907 RVA: 0x004018F0 File Offset: 0x003FFAF0
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

		// Token: 0x17005D53 RID: 23891
		// (get) Token: 0x0601B90C RID: 112908 RVA: 0x004018F9 File Offset: 0x003FFAF9
		// (set) Token: 0x0601B90D RID: 112909 RVA: 0x00401901 File Offset: 0x003FFB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x0601B90E RID: 112910 RVA: 0x0040190A File Offset: 0x003FFB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceEntityPosResponse);
		}

		// Token: 0x0601B90F RID: 112911 RVA: 0x00401918 File Offset: 0x003FFB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceEntityPosResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B910 RID: 112912 RVA: 0x00401968 File Offset: 0x003FFB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B911 RID: 112913 RVA: 0x004019C3 File Offset: 0x003FFBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B912 RID: 112914 RVA: 0x004019D0 File Offset: 0x003FFBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B913 RID: 112915 RVA: 0x004019DC File Offset: 0x003FFBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Pos);
			}
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

		// Token: 0x0601B914 RID: 112916 RVA: 0x00401A38 File Offset: 0x003FFC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B915 RID: 112917 RVA: 0x00401A90 File Offset: 0x003FFC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceEntityPosResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B916 RID: 112918 RVA: 0x00401AF8 File Offset: 0x003FFCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B917 RID: 112919 RVA: 0x00401B04 File Offset: 0x003FFD04
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
				if (num != 42U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.pos_ == null)
					{
						this.Pos = new Vector();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x0400A04F RID: 41039
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A050 RID: 41040
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400A051 RID: 41041
		private ErrorCode errorCode_;

		// Token: 0x0400A052 RID: 41042
		public const int PosFieldNumber = 5;

		// Token: 0x0400A053 RID: 41043
		private Vector pos_;
	}
}

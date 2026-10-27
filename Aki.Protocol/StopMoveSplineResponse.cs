using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001296 RID: 4758
	[NetMessage(EMessageId.StopMoveSplineResponse)]
	public sealed class StopMoveSplineResponse : IMessage<StopMoveSplineResponse>, IMessage, IEquatable<StopMoveSplineResponse>, IDeepCloneable<StopMoveSplineResponse>, IBufferMessage
	{
		// Token: 0x06019552 RID: 103762 RVA: 0x003AF01F File Offset: 0x003AD21F
		[NullableContext(1)]
		public static StopMoveSplineResponse Create()
		{
			return new StopMoveSplineResponse();
		}

		// Token: 0x17005573 RID: 21875
		// (get) Token: 0x06019553 RID: 103763 RVA: 0x003AF026 File Offset: 0x003AD226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005574 RID: 21876
		// (get) Token: 0x06019554 RID: 103764 RVA: 0x003AF029 File Offset: 0x003AD229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StopMoveSplineResponse.Descriptor;
			}
		}

		// Token: 0x06019555 RID: 103765 RVA: 0x003AF030 File Offset: 0x003AD230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopMoveSplineResponse()
		{
		}

		// Token: 0x06019556 RID: 103766 RVA: 0x003AF038 File Offset: 0x003AD238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopMoveSplineResponse(StopMoveSplineResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019557 RID: 103767 RVA: 0x003AF05D File Offset: 0x003AD25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopMoveSplineResponse Clone()
		{
			return new StopMoveSplineResponse(this);
		}

		// Token: 0x17005575 RID: 21877
		// (get) Token: 0x06019558 RID: 103768 RVA: 0x003AF065 File Offset: 0x003AD265
		// (set) Token: 0x06019559 RID: 103769 RVA: 0x003AF06D File Offset: 0x003AD26D
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

		// Token: 0x0601955A RID: 103770 RVA: 0x003AF076 File Offset: 0x003AD276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StopMoveSplineResponse);
		}

		// Token: 0x0601955B RID: 103771 RVA: 0x003AF084 File Offset: 0x003AD284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StopMoveSplineResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601955C RID: 103772 RVA: 0x003AF0B4 File Offset: 0x003AD2B4
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

		// Token: 0x0601955D RID: 103773 RVA: 0x003AF0F9 File Offset: 0x003AD2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601955E RID: 103774 RVA: 0x003AF106 File Offset: 0x003AD306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601955F RID: 103775 RVA: 0x003AF10F File Offset: 0x003AD30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019560 RID: 103776 RVA: 0x003AF144 File Offset: 0x003AD344
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

		// Token: 0x06019561 RID: 103777 RVA: 0x003AF182 File Offset: 0x003AD382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StopMoveSplineResponse other)
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

		// Token: 0x06019562 RID: 103778 RVA: 0x003AF1B3 File Offset: 0x003AD3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019563 RID: 103779 RVA: 0x003AF1BC File Offset: 0x003AD3BC
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040094E1 RID: 38113
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094E2 RID: 38114
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040094E3 RID: 38115
		private ErrorCode errorCode_;
	}
}

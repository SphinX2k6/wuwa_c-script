using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200110E RID: 4366
	[NetMessage(EMessageId.RoverRogueLootChangeResponse)]
	public sealed class RoverRogueLootChangeResponse : IMessage<RoverRogueLootChangeResponse>, IMessage, IEquatable<RoverRogueLootChangeResponse>, IDeepCloneable<RoverRogueLootChangeResponse>, IBufferMessage
	{
		// Token: 0x06017496 RID: 95382 RVA: 0x003619F3 File Offset: 0x0035FBF3
		[NullableContext(1)]
		public static RoverRogueLootChangeResponse Create()
		{
			return new RoverRogueLootChangeResponse();
		}

		// Token: 0x17004E18 RID: 19992
		// (get) Token: 0x06017497 RID: 95383 RVA: 0x003619FA File Offset: 0x0035FBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E19 RID: 19993
		// (get) Token: 0x06017498 RID: 95384 RVA: 0x003619FD File Offset: 0x0035FBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootChangeResponse.Descriptor;
			}
		}

		// Token: 0x06017499 RID: 95385 RVA: 0x00361A04 File Offset: 0x0035FC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeResponse()
		{
		}

		// Token: 0x0601749A RID: 95386 RVA: 0x00361A0C File Offset: 0x0035FC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeResponse(RoverRogueLootChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601749B RID: 95387 RVA: 0x00361A31 File Offset: 0x0035FC31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeResponse Clone()
		{
			return new RoverRogueLootChangeResponse(this);
		}

		// Token: 0x17004E1A RID: 19994
		// (get) Token: 0x0601749C RID: 95388 RVA: 0x00361A39 File Offset: 0x0035FC39
		// (set) Token: 0x0601749D RID: 95389 RVA: 0x00361A41 File Offset: 0x0035FC41
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

		// Token: 0x0601749E RID: 95390 RVA: 0x00361A4A File Offset: 0x0035FC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootChangeResponse);
		}

		// Token: 0x0601749F RID: 95391 RVA: 0x00361A58 File Offset: 0x0035FC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060174A0 RID: 95392 RVA: 0x00361A88 File Offset: 0x0035FC88
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

		// Token: 0x060174A1 RID: 95393 RVA: 0x00361ACD File Offset: 0x0035FCCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060174A2 RID: 95394 RVA: 0x00361ADA File Offset: 0x0035FCDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060174A3 RID: 95395 RVA: 0x00361AE3 File Offset: 0x0035FCE3
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

		// Token: 0x060174A4 RID: 95396 RVA: 0x00361B18 File Offset: 0x0035FD18
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

		// Token: 0x060174A5 RID: 95397 RVA: 0x00361B56 File Offset: 0x0035FD56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueLootChangeResponse other)
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

		// Token: 0x060174A6 RID: 95398 RVA: 0x00361B87 File Offset: 0x0035FD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060174A7 RID: 95399 RVA: 0x00361B90 File Offset: 0x0035FD90
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

		// Token: 0x04008A88 RID: 35464
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A89 RID: 35465
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04008A8A RID: 35466
		private ErrorCode errorCode_;
	}
}

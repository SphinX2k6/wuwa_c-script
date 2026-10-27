using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001414 RID: 5140
	[NetMessage(EMessageId.TrapDefenseBuildingResetResponse)]
	public sealed class TrapDefenseBuildingResetResponse : IMessage<TrapDefenseBuildingResetResponse>, IMessage, IEquatable<TrapDefenseBuildingResetResponse>, IDeepCloneable<TrapDefenseBuildingResetResponse>, IBufferMessage
	{
		// Token: 0x0601B3E9 RID: 111593 RVA: 0x003F2A61 File Offset: 0x003F0C61
		[NullableContext(1)]
		public static TrapDefenseBuildingResetResponse Create()
		{
			return new TrapDefenseBuildingResetResponse();
		}

		// Token: 0x17005BE4 RID: 23524
		// (get) Token: 0x0601B3EA RID: 111594 RVA: 0x003F2A68 File Offset: 0x003F0C68
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
		// (get) Token: 0x0601B3EB RID: 111595 RVA: 0x003F2A6B File Offset: 0x003F0C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingResetResponse.Descriptor;
			}
		}

		// Token: 0x0601B3EC RID: 111596 RVA: 0x003F2A72 File Offset: 0x003F0C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingResetResponse()
		{
		}

		// Token: 0x0601B3ED RID: 111597 RVA: 0x003F2A7A File Offset: 0x003F0C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingResetResponse(TrapDefenseBuildingResetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3EE RID: 111598 RVA: 0x003F2A9F File Offset: 0x003F0C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingResetResponse Clone()
		{
			return new TrapDefenseBuildingResetResponse(this);
		}

		// Token: 0x17005BE6 RID: 23526
		// (get) Token: 0x0601B3EF RID: 111599 RVA: 0x003F2AA7 File Offset: 0x003F0CA7
		// (set) Token: 0x0601B3F0 RID: 111600 RVA: 0x003F2AAF File Offset: 0x003F0CAF
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

		// Token: 0x0601B3F1 RID: 111601 RVA: 0x003F2AB8 File Offset: 0x003F0CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingResetResponse);
		}

		// Token: 0x0601B3F2 RID: 111602 RVA: 0x003F2AC6 File Offset: 0x003F0CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingResetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B3F3 RID: 111603 RVA: 0x003F2AF4 File Offset: 0x003F0CF4
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

		// Token: 0x0601B3F4 RID: 111604 RVA: 0x003F2B39 File Offset: 0x003F0D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B3F5 RID: 111605 RVA: 0x003F2B46 File Offset: 0x003F0D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B3F6 RID: 111606 RVA: 0x003F2B4F File Offset: 0x003F0D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B3F7 RID: 111607 RVA: 0x003F2B84 File Offset: 0x003F0D84
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

		// Token: 0x0601B3F8 RID: 111608 RVA: 0x003F2BC2 File Offset: 0x003F0DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuildingResetResponse other)
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

		// Token: 0x0601B3F9 RID: 111609 RVA: 0x003F2BF3 File Offset: 0x003F0DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B3FA RID: 111610 RVA: 0x003F2BFC File Offset: 0x003F0DFC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009D90 RID: 40336
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D91 RID: 40337
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04009D92 RID: 40338
		private ErrorCode errorCode_;
	}
}

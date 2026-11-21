using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005FB RID: 1531
	[NetMessage(EMessageId.FlySkinUnLoadResponse)]
	public sealed class FlySkinUnLoadResponse : IMessage<FlySkinUnLoadResponse>, IMessage, IEquatable<FlySkinUnLoadResponse>, IDeepCloneable<FlySkinUnLoadResponse>, IBufferMessage
	{
		// Token: 0x06008E02 RID: 36354 RVA: 0x00158AE8 File Offset: 0x00156CE8
		[NullableContext(1)]
		public static FlySkinUnLoadResponse Create()
		{
			return new FlySkinUnLoadResponse();
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06008E03 RID: 36355 RVA: 0x00158AEF File Offset: 0x00156CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06008E04 RID: 36356 RVA: 0x00158AF2 File Offset: 0x00156CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinUnLoadResponse.Descriptor;
			}
		}

		// Token: 0x06008E05 RID: 36357 RVA: 0x00158AF9 File Offset: 0x00156CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinUnLoadResponse()
		{
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x00158B01 File Offset: 0x00156D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinUnLoadResponse(FlySkinUnLoadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E07 RID: 36359 RVA: 0x00158B26 File Offset: 0x00156D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinUnLoadResponse Clone()
		{
			return new FlySkinUnLoadResponse(this);
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06008E08 RID: 36360 RVA: 0x00158B2E File Offset: 0x00156D2E
		// (set) Token: 0x06008E09 RID: 36361 RVA: 0x00158B36 File Offset: 0x00156D36
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

		// Token: 0x06008E0A RID: 36362 RVA: 0x00158B3F File Offset: 0x00156D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinUnLoadResponse);
		}

		// Token: 0x06008E0B RID: 36363 RVA: 0x00158B4D File Offset: 0x00156D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinUnLoadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E0C RID: 36364 RVA: 0x00158B7C File Offset: 0x00156D7C
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

		// Token: 0x06008E0D RID: 36365 RVA: 0x00158BC1 File Offset: 0x00156DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E0E RID: 36366 RVA: 0x00158BCE File Offset: 0x00156DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E0F RID: 36367 RVA: 0x00158BD7 File Offset: 0x00156DD7
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

		// Token: 0x06008E10 RID: 36368 RVA: 0x00158C0C File Offset: 0x00156E0C
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

		// Token: 0x06008E11 RID: 36369 RVA: 0x00158C4A File Offset: 0x00156E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinUnLoadResponse other)
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

		// Token: 0x06008E12 RID: 36370 RVA: 0x00158C7B File Offset: 0x00156E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E13 RID: 36371 RVA: 0x00158C84 File Offset: 0x00156E84
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

		// Token: 0x0400459A RID: 17818
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400459B RID: 17819
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400459C RID: 17820
		private ErrorCode errorCode_;
	}
}

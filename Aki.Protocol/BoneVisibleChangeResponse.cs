using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001BD RID: 445
	[NetMessage(EMessageId.BoneVisibleChangeResponse)]
	public sealed class BoneVisibleChangeResponse : IMessage<BoneVisibleChangeResponse>, IMessage, IEquatable<BoneVisibleChangeResponse>, IDeepCloneable<BoneVisibleChangeResponse>, IBufferMessage
	{
		// Token: 0x0600335C RID: 13148 RVA: 0x0008203C File Offset: 0x0008023C
		[NullableContext(1)]
		public static BoneVisibleChangeResponse Create()
		{
			return new BoneVisibleChangeResponse();
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600335D RID: 13149 RVA: 0x00082043 File Offset: 0x00080243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x0600335E RID: 13150 RVA: 0x00082046 File Offset: 0x00080246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoneVisibleChangeResponse.Descriptor;
			}
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x0008204D File Offset: 0x0008024D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeResponse()
		{
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x00082055 File Offset: 0x00080255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeResponse(BoneVisibleChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x0008207A File Offset: 0x0008027A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeResponse Clone()
		{
			return new BoneVisibleChangeResponse(this);
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06003362 RID: 13154 RVA: 0x00082082 File Offset: 0x00080282
		// (set) Token: 0x06003363 RID: 13155 RVA: 0x0008208A File Offset: 0x0008028A
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

		// Token: 0x06003364 RID: 13156 RVA: 0x00082093 File Offset: 0x00080293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoneVisibleChangeResponse);
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x000820A1 File Offset: 0x000802A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoneVisibleChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x000820D0 File Offset: 0x000802D0
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

		// Token: 0x06003367 RID: 13159 RVA: 0x00082115 File Offset: 0x00080315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x00082122 File Offset: 0x00080322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x0008212B File Offset: 0x0008032B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x00082160 File Offset: 0x00080360
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

		// Token: 0x0600336B RID: 13163 RVA: 0x0008219E File Offset: 0x0008039E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoneVisibleChangeResponse other)
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

		// Token: 0x0600336C RID: 13164 RVA: 0x000821CF File Offset: 0x000803CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x000821D8 File Offset: 0x000803D8
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040029B5 RID: 10677
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029B6 RID: 10678
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040029B7 RID: 10679
		private ErrorCode errorCode_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C3 RID: 4291
	[NetMessage(EMessageId.RoleTowerConsumeItemRequest)]
	public sealed class RoleTowerConsumeItemRequest : IMessage<RoleTowerConsumeItemRequest>, IMessage, IEquatable<RoleTowerConsumeItemRequest>, IDeepCloneable<RoleTowerConsumeItemRequest>, IBufferMessage
	{
		// Token: 0x06016EFB RID: 93947 RVA: 0x00355EED File Offset: 0x003540ED
		[NullableContext(1)]
		public static RoleTowerConsumeItemRequest Create()
		{
			return new RoleTowerConsumeItemRequest();
		}

		// Token: 0x17004CED RID: 19693
		// (get) Token: 0x06016EFC RID: 93948 RVA: 0x00355EF4 File Offset: 0x003540F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CEE RID: 19694
		// (get) Token: 0x06016EFD RID: 93949 RVA: 0x00355EF7 File Offset: 0x003540F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerConsumeItemRequest.Descriptor;
			}
		}

		// Token: 0x06016EFE RID: 93950 RVA: 0x00355EFE File Offset: 0x003540FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerConsumeItemRequest()
		{
		}

		// Token: 0x06016EFF RID: 93951 RVA: 0x00355F06 File Offset: 0x00354106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerConsumeItemRequest(RoleTowerConsumeItemRequest other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F00 RID: 93952 RVA: 0x00355F2B File Offset: 0x0035412B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerConsumeItemRequest Clone()
		{
			return new RoleTowerConsumeItemRequest(this);
		}

		// Token: 0x17004CEF RID: 19695
		// (get) Token: 0x06016F01 RID: 93953 RVA: 0x00355F33 File Offset: 0x00354133
		// (set) Token: 0x06016F02 RID: 93954 RVA: 0x00355F3B File Offset: 0x0035413B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x06016F03 RID: 93955 RVA: 0x00355F44 File Offset: 0x00354144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerConsumeItemRequest);
		}

		// Token: 0x06016F04 RID: 93956 RVA: 0x00355F52 File Offset: 0x00354152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerConsumeItemRequest other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016F05 RID: 93957 RVA: 0x00355F80 File Offset: 0x00354180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016F06 RID: 93958 RVA: 0x00355FBF File Offset: 0x003541BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F07 RID: 93959 RVA: 0x00355FCC File Offset: 0x003541CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F08 RID: 93960 RVA: 0x00355FD5 File Offset: 0x003541D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016F09 RID: 93961 RVA: 0x00356008 File Offset: 0x00354208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016F0A RID: 93962 RVA: 0x00356046 File Offset: 0x00354246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerConsumeItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016F0B RID: 93963 RVA: 0x00356077 File Offset: 0x00354277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F0C RID: 93964 RVA: 0x00356080 File Offset: 0x00354280
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400894D RID: 35149
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400894E RID: 35150
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400894F RID: 35151
		private int itemId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001525 RID: 5413
	[NetMessage(EMessageId.WuWuPackageRewardRequest)]
	public sealed class WuWuPackageRewardRequest : IMessage<WuWuPackageRewardRequest>, IMessage, IEquatable<WuWuPackageRewardRequest>, IDeepCloneable<WuWuPackageRewardRequest>, IBufferMessage
	{
		// Token: 0x0601C9B9 RID: 117177 RVA: 0x00421B43 File Offset: 0x0041FD43
		[NullableContext(1)]
		public static WuWuPackageRewardRequest Create()
		{
			return new WuWuPackageRewardRequest();
		}

		// Token: 0x17006075 RID: 24693
		// (get) Token: 0x0601C9BA RID: 117178 RVA: 0x00421B4A File Offset: 0x0041FD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006076 RID: 24694
		// (get) Token: 0x0601C9BB RID: 117179 RVA: 0x00421B4D File Offset: 0x0041FD4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuPackageRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601C9BC RID: 117180 RVA: 0x00421B54 File Offset: 0x0041FD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuPackageRewardRequest()
		{
		}

		// Token: 0x0601C9BD RID: 117181 RVA: 0x00421B5C File Offset: 0x0041FD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuPackageRewardRequest(WuWuPackageRewardRequest other) : this()
		{
			this.wrapId_ = other.wrapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C9BE RID: 117182 RVA: 0x00421B81 File Offset: 0x0041FD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuPackageRewardRequest Clone()
		{
			return new WuWuPackageRewardRequest(this);
		}

		// Token: 0x17006077 RID: 24695
		// (get) Token: 0x0601C9BF RID: 117183 RVA: 0x00421B89 File Offset: 0x0041FD89
		// (set) Token: 0x0601C9C0 RID: 117184 RVA: 0x00421B91 File Offset: 0x0041FD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WrapId
		{
			get
			{
				return this.wrapId_;
			}
			set
			{
				this.wrapId_ = value;
			}
		}

		// Token: 0x0601C9C1 RID: 117185 RVA: 0x00421B9A File Offset: 0x0041FD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuPackageRewardRequest);
		}

		// Token: 0x0601C9C2 RID: 117186 RVA: 0x00421BA8 File Offset: 0x0041FDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuPackageRewardRequest other)
		{
			return other != null && (other == this || (this.WrapId == other.WrapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C9C3 RID: 117187 RVA: 0x00421BD8 File Offset: 0x0041FDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WrapId != 0)
			{
				num ^= this.WrapId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C9C4 RID: 117188 RVA: 0x00421C17 File Offset: 0x0041FE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C9C5 RID: 117189 RVA: 0x00421C24 File Offset: 0x0041FE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C9C6 RID: 117190 RVA: 0x00421C2D File Offset: 0x0041FE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WrapId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.WrapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C9C7 RID: 117191 RVA: 0x00421C60 File Offset: 0x0041FE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WrapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WrapId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C9C8 RID: 117192 RVA: 0x00421C9E File Offset: 0x0041FE9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuPackageRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WrapId != 0)
			{
				this.WrapId = other.WrapId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C9C9 RID: 117193 RVA: 0x00421CCF File Offset: 0x0041FECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C9CA RID: 117194 RVA: 0x00421CD8 File Offset: 0x0041FED8
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
					this.WrapId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A39F RID: 41887
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3A0 RID: 41888
		public const int WrapIdFieldNumber = 15;

		// Token: 0x0400A3A1 RID: 41889
		private int wrapId_;
	}
}

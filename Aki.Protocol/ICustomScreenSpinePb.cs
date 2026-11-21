using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007AC RID: 1964
	public sealed class ICustomScreenSpinePb : IMessage<ICustomScreenSpinePb>, IMessage, IEquatable<ICustomScreenSpinePb>, IDeepCloneable<ICustomScreenSpinePb>, IBufferMessage
	{
		// Token: 0x0600B125 RID: 45349 RVA: 0x001A8AB6 File Offset: 0x001A6CB6
		[NullableContext(1)]
		public static ICustomScreenSpinePb Create()
		{
			return new ICustomScreenSpinePb();
		}

		// Token: 0x170023B5 RID: 9141
		// (get) Token: 0x0600B126 RID: 45350 RVA: 0x001A8ABD File Offset: 0x001A6CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x0600B127 RID: 45351 RVA: 0x001A8AC0 File Offset: 0x001A6CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomScreenSpinePb.Descriptor;
			}
		}

		// Token: 0x0600B128 RID: 45352 RVA: 0x001A8AC7 File Offset: 0x001A6CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenSpinePb()
		{
		}

		// Token: 0x0600B129 RID: 45353 RVA: 0x001A8ACF File Offset: 0x001A6CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenSpinePb(ICustomScreenSpinePb other) : this()
		{
			this.spineId_ = other.spineId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B12A RID: 45354 RVA: 0x001A8AF4 File Offset: 0x001A6CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenSpinePb Clone()
		{
			return new ICustomScreenSpinePb(this);
		}

		// Token: 0x170023B7 RID: 9143
		// (get) Token: 0x0600B12B RID: 45355 RVA: 0x001A8AFC File Offset: 0x001A6CFC
		// (set) Token: 0x0600B12C RID: 45356 RVA: 0x001A8B04 File Offset: 0x001A6D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpineId
		{
			get
			{
				return this.spineId_;
			}
			set
			{
				this.spineId_ = value;
			}
		}

		// Token: 0x0600B12D RID: 45357 RVA: 0x001A8B0D File Offset: 0x001A6D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomScreenSpinePb);
		}

		// Token: 0x0600B12E RID: 45358 RVA: 0x001A8B1B File Offset: 0x001A6D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomScreenSpinePb other)
		{
			return other != null && (other == this || (this.SpineId == other.SpineId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B12F RID: 45359 RVA: 0x001A8B4C File Offset: 0x001A6D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SpineId != 0)
			{
				num ^= this.SpineId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B130 RID: 45360 RVA: 0x001A8B8B File Offset: 0x001A6D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B131 RID: 45361 RVA: 0x001A8B98 File Offset: 0x001A6D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B132 RID: 45362 RVA: 0x001A8BA1 File Offset: 0x001A6DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SpineId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SpineId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B133 RID: 45363 RVA: 0x001A8BD4 File Offset: 0x001A6DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SpineId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpineId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B134 RID: 45364 RVA: 0x001A8C12 File Offset: 0x001A6E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ICustomScreenSpinePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SpineId != 0)
			{
				this.SpineId = other.SpineId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B135 RID: 45365 RVA: 0x001A8C43 File Offset: 0x001A6E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B136 RID: 45366 RVA: 0x001A8C4C File Offset: 0x001A6E4C
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
					this.SpineId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004FBC RID: 20412
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FBD RID: 20413
		public const int SpineIdFieldNumber = 1;

		// Token: 0x04004FBE RID: 20414
		private int spineId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000701 RID: 1793
	[NetMessage(EMessageId.GmLevelActionResponse)]
	public sealed class GmLevelActionResponse : IMessage<GmLevelActionResponse>, IMessage, IEquatable<GmLevelActionResponse>, IDeepCloneable<GmLevelActionResponse>, IBufferMessage
	{
		// Token: 0x0600A338 RID: 41784 RVA: 0x0018A60D File Offset: 0x0018880D
		[NullableContext(1)]
		public static GmLevelActionResponse Create()
		{
			return new GmLevelActionResponse();
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x0600A339 RID: 41785 RVA: 0x0018A614 File Offset: 0x00188814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x0600A33A RID: 41786 RVA: 0x0018A617 File Offset: 0x00188817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmLevelActionResponse.Descriptor;
			}
		}

		// Token: 0x0600A33B RID: 41787 RVA: 0x0018A61E File Offset: 0x0018881E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionResponse()
		{
		}

		// Token: 0x0600A33C RID: 41788 RVA: 0x0018A626 File Offset: 0x00188826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionResponse(GmLevelActionResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A33D RID: 41789 RVA: 0x0018A64B File Offset: 0x0018884B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionResponse Clone()
		{
			return new GmLevelActionResponse(this);
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x0600A33E RID: 41790 RVA: 0x0018A653 File Offset: 0x00188853
		// (set) Token: 0x0600A33F RID: 41791 RVA: 0x0018A65B File Offset: 0x0018885B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0600A340 RID: 41792 RVA: 0x0018A664 File Offset: 0x00188864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmLevelActionResponse);
		}

		// Token: 0x0600A341 RID: 41793 RVA: 0x0018A672 File Offset: 0x00188872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmLevelActionResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A342 RID: 41794 RVA: 0x0018A6A0 File Offset: 0x001888A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A343 RID: 41795 RVA: 0x0018A6E5 File Offset: 0x001888E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A344 RID: 41796 RVA: 0x0018A6F2 File Offset: 0x001888F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A345 RID: 41797 RVA: 0x0018A6FB File Offset: 0x001888FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A346 RID: 41798 RVA: 0x0018A730 File Offset: 0x00188930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A347 RID: 41799 RVA: 0x0018A76E File Offset: 0x0018896E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmLevelActionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A348 RID: 41800 RVA: 0x0018A79F File Offset: 0x0018899F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A349 RID: 41801 RVA: 0x0018A7A8 File Offset: 0x001889A8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004B79 RID: 19321
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B7A RID: 19322
		public const int CodeFieldNumber = 11;

		// Token: 0x04004B7B RID: 19323
		private ErrorCode code_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200023C RID: 572
	[NetMessage(EMessageId.CaptureEntityRequest)]
	public sealed class CaptureEntityRequest : IMessage<CaptureEntityRequest>, IMessage, IEquatable<CaptureEntityRequest>, IDeepCloneable<CaptureEntityRequest>, IBufferMessage
	{
		// Token: 0x06003DDC RID: 15836 RVA: 0x000996E8 File Offset: 0x000978E8
		[NullableContext(1)]
		public static CaptureEntityRequest Create()
		{
			return new CaptureEntityRequest();
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06003DDD RID: 15837 RVA: 0x000996EF File Offset: 0x000978EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06003DDE RID: 15838 RVA: 0x000996F2 File Offset: 0x000978F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaptureEntityRequest.Descriptor;
			}
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x000996F9 File Offset: 0x000978F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureEntityRequest()
		{
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x00099701 File Offset: 0x00097901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureEntityRequest(CaptureEntityRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x00099726 File Offset: 0x00097926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureEntityRequest Clone()
		{
			return new CaptureEntityRequest(this);
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06003DE2 RID: 15842 RVA: 0x0009972E File Offset: 0x0009792E
		// (set) Token: 0x06003DE3 RID: 15843 RVA: 0x00099736 File Offset: 0x00097936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x0009973F File Offset: 0x0009793F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaptureEntityRequest);
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x0009974D File Offset: 0x0009794D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaptureEntityRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x0009977C File Offset: 0x0009797C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x000997BB File Offset: 0x000979BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x000997C8 File Offset: 0x000979C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x000997D1 File Offset: 0x000979D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x00099804 File Offset: 0x00097A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x00099842 File Offset: 0x00097A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaptureEntityRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x00099873 File Offset: 0x00097A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x0009987C File Offset: 0x00097A7C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002D1E RID: 11550
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D1F RID: 11551
		public const int IdFieldNumber = 3;

		// Token: 0x04002D20 RID: 11552
		private long id_;
	}
}

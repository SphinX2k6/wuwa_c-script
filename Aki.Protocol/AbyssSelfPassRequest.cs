using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000048 RID: 72
	[NetMessage(EMessageId.AbyssSelfPassRequest)]
	public sealed class AbyssSelfPassRequest : IMessage<AbyssSelfPassRequest>, IMessage, IEquatable<AbyssSelfPassRequest>, IDeepCloneable<AbyssSelfPassRequest>, IBufferMessage
	{
		// Token: 0x06001430 RID: 5168 RVA: 0x00036401 File Offset: 0x00034601
		[NullableContext(1)]
		public static AbyssSelfPassRequest Create()
		{
			return new AbyssSelfPassRequest();
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x00036408 File Offset: 0x00034608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x0003640B File Offset: 0x0003460B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssSelfPassRequest.Descriptor;
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00036412 File Offset: 0x00034612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssSelfPassRequest()
		{
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0003641A File Offset: 0x0003461A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssSelfPassRequest(AbyssSelfPassRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0003643F File Offset: 0x0003463F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssSelfPassRequest Clone()
		{
			return new AbyssSelfPassRequest(this);
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x00036447 File Offset: 0x00034647
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x0003644F File Offset: 0x0003464F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x06001438 RID: 5176 RVA: 0x00036458 File Offset: 0x00034658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssSelfPassRequest);
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00036466 File Offset: 0x00034666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssSelfPassRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00036494 File Offset: 0x00034694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000364D3 File Offset: 0x000346D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x000364E0 File Offset: 0x000346E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x000364E9 File Offset: 0x000346E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0003651C File Offset: 0x0003471C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0003655A File Offset: 0x0003475A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssSelfPassRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0003658B File Offset: 0x0003478B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00036594 File Offset: 0x00034794
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002047 RID: 8263
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002048 RID: 8264
		public const int IdFieldNumber = 8;

		// Token: 0x04002049 RID: 8265
		private int id_;
	}
}

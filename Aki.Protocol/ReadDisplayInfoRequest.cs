using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E98 RID: 3736
	[NetMessage(EMessageId.ReadDisplayInfoRequest)]
	public sealed class ReadDisplayInfoRequest : IMessage<ReadDisplayInfoRequest>, IMessage, IEquatable<ReadDisplayInfoRequest>, IDeepCloneable<ReadDisplayInfoRequest>, IBufferMessage
	{
		// Token: 0x060140EE RID: 82158 RVA: 0x002EB901 File Offset: 0x002E9B01
		[NullableContext(1)]
		public static ReadDisplayInfoRequest Create()
		{
			return new ReadDisplayInfoRequest();
		}

		// Token: 0x170042B7 RID: 17079
		// (get) Token: 0x060140EF RID: 82159 RVA: 0x002EB908 File Offset: 0x002E9B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042B8 RID: 17080
		// (get) Token: 0x060140F0 RID: 82160 RVA: 0x002EB90B File Offset: 0x002E9B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReadDisplayInfoRequest.Descriptor;
			}
		}

		// Token: 0x060140F1 RID: 82161 RVA: 0x002EB912 File Offset: 0x002E9B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadDisplayInfoRequest()
		{
		}

		// Token: 0x060140F2 RID: 82162 RVA: 0x002EB91A File Offset: 0x002E9B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadDisplayInfoRequest(ReadDisplayInfoRequest other) : this()
		{
			this.displayId_ = other.displayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060140F3 RID: 82163 RVA: 0x002EB93F File Offset: 0x002E9B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadDisplayInfoRequest Clone()
		{
			return new ReadDisplayInfoRequest(this);
		}

		// Token: 0x170042B9 RID: 17081
		// (get) Token: 0x060140F4 RID: 82164 RVA: 0x002EB947 File Offset: 0x002E9B47
		// (set) Token: 0x060140F5 RID: 82165 RVA: 0x002EB94F File Offset: 0x002E9B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DisplayId
		{
			get
			{
				return this.displayId_;
			}
			set
			{
				this.displayId_ = value;
			}
		}

		// Token: 0x060140F6 RID: 82166 RVA: 0x002EB958 File Offset: 0x002E9B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReadDisplayInfoRequest);
		}

		// Token: 0x060140F7 RID: 82167 RVA: 0x002EB966 File Offset: 0x002E9B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReadDisplayInfoRequest other)
		{
			return other != null && (other == this || (this.DisplayId == other.DisplayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060140F8 RID: 82168 RVA: 0x002EB994 File Offset: 0x002E9B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DisplayId != 0)
			{
				num ^= this.DisplayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060140F9 RID: 82169 RVA: 0x002EB9D3 File Offset: 0x002E9BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060140FA RID: 82170 RVA: 0x002EB9E0 File Offset: 0x002E9BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060140FB RID: 82171 RVA: 0x002EB9E9 File Offset: 0x002E9BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DisplayId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.DisplayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060140FC RID: 82172 RVA: 0x002EBA1C File Offset: 0x002E9C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DisplayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DisplayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060140FD RID: 82173 RVA: 0x002EBA5A File Offset: 0x002E9C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReadDisplayInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DisplayId != 0)
			{
				this.DisplayId = other.DisplayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060140FE RID: 82174 RVA: 0x002EBA8B File Offset: 0x002E9C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060140FF RID: 82175 RVA: 0x002EBA94 File Offset: 0x002E9C94
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DisplayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007A5A RID: 31322
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A5B RID: 31323
		public const int DisplayIdFieldNumber = 6;

		// Token: 0x04007A5C RID: 31324
		private int displayId_;
	}
}

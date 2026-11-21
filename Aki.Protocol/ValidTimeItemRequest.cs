using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001538 RID: 5432
	[NetMessage(EMessageId.ValidTimeItemRequest)]
	public sealed class ValidTimeItemRequest : IMessage<ValidTimeItemRequest>, IMessage, IEquatable<ValidTimeItemRequest>, IDeepCloneable<ValidTimeItemRequest>, IBufferMessage
	{
		// Token: 0x0601CC64 RID: 117860 RVA: 0x0042B9B1 File Offset: 0x00429BB1
		[NullableContext(1)]
		public static ValidTimeItemRequest Create()
		{
			return new ValidTimeItemRequest();
		}

		// Token: 0x17006158 RID: 24920
		// (get) Token: 0x0601CC65 RID: 117861 RVA: 0x0042B9B8 File Offset: 0x00429BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006159 RID: 24921
		// (get) Token: 0x0601CC66 RID: 117862 RVA: 0x0042B9BB File Offset: 0x00429BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ValidTimeItemRequest.Descriptor;
			}
		}

		// Token: 0x0601CC67 RID: 117863 RVA: 0x0042B9C2 File Offset: 0x00429BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemRequest()
		{
		}

		// Token: 0x0601CC68 RID: 117864 RVA: 0x0042B9CA File Offset: 0x00429BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemRequest(ValidTimeItemRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CC69 RID: 117865 RVA: 0x0042B9E3 File Offset: 0x00429BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemRequest Clone()
		{
			return new ValidTimeItemRequest(this);
		}

		// Token: 0x0601CC6A RID: 117866 RVA: 0x0042B9EB File Offset: 0x00429BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ValidTimeItemRequest);
		}

		// Token: 0x0601CC6B RID: 117867 RVA: 0x0042B9F9 File Offset: 0x00429BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ValidTimeItemRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601CC6C RID: 117868 RVA: 0x0042BA18 File Offset: 0x00429C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CC6D RID: 117869 RVA: 0x0042BA3E File Offset: 0x00429C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CC6E RID: 117870 RVA: 0x0042BA4B File Offset: 0x00429C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CC6F RID: 117871 RVA: 0x0042BA54 File Offset: 0x00429C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CC70 RID: 117872 RVA: 0x0042BA6C File Offset: 0x00429C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CC71 RID: 117873 RVA: 0x0042BA92 File Offset: 0x00429C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ValidTimeItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CC72 RID: 117874 RVA: 0x0042BAAF File Offset: 0x00429CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CC73 RID: 117875 RVA: 0x0042BAB8 File Offset: 0x00429CB8
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A5AF RID: 42415
		private UnknownFieldSet _unknownFields;
	}
}

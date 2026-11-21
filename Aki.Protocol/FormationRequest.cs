using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200061B RID: 1563
	[NetMessage(EMessageId.FormationRequest)]
	public sealed class FormationRequest : IMessage<FormationRequest>, IMessage, IEquatable<FormationRequest>, IDeepCloneable<FormationRequest>, IBufferMessage
	{
		// Token: 0x06009099 RID: 37017 RVA: 0x0015E737 File Offset: 0x0015C937
		[NullableContext(1)]
		public static FormationRequest Create()
		{
			return new FormationRequest();
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x0600909A RID: 37018 RVA: 0x0015E73E File Offset: 0x0015C93E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x0600909B RID: 37019 RVA: 0x0015E741 File Offset: 0x0015C941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationRequest.Descriptor;
			}
		}

		// Token: 0x0600909C RID: 37020 RVA: 0x0015E748 File Offset: 0x0015C948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationRequest()
		{
		}

		// Token: 0x0600909D RID: 37021 RVA: 0x0015E750 File Offset: 0x0015C950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationRequest(FormationRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600909E RID: 37022 RVA: 0x0015E769 File Offset: 0x0015C969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationRequest Clone()
		{
			return new FormationRequest(this);
		}

		// Token: 0x0600909F RID: 37023 RVA: 0x0015E771 File Offset: 0x0015C971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationRequest);
		}

		// Token: 0x060090A0 RID: 37024 RVA: 0x0015E77F File Offset: 0x0015C97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060090A1 RID: 37025 RVA: 0x0015E7A0 File Offset: 0x0015C9A0
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

		// Token: 0x060090A2 RID: 37026 RVA: 0x0015E7C6 File Offset: 0x0015C9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060090A3 RID: 37027 RVA: 0x0015E7D3 File Offset: 0x0015C9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090A4 RID: 37028 RVA: 0x0015E7DC File Offset: 0x0015C9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060090A5 RID: 37029 RVA: 0x0015E7F4 File Offset: 0x0015C9F4
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

		// Token: 0x060090A6 RID: 37030 RVA: 0x0015E81A File Offset: 0x0015CA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060090A7 RID: 37031 RVA: 0x0015E837 File Offset: 0x0015CA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060090A8 RID: 37032 RVA: 0x0015E840 File Offset: 0x0015CA40
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

		// Token: 0x04004665 RID: 18021
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200061F RID: 1567
	[NetMessage(EMessageId.ForgeInfoRequest)]
	public sealed class ForgeInfoRequest : IMessage<ForgeInfoRequest>, IMessage, IEquatable<ForgeInfoRequest>, IDeepCloneable<ForgeInfoRequest>, IBufferMessage
	{
		// Token: 0x06009099 RID: 37017 RVA: 0x0015DFD8 File Offset: 0x0015C1D8
		[NullableContext(1)]
		public static ForgeInfoRequest Create()
		{
			return new ForgeInfoRequest();
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x0600909A RID: 37018 RVA: 0x0015DFDF File Offset: 0x0015C1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x0600909B RID: 37019 RVA: 0x0015DFE2 File Offset: 0x0015C1E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600909C RID: 37020 RVA: 0x0015DFE9 File Offset: 0x0015C1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeInfoRequest()
		{
		}

		// Token: 0x0600909D RID: 37021 RVA: 0x0015DFF1 File Offset: 0x0015C1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeInfoRequest(ForgeInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600909E RID: 37022 RVA: 0x0015E00A File Offset: 0x0015C20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeInfoRequest Clone()
		{
			return new ForgeInfoRequest(this);
		}

		// Token: 0x0600909F RID: 37023 RVA: 0x0015E012 File Offset: 0x0015C212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeInfoRequest);
		}

		// Token: 0x060090A0 RID: 37024 RVA: 0x0015E020 File Offset: 0x0015C220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060090A1 RID: 37025 RVA: 0x0015E040 File Offset: 0x0015C240
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

		// Token: 0x060090A2 RID: 37026 RVA: 0x0015E066 File Offset: 0x0015C266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060090A3 RID: 37027 RVA: 0x0015E073 File Offset: 0x0015C273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090A4 RID: 37028 RVA: 0x0015E07C File Offset: 0x0015C27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060090A5 RID: 37029 RVA: 0x0015E094 File Offset: 0x0015C294
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

		// Token: 0x060090A6 RID: 37030 RVA: 0x0015E0BA File Offset: 0x0015C2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ForgeInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060090A7 RID: 37031 RVA: 0x0015E0D7 File Offset: 0x0015C2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060090A8 RID: 37032 RVA: 0x0015E0E0 File Offset: 0x0015C2E0
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

		// Token: 0x040045F8 RID: 17912
		private UnknownFieldSet _unknownFields;
	}
}

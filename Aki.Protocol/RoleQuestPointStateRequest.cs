using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001093 RID: 4243
	[NetMessage(EMessageId.RoleQuestPointStateRequest)]
	public sealed class RoleQuestPointStateRequest : IMessage<RoleQuestPointStateRequest>, IMessage, IEquatable<RoleQuestPointStateRequest>, IDeepCloneable<RoleQuestPointStateRequest>, IBufferMessage
	{
		// Token: 0x06016B05 RID: 92933 RVA: 0x0034CB7D File Offset: 0x0034AD7D
		[NullableContext(1)]
		public static RoleQuestPointStateRequest Create()
		{
			return new RoleQuestPointStateRequest();
		}

		// Token: 0x17004C0A RID: 19466
		// (get) Token: 0x06016B06 RID: 92934 RVA: 0x0034CB84 File Offset: 0x0034AD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C0B RID: 19467
		// (get) Token: 0x06016B07 RID: 92935 RVA: 0x0034CB87 File Offset: 0x0034AD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleQuestPointStateRequest.Descriptor;
			}
		}

		// Token: 0x06016B08 RID: 92936 RVA: 0x0034CB8E File Offset: 0x0034AD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestPointStateRequest()
		{
		}

		// Token: 0x06016B09 RID: 92937 RVA: 0x0034CB96 File Offset: 0x0034AD96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestPointStateRequest(RoleQuestPointStateRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016B0A RID: 92938 RVA: 0x0034CBAF File Offset: 0x0034ADAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestPointStateRequest Clone()
		{
			return new RoleQuestPointStateRequest(this);
		}

		// Token: 0x06016B0B RID: 92939 RVA: 0x0034CBB7 File Offset: 0x0034ADB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleQuestPointStateRequest);
		}

		// Token: 0x06016B0C RID: 92940 RVA: 0x0034CBC5 File Offset: 0x0034ADC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleQuestPointStateRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016B0D RID: 92941 RVA: 0x0034CBE4 File Offset: 0x0034ADE4
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

		// Token: 0x06016B0E RID: 92942 RVA: 0x0034CC0A File Offset: 0x0034AE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B0F RID: 92943 RVA: 0x0034CC17 File Offset: 0x0034AE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B10 RID: 92944 RVA: 0x0034CC20 File Offset: 0x0034AE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016B11 RID: 92945 RVA: 0x0034CC38 File Offset: 0x0034AE38
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

		// Token: 0x06016B12 RID: 92946 RVA: 0x0034CC5E File Offset: 0x0034AE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleQuestPointStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016B13 RID: 92947 RVA: 0x0034CC7B File Offset: 0x0034AE7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B14 RID: 92948 RVA: 0x0034CC84 File Offset: 0x0034AE84
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

		// Token: 0x040087FE RID: 34814
		private UnknownFieldSet _unknownFields;
	}
}

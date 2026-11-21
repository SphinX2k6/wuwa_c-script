using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003FC RID: 1020
	[NetMessage(EMessageId.DrownEndTeleportRequest)]
	public sealed class DrownEndTeleportRequest : IMessage<DrownEndTeleportRequest>, IMessage, IEquatable<DrownEndTeleportRequest>, IDeepCloneable<DrownEndTeleportRequest>, IBufferMessage
	{
		// Token: 0x060062D8 RID: 25304 RVA: 0x000EE0FC File Offset: 0x000EC2FC
		[NullableContext(1)]
		public static DrownEndTeleportRequest Create()
		{
			return new DrownEndTeleportRequest();
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x060062D9 RID: 25305 RVA: 0x000EE103 File Offset: 0x000EC303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x060062DA RID: 25306 RVA: 0x000EE106 File Offset: 0x000EC306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownEndTeleportRequest.Descriptor;
			}
		}

		// Token: 0x060062DB RID: 25307 RVA: 0x000EE10D File Offset: 0x000EC30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportRequest()
		{
		}

		// Token: 0x060062DC RID: 25308 RVA: 0x000EE115 File Offset: 0x000EC315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportRequest(DrownEndTeleportRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062DD RID: 25309 RVA: 0x000EE12E File Offset: 0x000EC32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportRequest Clone()
		{
			return new DrownEndTeleportRequest(this);
		}

		// Token: 0x060062DE RID: 25310 RVA: 0x000EE136 File Offset: 0x000EC336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownEndTeleportRequest);
		}

		// Token: 0x060062DF RID: 25311 RVA: 0x000EE144 File Offset: 0x000EC344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownEndTeleportRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x000EE164 File Offset: 0x000EC364
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

		// Token: 0x060062E1 RID: 25313 RVA: 0x000EE18A File Offset: 0x000EC38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x000EE197 File Offset: 0x000EC397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062E3 RID: 25315 RVA: 0x000EE1A0 File Offset: 0x000EC3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x000EE1B8 File Offset: 0x000EC3B8
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

		// Token: 0x060062E5 RID: 25317 RVA: 0x000EE1DE File Offset: 0x000EC3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownEndTeleportRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060062E6 RID: 25318 RVA: 0x000EE1FB File Offset: 0x000EC3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062E7 RID: 25319 RVA: 0x000EE204 File Offset: 0x000EC404
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

		// Token: 0x04003853 RID: 14419
		private UnknownFieldSet _unknownFields;
	}
}

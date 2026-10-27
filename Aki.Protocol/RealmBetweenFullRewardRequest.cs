using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E9B RID: 3739
	[NetMessage(EMessageId.RealmBetweenFullRewardRequest)]
	public sealed class RealmBetweenFullRewardRequest : IMessage<RealmBetweenFullRewardRequest>, IMessage, IEquatable<RealmBetweenFullRewardRequest>, IDeepCloneable<RealmBetweenFullRewardRequest>, IBufferMessage
	{
		// Token: 0x0601412B RID: 82219 RVA: 0x002EC20D File Offset: 0x002EA40D
		[NullableContext(1)]
		public static RealmBetweenFullRewardRequest Create()
		{
			return new RealmBetweenFullRewardRequest();
		}

		// Token: 0x170042C5 RID: 17093
		// (get) Token: 0x0601412C RID: 82220 RVA: 0x002EC214 File Offset: 0x002EA414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042C6 RID: 17094
		// (get) Token: 0x0601412D RID: 82221 RVA: 0x002EC217 File Offset: 0x002EA417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenFullRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601412E RID: 82222 RVA: 0x002EC21E File Offset: 0x002EA41E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenFullRewardRequest()
		{
		}

		// Token: 0x0601412F RID: 82223 RVA: 0x002EC226 File Offset: 0x002EA426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenFullRewardRequest(RealmBetweenFullRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014130 RID: 82224 RVA: 0x002EC23F File Offset: 0x002EA43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenFullRewardRequest Clone()
		{
			return new RealmBetweenFullRewardRequest(this);
		}

		// Token: 0x06014131 RID: 82225 RVA: 0x002EC247 File Offset: 0x002EA447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenFullRewardRequest);
		}

		// Token: 0x06014132 RID: 82226 RVA: 0x002EC255 File Offset: 0x002EA455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenFullRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06014133 RID: 82227 RVA: 0x002EC274 File Offset: 0x002EA474
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

		// Token: 0x06014134 RID: 82228 RVA: 0x002EC29A File Offset: 0x002EA49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014135 RID: 82229 RVA: 0x002EC2A7 File Offset: 0x002EA4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014136 RID: 82230 RVA: 0x002EC2B0 File Offset: 0x002EA4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014137 RID: 82231 RVA: 0x002EC2C8 File Offset: 0x002EA4C8
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

		// Token: 0x06014138 RID: 82232 RVA: 0x002EC2EE File Offset: 0x002EA4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenFullRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014139 RID: 82233 RVA: 0x002EC30B File Offset: 0x002EA50B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601413A RID: 82234 RVA: 0x002EC314 File Offset: 0x002EA514
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

		// Token: 0x04007A71 RID: 31345
		private UnknownFieldSet _unknownFields;
	}
}

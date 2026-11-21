using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E8 RID: 2024
	[NetMessage(EMessageId.InfrV2LevelUpRequest)]
	public sealed class InfrV2LevelUpRequest : IMessage<InfrV2LevelUpRequest>, IMessage, IEquatable<InfrV2LevelUpRequest>, IDeepCloneable<InfrV2LevelUpRequest>, IBufferMessage
	{
		// Token: 0x0600B5C4 RID: 46532 RVA: 0x001B223B File Offset: 0x001B043B
		[NullableContext(1)]
		public static InfrV2LevelUpRequest Create()
		{
			return new InfrV2LevelUpRequest();
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x0600B5C5 RID: 46533 RVA: 0x001B2242 File Offset: 0x001B0442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x0600B5C6 RID: 46534 RVA: 0x001B2245 File Offset: 0x001B0445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2LevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0600B5C7 RID: 46535 RVA: 0x001B224C File Offset: 0x001B044C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2LevelUpRequest()
		{
		}

		// Token: 0x0600B5C8 RID: 46536 RVA: 0x001B2254 File Offset: 0x001B0454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2LevelUpRequest(InfrV2LevelUpRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5C9 RID: 46537 RVA: 0x001B226D File Offset: 0x001B046D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2LevelUpRequest Clone()
		{
			return new InfrV2LevelUpRequest(this);
		}

		// Token: 0x0600B5CA RID: 46538 RVA: 0x001B2275 File Offset: 0x001B0475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2LevelUpRequest);
		}

		// Token: 0x0600B5CB RID: 46539 RVA: 0x001B2283 File Offset: 0x001B0483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2LevelUpRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B5CC RID: 46540 RVA: 0x001B22A4 File Offset: 0x001B04A4
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

		// Token: 0x0600B5CD RID: 46541 RVA: 0x001B22CA File Offset: 0x001B04CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B5CE RID: 46542 RVA: 0x001B22D7 File Offset: 0x001B04D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5CF RID: 46543 RVA: 0x001B22E0 File Offset: 0x001B04E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B5D0 RID: 46544 RVA: 0x001B22F8 File Offset: 0x001B04F8
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

		// Token: 0x0600B5D1 RID: 46545 RVA: 0x001B231E File Offset: 0x001B051E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2LevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B5D2 RID: 46546 RVA: 0x001B233B File Offset: 0x001B053B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5D3 RID: 46547 RVA: 0x001B2344 File Offset: 0x001B0544
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

		// Token: 0x040050E8 RID: 20712
		private UnknownFieldSet _unknownFields;
	}
}

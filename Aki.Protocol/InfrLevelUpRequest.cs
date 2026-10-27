using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E0 RID: 2016
	[NetMessage(EMessageId.InfrLevelUpRequest)]
	public sealed class InfrLevelUpRequest : IMessage<InfrLevelUpRequest>, IMessage, IEquatable<InfrLevelUpRequest>, IDeepCloneable<InfrLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0600B4FA RID: 46330 RVA: 0x001B077B File Offset: 0x001AE97B
		[NullableContext(1)]
		public static InfrLevelUpRequest Create()
		{
			return new InfrLevelUpRequest();
		}

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x0600B4FB RID: 46331 RVA: 0x001B0782 File Offset: 0x001AE982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002480 RID: 9344
		// (get) Token: 0x0600B4FC RID: 46332 RVA: 0x001B0785 File Offset: 0x001AE985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0600B4FD RID: 46333 RVA: 0x001B078C File Offset: 0x001AE98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLevelUpRequest()
		{
		}

		// Token: 0x0600B4FE RID: 46334 RVA: 0x001B0794 File Offset: 0x001AE994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLevelUpRequest(InfrLevelUpRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x001B07AD File Offset: 0x001AE9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLevelUpRequest Clone()
		{
			return new InfrLevelUpRequest(this);
		}

		// Token: 0x0600B500 RID: 46336 RVA: 0x001B07B5 File Offset: 0x001AE9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrLevelUpRequest);
		}

		// Token: 0x0600B501 RID: 46337 RVA: 0x001B07C3 File Offset: 0x001AE9C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrLevelUpRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B502 RID: 46338 RVA: 0x001B07E4 File Offset: 0x001AE9E4
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

		// Token: 0x0600B503 RID: 46339 RVA: 0x001B080A File Offset: 0x001AEA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B504 RID: 46340 RVA: 0x001B0817 File Offset: 0x001AEA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B505 RID: 46341 RVA: 0x001B0820 File Offset: 0x001AEA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B506 RID: 46342 RVA: 0x001B0838 File Offset: 0x001AEA38
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

		// Token: 0x0600B507 RID: 46343 RVA: 0x001B085E File Offset: 0x001AEA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B508 RID: 46344 RVA: 0x001B087B File Offset: 0x001AEA7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B509 RID: 46345 RVA: 0x001B0884 File Offset: 0x001AEA84
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

		// Token: 0x04005069 RID: 20585
		private UnknownFieldSet _unknownFields;
	}
}

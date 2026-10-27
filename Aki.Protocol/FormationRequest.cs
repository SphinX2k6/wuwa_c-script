using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200062F RID: 1583
	[NetMessage(EMessageId.FormationRequest)]
	public sealed class FormationRequest : IMessage<FormationRequest>, IMessage, IEquatable<FormationRequest>, IDeepCloneable<FormationRequest>, IBufferMessage
	{
		// Token: 0x060091EF RID: 37359 RVA: 0x00161167 File Offset: 0x0015F367
		[NullableContext(1)]
		public static FormationRequest Create()
		{
			return new FormationRequest();
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x060091F0 RID: 37360 RVA: 0x0016116E File Offset: 0x0015F36E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x060091F1 RID: 37361 RVA: 0x00161171 File Offset: 0x0015F371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationRequest.Descriptor;
			}
		}

		// Token: 0x060091F2 RID: 37362 RVA: 0x00161178 File Offset: 0x0015F378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationRequest()
		{
		}

		// Token: 0x060091F3 RID: 37363 RVA: 0x00161180 File Offset: 0x0015F380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationRequest(FormationRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091F4 RID: 37364 RVA: 0x00161199 File Offset: 0x0015F399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationRequest Clone()
		{
			return new FormationRequest(this);
		}

		// Token: 0x060091F5 RID: 37365 RVA: 0x001611A1 File Offset: 0x0015F3A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationRequest);
		}

		// Token: 0x060091F6 RID: 37366 RVA: 0x001611AF File Offset: 0x0015F3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060091F7 RID: 37367 RVA: 0x001611D0 File Offset: 0x0015F3D0
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

		// Token: 0x060091F8 RID: 37368 RVA: 0x001611F6 File Offset: 0x0015F3F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060091F9 RID: 37369 RVA: 0x00161203 File Offset: 0x0015F403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091FA RID: 37370 RVA: 0x0016120C File Offset: 0x0015F40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091FB RID: 37371 RVA: 0x00161224 File Offset: 0x0015F424
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

		// Token: 0x060091FC RID: 37372 RVA: 0x0016124A File Offset: 0x0015F44A
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

		// Token: 0x060091FD RID: 37373 RVA: 0x00161267 File Offset: 0x0015F467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091FE RID: 37374 RVA: 0x00161270 File Offset: 0x0015F470
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

		// Token: 0x0400466C RID: 18028
		private UnknownFieldSet _unknownFields;
	}
}

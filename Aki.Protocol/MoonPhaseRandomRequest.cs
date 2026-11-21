using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009FF RID: 2559
	[NetMessage(EMessageId.MoonPhaseRandomRequest)]
	public sealed class MoonPhaseRandomRequest : IMessage<MoonPhaseRandomRequest>, IMessage, IEquatable<MoonPhaseRandomRequest>, IDeepCloneable<MoonPhaseRandomRequest>, IBufferMessage
	{
		// Token: 0x0600E044 RID: 57412 RVA: 0x0020E1DF File Offset: 0x0020C3DF
		[NullableContext(1)]
		public static MoonPhaseRandomRequest Create()
		{
			return new MoonPhaseRandomRequest();
		}

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x0600E045 RID: 57413 RVA: 0x0020E1E6 File Offset: 0x0020C3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x0600E046 RID: 57414 RVA: 0x0020E1E9 File Offset: 0x0020C3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoonPhaseRandomRequest.Descriptor;
			}
		}

		// Token: 0x0600E047 RID: 57415 RVA: 0x0020E1F0 File Offset: 0x0020C3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRandomRequest()
		{
		}

		// Token: 0x0600E048 RID: 57416 RVA: 0x0020E1F8 File Offset: 0x0020C3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRandomRequest(MoonPhaseRandomRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E049 RID: 57417 RVA: 0x0020E211 File Offset: 0x0020C411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRandomRequest Clone()
		{
			return new MoonPhaseRandomRequest(this);
		}

		// Token: 0x0600E04A RID: 57418 RVA: 0x0020E219 File Offset: 0x0020C419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoonPhaseRandomRequest);
		}

		// Token: 0x0600E04B RID: 57419 RVA: 0x0020E227 File Offset: 0x0020C427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoonPhaseRandomRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E04C RID: 57420 RVA: 0x0020E248 File Offset: 0x0020C448
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

		// Token: 0x0600E04D RID: 57421 RVA: 0x0020E26E File Offset: 0x0020C46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E04E RID: 57422 RVA: 0x0020E27B File Offset: 0x0020C47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E04F RID: 57423 RVA: 0x0020E284 File Offset: 0x0020C484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E050 RID: 57424 RVA: 0x0020E29C File Offset: 0x0020C49C
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

		// Token: 0x0600E051 RID: 57425 RVA: 0x0020E2C2 File Offset: 0x0020C4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoonPhaseRandomRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E052 RID: 57426 RVA: 0x0020E2DF File Offset: 0x0020C4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E053 RID: 57427 RVA: 0x0020E2E8 File Offset: 0x0020C4E8
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

		// Token: 0x04005CB0 RID: 23728
		private UnknownFieldSet _unknownFields;
	}
}

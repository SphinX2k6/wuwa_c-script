using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A01 RID: 2561
	[NetMessage(EMessageId.MoonPhaseRewardRequest)]
	public sealed class MoonPhaseRewardRequest : IMessage<MoonPhaseRewardRequest>, IMessage, IEquatable<MoonPhaseRewardRequest>, IDeepCloneable<MoonPhaseRewardRequest>, IBufferMessage
	{
		// Token: 0x0600E068 RID: 57448 RVA: 0x0020E60F File Offset: 0x0020C80F
		[NullableContext(1)]
		public static MoonPhaseRewardRequest Create()
		{
			return new MoonPhaseRewardRequest();
		}

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x0600E069 RID: 57449 RVA: 0x0020E616 File Offset: 0x0020C816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x0600E06A RID: 57450 RVA: 0x0020E619 File Offset: 0x0020C819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoonPhaseRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600E06B RID: 57451 RVA: 0x0020E620 File Offset: 0x0020C820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRewardRequest()
		{
		}

		// Token: 0x0600E06C RID: 57452 RVA: 0x0020E628 File Offset: 0x0020C828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRewardRequest(MoonPhaseRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E06D RID: 57453 RVA: 0x0020E641 File Offset: 0x0020C841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRewardRequest Clone()
		{
			return new MoonPhaseRewardRequest(this);
		}

		// Token: 0x0600E06E RID: 57454 RVA: 0x0020E649 File Offset: 0x0020C849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoonPhaseRewardRequest);
		}

		// Token: 0x0600E06F RID: 57455 RVA: 0x0020E657 File Offset: 0x0020C857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoonPhaseRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E070 RID: 57456 RVA: 0x0020E678 File Offset: 0x0020C878
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

		// Token: 0x0600E071 RID: 57457 RVA: 0x0020E69E File Offset: 0x0020C89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E072 RID: 57458 RVA: 0x0020E6AB File Offset: 0x0020C8AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E073 RID: 57459 RVA: 0x0020E6B4 File Offset: 0x0020C8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E074 RID: 57460 RVA: 0x0020E6CC File Offset: 0x0020C8CC
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

		// Token: 0x0600E075 RID: 57461 RVA: 0x0020E6F2 File Offset: 0x0020C8F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoonPhaseRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E076 RID: 57462 RVA: 0x0020E70F File Offset: 0x0020C90F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E077 RID: 57463 RVA: 0x0020E718 File Offset: 0x0020C918
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

		// Token: 0x04005CB6 RID: 23734
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A09 RID: 2569
	[NetMessage(EMessageId.MontagePlayRequest)]
	public sealed class MontagePlayRequest : IMessage<MontagePlayRequest>, IMessage, IEquatable<MontagePlayRequest>, IDeepCloneable<MontagePlayRequest>, IBufferMessage
	{
		// Token: 0x0600E0C8 RID: 57544 RVA: 0x0020EE18 File Offset: 0x0020D018
		[NullableContext(1)]
		public static MontagePlayRequest Create()
		{
			return new MontagePlayRequest();
		}

		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x0600E0C9 RID: 57545 RVA: 0x0020EE1F File Offset: 0x0020D01F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x0600E0CA RID: 57546 RVA: 0x0020EE22 File Offset: 0x0020D022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MontagePlayRequest.Descriptor;
			}
		}

		// Token: 0x0600E0CB RID: 57547 RVA: 0x0020EE29 File Offset: 0x0020D029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayRequest()
		{
		}

		// Token: 0x0600E0CC RID: 57548 RVA: 0x0020EE31 File Offset: 0x0020D031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayRequest(MontagePlayRequest other) : this()
		{
			this.montageIndex_ = other.montageIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E0CD RID: 57549 RVA: 0x0020EE56 File Offset: 0x0020D056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayRequest Clone()
		{
			return new MontagePlayRequest(this);
		}

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x0600E0CE RID: 57550 RVA: 0x0020EE5E File Offset: 0x0020D05E
		// (set) Token: 0x0600E0CF RID: 57551 RVA: 0x0020EE66 File Offset: 0x0020D066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MontageIndex
		{
			get
			{
				return this.montageIndex_;
			}
			set
			{
				this.montageIndex_ = value;
			}
		}

		// Token: 0x0600E0D0 RID: 57552 RVA: 0x0020EE6F File Offset: 0x0020D06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MontagePlayRequest);
		}

		// Token: 0x0600E0D1 RID: 57553 RVA: 0x0020EE7D File Offset: 0x0020D07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MontagePlayRequest other)
		{
			return other != null && (other == this || (this.MontageIndex == other.MontageIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E0D2 RID: 57554 RVA: 0x0020EEAC File Offset: 0x0020D0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MontageIndex != 0)
			{
				num ^= this.MontageIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E0D3 RID: 57555 RVA: 0x0020EEEB File Offset: 0x0020D0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E0D4 RID: 57556 RVA: 0x0020EEF8 File Offset: 0x0020D0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E0D5 RID: 57557 RVA: 0x0020EF01 File Offset: 0x0020D101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MontageIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E0D6 RID: 57558 RVA: 0x0020EF34 File Offset: 0x0020D134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MontageIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MontageIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E0D7 RID: 57559 RVA: 0x0020EF72 File Offset: 0x0020D172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MontagePlayRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MontageIndex != 0)
			{
				this.MontageIndex = other.MontageIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E0D8 RID: 57560 RVA: 0x0020EFA3 File Offset: 0x0020D1A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0D9 RID: 57561 RVA: 0x0020EFAC File Offset: 0x0020D1AC
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MontageIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C79 RID: 23673
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C7A RID: 23674
		public const int MontageIndexFieldNumber = 7;

		// Token: 0x04005C7B RID: 23675
		private int montageIndex_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200055B RID: 1371
	[NetMessage(EMessageId.FishingGhostStateNotify)]
	public sealed class FishingGhostStateNotify : IMessage<FishingGhostStateNotify>, IMessage, IEquatable<FishingGhostStateNotify>, IDeepCloneable<FishingGhostStateNotify>, IBufferMessage
	{
		// Token: 0x06007FE3 RID: 32739 RVA: 0x00134FF2 File Offset: 0x001331F2
		[NullableContext(1)]
		public static FishingGhostStateNotify Create()
		{
			return new FishingGhostStateNotify();
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x06007FE4 RID: 32740 RVA: 0x00134FF9 File Offset: 0x001331F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06007FE5 RID: 32741 RVA: 0x00134FFC File Offset: 0x001331FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingGhostStateNotify.Descriptor;
			}
		}

		// Token: 0x06007FE6 RID: 32742 RVA: 0x00135003 File Offset: 0x00133203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingGhostStateNotify()
		{
		}

		// Token: 0x06007FE7 RID: 32743 RVA: 0x0013500B File Offset: 0x0013320B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingGhostStateNotify(FishingGhostStateNotify other) : this()
		{
			this.open_ = other.open_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FE8 RID: 32744 RVA: 0x00135030 File Offset: 0x00133230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingGhostStateNotify Clone()
		{
			return new FishingGhostStateNotify(this);
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06007FE9 RID: 32745 RVA: 0x00135038 File Offset: 0x00133238
		// (set) Token: 0x06007FEA RID: 32746 RVA: 0x00135040 File Offset: 0x00133240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Open
		{
			get
			{
				return this.open_;
			}
			set
			{
				this.open_ = value;
			}
		}

		// Token: 0x06007FEB RID: 32747 RVA: 0x00135049 File Offset: 0x00133249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingGhostStateNotify);
		}

		// Token: 0x06007FEC RID: 32748 RVA: 0x00135057 File Offset: 0x00133257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingGhostStateNotify other)
		{
			return other != null && (other == this || (this.Open == other.Open && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007FED RID: 32749 RVA: 0x00135088 File Offset: 0x00133288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Open)
			{
				num ^= this.Open.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007FEE RID: 32750 RVA: 0x001350C7 File Offset: 0x001332C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007FEF RID: 32751 RVA: 0x001350D4 File Offset: 0x001332D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FF0 RID: 32752 RVA: 0x001350DD File Offset: 0x001332DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Open)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Open);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FF1 RID: 32753 RVA: 0x00135110 File Offset: 0x00133310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Open)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007FF2 RID: 32754 RVA: 0x00135142 File Offset: 0x00133342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingGhostStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Open)
			{
				this.Open = other.Open;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007FF3 RID: 32755 RVA: 0x00135173 File Offset: 0x00133373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FF4 RID: 32756 RVA: 0x0013517C File Offset: 0x0013337C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Open = input.ReadBool();
				}
			}
		}

		// Token: 0x04004076 RID: 16502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004077 RID: 16503
		public const int OpenFieldNumber = 6;

		// Token: 0x04004078 RID: 16504
		private bool open_;
	}
}

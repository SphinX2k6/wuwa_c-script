using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000834 RID: 2100
	public sealed class InteractProgress : IMessage<InteractProgress>, IMessage, IEquatable<InteractProgress>, IDeepCloneable<InteractProgress>, IBufferMessage
	{
		// Token: 0x0600BBA2 RID: 48034 RVA: 0x001BEDE0 File Offset: 0x001BCFE0
		[NullableContext(1)]
		public static InteractProgress Create()
		{
			return new InteractProgress();
		}

		// Token: 0x170025E4 RID: 9700
		// (get) Token: 0x0600BBA3 RID: 48035 RVA: 0x001BEDE7 File Offset: 0x001BCFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x0600BBA4 RID: 48036 RVA: 0x001BEDEA File Offset: 0x001BCFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractProgress.Descriptor;
			}
		}

		// Token: 0x0600BBA5 RID: 48037 RVA: 0x001BEDF1 File Offset: 0x001BCFF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractProgress()
		{
		}

		// Token: 0x0600BBA6 RID: 48038 RVA: 0x001BEE04 File Offset: 0x001BD004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractProgress(InteractProgress other) : this()
		{
			this.npcId_ = other.npcId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BBA7 RID: 48039 RVA: 0x001BEE2E File Offset: 0x001BD02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractProgress Clone()
		{
			return new InteractProgress(this);
		}

		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x0600BBA8 RID: 48040 RVA: 0x001BEE36 File Offset: 0x001BD036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NpcId
		{
			get
			{
				return this.npcId_;
			}
		}

		// Token: 0x0600BBA9 RID: 48041 RVA: 0x001BEE3E File Offset: 0x001BD03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractProgress);
		}

		// Token: 0x0600BBAA RID: 48042 RVA: 0x001BEE4C File Offset: 0x001BD04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractProgress other)
		{
			return other != null && (other == this || (this.npcId_.Equals(other.npcId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BBAB RID: 48043 RVA: 0x001BEE80 File Offset: 0x001BD080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.npcId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BBAC RID: 48044 RVA: 0x001BEEB4 File Offset: 0x001BD0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BBAD RID: 48045 RVA: 0x001BEEC1 File Offset: 0x001BD0C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BBAE RID: 48046 RVA: 0x001BEECA File Offset: 0x001BD0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.npcId_.WriteTo(ref output, InteractProgress._repeated_npcId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BBAF RID: 48047 RVA: 0x001BEEF4 File Offset: 0x001BD0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.npcId_.CalculateSize(InteractProgress._repeated_npcId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BBB0 RID: 48048 RVA: 0x001BEF2D File Offset: 0x001BD12D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractProgress other)
		{
			if (other == null)
			{
				return;
			}
			this.npcId_.Add(other.npcId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BBB1 RID: 48049 RVA: 0x001BEF5B File Offset: 0x001BD15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBB2 RID: 48050 RVA: 0x001BEF64 File Offset: 0x001BD164
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.npcId_.AddEntriesFrom(ref input, InteractProgress._repeated_npcId_codec);
				}
			}
		}

		// Token: 0x04005253 RID: 21075
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005254 RID: 21076
		public const int NpcIdFieldNumber = 1;

		// Token: 0x04005255 RID: 21077
		private static readonly FieldCodec<int> _repeated_npcId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04005256 RID: 21078
		private readonly RepeatedField<int> npcId_ = new RepeatedField<int>();
	}
}

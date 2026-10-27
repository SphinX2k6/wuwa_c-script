using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000379 RID: 889
	[NetMessage(EMessageId.DangoBrawlStartFightNotify)]
	public sealed class DangoBrawlStartFightNotify : IMessage<DangoBrawlStartFightNotify>, IMessage, IEquatable<DangoBrawlStartFightNotify>, IDeepCloneable<DangoBrawlStartFightNotify>, IBufferMessage
	{
		// Token: 0x06005840 RID: 22592 RVA: 0x000D74F2 File Offset: 0x000D56F2
		[NullableContext(1)]
		public static DangoBrawlStartFightNotify Create()
		{
			return new DangoBrawlStartFightNotify();
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06005841 RID: 22593 RVA: 0x000D74F9 File Offset: 0x000D56F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06005842 RID: 22594 RVA: 0x000D74FC File Offset: 0x000D56FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlStartFightNotify.Descriptor;
			}
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x000D7503 File Offset: 0x000D5703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightNotify()
		{
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x000D7516 File Offset: 0x000D5716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightNotify(DangoBrawlStartFightNotify other) : this()
		{
			this.fighters_ = other.fighters_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x000D7540 File Offset: 0x000D5740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightNotify Clone()
		{
			return new DangoBrawlStartFightNotify(this);
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06005846 RID: 22598 RVA: 0x000D7548 File Offset: 0x000D5748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlFighterInfo> Fighters
		{
			get
			{
				return this.fighters_;
			}
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x000D7550 File Offset: 0x000D5750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlStartFightNotify);
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x000D755E File Offset: 0x000D575E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlStartFightNotify other)
		{
			return other != null && (other == this || (this.fighters_.Equals(other.fighters_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x000D7594 File Offset: 0x000D5794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fighters_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x000D75C8 File Offset: 0x000D57C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x000D75D5 File Offset: 0x000D57D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x000D75DE File Offset: 0x000D57DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fighters_.WriteTo(ref output, DangoBrawlStartFightNotify._repeated_fighters_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x000D7608 File Offset: 0x000D5808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fighters_.CalculateSize(DangoBrawlStartFightNotify._repeated_fighters_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600584E RID: 22606 RVA: 0x000D7641 File Offset: 0x000D5841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlStartFightNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.fighters_.Add(other.fighters_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600584F RID: 22607 RVA: 0x000D766F File Offset: 0x000D586F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005850 RID: 22608 RVA: 0x000D7678 File Offset: 0x000D5878
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.fighters_.AddEntriesFrom(ref input, DangoBrawlStartFightNotify._repeated_fighters_codec);
				}
			}
		}

		// Token: 0x0400350A RID: 13578
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400350B RID: 13579
		public const int FightersFieldNumber = 7;

		// Token: 0x0400350C RID: 13580
		private static readonly FieldCodec<DangoBrawlFighterInfo> _repeated_fighters_codec = FieldCodec.ForMessage<DangoBrawlFighterInfo>(58U, DangoBrawlFighterInfo.Parser);

		// Token: 0x0400350D RID: 13581
		private readonly RepeatedField<DangoBrawlFighterInfo> fighters_ = new RepeatedField<DangoBrawlFighterInfo>();
	}
}

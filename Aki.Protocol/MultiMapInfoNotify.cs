using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD9 RID: 2777
	[NetMessage(EMessageId.MultiMapInfoNotify)]
	public sealed class MultiMapInfoNotify : IMessage<MultiMapInfoNotify>, IMessage, IEquatable<MultiMapInfoNotify>, IDeepCloneable<MultiMapInfoNotify>, IBufferMessage
	{
		// Token: 0x0600F1DB RID: 61915 RVA: 0x00235460 File Offset: 0x00233660
		[NullableContext(1)]
		public static MultiMapInfoNotify Create()
		{
			return new MultiMapInfoNotify();
		}

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x0600F1DC RID: 61916 RVA: 0x00235467 File Offset: 0x00233667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x0600F1DD RID: 61917 RVA: 0x0023546A File Offset: 0x0023366A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultiMapInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600F1DE RID: 61918 RVA: 0x00235471 File Offset: 0x00233671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiMapInfoNotify()
		{
		}

		// Token: 0x0600F1DF RID: 61919 RVA: 0x0023548F File Offset: 0x0023368F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiMapInfoNotify(MultiMapInfoNotify other) : this()
		{
			this.unlockMultiMapId_ = other.unlockMultiMapId_.Clone();
			this.unlockBlockId_ = other.unlockBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F1E0 RID: 61920 RVA: 0x002354CA File Offset: 0x002336CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiMapInfoNotify Clone()
		{
			return new MultiMapInfoNotify(this);
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x0600F1E1 RID: 61921 RVA: 0x002354D2 File Offset: 0x002336D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockMultiMapId
		{
			get
			{
				return this.unlockMultiMapId_;
			}
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x0600F1E2 RID: 61922 RVA: 0x002354DA File Offset: 0x002336DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBlockId
		{
			get
			{
				return this.unlockBlockId_;
			}
		}

		// Token: 0x0600F1E3 RID: 61923 RVA: 0x002354E2 File Offset: 0x002336E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultiMapInfoNotify);
		}

		// Token: 0x0600F1E4 RID: 61924 RVA: 0x002354F0 File Offset: 0x002336F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultiMapInfoNotify other)
		{
			return other != null && (other == this || (this.unlockMultiMapId_.Equals(other.unlockMultiMapId_) && this.unlockBlockId_.Equals(other.unlockBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F1E5 RID: 61925 RVA: 0x00235544 File Offset: 0x00233744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockMultiMapId_.GetHashCode();
			num ^= this.unlockBlockId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F1E6 RID: 61926 RVA: 0x00235586 File Offset: 0x00233786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F1E7 RID: 61927 RVA: 0x00235593 File Offset: 0x00233793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F1E8 RID: 61928 RVA: 0x0023559C File Offset: 0x0023379C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockMultiMapId_.WriteTo(ref output, MultiMapInfoNotify._repeated_unlockMultiMapId_codec);
			this.unlockBlockId_.WriteTo(ref output, MultiMapInfoNotify._repeated_unlockBlockId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F1E9 RID: 61929 RVA: 0x002355D4 File Offset: 0x002337D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockMultiMapId_.CalculateSize(MultiMapInfoNotify._repeated_unlockMultiMapId_codec);
			num += this.unlockBlockId_.CalculateSize(MultiMapInfoNotify._repeated_unlockBlockId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F1EA RID: 61930 RVA: 0x00235620 File Offset: 0x00233820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultiMapInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockMultiMapId_.Add(other.unlockMultiMapId_);
			this.unlockBlockId_.Add(other.unlockBlockId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F1EB RID: 61931 RVA: 0x0023565F File Offset: 0x0023385F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F1EC RID: 61932 RVA: 0x00235668 File Offset: 0x00233868
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
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.unlockMultiMapId_.AddEntriesFrom(ref input, MultiMapInfoNotify._repeated_unlockMultiMapId_codec);
						continue;
					}
				}
				else if (num == 96U || num == 98U)
				{
					this.unlockBlockId_.AddEntriesFrom(ref input, MultiMapInfoNotify._repeated_unlockBlockId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040061FD RID: 25085
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061FE RID: 25086
		public const int UnlockMultiMapIdFieldNumber = 3;

		// Token: 0x040061FF RID: 25087
		private static readonly FieldCodec<int> _repeated_unlockMultiMapId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006200 RID: 25088
		private readonly RepeatedField<int> unlockMultiMapId_ = new RepeatedField<int>();

		// Token: 0x04006201 RID: 25089
		public const int UnlockBlockIdFieldNumber = 12;

		// Token: 0x04006202 RID: 25090
		private static readonly FieldCodec<int> _repeated_unlockBlockId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04006203 RID: 25091
		private readonly RepeatedField<int> unlockBlockId_ = new RepeatedField<int>();
	}
}
